using Microsoft.AspNetCore.Mvc;
using Prototype2WebApi.Interfaces;
using Prototype2WebApi.Models;

namespace Prototype2WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AchievementController : ControllerBase
    {
        private readonly IPrototypeDbRepository _prototypeDbRepository;

        public AchievementController(IPrototypeDbRepository prototypeDbRepository)
        {
            _prototypeDbRepository = prototypeDbRepository;
        }

        [HttpGet]
        public IEnumerable<Acheivement> Get()
        {
            return _prototypeDbRepository.GetAllAcheivements();
        }

        [HttpGet("byid")]
        public Acheivement Get([FromBody]int id)
        {
            return _prototypeDbRepository.GetAcheivementById(id);
        }
    }
}
