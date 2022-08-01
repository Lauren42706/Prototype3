using Prototype2.Services.Interfaces;
using Prototype2WebApi.Models;

namespace Prototype2.Services
{
    public class InMemoryDataCache : IDataCache
    {
        public bool IsAuthenticated { get; set; }
        public UserInfoData UserAuthentication { get; set; }
    }
}
