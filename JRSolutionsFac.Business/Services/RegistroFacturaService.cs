using JRSolutionsFac.Entity.Dtos;
using JRSolutionsFac.Repository.Repositories;
using System.Collections.Generic;


namespace JRSolutionsFac.Business.Services
{
    public class RegistroFacturaService
    {
        RegistroFacturaRepository _repository = new RegistroFacturaRepository();
        public bool Add(List<RegistroFacturaDto> factura)
        {
            foreach (var dto in factura)
            {
                var result = _repository.Add(dto);
            }
            return false;
        }
    }
}
