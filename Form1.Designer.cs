namespace MyContactProject
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dgContact = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Family = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.myContacts_DBDataSet = new MyContactProject.MyContacts_DBDataSet();
			this.myContactsDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.myContacts_DBDataSet1 = new MyContactProject.MyContacts_DBDataSet1();
			this.myContactsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.my_ContactsTableAdapter = new MyContactProject.MyContacts_DBDataSet1TableAdapters.My_ContactsTableAdapter();
			this.btnrefresh = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.btndelete = new System.Windows.Forms.Button();
			this.btnedit = new System.Windows.Forms.Button();
			this.txtsearch = new System.Windows.Forms.TextBox();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgContact)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.myContacts_DBDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.myContactsDBDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.myContacts_DBDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.myContactsBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dgContact);
			this.groupBox2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(0, 112);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(966, 468);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "لیست مخاطبان";
			// 
			// dgContact
			// 
			this.dgContact.AllowUserToAddRows = false;
			this.dgContact.AllowUserToDeleteRows = false;
			this.dgContact.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgContact.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MyName,
            this.Family,
            this.Email,
            this.Age,
            this.Number});
			this.dgContact.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgContact.Location = new System.Drawing.Point(3, 28);
			this.dgContact.Name = "dgContact";
			this.dgContact.ReadOnly = true;
			this.dgContact.RowHeadersWidth = 62;
			this.dgContact.RowTemplate.Height = 28;
			this.dgContact.Size = new System.Drawing.Size(960, 437);
			this.dgContact.TabIndex = 0;
			this.dgContact.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgContact_CellContentClick);
			// 
			// ID
			// 
			this.ID.DataPropertyName = "ID";
			this.ID.HeaderText = "کد شخص";
			this.ID.MinimumWidth = 8;
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			// 
			// MyName
			// 
			this.MyName.DataPropertyName = "Name";
			this.MyName.HeaderText = "نام";
			this.MyName.MinimumWidth = 8;
			this.MyName.Name = "MyName";
			this.MyName.ReadOnly = true;
			// 
			// Family
			// 
			this.Family.DataPropertyName = "Family";
			this.Family.HeaderText = "نام خانوادگی";
			this.Family.MinimumWidth = 8;
			this.Family.Name = "Family";
			this.Family.ReadOnly = true;
			// 
			// Email
			// 
			this.Email.DataPropertyName = "Email";
			this.Email.HeaderText = "ایمیل";
			this.Email.MinimumWidth = 8;
			this.Email.Name = "Email";
			this.Email.ReadOnly = true;
			// 
			// Age
			// 
			this.Age.DataPropertyName = "Age";
			this.Age.HeaderText = "سن";
			this.Age.MinimumWidth = 8;
			this.Age.Name = "Age";
			this.Age.ReadOnly = true;
			// 
			// Number
			// 
			this.Number.DataPropertyName = "Number";
			this.Number.HeaderText = "شماره تلفن";
			this.Number.MinimumWidth = 8;
			this.Number.Name = "Number";
			this.Number.ReadOnly = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtsearch);
			this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(16, 59);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(950, 47);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "پیدا کردن مخاطبان:";
			// 
			// myContacts_DBDataSet
			// 
			this.myContacts_DBDataSet.DataSetName = "MyContacts_DBDataSet";
			this.myContacts_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// myContactsDBDataSetBindingSource
			// 
			this.myContactsDBDataSetBindingSource.DataSource = this.myContacts_DBDataSet;
			this.myContactsDBDataSetBindingSource.Position = 0;
			// 
			// myContacts_DBDataSet1
			// 
			this.myContacts_DBDataSet1.DataSetName = "MyContacts_DBDataSet1";
			this.myContacts_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// myContactsBindingSource
			// 
			this.myContactsBindingSource.DataMember = "My_Contacts";
			this.myContactsBindingSource.DataSource = this.myContacts_DBDataSet1;
			// 
			// my_ContactsTableAdapter
			// 
			this.my_ContactsTableAdapter.ClearBeforeFill = true;
			// 
			// btnrefresh
			// 
			this.btnrefresh.Location = new System.Drawing.Point(855, 12);
			this.btnrefresh.Name = "btnrefresh";
			this.btnrefresh.Size = new System.Drawing.Size(111, 41);
			this.btnrefresh.TabIndex = 0;
			this.btnrefresh.Text = "بروزرسانی";
			this.btnrefresh.UseVisualStyleBackColor = true;
			this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(747, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(91, 41);
			this.button1.TabIndex = 3;
			this.button1.Text = "ثبت نام";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btndelete
			// 
			this.btndelete.Location = new System.Drawing.Point(632, 12);
			this.btndelete.Name = "btndelete";
			this.btndelete.Size = new System.Drawing.Size(95, 41);
			this.btndelete.TabIndex = 4;
			this.btndelete.Text = "حذف";
			this.btndelete.UseVisualStyleBackColor = true;
			this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
			// 
			// btnedit
			// 
			this.btnedit.Location = new System.Drawing.Point(508, 12);
			this.btnedit.Name = "btnedit";
			this.btnedit.Size = new System.Drawing.Size(99, 41);
			this.btnedit.TabIndex = 5;
			this.btnedit.Text = "ویرایش";
			this.btnedit.UseVisualStyleBackColor = true;
			this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
			// 
			// txtsearch
			// 
			this.txtsearch.BackColor = System.Drawing.SystemColors.HotTrack;
			this.txtsearch.Location = new System.Drawing.Point(-4, 11);
			this.txtsearch.Name = "txtsearch";
			this.txtsearch.Size = new System.Drawing.Size(749, 36);
			this.txtsearch.TabIndex = 0;
			this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.HotTrack;
			this.ClientSize = new System.Drawing.Size(978, 583);
			this.Controls.Add(this.btnedit);
			this.Controls.Add(this.btndelete);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnrefresh);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Form1";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "دفترچه تلفن من";
			this.Load += new System.EventHandler(this.Form1_Load_1);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgContact)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.myContacts_DBDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.myContactsDBDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.myContacts_DBDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.myContactsBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dgContact;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.BindingSource myContactsDBDataSetBindingSource;
		private MyContacts_DBDataSet myContacts_DBDataSet;
		private MyContacts_DBDataSet1 myContacts_DBDataSet1;
		private System.Windows.Forms.BindingSource myContactsBindingSource;
		private MyContacts_DBDataSet1TableAdapters.My_ContactsTableAdapter my_ContactsTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn MyName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Family;
		private System.Windows.Forms.DataGridViewTextBoxColumn Email;
		private System.Windows.Forms.DataGridViewTextBoxColumn Age;
		private System.Windows.Forms.DataGridViewTextBoxColumn Number;
		private System.Windows.Forms.Button btnrefresh;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btndelete;
		private System.Windows.Forms.Button btnedit;
		private System.Windows.Forms.TextBox txtsearch;
	}
}

