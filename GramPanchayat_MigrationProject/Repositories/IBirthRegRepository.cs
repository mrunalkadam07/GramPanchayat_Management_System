using GramPanchayat_MigrationProject.API.Models;
namespace GramPanchayat_MigrationProject.API.Repositories
{
    public interface IBirthRegRepository
    {
       IEnumerable<Birth> GetAll();
       Birth Get(int RegistrationNo);
       Birth Add(Birth birth);
       void Delete(int RegistrationNo);
       Birth Update(int RegistrationNo, Birth birth);
    }
}
