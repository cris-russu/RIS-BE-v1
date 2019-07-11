using System;

namespace ModelsLib
{
    public class ChemicalReading : Reading
    {
        private int val;

        public int Value
        {
            get { return val; }
            set { val = value; }
        }
      
        #region cosntructors

        public ChemicalReading() { }
        public ChemicalReading(DateTime timestamp, int value, int sensor)
        {
            Timestamp = timestamp;
            val = value;
            sensor = SensorId;
        }
        public ChemicalReading(Reading reading, int value)
        {
            Timestamp = reading.Timestamp;
            SensorId = reading.SensorId;
            val = value;
        }

        #endregion

    }
}
