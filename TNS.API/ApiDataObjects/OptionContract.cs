﻿using System;
using IBApi;
using Infra.Enum;

namespace TNS.API.ApiDataObjects
{
	
	public class OptionContract : ContractBase
	{
		public OptionContract() 
		{
			
		}
		public OptionContract(string symbol, double strike, DateTime expiry, 
			EOptionType type, string exchange="SMART", int multiplier = 100, string currency = "USD")
			:base(symbol, SecurityType.Option)
			
		{
			Strike = strike;
			Expiry = expiry;
			OptionType = type;
			Multiplier = multiplier;
		}

		public OptionContract(string symbol, DateTime expiry, EOptionType type,
			 string exchange = "SMART", int multiplier = 100, string currency = "USD")
			: base(symbol, SecurityType.Option)

		{
			Expiry = expiry;
			Multiplier = multiplier;
			OptionType = type;
		}
		public DateTime Expiry { get; set; }
		public double Strike { get; set; }
		public EOptionType OptionType { get; set; }
		public int Multiplier { get; set; }

	    private string _optionKey;

	    public string OptionKey
	    {
            //this performance tweak is actually important, or else
            //the UIDataBroker don't work well
	        get
	        {
	            if (_optionKey == null)
	            {
	                _optionKey = $"{Expiry}.{OptionType}.{Strike}";
	            }
                return _optionKey;
            }
	    }
		public override string GetUniqueIdentifier()
		{
			return $"{Exchange}.{Symbol}.{Expiry}.{OptionType}.{Strike}"; ;
		}

		public override Contract ToIbContract()
		{
			var contract =  base.ToIbContract();
			if(OptionType != EOptionType.None)
				contract.Right = OptionType == EOptionType.Call ? "C" : "P";
			contract.Expiry = Expiry < DateTime.Now ? null : Expiry.ToString("yyyyMMdd");
			contract.Strike = Strike;
			contract.Multiplier = Multiplier.ToString();
			return contract;
		}

		public override string ToString()
		{
			return $"OptionContract: [{base.ToString()}, Expiry: {Expiry}, Strike: {Strike}, OptionType: {OptionType}, Multiplier: {Multiplier}]";
		}

		public string Description
		{
			get
			{
				string desc = $"{Symbol}.{Expiry:dd-MMM}:{OptionType}{Strike}, {Currency}, Multiplier:{Multiplier}";
				return desc;
			}
		}
		public string ShortDescription
		{
			get
			{
				string desc = $"{Symbol}.{Expiry:dd-MMM}:{OptionType}{Strike}.";
				return desc;
			}
		}
		public override bool Equals(object obj)
		{

			if (!base.Equals(obj))
				return false;

			var otherContract = obj as OptionContract;
			if (otherContract == null)
				return false;
			return otherContract.Expiry == Expiry && otherContract.OptionType == OptionType
				   && otherContract.Strike == Strike;
		}

		public override int GetHashCode()
		{
			return base.GetHashCode() + Expiry.GetHashCode() + OptionType.GetHashCode()
				   + Strike.GetHashCode();
		}

        public override EapiDataTypes APIDataType => EapiDataTypes.OptionContract;
    }
}
