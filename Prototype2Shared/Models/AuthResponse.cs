using Prototype2WebApi.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype2Shared.Models
{
    public class AuthResponse
    {
        public bool Authenticated { get; set; }
        public UserInfoData UserAuthenticated { get; set; }

        public AuthResponse()
        {
            Authenticated = false;
            UserAuthenticated = null;
        }
    }
}
