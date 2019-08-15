using JRSolutionsFac.Business.Services;
using JRSolutionsFac.Entity.Dtos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WindowsFac.Views.Formatos;
using WindowsFac.Views.Report;
using WindowsFac.Views.ShowsAlerts;

namespace WindowsFac.Views.Facturacion
{
    public partial class Facturation : Form
    {
        #region DECLARACIONES GLOBALES
        //Success dialog = new Success();


        List<ListadoProductosDto> result;
        List<ListadoMarcasDto> marcas = new List<ListadoMarcasDto>();
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
            dropdowntipo_fac.onHoverColor = ColorTranslator.FromHtml("#42A5F5");

            dropdownTipoDoc.NomalColor = ColorTranslator.FromHtml("#2196F3");
            dropdownTipoDoc.onHoverColor = ColorTranslator.FromHtml("#42A5F5");

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
            servicio_10.onHoverColor = ColorTranslator.FromHtml("#42A5F5");
            servicio_11.NomalColor = ColorTranslator.FromHtml("#2196F3");
            servicio_11.onHoverColor = ColorTranslator.FromHtml("#42A5F5");
            servicio_12.NomalColor = ColorTranslator.FromHtml("#2196F3");
            servicio_12.onHoverColor = ColorTranslator.FromHtml("#42A5F5");
            servicio_13.NomalColor = ColorTranslator.FromHtml("#2196F3");
            servicio_13.onHoverColor = ColorTranslator.FromHtml("#42A5F5");
            servicio_14.NomalColor = ColorTranslator.FromHtml("#2196F3");
            servicio_14.onHoverColor = ColorTranslator.FromHtml("#42A5F5");
            servicio_15.NomalColor = ColorTranslator.FromHtml("#2196F3");
            servicio_15.onHoverColor = ColorTranslator.FromHtml("#42A5F5");
            servicio_16.NomalColor = ColorTranslator.FromHtml("#2196F3");
            servicio_16.onHoverColor = ColorTranslator.FromHtml("#42A5F5");
            servicio_17.NomalColor = ColorTranslator.FromHtml("#2196F3");
            servicio_17.onHoverColor = ColorTranslator.FromHtml("#42A5F5");
            servicio_18.NomalColor = ColorTranslator.FromHtml("#2196F3");
            servicio_18.onHoverColor = ColorTranslator.FromHtml("#42A5F5");
            servicio_19.NomalColor = ColorTranslator.FromHtml("#2196F3");
            servicio_19.onHoverColor = ColorTranslator.FromHtml("#42A5F5");
            servicio_20.NomalColor = ColorTranslator.FromHtml("#2196F3");
            servicio_20.onHoverColor = ColorTranslator.FromHtml("#42A5F5");
            servicio_21.NomalColor = ColorTranslator.FromHtml("#2196F3");
            servicio_21.onHoverColor = ColorTranslator.FromHtml("#42A5F5");
            servicio_22.NomalColor = ColorTranslator.FromHtml("#2196F3");
            servicio_22.onHoverColor = ColorTranslator.FromHtml("#42A5F5");
            servicio_23.onHoverColor = ColorTranslator.FromHtml("#42A5F5");
            servicio_23.NomalColor = ColorTranslator.FromHtml("#2196F3");
            servicio_24.onHoverColor = ColorTranslator.FromHtml("#42A5F5");
            servicio_24.NomalColor = ColorTranslator.FromHtml("#2196F3");
            servicio_25.onHoverColor = ColorTranslator.FromHtml("#42A5F5");
            servicio_25.NomalColor = ColorTranslator.FromHtml("#2196F3");
            servicio_26.onHoverColor = ColorTranslator.FromHtml("#42A5F5");
            servicio_26.onHoverColor = ColorTranslator.FromHtml("#42A5F5");
            servicio_27.onHoverColor = ColorTranslator.FromHtml("#42A5F5");
            servicio_27.onHoverColor = ColorTranslator.FromHtml("#42A5F5");
            servicio_28.onHoverColor = ColorTranslator.FromHtml("#42A5F5");
            servicio_28.onHoverColor = ColorTranslator.FromHtml("#42A5F5");
            servicio_29.onHoverColor = ColorTranslator.FromHtml("#42A5F5");
            servicio_29.onHoverColor = ColorTranslator.FromHtml("#42A5F5");
            servicio_30.onHoverColor = ColorTranslator.FromHtml("#42A5F5");
            servicio_30.onHoverColor = ColorTranslator.FromHtml("#42A5F5");
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {
                        
        }

