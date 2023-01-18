using GramPanchayat_MigrationProject.API.Models;

namespace GramPanchayat_MigrationProject.API.Repositories
{
    public interface IPropertyTaxRepository
    {
       IEnumerable<PropertyTaxPaid> GetAll();
       PropertyTaxPaid Get(int billNo);
       PropertyTaxPaid Add(PropertyTaxPaid propertyTaxRegistration);
       void Delete(int RegistrationNo);
       PropertyTaxPaid Update(int billNo, PropertyTaxPaid propertyTaxRegistration);
    }
}