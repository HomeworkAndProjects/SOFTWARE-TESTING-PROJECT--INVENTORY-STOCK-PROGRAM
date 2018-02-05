namespace MDIFormDenemesi
{
    partial class FrmNormal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNormal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personelİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odaİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odaGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odayaDemirbaşAtaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelİşlemleriToolStripMenuItem,
            this.odaİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 41);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // personelİşlemleriToolStripMenuItem
            // 
            this.personelİşlemleriToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.personelİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelGörüntüleToolStripMenuItem});
            this.personelİşlemleriToolStripMenuItem.Name = "personelİşlemleriToolStripMenuItem";
            this.personelİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(230, 37);
            this.personelİşlemleriToolStripMenuItem.Text = "Personel İşlemleri";
            // 
            // personelGörüntüleToolStripMenuItem
            // 
            this.personelGörüntüleToolStripMenuItem.Name = "personelGörüntüleToolStripMenuItem";
            this.personelGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(299, 38);
            this.personelGörüntüleToolStripMenuItem.Text = "Personel Görüntüle";
            this.personelGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.personelGörüntüleToolStripMenuItem_Click);
            // 
            // odaİşlemleriToolStripMenuItem
            // 
            this.odaİşlemleriToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.odaİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odaGörüntüleToolStripMenuItem,
            this.odayaDemirbaşAtaToolStripMenuItem});
            this.odaİşlemleriToolStripMenuItem.Name = "odaİşlemleriToolStripMenuItem";
            this.odaİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(180, 37);
            this.odaİşlemleriToolStripMenuItem.Text = "Oda İşlemleri";
            // 
            // odaGörüntüleToolStripMenuItem
            // 
            this.odaGörüntüleToolStripMenuItem.Name = "odaGörüntüleToolStripMenuItem";
            this.odaGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(317, 38);
            this.odaGörüntüleToolStripMenuItem.Text = "Oda Görüntüle";
            this.odaGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.odaGörüntüleToolStripMenuItem_Click);
            // 
            // odayaDemirbaşAtaToolStripMenuItem
            // 
            this.odayaDemirbaşAtaToolStripMenuItem.Name = "odayaDemirbaşAtaToolStripMenuItem";
            this.odayaDemirbaşAtaToolStripMenuItem.Size = new System.Drawing.Size(317, 38);
            this.odayaDemirbaşAtaToolStripMenuItem.Text = "Odaya Demirbaş Ata";
            this.odayaDemirbaşAtaToolStripMenuItem.Click += new System.EventHandler(this.odayaDemirbaşAtaToolStripMenuItem_Click);
            // 
            // FrmNormal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmNormal";
            this.Text = "FrmNormal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personelİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odaİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odaGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odayaDemirbaşAtaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelGörüntüleToolStripMenuItem;
    }
}