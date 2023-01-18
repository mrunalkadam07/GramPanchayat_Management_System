using GramPanchayat_MigrationProject.API.Models;
using GramPanchayat_MigrationProject.API.Data;
using Microsoft.EntityFrameworkCore;
namespace GramPanchayat_MigrationProject.API.Repositories{
    public class PropertyTaxRepository : IPropertyTaxRepository
    {
        private readonly GramPanchayatDBContext gramPanchayatDBContext;
        public PropertyTaxRepository(GramPanchayatDBContext gramPanchayatDBContext)
        {
            this.gramPanchayatDBContext = gramPanchayatDBContext;
        }
        public PropertyTaxPaid Add(PropertyTaxPaid propertyTaxRegistration)
        {
            gramPanchayatDBContext.TaxPaid.Add(propertyTaxRegistration);
            gramPanchayatDBContext.SaveChanges();
            return propertyTaxRegistration;
        }
        public void Delete(int BillNo)
        {
            var reg = gramPanchayatDBContext.TaxPaid.Find(BillNo);
             gramPanchayatDBContext.TaxPaid.Remove(reg);
            gramPanchayatDBContext.SaveChanges();
        }
        public PropertyTaxPaid Get(int billNo)
        {
           return gramPanchayatDBContext.TaxPaid.FirstOrDefault(x => x.BillNo == billNo);
        }
        public IEnumerable<PropertyTaxPaid> GetAll()
        {
            return (IEnumerable<PropertyTaxPaid>)gramPanchayatDBContext.TaxPaid.ToList();
        }
        public PropertyTaxPaid Update(int billNo, PropertyTaxPaid propertyTaxRegistration)
        {
           var existingRecord = gramPanchayatDBContext.TaxPaid.FirstOrDefault(x => x.BillNo == billNo);
           if(existingRecord == null)
           {
            return null;
           }
        existingRecord.Billdate = propertyTaxRegistration.Billdate;
        existingRecord.Year = propertyTaxRegistration.Year;
        existingRecord.Name = propertyTaxRegistration.Name;
        existingRecord.Address = propertyTaxRegistration.Address;
        existingRecord.PropertyNo = propertyTaxRegistration.PropertyNo;
        existingRecord.HomeTax = propertyTaxRegistration.HomeTax;
        existingRecord.ElectrycityTax = propertyTaxRegistration.ElectrycityTax;
        existingRecord.SpecialWaterTax = propertyTaxRegistration.SpecialWaterTax;
        existingRecord.EducationalSess = propertyTaxRegistration.EducationalSess;
        existingRecord.PanaltyCharge = propertyTaxRegistration.PanaltyCharge;
        existingRecord.Total = propertyTaxRegistration.Total;
        gramPanchayatDBContext.SaveChanges();
        return existingRecord;
        }

    }
}