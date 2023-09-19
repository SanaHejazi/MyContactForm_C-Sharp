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
	public partial class AddOrEdit : Form
	{
		IContactRepository contactRepository;
		public AddOrEdit()
		{
			InitializeComponent();
			contactRepository = new ContactsRepository();
		}

		private void AddOrEdit_Load(object sender, EventArgs e)
		{
			
		}
		bool isvalid()
		{
			
			if (txtName.Text == "")
			{
				MessageBox.Show("لطفا نام را وارد کنید","هشدار",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return false;
			}
			if (txtFamily.Text == "")
			{
				MessageBox.Show("لطفا نام خانوادگی را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if (NumberAge.Value == null)
			{
				MessageBox.Show("لطفا سن را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if (txtNumber.Text == "")
			{
				MessageBox.Show("لطفا شماره تلفن را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if (txtEmail.Text == "")
			{
				MessageBox.Show("لطفا ایمیل را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if (txtAdress.Text == "")
			{
				MessageBox.Show("لطفا ادرس را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			return true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if(isvalid())
			{
				bool success= contactRepository.Insert(txtName.Text, txtFamily.Text,(int)NumberAge.Value, txtNumber.Text,txtAdress.Text);
				if(success)
				{
					MessageBox.Show("مخاطب موردنظر ثبت شد","پیغام سیستم",MessageBoxButtons.OK, MessageBoxIcon.Information);
					DialogResult = DialogResult.OK;
				}
				else
				{
					MessageBox.Show("اشکال در ثبت مخاطب", "پیغام سیستم", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void NumberAge_ValueChanged(object sender, EventArgs e)
		{

		}
	}
}
