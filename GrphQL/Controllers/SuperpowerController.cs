using GrphQL.IRepository;
using GrphQL.Models;
using Microsoft.AspNetCore.Mvc;

namespace GrphQL.Controllers
{
    public class SuperpowerController : Controller
    {
        private readonly ISuperpowerRepository _superpowerRepo;

        public SuperpowerController(ISuperpowerRepository superpowerRepo)
        {
            _superpowerRepo = superpowerRepo;
        }

        [HttpGet]
        [Route("api/superpowers")]
        public async Task<IActionResult> GetSuperpowers()
        {
            var superpowers = await _superpowerRepo.GetSuperpowers();

            return Ok(superpowers);
        }

        [HttpGet]
        [Route("api/superpowers/{id}")]
        public async Task<IActionResult> GetSuperpower(Guid id)
        {
            var superpower = await _superpowerRepo.GetSuperpower(id);
            return Ok(superpower);
        }

        [HttpPost]
        [Route("api/superpowers")]
        public async Task<IActionResult> AddSuperpower([FromBody] Superpower superpower)
        {
            await _superpowerRepo.AddSuperpower(superpower);
            return Ok();
        }

        [HttpPut]
        [Route("api/superpowers")]
        public async Task<IActionResult> UpdateSuperpower([FromBody] Superpower superpower)
        {
            var superPower = await _superpowerRepo.UpdateSuperpower(superpower);


            await _superpowerRepo.UpdateSuperpower(superPower);
            return Ok();
        }
    }
}
