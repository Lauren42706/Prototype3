using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prototype2WebApi.Enums;
using Prototype2WebApi.Interfaces;
using Prototype2WebApi.Models;

namespace Prototype2WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FamilyStatusController : ControllerBase
    {
        private readonly IPrototypeDbRepository _prototypeDbRepository;
        public FamilyStatusController(IPrototypeDbRepository prototypeDbRepository)
        {
            _prototypeDbRepository = prototypeDbRepository;
        }

        [HttpPost]
        public IActionResult CreateFamilyStatus([FromBody] FamilyStatus familystatus)
        {
            try
            {
                if (familystatus == null || !ModelState.IsValid)
                {
                    return BadRequest(SystemErrorCodes.CustomerNotValid.ToString());
                }
                bool familystatusExists = _prototypeDbRepository.DoesFamilyStatusExistById(familystatus.FamilyStatusId);
                if (familystatusExists)
                {
                    return StatusCode(StatusCodes.Status409Conflict, SystemErrorCodes.FamilyStatusDuplicate.ToString());
                }
                _prototypeDbRepository.CreateFamilyStatus(familystatus);
            }
            catch (Exception e)
            {
                return BadRequest(SystemErrorCodes.FamilyStatusCreationFailed.ToString());
            }
            return Ok(familystatus);
        }

        [HttpGet]
        public IEnumerable<FamilyStatus> Get()
        {
            return _prototypeDbRepository.GetAllFamilyStatuses();
        }

        [HttpGet("byid")]
        public FamilyStatus Get([FromQuery] int id)
        {
            return _prototypeDbRepository.GetFamilyStatusById(id);
        }
    }
}
