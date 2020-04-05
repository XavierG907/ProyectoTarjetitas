namespace Tarjetitas
{
    partial class RecycleCards
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecycleCards));
            this.panelRecycleCards = new System.Windows.Forms.Panel();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPresentation = new System.Windows.Forms.Label();
            this.labelRecycleCards = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.flowLayoutPanelCards = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonDeleteCard = new System.Windows.Forms.Button();
            this.buttonRecoveCard = new System.Windows.Forms.Button();
            this.labelPresentation2 = new System.Windows.Forms.Label();
            this.labelSelectedCard = new System.Windows.Forms.Label();
            this.comboBoxRecoveCard = new System.Windows.Forms.ComboBox();
            this.labelRecoveCard = new System.Windows.Forms.Label();
            this.timerSelection = new System.Windows.Forms.Timer(this.components);
            this.panelRecycleCards.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRecycleCards
            // 
            this.panelRecycleCards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(78)))), ((int)(((byte)(107)))));
            this.panelRecycleCards.Controls.Add(this.labelUser);
            this.panelRecycleCards.Controls.Add(this.labelPresentation);
            this.panelRecycleCards.Controls.Add(this.labelRecycleCards);
            this.panelRecycleCards.Controls.Add(this.buttonBack);
            this.panelRecycleCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRecycleCards.Location = new System.Drawing.Point(0, 0);
            this.panelRecycleCards.Name = "panelRecycleCards";
            this.panelRecycleCards.Size = new System.Drawing.Size(831, 68);
            this.panelRecycleCards.TabIndex = 0;
            // 
            // labelUser
            // 
            this.labelUser.BackColor = System.Drawing.Color.Transparent;
            this.labelUser.ForeColor = System.Drawing.Color.White;
            this.labelUser.Location = new System.Drawing.Point(108, 45);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(311, 13);
            this.labelUser.TabIndex = 12;
            this.labelUser.Text = "Raul";
            // 
            // labelPresentation
            // 
            this.labelPresentation.AutoSize = true;
            this.labelPresentation.BackColor = System.Drawing.Color.Transparent;
            this.labelPresentation.ForeColor = System.Drawing.Color.White;
            this.labelPresentation.Location = new System.Drawing.Point(63, 45);
            this.labelPresentation.Name = "labelPresentation";
            this.labelPresentation.Size = new System.Drawing.Size(46, 13);
            this.labelPresentation.TabIndex = 11;
            this.labelPresentation.Text = "Usuario:";
            // 
            // labelRecycleCards
            // 
            this.labelRecycleCards.AutoSize = true;
            this.labelRecycleCards.BackColor = System.Drawing.Color.Transparent;
            this.labelRecycleCards.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecycleCards.ForeColor = System.Drawing.Color.DarkGray;
            this.labelRecycleCards.Location = new System.Drawing.Point(58, 3);
            this.labelRecycleCards.Name = "labelRecycleCards";
            this.labelRecycleCards.Size = new System.Drawing.Size(281, 36);
            this.labelRecycleCards.TabIndex = 3;
            this.labelRecycleCards.Text = "Tarjetas Eliminadas";
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
            this.buttonBack.TabIndex = 2;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // flowLayoutPanelCards
            // 
            this.flowLayoutPanelCards.AutoScroll = true;
            this.flowLayoutPanelCards.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelCards.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanelCards.Location = new System.Drawing.Point(224, 68);
            this.flowLayoutPanelCards.Name = "flowLayoutPanelCards";
            this.flowLayoutPanelCards.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanelCards.Size = new System.Drawing.Size(607, 382);
            this.flowLayoutPanelCards.TabIndex = 3;
            // 
            // buttonDeleteCard
            // 
            this.buttonDeleteCard.BackColor = System.Drawing.Color.Crimson;
            this.buttonDeleteCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDeleteCard.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.buttonDeleteCard.FlatAppearance.BorderSize = 0;
            this.buttonDeleteCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteCard.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteCard.ForeColor = System.Drawing.Color.DarkGray;
            this.buttonDeleteCard.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeleteCard.Image")));
            this.buttonDeleteCard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDeleteCard.Location = new System.Drawing.Point(3, 375);
            this.buttonDeleteCard.Name = "buttonDeleteCard";
            this.buttonDeleteCard.Size = new System.Drawing.Size(186, 45);
            this.buttonDeleteCard.TabIndex = 10;
            this.buttonDeleteCard.Text = "Eliminar Tarjeta";
            this.buttonDeleteCard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeleteCard.UseVisualStyleBackColor = false;
            this.buttonDeleteCard.Click += new System.EventHandler(this.buttonDeleteCard_Click);
            // 
            // buttonRecoveCard
            // 
            this.buttonRecoveCard.BackColor = System.Drawing.Color.Crimson;
            this.buttonRecoveCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRecoveCard.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.buttonRecoveCard.FlatAppearance.BorderSize = 0;
            this.buttonRecoveCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRecoveCard.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRecoveCard.ForeColor = System.Drawing.Color.DarkGray;
            this.buttonRecoveCard.Image = ((System.Drawing.Image)(resources.GetObject("buttonRecoveCard.Image")));
            this.buttonRecoveCard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRecoveCard.Location = new System.Drawing.Point(3, 170);
            this.buttonRecoveCard.Name = "buttonRecoveCard";
            this.buttonRecoveCard.Size = new System.Drawing.Size(186, 45);
            this.buttonRecoveCard.TabIndex = 11;
            this.buttonRecoveCard.Text = "Recuperar Tarjeta";
            this.buttonRecoveCard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRecoveCard.UseVisualStyleBackColor = false;
            this.buttonRecoveCard.Click += new System.EventHandler(this.buttonRecoveCard_Click);
            // 
            // labelPresentation2
            // 
            this.labelPresentation2.BackColor = System.Drawing.Color.Transparent;
            this.labelPresentation2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPresentation2.ForeColor = System.Drawing.Color.DarkGray;
            this.labelPresentation2.Location = new System.Drawing.Point(10, 71);
            this.labelPresentation2.Name = "labelPresentation2";
            this.labelPresentation2.Size = new System.Drawing.Size(158, 43);
            this.labelPresentation2.TabIndex = 12;
            this.labelPresentation2.Text = "Carta seleccionada:";
            // 
            // labelSelectedCard
            // 
            this.labelSelectedCard.BackColor = System.Drawing.Color.Transparent;
            this.labelSelectedCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedCard.ForeColor = System.Drawing.Color.DarkGray;
            this.labelSelectedCard.Location = new System.Drawing.Point(10, 96);
            this.labelSelectedCard.Name = "labelSelectedCard";
            this.labelSelectedCard.Size = new System.Drawing.Size(158, 43);
            this.labelSelectedCard.TabIndex = 13;
            this.labelSelectedCard.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBoxRecoveCard
            // 
            this.comboBoxRecoveCard.BackColor = System.Drawing.SystemColors.Control;
            this.comboBoxRecoveCard.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRecoveCard.ForeColor = System.Drawing.Color.Black;
            this.comboBoxRecoveCard.FormattingEnabled = true;
            this.comboBoxRecoveCard.Location = new System.Drawing.Point(3, 248);
            this.comboBoxRecoveCard.Name = "comboBoxRecoveCard";
            this.comboBoxRecoveCard.Size = new System.Drawing.Size(186, 28);
            this.comboBoxRecoveCard.TabIndex = 14;
            // 
            // labelRecoveCard
            // 
            this.labelRecoveCard.AutoSize = true;
            this.labelRecoveCard.BackColor = System.Drawing.Color.Transparent;
            this.labelRecoveCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecoveCard.ForeColor = System.Drawing.Color.DarkGray;
            this.labelRecoveCard.Location = new System.Drawing.Point(10, 227);
            this.labelRecoveCard.Name = "labelRecoveCard";
            this.labelRecoveCard.Size = new System.Drawing.Size(158, 18);
            this.labelRecoveCard.TabIndex = 15;
            this.labelRecoveCard.Text = "Recuperar y mandar a:";
            // 
            // timerSelection
            // 
            this.timerSelection.Enabled = true;
            this.timerSelection.Tick += new System.EventHandler(this.timerSelection_Tick);
            // 
            // RecycleCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(34)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.labelRecoveCard);
            this.Controls.Add(this.comboBoxRecoveCard);
            this.Controls.Add(this.labelSelectedCard);
            this.Controls.Add(this.labelPresentation2);
            this.Controls.Add(this.buttonRecoveCard);
            this.Controls.Add(this.buttonDeleteCard);
            this.Controls.Add(this.flowLayoutPanelCards);
            this.Controls.Add(this.panelRecycleCards);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecycleCards";
            this.Text = "RecycleCards";
            this.Load += new System.EventHandler(this.RecycleCards_Load);
            this.panelRecycleCards.ResumeLayout(false);
            this.panelRecycleCards.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelRecycleCards;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelRecycleCards;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPresentation;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCards;
        private System.Windows.Forms.Button buttonDeleteCard;
        private System.Windows.Forms.Button buttonRecoveCard;
        private System.Windows.Forms.Label labelPresentation2;
        private System.Windows.Forms.Label labelSelectedCard;
        private System.Windows.Forms.ComboBox comboBoxRecoveCard;
        private System.Windows.Forms.Label labelRecoveCard;
        private System.Windows.Forms.Timer timerSelection;
    }
}