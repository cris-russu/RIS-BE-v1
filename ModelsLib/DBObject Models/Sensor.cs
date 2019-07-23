using ModelsLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq.Mapping;
using System.Threading.Tasks;

namespace ModelsLib.DBObject_Models
{
    public class Sensor
    {
        private int _id;
        private string _sens_type;
        private int uptime;
        private int lifespan;
        [Column(IsDbGenerated = true, IsPrimaryKey = true, Storage = "_id")]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        [Column(Storage = "_sens_type")]
        public string Sens_type
        {
            get { return _sens_type; }
            set { _sens_type = value; }
        }
        [Column(Storage = "uptime")]
        public int Uptime
        {
            get { return uptime; }
            set { uptime = value; }
        }
        [Column(Storage = "lifespan")]
        public int Lifespan
        {
            get { return lifespan; }
            set { lifespan = value; }
        }
        
        private SensorType type;
        public SensorType Type
        {
            get { return type; }
            set { type = value; }
        }
        private List<Reading> readings;
        public List<Reading> Readings
        {
            get { return readings; }
            set { readings = value; }
        }
        //private Reading currentReading;

        //public Reading CurrentReading
        //{
        //    get { return currentReading; }
        //    set { currentReading = value; }
        //}

        public Sensor() { }
        public Sensor(SensorType tp, int ut, int lt)
        {
            type = tp;
            uptime = ut;
            lifespan = lt; 
        }
        // TODO: constructor with Reading-obj
    }
}
