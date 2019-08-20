using JRSolutionsFac.Business.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFac.Views.Servicios
{
    public partial class Services : Form
    {
        ListadoServiciosService _service = new ListadoServiciosService();
        public Services()
        {
            InitializeComponent();
            gridServicios.HeaderBgColor = ColorTranslator.FromHtml("#880088");
        }

        private void Services_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();

            table = _service.FindTable("-1");
            gridServicios.DataSource = table;
        }

        private void busqueda_Click(object sender, EventArgs e)
        {
            if (lblFiltro.Text == "")
            {
                MessageBox.Show("No a escrito nada aun.");
            }
            else
            {
                DataTable table = new DataTable();

                table = _service.FindTable(lblFiltro.Text.Trim());
                gridServicios.DataSource = table;
            }
            
        }

        private void GridHistorico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Edicion(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblServicio.Text = gridServicios.SelectedCells[0].Value.ToString();
            lblValor.Text = gridServicios.SelectedCells[1].Value.ToString();
        }
    }
}
