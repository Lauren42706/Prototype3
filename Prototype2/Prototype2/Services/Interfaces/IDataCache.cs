using Prototype2WebApi.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype2.Services.Interfaces
{
    public interface IDataCache
    {
        bool IsAuthenticated { get; set; }

        UserInfoData UserAuthentication { get; set; }
    }
}
