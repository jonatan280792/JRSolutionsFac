using JRSolutionsFac.Entity.Dtos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRSolutionsFac.Entity.Mappers
{
    public static class ListadoProductosMapper
    {
        public static List<ListadoProductosDto> AsListProduct(this DataTable table)
        {
            List<ListadoProductosDto> productosDtoList = new List<ListadoProductosDto>();
            if (table != null)
            {
                foreach (DataRow row in table.Rows)
                    productosDtoList.Add(new ListadoProductosDto()
                    {
                        Id = Convert.ToInt32(row["id"].ToString()),
                        producto = row["producto"].ToString(),
                        valor = Convert.ToInt32(row["valor"].ToString()),
                    });
            }
            return productosDtoList;
        }
    }
}
