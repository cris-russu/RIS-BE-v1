using ModelsLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLib.DBObject_Models
{
    public class EndNode
    {

        #region properties and constructors
        private int battery_lvl;
        private int urgency_lvl;
        private BinType type;  
        private int capacity;
        private string eui;
        private AddressModel address;
        private List<int> sensorIdList;
        private List<Sensor> sensors;

        public List<Sensor> Sensors
        {
            get { return sensors; }
            set { sensors = value; }
        }
        public List<int> SensorsList
        {
            get { return sensorIdList; }
            set { sensorIdList = value; }
        }
        public AddressModel Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Eui
        {
            get { return eui; }
            set { eui = value; }
        }
        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }
        public BinType Type
        {
            get { return type; }
            set { type = value; }
        }
        public int UrgencyLvl
        {
            get { return urgency_lvl; }
            set { urgency_lvl = value; }
        }
        public int BatteryLvl
        {
            get { return battery_lvl; }
            set { battery_lvl = value; }
        }

        public EndNode() { }
        public EndNode(string eui, BinType garbage_type, int bin_capacity)
        {
            this.eui = eui;
            type = garbage_type;
            capacity = bin_capacity;
            
        }
        public EndNode(string eui, BinType garbage_type, int bin_capacity, AddressModel node_address)
        {
            this.eui = eui;
            type = garbage_type;
            capacity = bin_capacity;
            address = node_address;
        }
        #endregion

    }
}
