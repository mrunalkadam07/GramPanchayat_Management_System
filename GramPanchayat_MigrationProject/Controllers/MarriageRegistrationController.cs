using GramPanchayat_MigrationProject.API.Models;
using GramPanchayat_MigrationProject.API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GramPanchayat_MigrationProject.API.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class MarriageRegistrationController : Controller
    {
        private readonly IMarriageRegRepository marriageRegRepository;

        public MarriageRegistrationController(IMarriageRegRepository marriageRegRepository)
        {
            this.marriageRegRepository = marriageRegRepository;
        }

        [HttpGet]
        public IActionResult GetAllMarriageReg(){
            {
                var result = marriageRegRepository.GetAll();
                return Ok(result);
            }
        }
        [HttpGet("{RegistrationNo}")]
        public IActionResult GetReg(int RegistrationNo)
        {
          var reg = marriageRegRepository.Get(RegistrationNo);
          if(reg == null)
          {
            return NotFound();
          }
          return Ok(reg);
        }

        [HttpPost]
        public IActionResult AddMarriage(MarriageRegModel marriageRegModel){
           marriageRegRepository.Add(marriageRegModel);
           return Ok();
        }

        [HttpDelete("{RegistrationNo}")]
        public IActionResult DeleteMarriage(int RegistrationNo){
           marriageRegRepository.Delete(RegistrationNo);
           return NoContent();
        }
        [HttpPut("{RegistrationNo}")]
        public IActionResult Update(int RegistrationNo,MarriageRegModel marriageRegModel)
        {
           var obj = marriageRegRepository.Update(RegistrationNo, marriageRegModel);

           if(obj == null){
            return NotFound();
           }

           return Ok(obj);
        }

        }
    }
