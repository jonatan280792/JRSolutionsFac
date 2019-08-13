using System;
using System.Windows.Forms;
using JRSolutionsFac.Business.Interfaces;
using JRSolutionsFac.Business.Services;
using MaterialSkin;
using MaterialSkin.Controls;
using WindowsFac.Views.Menu;

namespace WindowsFac
{
    public partial class Login : MaterialForm
    {
        ILoginService _service;
        LoginService _loginservice = new LoginService();

        MaterialForm login = new MaterialForm();
        MenuFac menu = new MenuFac();

        public Login(ILoginService service)
        {
            _service = service;
        }
        
        public Login()
        {
            InitializeComponent();

            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );           
        }

        private void Login_Load(object sender, EventArgs e)
        {
                        
        }

        private void BunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void BunifuImageButton3_Click(object sender, EventArgs e)
        {

        }

        public void BtnLogin_Click(object sender, EventArgs e)
        {
            
            MenuFacturacion menu2 = new MenuFacturacion();
            


            string UserName = lblUserName.Text.Trim();
            string PassWord = lblPassWord.Text.Trim();

            var result = _loginservice.Find(UserName, PassWord);

            if (result.Count == 0)
            {
                MessageBox.Show("Usuario y/o contraseña incorrecta");
                menu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ingreso exitoso al sistema");
                menu.Show();
                login.Close();
            }            
        }

        private void enter_Login(object sender, EventArgs e)
        {
            string UserName = lblUserName.Text.Trim();
            string PassWord = lblPassWord.Text.Trim();

            var result = _loginservice.Find(UserName, PassWord);

            if (result.Count == 0)
            {
                MessageBox.Show("Usuario y/o contraseña incorrecta");
                
            }
            else
            {
                MessageBox.Show("Ingreso exitoso al sistema");
                menu.Show();
                login.Close();
            }
        }
    }
}
