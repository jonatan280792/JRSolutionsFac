using JRSolutionsFac.Entity.Dtos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace JRSolutionsFac.Entity.Mappers
{
    public static class ReportFacturaEncabezadoMapper
    {
        public static List<ReportFacturaEncabezadoDto> AsListFact(this DataTable table)
        {
            List<ReportFacturaEncabezadoDto> facHeadDtoList = new List<ReportFacturaEncabezadoDto>();
            if (table != null)
            {
                foreach (DataRow row in table.Rows)
                    facHeadDtoList.Add(new ReportFacturaEncabezadoDto()
                    {
                        Id = Convert.ToInt32(row["Id"].ToString()),
                        NumFac = Convert.ToInt32(row["NumFac"].ToString()),
                        Nit = row["Nit"].ToString(),
                        Detalle = row["Detalle"].ToString(),
                        Cajero = row["Cajero"].ToString(),
                        Tipo_doc = row["Tipo_doc"].ToString(),
                        Numero_doc = row["Numero_doc"].ToString(),
                        Nom_client = row["Nom_client"].ToString(),
                        Marca = row["Marca"].ToString(),
                        Tipo = row["Tipo"].ToString(),
                        Modelo = row["Modelo"].ToString(),
                        Placa = row["Placa"].ToString(),
                        Mecanica = row["Mecanica"].ToString(),
                        Latoneria = row["Latoneria"].ToString(),
                        Pintura = row["Pintura"].ToString(),
                        Total = Convert.ToInt32(row["Total"].ToString()),
                        Recibido = Convert.ToInt32(row["Recibido"].ToString()),
                        Cambio = Convert.ToInt32(row["Cambio"].ToString()),
                        Fecha = Convert.ToDateTime(row["Fecha"].ToString()),
                        Fechaentrega = Convert.ToDateTime(row["Fechaentrega"].ToString()),
                    });
            }
            return facHeadDtoList;
        }

        public static ReportFacturaEncabezadoDto AsFac(this DataTable table)
        {
            ReportFacturaEncabezadoDto facturaHeadDto = new ReportFacturaEncabezadoDto();
            if (table != null)
                facturaHeadDto = new ReportFacturaEncabezadoDto()
                {
                    Id = Convert.ToInt32(table.AsEnumerable().First()["Id"].ToString()),
                    NumFac = Convert.ToInt32(table.AsEnumerable().First()["NumFac"].ToString()),
                    Nit = table.AsEnumerable().First()["Nit"].ToString().Trim(),
                    Detalle = table.AsEnumerable().First()["Detalle"].ToString().Trim(),
                    Cajero = table.AsEnumerable().First()["Cajero"].ToString().Trim(),
                    Tipo_doc = table.AsEnumerable().First()["Tipo_doc"].ToString().Trim().Trim(),
                    Numero_doc = table.AsEnumerable().First()["Numero_doc"].ToString().Trim(),
                    Nom_client = table.AsEnumerable().First()["Nom_client"].ToString().Trim(),
                    Marca = table.AsEnumerable().First()["Marca"].ToString().Trim(),
                    Tipo = table.AsEnumerable().First()["Tipo"].ToString().Trim(),
                    Modelo = table.AsEnumerable().First()["Modelo"].ToString().Trim(),
                    Placa = table.AsEnumerable().First()["Placa"].ToString().Trim(),
                    Mecanica = table.AsEnumerable().First()["Mecanica"].ToString().Trim(),
                    Latoneria = table.AsEnumerable().First()["Latoneria"].ToString().Trim(),
                    Pintura = table.AsEnumerable().First()["Pintura"].ToString().Trim(),
                    Total = Convert.ToInt32(table.AsEnumerable().First()["Total"].ToString().Trim()),
                    Recibido = Convert.ToInt32(table.AsEnumerable().First()["Recibido"].ToString().Trim()),
                    Cambio = Convert.ToInt32(table.AsEnumerable().First()["Cambio"].ToString().Trim()),
                    Fecha = Convert.ToDateTime(table.AsEnumerable().First()["Fecha"].ToString().Trim()),
                    Fechaentrega = Convert.ToDateTime(table.AsEnumerable().First()["Fechaentrega"].ToString().Trim()),
                };
            return facturaHeadDto;
        }
    }
}
