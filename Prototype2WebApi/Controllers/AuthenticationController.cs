using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prototype2WebApi.Enums;
using Prototype2WebApi.Interfaces;
using Prototype2WebApi.Models;
using Prototype2Shared.Models;

namespace Prototype2WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IPrototypeDbRepository _prototypeDbRepository;

        public AuthenticationController(IPrototypeDbRepository prototypeDbRepository)
        {
            _prototypeDbRepository = prototypeDbRepository;
        }

        [HttpPost]
        public IActionResult Post([FromBody] AuthRequest auth)
        {
            try
            {
                var result = _prototypeDbRepository.PerformAuthenticationCheck(auth.UserName, auth.Pin);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(SystemErrorCodes.AuthenticationFailed.ToString());
            }
        }
    }
}
