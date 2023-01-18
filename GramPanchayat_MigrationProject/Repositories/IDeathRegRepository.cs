using GramPanchayat_MigrationProject.API.Models;
namespace GramPanchayat_MigrationProject.API.Repositories
{
    public interface IDeathRegRepository
    {
       IEnumerable<DeathRegistration> GetAll();
       DeathRegistration Get(int RegistrationNo);
       DeathRegistration Add(DeathRegistration deathRegistration);
       void Delete(int RegistrationNo);
       DeathRegistration Update(int RegistrationNo, DeathRegistration deathRegistration);
    }
}