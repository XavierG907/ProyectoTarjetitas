namespace Tarjetitas
{
    partial class MyDecks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyDecks));
            this.buttonBack = new System.Windows.Forms.Button();
            this.panelMyDecks = new System.Windows.Forms.Panel();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPresentation = new System.Windows.Forms.Label();
            this.labelMyDecks = new System.Windows.Forms.Label();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonConfig = new System.Windows.Forms.Button();
            this.flowLayoutPanelDecks = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddDeck = new System.Windows.Forms.Button();
            this.textBoxDeckTitle = new System.Windows.Forms.TextBox();
            this.labelAddTitle = new System.Windows.Forms.Label();
            this.panelAddDeck = new System.Windows.Forms.Panel();
            this.checkBoxDeckPrivacy = new System.Windows.Forms.CheckBox();
            this.labelTitleAddDeck = new System.Windows.Forms.Label();
            this.panelMyDecks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.panelAddDeck.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Transparent;
            this.buttonBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBack.BackgroundImage")));
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.ForeColor = System.Drawing.Color.Transparent;
            this.buttonBack.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonBack.Location = new System.Drawing.Point(3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(50, 50);
            this.buttonBack.TabIndex = 9;
            this.buttonBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // panelMyDecks
            // 
            this.panelMyDecks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.panelMyDecks.Controls.Add(this.pictureBoxImage);
            this.panelMyDecks.Controls.Add(this.buttonBack);
            this.panelMyDecks.Controls.Add(this.labelUser);
            this.panelMyDecks.Controls.Add(this.labelPresentation);
            this.panelMyDecks.Controls.Add(this.labelMyDecks);
            this.panelMyDecks.Controls.Add(this.buttonHelp);
            this.panelMyDecks.Controls.Add(this.buttonConfig);
            this.panelMyDecks.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMyDecks.Location = new System.Drawing.Point(0, 0);
            this.panelMyDecks.Name = "panelMyDecks";
            this.panelMyDecks.Size = new System.Drawing.Size(831, 77);
            this.panelMyDecks.TabIndex = 10;
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxImage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxImage.Image")));
            this.pictureBoxImage.Location = new System.Drawing.Point(649, 5);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(151, 66);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImage.TabIndex = 9;
            this.pictureBoxImage.TabStop = false;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.BackColor = System.Drawing.Color.Transparent;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.White;
            this.labelUser.Location = new System.Drawing.Point(423, 58);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(36, 16);
            this.labelUser.TabIndex = 7;
            this.labelUser.Text = "Raúl";
            // 
            // labelPresentation
            // 
            this.labelPresentation.AutoSize = true;
            this.labelPresentation.BackColor = System.Drawing.Color.Transparent;
            this.labelPresentation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPresentation.ForeColor = System.Drawing.Color.White;
            this.labelPresentation.Location = new System.Drawing.Point(359, 58);
            this.labelPresentation.Name = "labelPresentation";
            this.labelPresentation.Size = new System.Drawing.Size(58, 16);
            this.labelPresentation.TabIndex = 6;
            this.labelPresentation.Text = "Usuario:";
            // 
            // labelMyDecks
            // 
            this.labelMyDecks.AutoSize = true;
            this.labelMyDecks.BackColor = System.Drawing.Color.Transparent;
            this.labelMyDecks.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMyDecks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(135)))), ((int)(((byte)(143)))));
            this.labelMyDecks.Location = new System.Drawing.Point(300, 9);
            this.labelMyDecks.Name = "labelMyDecks";
            this.labelMyDecks.Size = new System.Drawing.Size(219, 44);
            this.labelMyDecks.TabIndex = 5;
            this.labelMyDecks.Text = "Mis Barajas";
            this.labelMyDecks.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.Transparent;
            this.buttonHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHelp.BackgroundImage")));
            this.buttonHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonHelp.FlatAppearance.BorderSize = 0;
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.ForeColor = System.Drawing.Color.Transparent;
            this.buttonHelp.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonHelp.Location = new System.Drawing.Point(149, 3);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(50, 50);
            this.buttonHelp.TabIndex = 4;
            this.buttonHelp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonHelp.UseVisualStyleBackColor = false;
            // 
            // buttonConfig
            // 
            this.buttonConfig.BackColor = System.Drawing.Color.Transparent;
            this.buttonConfig.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonConfig.BackgroundImage")));
            this.buttonConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonConfig.FlatAppearance.BorderSize = 0;
            this.buttonConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfig.ForeColor = System.Drawing.Color.Transparent;
            this.buttonConfig.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonConfig.Location = new System.Drawing.Point(72, 3);
            this.buttonConfig.Name = "buttonConfig";
            this.buttonConfig.Size = new System.Drawing.Size(50, 50);
            this.buttonConfig.TabIndex = 3;
            this.buttonConfig.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonConfig.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanelDecks
            // 
            this.flowLayoutPanelDecks.AutoScroll = true;
            this.flowLayoutPanelDecks.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelDecks.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanelDecks.Location = new System.Drawing.Point(0, 77);
            this.flowLayoutPanelDecks.Name = "flowLayoutPanelDecks";
            this.flowLayoutPanelDecks.Size = new System.Drawing.Size(585, 373);
            this.flowLayoutPanelDecks.TabIndex = 11;
            // 
            // buttonAddDeck
            // 
            this.buttonAddDeck.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddDeck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAddDeck.BackgroundImage")));
            this.buttonAddDeck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddDeck.FlatAppearance.BorderSize = 0;
            this.buttonAddDeck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddDeck.ForeColor = System.Drawing.Color.Transparent;
            this.buttonAddDeck.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonAddDeck.Location = new System.Drawing.Point(159, 47);
            this.buttonAddDeck.Name = "buttonAddDeck";
            this.buttonAddDeck.Size = new System.Drawing.Size(50, 38);
            this.buttonAddDeck.TabIndex = 10;
            this.buttonAddDeck.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAddDeck.UseVisualStyleBackColor = false;
            this.buttonAddDeck.Click += new System.EventHandler(this.buttonAddDeck_Click);
            // 
            // textBoxDeckTitle
            // 
            this.textBoxDeckTitle.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxDeckTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDeckTitle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDeckTitle.ForeColor = System.Drawing.Color.Black;
            this.textBoxDeckTitle.Location = new System.Drawing.Point(6, 65);
            this.textBoxDeckTitle.Name = "textBoxDeckTitle";
            this.textBoxDeckTitle.Size = new System.Drawing.Size(147, 16);
            this.textBoxDeckTitle.TabIndex = 12;
            this.textBoxDeckTitle.Text = "Baraja sin Titulo";
            this.textBoxDeckTitle.Enter += new System.EventHandler(this.textBoxDeckTitle_Enter);
            this.textBoxDeckTitle.Leave += new System.EventHandler(this.textBoxDeckTitle_Leave);
            // 
            // labelAddTitle
            // 
            this.labelAddTitle.AutoSize = true;
            this.labelAddTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelAddTitle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(135)))), ((int)(((byte)(143)))));
            this.labelAddTitle.Location = new System.Drawing.Point(3, 47);
            this.labelAddTitle.Name = "labelAddTitle";
            this.labelAddTitle.Size = new System.Drawing.Size(46, 16);
            this.labelAddTitle.TabIndex = 13;
            this.labelAddTitle.Text = "Titulo:";
            // 
            // panelAddDeck
            // 
            this.panelAddDeck.BackColor = System.Drawing.Color.Transparent;
            this.panelAddDeck.Controls.Add(this.checkBoxDeckPrivacy);
            this.panelAddDeck.Controls.Add(this.labelTitleAddDeck);
            this.panelAddDeck.Controls.Add(this.buttonAddDeck);
            this.panelAddDeck.Controls.Add(this.textBoxDeckTitle);
            this.panelAddDeck.Controls.Add(this.labelAddTitle);
            this.panelAddDeck.Location = new System.Drawing.Point(601, 324);
            this.panelAddDeck.Name = "panelAddDeck";
            this.panelAddDeck.Size = new System.Drawing.Size(212, 114);
            this.panelAddDeck.TabIndex = 14;
            // 
            // checkBoxDeckPrivacy
            // 
            this.checkBoxDeckPrivacy.AutoSize = true;
            this.checkBoxDeckPrivacy.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxDeckPrivacy.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDeckPrivacy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(135)))), ((int)(((byte)(143)))));
            this.checkBoxDeckPrivacy.Location = new System.Drawing.Point(6, 87);
            this.checkBoxDeckPrivacy.Name = "checkBoxDeckPrivacy";
            this.checkBoxDeckPrivacy.Size = new System.Drawing.Size(124, 20);
            this.checkBoxDeckPrivacy.TabIndex = 16;
            this.checkBoxDeckPrivacy.Text = "Baraja Pública";
            this.checkBoxDeckPrivacy.UseVisualStyleBackColor = false;
            // 
            // labelTitleAddDeck
            // 
            this.labelTitleAddDeck.AutoSize = true;
            this.labelTitleAddDeck.BackColor = System.Drawing.Color.Transparent;
            this.labelTitleAddDeck.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleAddDeck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(135)))), ((int)(((byte)(143)))));
            this.labelTitleAddDeck.Location = new System.Drawing.Point(31, 9);
            this.labelTitleAddDeck.Name = "labelTitleAddDeck";
            this.labelTitleAddDeck.Size = new System.Drawing.Size(153, 23);
            this.labelTitleAddDeck.TabIndex = 15;
            this.labelTitleAddDeck.Text = "Agregar Baraja";
            // 
            // MyDecks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(34)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.panelAddDeck);
            this.Controls.Add(this.flowLayoutPanelDecks);
            this.Controls.Add(this.panelMyDecks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyDecks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyDecks";
            this.Load += new System.EventHandler(this.MyDecks_Load);
            this.panelMyDecks.ResumeLayout(false);
            this.panelMyDecks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.panelAddDeck.ResumeLayout(false);
            this.panelAddDeck.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panelMyDecks;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPresentation;
        private System.Windows.Forms.Label labelMyDecks;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDecks;
        private System.Windows.Forms.Button buttonAddDeck;
        private System.Windows.Forms.TextBox textBoxDeckTitle;
        private System.Windows.Forms.Label labelAddTitle;
        private System.Windows.Forms.Button buttonConfig;
        private System.Windows.Forms.Panel panelAddDeck;
        private System.Windows.Forms.Label labelTitleAddDeck;
        private System.Windows.Forms.CheckBox checkBoxDeckPrivacy;
    }
}