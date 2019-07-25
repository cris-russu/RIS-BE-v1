using System;
using System.Data.Linq.Mapping;

namespace ModelsLib
{
    [Table(Name = "BME_Readings")]
    public class AtmosphericReading
    {
        #region properties

        private ushort pressure;
        private byte humidity;
        private sbyte tempurature;
        private byte airQuality;
        private int sensorId;
        private DateTime timestamp;
        private int _id;
        [Column(IsDbGenerated = true, IsPrimaryKey = true, Storage = "_id")]
        public int Id { get { return _id; } set { _id = value; } }
        [Column(Storage = "timestamp")]
        public DateTime Timestamp { get { return timestamp; } set { timestamp = value; } }
        [Column(Storage = "sensorId")]
        public int SensorId { get { return sensorId; } set { sensorId = value; } }
        [Column(Storage = "airQuality")]
        public byte AirQUality { get { return airQuality; } set { airQuality = value; } }
        [Column(Storage = "temperature")]
        public sbyte Temperature { get { return tempurature; } set { tempurature = value; } }
        [Column(Storage = "humidity")]
        public byte Humidity { get { return humidity; } set { humidity = value; } }
        [Column(Storage = "pressure")]
        public ushort Pressure { get { return pressure; } set { pressure = value; } }

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
        public AtmosphericReading(DateTime ts, int sensorId, ushort pr, byte hu, sbyte tmp, byte aq)
        {
            pressure = pr;
            humidity = hu;
            tempurature = tmp;
            airQuality = aq;
            Timestamp = ts;
            SensorId = sensorId;
        }

        #endregion

        public string GetReadingDate() => Timestamp.ToShortDateString();
        public string GetReadingTime() => Timestamp.ToShortTimeString();
    }
}
