using System;
using System.Data;
using Mono.Data.Sqlite;
namespace ConsoleApp
{
    using ConsoleApp.Bll;

    class MainClass
	{
		public static void Main(string[] args)
		{

            SensorsBll.Instance.SetTemperature();


            double temperatureInCelsius;
            GetTemperature temperature = new GetTemperature();
            temperatureInCelsius = temperature.getTemperature();
            Console.WriteLine("Temperature in Celsius: " + temperatureInCelsius);
            AddToDB modifyDB = new AddToDB();
            modifyDB.addtoDB(temperatureInCelsius);

        }

	}
}
