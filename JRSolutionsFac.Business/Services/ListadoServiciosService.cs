using JRSolutionsFac.Repository.Repositories;
using System.Data;

namespace JRSolutionsFac.Business.Services
{
    public class ListadoServiciosService
    {
        ListadoServiciosRepository _repository = new ListadoServiciosRepository();
        public DataTable FindTable(string filter) => _repository.Find(filter);
    }
}
