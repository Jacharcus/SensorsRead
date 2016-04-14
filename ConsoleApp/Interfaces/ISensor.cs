using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RaspberryPiDotNet;

namespace ConsoleApp.Interfaces
{
    public interface ISensor
    {
        GPIOMem SPICLK { get; set; }
        GPIOMem SPIMISO { get; set; }
        GPIOMem SPIMOSI { get; set; }
        GPIOMem SPICSl { get; set; }
		int adcNumber { get; set; }
		double readADC { get; set; }
    }
}
