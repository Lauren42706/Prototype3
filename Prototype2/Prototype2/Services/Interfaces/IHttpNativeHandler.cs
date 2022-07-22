using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Prototype2.Services.Interfaces
{
    public interface IHttpNativeHandler
    {
        HttpClientHandler GetHttpClientHandler();
    }
}