        private void Facturation_Load(object sender, EventArgs e)
        {
            
            //Facturation fac = new Facturation();

            //dialog.Show();

            //Application.DoEvents();

            // Show or load the main form.
            
            marcas = _serviceMarcas.GetAll();
            foreach (var item in marcas)
            {
                dropdownMarca.Items.Add(item.Marca);
            }

            result = _productservice.Find();
            LoadCabecera();
            LoadCombos(result);

            //fac.ShowDialog();
            //dialog.Close();
            //servicio_1.items = result;
        }

        protected override void OnLoad(EventArgs args)
        {
            //dialog.Show();
            base.OnLoad(args);

            Application.Idle += new EventHandler(OnLoaded);
            
        }
        private void OnLoaded(object sender, EventArgs args)
        {
            
            Application.Idle -= new EventHandler(OnLoaded);
            //dialog.Hide();
            //dialog.Close();

            // TODO: add relevant code here

        }
        public void LoadCabecera()
        {       
            //Numero de factura
            ListadoFacturasDto dato = new ListadoFacturasDto();
            dato = _facturasservice.GetAll().FirstOrDefault();
            int newFac = dato.NumFac + 1;
            lblFactura.Text = newFac.ToString();

            //Marcas de carros            


            dropdowntipo_fac.selectedIndex = 0;
            dropdownTipoDoc.selectedIndex = 0;
            dropdwonCaja.selectedIndex = 0;
            lvlplaca.Text = "";
            lblDocumento.Text = "";
            lvlCliente.Text = "";
            lblTipo.Text = "";
            lvlMecanica.Text = "";
            lblModelo.Text = "";
            //Resetea valores TextBox
            lvlvalor1.Text = "0"; lvlvalor2.Text = "0"; lvlvalor3.Text = "0"; lvlvalor4.Text = "0"; lvlvalor5.Text = "0"; lvlvalor6.Text = "0"; lvlvalor7.Text = "0";
            lvlvalor8.Text = "0"; lvlvalor9.Text = "0"; lvlvalor10.Text = "0"; lvlvalor11.Text = "0"; lvlvalor12.Text = "0"; lvlvalor13.Text = "0";
            lvlvalor14.Text = "0"; lvlvalor15.Text = "0"; lvlvalor16.Text = "0"; lvlvalor17.Text = "0"; lvlvalor18.Text = "0"; lvlvalor19.Text = "0"; lvlvalor20.Text = "0";
            lvlvalor21.Text = "0"; lvlvalor22.Text = "0"; lvlvalor23.Text = "0"; lvlvalor24.Text = "0"; lvlvalor25.Text = "0"; lvlvalor26.Text = "0";
            lvlvalor27.Text = "0"; lvlvalor28.Text = "0"; lvlvalor29.Text = "0"; lvlvalor30.Text = "0";

            lvlRecibido.Text = "";
            lvlCambio.Text = "$ 0";
            lvlCambioEmpy.Text = "-1";
            lvlTotal.Text = "$ 0";

        }

        public IEnumerable<object> test()
        {            
            return result;
        }

        public void LoadCombos(List<ListadoProductosDto> result)
        {
           // IEnumerable<object> dasdsad = test();
            
           // ObjectCo
            
           //// dasdsad = result.AsEnumerable();
           // servicio_1.Items = dasdsad;
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
            }            
        }

        public void LoadCombos2()
        {
            foreach (var item in result)
            {
                servicio_11.Items.Add(item.producto);
                servicio_12.Items.Add(item.producto);
                servicio_13.Items.Add(item.producto);
                servicio_14.Items.Add(item.producto);
                servicio_15.Items.Add(item.producto);
                servicio_16.Items.Add(item.producto);
                servicio_17.Items.Add(item.producto);
                servicio_18.Items.Add(item.producto);
                servicio_19.Items.Add(item.producto);
                servicio_20.Items.Add(item.producto);
            }
        }

