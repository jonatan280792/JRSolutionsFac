using JRSolutionsFac.Entity.Dtos;
using JRSolutionsFac.Entity.Mappers;
using JRSolutionsFac.Repository.Repositories;
using System.Collections.Generic;

namespace JRSolutionsFac.Business.Services
{
    public class ListadoMarcasService
    {
        ListadoMarcasRepository _repository = new ListadoMarcasRepository();

        public List<ListadoMarcasDto> GetAll() => _repository.GetAll().AsListMarcas();
    }
}
