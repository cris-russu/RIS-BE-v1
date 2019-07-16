using System.Collections.Generic;

namespace ModelsLib
{
    public class AddressModel
    {
        #region properties

        private string city;
        private string street;
        private int number;
        private string zipCode;
        private List<WeatherForecast> forecasts;

        public List<WeatherForecast> Forecasts
        {
            get { return forecasts; }
            set { forecasts = value; }
        }
        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        #endregion

        public AddressModel() { }
        public AddressModel(string ct, string str, int num, string zc)
        {
            city = ct;
            street = str;
            number = num;
            zipCode = zc; 
        }
        
    }
}
