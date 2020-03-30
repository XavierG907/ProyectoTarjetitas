namespace Tarjetitas
{
    partial class EditCards
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCards));
            this.buttonBack = new System.Windows.Forms.Button();
            this.panelEditCards = new System.Windows.Forms.Panel();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPresentation = new System.Windows.Forms.Label();
            this.labelDeckTitle = new System.Windows.Forms.Label();
            this.checkBoxDeckPublic = new System.Windows.Forms.CheckBox();
            this.textBoxDeckTitle = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonAddCard = new System.Windows.Forms.Button();
            this.labelEditCards = new System.Windows.Forms.Label();
            this.flowLayoutPanelCards = new System.Windows.Forms.FlowLayoutPanel();
            this.labelPresentation2 = new System.Windows.Forms.Label();
            this.labelSelectedCard = new System.Windows.Forms.Label();
            this.buttonDeleteCard = new System.Windows.Forms.Button();
            this.timerSelectedCard = new System.Windows.Forms.Timer(this.components);
            this.panelEditCards.SuspendLayout();
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
            this.buttonBack.Location = new System.Drawing.Point(3, 3);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(49, 49);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // panelEditCards
            // 
            this.panelEditCards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(78)))), ((int)(((byte)(107)))));
            this.panelEditCards.Controls.Add(this.labelUser);
            this.panelEditCards.Controls.Add(this.labelPresentation);
            this.panelEditCards.Controls.Add(this.labelDeckTitle);
            this.panelEditCards.Controls.Add(this.checkBoxDeckPublic);
            this.panelEditCards.Controls.Add(this.textBoxDeckTitle);
            this.panelEditCards.Controls.Add(this.buttonBack);
            this.panelEditCards.Controls.Add(this.buttonSave);
            this.panelEditCards.Controls.Add(this.buttonAddCard);
            this.panelEditCards.Controls.Add(this.labelEditCards);
            this.panelEditCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEditCards.Location = new System.Drawing.Point(0, 0);
            this.panelEditCards.Name = "panelEditCards";
            this.panelEditCards.Size = new System.Drawing.Size(831, 68);
            this.panelEditCards.TabIndex = 1;
            // 
            // labelUser
            // 
            this.labelUser.BackColor = System.Drawing.Color.Transparent;
            this.labelUser.ForeColor = System.Drawing.Color.White;
            this.labelUser.Location = new System.Drawing.Point(160, 44);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(134, 13);
            this.labelUser.TabIndex = 8;
            this.labelUser.Text = "Raul";
            // 
            // labelPresentation
            // 
            this.labelPresentation.AutoSize = true;
            this.labelPresentation.BackColor = System.Drawing.Color.Transparent;
            this.labelPresentation.ForeColor = System.Drawing.Color.White;
            this.labelPresentation.Location = new System.Drawing.Point(115, 44);
            this.labelPresentation.Name = "labelPresentation";
            this.labelPresentation.Size = new System.Drawing.Size(46, 13);
            this.labelPresentation.TabIndex = 7;
            this.labelPresentation.Text = "Usuario:";
            // 
            // labelDeckTitle
            // 
            this.labelDeckTitle.AutoSize = true;
            this.labelDeckTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelDeckTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeckTitle.ForeColor = System.Drawing.Color.DarkGray;
            this.labelDeckTitle.Location = new System.Drawing.Point(314, 12);
            this.labelDeckTitle.Name = "labelDeckTitle";
            this.labelDeckTitle.Size = new System.Drawing.Size(55, 18);
            this.labelDeckTitle.TabIndex = 6;
            this.labelDeckTitle.Text = "Titulo:";
            // 
            // checkBoxDeckPublic
            // 
            this.checkBoxDeckPublic.AutoSize = true;
            this.checkBoxDeckPublic.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxDeckPublic.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDeckPublic.ForeColor = System.Drawing.Color.DarkGray;
            this.checkBoxDeckPublic.Location = new System.Drawing.Point(317, 35);
            this.checkBoxDeckPublic.Name = "checkBoxDeckPublic";
            this.checkBoxDeckPublic.Size = new System.Drawing.Size(136, 22);
            this.checkBoxDeckPublic.TabIndex = 5;
            this.checkBoxDeckPublic.Text = "Baraja pública";
            this.checkBoxDeckPublic.UseVisualStyleBackColor = false;
            // 
            // textBoxDeckTitle
            // 
            this.textBoxDeckTitle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDeckTitle.Location = new System.Drawing.Point(375, 10);
            this.textBoxDeckTitle.Name = "textBoxDeckTitle";
            this.textBoxDeckTitle.Size = new System.Drawing.Size(261, 22);
            this.textBoxDeckTitle.TabIndex = 4;
            this.textBoxDeckTitle.Text = "Verbos irregulares en inglés I";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Transparent;
            this.buttonSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSave.BackgroundImage")));
            this.buttonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Location = new System.Drawing.Point(58, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(49, 49);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // buttonAddCard
            // 
            this.buttonAddCard.BackColor = System.Drawing.Color.Crimson;
            this.buttonAddCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddCard.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.buttonAddCard.FlatAppearance.BorderSize = 0;
            this.buttonAddCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddCard.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCard.ForeColor = System.Drawing.Color.DarkGray;
            this.buttonAddCard.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddCard.Image")));
            this.buttonAddCard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAddCard.Location = new System.Drawing.Point(645, 12);
            this.buttonAddCard.Name = "buttonAddCard";
            this.buttonAddCard.Size = new System.Drawing.Size(177, 45);
            this.buttonAddCard.TabIndex = 3;
            this.buttonAddCard.Text = "Agregar Tarjeta";
            this.buttonAddCard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddCard.UseVisualStyleBackColor = false;
            this.buttonAddCard.Click += new System.EventHandler(this.buttonAddCard_Click);
            // 
            // labelEditCards
            // 
            this.labelEditCards.AutoSize = true;
            this.labelEditCards.BackColor = System.Drawing.Color.Transparent;
            this.labelEditCards.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditCards.ForeColor = System.Drawing.Color.DarkGray;
            this.labelEditCards.Location = new System.Drawing.Point(113, 9);
            this.labelEditCards.Name = "labelEditCards";
            this.labelEditCards.Size = new System.Drawing.Size(191, 25);
            this.labelEditCards.TabIndex = 0;
            this.labelEditCards.Text = "Edición de Baraja";
            // 
            // flowLayoutPanelCards
            // 
            this.flowLayoutPanelCards.AutoScroll = true;
            this.flowLayoutPanelCards.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelCards.Location = new System.Drawing.Point(0, 68);
            this.flowLayoutPanelCards.Name = "flowLayoutPanelCards";
            this.flowLayoutPanelCards.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanelCards.Size = new System.Drawing.Size(831, 310);
            this.flowLayoutPanelCards.TabIndex = 2;
            this.flowLayoutPanelCards.WrapContents = false;
            // 
            // labelPresentation2
            // 
            this.labelPresentation2.AutoSize = true;
            this.labelPresentation2.BackColor = System.Drawing.Color.Transparent;
            this.labelPresentation2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPresentation2.ForeColor = System.Drawing.Color.DarkGray;
            this.labelPresentation2.Location = new System.Drawing.Point(3, 383);
            this.labelPresentation2.Name = "labelPresentation2";
            this.labelPresentation2.Size = new System.Drawing.Size(158, 18);
            this.labelPresentation2.TabIndex = 7;
            this.labelPresentation2.Text = "Carta seleccionada:";
            // 
            // labelSelectedCard
            // 
            this.labelSelectedCard.BackColor = System.Drawing.Color.Transparent;
            this.labelSelectedCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedCard.ForeColor = System.Drawing.Color.DarkGray;
            this.labelSelectedCard.Location = new System.Drawing.Point(160, 383);
            this.labelSelectedCard.Name = "labelSelectedCard";
            this.labelSelectedCard.Size = new System.Drawing.Size(158, 18);
            this.labelSelectedCard.TabIndex = 8;
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
            this.buttonDeleteCard.Location = new System.Drawing.Point(6, 410);
            this.buttonDeleteCard.Name = "buttonDeleteCard";
            this.buttonDeleteCard.Size = new System.Drawing.Size(163, 30);
            this.buttonDeleteCard.TabIndex = 9;
            this.buttonDeleteCard.Text = "Eliminar Tarjeta";
            this.buttonDeleteCard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeleteCard.UseVisualStyleBackColor = false;
            this.buttonDeleteCard.Click += new System.EventHandler(this.buttonDeleteCard_Click);
            // 
            // timerSelectedCard
            // 
            this.timerSelectedCard.Enabled = true;
            this.timerSelectedCard.Tick += new System.EventHandler(this.timerSelectedCard_Tick);
            // 
            // EditCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(34)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(831, 451);
            this.Controls.Add(this.buttonDeleteCard);
            this.Controls.Add(this.labelSelectedCard);
            this.Controls.Add(this.labelPresentation2);
            this.Controls.Add(this.flowLayoutPanelCards);
            this.Controls.Add(this.panelEditCards);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditCards";
            this.Text = "EditCards";
            this.panelEditCards.ResumeLayout(false);
            this.panelEditCards.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panelEditCards;
        private System.Windows.Forms.Label labelDeckTitle;
        private System.Windows.Forms.CheckBox checkBoxDeckPublic;
        private System.Windows.Forms.TextBox textBoxDeckTitle;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonAddCard;
        private System.Windows.Forms.Label labelEditCards;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCards;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPresentation;
        private System.Windows.Forms.Label labelPresentation2;
        private System.Windows.Forms.Label labelSelectedCard;
        private System.Windows.Forms.Button buttonDeleteCard;
        private System.Windows.Forms.Timer timerSelectedCard;
    }
}

