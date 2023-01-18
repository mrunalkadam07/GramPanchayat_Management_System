using GramPanchayat_MigrationProject.API.Models;

namespace GramPanchayat_MigrationProject.API.Repositories
{
    public interface IMarriageRegRepository
    {
        IEnumerable<MarriageRegModel> GetAll();
        MarriageRegModel Get(int RegistrationNo);
        MarriageRegModel Add(MarriageRegModel merrageReg);
        void Delete(int RegistrationNo);

        MarriageRegModel Update(int RegistrationNo,MarriageRegModel marriageRegModel);
        
    }
}