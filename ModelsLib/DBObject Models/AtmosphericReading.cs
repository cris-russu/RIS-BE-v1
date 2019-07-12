using System;

namespace ModelsLib
{
    public class AtmosphericReading : Reading
    {
        #region properties

        private ushort pressure;
        private byte humidity;
        private sbyte tempurature;
        private byte airQuality;

        public byte AirQUality
        {
            get { return airQuality; }
            set { airQuality = value; }
        }
        public sbyte Temperature
        {
            get { return tempurature; }
            set { tempurature = value; }
        }
        public byte Humidity
        {
            get { return humidity; }
            set { humidity = value; }
        }
        public ushort Pressure
        {
            get { return pressure; }
            set { pressure = value; }
        }

        #endregion

        #region constructors

        public AtmosphericReading() { }
        public AtmosphericReading(ushort pr, byte hu, sbyte tmp, byte aq)
        {
            pressure = pr;
            humidity = hu;
            tempurature = tmp;
            airQuality = aq;
        }
        public AtmosphericReading(DateTime timestamp, ushort pr, byte hu, sbyte tmp, byte aq)
        {
            Timestamp = timestamp; 
            pressure = pr;
            humidity = hu;
            tempurature = tmp;
            airQuality = aq;
        }
        public AtmosphericReading(Reading reading, ushort pr, byte hu, sbyte tmp, byte aq)
        {
            pressure = pr;
            humidity = hu;
            tempurature = tmp;
            airQuality = aq;
            Timestamp = reading.Timestamp;
            SensorId = reading.SensorId;
        }
        
        #endregion
    }
}
