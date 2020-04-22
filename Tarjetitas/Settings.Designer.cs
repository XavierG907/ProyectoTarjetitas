namespace Tarjetitas
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.buttonBack = new System.Windows.Forms.Button();
            this.txtConfPassword = new System.Windows.Forms.MaskedTextBox();
            this.txtPassword = new System.Windows.Forms.MaskedTextBox();
            this.cbTema = new System.Windows.Forms.ComboBox();
            this.dtpBirthdaay = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.errorEmail = new System.Windows.Forms.Label();
            this.errorConfPassword = new System.Windows.Forms.Label();
            this.errorPassword = new System.Windows.Forms.Label();
            this.errorUserName = new System.Windows.Forms.Label();
            this.errorLastName = new System.Windows.Forms.Label();
            this.errorName = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonConfig = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.errorGeneral = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Transparent;
            this.buttonBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBack.BackgroundImage")));
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Location = new System.Drawing.Point(12, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(49, 49);
            this.buttonBack.TabIndex = 53;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // txtConfPassword
            // 
            this.txtConfPassword.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtConfPassword.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtConfPassword.Location = new System.Drawing.Point(269, 400);
            this.txtConfPassword.Name = "txtConfPassword";
            this.txtConfPassword.Size = new System.Drawing.Size(299, 25);
            this.txtConfPassword.TabIndex = 64;
            this.txtConfPassword.UseSystemPasswordChar = true;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPassword.Location = new System.Drawing.Point(269, 348);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(299, 25);
            this.txtPassword.TabIndex = 62;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // cbTema
            // 
            this.cbTema.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cbTema.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbTema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTema.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbTema.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTema.FormattingEnabled = true;
            this.cbTema.Location = new System.Drawing.Point(269, 450);
            this.cbTema.Name = "cbTema";
            this.cbTema.Size = new System.Drawing.Size(299, 26);
            this.cbTema.TabIndex = 65;
            this.cbTema.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbTema_DrawItem);
            // 
            // dtpBirthdaay
            // 
            this.dtpBirthdaay.CustomFormat = "dd-MM-yyyy";
            this.dtpBirthdaay.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthdaay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthdaay.Location = new System.Drawing.Point(269, 192);
            this.dtpBirthdaay.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtpBirthdaay.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpBirthdaay.Name = "dtpBirthdaay";
            this.dtpBirthdaay.Size = new System.Drawing.Size(299, 25);
            this.dtpBirthdaay.TabIndex = 57;
            this.dtpBirthdaay.Value = new System.DateTime(2016, 12, 31, 0, 0, 0, 0);
            // 
            // label13
            // 
            this.label13.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label13.Location = new System.Drawing.Point(86, 453);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(177, 30);
            this.label13.TabIndex = 80;
            this.label13.Text = "TEMA";
            // 
            // errorEmail
            // 
            this.errorEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorEmail.ForeColor = System.Drawing.Color.LightCoral;
            this.errorEmail.Location = new System.Drawing.Point(270, 275);
            this.errorEmail.Name = "errorEmail";
            this.errorEmail.Size = new System.Drawing.Size(467, 19);
            this.errorEmail.TabIndex = 79;
            // 
            // errorConfPassword
            // 
            this.errorConfPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorConfPassword.ForeColor = System.Drawing.Color.LightCoral;
            this.errorConfPassword.Location = new System.Drawing.Point(270, 429);
            this.errorConfPassword.Name = "errorConfPassword";
            this.errorConfPassword.Size = new System.Drawing.Size(467, 19);
            this.errorConfPassword.TabIndex = 78;
            // 
            // errorPassword
            // 
            this.errorPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorPassword.ForeColor = System.Drawing.Color.LightCoral;
            this.errorPassword.Location = new System.Drawing.Point(267, 378);
            this.errorPassword.Name = "errorPassword";
            this.errorPassword.Size = new System.Drawing.Size(474, 19);
            this.errorPassword.TabIndex = 77;
            // 
            // errorUserName
            // 
            this.errorUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorUserName.ForeColor = System.Drawing.Color.LightCoral;
            this.errorUserName.Location = new System.Drawing.Point(270, 327);
            this.errorUserName.Name = "errorUserName";
            this.errorUserName.Size = new System.Drawing.Size(467, 19);
            this.errorUserName.TabIndex = 76;
            // 
            // errorLastName
            // 
            this.errorLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLastName.ForeColor = System.Drawing.Color.LightCoral;
            this.errorLastName.Location = new System.Drawing.Point(270, 172);
            this.errorLastName.Name = "errorLastName";
            this.errorLastName.Size = new System.Drawing.Size(467, 19);
            this.errorLastName.TabIndex = 75;
            // 
            // errorName
            // 
            this.errorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorName.ForeColor = System.Drawing.Color.LightCoral;
            this.errorName.Location = new System.Drawing.Point(270, 121);
            this.errorName.Name = "errorName";
            this.errorName.Size = new System.Drawing.Size(467, 19);
            this.errorName.TabIndex = 74;
            // 
            // label15
            // 
            this.label15.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label15.Location = new System.Drawing.Point(86, 403);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(177, 30);
            this.label15.TabIndex = 72;
            this.label15.Text = "CONFIRMAR CONTRASEÑA";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEmail.Location = new System.Drawing.Point(270, 244);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(298, 25);
            this.txtEmail.TabIndex = 58;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtUserName.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtUserName.Location = new System.Drawing.Point(270, 296);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(298, 25);
            this.txtUserName.TabIndex = 61;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtLastName.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLastName.Location = new System.Drawing.Point(270, 141);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(298, 25);
            this.txtLastName.TabIndex = 55;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtName.Location = new System.Drawing.Point(270, 89);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(298, 25);
            this.txtName.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label7.Location = new System.Drawing.Point(86, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 30);
            this.label7.TabIndex = 67;
            this.label7.Text = "NUEVA CONTRASEÑA";
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label6.Location = new System.Drawing.Point(86, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 30);
            this.label6.TabIndex = 66;
            this.label6.Text = "NOMBRE DE USUARIO";
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label5.Location = new System.Drawing.Point(86, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 30);
            this.label5.TabIndex = 63;
            this.label5.Text = "CORREO";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label3.Location = new System.Drawing.Point(86, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 30);
            this.label3.TabIndex = 60;
            this.label3.Text = "FECHA DE NACIMIENTO";
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label2.Location = new System.Drawing.Point(86, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 30);
            this.label2.TabIndex = 59;
            this.label2.Text = "APELLIDO(S)";
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label1.Location = new System.Drawing.Point(86, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 30);
            this.label1.TabIndex = 56;
            this.label1.Text = "NOMBRE(S)";
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.BackColor = System.Drawing.Color.Crimson;
            this.btnCreateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateUser.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnCreateUser.Location = new System.Drawing.Point(269, 500);
            this.btnCreateUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(299, 30);
            this.btnCreateUser.TabIndex = 81;
            this.btnCreateUser.Text = "CONFIRMAR CAMBIOS";
            this.btnCreateUser.UseVisualStyleBackColor = false;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(100)))), ((int)(((byte)(110)))));
            this.panel1.Controls.Add(this.buttonConfig);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 73);
            this.panel1.TabIndex = 82;
            // 
            // buttonConfig
            // 
            this.buttonConfig.BackColor = System.Drawing.Color.Transparent;
            this.buttonConfig.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonConfig.BackgroundImage")));
            this.buttonConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonConfig.FlatAppearance.BorderSize = 0;
            this.buttonConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfig.ForeColor = System.Drawing.Color.Transparent;
            this.buttonConfig.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonConfig.Location = new System.Drawing.Point(738, 12);
            this.buttonConfig.Name = "buttonConfig";
            this.buttonConfig.Size = new System.Drawing.Size(50, 50);
            this.buttonConfig.TabIndex = 83;
            this.buttonConfig.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonConfig.UseVisualStyleBackColor = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Aquamarine;
            this.label17.Location = new System.Drawing.Point(317, 22);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(199, 23);
            this.label17.TabIndex = 50;
            this.label17.Text = "AJUSTES DE USUARIO";
            // 
            // errorGeneral
            // 
            this.errorGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorGeneral.ForeColor = System.Drawing.Color.LightCoral;
            this.errorGeneral.Location = new System.Drawing.Point(270, 532);
            this.errorGeneral.Name = "errorGeneral";
            this.errorGeneral.Size = new System.Drawing.Size(467, 19);
            this.errorGeneral.TabIndex = 83;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(34)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 567);
            this.Controls.Add(this.errorGeneral);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCreateUser);
            this.Controls.Add(this.txtConfPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.cbTema);
            this.Controls.Add(this.dtpBirthdaay);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.errorEmail);
            this.Controls.Add(this.errorConfPassword);
            this.Controls.Add(this.errorPassword);
            this.Controls.Add(this.errorUserName);
            this.Controls.Add(this.errorLastName);
            this.Controls.Add(this.errorName);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Settings_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.MaskedTextBox txtConfPassword;
        private System.Windows.Forms.MaskedTextBox txtPassword;
        private System.Windows.Forms.ComboBox cbTema;
        private System.Windows.Forms.DateTimePicker dtpBirthdaay;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label errorEmail;
        private System.Windows.Forms.Label errorConfPassword;
        private System.Windows.Forms.Label errorPassword;
        private System.Windows.Forms.Label errorUserName;
        private System.Windows.Forms.Label errorLastName;
        private System.Windows.Forms.Label errorName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button buttonConfig;
        private System.Windows.Forms.Label errorGeneral;
    }
}