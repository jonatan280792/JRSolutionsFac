using JRSolutionsFac.Entity.Dtos;
using System;
using System.Collections.Generic;
using System.Data;

namespace JRSolutionsFac.Entity.Mappers
{
    public static class ListadoFacturasMapper
    {
        public static List<ListadoFacturasDto> AsListFacturas(this DataTable table)
        {
            List<ListadoFacturasDto> loginDtoList = new List<ListadoFacturasDto>();
            if (table != null)
            {
                foreach (DataRow row in table.Rows)
                    loginDtoList.Add(new ListadoFacturasDto()
                    {
                        NumFac = Convert.ToInt32(row["numfac"].ToString()),
                        Detalle = row["detalle"].ToString(),
                        Placa = row["Placa_Vehiculo"].ToString(),
                        Cliente = row["nom_client"].ToString(),
                        Total = Convert.ToInt32(row["total"].ToString()),
                        Fecha = Convert.ToDateTime(row["fecha"].ToString()),
                    });
            }
            return loginDtoList;
        }
    }
}
