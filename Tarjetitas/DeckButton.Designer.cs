namespace Tarjetitas
{
    partial class DeckButton
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeckButton));
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelNumCards = new System.Windows.Forms.Label();
            this.pictureBoxNotFavourite = new System.Windows.Forms.PictureBox();
            this.pictureBoxFavourite = new System.Windows.Forms.PictureBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNotFavourite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFavourite)).BeginInit();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            this.labelTitle.Location = new System.Drawing.Point(12, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(435, 23);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Titulo";
            this.labelTitle.Click += new System.EventHandler(this.panelContainer_Click);
            this.labelTitle.MouseEnter += new System.EventHandler(this.panelContainer_MouseEnter);
            this.labelTitle.MouseLeave += new System.EventHandler(this.panelContainer_MouseLeave);
            // 
            // labelAuthor
            // 
            this.labelAuthor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelAuthor.BackColor = System.Drawing.Color.Transparent;
            this.labelAuthor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.labelAuthor.Location = new System.Drawing.Point(13, 33);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(318, 23);
            this.labelAuthor.TabIndex = 1;
            this.labelAuthor.Text = "Autor: ";
            this.labelAuthor.Click += new System.EventHandler(this.panelContainer_Click);
            this.labelAuthor.MouseEnter += new System.EventHandler(this.panelContainer_MouseEnter);
            this.labelAuthor.MouseLeave += new System.EventHandler(this.panelContainer_MouseLeave);
            // 
            // labelNumCards
            // 
            this.labelNumCards.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelNumCards.BackColor = System.Drawing.Color.Transparent;
            this.labelNumCards.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumCards.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.labelNumCards.Location = new System.Drawing.Point(337, 33);
            this.labelNumCards.Name = "labelNumCards";
            this.labelNumCards.Size = new System.Drawing.Size(110, 23);
            this.labelNumCards.TabIndex = 2;
            this.labelNumCards.Text = "Cartas: ";
            this.labelNumCards.Click += new System.EventHandler(this.panelContainer_Click);
            this.labelNumCards.MouseEnter += new System.EventHandler(this.panelContainer_MouseEnter);
            this.labelNumCards.MouseLeave += new System.EventHandler(this.panelContainer_MouseLeave);
            // 
            // pictureBoxNotFavourite
            // 
            this.pictureBoxNotFavourite.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBoxNotFavourite.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxNotFavourite.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNotFavourite.Image")));
            this.pictureBoxNotFavourite.Location = new System.Drawing.Point(462, 6);
            this.pictureBoxNotFavourite.Name = "pictureBoxNotFavourite";
            this.pictureBoxNotFavourite.Size = new System.Drawing.Size(71, 50);
            this.pictureBoxNotFavourite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNotFavourite.TabIndex = 3;
            this.pictureBoxNotFavourite.TabStop = false;
            this.pictureBoxNotFavourite.Click += new System.EventHandler(this.pictureBoxNotFavourite_Click);
            this.pictureBoxNotFavourite.MouseEnter += new System.EventHandler(this.panelContainer_MouseEnter);
            this.pictureBoxNotFavourite.MouseLeave += new System.EventHandler(this.panelContainer_MouseEnter);
            // 
            // pictureBoxFavourite
            // 
            this.pictureBoxFavourite.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBoxFavourite.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFavourite.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFavourite.Image")));
            this.pictureBoxFavourite.Location = new System.Drawing.Point(462, 6);
            this.pictureBoxFavourite.Name = "pictureBoxFavourite";
            this.pictureBoxFavourite.Size = new System.Drawing.Size(71, 50);
            this.pictureBoxFavourite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFavourite.TabIndex = 4;
            this.pictureBoxFavourite.TabStop = false;
            this.pictureBoxFavourite.Visible = false;
            this.pictureBoxFavourite.Click += new System.EventHandler(this.pictureBoxFavourite_Click);
            this.pictureBoxFavourite.MouseEnter += new System.EventHandler(this.panelContainer_MouseEnter);
            this.pictureBoxFavourite.MouseLeave += new System.EventHandler(this.panelContainer_MouseEnter);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.Crimson;
            this.panelContainer.Controls.Add(this.labelTitle);
            this.panelContainer.Controls.Add(this.pictureBoxFavourite);
            this.panelContainer.Controls.Add(this.labelAuthor);
            this.panelContainer.Controls.Add(this.pictureBoxNotFavourite);
            this.panelContainer.Controls.Add(this.labelNumCards);
            this.panelContainer.Location = new System.Drawing.Point(8, 8);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(539, 65);
            this.panelContainer.TabIndex = 5;
            this.panelContainer.Click += new System.EventHandler(this.panelContainer_Click);
            this.panelContainer.MouseEnter += new System.EventHandler(this.panelContainer_MouseEnter);
            this.panelContainer.MouseLeave += new System.EventHandler(this.panelContainer_MouseLeave);
            // 
            // DeckButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelContainer);
            this.Name = "DeckButton";
            this.Size = new System.Drawing.Size(555, 81);
            this.Load += new System.EventHandler(this.DeckButton_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNotFavourite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFavourite)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelNumCards;
        private System.Windows.Forms.PictureBox pictureBoxNotFavourite;
        private System.Windows.Forms.PictureBox pictureBoxFavourite;
        private System.Windows.Forms.Panel panelContainer;
    }
}
