using JRSolutionsFac.Business.Services;
using JRSolutionsFac.Entity.Dtos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFac.Views.Facturacion
{
    public partial class Facturation : Form
    {
        List<ListadoProductosDto> result;
        public Facturation()
        {
            InitializeComponent();
            date_one.BackColor = ColorTranslator.FromHtml("#2196F3");
            date_two.BackColor = ColorTranslator.FromHtml("#2196F3");

            servicio_1.BackColor = ColorTranslator.FromHtml("#2196F3");
            servicio_2.BackColor = ColorTranslator.FromHtml("#2196F3");
            servicio_3.BackColor = ColorTranslator.FromHtml("#2196F3");
            servicio_4.BackColor = ColorTranslator.FromHtml("#2196F3");
            servicio_5.BackColor = ColorTranslator.FromHtml("#2196F3");
            servicio_6.BackColor = ColorTranslator.FromHtml("#2196F3");
            servicio_7.BackColor = ColorTranslator.FromHtml("#2196F3");
            servicio_8.BackColor = ColorTranslator.FromHtml("#2196F3");
            servicio_9.BackColor = ColorTranslator.FromHtml("#2196F3");
            servicio_10.BackColor = ColorTranslator.FromHtml("#2196F3");
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {
                        
        }

        private void Facturation_Load(object sender, EventArgs e)
        {
            ListadoProductosService _productservice = new ListadoProductosService();

            result = _productservice.Find();

            int conteo = 20;
            //for (var i = 0; i < conteo; i++)
            //{
            //    e = "lvlvalor" + i.ToString() + ".Text = '0'";
            //}
            lvlvalor1.Text = "0"; lvlvalor2.Text = "0"; lvlvalor3.Text = "0"; lvlvalor4.Text = "0"; lvlvalor5.Text = "0"; lvlvalor6.Text = "0"; lvlvalor7.Text = "0";
            lvlvalor8.Text = "0"; lvlvalor9.Text = "0"; lvlvalor10.Text = "0"; lvlvalor11.Text = "0"; lvlvalor12.Text = "0"; lvlvalor13.Text = "0";


            LoadCombos(result);
            
            //servicio_1.items = result;
        }

        public void LoadCombos(List<ListadoProductosDto> result)
        {
            
            foreach (var item in result)
            {
                servicio_1.Items.Add(item.producto);
                servicio_2.Items.Add(item.producto);
                servicio_3.Items.Add(item.producto);
                servicio_4.Items.Add(item.producto);
                servicio_5.Items.Add(item.producto);
                servicio_6.Items.Add(item.producto);
                servicio_7.Items.Add(item.producto);
                servicio_8.Items.Add(item.producto);
                servicio_9.Items.Add(item.producto);
                servicio_10.Items.Add(item.producto);
                servicio_11.Items.Add(item.producto);
                servicio_12.Items.Add(item.producto);
                servicio_13.Items.Add(item.producto);
            }
        }
        public int validador_precio(string servicio)
        {
            var filter = result.Where(x => x.producto == servicio).Select(x => x.valor);

            return Convert.ToInt32(filter.FirstOrDefault());
        }

        public string total_factura()
        {
            int total = Convert.ToInt32(lvlvalor1.Text) + Convert.ToInt32(lvlvalor2.Text) + Convert.ToInt32(lvlvalor3.Text) + Convert.ToInt32(lvlvalor4.Text) +
                Convert.ToInt32(lvlvalor5.Text) + Convert.ToInt32(lvlvalor6.Text) + Convert.ToInt32(lvlvalor7.Text) + Convert.ToInt32(lvlvalor8.Text) +
                Convert.ToInt32(lvlvalor9.Text) + Convert.ToInt32(lvlvalor10.Text);
            string totalizar = total.ToString("C");
            lvlTotal.Text = totalizar;
            return totalizar;
        }

        private void servicio_4_change(object sender, EventArgs e)
        {
            lblcantidad4.Text = "1";
            lvlvalor4.Text = validador_precio(servicio_4.selectedValue).ToString();
        }

        private void servicio_1_change(object sender, EventArgs e)
        {
            lblcantidad1.Text = "1";
            lvlvalor1.Text = validador_precio(servicio_1.selectedValue).ToString();
            total_factura();

        }
        private void servicio_2_change(object sender, EventArgs e)
        {
            lblcantidad2.Text = "1";
            lvlvalor2.Text = validador_precio(servicio_2.selectedValue).ToString();
            total_factura();
        }

        //public void validador_precio(string servicio)
        //{
        //    int valor = Convert.ToInt32(result.Where(s => s.producto == servicio).Select(s => s.valor));            
        //}

        


      
        public int validar_numeros(object sender, KeyPressEventArgs e)
        {
            int exito = 1;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
                exito = 0;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                exito = 0;
            }  

            return exito;
        }

        private void lvlvalor_KeyPress(object sender, KeyPressEventArgs e)
        {
            int exitoso = validar_numeros(sender, e);
            if (exitoso == 1)
            {
                total_factura();
            }
        }

        private void servicio_3_change(object sender, EventArgs e)
        {
            lblcantidad3.Text = "1";
            lvlvalor3.Text = validador_precio(servicio_3.selectedValue).ToString();
            total_factura();
        }

        private void servicio_5_change(object sender, EventArgs e)
        {
            lblcantidad5.Text = "1";
            lvlvalor5.Text = validador_precio(servicio_5.selectedValue).ToString();
            total_factura();
        }

        private void servicio_6_change(object sender, EventArgs e)
        {
            lblcantidad6.Text = "1";
            lvlvalor6.Text = validador_precio(servicio_6.selectedValue).ToString();
            total_factura();
        }

        private void servicio_7_change(object sender, EventArgs e)
        {
            lblcantidad7.Text = "1";
            lvlvalor7.Text = validador_precio(servicio_7.selectedValue).ToString();
            total_factura();
        }

        private void servicio_8_change(object sender, EventArgs e)
        {
            lblcantidad8.Text = "1";
            lvlvalor8.Text = validador_precio(servicio_8.selectedValue).ToString();
            total_factura();
        }

        private void servicio_9_change(object sender, EventArgs e)
        {
            lblcantidad9.Text = "1";
            lvlvalor9.Text = validador_precio(servicio_9.selectedValue).ToString();
            total_factura();
        }

        private void servicio_10_change(object sender, EventArgs e)
        {
            lblcantidad10.Text = "1";
            lvlvalor10.Text = validador_precio(servicio_10.selectedValue).ToString();
            total_factura();
        }

        private void changes_Values(object sender, EventArgs e)
        {
            total_factura();
        }

        private void BtnGuardarFactura_Click(object sender, EventArgs e)
        {
            if(lvlRecibido.Text == "")
            {
                MessageBox.Show("Por favor agregue el valor recibido");

            }
            
        }
    }
}
