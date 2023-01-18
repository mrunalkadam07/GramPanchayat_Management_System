using GramPanchayat_MigrationProject.API.Models;
using GramPanchayat_MigrationProject.API.Data;
using Microsoft.AspNetCore.Mvc;

namespace GramPanchayat_MigrationProject.API.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        private readonly GramPanchayatDBContext gramPanchayatDbContext;

        public LoginRepository(GramPanchayatDBContext gramPanchayatDbContext)
        {
            this.gramPanchayatDbContext = gramPanchayatDbContext;
        }

        public IEnumerable<LoginModel> GetAll()
        {
            return gramPanchayatDbContext.Login1.ToList();
        }

        public int Validate(LoginModel logindata)
        {
            var rec = (from r in gramPanchayatDbContext.Login1 where r.user == logindata.user && r.pass == logindata.pass select r);
            if(rec.Count() > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}