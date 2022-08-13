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

namespace BTL_MQTT.Forms
{
    public partial class FrmStations : Form
    {
        TableLayoutPanel tblWaterSensor, tblSolarAir;
        private List<PictureBox> pcStations = new List<PictureBox>();
        private List<JSON_Data> jSON_Datas = new List<JSON_Data>();
        private List<RootJSON> jSON_Objs = new List<RootJSON>();

        public FrmStations(List<JSON_Data> jSON_Datas, List<RootJSON> jSON_Objs)
        {
            this.jSON_Datas = jSON_Datas;
            this.jSON_Objs = jSON_Objs;
            InitializeComponent();
        }

        private void FrmStations_Load(object sender, EventArgs e)
        {
            CreateTableLayoutPanel();
            foreach (var jsonObject in jSON_Datas)
            {
                if (jsonObject.station_name.Contains("water-sensor"))
                {
                    tblWaterSensor.ColumnCount += 1;
                    tblWaterSensor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));

                    PictureBox pic = new PictureBox();
                    pic.Name = jsonObject.station_name;
                    pic.Cursor = Cursors.Hand;
                    pic.SizeMode = PictureBoxSizeMode.Zoom;
                    pic.Image = Image.FromFile(Application.StartupPath + @"\imgs\computer.png");
                    pcStations.Add(pic);

                    tblWaterSensor.Controls.Add(pic, tblWaterSensor.ColumnCount - 1, 0);
                    tblWaterSensor.Controls.Add(new Label
                    {
                        Text = "Trạm " + tblWaterSensor.ColumnCount,
                        TextAlign = ContentAlignment.MiddleCenter,
                        ForeColor = Color.White
                    }, tblWaterSensor.ColumnCount - 1, 1);
                }

                if (jsonObject.station_name.Contains("solar-air"))
                {
                    tblSolarAir.ColumnCount += 1;
                    tblSolarAir.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9F));

                    PictureBox pic = new PictureBox();
                    pic.Name = jsonObject.station_name;
                    pic.Cursor = Cursors.Hand;
                    pic.SizeMode = PictureBoxSizeMode.Zoom;
                    pic.Image = Image.FromFile(Application.StartupPath + @"\imgs\solar.png");
                    pcStations.Add(pic);

                    tblSolarAir.Controls.Add(pic, tblSolarAir.ColumnCount - 1, 0);
                    tblSolarAir.Controls.Add(new Label
                    {
                        Text = "Trạm " + tblSolarAir.ColumnCount,
                        TextAlign = ContentAlignment.MiddleCenter,
                        ForeColor = Color.White
                    }, tblSolarAir.ColumnCount - 1, 1);
                }
                //var timestampNow = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
                //for (int i = 0; i < FrmMenu.jSON_Datas.Count; i++)
                //    if (timestampNow - FrmMenu.jSON_Datas[i].timestamp > 1800) 
                //    {

                //    }
            }

            for (int i = 0; i < jSON_Datas.Count; i++)
            {
                pcStations[i].Click += btnStation;
            }
            StartResetStations();
            timerUpdateStations.Start();
        } 

        private void btnStation(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            string name = pic.Name;
            foreach (var data in jSON_Datas) {
                if (data.station_name == name) { 
                    FrmInformation frmInformation = new FrmInformation(data);
                    frmInformation.ShowDialog();
                }
            }
        }

        private void StartResetStations()
        {
            var timestampNow = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
            for (int i = 0; i < jSON_Datas.Count; i++)
            {
                if (timestampNow - jSON_Datas[i].timestamp > 1800)
                {
                    pcStations[i].Enabled = false;
                    if (pcStations[i].Name.Contains("water-sensor")) 
                        pcStations[i].Image = Image.FromFile(Application.StartupPath + @"\imgs\computer_disconnected.png");
                    else pcStations[i].Image = Image.FromFile(Application.StartupPath + @"\imgs\solar_disconnected.png");
                }
            }
        }

        private void timerUpdateStations_Tick(object sender, EventArgs e)
        {
            StartResetStations();
        }

        private void CreateTableLayoutPanel()
        {
            tblWaterSensor = new TableLayoutPanel();
            tblWaterSensor.Location = new Point(12, 100);
            tblWaterSensor.Size = new Size(700, 90);
            tblWaterSensor.AutoScroll = true;
            tblWaterSensor.RowCount = 2;
            Controls.Add(tblWaterSensor);

            tblSolarAir = new TableLayoutPanel();
            tblSolarAir.Location = new Point(12, 280);
            tblSolarAir.Size = new Size(700, 90);
            tblSolarAir.AutoScroll = true;
            tblSolarAir.RowCount = 2;
            Controls.Add(tblSolarAir);
        }
    }
}
