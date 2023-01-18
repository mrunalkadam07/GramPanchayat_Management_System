using GramPanchayat_MigrationProject.API.Models;
using GramPanchayat_MigrationProject.API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GramPanchayat_MigrationProject.API.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class DeadBirthRegController : Controller
    {
           private readonly IDeadBirthRepository deathBirthregRepository;
            public DeadBirthRegController(IDeadBirthRepository deathBirthregRepository)
             {
                this.deathBirthregRepository = deathBirthregRepository;
            }

        [HttpGet]
        public IActionResult GetAll(){
            {
                var registrations = deathBirthregRepository.GetAll();
                return Ok(registrations);
            }
        }

        [HttpGet("{RegistrationNo}")]
       
        public IActionResult GetReg(int RegistrationNo)
        {
          var reg = deathBirthregRepository.Get(RegistrationNo);
          if(reg == null)
          {
            return NotFound();
          }
          return Ok(reg);
        }

        [HttpPost]
        public IActionResult AddDeath(DeadBirth deadBirthRegistration){
           deathBirthregRepository.Add(deadBirthRegistration);
           return Ok();
        }

        [HttpDelete("{RegistrationNo}")]
        public IActionResult DeleteDeath(int RegistrationNo){
           deathBirthregRepository.Delete(RegistrationNo);
           return NoContent();
        }

        [HttpPut("{RegistrationNo}")]
        public DeadBirth Update(int RegistrationNo,DeadBirth deadBirthRegistration)
        {
           return deathBirthregRepository.Update(RegistrationNo, deadBirthRegistration);
        }
    }
}