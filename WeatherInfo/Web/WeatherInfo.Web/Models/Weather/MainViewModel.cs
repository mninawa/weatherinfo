﻿using System.Collections.Generic;

namespace WeatherInfo.Web.Models.Weather
{
    public class MainViewModel
    {
        public string UnitType { get; set; }
        public List<MainItemViewModel> MainItems { get; set; }
    }
}