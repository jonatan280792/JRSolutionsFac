using JRSolutionsFac.Entity.Dtos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
