using JRSolutionsFac.Entity.Dtos;
using JRSolutionsFac.Entity.Mappers;
using JRSolutionsFac.Repository.Repositories;
using System.Collections.Generic;

namespace JRSolutionsFac.Business.Services
{    
    public class ListadoFacturasService
    {
        ListadoFacturasRepository _repository = new ListadoFacturasRepository();

        public List<ListadoFacturasDto> GetAll() => _repository.GetAll().AsListFacturas();
    }
}
