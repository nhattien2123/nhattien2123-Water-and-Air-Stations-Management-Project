using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_MQTT
{
    public class RootJSON
    {
        public string CPUSerial { get; set; }
        public string AzureID { get; set; }
        public string AzureToken { get; set; }
        public string StationType { get; set; }
        public List<SensorData> SensorData { get; set; }
        public int? TimeOutPump { get; set; }
        public int? TimeOutFlush { get; set; }
    }

    public class SensorData
    {
        public string sensorName { get; set; }
        public string sensorUnit { get; set; }
        public string sensorMapKey { get; set; }
        public double sensorCalib { get; set; }
        public List<int> sensorData { get; set; }
    }

    public class JSON_Data
    {
        public string project_id { get; set; }
        public string project_name { get; set; }
        public string station_id { get; set; }
        public string station_name { get; set; }
        public float longitude { get; set; }
        public float latitude { get; set; }
        public float volt_battery { get; set; }
        public float volt_solar { get; set; }
        public List<data_sensor> data_sensor { get; set; }
        public int timestamp { get; set; }
    }

    public class data_sensor
    {
        public string sensor_name { get; set; }
        public string sensor_key { get; set; }
        public string sensor_unit { get; set; }
        public float sensor_value { get; set; }
    }
}
