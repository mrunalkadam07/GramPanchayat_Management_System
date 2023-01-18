using GramPanchayat_MigrationProject.API.Models;
using GramPanchayat_MigrationProject.API.Repositories;
using Microsoft.AspNetCore.Mvc;
namespace GramPanchayat_MigrationProject.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BirthRegistrationController : Controller
    {
        private readonly IBirthRegRepository birthregRepository;
        public BirthRegistrationController(IBirthRegRepository birthregRepository)
        {
            this.birthregRepository = birthregRepository;
        }
        [HttpGet]
        public IActionResult GetAll(){
            {
                var registrations = birthregRepository.GetAll();
                return Ok(registrations);
            }
        }
        [HttpGet("{RegistrationNo}")]
        public IActionResult GetReg(int RegistrationNo)
        {
          var reg = birthregRepository.Get(RegistrationNo);
          if(reg == null)
          {
            return NotFound();
          }
          return Ok(reg);
        }
        [HttpPost]
        public IActionResult AddDeath(Birth birth){
           birthregRepository.Add(birth);
           return Ok();
        }
        [HttpDelete("{RegistrationNo}")]
        public IActionResult DeleteDeath(int RegistrationNo){
           birthregRepository.Delete(RegistrationNo);
           return NoContent();
        }
        [HttpPut("{RegistrationNo}")]
        public Birth Update(int RegistrationNo,Birth birth)
        {
           return birthregRepository.Update(RegistrationNo, birth);
        }
    }
}
