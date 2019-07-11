namespace ModelsLib
{
    public class AtmosphericReading : Reading
    {
        #region properties

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

        #endregion

        #region constructors

        public AtmosphericReading() { }
        public AtmosphericReading(int pr, int hu, int tmp)
        {
            pressure = pr;
            humidity = hu;
            tempurature = tmp;
        }
        public AtmosphericReading(Reading reading, int pr, int hu, int tmp)
        {
            pressure = pr;
            humidity = hu;
            tempurature = tmp;
            Timestamp = reading.Timestamp;
            SensorId = reading.SensorId;
        }
        
        #endregion
    }
}
