﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Threading;
using IBApi;
using Infra.Enum;
using log4net;
using log4net.Repository.Hierarchy;
using TNS.API.ApiDataObjects;

namespace TNS.API.IBApiWrapper
{
    public static class IBExtensions
    {
        private static readonly ILog Logger = LogManager.GetLogger(typeof(IBExtensions));
        public static ContractBase ToContract(this Contract contract)
        {
            switch (contract.SecType)
            {
                case "OPT":
                    // var EOptionType = contract.Right == "C" ? EOptionType.Call : EOptionType.Put;
                    EOptionType optionType;
                    switch (contract.Right)
                    {
                        case "C":
                            optionType = EOptionType.Call;
                            break;
                        case "P":
                            optionType = EOptionType.Put;
                            break;
                        default:
                            optionType = EOptionType.None;
                            break;
                    }
                    return new OptionContract(contract.Symbol, contract.Strike, GetExpiryDate(contract.Expiry), optionType,
                        contract.Exchange, Convert.ToInt32(contract.Multiplier), contract.Currency);
                case "STK":
                    return new SecurityContract(contract.Symbol, SecurityType.Stock);
                case "IND":
                    return new SecurityContract(contract.Symbol, SecurityType.Index);
                default:
                    throw new Exception("Invalid contract type received " +  contract.SecType);
            }
     }

        public static SecurityType ToSecurityType(string secType)
        {
            switch (secType)
            {
                case "OPT":
                    return SecurityType.Option;
                case "STK":
                    return SecurityType.Stock;
                case "IND":
                    return SecurityType.Option;
                default:
                    throw new Exception("Invalid contract type received " + secType);
            }
        }
      
        private static DateTime GetExpiryDate(string expDateStr)
        {
            if (string.IsNullOrEmpty(expDateStr))
                return DateTime.MinValue;
            DateTime expiryDate = DateTime.ParseExact(expDateStr, "yyyyMMdd", 
                        CultureInfo.CurrentCulture, DateTimeStyles.None);
            return expiryDate;
        }
        public static string GetSecType(SecurityType type)
        {
            switch (type)
            {
                case SecurityType.Stock:
                    return "STK";
                case SecurityType.Option:
                    return "OPT";
                case SecurityType.Index:
                    return "IND";
                default:
                    return string.Empty;
            }
        }
       
        public static Contract ToIbMainSecurityContract(this ContractBase msContract)
        {
            return new Contract
            {
                Symbol = msContract.Symbol,
                Currency = msContract.Currency,
                SecType = GetSecType(msContract.SecurityType),
                Exchange = msContract.Exchange
            };
        }
        public static Order ToIbOrder(this OrderData order, string mainAccount, string orderId)
        {
            var ibOrder = new Order
            {
                OrderId = Convert.ToInt32(orderId),
                Action = order.OrderAction == OrderAction.BUY ? "BUY" : "SELL",
                OrderType = order.OrderType.ToString().ToUpper(), //"LMT", MKT "MKT PRT" - not suported
                LmtPrice = order.LimitPrice,
                TotalQuantity = order.Quantity,
                Account = mainAccount,
                Tif = "DAY",
                Transmit = true,
                OrderRef = "IB-AutoTrader-Raz",
                WhatIf = order.WhatIf
            };
            return ibOrder;
            
        }

        public static OrderData ToOrderData(this Order order)
        {
            return new OrderData()
            {
                OrderType = (OrderType) Enum.Parse(typeof (OrderType), order.OrderType),
                OrderAction = (OrderAction) Enum.Parse(typeof (OrderAction), order.Action),
                LimitPrice = order.LmtPrice,
                Quantity = order.TotalQuantity,
                OrderId = order.OrderId.ToString(),
                WhatIf = order.WhatIf
            };
        }

        public static void UpdateSecurityData(this ContractDetails contractDetails, ContractBase securityContract)
        {
            //LiquidHours="20150427:0930-1600;20150428:0930-1600" 
            //"20090507:0700-1830,1830-2330;20090508:CLOSED." "20150503:CLOSED;20150504:0930-1600"
            //TimeZoneId="EST5EDT"
            if (contractDetails.Summary.SecType.Equals("OPT"))
                return;
            string liquidHoursStr = contractDetails.LiquidHours;
            if (string.IsNullOrEmpty(liquidHoursStr))
            {
                Debug.Assert(false, "Problem with AAPLContractDetailsData " +
                                    "liquidHoursStr is null or empty!");
            }
            //For testing only:
            //liquidHoursStr = "20150624:0141-0600;20150600:0930-1600";//For Testing only
            string[] workingDays = liquidHoursStr.Split(';');

            //Eastern Standard Time
            TimeZoneInfo ist = TimeZoneInfo.FindSystemTimeZoneById("Israel Standard Time");

            //Israel Standard Time
            TimeZoneInfo est = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");

            //Find next working day/time:
            var nextWorkingDayItem = -1;
            string closedStr = "CLOSED";
            while (closedStr == "CLOSED")
            {
                nextWorkingDayItem++;
                closedStr = workingDays[nextWorkingDayItem].Substring(9, 6);
            }
            string stringToParse = workingDays[nextWorkingDayItem];

            securityContract.NextWorkingTime = DateTime.ParseExact(
                stringToParse.Substring(0, 13), //Update securityContract object
                "yyyyMMdd:HHmm", CultureInfo.CurrentCulture, DateTimeStyles.None);

            securityContract.StartTradingTime = securityContract.NextWorkingTime;

            securityContract.StartTradingTimeLocal = TimeZoneInfo.ConvertTime //Update securityContract object
                (securityContract.StartTradingTime, est, ist);

            securityContract.NextWorkingTime = TimeZoneInfo.ConvertTime //Update securityContract object
                (securityContract.NextWorkingTime, est, ist);

            //handle the different time between local time and exchange time:
            securityContract.IsWorkingDay =
                securityContract.NextWorkingTime.Date == DateTime.Today; //Update securityContract object

            var endTimeStr = stringToParse.Substring(0, 8) + " " + stringToParse.Substring(14, 4);
            securityContract.EndTradingTime = DateTime.ParseExact(endTimeStr,
                "yyyyMMdd HHmm", //Update securityContract object
                CultureInfo.CurrentCulture, DateTimeStyles.None);
            securityContract.EndTradingTimeLocal = TimeZoneInfo.ConvertTime //Update securityContract object
                (securityContract.EndTradingTime, est, ist);

            var msg = securityContract.IsWorkingDay == false
                ? $"Today is not workingDay. NextWorkingTime={securityContract.NextWorkingTime}"
                : $"Today is workingDay! StartTradingTime={securityContract.StartTradingTimeLocal}, EndTradingTime:{securityContract.EndTradingTimeLocal}. ";

            Logger.Info(msg);
        }

