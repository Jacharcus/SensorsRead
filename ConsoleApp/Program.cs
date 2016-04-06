using System;
using System.Data;
using Mono.Data.Sqlite;
namespace ConsoleApp
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			double temperatureInCelsius;
			GetTemperature temperature = new GetTemperature();
			temperatureInCelsius = temperature.getTemperature ();
			Console.WriteLine ("Temperature in Celsius: " + temperatureInCelsius);
			AddToDB modifyDB = new AddToDB ();
			modifyDB.addtoDB (temperatureInCelsius);

		}

	}
}
