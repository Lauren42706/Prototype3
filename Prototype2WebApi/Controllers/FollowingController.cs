using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prototype2WebApi.Enums;
using Prototype2WebApi.Interfaces;
using Prototype2WebApi.Models;

namespace Prototype2WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FollowingController : ControllerBase
    {
        private readonly IPrototypeDbRepository _prototypeDbRepository;

        public FollowingController(IPrototypeDbRepository prototypeDbRepository)
        {
            _prototypeDbRepository = prototypeDbRepository;
        }

        [HttpPost]
        public IActionResult Create([FromBody] Following follower)
        {
            try
            {
                if (follower == null || !ModelState.IsValid)
                {
                    return BadRequest(SystemErrorCodes.FollowerNotValid.ToString());
                }
                bool customerExists = _prototypeDbRepository.DoesFollowerExistById(follower.FollowingId);
                if (customerExists)
                {
                    return StatusCode(StatusCodes.Status409Conflict, SystemErrorCodes.FollowerDuplicate.ToString());
                }
                _prototypeDbRepository.CreateNewFollower(follower);
            }
            catch (Exception e)
            {
                return BadRequest(SystemErrorCodes.FollowerCreationFailed.ToString());
            }
            return Ok(follower);
        }

        [HttpGet]
        public IEnumerable<Following> Get()
        {
            return _prototypeDbRepository.GetUserFollowerData();
        }

        [HttpGet("byid")]
        public Following Get([FromQuery] int id)
        {
            return _prototypeDbRepository.GetFollowerById(id);
        }
    }
}
