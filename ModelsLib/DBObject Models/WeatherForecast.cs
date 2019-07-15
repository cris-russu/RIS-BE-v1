﻿using System;

namespace ModelsLib
{
    public class WeatherForecast
    {
        #region properties

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