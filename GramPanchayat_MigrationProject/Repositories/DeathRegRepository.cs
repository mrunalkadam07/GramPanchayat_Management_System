using GramPanchayat_MigrationProject.API.Models;
using GramPanchayat_MigrationProject.API.Data;
using Microsoft.EntityFrameworkCore;
namespace GramPanchayat_MigrationProject.API.Repositories{
    public class DeathRegRepository : IDeathRegRepository
    {
        private readonly GramPanchayatDBContext gramPanchayatDBContext;
        public DeathRegRepository(GramPanchayatDBContext gramPanchayatDBContext)
        {
            this.gramPanchayatDBContext = gramPanchayatDBContext;
        }
        public DeathRegistration Add(DeathRegistration deathRegistration)
        {
            gramPanchayatDBContext.DeathReg.Add(deathRegistration);
            gramPanchayatDBContext.SaveChanges();
            return deathRegistration;
        }
        public void Delete(int RegistrationNo)
        {
            var reg = gramPanchayatDBContext.DeathReg.Find(RegistrationNo);
             gramPanchayatDBContext.DeathReg.Remove(reg);
            gramPanchayatDBContext.SaveChanges();
        }
        public DeathRegistration Get(int RegistrationNo)
        {
           return gramPanchayatDBContext.DeathReg.FirstOrDefault(x => x.RegistrationNo == RegistrationNo);
        }
        public IEnumerable<DeathRegistration> GetAll()
        {
            return (IEnumerable<DeathRegistration>)gramPanchayatDBContext.DeathReg.ToList();
        }
        public DeathRegistration Update(int RegistrationNo, DeathRegistration deathRegistration)
        {
           var existingRecord = gramPanchayatDBContext.DeathReg.FirstOrDefault(x => x.RegistrationNo == RegistrationNo);
           if(existingRecord == null)
           {
            return null;
           }
        existingRecord.Year = deathRegistration.Year;
        existingRecord.CityVillege = deathRegistration.CityVillege;
        existingRecord.Taluko = deathRegistration.Taluko;
        existingRecord.Dist = deathRegistration.Dist;
        existingRecord.RegistrationDate = deathRegistration.RegistrationDate;
        existingRecord.DateOfDeath = deathRegistration.DateOfDeath;
        existingRecord.NameAndAddressOfDeathSenderPerson = deathRegistration.NameAndAddressOfDeathSenderPerson;
        existingRecord.Sex = deathRegistration.Sex;
        existingRecord.AgeAtDeath = deathRegistration.AgeAtDeath;
        existingRecord.PlaceOfDeath = deathRegistration.PlaceOfDeath;
        existingRecord.MotherFatherHusbandName = deathRegistration.MotherFatherHusbandName;
        existingRecord.PermentAddressOfDeathPerson = deathRegistration.PermentAddressOfDeathPerson;
        existingRecord.NameOfDeathPerson= deathRegistration.NameOfDeathPerson;
        existingRecord.NameOfRegistar = deathRegistration.NameOfRegistar;
        gramPanchayatDBContext.SaveChanges();
        return existingRecord;
        }
    }
}