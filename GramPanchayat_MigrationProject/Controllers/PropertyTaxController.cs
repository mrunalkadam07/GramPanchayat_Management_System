using GramPanchayat_MigrationProject.API.Models;
using GramPanchayat_MigrationProject.API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GramPanchayat_MigrationProject.API.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class PropertyTaxController : Controller
    {
           private readonly IPropertyTaxRepository propertytaxRepository;
            public PropertyTaxController(IPropertyTaxRepository propertytaxRepository)
             {
                this.propertytaxRepository = propertytaxRepository;
            }

        [HttpGet]
        public IActionResult GetAll(){
            {
                var registrations = propertytaxRepository.GetAll();
                return Ok(registrations);
            }
        }

        [HttpGet("{BillNo}")]
       
        public IActionResult GetReg(int billNo)
        {
          var reg = propertytaxRepository.Get(billNo);
          if(reg == null)
          {
            return NotFound();
          }
          return Ok(reg);
        }

        [HttpPost]
        public IActionResult AddProperty(PropertyTaxPaid propertytax){
           propertytaxRepository.Add(propertytax);
           return Ok();
        }

        [HttpDelete("{BillNo}")]
        public IActionResult DeleteDeath(int billNo){
           propertytaxRepository.Delete(billNo);
           return NoContent();
        }

        [HttpPut("{BillNo}")]
        public PropertyTaxPaid Update(int billNo,PropertyTaxPaid propertyTax)
        {
           return propertytaxRepository.Update(billNo, propertyTax);
        }
    }
}