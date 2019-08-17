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
        }

        private void Services_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();

            table = _service.FindTable("-1");
            gridHistorico.DataSource = table;
        }
    }
}
