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
using System.Web.Script.Serialization;

namespace BTL_MQTT
{
    public partial class FrmLoading : Form
    {
        int nJSON = 0;
        static MqttClient client;
        FrmMenu frmMenu;
        string topics = "/tram_chim_monitoring/dong_thap/";
        string MQTTBroker = "mqttserver.tk";
        int MQTTPort = 1883;
        string ClientID = Guid.NewGuid().ToString();
        string MQTTUsername = "tram_chim_sub";
        string MQTTPassword = "TramChimMQTT...";
        private List<RootJSON> JSONObjs = new List<RootJSON>();
        private List<JSON_Data> JSONObjs_Data = new List<JSON_Data>();
        public FrmLoading()
        {
            InitializeComponent();
        }

        private void FrmLoading_Load(object sender, EventArgs e)
        {
            try
            {
                MqttClient client = ConnectMQTT(MQTTBroker, MQTTPort, ClientID, MQTTUsername, MQTTPassword);
                using (WebClient wc = new WebClient())
                {
                    var data = wc.DownloadData("https://ubc.sgp1.digitaloceanspaces.com/TramChimPark/Config/config.json");
                    var json = Encoding.UTF8.GetString(data);
                    List<RootJSON> jsonData = JsonConvert.DeserializeObject<List<RootJSON>>(json);
                    this.JSONObjs = jsonData.ToList();
                }
                nJSON = 0;
                client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;
                timerLoading.Start();
                //client.MqttMsgSubscribed += client_MqttMsgSubscribed;
                //FrmStation frmStation = new FrmStation();
                //frmStation.Show();
            }
            catch { }
        }

        private void Subscribe(MqttClient client, string topic)
        {
            client.Subscribe(new string[] { topic }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
        }

        private void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            bool checkSameStation = false;
            string jsonMessage = Encoding.UTF8.GetString(e.Message);
            var convertMessage = JsonConvert.DeserializeObject<JSON_Data>(jsonMessage);
            lbNotice.Text = "Subscribe " + convertMessage.station_name + " is successful...";
            pnLoading.Width += ClientRectangle.Width / JSONObjs.Count;
            for (int i = 0; i < JSONObjs_Data.Count; i++)
                if (JSONObjs_Data[i].station_id == convertMessage.station_id)
                {
                    JSONObjs_Data[i] = convertMessage;
                    checkSameStation = true;
                }
            if (!checkSameStation)
                JSONObjs_Data.Add(convertMessage);
            nJSON++;
        }

        static MqttClient ConnectMQTT(string broker, int port, string clientId, string username, string password)
        {
            client = new MqttClient(broker, port, false, MqttSslProtocols.None, null, null);
            client.ProtocolVersion = MqttProtocolVersion.Version_3_1;
            client.Connect(clientId, username, password);
            if (client.IsConnected)
            {
                MessageBox.Show("Connected to MQTT Broker");
            }
            else
            {
                MessageBox.Show("Failed to connect MQTT Broker");
            }
            return client;
        }

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            if (nJSON < JSONObjs.Count)
                Subscribe(client, topics + JSONObjs[nJSON].AzureID);
            if (JSONObjs_Data.Count == JSONObjs.Count)
            { 
                timerLoading.Stop();
                this.Hide();
                frmMenu = new FrmMenu(JSONObjs_Data, JSONObjs);
                frmMenu.Owner = this;
                frmMenu.ShowDialog();
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            client.Disconnect();
            base.OnClosed(e);
        }
    }
}

//var timestampNow = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();  MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE
//JavaScriptSerializer json_serializer = new JavaScriptSerializer();
//JSON_Object response = (JSON_Object)json_serializer.Deserialize(json_object_web, typeof(JSON_Object));
//MessageBox.Show("Hello");
//var listData = JsonConvert.DeserializeObject<List<JSON_Object>>(jsonData);
//MessageBox.Show(listData[0].AzureID);
//foreach (var item in jObject["AzureID"])
//{

//}
//MessageBox.Show(ser.AzureID);
//foreach (JObject obj in arr.Children<JObject>())
//{
//    foreach (JProperty singleProp in obj.Properties())
//    {
//        string name = singleProp.Name;
//        string value = singleProp.Value.ToString();
//        MessageBox.Show(Name);
//    }
//}
//this.JSONconfig = jsonData.ToList();
//private void client_MqttMsgSubscribed(object sender, MqttMsgSubscribedEventArgs e)
//{
//    var sb = new StringBuilder();
//    foreach (byte qosLevel in e.GrantedQoSLevels)
//    {
//        sb.Append(qosLevel);
//        sb.Append(" ");
//    }
//}


//LeHo da den va comment