using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MyContactProject
{
	internal class ContactsRepository : IContactRepository
	{
		
		private string connectionString = "Data Source=.;Initial Catalog=MyContacts_DB;Integrated Security = true";
		public bool Delete(int Id)
		{
			SqlConnection connection = new SqlConnection(connectionString);
			try
			{
				
				string query = "Delete From My_Contacts Where ID=@Id";
				SqlCommand command=new SqlCommand(query, connection);
				command.Parameters.AddWithValue("@id", Id);
				connection.Open();
				command.ExecuteNonQuery();
				return true;
			}
			catch (Exception e)
			{
				
				MessageBox.Show(e.Message);
			return false;
			}
			finally 
			{
				connection.Close();
			}

		}

		public DataTable GetContactTable()
		{
			String query = "Select Name,Family,Age,Email,Number,ID From My_Contacts";
			SqlConnection connection = new SqlConnection(connectionString);
			SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			return dt;
		}
		public DataTable GetRowContact(int Id)
		{
			throw new NotImplementedException();
		}

		public bool Insert(string Name, string Family,String Email, int Age, string Number,string adress)
		{

			SqlConnection connection = new SqlConnection(connectionString);
			try
			{
				string inserquery = "Insert Into My_Contacts(Name,Family,Age,Email,Number,Address) Values (@Name,@Family,@Age,@Email,@Number,@Address)";
			
				SqlCommand command=new SqlCommand(inserquery, connection);
				command.Parameters.AddWithValue("@Name",Name);
				command.Parameters.AddWithValue("@Family",Family);
				command.Parameters.AddWithValue("@Age",Age);
				command.Parameters.AddWithValue("@Email",Email);
				command.Parameters.AddWithValue("@Number",Number);
				command.Parameters.AddWithValue("@Address",adress);
				connection.Open();
				command.ExecuteNonQuery();
				
				return true;
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
				return false;
			}
			finally { connection.Close(); }
		}

		public bool Update(int Id, string Name, string Family, int Age, string Number)
		{
			throw new NotImplementedException();
		}
	}
}
