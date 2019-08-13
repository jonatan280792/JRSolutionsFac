using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFac.Views.Formatos
{
    public partial class PrintPDF : Form
    {
        public PrintPDF()
        {
            InitializeComponent();
        }
        Bitmap bmp;

        private void load_PrintPDF(object sender, EventArgs e)
        {
            ReportPrint fdsf = new ReportPrint();

           //     fdsf.SetDataSource();

            string reportName = "impresion.rdlc";
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_print(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
