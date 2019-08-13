using JRSolutionsFac.Business.Services;
using JRSolutionsFac.Entity.Dtos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WindowsFac.Views.Formatos;

namespace WindowsFac.Views.Facturacion
{
    public partial class Facturation : Form
    {
        #region DECLARACIONES GLOBALES
        List<ListadoProductosDto> result;
        RegistroFacturaService _serviceFactura = new RegistroFacturaService();
        ListadoProductosService _productservice = new ListadoProductosService();
        ListadoFacturasService _facturasservice = new ListadoFacturasService();
        ListadoMarcasService _serviceMarcas = new ListadoMarcasService();
        #endregion

        public Facturation()
        {
            InitializeComponent();
            date_one.BackColor = ColorTranslator.FromHtml("#2196F3");
            date_two.BackColor = ColorTranslator.FromHtml("#2196F3");

            dropdowntipo_fac.NomalColor = ColorTranslator.FromHtml("#2196F3");
            dropdowntipo_fac.onHoverColor = ColorTranslator.FromHtml("#42A5F5");

            dropdownMarca.NomalColor = ColorTranslator.FromHtml("#2196F3");
            dropdownMarca.onHoverColor = ColorTranslator.FromHtml("#42A5F5");

            dropdwonCaja.NomalColor = ColorTranslator.FromHtml("#2196F3");
            dropdwonCaja.onHoverColor = ColorTranslator.FromHtml("#42A5F5");

            dropdowntipo_fac.NomalColor = ColorTranslator.FromHtml("#2196F3");

            servicio_1.NomalColor = ColorTranslator.FromHtml("#2196F3");
            servicio_1.onHoverColor = ColorTranslator.FromHtml("#42A5F5");
            
            servicio_2.NomalColor = ColorTranslator.FromHtml("#2196F3");
            servicio_2.onHoverColor = ColorTranslator.FromHtml("#42A5F5");
            servicio_3.NomalColor = ColorTranslator.FromHtml("#2196F3");
            servicio_3.onHoverColor = ColorTranslator.FromHtml("#42A5F5");
            servicio_4.NomalColor = ColorTranslator.FromHtml("#2196F3");
            servicio_4.onHoverColor = ColorTranslator.FromHtml("#42A5F5");
            servicio_5.NomalColor = ColorTranslator.FromHtml("#2196F3");
            servicio_5.onHoverColor = ColorTranslator.FromHtml("#42A5F5");
            servicio_6.NomalColor = ColorTranslator.FromHtml("#2196F3");
            servicio_6.onHoverColor = ColorTranslator.FromHtml("#42A5F5");
            servicio_7.NomalColor = ColorTranslator.FromHtml("#2196F3");
            servicio_7.onHoverColor = ColorTranslator.FromHtml("#42A5F5");
            servicio_8.NomalColor = ColorTranslator.FromHtml("#2196F3");
            servicio_8.onHoverColor = ColorTranslator.FromHtml("#42A5F5");
            servicio_9.NomalColor = ColorTranslator.FromHtml("#2196F3");
            servicio_9.onHoverColor = ColorTranslator.FromHtml("#42A5F5");
            servicio_10.NomalColor = ColorTranslator.FromHtml("#2196F3");
            servicio_11.onHoverColor = ColorTranslator.FromHtml("#42A5F5");
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {
                        
        }

        private void Facturation_Load(object sender, EventArgs e)
        {
            

            result = _productservice.Find();

            int conteo = 20;
            //for (var i = 0; i < conteo; i++)
            //{
            //    e = "lvlvalor" + i.ToString() + ".Text = '0'";
            //}
            lvlvalor1.Text = "0"; lvlvalor2.Text = "0"; lvlvalor3.Text = "0"; lvlvalor4.Text = "0"; lvlvalor5.Text = "0"; lvlvalor6.Text = "0"; lvlvalor7.Text = "0";
            lvlvalor8.Text = "0"; lvlvalor9.Text = "0"; lvlvalor10.Text = "0"; lvlvalor11.Text = "0"; lvlvalor12.Text = "0"; lvlvalor13.Text = "0";

            lvlRecibido.Text = "0";
            lvlCambio.Text = "$ 0";
            lvlCambioEmpy.Text = "-1";
            lvlTotal.Text = "$ 0";

            LoadCabecera();
            LoadCombos(result);
            
            //servicio_1.items = result;
        }
        public void LoadCabecera()
        {       
            //Numero de factura
            ListadoFacturasDto dato = new ListadoFacturasDto();
            dato = _facturasservice.GetAll().FirstOrDefault();
            int newFac = dato.NumFac + 1;
            lblFactura.Text = newFac.ToString();

            //Marcas de carros
            List<ListadoMarcasDto> marcas = new List<ListadoMarcasDto>();
            marcas = _serviceMarcas.GetAll();
            foreach (var item in marcas)
            {
                dropdownMarca.Items.Add(item.Marca);
            }
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
                //servicio_11.Items.Add(item.producto);
                //servicio_12.Items.Add(item.producto);
                //servicio_13.Items.Add(item.producto);
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
            lvlTotalEmpy.Text = total.ToString();
            lvlTotal.Text = totalizar;
            return totalizar;
        }

        private void servicio_4_change(object sender, EventArgs e)
        {
            lblcantidad4.Text = "1";
            lvlvalor4.Text = validador_precio(servicio_4.selectedValue).ToString();
            servicio_5.Enabled = true;
        }

        private void servicio_1_change(object sender, EventArgs e)
        {
            lblcantidad1.Text = "1";
            lvlvalor1.Text = validador_precio(servicio_1.selectedValue).ToString();
            total_factura();
            servicio_2.Enabled = true;

        }
        private void servicio_2_change(object sender, EventArgs e)
        {
            lblcantidad2.Text = "1";
            lvlvalor2.Text = validador_precio(servicio_2.selectedValue).ToString();
            total_factura();
            servicio_3.Enabled = true;
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
            servicio_4.Enabled = true;
        }

        private void servicio_5_change(object sender, EventArgs e)
        {
            lblcantidad5.Text = "1";
            lvlvalor5.Text = validador_precio(servicio_5.selectedValue).ToString();
            total_factura();
            servicio_6.Enabled = true;
        }

        private void servicio_6_change(object sender, EventArgs e)
        {
            lblcantidad6.Text = "1";
            lvlvalor6.Text = validador_precio(servicio_6.selectedValue).ToString();
            total_factura();
            servicio_7.Enabled = true;
        }

        private void servicio_7_change(object sender, EventArgs e)
        {
            lblcantidad7.Text = "1";
            lvlvalor7.Text = validador_precio(servicio_7.selectedValue).ToString();
            total_factura();
            servicio_8.Enabled = true;
        }

        private void servicio_8_change(object sender, EventArgs e)
        {
            lblcantidad8.Text = "1";
            lvlvalor8.Text = validador_precio(servicio_8.selectedValue).ToString();
            total_factura();
            servicio_9.Enabled = true;
        }

        private void servicio_9_change(object sender, EventArgs e)
        {
            lblcantidad9.Text = "1";
            lvlvalor9.Text = validador_precio(servicio_9.selectedValue).ToString();
            total_factura();
            servicio_10.Enabled = true;
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
            List<RegistroFacturaDto> servicios = new List<RegistroFacturaDto>();
            PrintPDF print = new PrintPDF();
            if(Convert.ToInt32(lvlCambioEmpy.Text) < 0)
            {
                MessageBox.Show("Por favor agregue el valor recibido");

            }
            else
            {
                if (servicio_1.selectedIndex != -1)
                {
                    servicios.Add(new RegistroFacturaDto()
                    {
                        NumFac = 2324,
                        Producto = servicio_1.selectedValue,
                        Cantidad = Convert.ToInt32(lblcantidad1.Text),
                        Valor = Convert.ToInt32(lvlvalor1.Text)
                    });
                }
                if (servicio_2.selectedIndex != -1)
                {
                    servicios.Add(new RegistroFacturaDto()
                    {
                        NumFac = 2324,
                        Producto = servicio_2.selectedValue,
                        Cantidad = Convert.ToInt32(lblcantidad2.Text),
                        Valor = Convert.ToInt32(lvlvalor2.Text)
                    });
                }
                if (servicio_3.selectedIndex != -1)
                {
                    servicios.Add(new RegistroFacturaDto()
                    {
                        NumFac = 2324,
                        Producto = servicio_3.selectedValue,
                        Cantidad = Convert.ToInt32(lblcantidad3.Text),
                        Valor = Convert.ToInt32(lvlvalor3.Text)
                    });
                }
                if (servicio_4.selectedIndex != -1)
                {
                    servicios.Add(new RegistroFacturaDto()
                    {
                        NumFac = 2324,
                        Producto = servicio_4.selectedValue,
                        Cantidad = Convert.ToInt32(lblcantidad4.Text),
                        Valor = Convert.ToInt32(lvlvalor4.Text)
                    });
                }
                if (servicio_5.selectedIndex != -1)
                {
                    servicios.Add(new RegistroFacturaDto()
                    {
                        NumFac = 2324,
                        Producto = servicio_5.selectedValue,
                        Cantidad = Convert.ToInt32(lblcantidad5.Text),
                        Valor = Convert.ToInt32(lvlvalor5.Text)
                    });
                }
                if (servicio_6.selectedIndex != -1)
                {
                    servicios.Add(new RegistroFacturaDto()
                    {
                        NumFac = 2324,
                        Producto = servicio_6.selectedValue,
                        Cantidad = Convert.ToInt32(lblcantidad6.Text),
                        Valor = Convert.ToInt32(lvlvalor6.Text)
                    });
                }
                if (servicio_7.selectedIndex != -1)
                {
                    servicios.Add(new RegistroFacturaDto()
                    {
                        NumFac = 2324,
                        Producto = servicio_7.selectedValue,
                        Cantidad = Convert.ToInt32(lblcantidad7.Text),
                        Valor = Convert.ToInt32(lvlvalor7.Text)
                    });
                }
                if (servicio_8.selectedIndex != -1)
                {
                    servicios.Add(new RegistroFacturaDto()
                    {
                        NumFac = 2324,
                        Producto = servicio_8.selectedValue,
                        Cantidad = Convert.ToInt32(lblcantidad8.Text),
                        Valor = Convert.ToInt32(lvlvalor8.Text)
                    });
                }
                if (servicio_9.selectedIndex != -1)
                {
                    servicios.Add(new RegistroFacturaDto()
                    {
                        NumFac = 2324,
                        Producto = servicio_9.selectedValue,
                        Cantidad = Convert.ToInt32(lblcantidad9.Text),
                        Valor = Convert.ToInt32(lvlvalor9.Text)
                    });
                }
                if (servicio_10.selectedIndex != -1)
                {
                    servicios.Add(new RegistroFacturaDto()
                    {
                        NumFac = 2324,
                        Producto = servicio_10.selectedValue,
                        Cantidad = Convert.ToInt32(lblcantidad10.Text),
                        Valor = Convert.ToInt32(lvlvalor10.Text)
                    });
                }

                bool estado = _serviceFactura.Add(servicios);

            }
            //print.ShowDialog();
            btnImprimir.Enabled = true;
        }


        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            PrintPDF print = new PrintPDF();
            //string reportName = "impresion.rdlc";
            //Graphics g = this.CreateGraphics();
            //bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            //Graphics mg = Graphics.FromImage(bmp);
            //mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            //printPreviewDialog1.ShowDialog();
            print.ShowDialog();

        }

        Bitmap bmp;
        private void printDocument1_print(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void calculate(object sender, KeyEventArgs e)
        {
            total_factura();
        }

        private void calculate_cambio(object sender, KeyEventArgs e)
        {
            total_cambio();
        }
        public string total_cambio()
        {
            if(lvlRecibido.Text == "")
            {
                lvlRecibido.Text = "0";
            }
            int cambio = Convert.ToInt32(lvlRecibido.Text) - Convert.ToInt32(lvlTotalEmpy.Text);
            string totalizar = cambio.ToString("C");
            lvlCambio.Text = totalizar;
            lvlCambioEmpy.Text = cambio.ToString();
            return totalizar;
        }
    }
}
