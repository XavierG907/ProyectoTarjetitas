namespace Tarjetitas
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelMain = new System.Windows.Forms.Label();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonConfig = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonRecycleBin = new System.Windows.Forms.Button();
            this.buttonFavoriteDecks = new System.Windows.Forms.Button();
            this.buttonPublicDecks = new System.Windows.Forms.Button();
            this.buttonMyDecks = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.panelMainMenu.Controls.Add(this.pictureBoxImage);
            this.panelMainMenu.Controls.Add(this.labelUser);
            this.panelMainMenu.Controls.Add(this.labelWelcome);
            this.panelMainMenu.Controls.Add(this.labelMain);
            this.panelMainMenu.Controls.Add(this.buttonHelp);
            this.panelMainMenu.Controls.Add(this.buttonConfig);
            this.panelMainMenu.Controls.Add(this.buttonLogOut);
            this.panelMainMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(831, 77);
            this.panelMainMenu.TabIndex = 0;
            // 
            // pictureBoxImage
            // 
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
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.White;
            this.labelUser.Location = new System.Drawing.Point(423, 58);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(0, 16);
            this.labelUser.TabIndex = 7;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.Color.White;
            this.labelWelcome.Location = new System.Drawing.Point(343, 58);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(79, 16);
            this.labelWelcome.TabIndex = 6;
            this.labelWelcome.Text = "Bienvenido,";
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.BackColor = System.Drawing.Color.Transparent;
            this.labelMain.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(135)))), ((int)(((byte)(143)))));
            this.labelMain.Location = new System.Drawing.Point(274, 11);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(292, 44);
            this.labelMain.TabIndex = 5;
            this.labelMain.Text = "TARJETITAS PRO";
            this.labelMain.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.Transparent;
            this.buttonHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHelp.BackgroundImage")));
            this.buttonHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonHelp.FlatAppearance.BorderSize = 0;
            this.buttonHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
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
            this.buttonConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
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
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.Color.Transparent;
            this.buttonLogOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLogOut.BackgroundImage")));
            this.buttonLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLogOut.FlatAppearance.BorderSize = 0;
            this.buttonLogOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogOut.ForeColor = System.Drawing.Color.Transparent;
            this.buttonLogOut.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonLogOut.Location = new System.Drawing.Point(3, 3);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(50, 50);
            this.buttonLogOut.TabIndex = 1;
            this.buttonLogOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonRecycleBin
            // 
            this.buttonRecycleBin.BackColor = System.Drawing.Color.Crimson;
            this.buttonRecycleBin.FlatAppearance.BorderSize = 0;
            this.buttonRecycleBin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRecycleBin.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRecycleBin.ForeColor = System.Drawing.Color.DarkGray;
            this.buttonRecycleBin.Image = ((System.Drawing.Image)(resources.GetObject("buttonRecycleBin.Image")));
            this.buttonRecycleBin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRecycleBin.Location = new System.Drawing.Point(216, 368);
            this.buttonRecycleBin.Name = "buttonRecycleBin";
            this.buttonRecycleBin.Size = new System.Drawing.Size(398, 58);
            this.buttonRecycleBin.TabIndex = 27;
            this.buttonRecycleBin.Text = "Papelería de Reciclaje";
            this.buttonRecycleBin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRecycleBin.UseVisualStyleBackColor = false;
            this.buttonRecycleBin.Click += new System.EventHandler(this.buttonRecycleBin_Click);
            // 
            // buttonFavoriteDecks
            // 
            this.buttonFavoriteDecks.BackColor = System.Drawing.Color.Crimson;
            this.buttonFavoriteDecks.FlatAppearance.BorderSize = 0;
            this.buttonFavoriteDecks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFavoriteDecks.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFavoriteDecks.ForeColor = System.Drawing.Color.DarkGray;
            this.buttonFavoriteDecks.Image = ((System.Drawing.Image)(resources.GetObject("buttonFavoriteDecks.Image")));
            this.buttonFavoriteDecks.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFavoriteDecks.Location = new System.Drawing.Point(216, 279);
            this.buttonFavoriteDecks.Name = "buttonFavoriteDecks";
            this.buttonFavoriteDecks.Size = new System.Drawing.Size(398, 58);
            this.buttonFavoriteDecks.TabIndex = 26;
            this.buttonFavoriteDecks.Text = "Barajas Favoritas";
            this.buttonFavoriteDecks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFavoriteDecks.UseVisualStyleBackColor = false;
            this.buttonFavoriteDecks.Click += new System.EventHandler(this.buttonFavoriteDecks_Click);
            // 
            // buttonPublicDecks
            // 
            this.buttonPublicDecks.BackColor = System.Drawing.Color.Crimson;
            this.buttonPublicDecks.FlatAppearance.BorderSize = 0;
            this.buttonPublicDecks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPublicDecks.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPublicDecks.ForeColor = System.Drawing.Color.DarkGray;
            this.buttonPublicDecks.Image = ((System.Drawing.Image)(resources.GetObject("buttonPublicDecks.Image")));
            this.buttonPublicDecks.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPublicDecks.Location = new System.Drawing.Point(216, 190);
            this.buttonPublicDecks.Name = "buttonPublicDecks";
            this.buttonPublicDecks.Size = new System.Drawing.Size(398, 58);
            this.buttonPublicDecks.TabIndex = 25;
            this.buttonPublicDecks.Text = "Barajas Públicas";
            this.buttonPublicDecks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPublicDecks.UseVisualStyleBackColor = false;
            this.buttonPublicDecks.Click += new System.EventHandler(this.buttonPublicDecks_Click);
            // 
            // buttonMyDecks
            // 
            this.buttonMyDecks.BackColor = System.Drawing.Color.Crimson;
            this.buttonMyDecks.FlatAppearance.BorderSize = 0;
            this.buttonMyDecks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMyDecks.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMyDecks.ForeColor = System.Drawing.Color.DarkGray;
            this.buttonMyDecks.Image = ((System.Drawing.Image)(resources.GetObject("buttonMyDecks.Image")));
            this.buttonMyDecks.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMyDecks.Location = new System.Drawing.Point(216, 101);
            this.buttonMyDecks.Name = "buttonMyDecks";
            this.buttonMyDecks.Size = new System.Drawing.Size(398, 58);
            this.buttonMyDecks.TabIndex = 24;
            this.buttonMyDecks.Text = "Mis Barajas";
            this.buttonMyDecks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMyDecks.UseVisualStyleBackColor = false;
            this.buttonMyDecks.Click += new System.EventHandler(this.buttonMyDecks_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.Transparent;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(831, 451);
            this.panelContainer.TabIndex = 28;
            this.panelContainer.Visible = false;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(34)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.buttonRecycleBin);
            this.Controls.Add(this.buttonFavoriteDecks);
            this.Controls.Add(this.buttonPublicDecks);
            this.Controls.Add(this.buttonMyDecks);
            this.Controls.Add(this.panelMainMenu);
            this.MaximizeBox = false;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TarjetitasPro V1.1";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.panelMainMenu.ResumeLayout(false);
            this.panelMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMainMenu;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonConfig;
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Button buttonRecycleBin;
        private System.Windows.Forms.Button buttonFavoriteDecks;
        private System.Windows.Forms.Button buttonPublicDecks;
        private System.Windows.Forms.Button buttonMyDecks;
        private System.Windows.Forms.Panel panelContainer;
    }
}

