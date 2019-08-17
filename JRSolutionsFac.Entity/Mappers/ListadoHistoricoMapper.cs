using JRSolutionsFac.Entity.Dtos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRSolutionsFac.Entity.Mappers
{
    public static class ListadoHistoricoMapper
    {
        public static List<ListadoHistoricoDto> AsListHistory(this DataTable table)
        {
            List<ListadoHistoricoDto> listHistorico = new List<ListadoHistoricoDto>();
            if (table != null)
            {
                foreach (DataRow row in table.Rows)
                    listHistorico.Add(new ListadoHistoricoDto()
                    {                        
                        NumFac = Convert.ToInt32(row["Factura"].ToString()),
                        Tipo_Documento = row["Tipo_Documento"].ToString(),
                        Numero_Documento = row["Numero_Documento"].ToString(),
                        Cliente = row["Cliente"].ToString(),
                        Placa = row["Placa"].ToString(),
                        Marca = row["Marca"].ToString(),
                        Total = Convert.ToInt32(row["Total"].ToString()),
                        Fecha_Creacion = Convert.ToDateTime(row["FechaCreacion"].ToString()),                       
                    });
            }
            return listHistorico;
        }
    }
}
