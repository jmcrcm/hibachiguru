using System;
using System.Collections.Generic;
using Npgsql;

namespace DataAccess
{
	public class Databasehelper
	{
		private readonly string connectionString;

		public Databasehelper(string connectionString)
		{
			this.connectionString = connectionString;
		}

		public List<string> ReadDataFromDatabase()
		{
			List<string> result = new List<string>();

			using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
			{
				try
				{
					connection.Open();

					using (NpgslqCommand command = new NpgslqCommand("SELECT menu_combinations FROM menu_combinations", connection))
					{
						using (NpgsqlDataReader reader = command.ExecuteReader())
						{
							while (reader.Read())
							{
								string value = reader.GetString(0);
								result.Add(value);
							}
						}
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine($"Ërror: {ex.Message}");
				}
			}

			return result;

		}

	}
}
