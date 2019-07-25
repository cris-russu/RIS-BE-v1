using System.Collections.Generic;
using System.Data.Linq.Mapping;

namespace ModelsLib
{
    [Table(Name = "Addresses")]
    public class AddressModel
    {
        #region properties

        private int _id;
        private string city;
        private string street;
        private string zipCode;
        private List<WeatherForecast> forecasts;

        [Column(IsDbGenerated = true, IsPrimaryKey = true, Storage = "_id")]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        [Column(Storage = "zipCode")]
        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }
        [Column(Storage = "street")]
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        [Column(Storage = "city")]
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public List<WeatherForecast> Forecasts
        {
            get { return forecasts; }
            set { forecasts = value; }
        }
        #endregion

        public AddressModel() { }
        public AddressModel(string ct, string str, string zc)
        {
            city = ct;
            street = str;
            zipCode = zc;
        }

    }
}