        public void DisabledControls()
        {
            servicio_2.Enabled = false;
            servicio_3.Enabled = false;
            servicio_4.Enabled = false;
            servicio_5.Enabled = false;
            servicio_6.Enabled = false;
            servicio_7.Enabled = false;
            servicio_8.Enabled = false;
            servicio_9.Enabled = false;
            servicio_10.Enabled = false;
            servicio_11.Enabled = false;
            servicio_12.Enabled = false;
            servicio_13.Enabled = false;
            servicio_14.Enabled = false;
            servicio_15.Enabled = false;
            servicio_16.Enabled = false;
            servicio_17.Enabled = false;
            servicio_18.Enabled = false;
            servicio_19.Enabled = false;
            servicio_20.Enabled = false;
            servicio_21.Enabled = false;
            servicio_22.Enabled = false;
            servicio_23.Enabled = false;
            servicio_24.Enabled = false;
            servicio_25.Enabled = false;
            servicio_26.Enabled = false;
            servicio_27.Enabled = false;
            servicio_28.Enabled = false;
            servicio_29.Enabled = false;
            servicio_30.Enabled = false;
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
                Convert.ToInt32(lvlvalor9.Text) + Convert.ToInt32(lvlvalor10.Text) + Convert.ToInt32(lvlvalor11.Text) + Convert.ToInt32(lvlvalor12.Text) +
                Convert.ToInt32(lvlvalor13.Text) + Convert.ToInt32(lvlvalor14.Text) + Convert.ToInt32(lvlvalor15.Text) + Convert.ToInt32(lvlvalor16.Text) +
                Convert.ToInt32(lvlvalor17.Text) + Convert.ToInt32(lvlvalor18.Text) + Convert.ToInt32(lvlvalor19.Text) + Convert.ToInt32(lvlvalor20.Text) +
                Convert.ToInt32(lvlvalor21.Text) + Convert.ToInt32(lvlvalor22.Text) + Convert.ToInt32(lvlvalor23.Text) + Convert.ToInt32(lvlvalor24.Text) +
                Convert.ToInt32(lvlvalor25.Text) + Convert.ToInt32(lvlvalor26.Text) + Convert.ToInt32(lvlvalor27.Text) + Convert.ToInt32(lvlvalor28.Text) +
                Convert.ToInt32(lvlvalor29.Text) + Convert.ToInt32(lvlvalor30.Text);
            string totalizar = total.ToString("C");
            lvlTotalEmpy.Text = total.ToString();
            lvlTotal.Text = totalizar;
            return totalizar;
        }

        private void servicio_4_change(object sender, EventArgs e)
        {
            lblcantidad4.Text = "1";
            lvlvalor4.Text = validador_precio(servicio_4.selectedValue).ToString();
            total_factura();
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
            if (servicio_11.items.Length == 0)
            {
                LoadCombos2();
            }
            
            servicio_11.Enabled = true;
        }

        private void changes_Values(object sender, EventArgs e)
        {
            total_factura();
        }

