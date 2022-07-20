using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Prototype2.Services.Interfaces
{
    public interface IAuthentication
    {
        Task<bool> Authenticate(string userName, string pin);
    }
}
