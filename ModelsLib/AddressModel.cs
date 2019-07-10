﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLib
{
    public class AddressModel
    {
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
        public string MyProperty
        {
            get { return street; }
            set { street = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }

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
