using GramPanchayat_MigrationProject.API.Models;

namespace GramPanchayat_MigrationProject.API.Repositories
{
    public interface IDeadBirthRepository
    {
       IEnumerable<DeadBirth> GetAll();
       DeadBirth Get(int RegistrationNo);
       DeadBirth Add(DeadBirth deadBirthRegistration);
       void Delete(int RegistrationNo);
       DeadBirth Update(int RegistrationNo, DeadBirth deadBirthRegistration);
    }
}