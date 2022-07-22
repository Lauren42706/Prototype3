using Prototype2.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype2.Services
{
    public class AppConfigurationServices : IAppConfiguration
    {
        private string _bankingServerUrl;

        public string BankingServerUrl
        {
            get => _bankingServerUrl;
            set => _bankingServerUrl = value;
        }

        public AppConfigurationServices()
        {
#if LOCALSERVER
                _bankingServerUrl = "https://10.0.2.2:5001/";
#else
            _bankingServerUrl = "http://localhost:5114";
#endif
        }
    }
}
