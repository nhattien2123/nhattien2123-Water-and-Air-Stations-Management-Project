using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using uPLibrary.Networking.M2Mqtt.Exceptions;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BTL_MQTT
{
    public partial class FrmMenu : Form
    {
        private Form activeForm;
        private List<JSON_Data> jSON_Datas = new List<JSON_Data>();
        private List<RootJSON> jSON_Objs = new List<RootJSON>();

        public FrmMenu(List<JSON_Data> jSON_Datas, List<RootJSON> jSON_Objs) 
        {
            this.jSON_Datas = jSON_Datas;
            this.jSON_Objs = jSON_Objs;
            InitializeComponent();
        }

        private void FrmStation_Load(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FrmHome(), sender);
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnForm.Controls.Add(childForm);
            this.pnForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbTitle.Text = childForm.Text;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FrmHome(), sender);
        }

        private void timerTimeNow_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStations_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FrmStations(jSON_Datas, jSON_Objs), sender);
        }

        private void FrmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            var formOwner = Owner;
            formOwner.RemoveOwnedForm(this);
            formOwner.Close();
        }

        private void btHelp_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FrmHelp(), sender);
        }
    }
}
