using GramPanchayat_MigrationProject.API.Models;
namespace GramPanchayat_MigrationProject.API.Repositories
{
    public interface IAssasmenttaxRepository
    {
       IEnumerable<Assasment> GetAll();
       Assasment Get(int FormNo);
       Assasment Add(Assasment assasment);
       void Delete(int FormNo);
       Assasment Update(int FormNo, Assasment assasment);
    }
}
