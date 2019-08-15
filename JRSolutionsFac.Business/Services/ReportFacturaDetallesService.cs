using JRSolutionsFac.Entity.Dtos;
using JRSolutionsFac.Entity.Mappers;
using JRSolutionsFac.Repository.Repositories;
using System.Data;

namespace JRSolutionsFac.Business.Services
{
    public class ReportFacturaDetallesService
    {
        ReportFacturaDetallesRepository _respository = new ReportFacturaDetallesRepository();

        public ReportFacturaDetallesDto GetFac(int NumFac) => _respository.GetFac(NumFac).AsFacDetail();

        public DataTable GetFacData(int NumFac) => _respository.GetFac(NumFac);
    }
}
