using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLib
{
    public class ChemicalReading : Reading
    {
        public int Value { get; set; }

        public ChemicalReading() { }

        public ChemicalReading(DateTime timestamp, int value, int sensor)
        {
            Timestamp = timestamp;
            Value = value;
            sensor = SensorId;
        }

        public ChemicalReading(Reading reading, int value)
        {
            Timestamp = reading.Timestamp;
            SensorId = reading.SensorId;
            Value = value;
        }


    }
}
