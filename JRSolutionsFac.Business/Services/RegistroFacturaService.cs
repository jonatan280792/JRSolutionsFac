using JRSolutionsFac.Entity.Dtos;
using JRSolutionsFac.Repository.Repositories;
using System.Collections.Generic;


namespace JRSolutionsFac.Business.Services
{
    public class RegistroFacturaService
    {
        RegistroFacturaRepository _repositoryHead = new RegistroFacturaRepository();
        RegistroFacturaDetalleRepository _repositoryDetail = new RegistroFacturaDetalleRepository();
        
        public bool Add(RegistroFacturaDto encabezado, List<RegistroFacturaDetalleDto> factura)
        {

            var result = _repositoryHead.Add(encabezado);
            bool resultDetail = new bool();
            foreach (var dto in factura)
            {
                resultDetail = _repositoryDetail.Add(dto);
            }
            return resultDetail;
        }
    }
}
