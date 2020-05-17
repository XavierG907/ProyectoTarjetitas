namespace Tarjetitas
{
    partial class OtherDecks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OtherDecks));
            this.panelOtherDecks = new System.Windows.Forms.Panel();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPresentation = new System.Windows.Forms.Label();
            this.labelDecksTitle = new System.Windows.Forms.Label();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.flowLayoutPanelDecks = new System.Windows.Forms.FlowLayoutPanel();
            this.labelDeckAuthor = new System.Windows.Forms.Label();
            this.labelDeckTitle = new System.Windows.Forms.Label();
            this.labelPresentation3 = new System.Windows.Forms.Label();
            this.labelPresentation2 = new System.Windows.Forms.Label();
            this.buttonStudyDeck = new System.Windows.Forms.Button();
            this.buttonPlayMemorama = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.timerSelection = new System.Windows.Forms.Timer(this.components);
            this.panelOtherDecks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOtherDecks
            // 
            this.panelOtherDecks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.panelOtherDecks.Controls.Add(this.pictureBoxImage);
            this.panelOtherDecks.Controls.Add(this.buttonBack);
            this.panelOtherDecks.Controls.Add(this.labelUser);
            this.panelOtherDecks.Controls.Add(this.labelPresentation);
            this.panelOtherDecks.Controls.Add(this.labelDecksTitle);
            this.panelOtherDecks.Controls.Add(this.buttonHelp);
            this.panelOtherDecks.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOtherDecks.Location = new System.Drawing.Point(0, 0);
            this.panelOtherDecks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelOtherDecks.Name = "panelOtherDecks";
            this.panelOtherDecks.Size = new System.Drawing.Size(1108, 95);
            this.panelOtherDecks.TabIndex = 11;
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxImage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxImage.Image")));
            this.pictureBoxImage.Location = new System.Drawing.Point(865, 6);
            this.pictureBoxImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(201, 81);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImage.TabIndex = 9;
            this.pictureBoxImage.TabStop = false;
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
            this.buttonBack.ForeColor = System.Drawing.Color.Transparent;
            this.buttonBack.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonBack.Location = new System.Drawing.Point(4, 2);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(67, 62);
            this.buttonBack.TabIndex = 9;
            this.buttonBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.BackColor = System.Drawing.Color.Transparent;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.White;
            this.labelUser.Location = new System.Drawing.Point(564, 71);
            this.labelUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(43, 20);
            this.labelUser.TabIndex = 7;
            this.labelUser.Text = "Raúl";
            // 
            // labelPresentation
            // 
            this.labelPresentation.AutoSize = true;
            this.labelPresentation.BackColor = System.Drawing.Color.Transparent;
            this.labelPresentation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPresentation.ForeColor = System.Drawing.Color.White;
            this.labelPresentation.Location = new System.Drawing.Point(479, 71);
            this.labelPresentation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPresentation.Name = "labelPresentation";
            this.labelPresentation.Size = new System.Drawing.Size(72, 20);
            this.labelPresentation.TabIndex = 6;
            this.labelPresentation.Text = "Usuario:";
            // 
            // labelDecksTitle
            // 
            this.labelDecksTitle.AutoSize = true;
            this.labelDecksTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelDecksTitle.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDecksTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(135)))), ((int)(((byte)(143)))));
            this.labelDecksTitle.Location = new System.Drawing.Point(372, 11);
            this.labelDecksTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDecksTitle.Name = "labelDecksTitle";
            this.labelDecksTitle.Size = new System.Drawing.Size(330, 56);
            this.labelDecksTitle.TabIndex = 5;
            this.labelDecksTitle.Text = "Barajas Pu/Fv";
            this.labelDecksTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.buttonHelp.Location = new System.Drawing.Point(103, 2);
            this.buttonHelp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(67, 62);
            this.buttonHelp.TabIndex = 4;
            this.buttonHelp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // flowLayoutPanelDecks
            // 
            this.flowLayoutPanelDecks.AutoScroll = true;
            this.flowLayoutPanelDecks.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelDecks.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanelDecks.Location = new System.Drawing.Point(0, 95);
            this.flowLayoutPanelDecks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanelDecks.Name = "flowLayoutPanelDecks";
            this.flowLayoutPanelDecks.Size = new System.Drawing.Size(780, 460);
            this.flowLayoutPanelDecks.TabIndex = 12;
            // 
            // labelDeckAuthor
            // 
            this.labelDeckAuthor.BackColor = System.Drawing.Color.Transparent;
            this.labelDeckAuthor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeckAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(135)))), ((int)(((byte)(143)))));
            this.labelDeckAuthor.Location = new System.Drawing.Point(872, 186);
            this.labelDeckAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDeckAuthor.Name = "labelDeckAuthor";
            this.labelDeckAuthor.Size = new System.Drawing.Size(220, 25);
            this.labelDeckAuthor.TabIndex = 34;
            // 
            // labelDeckTitle
            // 
            this.labelDeckTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelDeckTitle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeckTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(135)))), ((int)(((byte)(143)))));
            this.labelDeckTitle.Location = new System.Drawing.Point(872, 143);
            this.labelDeckTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDeckTitle.Name = "labelDeckTitle";
            this.labelDeckTitle.Size = new System.Drawing.Size(220, 25);
            this.labelDeckTitle.TabIndex = 33;
            // 
            // labelPresentation3
            // 
            this.labelPresentation3.BackColor = System.Drawing.Color.Transparent;
            this.labelPresentation3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPresentation3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(135)))), ((int)(((byte)(143)))));
            this.labelPresentation3.Location = new System.Drawing.Point(797, 143);
            this.labelPresentation3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPresentation3.Name = "labelPresentation3";
            this.labelPresentation3.Size = new System.Drawing.Size(63, 68);
            this.labelPresentation3.TabIndex = 32;
            this.labelPresentation3.Text = "Titulo:\r\n\r\nAutor:";
            // 
            // labelPresentation2
            // 
            this.labelPresentation2.BackColor = System.Drawing.Color.Transparent;
            this.labelPresentation2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPresentation2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(135)))), ((int)(((byte)(143)))));
            this.labelPresentation2.Location = new System.Drawing.Point(788, 110);
            this.labelPresentation2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPresentation2.Name = "labelPresentation2";
            this.labelPresentation2.Size = new System.Drawing.Size(239, 25);
            this.labelPresentation2.TabIndex = 31;
            this.labelPresentation2.Text = "Baraja Seleccionada:";
            // 
            // buttonStudyDeck
            // 
            this.buttonStudyDeck.BackColor = System.Drawing.Color.Crimson;
            this.buttonStudyDeck.FlatAppearance.BorderSize = 0;
            this.buttonStudyDeck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStudyDeck.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStudyDeck.ForeColor = System.Drawing.Color.DarkGray;
            this.buttonStudyDeck.Image = ((System.Drawing.Image)(resources.GetObject("buttonStudyDeck.Image")));
            this.buttonStudyDeck.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonStudyDeck.Location = new System.Drawing.Point(801, 286);
            this.buttonStudyDeck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonStudyDeck.Name = "buttonStudyDeck";
            this.buttonStudyDeck.Size = new System.Drawing.Size(291, 50);
            this.buttonStudyDeck.TabIndex = 35;
            this.buttonStudyDeck.Text = "Estudiar Baraja";
            this.buttonStudyDeck.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStudyDeck.UseVisualStyleBackColor = false;
            this.buttonStudyDeck.Click += new System.EventHandler(this.buttonStudyDeck_Click);
            // 
            // buttonPlayMemorama
            // 
            this.buttonPlayMemorama.BackColor = System.Drawing.Color.Crimson;
            this.buttonPlayMemorama.FlatAppearance.BorderSize = 0;
            this.buttonPlayMemorama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlayMemorama.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayMemorama.ForeColor = System.Drawing.Color.DarkGray;
            this.buttonPlayMemorama.Image = ((System.Drawing.Image)(resources.GetObject("buttonPlayMemorama.Image")));
            this.buttonPlayMemorama.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPlayMemorama.Location = new System.Drawing.Point(801, 362);
            this.buttonPlayMemorama.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPlayMemorama.Name = "buttonPlayMemorama";
            this.buttonPlayMemorama.Size = new System.Drawing.Size(291, 50);
            this.buttonPlayMemorama.TabIndex = 36;
            this.buttonPlayMemorama.Text = "Jugar Memorama";
            this.buttonPlayMemorama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPlayMemorama.UseVisualStyleBackColor = false;
            this.buttonPlayMemorama.Click += new System.EventHandler(this.buttonPlayMemorama_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.Transparent;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1108, 555);
            this.panelContainer.TabIndex = 37;
            this.panelContainer.Visible = false;
            // 
            // timerSelection
            // 
            this.timerSelection.Enabled = true;
            this.timerSelection.Tick += new System.EventHandler(this.timerSelection_Tick);
            // 
            // OtherDecks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(34)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1108, 555);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.buttonPlayMemorama);
            this.Controls.Add(this.buttonStudyDeck);
            this.Controls.Add(this.labelDeckAuthor);
            this.Controls.Add(this.labelDeckTitle);
            this.Controls.Add(this.labelPresentation3);
            this.Controls.Add(this.labelPresentation2);
            this.Controls.Add(this.flowLayoutPanelDecks);
            this.Controls.Add(this.panelOtherDecks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OtherDecks";
            this.Text = "OtherDecks";
            this.Load += new System.EventHandler(this.OtherDecks_Load);
            this.panelOtherDecks.ResumeLayout(false);
            this.panelOtherDecks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOtherDecks;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPresentation;
        private System.Windows.Forms.Label labelDecksTitle;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDecks;
        private System.Windows.Forms.Label labelDeckAuthor;
        private System.Windows.Forms.Label labelDeckTitle;
        private System.Windows.Forms.Label labelPresentation3;
        private System.Windows.Forms.Label labelPresentation2;
        private System.Windows.Forms.Button buttonStudyDeck;
        private System.Windows.Forms.Button buttonPlayMemorama;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Timer timerSelection;
    }
}