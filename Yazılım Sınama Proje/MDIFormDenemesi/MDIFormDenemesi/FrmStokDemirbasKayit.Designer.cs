namespace MDIFormDenemesi
{
    partial class frmStokDemirbasKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStokDemirbasKayit));
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbDemirbasTuru = new System.Windows.Forms.ComboBox();
            this.lblFiyatVirgul = new System.Windows.Forms.Label();
            this.txtFiyatOndalikKisim = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.numAdetinYazilmasi = new System.Windows.Forms.NumericUpDown();
            this.dateDemirbasAlimTarihi = new System.Windows.Forms.DateTimePicker();
            this.cmbDepartmanAdi = new System.Windows.Forms.ComboBox();
            this.cmbFakulteAdi = new System.Windows.Forms.ComboBox();
            this.lblDemirbasAdet = new System.Windows.Forms.Label();
            this.lblDemirbasTuru = new System.Windows.Forms.Label();
            this.lblDemirbasAlimTarihi = new System.Windows.Forms.Label();
            this.lblDemirbasAdi = new System.Windows.Forms.Label();
            this.lblDemirbasFiyat = new System.Windows.Forms.Label();
            this.lblDepartmanAdi = new System.Windows.Forms.Label();
            this.lblFakulteAdi = new System.Windows.Forms.Label();
            this.txtFiyatTamKisim = new System.Windows.Forms.TextBox();
            this.txtDemirbasAdi = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdetinYazilmasi)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Controls.Add(this.cmbDemirbasTuru);
            this.panel2.Controls.Add(this.lblFiyatVirgul);
            this.panel2.Controls.Add(this.txtFiyatOndalikKisim);
            this.panel2.Controls.Add(this.btnKaydet);
            this.panel2.Controls.Add(this.numAdetinYazilmasi);
            this.panel2.Controls.Add(this.dateDemirbasAlimTarihi);
            this.panel2.Controls.Add(this.cmbDepartmanAdi);
            this.panel2.Controls.Add(this.cmbFakulteAdi);
            this.panel2.Controls.Add(this.lblDemirbasAdet);
            this.panel2.Controls.Add(this.lblDemirbasTuru);
            this.panel2.Controls.Add(this.lblDemirbasAlimTarihi);
            this.panel2.Controls.Add(this.lblDemirbasAdi);
            this.panel2.Controls.Add(this.lblDemirbasFiyat);
            this.panel2.Controls.Add(this.lblDepartmanAdi);
            this.panel2.Controls.Add(this.lblFakulteAdi);
            this.panel2.Controls.Add(this.txtFiyatTamKisim);
            this.panel2.Controls.Add(this.txtDemirbasAdi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(623, 374);
            this.panel2.TabIndex = 16;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // cmbDemirbasTuru
            // 
            this.cmbDemirbasTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDemirbasTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDemirbasTuru.FormattingEnabled = true;
            this.cmbDemirbasTuru.Location = new System.Drawing.Point(328, 142);
            this.cmbDemirbasTuru.Name = "cmbDemirbasTuru";
            this.cmbDemirbasTuru.Size = new System.Drawing.Size(267, 33);
            this.cmbDemirbasTuru.TabIndex = 20;
            // 
            // lblFiyatVirgul
            // 
            this.lblFiyatVirgul.AutoSize = true;
            this.lblFiyatVirgul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyatVirgul.Location = new System.Drawing.Point(496, 191);
            this.lblFiyatVirgul.Name = "lblFiyatVirgul";
            this.lblFiyatVirgul.Size = new System.Drawing.Size(15, 24);
            this.lblFiyatVirgul.TabIndex = 19;
            this.lblFiyatVirgul.Text = ",";
            // 
            // txtFiyatOndalikKisim
            // 
            this.txtFiyatOndalikKisim.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFiyatOndalikKisim.Location = new System.Drawing.Point(517, 181);
            this.txtFiyatOndalikKisim.MaxLength = 2;
            this.txtFiyatOndalikKisim.Multiline = true;
            this.txtFiyatOndalikKisim.Name = "txtFiyatOndalikKisim";
            this.txtFiyatOndalikKisim.Size = new System.Drawing.Size(78, 37);
            this.txtFiyatOndalikKisim.TabIndex = 18;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Transparent;
            this.btnKaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKaydet.BackgroundImage")));
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKaydet.Location = new System.Drawing.Point(396, 311);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(199, 48);
            this.btnKaydet.TabIndex = 17;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // numAdetinYazilmasi
            // 
            this.numAdetinYazilmasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numAdetinYazilmasi.Location = new System.Drawing.Point(328, 274);
            this.numAdetinYazilmasi.Name = "numAdetinYazilmasi";
            this.numAdetinYazilmasi.Size = new System.Drawing.Size(267, 31);
            this.numAdetinYazilmasi.TabIndex = 15;
            // 
            // dateDemirbasAlimTarihi
            // 
            this.dateDemirbasAlimTarihi.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateDemirbasAlimTarihi.Location = new System.Drawing.Point(334, 233);
            this.dateDemirbasAlimTarihi.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dateDemirbasAlimTarihi.Name = "dateDemirbasAlimTarihi";
            this.dateDemirbasAlimTarihi.Size = new System.Drawing.Size(261, 20);
            this.dateDemirbasAlimTarihi.TabIndex = 14;
            // 
            // cmbDepartmanAdi
            // 
            this.cmbDepartmanAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartmanAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDepartmanAdi.FormattingEnabled = true;
            this.cmbDepartmanAdi.Location = new System.Drawing.Point(328, 62);
            this.cmbDepartmanAdi.Name = "cmbDepartmanAdi";
            this.cmbDepartmanAdi.Size = new System.Drawing.Size(267, 33);
            this.cmbDepartmanAdi.TabIndex = 13;
            this.cmbDepartmanAdi.SelectedIndexChanged += new System.EventHandler(this.cmbDepartmanAdi_SelectedIndexChanged);
            // 
            // cmbFakulteAdi
            // 
            this.cmbFakulteAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFakulteAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbFakulteAdi.FormattingEnabled = true;
            this.cmbFakulteAdi.Location = new System.Drawing.Point(328, 23);
            this.cmbFakulteAdi.Name = "cmbFakulteAdi";
            this.cmbFakulteAdi.Size = new System.Drawing.Size(267, 33);
            this.cmbFakulteAdi.TabIndex = 13;
            this.cmbFakulteAdi.SelectedIndexChanged += new System.EventHandler(this.cmbFakulteAdi_SelectedIndexChanged);
            // 
            // lblDemirbasAdet
            // 
            this.lblDemirbasAdet.AutoSize = true;
            this.lblDemirbasAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDemirbasAdet.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDemirbasAdet.Location = new System.Drawing.Point(12, 263);
            this.lblDemirbasAdet.Name = "lblDemirbasAdet";
            this.lblDemirbasAdet.Size = new System.Drawing.Size(236, 37);
            this.lblDemirbasAdet.TabIndex = 12;
            this.lblDemirbasAdet.Text = "Demirbaş Adeti";
            // 
            // lblDemirbasTuru
            // 
            this.lblDemirbasTuru.AutoSize = true;
            this.lblDemirbasTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDemirbasTuru.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDemirbasTuru.Location = new System.Drawing.Point(12, 140);
            this.lblDemirbasTuru.Name = "lblDemirbasTuru";
            this.lblDemirbasTuru.Size = new System.Drawing.Size(255, 37);
            this.lblDemirbasTuru.TabIndex = 12;
            this.lblDemirbasTuru.Text = "Demirbaşın Türü";
            // 
            // lblDemirbasAlimTarihi
            // 
            this.lblDemirbasAlimTarihi.AutoSize = true;
            this.lblDemirbasAlimTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDemirbasAlimTarihi.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDemirbasAlimTarihi.Location = new System.Drawing.Point(12, 221);
            this.lblDemirbasAlimTarihi.Name = "lblDemirbasAlimTarihi";
            this.lblDemirbasAlimTarihi.Size = new System.Drawing.Size(316, 37);
            this.lblDemirbasAlimTarihi.TabIndex = 12;
            this.lblDemirbasAlimTarihi.Text = "Demirbaş Alım Tarihi";
            // 
            // lblDemirbasAdi
            // 
            this.lblDemirbasAdi.AutoSize = true;
            this.lblDemirbasAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDemirbasAdi.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDemirbasAdi.Location = new System.Drawing.Point(12, 99);
            this.lblDemirbasAdi.Name = "lblDemirbasAdi";
            this.lblDemirbasAdi.Size = new System.Drawing.Size(210, 37);
            this.lblDemirbasAdi.TabIndex = 12;
            this.lblDemirbasAdi.Text = "Demirbaş Adı";
            // 
            // lblDemirbasFiyat
            // 
            this.lblDemirbasFiyat.AutoSize = true;
            this.lblDemirbasFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDemirbasFiyat.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDemirbasFiyat.Location = new System.Drawing.Point(12, 181);
            this.lblDemirbasFiyat.Name = "lblDemirbasFiyat";
            this.lblDemirbasFiyat.Size = new System.Drawing.Size(86, 37);
            this.lblDemirbasFiyat.TabIndex = 12;
            this.lblDemirbasFiyat.Text = "Fiyat";
            // 
            // lblDepartmanAdi
            // 
            this.lblDepartmanAdi.AutoSize = true;
            this.lblDepartmanAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmanAdi.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDepartmanAdi.Location = new System.Drawing.Point(12, 51);
            this.lblDepartmanAdi.Name = "lblDepartmanAdi";
            this.lblDepartmanAdi.Size = new System.Drawing.Size(232, 37);
            this.lblDepartmanAdi.TabIndex = 12;
            this.lblDepartmanAdi.Text = "Departman Adı";
            // 
            // lblFakulteAdi
            // 
            this.lblFakulteAdi.AutoSize = true;
            this.lblFakulteAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFakulteAdi.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFakulteAdi.Location = new System.Drawing.Point(12, 13);
            this.lblFakulteAdi.Name = "lblFakulteAdi";
            this.lblFakulteAdi.Size = new System.Drawing.Size(178, 37);
            this.lblFakulteAdi.TabIndex = 12;
            this.lblFakulteAdi.Text = "Fakülte Adı";
            // 
            // txtFiyatTamKisim
            // 
            this.txtFiyatTamKisim.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFiyatTamKisim.Location = new System.Drawing.Point(414, 181);
            this.txtFiyatTamKisim.MaxLength = 5;
            this.txtFiyatTamKisim.Multiline = true;
            this.txtFiyatTamKisim.Name = "txtFiyatTamKisim";
            this.txtFiyatTamKisim.Size = new System.Drawing.Size(78, 37);
            this.txtFiyatTamKisim.TabIndex = 11;
            // 
            // txtDemirbasAdi
            // 
            this.txtDemirbasAdi.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDemirbasAdi.Location = new System.Drawing.Point(328, 101);
            this.txtDemirbasAdi.MaxLength = 12;
            this.txtDemirbasAdi.Multiline = true;
            this.txtDemirbasAdi.Name = "txtDemirbasAdi";
            this.txtDemirbasAdi.Size = new System.Drawing.Size(267, 35);
            this.txtDemirbasAdi.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 94);
            this.panel1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(135, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(339, 45);
            this.label4.TabIndex = 12;
            this.label4.Text = "Demirbaş Kaydet";
            // 
            // frmStokDemirbasKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 468);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStokDemirbasKayit";
            this.Text = "frmDemirbasKayit";
            this.Load += new System.EventHandler(this.frmStokDemirbasKayit_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdetinYazilmasi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDemirbasAdi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateDemirbasAlimTarihi;
        private System.Windows.Forms.ComboBox cmbDepartmanAdi;
        private System.Windows.Forms.ComboBox cmbFakulteAdi;
        private System.Windows.Forms.Label lblDemirbasAdet;
        private System.Windows.Forms.Label lblDemirbasTuru;
        private System.Windows.Forms.Label lblDemirbasAlimTarihi;
        private System.Windows.Forms.Label lblDemirbasAdi;
        private System.Windows.Forms.Label lblDemirbasFiyat;
        private System.Windows.Forms.Label lblDepartmanAdi;
        private System.Windows.Forms.Label lblFakulteAdi;
        private System.Windows.Forms.TextBox txtFiyatTamKisim;
        private System.Windows.Forms.NumericUpDown numAdetinYazilmasi;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label lblFiyatVirgul;
        private System.Windows.Forms.TextBox txtFiyatOndalikKisim;
        private System.Windows.Forms.ComboBox cmbDemirbasTuru;
    }
}