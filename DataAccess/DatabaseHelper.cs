using System;
using System.Collections.Generic;
using Npgsql;

namespace DataAccess
{
	public class DatabaseHelper
	{
		private readonly string connectionString;

		public DatabaseHelper(string connectionString)
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
					using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM menu_combinations;", connection))
					{
						using (NpgsqlDataReader reader = command.ExecuteReader())
						{
							while (reader.Read())
							{
								Guid uuid = reader.GetGuid(0);
								String itemName = reader.GetString(1);
								double price = reader.GetDouble(2);

								// Convert Uuid to string
								string uuidString = uuid.ToString();

								string value = $"{uuid};{itemName};{price}";
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
