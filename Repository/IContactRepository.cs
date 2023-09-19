using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContactProject
{
	internal interface IContactRepository
	{
		DataTable GetContactTable();
		DataTable GetRowContact(int Id);
		bool Insert(String Name, String Family, int Age, String Number,String Address);
		bool Update(int Id, String Name, String Family, int Age, String Number);
		bool Delete(int Id);
		
	}
}
