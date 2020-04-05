namespace Tarjetitas
{
    partial class RecycleBin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecycleBin));
            this.panelRecycleBin = new System.Windows.Forms.Panel();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelRecycleBin = new System.Windows.Forms.Label();
            this.labelPresentation = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.flowLayoutPanelDecks = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonLooseCards = new System.Windows.Forms.Button();
            this.buttonCheckDeck = new System.Windows.Forms.Button();
            this.labelDeckAuthor = new System.Windows.Forms.Label();
            this.labelDeckTitle = new System.Windows.Forms.Label();
            this.labelPresentation3 = new System.Windows.Forms.Label();
            this.labelPresentation2 = new System.Windows.Forms.Label();
            this.buttonRecoverDeck = new System.Windows.Forms.Button();
            this.buttonDeleteDeck = new System.Windows.Forms.Button();
            this.timerSelection = new System.Windows.Forms.Timer(this.components);
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelRecycleBin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRecycleBin
            // 
            this.panelRecycleBin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(78)))), ((int)(((byte)(107)))));
            this.panelRecycleBin.Controls.Add(this.labelUser);
            this.panelRecycleBin.Controls.Add(this.labelRecycleBin);
            this.panelRecycleBin.Controls.Add(this.labelPresentation);
            this.panelRecycleBin.Controls.Add(this.buttonBack);
            this.panelRecycleBin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRecycleBin.Location = new System.Drawing.Point(0, 0);
            this.panelRecycleBin.Name = "panelRecycleBin";
            this.panelRecycleBin.Size = new System.Drawing.Size(831, 68);
            this.panelRecycleBin.TabIndex = 0;
            // 
            // labelUser
            // 
            this.labelUser.BackColor = System.Drawing.Color.Transparent;
            this.labelUser.ForeColor = System.Drawing.Color.White;
            this.labelUser.Location = new System.Drawing.Point(109, 42);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(311, 13);
            this.labelUser.TabIndex = 10;
            this.labelUser.Text = "Raul";
            // 
            // labelRecycleBin
            // 
            this.labelRecycleBin.AutoSize = true;
            this.labelRecycleBin.BackColor = System.Drawing.Color.Transparent;
            this.labelRecycleBin.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecycleBin.ForeColor = System.Drawing.Color.DarkGray;
            this.labelRecycleBin.Location = new System.Drawing.Point(58, 3);
            this.labelRecycleBin.Name = "labelRecycleBin";
            this.labelRecycleBin.Size = new System.Drawing.Size(337, 36);
            this.labelRecycleBin.TabIndex = 2;
            this.labelRecycleBin.Text = "Papelería de Reciclaje";
            // 
            // labelPresentation
            // 
            this.labelPresentation.AutoSize = true;
            this.labelPresentation.BackColor = System.Drawing.Color.Transparent;
            this.labelPresentation.ForeColor = System.Drawing.Color.White;
            this.labelPresentation.Location = new System.Drawing.Point(64, 42);
            this.labelPresentation.Name = "labelPresentation";
            this.labelPresentation.Size = new System.Drawing.Size(46, 13);
            this.labelPresentation.TabIndex = 9;
            this.labelPresentation.Text = "Usuario:";
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
            this.buttonBack.Location = new System.Drawing.Point(3, 3);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(49, 49);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // flowLayoutPanelDecks
            // 
            this.flowLayoutPanelDecks.AutoScroll = true;
            this.flowLayoutPanelDecks.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelDecks.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanelDecks.Location = new System.Drawing.Point(0, 68);
            this.flowLayoutPanelDecks.Name = "flowLayoutPanelDecks";
            this.flowLayoutPanelDecks.Size = new System.Drawing.Size(585, 382);
            this.flowLayoutPanelDecks.TabIndex = 13;
            // 
            // buttonLooseCards
            // 
            this.buttonLooseCards.BackColor = System.Drawing.Color.Crimson;
            this.buttonLooseCards.FlatAppearance.BorderSize = 0;
            this.buttonLooseCards.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLooseCards.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLooseCards.ForeColor = System.Drawing.Color.DarkGray;
            this.buttonLooseCards.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLooseCards.Location = new System.Drawing.Point(601, 90);
            this.buttonLooseCards.Name = "buttonLooseCards";
            this.buttonLooseCards.Size = new System.Drawing.Size(218, 56);
            this.buttonLooseCards.TabIndex = 36;
            this.buttonLooseCards.Text = "Visualizar Tarjetas Sueltas";
            this.buttonLooseCards.UseVisualStyleBackColor = false;
            this.buttonLooseCards.Click += new System.EventHandler(this.buttonLooseCards_Click);
            // 
            // buttonCheckDeck
            // 
            this.buttonCheckDeck.BackColor = System.Drawing.Color.Crimson;
            this.buttonCheckDeck.FlatAppearance.BorderSize = 0;
            this.buttonCheckDeck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheckDeck.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckDeck.ForeColor = System.Drawing.Color.DarkGray;
            this.buttonCheckDeck.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCheckDeck.Location = new System.Drawing.Point(601, 285);
            this.buttonCheckDeck.Name = "buttonCheckDeck";
            this.buttonCheckDeck.Size = new System.Drawing.Size(218, 41);
            this.buttonCheckDeck.TabIndex = 37;
            this.buttonCheckDeck.Text = "Visualizar baraja";
            this.buttonCheckDeck.UseVisualStyleBackColor = false;
            this.buttonCheckDeck.Click += new System.EventHandler(this.buttonCheckDeck_Click);
            // 
            // labelDeckAuthor
            // 
            this.labelDeckAuthor.BackColor = System.Drawing.Color.Transparent;
            this.labelDeckAuthor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeckAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(135)))), ((int)(((byte)(143)))));
            this.labelDeckAuthor.Location = new System.Drawing.Point(654, 239);
            this.labelDeckAuthor.Name = "labelDeckAuthor";
            this.labelDeckAuthor.Size = new System.Drawing.Size(165, 20);
            this.labelDeckAuthor.TabIndex = 41;
            // 
            // labelDeckTitle
            // 
            this.labelDeckTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelDeckTitle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeckTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(135)))), ((int)(((byte)(143)))));
            this.labelDeckTitle.Location = new System.Drawing.Point(654, 204);
            this.labelDeckTitle.Name = "labelDeckTitle";
            this.labelDeckTitle.Size = new System.Drawing.Size(165, 20);
            this.labelDeckTitle.TabIndex = 40;
            // 
            // labelPresentation3
            // 
            this.labelPresentation3.BackColor = System.Drawing.Color.Transparent;
            this.labelPresentation3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPresentation3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(135)))), ((int)(((byte)(143)))));
            this.labelPresentation3.Location = new System.Drawing.Point(598, 204);
            this.labelPresentation3.Name = "labelPresentation3";
            this.labelPresentation3.Size = new System.Drawing.Size(47, 55);
            this.labelPresentation3.TabIndex = 39;
            this.labelPresentation3.Text = "Titulo:\r\n\r\nAutor:";
            // 
            // labelPresentation2
            // 
            this.labelPresentation2.BackColor = System.Drawing.Color.Transparent;
            this.labelPresentation2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPresentation2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(135)))), ((int)(((byte)(143)))));
            this.labelPresentation2.Location = new System.Drawing.Point(591, 177);
            this.labelPresentation2.Name = "labelPresentation2";
            this.labelPresentation2.Size = new System.Drawing.Size(179, 20);
            this.labelPresentation2.TabIndex = 38;
            this.labelPresentation2.Text = "Baraja Seleccionada:";
            // 
            // buttonRecoverDeck
            // 
            this.buttonRecoverDeck.BackColor = System.Drawing.Color.Crimson;
            this.buttonRecoverDeck.FlatAppearance.BorderSize = 0;
            this.buttonRecoverDeck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRecoverDeck.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRecoverDeck.ForeColor = System.Drawing.Color.DarkGray;
            this.buttonRecoverDeck.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRecoverDeck.Location = new System.Drawing.Point(601, 341);
            this.buttonRecoverDeck.Name = "buttonRecoverDeck";
            this.buttonRecoverDeck.Size = new System.Drawing.Size(218, 41);
            this.buttonRecoverDeck.TabIndex = 42;
            this.buttonRecoverDeck.Text = "Recuperar Baraja";
            this.buttonRecoverDeck.UseVisualStyleBackColor = false;
            this.buttonRecoverDeck.Click += new System.EventHandler(this.buttonRecoverDeck_Click);
            // 
            // buttonDeleteDeck
            // 
            this.buttonDeleteDeck.BackColor = System.Drawing.Color.Crimson;
            this.buttonDeleteDeck.FlatAppearance.BorderSize = 0;
            this.buttonDeleteDeck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteDeck.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteDeck.ForeColor = System.Drawing.Color.DarkGray;
            this.buttonDeleteDeck.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDeleteDeck.Location = new System.Drawing.Point(601, 397);
            this.buttonDeleteDeck.Name = "buttonDeleteDeck";
            this.buttonDeleteDeck.Size = new System.Drawing.Size(218, 41);
            this.buttonDeleteDeck.TabIndex = 43;
            this.buttonDeleteDeck.Text = "Eliminar Baraja";
            this.buttonDeleteDeck.UseVisualStyleBackColor = false;
            this.buttonDeleteDeck.Click += new System.EventHandler(this.buttonDeleteDeck_Click);
            // 
            // timerSelection
            // 
            this.timerSelection.Enabled = true;
            this.timerSelection.Tick += new System.EventHandler(this.timerSelection_Tick);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.Transparent;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(831, 450);
            this.panelContainer.TabIndex = 44;
            this.panelContainer.Visible = false;
            // 
            // RecycleBin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(34)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.buttonDeleteDeck);
            this.Controls.Add(this.buttonRecoverDeck);
            this.Controls.Add(this.labelDeckAuthor);
            this.Controls.Add(this.labelDeckTitle);
            this.Controls.Add(this.labelPresentation3);
            this.Controls.Add(this.labelPresentation2);
            this.Controls.Add(this.buttonCheckDeck);
            this.Controls.Add(this.buttonLooseCards);
            this.Controls.Add(this.flowLayoutPanelDecks);
            this.Controls.Add(this.panelRecycleBin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecycleBin";
            this.Text = "RecycleBin";
            this.Load += new System.EventHandler(this.RecycleBin_Load);
            this.panelRecycleBin.ResumeLayout(false);
            this.panelRecycleBin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRecycleBin;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelRecycleBin;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPresentation;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDecks;
        private System.Windows.Forms.Button buttonLooseCards;
        private System.Windows.Forms.Button buttonCheckDeck;
        private System.Windows.Forms.Label labelDeckAuthor;
        private System.Windows.Forms.Label labelDeckTitle;
        private System.Windows.Forms.Label labelPresentation3;
        private System.Windows.Forms.Label labelPresentation2;
        private System.Windows.Forms.Button buttonRecoverDeck;
        private System.Windows.Forms.Button buttonDeleteDeck;
        private System.Windows.Forms.Timer timerSelection;
        private System.Windows.Forms.Panel panelContainer;
    }
}