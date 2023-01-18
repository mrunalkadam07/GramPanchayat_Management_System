using GramPanchayat_MigrationProject.API.Models;
using GramPanchayat_MigrationProject.API.Data;
using Microsoft.EntityFrameworkCore;
namespace GramPanchayat_MigrationProject.API.Repositories{
    public class AssasmenttaxRepository : IAssasmenttaxRepository
    {
        private readonly GramPanchayatDBContext gramPanchayatDBContext;
        public AssasmenttaxRepository(GramPanchayatDBContext gramPanchayatDBContext)
        {
            this.gramPanchayatDBContext = gramPanchayatDBContext;
        }
        public Assasment Add(Assasment assasment)
        {
            gramPanchayatDBContext.Assasmenttax.Add(assasment);
            gramPanchayatDBContext.SaveChanges();
            return assasment;
        }
        public void Delete(int FormNo)
        {
            var reg = gramPanchayatDBContext.Assasmenttax.Find(FormNo);
             gramPanchayatDBContext.Assasmenttax.Remove(reg);
            gramPanchayatDBContext.SaveChanges();
        }
        public Assasment Get(int FormNo)
        {
           return gramPanchayatDBContext.Assasmenttax.FirstOrDefault(x => x.FormNo == FormNo);
        }
        public IEnumerable<Assasment> GetAll()
        {
            return (IEnumerable<Assasment>)gramPanchayatDBContext.Assasmenttax.ToList();
        }
        public Assasment Update(int FormNo, Assasment assasment)
        {
           var existingRecord = gramPanchayatDBContext.Assasmenttax.FirstOrDefault(x => x.FormNo == FormNo);
           if(existingRecord == null)
           {
            return null;
           }
        existingRecord.WardNo = assasment.WardNo;
        existingRecord.Date = assasment.Date;
        existingRecord.OldAssasmentNo = assasment.OldAssasmentNo;
        existingRecord.OwnersName = assasment.OwnersName;
        existingRecord.HoldersName = assasment.HoldersName;
        existingRecord.PropertyAddress = assasment.PropertyAddress;
        existingRecord.OccupiedBy = assasment.OccupiedBy;
        existingRecord.UseOfPropertyType = assasment.UseOfPropertyType;
        existingRecord.LocationCode = assasment.LocationCode;
        existingRecord.YearOfBuildup = assasment.YearOfBuildup;
        existingRecord.TotalAreaOfBuildupSqMeter = assasment.TotalAreaOfBuildupSqMeter;
        existingRecord.OpenAreaWhereNotBuildupSqMeter = assasment.OpenAreaWhereNotBuildupSqMeter;
        existingRecord.OpenAreasPlotSqMeter = assasment.OpenAreasPlotSqMeter;
        existingRecord.AssasedPropertyTax = assasment.AssasedPropertyTax;
        existingRecord.WardTotal = assasment.WardTotal;
        
        gramPanchayatDBContext.SaveChanges();
        return existingRecord;
        }
    }
}
