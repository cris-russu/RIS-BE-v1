using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLib
{
    public class WeatherForecast
    {
        private int temperature;
        private int pressure;
        private int humidity;
        private int addressId;
        private DateTime timestamp;

        public DateTime Timestamp
        {
            get { return timestamp; }
            set { timestamp = value; }
        }
        public int AddressId
        {
            get { return addressId; }
            set { addressId = value; }
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
        public int Temperature
        {
            get { return temperature; }
            set { temperature = value; }
        }

        public WeatherForecast() { }
        public WeatherForecast(int tmp, int pres, int hum)
        {
            temperature = tmp;
            pressure = pres;
            humidity = hum;
        }
    }
}
