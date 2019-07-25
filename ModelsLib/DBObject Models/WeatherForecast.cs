using System;
using System.Data.Linq.Mapping;

namespace ModelsLib
{
    [Table(Name = "WeatherForecasts")]
    public class WeatherForecast
    {
        #region properties

        private int _id;
        private int temperature;
        private int pressure;
        private int humidity;
        private int addressId;
        private DateTime timestamp;

        [Column(IsDbGenerated = true, IsPrimaryKey = true, Storage = "_id")]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        [Column(Storage = "temperature")]
        public int Temperature
        {
            get { return temperature; }
            set { temperature = value; }
        }
        [Column(Storage = "pressure")]
        public int Pressure
        {
            get { return pressure; }
            set { pressure = value; }
        }
        [Column(Storage = "humidity")]
        public int Humidity
        {
            get { return humidity; }
            set { humidity = value; }
        }
        [Column(Storage = "addressId")]
        public int AddressId
        {
            get { return addressId; }
            set { addressId = value; }
        }
        [Column(Storage = "timestamp")]
        public DateTime Timestamp
        {
            get { return timestamp; }
            set { timestamp = value; }
        }




        #endregion

        #region contructors

        public WeatherForecast() { }
        public WeatherForecast(int tmp, int pres, int hum)
        {
            temperature = tmp;
            pressure = pres;
            humidity = hum;
        }
        #endregion

    }
}
