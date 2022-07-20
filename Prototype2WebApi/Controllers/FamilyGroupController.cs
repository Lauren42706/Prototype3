using Microsoft.AspNetCore.Mvc;
using Prototype2WebApi.Enums;
using Prototype2WebApi.Interfaces;
using Prototype2WebApi.Models;

namespace Prototype2WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FamilyGroupController : ControllerBase
    {
        private readonly IPrototypeDbRepository _prototypeDbRepository;
        public FamilyGroupController(IPrototypeDbRepository prototypeDbRepository)
        {
            _prototypeDbRepository = prototypeDbRepository;
        }

        [HttpPost]
        public IActionResult CreateFamilyGroup([FromBody] FamilyGroup familygroup)
        {
            try
            {
                if (familygroup == null || !ModelState.IsValid)
                {
                    return BadRequest(SystemErrorCodes.FamilyGroupNotValid.ToString());
                }
                FamilyStatus familyStatus = _prototypeDbRepository.GetFamilyStatusById(familygroup.FamilyStatusId);
                if(familyStatus != null)
                {
                    if((familygroup.FamilyGroupId == (int) FamilyStatusEnum.Mother))
                    {

                    }
                }
                bool familystatusExists = _prototypeDbRepository.DoesFamilyStatusExistById(familygroup.FamilyGroupId);
                if (familystatusExists)
                {
                    return StatusCode(StatusCodes.Status409Conflict, SystemErrorCodes.FamilyGroupDuplicate.ToString());
                }
                _prototypeDbRepository.CreateFamilyGroup(familygroup);
            }
            catch (Exception e)
            {
                return BadRequest(SystemErrorCodes.FamilyGroupCreationFailed.ToString());
            }
            return Ok(familygroup);
        }

        [HttpGet]
        public IEnumerable<FamilyGroup> Get()
        {
            return _prototypeDbRepository.GetAllFamilyMembers();
        }

        [HttpGet("byid")]
        public FamilyGroup Get([FromQuery] int id)
        {
            return _prototypeDbRepository.GetFamilyGroupById(id);
        }
    }
}
