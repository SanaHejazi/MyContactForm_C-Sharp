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
		public int currentid;
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
			addOrEdit.x = 0;
			addOrEdit.ShowDialog();
			if (addOrEdit.DialogResult == DialogResult.OK)
			{
				refrehs();
			}
		}

		private void btndelete_Click(object sender, EventArgs e)
		{
			if (dgContact.CurrentRow != null)
			{
				string name = dgContact.CurrentRow.Cells[1].Value.ToString();
				string family = dgContact.CurrentRow.Cells[2].Value.ToString();
				string fullname = name + " " + family;
				if (MessageBox.Show($" ایا از حذف {fullname} مطمان هستید؟", "توجه", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					int contactid = (int)dgContact.CurrentRow.Cells[0].Value;
					if (contactRepository.Delete(contactid))
					{
						MessageBox.Show("حذف با موفقیت انجام شد", "پیغام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
					else
					{
						MessageBox.Show("حذف مخاطب ناموفق بود", "پیغام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}


					refrehs();
				}
			}
			else
			{
				MessageBox.Show("لطفا مخاطب خود را انتخاب کنید", "پیغام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnedit_Click(object sender, EventArgs e)
		{
			if (dgContact.CurrentRow != null)
			{
				string name = dgContact.CurrentRow.Cells[1].Value.ToString();
				string family = dgContact.CurrentRow.Cells[2].Value.ToString();
				string fullname = " "+name + " " + family+" ";
				if (MessageBox.Show($"مطمان هستید{fullname}ایا از ویرایش ", "پیغام سیستم", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					AddOrEdit frm=new AddOrEdit();
					frm.x = (int)dgContact.CurrentRow.Cells[0].Value;
					frm.ShowDialog();
				if(frm.DialogResult==DialogResult.OK)
					{
						refrehs();
					}
				}

				}
				

				else
				{
					MessageBox.Show("لطفا مخاطب خود را انتخاب کنید", "پیغام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}



			}
		}
	}

