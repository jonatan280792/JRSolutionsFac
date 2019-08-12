using System.Data;

namespace JRSolutionsFac.Repository.Interfaces
{
    public interface ILoginRepository
    {
        DataTable Find(string UserName, string PassWord);
    }
}
