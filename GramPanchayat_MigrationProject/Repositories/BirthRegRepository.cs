using GramPanchayat_MigrationProject.API.Models;
using GramPanchayat_MigrationProject.API.Data;
using Microsoft.EntityFrameworkCore;
namespace GramPanchayat_MigrationProject.API.Repositories{
    public class BirthRegRepository : IBirthRegRepository
    {
        private readonly GramPanchayatDBContext gramPanchayatDBContext;
        public BirthRegRepository(GramPanchayatDBContext gramPanchayatDBContext)
        {
            this.gramPanchayatDBContext = gramPanchayatDBContext;
        }
        public Birth Add(Birth birth)
        {
            gramPanchayatDBContext.BirthReg.Add(birth);
            gramPanchayatDBContext.SaveChanges();
            return birth;
        }
        public void Delete(int RegistrationNo)
        {
            var reg = gramPanchayatDBContext.BirthReg.Find(RegistrationNo);
             gramPanchayatDBContext.BirthReg.Remove(reg);
            gramPanchayatDBContext.SaveChanges();
        }
        public Birth Get(int RegistrationNo)
        {
           return gramPanchayatDBContext.BirthReg.FirstOrDefault(x => x.RegistrationNo == RegistrationNo);
        }
        public IEnumerable<Birth> GetAll()
        {
            return (IEnumerable<Birth>)gramPanchayatDBContext.BirthReg.ToList();
        }
        public Birth Update(int RegistrationNo, Birth birth)
        {
           var existingRecord = gramPanchayatDBContext.BirthReg.FirstOrDefault(x => x.RegistrationNo == RegistrationNo);
           if(existingRecord == null)
           {
            return null;
           }
        existingRecord.RegistionDate = birth.RegistionDate;
        existingRecord.DateOfBirth = birth.DateOfBirth;
        existingRecord.Sex = birth.Sex;
        existingRecord.ChildName = birth.ChildName;
        existingRecord.FatherName= birth.FatherName;
        existingRecord.MotherName = birth.MotherName;
        existingRecord.Address = birth.Address;
        existingRecord.WeightOfChild = birth.WeightOfChild;
        existingRecord.BirthPlace = birth.BirthPlace;
        existingRecord.NameAndAddressOfDetailSenderPerson = birth.NameAndAddressOfDetailSenderPerson;
        existingRecord.CityVillegName = birth.CityVillegName;
        existingRecord.DistName = birth.DistName;
        existingRecord.State = birth.State;
        existingRecord.Religion = birth.Religion;
        existingRecord.FatherEducationQualification = birth.FatherEducationQualification;
        existingRecord.MotherEducationQualification = birth.MotherEducationQualification;
        existingRecord.FatherOccupation = birth.FatherOccupation;
        existingRecord.MotherOccupation = birth.MotherOccupation;
        existingRecord.MotherAgeMerrageTime = birth.MotherAgeMerrageTime;
        existingRecord.MotherAgeAtChildTime = birth.MotherAgeAtChildTime;
        existingRecord.DeliveryType = birth.DeliveryType;
        existingRecord.MotherRecidences = birth.MotherRecidences;
        existingRecord.TotalLiveChildWithThisChild = birth.TotalLiveChildWithThisChild;
       
        gramPanchayatDBContext.SaveChanges();
        return existingRecord;
        }
    }
}
