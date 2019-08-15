using JRSolutionsFac.Entity.Dtos;
using System.Collections.Generic;
using System.Data;

namespace JRSolutionsFac.Entity.Mappers
{
    public static class LoginMapper
    {
        public static List<LoginDto> AsListLogin(this DataTable table)
        {
            List<LoginDto> loginDtoList = new List<LoginDto>();
            if (table != null)
            {
                foreach (DataRow row in table.Rows)
                    loginDtoList.Add(new LoginDto()
                    {
                        UserName = row["UserName"].ToString(),
                        PassWord = row["PassWord"].ToString()
                    });
            }
            return loginDtoList;
        }
    }
}
