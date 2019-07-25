using System;
using System.Data.Linq.Mapping;

namespace ModelsLib
{
    [Table(Name = "TGS_Readings")]
    public class ChemicalReading
    {
        private ushort val;
        private int sensorId;
        private DateTime timestamp;
        private int _id;
        [Column(IsDbGenerated = true, IsPrimaryKey = true, Storage = "_id")]
        public int Id { get { return _id; } set { _id = value; } }
        [Column(Storage = "timestamp")]
        public DateTime Time_stamp { get { return timestamp; } set { timestamp = value; } }
        [Column(Storage = "sensorId")]
        public int SensorId { get { return sensorId; } set { sensorId = value; } }
        [Column(Storage = "val")]
        public ushort Read_Value { get { return val; } set { val = value; } }

        #region cosntructors

        public ChemicalReading() { }
        public ChemicalReading(DateTime timestamp, ushort value)
        {
            Time_stamp = timestamp;
            Read_Value = value;
        }
        public ChemicalReading(DateTime timestamp, ushort value, int sensor)
        {
            Time_stamp = timestamp;
            val = value;
            sensor = SensorId;
        }
        public ChemicalReading(DateTime timestamp, int sensorID, ushort value)
        {
            Time_stamp = timestamp;
            SensorId = sensorID;
            val = value;
        }

        #endregion
        public string GetReadingDate() => Time_stamp.ToShortDateString();
        public string GetReadingTime() => Time_stamp.ToShortTimeString();
    }
}
