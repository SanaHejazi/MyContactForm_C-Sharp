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

		private void dgContact_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			AddOrEdit addOrEdit = new AddOrEdit();
			addOrEdit.ShowDialog();
			if(addOrEdit.DialogResult==DialogResult.OK)
			{
				refrehs();
			}
		}
	}
}
