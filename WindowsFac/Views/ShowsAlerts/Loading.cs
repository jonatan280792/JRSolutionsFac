using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFac.Views.ShowsAlerts
{
    public partial class Loading : UserControl
    {
        public Loading()
        {
            InitializeComponent();
        }

        int dir = 1;

        private void Strech_Tick(object sender, EventArgs e)
        {
            if (bunifuCircleProgressbar1.Value < 100)
            {
                dir = -1;
            }
            else
            {
                dir = +1;
            }

            bunifuCircleProgressbar1.Value += dir;
        }
    }
}
