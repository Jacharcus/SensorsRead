using System;
using System.Data;
using Mono.Data.Sqlite;

namespace ConsoleApp
{
	public class SensorsDbDal
	{
		public void addtoDB(double temperatureInCelsius)
		{
			const string connectionString = "URI=file:/home/pi/SensorReach/ConsoleApp/sensorsdata.db";
			IDbConnection dbConnection = new SqliteConnection(connectionString);
			IDbTransaction transaction;
			dbConnection.Open ();
			IDbCommand dbCommand= dbConnection.CreateCommand();
			transaction = dbConnection.BeginTransaction();
			string sqlCommand =" INSERT INTO temps values(date('now'), time('now'),'L', " + Convert.ToString(temperatureInCelsius) + ");";
			dbCommand.CommandText = sqlCommand;
			dbCommand.ExecuteNonQuery ();
			transaction.Commit ();
		}
	}
}

