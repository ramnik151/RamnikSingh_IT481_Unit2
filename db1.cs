using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RamnikSingh_IT481_Unit2
{
    class db1
	{
		string connectionString;
		SqlConnection cnn;
		public db1()
		{
			connectionString= "Persist Security Info=False;Integrated Security=true;Initial Catalog=Northwind;Server=RAMNIK-SURFACE\\SQLEXPRESS";
		}
		public db1(string conn)
		{
			connectionString = conn;
		}
		public string getCustomerCount()
		{
			Int32 count = 0;
			cnn = new SqlConnection(connectionString);
			cnn.Open();
			String countQuery = "select count(*) from customers;";
			SqlCommand cmd = new SqlCommand(countQuery, cnn);

			try
			{
				count = Convert.ToInt32(cmd.ExecuteScalar());
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			return count.ToString();
		}

		public string getCompanyNames()
		{
			string names = "None";
			SqlDataReader dataReader;

			cnn = new SqlConnection(connectionString);
			cnn.Open();
			string countQuery = "select Companyname from customers;";
			SqlCommand cmd = new SqlCommand(countQuery, cnn);
			dataReader = cmd.ExecuteReader();
			while (dataReader.Read())
			{
				try
				{
					names = names + dataReader["CompanyName"]+ "\n";
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}

			}

			return names;

		}

	}
	
}
