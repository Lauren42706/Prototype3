using Prototype2Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Prototype2.Services.Interfaces
{
    public interface IAuthentication
    {
        Task<AuthResponse> Authenticate(string userName, string pin);
    }
}
