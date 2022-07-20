using Microsoft.AspNetCore.Mvc;
using Prototype2WebApi.Enums;
using Prototype2WebApi.Interfaces;
using Prototype2WebApi.Models;

namespace Prototype2WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostedStoryController : ControllerBase
    {
        private readonly IPrototypeDbRepository _prototypeDbRepository;
        public PostedStoryController(IPrototypeDbRepository prototypeDbRepository)
        {
            _prototypeDbRepository = prototypeDbRepository;
        }

        [HttpPost]
        public IActionResult PostStory([FromBody] PostedStory postedstory)
        {
            try
            {
                if (postedstory == null || !ModelState.IsValid)
                {
                    return BadRequest(SystemErrorCodes.PostedStoryFailed.ToString());
                }
                bool DoesPostedStoryExist = _prototypeDbRepository.DoesPostedStoryExistById(postedstory.PostedStoryId);
                if (DoesPostedStoryExist)
                {
                    return StatusCode(StatusCodes.Status409Conflict, SystemErrorCodes.PostedStoryDuplicate.ToString());
                }
                _prototypeDbRepository.PostStory(postedstory);
            }
            catch (Exception)
            {
                return BadRequest(SystemErrorCodes.ScheduleCreationFailed.ToString());
            }
            return Ok(postedstory);
        }
        [HttpGet]
        public IEnumerable<PostedStory> Get()
        {
            return _prototypeDbRepository.GetAllPostedStories();
        }

        // GET api/<CustomerController>/5
        [HttpGet("byid")]
        public PostedStory Get([FromQuery] int id)
        {
            return _prototypeDbRepository.GetPostedStoryId(id);
        }


    }
}
