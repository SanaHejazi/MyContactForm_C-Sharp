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
		//
		private string connectionString = "Data Source=.;Initial Catalog=MyContacts_DB;Integrated Security = true";
		public bool Delete(int Id)
		{
			throw new NotImplementedException();
		}

		public DataTable GetContactTable()
		{
			String query = "Select * From My_Contacts";
			SqlConnection connection = new SqlConnection(connectionString);
			SqlDataAdapter adapter=new SqlDataAdapter(query,connection);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			try
			{
				
			}
			catch (Exception e) {}
			
			return dt;
		}

		public DataTable GetRowContact(int Id)
		{
			throw new NotImplementedException();
		}

		public bool Insert(string Name, string Family, int Age, string Number)
		{
			throw new NotImplementedException();
		}

		public bool Update(int Id, string Name, string Family, int Age, string Number)
		{
			throw new NotImplementedException();
		}
	}
}
