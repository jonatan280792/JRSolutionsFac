using JRSolutionsFac.Entity.Dtos;
using System;
using System.Data;
using System.Linq;


namespace JRSolutionsFac.Entity.Mappers
{
    public static class ReportFacturaDetallesMapper
    {
        public static ReportFacturaDetallesDto AsFacDetail(this DataTable table)
        {
            ReportFacturaDetallesDto facturaHeadDto = new ReportFacturaDetallesDto();
            if (table != null)
                facturaHeadDto = new ReportFacturaDetallesDto()
                {                    
                    NumFac = Convert.ToInt32(table.AsEnumerable().First()["NumFac"].ToString()),
                    Producto = table.AsEnumerable().First()["Producto"].ToString().Trim(),
                    Cantidad = Convert.ToInt32(table.AsEnumerable().First()["Cantidad"].ToString().Trim()),
                    Valor = Convert.ToInt32(table.AsEnumerable().First()["Valor"].ToString().Trim()),                    
                };
            return facturaHeadDto;
        }
    }
}
