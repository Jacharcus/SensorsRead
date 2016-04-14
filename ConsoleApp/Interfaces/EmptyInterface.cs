using System;

namespace ConsoleApp
{
	using Interfaces;
	public interface ITemperatureSensor : ISensor
	{
		string GradeType { get; set; }
	}
}

