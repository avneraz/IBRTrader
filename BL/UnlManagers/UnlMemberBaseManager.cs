﻿using Infra.Bus;
using Infra.Enum;
using TNS.API;
using TNS.API.ApiDataObjects;
using TNS.BL.Interfaces;

namespace TNS.BL.UnlManagers
{
    public abstract class UnlMemberBaseManager : IUnlBaseMemberManager
    {
        protected UnlMemberBaseManager( ManagedSecurity managedSecurity, UNLManager unlManager)
        {
            ManagedSecurity = managedSecurity;
            UNLManager = unlManager;
            APIWrapper = unlManager.APIWrapper;
            ConnectionStatus = ConnectionStatus.Disconnected;
            Symbol = managedSecurity.Symbol;
            UnlTradingData = unlManager.UnlTradingData;

        }
        protected readonly string Symbol;
        protected readonly ManagedSecurity ManagedSecurity;
        protected readonly ITradingApi APIWrapper;
        protected readonly UNLManager UNLManager;
        protected bool IsNowWorkingTime => UNLManager.IsNowWorkingTime;
        protected bool IsWorkingDay => UNLManager.IsWorkingDay;



        public virtual SecurityData MainSecurityData { get; protected set; }
        public UnlTradingData UnlTradingData { get; }
        /// <summary>
        /// Used as flag for request option chain:
        /// </summary>
        public bool RequestOptionChainDone { get; set; }
        public bool IsConnected => ConnectionStatus == ConnectionStatus.Connected;
        public ConnectionStatus ConnectionStatus { get; private set; }
        public virtual bool HandleMessage(IMessage message)
        {
            bool result = false;
            switch (message.APIDataType)
            {
                case EapiDataTypes.SecurityData:
                    MainSecurityData = (SecurityData)message;
                    result = true;
                    break;
                case EapiDataTypes.BrokerConnectionStatus:

                    var connectionStatusMessage = (BrokerConnectionStatusMessage)message;
                    ConnectionStatus = connectionStatusMessage.Status;
                    if (connectionStatusMessage.AfterConnectionToApiWrapper)
                        DoWorkAfterConnection();
                    result = true;
                    break;
            }
            return result;
        }
        public virtual void DoWorkAfterConnection()
        {
        }
    }
}
