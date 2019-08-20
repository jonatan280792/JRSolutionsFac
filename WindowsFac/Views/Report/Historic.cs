using Bunifu.UI.WinForms.BunifuButton;
using JRSolutionsFac.Business.Services;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFac.Views.Report
{
    public partial class Historic : Form
    {
        ListadoHistoricoService _sevice = new ListadoHistoricoService();
        public Historic()
        {
            InitializeComponent();
            gridHistorico.HeaderBgColor = ColorTranslator.FromHtml("#880088");
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            BunifuButton bunifuButton =
            new BunifuButton();

            bunifuButton.Location = new System.Drawing.Point(70, 70);
            bunifuButton.ButtonText = "Hello world";

            bunifuButton.Click += (senderObject, eventArgs) => {
                MessageBox.Show("Hello there...");
            };

            Controls.Add(bunifuButton);

            if (filterFac.Text.Trim() == "")
            {
                MessageBox.Show("No escrito nada en el filtro, por favor verifique");
            }
            else
            {
                DataTable table = new DataTable();
                table = _sevice.FindTable(filterFac.Text.Trim());

                gridHistorico.DataSource = table;
            }            
        }

        private void load(object sender, EventArgs e)
        { 
            DataTable table = new DataTable();
            table = _sevice.FindTable("-1");            

            
            gridHistorico.DataSource = table;
        }

        private void imprimir(object sender, DataGridViewCellEventArgs e)
        {
            int factura = Convert.ToInt32(gridHistorico.SelectedCells[0].Value);
            ReportViewer _factura = new ReportViewer(factura);
            _factura.ShowDialog();
        }
    }
}
