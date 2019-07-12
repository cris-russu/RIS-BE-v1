using System;

namespace ModelsLib
{
    public class ChemicalReading : Reading
    {
        private ushort val;

        public ushort Value
        {
            get { return val; }
            set { val = value; }
        }
      
        #region cosntructors

        public ChemicalReading() { }
        public ChemicalReading(DateTime timestamp, ushort value)  {
            Timestamp = timestamp;
            Value = value;
        }
        public ChemicalReading(DateTime timestamp, ushort value, int sensor)
        {
            Timestamp = timestamp;
            val = value;
            sensor = SensorId;
        }
        public ChemicalReading(Reading reading, ushort value)
        {
            Timestamp = reading.Timestamp;
            SensorId = reading.SensorId;
            val = value;
        }

        #endregion

    }
}
