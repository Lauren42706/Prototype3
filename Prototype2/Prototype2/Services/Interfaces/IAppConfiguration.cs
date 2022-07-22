using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype2.Services.Interfaces
{
    public interface IAppConfiguration
    {
        string BankingServerUrl { get; set; }
    }
}
