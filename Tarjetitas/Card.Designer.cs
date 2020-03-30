namespace Tarjetitas
{
    partial class Card
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Card));
            this.buttonReverse = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.labelIdOcurrence = new System.Windows.Forms.Label();
            this.buttonAddMultContent = new System.Windows.Forms.Button();
            this.labelSide = new System.Windows.Forms.Label();
            this.contextMenuStripOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemText = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemImage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAudio = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemVideo = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonReverse
            // 
            this.buttonReverse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonReverse.BackgroundImage")));
            this.buttonReverse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonReverse.FlatAppearance.BorderSize = 0;
            this.buttonReverse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonReverse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonReverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReverse.Location = new System.Drawing.Point(242, 241);
            this.buttonReverse.Name = "buttonReverse";
            this.buttonReverse.Size = new System.Drawing.Size(40, 40);
            this.buttonReverse.TabIndex = 0;
            this.buttonReverse.UseVisualStyleBackColor = true;
            this.buttonReverse.Click += new System.EventHandler(this.buttonReverse_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(285, 235);
            this.panelContainer.TabIndex = 1;
            this.panelContainer.Click += new System.EventHandler(this.Card_Click);
            // 
            // labelIdOcurrence
            // 
            this.labelIdOcurrence.AutoSize = true;
            this.labelIdOcurrence.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdOcurrence.Location = new System.Drawing.Point(6, 262);
            this.labelIdOcurrence.Name = "labelIdOcurrence";
            this.labelIdOcurrence.Size = new System.Drawing.Size(0, 19);
            this.labelIdOcurrence.TabIndex = 2;
            // 
            // buttonAddMultContent
            // 
            this.buttonAddMultContent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAddMultContent.BackgroundImage")));
            this.buttonAddMultContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddMultContent.FlatAppearance.BorderSize = 0;
            this.buttonAddMultContent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonAddMultContent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonAddMultContent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddMultContent.Location = new System.Drawing.Point(196, 241);
            this.buttonAddMultContent.Name = "buttonAddMultContent";
            this.buttonAddMultContent.Size = new System.Drawing.Size(40, 40);
            this.buttonAddMultContent.TabIndex = 3;
            this.buttonAddMultContent.UseVisualStyleBackColor = true;
            this.buttonAddMultContent.Visible = false;
            this.buttonAddMultContent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonAddMultContent_MouseClick);
            // 
            // labelSide
            // 
            this.labelSide.AutoSize = true;
            this.labelSide.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSide.Location = new System.Drawing.Point(47, 261);
            this.labelSide.Name = "labelSide";
            this.labelSide.Size = new System.Drawing.Size(55, 20);
            this.labelSide.TabIndex = 4;
            this.labelSide.Text = "Frente";
            // 
            // contextMenuStripOptions
            // 
            this.contextMenuStripOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemText,
            this.toolStripMenuItemImage,
            this.toolStripMenuItemAudio,
            this.toolStripMenuItemVideo});
            this.contextMenuStripOptions.Name = "contextMenuStripOptions";
            this.contextMenuStripOptions.Size = new System.Drawing.Size(185, 114);
            this.contextMenuStripOptions.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStripOptions_ItemClicked);
            // 
            // toolStripMenuItemText
            // 
            this.toolStripMenuItemText.Name = "toolStripMenuItemText";
            this.toolStripMenuItemText.Size = new System.Drawing.Size(184, 22);
            this.toolStripMenuItemText.Text = "Agregar texto";
            // 
            // toolStripMenuItemImage
            // 
            this.toolStripMenuItemImage.Name = "toolStripMenuItemImage";
            this.toolStripMenuItemImage.Size = new System.Drawing.Size(184, 22);
            this.toolStripMenuItemImage.Text = "Agregar imagen";
            // 
            // toolStripMenuItemAudio
            // 
            this.toolStripMenuItemAudio.Name = "toolStripMenuItemAudio";
            this.toolStripMenuItemAudio.Size = new System.Drawing.Size(184, 22);
            this.toolStripMenuItemAudio.Text = "Agregar audio (.wav)";
            // 
            // toolStripMenuItemVideo
            // 
            this.toolStripMenuItemVideo.Name = "toolStripMenuItemVideo";
            this.toolStripMenuItemVideo.Size = new System.Drawing.Size(184, 22);
            this.toolStripMenuItemVideo.Text = "Agregar mp4/mp3";
            // 
            // Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelSide);
            this.Controls.Add(this.buttonAddMultContent);
            this.Controls.Add(this.labelIdOcurrence);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.buttonReverse);
            this.Name = "Card";
            this.Size = new System.Drawing.Size(285, 285);
            this.Click += new System.EventHandler(this.Card_Click);
            this.contextMenuStripOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReverse;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label labelIdOcurrence;
        private System.Windows.Forms.Button buttonAddMultContent;
        private System.Windows.Forms.Label labelSide;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripOptions;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemText;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemImage;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAudio;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemVideo;
    }
}
