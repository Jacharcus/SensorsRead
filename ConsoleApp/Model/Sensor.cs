﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RaspberryPiDotNet;

namespace ConsoleApp.Model
{
    using ConsoleApp.Interfaces;
    public class Sensor : ISensor 
    {
        public int adcNumber { get; set; };
        public double readADC { get; set; };
    }
}
