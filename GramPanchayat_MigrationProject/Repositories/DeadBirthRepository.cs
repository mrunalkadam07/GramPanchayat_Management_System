using GramPanchayat_MigrationProject.API.Models;
using GramPanchayat_MigrationProject.API.Data;
using Microsoft.EntityFrameworkCore;

namespace GramPanchayat_MigrationProject.API.Repositories{

    public class DeadBirthRepository : IDeadBirthRepository
    {
        private readonly GramPanchayatDBContext gramPanchayatDBContext;

        public DeadBirthRepository(GramPanchayatDBContext gramPanchayatDBContext)
        {
            this.gramPanchayatDBContext = gramPanchayatDBContext;
        }

        public DeadBirth Add(DeadBirth deadBirthRegistration)
        {  
            gramPanchayatDBContext.DeadBirthReg.Add(deadBirthRegistration);
            gramPanchayatDBContext.SaveChanges();
            return deadBirthRegistration;

        }

        public void Delete(int RegistrationNo)
        {
            var reg = gramPanchayatDBContext.DeadBirthReg.Find(RegistrationNo);
            gramPanchayatDBContext.DeadBirthReg.Remove(reg);
            gramPanchayatDBContext.SaveChanges();
        }
        public DeadBirth Get(int RegistrationNo)
        {
           return gramPanchayatDBContext.DeadBirthReg.FirstOrDefault(x => x.RegistretionNo == RegistrationNo);
        }

        public IEnumerable<DeadBirth> GetAll()
        {
            return (IEnumerable<DeadBirth>)gramPanchayatDBContext.DeadBirthReg.ToList();
        }

        public DeadBirth Update(int RegistrationNo, DeadBirth deathRegistration)
        {
           var existingRecord = gramPanchayatDBContext.DeadBirthReg.FirstOrDefault(x => x.RegistretionNo == RegistrationNo);
           if(existingRecord == null)
           {
            return null;
           }
        existingRecord.Year = deathRegistration.Year;
        existingRecord.CityVillege = deathRegistration.CityVillege;
        existingRecord.Taluko = deathRegistration.Taluko;
        existingRecord.Dist = deathRegistration.Dist;
        existingRecord.RegistretionDate = deathRegistration.RegistretionDate;
        existingRecord.DeadBirthDate = deathRegistration.DeadBirthDate;
        existingRecord.Sex = deathRegistration.Sex;
        existingRecord.FatherName = deathRegistration.FatherName;
        existingRecord.MotherName = deathRegistration.MotherName;
        existingRecord.Address = deathRegistration.Address;
        existingRecord.BirthPlace = deathRegistration.BirthPlace;
        existingRecord.NameAndAddressOfDetailSendesPerson = deathRegistration.NameAndAddressOfDetailSendesPerson;
        existingRecord.NameOfRegistar = deathRegistration.NameOfRegistar;
        gramPanchayatDBContext.SaveChanges();
        return existingRecord;
        }
    }
}