        public static void UpdateSecurityDataOld(this ContractDetails contractDetails, ContractBase securityContract)
        {
        
            //LiquidHours="20150427:0930-1600;20150428:0930-1600" 
            //"20090507:0700-1830,1830-2330;20090508:CLOSED." "20150503:CLOSED;20150504:0930-1600"
            //TimeZoneId="EST5EDT"

            string liquidHoursStr = contractDetails.LiquidHours;
            if (string.IsNullOrEmpty(liquidHoursStr))
            {
                Debug.Assert(false, "Problem with AAPLContractDetailsData " + 
                    "liquidHoursStr is null or empty!");
            }
            //For testing only:
            //liquidHoursStr = "20150624:0141-0600;20150600:0930-1600";//For Testing only
            string[] workingDays = liquidHoursStr.Split(';');

            //Eastern Standard Time
            TimeZoneInfo ist = TimeZoneInfo.FindSystemTimeZoneById("Israel Standard Time");
            //Israel Standard Time
            TimeZoneInfo est = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");

            string closedStr = workingDays[0].Substring(9, 6);

            //Check for the case tommorow is holiday:
            string tommorowClosed = workingDays[1].Substring(9, 6);

            bool isTommorowHoliday = tommorowClosed.Equals("CLOSED");

            var nextDayItem = 1;
            if (isTommorowHoliday) nextDayItem = 3;//To be changed it's bug

            securityContract.NextWorkingTime = DateTime.ParseExact(workingDays[nextDayItem].Substring(0, 13),//Update securityContract object
                "yyyyMMdd:HHmm", CultureInfo.CurrentCulture, DateTimeStyles.None);

            securityContract.NextWorkingTime = TimeZoneInfo.ConvertTime//Update securityContract object
                (securityContract.NextWorkingTime, est, ist);
            //handle the different time between local time and exchange time:
            bool nextDayIsToday = securityContract.NextWorkingTime.Date == DateTime.Today;
            securityContract.IsWorkingDay = ((closedStr.Equals("CLOSED") == false) || (nextDayIsToday));//Update securityContract object

            string msg;
            if (securityContract.IsWorkingDay == false)
            {
                msg = string.Format("Today is not workingDay. NextWorkingTime={0}",
                    securityContract.NextWorkingTime);
                Logger.Info(msg);
                return;
            }

            var stringToParse = nextDayIsToday ? workingDays[1] : workingDays[0];

            securityContract.StartTradingTime = DateTime.ParseExact(stringToParse.Substring(0, 13),//Update securityContract object
                "yyyyMMdd:HHmm",CultureInfo.CurrentCulture, DateTimeStyles.None);

            securityContract.StartTradingTimeLocal = TimeZoneInfo.ConvertTime //Update securityContract object
                (securityContract.StartTradingTime, est, ist);
            //For Test:  StartTradingTimeLocal = DateTime.Now.AddMinutes(1);
            string endTimeStr = stringToParse.Substring(0, 8) + " " + stringToParse.Substring(14, 4);
            securityContract.EndTradingTime = DateTime.ParseExact(endTimeStr, "yyyyMMdd HHmm",//Update securityContract object
                CultureInfo.CurrentCulture, DateTimeStyles.None);
            securityContract.EndTradingTimeLocal = TimeZoneInfo.ConvertTime//Update securityContract object
                (securityContract.EndTradingTime, est, ist);

            //For Testing: securityContract.StartTradingTimeLocal = DateTime.Now.AddMinutes(1);
            //For Testing: securityContract.EndTradingTimeLocal = DateTime.Now.AddMinutes(3);

            msg =
                $"Today is workingDay! StartTradingTime={securityContract.StartTradingTimeLocal}, EndTradingTime:{securityContract.EndTradingTimeLocal}. ";
            
            Logger.Debug(msg);
           
        }
    }
}
