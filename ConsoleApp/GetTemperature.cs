using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using RaspberryPiDotNet;
namespace ConsoleApp
{
    class GetTemperature
	{
		public double readRawData()
		{
			GPIOMem SPICLK = new GPIOMem (GPIOPins.Pin_P1_18, GPIODirection.Out);
			GPIOMem SPIMISO = new GPIOMem (GPIOPins.Pin_P1_23, GPIODirection.In);
			GPIOMem SPIMOSI = new GPIOMem (GPIOPins.Pin_P1_24, GPIODirection.Out);
			GPIOMem SPICS = new GPIOMem (GPIOPins.Pin_P1_22, GPIODirection.Out);
			int adcnum = 0;
			double read_adc0 = 0.0;
			MCP3008 MCP3008 = new MCP3008 (adcnum, SPICLK, SPIMOSI, SPIMISO, SPICS);
			read_adc0 = MCP3008.AnalogToDigital;
			return read_adc0;
		}
		public double convertToMilivolts()
		{
			return Convert.ToDouble (readRawData()) * (3300.0 / 1024);
		}
		public double getTemperature()
		{
			return ((convertToMilivolts() - 100.0) / 10.0) - 40.0;
		}
	}
}

