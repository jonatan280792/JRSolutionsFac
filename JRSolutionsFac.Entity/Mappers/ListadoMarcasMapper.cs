using JRSolutionsFac.Entity.Dtos;
using System;
using System.Collections.Generic;
using System.Data;

namespace JRSolutionsFac.Entity.Mappers
{
    public static class ListadoMarcasMapper
    {
        public static List<ListadoMarcasDto> AsListMarcas(this DataTable table)
        {
            List<ListadoMarcasDto> loginDtoList = new List<ListadoMarcasDto>();
            if (table != null)
            {
                foreach (DataRow row in table.Rows)
                    loginDtoList.Add(new ListadoMarcasDto()
                    {
                        Id = Convert.ToInt32(row["Id"].ToString()),
                        Marca = row["Marca"].ToString(),
                        Tipe = Convert.ToInt32(row["Tipe"].ToString()),                        
                    });
            }
            return loginDtoList;
        }
    }
}
