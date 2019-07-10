using System;

namespace ModelsLib
{
    public abstract class Reading
    {
        private DateTime dateTime;
        private int sensorId;

        public DateTime Timestamp { get => dateTime; set => dateTime = value; }
        public int SensorId { get => sensorId; set => sensorId = value; }

        public Reading() { }
        public Reading(DateTime timestamp, int sensorId)
        {
            dateTime = timestamp;
            this.sensorId = sensorId;
        }

        public string GetReadingDate() => Timestamp.ToShortDateString();
        public string GetReadingTime() => Timestamp.ToShortTimeString();


    }
}
