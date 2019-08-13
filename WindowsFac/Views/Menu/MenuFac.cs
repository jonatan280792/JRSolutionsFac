using System.Drawing;
using System.Windows.Forms;
using WindowsFac.Views.Facturacion;
using WindowsFac.Views.Parametros;
using WindowsFac.Views.Servicios;

namespace WindowsFac.Views.Menu
{
    public partial class MenuFac : Form
    {
        public MenuFac()
        {
            InitializeComponent();
            //MenuFac menu = new MenuFac();

            panellateral.BackColor = ColorTranslator.FromHtml("#42A5F5");
            panelsuperior.BackColor = ColorTranslator.FromHtml("#2196F3");
            parameters.BackColor = ColorTranslator.FromHtml("#42A5F5");
            clientsnew.BackColor = ColorTranslator.FromHtml("#42A5F5");
            services.BackColor = ColorTranslator.FromHtml("#42A5F5");
            
            factura.BackColor = ColorTranslator.FromHtml("#42A5F5");
            historic.BackColor = ColorTranslator.FromHtml("#42A5F5");
            users.BackColor = ColorTranslator.FromHtml("#42A5F5");
        }

        private void Panellateral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Close_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
        private void Parameters_Click(object sender, System.EventArgs e)
        {
            AbrirFormInPanel(new Parameters());
        }

        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.panelContainer.Controls.Count > 0)
                this.panelContainer.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(fh);
            this.panelContainer.Tag = fh;
            fh.Show();
        }

        private void Services_Click(object sender, System.EventArgs e)
        {
            AbrirFormInPanel(new Services());
        }

        private void Factura_Click(object sender, System.EventArgs e)
        {
            AbrirFormInPanel(new Facturation());
        }
    }
}
