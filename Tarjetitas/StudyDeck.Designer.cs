namespace Tarjetitas
{
    partial class StudyDeck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudyDeck));
            this.buttonBack = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.buttonIncorrect = new System.Windows.Forms.Button();
            this.buttonCorrect = new System.Windows.Forms.Button();
            this.labelCardNum = new System.Windows.Forms.Label();
            this.labelCorrectOnes = new System.Windows.Forms.Label();
            this.labelIncorrectOnes = new System.Windows.Forms.Label();
            this.flowLayoutPanelCards = new System.Windows.Forms.FlowLayoutPanel();
            this.labelIncorrectCards = new System.Windows.Forms.Label();
            this.buttonOpenCards = new System.Windows.Forms.Button();
            this.panelIncorrectCards = new System.Windows.Forms.Panel();
            this.buttonHide = new System.Windows.Forms.Button();
            this.panelIncorrectCards.SuspendLayout();
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
            this.buttonBack.TabIndex = 1;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.Transparent;
            this.panelContainer.Location = new System.Drawing.Point(261, 75);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(285, 285);
            this.panelContainer.TabIndex = 2;
            // 
            // buttonIncorrect
            // 
            this.buttonIncorrect.BackColor = System.Drawing.Color.Transparent;
            this.buttonIncorrect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonIncorrect.BackgroundImage")));
            this.buttonIncorrect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonIncorrect.FlatAppearance.BorderSize = 0;
            this.buttonIncorrect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonIncorrect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonIncorrect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIncorrect.Location = new System.Drawing.Point(341, 376);
            this.buttonIncorrect.Name = "buttonIncorrect";
            this.buttonIncorrect.Size = new System.Drawing.Size(49, 49);
            this.buttonIncorrect.TabIndex = 3;
            this.buttonIncorrect.UseVisualStyleBackColor = false;
            this.buttonIncorrect.Click += new System.EventHandler(this.buttonIncorrect_Click);
            // 
            // buttonCorrect
            // 
            this.buttonCorrect.BackColor = System.Drawing.Color.Transparent;
            this.buttonCorrect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCorrect.BackgroundImage")));
            this.buttonCorrect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCorrect.FlatAppearance.BorderSize = 0;
            this.buttonCorrect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonCorrect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonCorrect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCorrect.Location = new System.Drawing.Point(413, 376);
            this.buttonCorrect.Name = "buttonCorrect";
            this.buttonCorrect.Size = new System.Drawing.Size(49, 49);
            this.buttonCorrect.TabIndex = 4;
            this.buttonCorrect.UseVisualStyleBackColor = false;
            this.buttonCorrect.Click += new System.EventHandler(this.buttonCorrect_Click);
            // 
            // labelCardNum
            // 
            this.labelCardNum.AutoSize = true;
            this.labelCardNum.BackColor = System.Drawing.Color.Transparent;
            this.labelCardNum.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCardNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.labelCardNum.Location = new System.Drawing.Point(308, 36);
            this.labelCardNum.Name = "labelCardNum";
            this.labelCardNum.Size = new System.Drawing.Size(171, 25);
            this.labelCardNum.TabIndex = 5;
            this.labelCardNum.Text = "Tarjeta numero:";
            // 
            // labelCorrectOnes
            // 
            this.labelCorrectOnes.AutoSize = true;
            this.labelCorrectOnes.BackColor = System.Drawing.Color.Transparent;
            this.labelCorrectOnes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorrectOnes.ForeColor = System.Drawing.Color.Green;
            this.labelCorrectOnes.Location = new System.Drawing.Point(133, 182);
            this.labelCorrectOnes.Name = "labelCorrectOnes";
            this.labelCorrectOnes.Size = new System.Drawing.Size(86, 19);
            this.labelCorrectOnes.TabIndex = 6;
            this.labelCorrectOnes.Text = "Correctas:";
            // 
            // labelIncorrectOnes
            // 
            this.labelIncorrectOnes.AutoSize = true;
            this.labelIncorrectOnes.BackColor = System.Drawing.Color.Transparent;
            this.labelIncorrectOnes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIncorrectOnes.ForeColor = System.Drawing.Color.Red;
            this.labelIncorrectOnes.Location = new System.Drawing.Point(133, 213);
            this.labelIncorrectOnes.Name = "labelIncorrectOnes";
            this.labelIncorrectOnes.Size = new System.Drawing.Size(98, 19);
            this.labelIncorrectOnes.TabIndex = 7;
            this.labelIncorrectOnes.Text = "Incorrectas:";
            // 
            // flowLayoutPanelCards
            // 
            this.flowLayoutPanelCards.AutoScroll = true;
            this.flowLayoutPanelCards.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelCards.Location = new System.Drawing.Point(3, 75);
            this.flowLayoutPanelCards.Name = "flowLayoutPanelCards";
            this.flowLayoutPanelCards.Size = new System.Drawing.Size(310, 363);
            this.flowLayoutPanelCards.TabIndex = 8;
            // 
            // labelIncorrectCards
            // 
            this.labelIncorrectCards.AutoSize = true;
            this.labelIncorrectCards.BackColor = System.Drawing.Color.Transparent;
            this.labelIncorrectCards.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIncorrectCards.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.labelIncorrectCards.Location = new System.Drawing.Point(8, 50);
            this.labelIncorrectCards.Name = "labelIncorrectCards";
            this.labelIncorrectCards.Size = new System.Drawing.Size(149, 19);
            this.labelIncorrectCards.TabIndex = 9;
            this.labelIncorrectCards.Text = "Tarjetas a repasar:";
            // 
            // buttonOpenCards
            // 
            this.buttonOpenCards.BackColor = System.Drawing.Color.Crimson;
            this.buttonOpenCards.FlatAppearance.BorderSize = 0;
            this.buttonOpenCards.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenCards.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenCards.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.buttonOpenCards.Location = new System.Drawing.Point(672, 12);
            this.buttonOpenCards.Name = "buttonOpenCards";
            this.buttonOpenCards.Size = new System.Drawing.Size(147, 35);
            this.buttonOpenCards.TabIndex = 10;
            this.buttonOpenCards.Text = "Tarjetas a repasar";
            this.buttonOpenCards.UseVisualStyleBackColor = false;
            this.buttonOpenCards.Click += new System.EventHandler(this.buttonOpenCards_Click);
            // 
            // panelIncorrectCards
            // 
            this.panelIncorrectCards.BackColor = System.Drawing.Color.Transparent;
            this.panelIncorrectCards.Controls.Add(this.buttonHide);
            this.panelIncorrectCards.Controls.Add(this.labelIncorrectCards);
            this.panelIncorrectCards.Controls.Add(this.flowLayoutPanelCards);
            this.panelIncorrectCards.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelIncorrectCards.Location = new System.Drawing.Point(511, 0);
            this.panelIncorrectCards.Name = "panelIncorrectCards";
            this.panelIncorrectCards.Size = new System.Drawing.Size(320, 450);
            this.panelIncorrectCards.TabIndex = 11;
            this.panelIncorrectCards.Visible = false;
            // 
            // buttonHide
            // 
            this.buttonHide.BackColor = System.Drawing.Color.Transparent;
            this.buttonHide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHide.BackgroundImage")));
            this.buttonHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonHide.FlatAppearance.BorderSize = 0;
            this.buttonHide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonHide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHide.Location = new System.Drawing.Point(12, 12);
            this.buttonHide.Name = "buttonHide";
            this.buttonHide.Size = new System.Drawing.Size(35, 35);
            this.buttonHide.TabIndex = 12;
            this.buttonHide.UseVisualStyleBackColor = false;
            this.buttonHide.Click += new System.EventHandler(this.buttonHide_Click);
            // 
            // StudyDeck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(34)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.panelIncorrectCards);
            this.Controls.Add(this.buttonOpenCards);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.labelIncorrectOnes);
            this.Controls.Add(this.labelCorrectOnes);
            this.Controls.Add(this.labelCardNum);
            this.Controls.Add(this.buttonCorrect);
            this.Controls.Add(this.buttonIncorrect);
            this.Controls.Add(this.buttonBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudyDeck";
            this.Text = "StudyDeck";
            this.Load += new System.EventHandler(this.StudyDeck_Load);
            this.panelIncorrectCards.ResumeLayout(false);
            this.panelIncorrectCards.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button buttonIncorrect;
        private System.Windows.Forms.Button buttonCorrect;
        private System.Windows.Forms.Label labelCardNum;
        private System.Windows.Forms.Label labelCorrectOnes;
        private System.Windows.Forms.Label labelIncorrectOnes;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCards;
        private System.Windows.Forms.Label labelIncorrectCards;
        private System.Windows.Forms.Button buttonOpenCards;
        private System.Windows.Forms.Panel panelIncorrectCards;
        private System.Windows.Forms.Button buttonHide;
    }
}