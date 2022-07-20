using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prototype2WebApi.Enums;
using Prototype2WebApi.Interfaces;
using Prototype2WebApi.Models;

namespace Prototype2WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscussionController : ControllerBase
    {
        private readonly IPrototypeDbRepository _prototypeDbRepository;

        public DiscussionController(IPrototypeDbRepository prototypeDbRepository)
        {
            _prototypeDbRepository = prototypeDbRepository;
        }

        [HttpPost]
        public IActionResult CreateDiscussion([FromBody] Discussion userinfo)
        {
            try
            {
                if (userinfo == null || !ModelState.IsValid)
                {
                    return BadRequest(SystemErrorCodes.CustomerNotValid.ToString());
                }
                bool customerExists = _prototypeDbRepository.DoesUserExistById(userinfo.UserId);
                if (customerExists)
                {
                    return StatusCode(StatusCodes.Status409Conflict, SystemErrorCodes.PostedStoryDuplicate.ToString());
                }
                _prototypeDbRepository.CreateNewDiscussion(userinfo);
            }
            catch (Exception e)
            {
                return BadRequest(SystemErrorCodes.ScheduleCreationFailed.ToString());
            }
            return Ok(userinfo);
        }

        [HttpGet]
        public IEnumerable<Discussion> Get()
        {
            return _prototypeDbRepository.GetDiscussion();
        }

        [HttpGet("byid")]
        public Discussion Get([FromQuery] int id)
        {
            return _prototypeDbRepository.GetDiscussionById(id);
        }
    }
}