        private void BtnGuardarFactura_Click(object sender, EventArgs e)
        {
            List<RegistroFacturaDetalleDto> servicios = new List<RegistroFacturaDetalleDto>();
            RegistroFacturaDto model = new RegistroFacturaDto();
            PrintPDF print = new PrintPDF();
            
            if (servicio_1.selectedIndex == -1)
            {
                MessageBox.Show("No se puede guardar una factura sin ningun servicio, por facor verifique.");
            }
            else if((Convert.ToInt32(lvlCambioEmpy.Text) < 0) || lvlCambio.Text == "")
            {
                MessageBox.Show("Por favor agregue el el dinero recibido.");

            }
            else if ((lvlplaca.Text == "") || (lblTipo.Text == "") || (dropdownMarca.selectedIndex == -1))
            {
                MessageBox.Show("Para guardar la factura debe diligencia minimo la Placa, El Tipo y la Marca.");
            }
            else
            {
                model.nit = lblnit.Text;
                model.numfac = Convert.ToInt32(lblFactura.Text);
                model.detalle = dropdowntipo_fac.selectedValue;
                model.cajero = dropdwonCaja.selectedValue;
                model.placa = lvlplaca.Text;
                model.marca = dropdownMarca.selectedValue;
                model.tipo_doc = dropdownTipoDoc.selectedValue;
                if (lblDocumento.Text == "") { model.numero_doc = "N/A";} else { model.numero_doc = lblDocumento.Text; }
                model.nom_client = lvlCliente.Text.Trim();
                if (lblModelo.Text == "") { model.modelo = 0; } else { model.modelo = Convert.ToInt32(lblModelo.Text); }
                model.tipo = lblTipo.Text.Trim();

                model.total = Convert.ToInt32(lvlTotalEmpy.Text);
                model.valorrecibido = Convert.ToInt32(lvlRecibido.Text);
                model.cambio = Convert.ToInt32(lvlCambioEmpy.Text);

                model.fecha = date_one.Value;
                model.fechaentrega = date_two.Value;

                model.mecanica = lvlMecanica.Text.Trim();
                model.latoneria = lvlLatoneria.Text.Trim();
                model.pintura = lblPintura.Text.Trim();                

                llenarServicios(servicios);
                bool estado = _serviceFactura.Add(model, servicios);
                if (estado)
                {

                    ReportViewer _factura = new ReportViewer(model.numfac);

                    MessageBox.Show("Factura Grabada exitosamente.");
                    _factura.ShowDialog();
                    //print.ShowDialog();
                    btnImprimir.Enabled = true;
                    //LoadCabecera();
                    //if (servicio_1.items.Length == 0)
                    //{
                    //    LoadCombos(result);
                    //}                    
                    dropdownMarca.Clear();
                    DisabledControls();

                    //Facturation_Load(sender, e);

                    servicio_2.selectedIndex = 0;
                    //servicio_2.SelectedItem = "";
                    servicio_3.selectedIndex = -1;
                    servicio_4.selectedIndex = -1;
                    servicio_5.selectedIndex = -1;
                    servicio_6.selectedIndex = -1;
                    servicio_7.selectedIndex = -1;
                    servicio_8.selectedIndex = -1;
                    servicio_9.selectedIndex = -1;
                    servicio_10.selectedIndex = -1;
                    servicio_11.selectedIndex = -1;
                    servicio_12.selectedIndex = -1;
                    servicio_13.selectedIndex = -1;
                    servicio_14.selectedIndex = -1;
                    servicio_15.selectedIndex = -1;
                    servicio_16.selectedIndex = -1;
                    servicio_17.selectedIndex = -1;
                    servicio_18.selectedIndex = -1;
                    servicio_19.selectedIndex = -1;
                    servicio_20.selectedIndex = -1;
                    servicio_21.selectedIndex = -1;
                    servicio_22.selectedIndex = -1;
                    servicio_23.selectedIndex = -1;
                    servicio_24.selectedIndex = -1;
                    servicio_25.selectedIndex = -1;
                    servicio_26.selectedIndex = -1;
                    servicio_27.selectedIndex = -1;
                    servicio_28.selectedIndex = -1;
                    servicio_29.selectedIndex = -1;
                    servicio_30.selectedIndex = -1;


                }
                else
                {
                    MessageBox.Show("A ocurrido un error.");
                }
            }
            
        }
        public List<RegistroFacturaDetalleDto> llenarServicios(List<RegistroFacturaDetalleDto> servicios)
        {
            
            if (servicio_1.selectedIndex != -1)
            {
                servicios.Add(new RegistroFacturaDetalleDto()
                {
                    NumFac = Convert.ToInt32(lblFactura.Text),
                    Producto = servicio_1.selectedValue,
                    Cantidad = Convert.ToInt32(lblcantidad1.Text),
                    Valor = Convert.ToInt32(lvlvalor1.Text)
                });
            }
            if (servicio_2.selectedIndex != -1)
            {
                servicios.Add(new RegistroFacturaDetalleDto()
                {
                    NumFac = Convert.ToInt32(lblFactura.Text),
                    Producto = servicio_2.selectedValue,
                    Cantidad = Convert.ToInt32(lblcantidad2.Text),
                    Valor = Convert.ToInt32(lvlvalor2.Text)
                });
            }
            if (servicio_3.selectedIndex != -1)
            {
                servicios.Add(new RegistroFacturaDetalleDto()
                {
                    NumFac = Convert.ToInt32(lblFactura.Text),
                    Producto = servicio_3.selectedValue,
                    Cantidad = Convert.ToInt32(lblcantidad3.Text),
                    Valor = Convert.ToInt32(lvlvalor3.Text)
                });
            }
            if (servicio_4.selectedIndex != -1)
            {
                servicios.Add(new RegistroFacturaDetalleDto()
                {
                    NumFac = Convert.ToInt32(lblFactura.Text),
                    Producto = servicio_4.selectedValue,
                    Cantidad = Convert.ToInt32(lblcantidad4.Text),
                    Valor = Convert.ToInt32(lvlvalor4.Text)
                });
            }
            if (servicio_5.selectedIndex != -1)
            {
                servicios.Add(new RegistroFacturaDetalleDto()
                {
                    NumFac = Convert.ToInt32(lblFactura.Text),
                    Producto = servicio_5.selectedValue,
                    Cantidad = Convert.ToInt32(lblcantidad5.Text),
                    Valor = Convert.ToInt32(lvlvalor5.Text)
                });
            }
            if (servicio_6.selectedIndex != -1)
            {
                servicios.Add(new RegistroFacturaDetalleDto()
                {
                    NumFac = Convert.ToInt32(lblFactura.Text),
                    Producto = servicio_6.selectedValue,
                    Cantidad = Convert.ToInt32(lblcantidad6.Text),
                    Valor = Convert.ToInt32(lvlvalor6.Text)
                });
            }
            if (servicio_7.selectedIndex != -1)
            {
                servicios.Add(new RegistroFacturaDetalleDto()
                {
                    NumFac = Convert.ToInt32(lblFactura.Text),
                    Producto = servicio_7.selectedValue,
                    Cantidad = Convert.ToInt32(lblcantidad7.Text),
                    Valor = Convert.ToInt32(lvlvalor7.Text)
                });
            }
            if (servicio_8.selectedIndex != -1)
            {
                servicios.Add(new RegistroFacturaDetalleDto()
                {
                    NumFac = Convert.ToInt32(lblFactura.Text),
                    Producto = servicio_8.selectedValue,
                    Cantidad = Convert.ToInt32(lblcantidad8.Text),
                    Valor = Convert.ToInt32(lvlvalor8.Text)
                });
            }
            if (servicio_9.selectedIndex != -1)
            {
                servicios.Add(new RegistroFacturaDetalleDto()
                {
                    NumFac = Convert.ToInt32(lblFactura.Text),
                    Producto = servicio_9.selectedValue,
                    Cantidad = Convert.ToInt32(lblcantidad9.Text),
                    Valor = Convert.ToInt32(lvlvalor9.Text)
                });
            }
            if (servicio_10.selectedIndex != -1)
            {
                servicios.Add(new RegistroFacturaDetalleDto()
                {
                    NumFac = Convert.ToInt32(lblFactura.Text),
                    Producto = servicio_10.selectedValue,
                    Cantidad = Convert.ToInt32(lblcantidad10.Text),
                    Valor = Convert.ToInt32(lvlvalor10.Text)
                });
            }
            if (servicio_11.selectedIndex != -1)
            {
                servicios.Add(new RegistroFacturaDetalleDto()
                {
                    NumFac = Convert.ToInt32(lblFactura.Text),
                    Producto = servicio_11.selectedValue,
                    Cantidad = Convert.ToInt32(lblcantidad11.Text),
                    Valor = Convert.ToInt32(lvlvalor11.Text)
                });
            }
            if (servicio_12.selectedIndex != -1)
            {
                servicios.Add(new RegistroFacturaDetalleDto()
                {
                    NumFac = Convert.ToInt32(lblFactura.Text),
                    Producto = servicio_12.selectedValue,
                    Cantidad = Convert.ToInt32(lblcantidad12.Text),
                    Valor = Convert.ToInt32(lvlvalor12.Text)
                });
            }
            if (servicio_13.selectedIndex != -1)
            {
                servicios.Add(new RegistroFacturaDetalleDto()
                {
                    NumFac = Convert.ToInt32(lblFactura.Text),
                    Producto = servicio_13.selectedValue,
                    Cantidad = Convert.ToInt32(lblcantidad13.Text),
                    Valor = Convert.ToInt32(lvlvalor13.Text)
                });
            }
            if (servicio_14.selectedIndex != -1)
            {
                servicios.Add(new RegistroFacturaDetalleDto()
                {
                    NumFac = Convert.ToInt32(lblFactura.Text),
                    Producto = servicio_14.selectedValue,
                    Cantidad = Convert.ToInt32(lblcantidad14.Text),
                    Valor = Convert.ToInt32(lvlvalor14.Text)
                });
            }
            if (servicio_15.selectedIndex != -1)
            {
                servicios.Add(new RegistroFacturaDetalleDto()
                {
                    NumFac = Convert.ToInt32(lblFactura.Text),
                    Producto = servicio_15.selectedValue,
                    Cantidad = Convert.ToInt32(lblcantidad15.Text),
                    Valor = Convert.ToInt32(lvlvalor15.Text)
                });
            }
            if (servicio_16.selectedIndex != -1)
            {
                servicios.Add(new RegistroFacturaDetalleDto()
                {
                    NumFac = Convert.ToInt32(lblFactura.Text),
                    Producto = servicio_16.selectedValue,
                    Cantidad = Convert.ToInt32(lblcantidad16.Text),
                    Valor = Convert.ToInt32(lvlvalor16.Text)
                });
            }
            if (servicio_17.selectedIndex != -1)
            {
                servicios.Add(new RegistroFacturaDetalleDto()
                {
                    NumFac = Convert.ToInt32(lblFactura.Text),
                    Producto = servicio_17.selectedValue,
                    Cantidad = Convert.ToInt32(lblcantidad17.Text),
                    Valor = Convert.ToInt32(lvlvalor17.Text)
                });
            }
            if (servicio_18.selectedIndex != -1)
            {
                servicios.Add(new RegistroFacturaDetalleDto()
                {
                    NumFac = Convert.ToInt32(lblFactura.Text),
                    Producto = servicio_18.selectedValue,
                    Cantidad = Convert.ToInt32(lblcantidad18.Text),
                    Valor = Convert.ToInt32(lvlvalor18.Text)
                });
            }
            if (servicio_19.selectedIndex != -1)
            {
                servicios.Add(new RegistroFacturaDetalleDto()
                {
                    NumFac = Convert.ToInt32(lblFactura.Text),
                    Producto = servicio_19.selectedValue,
                    Cantidad = Convert.ToInt32(lblcantidad19.Text),
                    Valor = Convert.ToInt32(lvlvalor19.Text)
                });
            }
            if (servicio_20.selectedIndex != -1)
            {
                servicios.Add(new RegistroFacturaDetalleDto()
                {
                    NumFac = Convert.ToInt32(lblFactura.Text),
                    Producto = servicio_20.selectedValue,
                    Cantidad = Convert.ToInt32(lblcantidad20.Text),
                    Valor = Convert.ToInt32(lvlvalor20.Text)
                });
            }
            if (servicio_21.selectedIndex != -1)
            {
                servicios.Add(new RegistroFacturaDetalleDto()
                {
                    NumFac = Convert.ToInt32(lblFactura.Text),
                    Producto = servicio_21.selectedValue,
                    Cantidad = Convert.ToInt32(lblcantidad21.Text),
                    Valor = Convert.ToInt32(lvlvalor21.Text)
                });
            }
            if (servicio_22.selectedIndex != -1)
            {
                servicios.Add(new RegistroFacturaDetalleDto()
                {
                    NumFac = Convert.ToInt32(lblFactura.Text),
                    Producto = servicio_22.selectedValue,
                    Cantidad = Convert.ToInt32(lblcantidad22.Text),
                    Valor = Convert.ToInt32(lvlvalor22.Text)
                });
            }
            if (servicio_23.selectedIndex != -1)
            {
                servicios.Add(new RegistroFacturaDetalleDto()
                {
                    NumFac = Convert.ToInt32(lblFactura.Text),
                    Producto = servicio_23.selectedValue,
                    Cantidad = Convert.ToInt32(lblcantidad23.Text),
                    Valor = Convert.ToInt32(lvlvalor23.Text)
                });
            }
            if (servicio_24.selectedIndex != -1)
            {
                servicios.Add(new RegistroFacturaDetalleDto()
                {
                    NumFac = Convert.ToInt32(lblFactura.Text),
                    Producto = servicio_24.selectedValue,
                    Cantidad = Convert.ToInt32(lblcantidad24.Text),
                    Valor = Convert.ToInt32(lvlvalor24.Text)
                });
            }
            if (servicio_25.selectedIndex != -1)
            {
                servicios.Add(new RegistroFacturaDetalleDto()
                {
                    NumFac = Convert.ToInt32(lblFactura.Text),
                    Producto = servicio_25.selectedValue,
                    Cantidad = Convert.ToInt32(lblcantidad25.Text),
                    Valor = Convert.ToInt32(lvlvalor25.Text)
                });
            }
            if (servicio_26.selectedIndex != -1)
            {
                servicios.Add(new RegistroFacturaDetalleDto()
                {
                    NumFac = Convert.ToInt32(lblFactura.Text),
                    Producto = servicio_26.selectedValue,
                    Cantidad = Convert.ToInt32(lblcantidad26.Text),
                    Valor = Convert.ToInt32(lvlvalor26.Text)
                });
            }
            if (servicio_27.selectedIndex != -1)
            {
                servicios.Add(new RegistroFacturaDetalleDto()
                {
                    NumFac = Convert.ToInt32(lblFactura.Text),
                    Producto = servicio_27.selectedValue,
                    Cantidad = Convert.ToInt32(lblcantidad27.Text),
                    Valor = Convert.ToInt32(lvlvalor27.Text)
                });
            }
            if (servicio_28.selectedIndex != -1)
            {
                servicios.Add(new RegistroFacturaDetalleDto()
                {
                    NumFac = Convert.ToInt32(lblFactura.Text),
                    Producto = servicio_28.selectedValue,
                    Cantidad = Convert.ToInt32(lblcantidad28.Text),
                    Valor = Convert.ToInt32(lvlvalor28.Text)
                });
            }
            if (servicio_29.selectedIndex != -1)
            {
                servicios.Add(new RegistroFacturaDetalleDto()
                {
                    NumFac = Convert.ToInt32(lblFactura.Text),
                    Producto = servicio_29.selectedValue,
                    Cantidad = Convert.ToInt32(lblcantidad29.Text),
                    Valor = Convert.ToInt32(lvlvalor29.Text)
                });
            }
            if (servicio_30.selectedIndex != -1)
            {
                servicios.Add(new RegistroFacturaDetalleDto()
                {
                    NumFac = Convert.ToInt32(lblFactura.Text),
                    Producto = servicio_30.selectedValue,
                    Cantidad = Convert.ToInt32(lblcantidad30.Text),
                    Valor = Convert.ToInt32(lvlvalor30.Text)
                });
            }

            return servicios;
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

        private void servicio_11_change(object sender, EventArgs e)
        {
            lblcantidad11.Text = "1";
            lvlvalor11.Text = validador_precio(servicio_11.selectedValue).ToString();
            total_factura();
            servicio_12.Enabled = true;
        }

        private void servicio_12_change(object sender, EventArgs e)
        {
            lblcantidad12.Text = "1";
            lvlvalor12.Text = validador_precio(servicio_12.selectedValue).ToString();
            total_factura();
            servicio_13.Enabled = true;
        }

        private void servicio_13_change(object sender, EventArgs e)
        {
            lblcantidad13.Text = "1";
            lvlvalor13.Text = validador_precio(servicio_13.selectedValue).ToString();
            total_factura();
            servicio_14.Enabled = true;
        }

        private void servicio_14_change(object sender, EventArgs e)
        {
            lblcantidad14.Text = "1";
            lvlvalor14.Text = validador_precio(servicio_14.selectedValue).ToString();
            total_factura();
            servicio_15.Enabled = true;
        }

        private void servicio_15_change(object sender, EventArgs e)
        {
            lblcantidad15.Text = "1";
            lvlvalor15.Text = validador_precio(servicio_15.selectedValue).ToString();
            total_factura();
            servicio_16.Enabled = true;
        }

        private void servicio_16_change(object sender, EventArgs e)
        {
            lblcantidad16.Text = "1";
            lvlvalor16.Text = validador_precio(servicio_16.selectedValue).ToString();
            total_factura();
            servicio_17.Enabled = true;
        }

        private void servicio_17_change(object sender, EventArgs e)
        {
            lblcantidad17.Text = "1";
            lvlvalor17.Text = validador_precio(servicio_17.selectedValue).ToString();
            total_factura();
            servicio_18.Enabled = true;
        }

        private void servicio_18_change(object sender, EventArgs e)
        {
            lblcantidad18.Text = "1";
            lvlvalor18.Text = validador_precio(servicio_18.selectedValue).ToString();
            total_factura();
            servicio_19.Enabled = true;
        }

        private void servicio_19_change(object sender, EventArgs e)
        {
            lblcantidad19.Text = "1";
            lvlvalor19.Text = validador_precio(servicio_19.selectedValue).ToString();
            total_factura();
            servicio_20.Enabled = true;
        }

        private void servicio_20_change(object sender, EventArgs e)
        {
            lblcantidad20.Text = "1";
            lvlvalor20.Text = validador_precio(servicio_20.selectedValue).ToString();
            total_factura();
            servicio_21.Enabled = true;
        }

        private void servicio_21_change(object sender, EventArgs e)
        {
            lblcantidad21.Text = "1";
            lvlvalor21.Text = validador_precio(servicio_21.selectedValue).ToString();
            total_factura();
            servicio_22.Enabled = true;
        }

        private void servicio_22_change(object sender, EventArgs e)
        {
            lblcantidad22.Text = "1";
            lvlvalor22.Text = validador_precio(servicio_22.selectedValue).ToString();
            total_factura();
            servicio_23.Enabled = true;
        }

        private void servicio_23_change(object sender, EventArgs e)
        {
            lblcantidad23.Text = "1";
            lvlvalor23.Text = validador_precio(servicio_23.selectedValue).ToString();
            total_factura();
            servicio_24.Enabled = true;
        }

        private void servicio_24_change(object sender, EventArgs e)
        {
            lblcantidad24.Text = "1";
            lvlvalor24.Text = validador_precio(servicio_24.selectedValue).ToString();
            total_factura();
            servicio_25.Enabled = true;
        }

        private void servicio_25_change(object sender, EventArgs e)
        {
            lblcantidad25.Text = "1";
            lvlvalor25.Text = validador_precio(servicio_25.selectedValue).ToString();
            total_factura();
            servicio_26.Enabled = true;
        }

        private void servicio_26_change(object sender, EventArgs e)
        {
            lblcantidad26.Text = "1";
            lvlvalor26.Text = validador_precio(servicio_26.selectedValue).ToString();
            total_factura();
            servicio_27.Enabled = true;
        }

        private void servicio_27_change(object sender, EventArgs e)
        {
            lblcantidad27.Text = "1";
            lvlvalor27.Text = validador_precio(servicio_27.selectedValue).ToString();
            total_factura();
            servicio_28.Enabled = true;
        }

        private void servicio_28_change(object sender, EventArgs e)
        {
            lblcantidad28.Text = "1";
            lvlvalor28.Text = validador_precio(servicio_28.selectedValue).ToString();
            total_factura();
            servicio_29.Enabled = true;
        }

        private void servicio_29_change(object sender, EventArgs e)
        {
            lblcantidad29.Text = "1";
            lvlvalor29.Text = validador_precio(servicio_29.selectedValue).ToString();
            total_factura();
            servicio_30.Enabled = true;
        }

        private void servicio_30_change(object sender, EventArgs e)
        {
            lblcantidad30.Text = "1";
            lvlvalor30.Text = validador_precio(servicio_30.selectedValue).ToString();
            total_factura();
        }
    }
}
