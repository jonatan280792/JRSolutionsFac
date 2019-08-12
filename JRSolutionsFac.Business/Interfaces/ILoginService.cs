using JRSolutionsFac.Business.Services;
using JRSolutionsFac.Entity.Dtos;
using System.Collections.Generic;

namespace JRSolutionsFac.Business.Interfaces
{
    public interface ILoginService
    {
        List<LoginDto> Find(string UserName, string PassWord);
    }
}
