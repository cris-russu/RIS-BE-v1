using ModelsLib.Enums;
using System.Data.Linq.Mapping;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLib.DBObject_Models
{
    [Table(Name = "EndNodes")]
    public class EndNode
    {

        #region properties and constructors
        private int _id;
        private string eui;
        private string garbage_type;
        private int battery_lvl;
        private int urgency_lvl;
        private int capacity;
        private int _addressId;
        private int _tgs2602_id;
        private int _tgs2611_id;
        private int _tgs2620_id;
        private int _bme680_id;

        [Column(IsDbGenerated =true, IsPrimaryKey = true, Storage = "_id")]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        [Column(Storage = "eui")]
        public string Eui
        {
            get { return eui; }
            set { eui = value; }
        }
        [Column(Storage = "garbage_type")]
        public string GarbageType
        {
            get { return garbage_type; }
            set { garbage_type = value; }
        }
        [Column(Storage = "battery_lvl")]
        public int BatteryLvl
        {
            get { return battery_lvl; }
            set { battery_lvl = value; }
        }
        [Column(Storage = "urgency_lvl")]
        public int UrgencyLvl
        {
            get { return urgency_lvl; }
            set { urgency_lvl = value; }
        }
        [Column(Storage = "capacity")]
        public int BinCapacity
        {
            get { return capacity; }
            set { capacity = value; }
        }
        [Column(Storage = "_addressId")]
        public int AddressId
        {
            get { return _addressId; }
            set { _addressId = value; }
        }
        [Column(Storage = "_tgs2602_id")]
        public int TGS2602_ID
        {
            get { return _tgs2602_id; }
            set { _tgs2602_id = value; }
        }
        [Column(Storage = "_tgs2611_id")]
        public int TGS2611_ID
        {
            get { return _tgs2602_id; }
            set { _tgs2602_id = value; }
        }
        [Column(Storage = "_tgs2620_id")]
        public int TGS2620_ID
        {
            get { return _tgs2620_id; }
            set { _tgs2620_id = value; }
        }
        [Column(Storage = "_bme680_id")]
        public int BME680_ID
        {
            get { return _bme680_id; }
            set { _bme680_id = value; }
        }


        #region objects_lists

        private AddressModel address;
        private List<int> sensorIdList;
        private List<Sensor> sensors;
        private BinType type;
        public BinType Type
        {
            get { return type; }
            set { type = value; }
        }
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
        #endregion

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
