using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace BTL_MQTT.Forms
{
    public partial class FrmHelp : Form
    {
        public FrmHelp()
        {
            InitializeComponent();
        }

        private void lbLink_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.facebook.com/my.cua.794");
            Process.Start(sInfo);
        }
    }
}
