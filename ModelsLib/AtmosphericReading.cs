using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLib
{
    public class AtmosphericReading : Reading
    {
        private int pressure;
        private int humidity;
        private int tempurature;

        public int Temperature
        {
            get { return tempurature; }
            set { tempurature = value; }
        }
        public int Humidity
        {
            get { return humidity; }
            set { humidity = value; }
        }
        public int Pressure
        {
            get { return pressure; }
            set { pressure = value; }
        }

        
    }
}
