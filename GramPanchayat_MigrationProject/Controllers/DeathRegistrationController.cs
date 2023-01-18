using GramPanchayat_MigrationProject.API.Models;
using GramPanchayat_MigrationProject.API.Repositories;
using Microsoft.AspNetCore.Mvc;
namespace GramPanchayat_MigrationProject.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DeathRegistrationController : Controller
    {
        private readonly IDeathRegRepository deathregRepository;
        public DeathRegistrationController(IDeathRegRepository deathregRepository)
        {
            this.deathregRepository = deathregRepository;
        }
        [HttpGet]
        public IActionResult GetAll(){
            {
                var registrations = deathregRepository.GetAll();
                return Ok(registrations);
            }
        }
        [HttpGet("{RegistrationNo}")]
        public IActionResult GetReg(int RegistrationNo)
        {
          var reg = deathregRepository.Get(RegistrationNo);
          if(reg == null)
          {
            return NotFound();
          }
          return Ok(reg);
        }
        [HttpPost]
        public IActionResult AddDeath(DeathRegistration deathRegistration){
           deathregRepository.Add(deathRegistration);
           return Ok();
        }
        [HttpDelete("{RegistrationNo}")]
        public IActionResult DeleteDeath(int RegistrationNo){
           deathregRepository.Delete(RegistrationNo);
           return NoContent();
        }
        [HttpPut("{RegistrationNo}")]
        public DeathRegistration Update(int RegistrationNo,DeathRegistration deathRegistration)
        {
           return deathregRepository.Update(RegistrationNo, deathRegistration);
        }
    }
}