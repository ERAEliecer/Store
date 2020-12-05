using System;
using MySql.Data.MySqlClient;

namespace Daos
{
    public class Connention
    {
		public static MySqlConnection Conn()
		{
			MySqlConnection conn;

			try
			{
				String connString = "server=localhost;uid=root;pwd=root;database=Store";
				conn = new MySqlConnection(connString);
				conn.Open();
			}
			catch (MySqlException ex)
			{
				Console.WriteLine(ex.ToString());
				conn = null;
			}

			return conn;
		}
	}
}
