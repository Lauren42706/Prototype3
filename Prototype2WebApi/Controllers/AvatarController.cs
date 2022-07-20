using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prototype2WebApi.Enums;
using Prototype2WebApi.Interfaces;
using Prototype2WebApi.Models;

namespace Prototype2WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvatarController : ControllerBase
    {
        private readonly IPrototypeDbRepository _prototypeDbRepository;

        public AvatarController(IPrototypeDbRepository prototypeDbRepository)
        {
            _prototypeDbRepository = prototypeDbRepository;
        }

        [HttpPost]
        public IActionResult CreateAvatar([FromBody] Avatar userinfo)
        {
            try
            {
                if (userinfo == null || !ModelState.IsValid)
                {
                    return BadRequest(SystemErrorCodes.AvatarNotValid.ToString());
                }
                bool customerExists = _prototypeDbRepository.DoesUserExistById(userinfo.UserId);
                if (customerExists)
                {
                    return StatusCode(StatusCodes.Status409Conflict, SystemErrorCodes.AvatarDuplicate.ToString());
                }
                _prototypeDbRepository.CreateNewAvatar(userinfo);
            }
            catch (Exception e)
            {
                return BadRequest(SystemErrorCodes.AvatarCreationFailed.ToString());
            }
            return Ok(userinfo);
        }

        [HttpGet]
        public IEnumerable<Avatar> Get()
        {
            return _prototypeDbRepository.GetAvatarData();
        }

        [HttpGet("byid")]
        public Avatar Get([FromQuery] int id)
        {
            return _prototypeDbRepository.GetAvatarById(id);
        }
    }
}
