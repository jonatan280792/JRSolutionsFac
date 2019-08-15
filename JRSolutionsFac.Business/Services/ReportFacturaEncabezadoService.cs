using JRSolutionsFac.Entity.Dtos;
using JRSolutionsFac.Entity.Mappers;
using JRSolutionsFac.Repository.Repositories;
using System.Data;

namespace JRSolutionsFac.Business.Services
{
    public class ReportFacturaEncabezadoService
    {
        ReportFacturaEncabezadoRepository _respository = new ReportFacturaEncabezadoRepository();

        public ReportFacturaEncabezadoDto GetFac(int NumFac) => _respository.GetFac(NumFac).AsFac();

        public DataTable GetFacData(int NumFac) => _respository.GetFac(NumFac);
    }
}
