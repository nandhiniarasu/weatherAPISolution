﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace weatherAPIProject
{
    public class Weather
    {
        public int ID { get; set; }
        public string Date { get; set; }
        public string City { get; set; }
        public float HighTemp { get; set; }
        public float LowTemp { get; set; }
        public string ForeCast { get; set; }
    }
}
