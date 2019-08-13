using JRSolutionsFac.Entity.Dtos;
using JRSolutionsFac.Entity.Mappers;
using JRSolutionsFac.Repository.Repositories;
using System.Collections.Generic;

namespace JRSolutionsFac.Business.Services
{
    public class LoginService
    {
        LoginRepository loginrepository = new LoginRepository();
        //ILoginRepository _repository;
        //public LoginService(ILoginRepository repository)
        //{
        //    _repository = repository;
        //}
        public List<LoginDto> Find(string UserName, string PassWord) => loginrepository.Find(UserName, PassWord).AsListLogin();

        public List<LoginDto> Listar(string UserName, string PassWord) => loginrepository.Find(UserName, PassWord).AsListLogin();
    }
}
