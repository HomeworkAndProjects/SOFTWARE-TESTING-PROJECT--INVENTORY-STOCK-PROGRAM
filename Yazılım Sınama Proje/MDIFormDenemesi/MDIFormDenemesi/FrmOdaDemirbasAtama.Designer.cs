namespace MDIFormDenemesi
{
    partial class frmDemirbasEkleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDemirbasEkleme));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDepartmanAdı = new System.Windows.Forms.Label();
            this.cmbDepartmanAdi = new System.Windows.Forms.ComboBox();
            this.lblFakulteAdi = new System.Windows.Forms.Label();
            this.cmbFakulteAdi = new System.Windows.Forms.ComboBox();
            this.lblOdaAdi = new System.Windows.Forms.Label();
            this.cmbOdaAdi = new System.Windows.Forms.ComboBox();
            this.btnDemirbasEkle = new System.Windows.Forms.Button();
            this.numDemirbasSayisi = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDemirbasAdi = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDemirbasSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 94);
            this.panel1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(12, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(330, 45);
            this.label4.TabIndex = 12;
            this.label4.Text = "Demirbaş Atama";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Controls.Add(this.lblDepartmanAdı);
            this.panel2.Controls.Add(this.cmbDepartmanAdi);
            this.panel2.Controls.Add(this.lblFakulteAdi);
            this.panel2.Controls.Add(this.cmbFakulteAdi);
            this.panel2.Controls.Add(this.lblOdaAdi);
            this.panel2.Controls.Add(this.cmbOdaAdi);
            this.panel2.Controls.Add(this.btnDemirbasEkle);
            this.panel2.Controls.Add(this.numDemirbasSayisi);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cmbDemirbasAdi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 448);
            this.panel2.TabIndex = 12;
            // 
            // lblDepartmanAdı
            // 
            this.lblDepartmanAdı.AutoSize = true;
            this.lblDepartmanAdı.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDepartmanAdı.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDepartmanAdı.Location = new System.Drawing.Point(94, 78);
            this.lblDepartmanAdı.Name = "lblDepartmanAdı";
            this.lblDepartmanAdı.Size = new System.Drawing.Size(153, 23);
            this.lblDepartmanAdı.TabIndex = 25;
            this.lblDepartmanAdı.Text = "Departman Adı";
            // 
            // cmbDepartmanAdi
            // 
            this.cmbDepartmanAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartmanAdi.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.cmbDepartmanAdi.FormattingEnabled = true;
            this.cmbDepartmanAdi.Location = new System.Drawing.Point(37, 104);
            this.cmbDepartmanAdi.Name = "cmbDepartmanAdi";
            this.cmbDepartmanAdi.Size = new System.Drawing.Size(293, 31);
            this.cmbDepartmanAdi.TabIndex = 24;
            this.cmbDepartmanAdi.SelectedIndexChanged += new System.EventHandler(this.cmbDepartmanAdı_SelectedIndexChanged);
            // 
            // lblFakulteAdi
            // 
            this.lblFakulteAdi.AutoSize = true;
            this.lblFakulteAdi.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFakulteAdi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFakulteAdi.Location = new System.Drawing.Point(94, 9);
            this.lblFakulteAdi.Name = "lblFakulteAdi";
            this.lblFakulteAdi.Size = new System.Drawing.Size(116, 23);
            this.lblFakulteAdi.TabIndex = 23;
            this.lblFakulteAdi.Text = "Fakulte Adı";
            // 
            // cmbFakulteAdi
            // 
            this.cmbFakulteAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFakulteAdi.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.cmbFakulteAdi.FormattingEnabled = true;
            this.cmbFakulteAdi.Location = new System.Drawing.Point(37, 44);
            this.cmbFakulteAdi.Name = "cmbFakulteAdi";
            this.cmbFakulteAdi.Size = new System.Drawing.Size(293, 31);
            this.cmbFakulteAdi.TabIndex = 22;
            this.cmbFakulteAdi.SelectedIndexChanged += new System.EventHandler(this.cmbFakulteAdi_SelectedIndexChanged);
            // 
            // lblOdaAdi
            // 
            this.lblOdaAdi.AutoSize = true;
            this.lblOdaAdi.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdaAdi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOdaAdi.Location = new System.Drawing.Point(94, 154);
            this.lblOdaAdi.Name = "lblOdaAdi";
            this.lblOdaAdi.Size = new System.Drawing.Size(86, 23);
            this.lblOdaAdi.TabIndex = 21;
            this.lblOdaAdi.Text = "Oda Adı";
            // 
            // cmbOdaAdi
            // 
            this.cmbOdaAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOdaAdi.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.cmbOdaAdi.FormattingEnabled = true;
            this.cmbOdaAdi.Location = new System.Drawing.Point(37, 180);
            this.cmbOdaAdi.Name = "cmbOdaAdi";
            this.cmbOdaAdi.Size = new System.Drawing.Size(293, 31);
            this.cmbOdaAdi.TabIndex = 20;
            this.cmbOdaAdi.SelectedIndexChanged += new System.EventHandler(this.cmbOdaAdi_SelectedIndexChanged);
            // 
            // btnDemirbasEkle
            // 
            this.btnDemirbasEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnDemirbasEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDemirbasEkle.BackgroundImage")));
            this.btnDemirbasEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDemirbasEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDemirbasEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDemirbasEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDemirbasEkle.Location = new System.Drawing.Point(120, 386);
            this.btnDemirbasEkle.Name = "btnDemirbasEkle";
            this.btnDemirbasEkle.Size = new System.Drawing.Size(90, 50);
            this.btnDemirbasEkle.TabIndex = 19;
            this.btnDemirbasEkle.Text = "Ekle";
            this.btnDemirbasEkle.UseVisualStyleBackColor = false;
            this.btnDemirbasEkle.Click += new System.EventHandler(this.btnDemirbasEkle_Click);
            // 
            // numDemirbasSayisi
            // 
            this.numDemirbasSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numDemirbasSayisi.Location = new System.Drawing.Point(37, 341);
            this.numDemirbasSayisi.Name = "numDemirbasSayisi";
            this.numDemirbasSayisi.Size = new System.Drawing.Size(293, 31);
            this.numDemirbasSayisi.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(94, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Demirbaş Sayısı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(92, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Demirbaş Adı";
            // 
            // cmbDemirbasAdi
            // 
            this.cmbDemirbasAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDemirbasAdi.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.cmbDemirbasAdi.FormattingEnabled = true;
            this.cmbDemirbasAdi.Location = new System.Drawing.Point(37, 258);
            this.cmbDemirbasAdi.Name = "cmbDemirbasAdi";
            this.cmbDemirbasAdi.Size = new System.Drawing.Size(293, 31);
            this.cmbDemirbasAdi.TabIndex = 11;
            this.cmbDemirbasAdi.SelectedIndexChanged += new System.EventHandler(this.cmbDemirbasAdi_SelectedIndexChanged);
            // 
            // frmDemirbasEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 542);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDemirbasEkleme";
            this.Text = "frmDemirbasEkleme";
            this.Load += new System.EventHandler(this.frmDemirbasEkleme_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDemirbasSayisi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDemirbasAdi;
        private System.Windows.Forms.NumericUpDown numDemirbasSayisi;
        private System.Windows.Forms.Button btnDemirbasEkle;
        private System.Windows.Forms.Label lblOdaAdi;
        private System.Windows.Forms.ComboBox cmbOdaAdi;
        private System.Windows.Forms.Label lblDepartmanAdı;
        private System.Windows.Forms.ComboBox cmbDepartmanAdi;
        private System.Windows.Forms.Label lblFakulteAdi;
        private System.Windows.Forms.ComboBox cmbFakulteAdi;
    }
}