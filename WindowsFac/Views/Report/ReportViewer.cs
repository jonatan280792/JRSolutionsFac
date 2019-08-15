using JRSolutionsFac.Business.Services;
using JRSolutionsFac.Entity.Dtos;
using System.Data;
using System.Windows.Forms;

namespace WindowsFac.Views.Report
{
    public partial class ReportViewer : Form
    {
        public ReportViewer(int numfac)
        {
            InitializeComponent();
            WindowsFac.ReportAutolife cryRpt = new WindowsFac.ReportAutolife();

            ReportFacturaEncabezadoService _serviceFactura = new ReportFacturaEncabezadoService();
            ReportFacturaDetallesService _serviceFacturaDetalles = new ReportFacturaDetallesService();

            //ReportFacturaEncabezadoDto header = _serviceFactura.GetFac(numfac);

            DataTable header = new DataTable();
            header = _serviceFactura.GetFacData(numfac);

            DataTable details = new DataTable();
            details = _serviceFacturaDetalles.GetFacData(numfac);

            //cryRpt.SetDataSource(table);

            cryRpt.Database.Tables["ReportFacturaHead"].SetDataSource(header);
            cryRpt.Database.Tables["ReportFacturaDetail"].SetDataSource(details);
            
            ////cryRpt.Load("D:/GitHub/JRSolutionsFac/WindowsFac/ReportAutolife.rpt");
            ////cryRpt.DataSourceConnections.Clear();
            //cryRpt.SetDataSource(header);
            //cryRpt.Subreports[0].DataSourceConnections.Clear();
            //cryRpt.Subreports[0].SetDataSource(header);
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
            //sss.SetDataSource();
        }
    }
}
