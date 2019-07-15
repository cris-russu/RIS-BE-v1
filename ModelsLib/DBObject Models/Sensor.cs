using ModelsLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLib.DBObject_Models
{
    public class Sensor
    {
        private SensorType type;
        private int uptime;
        private int lifetime;
        private List<Reading> readings;

        public List<Reading> MyProperty
        {
            get { return readings; }
            set { readings = value; }
        }
        public int Lifetime
        {
            get { return lifetime; }
            set { lifetime = value; }
        }
        public int Uptime
        {
            get { return uptime; }
            set { uptime = value; }
        }
        public SensorType Type
        {
            get { return type; }
            set { type = value; }
        }

        public Sensor() { }
        public Sensor(SensorType tp, int ut, int lt)
        {
            type = tp;
            uptime = ut;
            lifetime = lt; 
        }
        
    }
}
