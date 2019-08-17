using JRSolutionsFac.Entity.Dtos;
using JRSolutionsFac.Entity.Mappers;
using JRSolutionsFac.Repository.Repositories;
using System.Collections.Generic;
using System.Data;

namespace JRSolutionsFac.Business.Services
{
    public class ListadoHistoricoService
    {
        ListadoHistoricoRepository _repository = new ListadoHistoricoRepository();

        public List<ListadoHistoricoDto> Find(string filter) => _repository.Find(filter).AsListHistory();

        public DataTable FindTable(string filter) => _repository.Find(filter);

    }
}
