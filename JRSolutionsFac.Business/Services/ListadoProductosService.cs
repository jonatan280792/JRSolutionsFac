using JRSolutionsFac.Entity.Dtos;
using JRSolutionsFac.Entity.Mappers;
using JRSolutionsFac.Repository.Repositories;
using System.Collections.Generic;

namespace JRSolutionsFac.Business.Services
{
    public class ListadoProductosService
    {
        ListadoProductosRepository _productorepository = new ListadoProductosRepository();

        public List<ListadoProductosDto> Find() => _productorepository.Find().AsListProduct();
    }
}
