using Microsoft.Data.Sqlite;

namespace WebAPI
{
	/// <summary>
	/// Класс для обработки БД.
	/// </summary>
	public class DataBase
	{
		public void PostPerson( string LastName, string MidleName, string FirstName, int lenght, double mass, int age)
		{
			int ID = 0;
			string sqlExpression = "SELECT * FROM Person";
			using (var connection = new SqliteConnection("Data Source=PersonInfo.db"))
			{
				connection.Open();

				SqliteCommand command = new SqliteCommand(sqlExpression, connection);
				using (SqliteDataReader reader = command.ExecuteReader())
				{
					ID = reader.FieldCount;
				}
			}

			using (var connection = new SqliteConnection("Data Source=PersonInfo.db"))
			{
				connection.Open();

				SqliteCommand command = new SqliteCommand();
				command.Connection = connection;
				command.CommandText = $"INSERT INTO Person (ID, LastName, MidleName, FirstName, Mass, Length, age) " +
					$"VALUES ({ID+1},'{FirstName}', '{MidleName}', '{FirstName}', {mass}, {lenght}, {age})";
				int number = command.ExecuteNonQuery();
				Console.WriteLine(number);
			}
		}
	}
}
