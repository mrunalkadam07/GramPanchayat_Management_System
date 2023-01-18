using GramPanchayat_MigrationProject.API.Models;
using GramPanchayat_MigrationProject.API.Repositories;
using Microsoft.AspNetCore.Mvc;
namespace GramPanchayat_MigrationProject.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AssasmenttaxController : Controller
    {
        private readonly IAssasmenttaxRepository assasmenttaxRepository;
        public AssasmenttaxController(IAssasmenttaxRepository assasmenttaxRepository)
        {
            this.assasmenttaxRepository = assasmenttaxRepository;
        }
        [HttpGet]
        public IActionResult GetAll(){
            {
                var res = assasmenttaxRepository.GetAll();
                return Ok(res);
            }
        }
        [HttpGet("{FormNo}")]
        public IActionResult GetReg(int FormNo)
        {
          var reg = assasmenttaxRepository.Get(FormNo);
          if(reg == null)
          {
            return NotFound();
          }
          return Ok(reg);
        }
        [HttpPost]
        public IActionResult Add(Assasment assasment){
           assasmenttaxRepository.Add(assasment);
           return Ok();
        }
        [HttpDelete("{FormNo}")]
        public IActionResult Delete(int FormNo){
           assasmenttaxRepository.Delete(FormNo);
           return NoContent();
        }
        [HttpPut("{FormNo}")]
        public Assasment Update(int FormNo,Assasment assasment)
        {
           return assasmenttaxRepository.Update(FormNo, assasment);
        }
    }
}
