using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RaspberryPiDotNet;

namespace ConsoleApp.Interfaces
{
    public interface ISensor
    {
        public GPIOMem SPICLK { get; set; };
        public GPIOMem SPIMISO { get; set; };
        public GPIOMem SPIMOSI { get; set; };
        public GPIOMem SPICSl { get; set; };
    }
}
