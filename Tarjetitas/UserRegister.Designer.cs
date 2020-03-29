/*
 * Created by SharpDevelop.
 * User: g2
 * Date: 14/03/2020
 * Time: 09:40 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Tarjetitas
{
	partial class UserRegister
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pbCaptcha;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnCreateUser;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox txtVerification;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Button btnChangeCode;
		private System.Windows.Forms.Label errorName;
		private System.Windows.Forms.Label errorLastName;
		private System.Windows.Forms.Label errorUserName;
		private System.Windows.Forms.Label errorPassword;
		private System.Windows.Forms.Label errorConfPassword;
		private System.Windows.Forms.Label errorCode;
		private System.Windows.Forms.Label errorEmail;
		private System.Windows.Forms.Label errorGeneral;

		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRegister));
            this.pbCaptcha = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtVerification = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnChangeCode = new System.Windows.Forms.Button();
            this.errorName = new System.Windows.Forms.Label();
            this.errorLastName = new System.Windows.Forms.Label();
            this.errorUserName = new System.Windows.Forms.Label();
            this.errorPassword = new System.Windows.Forms.Label();
            this.errorConfPassword = new System.Windows.Forms.Label();
            this.errorCode = new System.Windows.Forms.Label();
            this.errorEmail = new System.Windows.Forms.Label();
            this.errorGeneral = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpBirthdaay = new System.Windows.Forms.DateTimePicker();
            this.cbTema = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.MaskedTextBox();
            this.txtConfPassword = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaptcha)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCaptcha
            // 
            this.pbCaptcha.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pbCaptcha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCaptcha.Location = new System.Drawing.Point(247, 463);
            this.pbCaptcha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbCaptcha.Name = "pbCaptcha";
            this.pbCaptcha.Size = new System.Drawing.Size(298, 85);
            this.pbCaptcha.TabIndex = 1;
            this.pbCaptcha.TabStop = false;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label1.Location = new System.Drawing.Point(63, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "NOMBRE(S)";
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label2.Location = new System.Drawing.Point(63, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "APELLIDO(S)";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label3.Location = new System.Drawing.Point(63, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "FECHA DE NACIMIENTO";
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label5.Location = new System.Drawing.Point(63, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 30);
            this.label5.TabIndex = 6;
            this.label5.Text = "CORREO";
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label6.Location = new System.Drawing.Point(63, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 30);
            this.label6.TabIndex = 7;
            this.label6.Text = "NOMBRE DE USUARIO";
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label7.Location = new System.Drawing.Point(63, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 30);
            this.label7.TabIndex = 8;
            this.label7.Text = "CONTRASEÑA";
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label8.Location = new System.Drawing.Point(63, 572);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 30);
            this.label8.TabIndex = 9;
            this.label8.Text = "CODIGO DE VERIFICACION";
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.BackColor = System.Drawing.Color.Crimson;
            this.btnCreateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateUser.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnCreateUser.Location = new System.Drawing.Point(423, 617);
            this.btnCreateUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(122, 30);
            this.btnCreateUser.TabIndex = 10;
            this.btnCreateUser.Text = "CONFIRMAR";
            this.btnCreateUser.UseVisualStyleBackColor = false;
            this.btnCreateUser.Click += new System.EventHandler(this.BtnCreateUserClick);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtName.Location = new System.Drawing.Point(247, 57);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(298, 25);
            this.txtName.TabIndex = 0;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtLastName.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLastName.Location = new System.Drawing.Point(247, 109);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(298, 25);
            this.txtLastName.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEmail.Location = new System.Drawing.Point(247, 212);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(298, 25);
            this.txtEmail.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(28, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 30);
            this.label9.TabIndex = 18;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(28, 316);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 30);
            this.label10.TabIndex = 19;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(28, 264);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 30);
            this.label11.TabIndex = 20;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(28, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 30);
            this.label12.TabIndex = 21;
            this.label12.Text = "*";
            // 
            // label15
            // 
            this.label15.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label15.Location = new System.Drawing.Point(63, 371);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(177, 30);
            this.label15.TabIndex = 23;
            this.label15.Text = "CONFIRMAR CONTRASEÑA";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(28, 367);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 30);
            this.label16.TabIndex = 28;
            this.label16.Text = "*";
            // 
            // txtVerification
            // 
            this.txtVerification.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtVerification.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerification.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtVerification.Location = new System.Drawing.Point(247, 567);
            this.txtVerification.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVerification.Name = "txtVerification";
            this.txtVerification.Size = new System.Drawing.Size(298, 25);
            this.txtVerification.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(28, 568);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 30);
            this.label14.TabIndex = 30;
            this.label14.Text = "*";
            // 
            // btnChangeCode
            // 
            this.btnChangeCode.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnChangeCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeCode.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnChangeCode.Location = new System.Drawing.Point(104, 482);
            this.btnChangeCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChangeCode.Name = "btnChangeCode";
            this.btnChangeCode.Size = new System.Drawing.Size(87, 46);
            this.btnChangeCode.TabIndex = 8;
            this.btnChangeCode.Text = "CAMBIAR CODIGO";
            this.btnChangeCode.UseVisualStyleBackColor = false;
            this.btnChangeCode.Click += new System.EventHandler(this.BtnChangeCodeClick);
            // 
            // errorName
            // 
            this.errorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorName.ForeColor = System.Drawing.Color.LightCoral;
            this.errorName.Location = new System.Drawing.Point(247, 89);
            this.errorName.Name = "errorName";
            this.errorName.Size = new System.Drawing.Size(467, 19);
            this.errorName.TabIndex = 32;
            // 
            // errorLastName
            // 
            this.errorLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLastName.ForeColor = System.Drawing.Color.LightCoral;
            this.errorLastName.Location = new System.Drawing.Point(247, 140);
            this.errorLastName.Name = "errorLastName";
            this.errorLastName.Size = new System.Drawing.Size(467, 19);
            this.errorLastName.TabIndex = 33;
            // 
            // errorUserName
            // 
            this.errorUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorUserName.ForeColor = System.Drawing.Color.LightCoral;
            this.errorUserName.Location = new System.Drawing.Point(247, 295);
            this.errorUserName.Name = "errorUserName";
            this.errorUserName.Size = new System.Drawing.Size(467, 19);
            this.errorUserName.TabIndex = 34;
            // 
            // errorPassword
            // 
            this.errorPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorPassword.ForeColor = System.Drawing.Color.LightCoral;
            this.errorPassword.Location = new System.Drawing.Point(244, 346);
            this.errorPassword.Name = "errorPassword";
            this.errorPassword.Size = new System.Drawing.Size(474, 19);
            this.errorPassword.TabIndex = 35;
            // 
            // errorConfPassword
            // 
            this.errorConfPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorConfPassword.ForeColor = System.Drawing.Color.LightCoral;
            this.errorConfPassword.Location = new System.Drawing.Point(247, 397);
            this.errorConfPassword.Name = "errorConfPassword";
            this.errorConfPassword.Size = new System.Drawing.Size(467, 19);
            this.errorConfPassword.TabIndex = 36;
            // 
            // errorCode
            // 
            this.errorCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorCode.ForeColor = System.Drawing.Color.LightCoral;
            this.errorCode.Location = new System.Drawing.Point(247, 598);
            this.errorCode.Name = "errorCode";
            this.errorCode.Size = new System.Drawing.Size(467, 19);
            this.errorCode.TabIndex = 37;
            // 
            // errorEmail
            // 
            this.errorEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorEmail.ForeColor = System.Drawing.Color.LightCoral;
            this.errorEmail.Location = new System.Drawing.Point(247, 243);
            this.errorEmail.Name = "errorEmail";
            this.errorEmail.Size = new System.Drawing.Size(467, 19);
            this.errorEmail.TabIndex = 40;
            // 
            // errorGeneral
            // 
            this.errorGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorGeneral.ForeColor = System.Drawing.Color.LightCoral;
            this.errorGeneral.Location = new System.Drawing.Point(247, 651);
            this.errorGeneral.Name = "errorGeneral";
            this.errorGeneral.Size = new System.Drawing.Size(467, 19);
            this.errorGeneral.TabIndex = 42;
            // 
            // label13
            // 
            this.label13.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label13.Location = new System.Drawing.Point(63, 421);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(177, 30);
            this.label13.TabIndex = 46;
            this.label13.Text = "TEMA";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(29, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 30);
            this.label4.TabIndex = 47;
            this.label4.Text = "*";
            // 
            // dtpBirthdaay
            // 
            this.dtpBirthdaay.CustomFormat = "dd-MM-yyyy";
            this.dtpBirthdaay.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthdaay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthdaay.Location = new System.Drawing.Point(246, 160);
            this.dtpBirthdaay.MaxDate = new System.DateTime(2016, 12, 31, 0, 0, 0, 0);
            this.dtpBirthdaay.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpBirthdaay.Name = "dtpBirthdaay";
            this.dtpBirthdaay.Size = new System.Drawing.Size(299, 25);
            this.dtpBirthdaay.TabIndex = 2;
            this.dtpBirthdaay.Value = new System.DateTime(2016, 12, 31, 0, 0, 0, 0);
            // 
            // cbTema
            // 
            this.cbTema.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cbTema.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbTema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTema.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbTema.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTema.FormattingEnabled = true;
            this.cbTema.Location = new System.Drawing.Point(246, 418);
            this.cbTema.Name = "cbTema";
            this.cbTema.Size = new System.Drawing.Size(299, 26);
            this.cbTema.TabIndex = 7;
            this.cbTema.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbTema_DrawItem);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(100)))), ((int)(((byte)(110)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.pictureBoxImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 45);
            this.panel1.TabIndex = 48;
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxImage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxImage.Image")));
            this.pictureBoxImage.Location = new System.Drawing.Point(615, 0);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(125, 47);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImage.TabIndex = 49;
            this.pictureBoxImage.TabStop = false;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtUserName.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtUserName.Location = new System.Drawing.Point(247, 264);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(298, 25);
            this.txtUserName.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPassword.Location = new System.Drawing.Point(246, 316);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(299, 25);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtConfPassword
            // 
            this.txtConfPassword.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtConfPassword.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtConfPassword.Location = new System.Drawing.Point(246, 368);
            this.txtConfPassword.Name = "txtConfPassword";
            this.txtConfPassword.Size = new System.Drawing.Size(299, 25);
            this.txtConfPassword.TabIndex = 6;
            this.txtConfPassword.UseSystemPasswordChar = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.BurlyWood;
            this.label17.Location = new System.Drawing.Point(314, 13);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(126, 23);
            this.label17.TabIndex = 50;
            this.label17.Text = "REGISTRARSE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // UserRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(34)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(740, 689);
            this.Controls.Add(this.txtConfPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbTema);
            this.Controls.Add(this.dtpBirthdaay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.errorGeneral);
            this.Controls.Add(this.errorEmail);
            this.Controls.Add(this.errorCode);
            this.Controls.Add(this.errorConfPassword);
            this.Controls.Add(this.errorPassword);
            this.Controls.Add(this.errorUserName);
            this.Controls.Add(this.errorLastName);
            this.Controls.Add(this.errorName);
            this.Controls.Add(this.btnChangeCode);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtVerification);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnCreateUser);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbCaptcha);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "UserRegister";
            this.Text = "Registro de usuario";
            ((System.ComponentModel.ISupportInitialize)(this.pbCaptcha)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpBirthdaay;
        private System.Windows.Forms.ComboBox cbTema;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.MaskedTextBox txtPassword;
        private System.Windows.Forms.MaskedTextBox txtConfPassword;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
