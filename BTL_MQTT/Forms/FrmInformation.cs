using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_MQTT.Forms
{
    public partial class FrmInformation : Form
    {
        JSON_Data json_data = new JSON_Data();

        public FrmInformation(JSON_Data json_data)
        {
            this.json_data = json_data;
            InitializeComponent();
        }

        private void btGoBack_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void FrmInformation_Load(object sender, EventArgs e)
        {
            lbStationName.Text = json_data.station_name;
            if (json_data.station_name.Contains("water-sensor"))
                pcStation.Image = Image.FromFile(Application.StartupPath + @"\imgs\computer.png");
            else pcStation.Image = Image.FromFile(Application.StartupPath + @"\imgs\solar.png");

            foreach (Control control in this.Controls)
            {
                if (control is Label && control.Name.Contains("lbTitle"))
                {
                    int i = Int32.Parse(control.Name.Substring(7));
                    control.Text = json_data.data_sensor[i].sensor_name;
                }
                if (control is Label && control.Name.Contains("lbValue"))
                {
                    int i = Int32.Parse(control.Name.Substring(7));
                    control.Text = json_data.data_sensor[i].sensor_value + " " + json_data.data_sensor[i].sensor_unit;
                }
            }
        }
    }
}
