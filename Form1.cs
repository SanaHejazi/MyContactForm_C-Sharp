using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyContactProject
{
	public partial class Form1 : Form
	{
		IContactRepository contactRepository;
		public Form1()
		{
			InitializeComponent();
			contactRepository = new ContactsRepository();
		}
		private void Form1_Load_1(object sender, EventArgs e)
		{
			//this.my_ContactsTableAdapter.Fill(this.myContacts_DBDataSet1.My_Contacts);
			refrehs();
		}

		private void refrehs()
		{
			dgContact.AutoGenerateColumns = false;
			dgContact.DataSource = contactRepository.GetContactTable();
		}

		private void btnrefresh_Click(object sender, EventArgs e)
		{
			refrehs();
		}
	}
}
