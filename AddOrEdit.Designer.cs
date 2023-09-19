namespace MyContactProject
{
	partial class AddOrEdit
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.txtAdress = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.NumberAge = new System.Windows.Forms.NumericUpDown();
			this.txtFamily = new System.Windows.Forms.TextBox();
			this.txtNumber = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.myContacts_DBDataSet1 = new MyContactProject.MyContacts_DBDataSet();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NumberAge)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.myContacts_DBDataSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.txtAdress);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.NumberAge);
			this.groupBox1.Controls.Add(this.txtFamily);
			this.groupBox1.Controls.Add(this.txtNumber);
			this.groupBox1.Controls.Add(this.txtEmail);
			this.groupBox1.Controls.Add(this.txtName);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(954, 567);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "اطلاعات فردی";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(801, 519);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(147, 40);
			this.button1.TabIndex = 13;
			this.button1.Text = "ثبت اطلاعت";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// txtAdress
			// 
			this.txtAdress.Location = new System.Drawing.Point(26, 291);
			this.txtAdress.Multiline = true;
			this.txtAdress.Name = "txtAdress";
			this.txtAdress.Size = new System.Drawing.Size(838, 199);
			this.txtAdress.TabIndex = 12;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(870, 291);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(98, 34);
			this.label6.TabIndex = 11;
			this.label6.Text = "ادرس :";
			// 
			// NumberAge
			// 
			this.NumberAge.Location = new System.Drawing.Point(586, 145);
			this.NumberAge.Name = "NumberAge";
			this.NumberAge.Size = new System.Drawing.Size(286, 41);
			this.NumberAge.TabIndex = 10;
			this.NumberAge.ValueChanged += new System.EventHandler(this.NumberAge_ValueChanged);
			// 
			// txtFamily
			// 
			this.txtFamily.Location = new System.Drawing.Point(32, 76);
			this.txtFamily.Name = "txtFamily";
			this.txtFamily.Size = new System.Drawing.Size(339, 41);
			this.txtFamily.TabIndex = 9;
			// 
			// txtNumber
			// 
			this.txtNumber.Location = new System.Drawing.Point(32, 149);
			this.txtNumber.Name = "txtNumber";
			this.txtNumber.Size = new System.Drawing.Size(339, 41);
			this.txtNumber.TabIndex = 7;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(26, 228);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(839, 41);
			this.txtEmail.TabIndex = 6;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(586, 76);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(279, 41);
			this.txtName.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(377, 76);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(183, 34);
			this.label5.TabIndex = 4;
			this.label5.Text = "نام خانوادگی :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(878, 149);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(82, 34);
			this.label4.TabIndex = 3;
			this.label4.Text = "سن :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(389, 156);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(171, 34);
			this.label3.TabIndex = 2;
			this.label3.Text = "شماره تلفن :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(864, 228);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 34);
			this.label2.TabIndex = 1;
			this.label2.Text = "ایمیل :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(881, 76);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 34);
			this.label1.TabIndex = 0;
			this.label1.Text = "نام :";
			// 
			// myContacts_DBDataSet1
			// 
			this.myContacts_DBDataSet1.DataSetName = "MyContacts_DBDataSet";
			this.myContacts_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// AddOrEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.ClientSize = new System.Drawing.Size(978, 583);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "AddOrEdit";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.AddOrEdit_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.NumberAge)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.myContacts_DBDataSet1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private MyContacts_DBDataSet myContacts_DBDataSet1;
		private System.Windows.Forms.TextBox txtFamily;
		private System.Windows.Forms.TextBox txtNumber;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown NumberAge;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtAdress;
		private System.Windows.Forms.Label label6;
	}
}