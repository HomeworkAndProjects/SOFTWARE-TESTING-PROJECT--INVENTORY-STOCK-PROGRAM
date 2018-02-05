namespace MDIFormDenemesi
{
    partial class FrmOdaArama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOdaArama));
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPersonelAta = new System.Windows.Forms.Button();
            this.cmbPersonelAta = new System.Windows.Forms.ComboBox();
            this.cmbDepartmanAdi = new System.Windows.Forms.ComboBox();
            this.cmbFakulteAdi = new System.Windows.Forms.ComboBox();
            this.lblDepartmanAdi = new System.Windows.Forms.Label();
            this.lblFakulteAdi = new System.Windows.Forms.Label();
            this.dGVOdaDemirbas = new System.Windows.Forms.DataGridView();
            this.grpOdaGoster = new System.Windows.Forms.GroupBox();
            this.lblPersonelNoGoruntule = new System.Windows.Forms.Label();
            this.lblPersonelSoyadiGoruntule = new System.Windows.Forms.Label();
            this.lblPersonelAdiGoruntule = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPersonelBilgiGoruntule = new System.Windows.Forms.Label();
            this.lblPersonelNo = new System.Windows.Forms.Label();
            this.lblPersonelSoyadi = new System.Windows.Forms.Label();
            this.lblPersonAdi = new System.Windows.Forms.Label();
            this.lblPersonelBilgileri = new System.Windows.Forms.Label();
            this.btnDokumanlastir = new System.Windows.Forms.Button();
            this.btnDemirbasAta = new System.Windows.Forms.Button();
            this.btnOdaArama = new System.Windows.Forms.Button();
            this.cmbGoreAra = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblOdaGoruntule = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVOdaDemirbas)).BeginInit();
            this.grpOdaGoster.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.cmbDepartmanAdi);
            this.panel2.Controls.Add(this.cmbFakulteAdi);
            this.panel2.Controls.Add(this.lblDepartmanAdi);
            this.panel2.Controls.Add(this.lblFakulteAdi);
            this.panel2.Controls.Add(this.dGVOdaDemirbas);
            this.panel2.Controls.Add(this.grpOdaGoster);
            this.panel2.Controls.Add(this.btnOdaArama);
            this.panel2.Controls.Add(this.cmbGoreAra);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1296, 655);
            this.panel2.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPersonelAta);
            this.groupBox1.Controls.Add(this.cmbPersonelAta);
            this.groupBox1.Location = new System.Drawing.Point(957, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 100);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Ata/Değiştir";
            // 
            // btnPersonelAta
            // 
            this.btnPersonelAta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPersonelAta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPersonelAta.Location = new System.Drawing.Point(69, 46);
            this.btnPersonelAta.Name = "btnPersonelAta";
            this.btnPersonelAta.Size = new System.Drawing.Size(165, 42);
            this.btnPersonelAta.TabIndex = 3;
            this.btnPersonelAta.Text = "Personel Ata/Değiştir";
            this.btnPersonelAta.UseVisualStyleBackColor = false;
            this.btnPersonelAta.Click += new System.EventHandler(this.btnPersonelAta_Click);
            // 
            // cmbPersonelAta
            // 
            this.cmbPersonelAta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonelAta.FormattingEnabled = true;
            this.cmbPersonelAta.Location = new System.Drawing.Point(45, 19);
            this.cmbPersonelAta.Name = "cmbPersonelAta";
            this.cmbPersonelAta.Size = new System.Drawing.Size(212, 21);
            this.cmbPersonelAta.TabIndex = 2;
            // 
            // cmbDepartmanAdi
            // 
            this.cmbDepartmanAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartmanAdi.FormattingEnabled = true;
            this.cmbDepartmanAdi.Location = new System.Drawing.Point(481, 72);
            this.cmbDepartmanAdi.Name = "cmbDepartmanAdi";
            this.cmbDepartmanAdi.Size = new System.Drawing.Size(149, 21);
            this.cmbDepartmanAdi.TabIndex = 20;
            this.cmbDepartmanAdi.SelectedIndexChanged += new System.EventHandler(this.cmbDepartmanAdi_SelectedIndexChanged);
            // 
            // cmbFakulteAdi
            // 
            this.cmbFakulteAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFakulteAdi.FormattingEnabled = true;
            this.cmbFakulteAdi.Location = new System.Drawing.Point(481, 30);
            this.cmbFakulteAdi.Name = "cmbFakulteAdi";
            this.cmbFakulteAdi.Size = new System.Drawing.Size(149, 21);
            this.cmbFakulteAdi.TabIndex = 19;
            this.cmbFakulteAdi.SelectedIndexChanged += new System.EventHandler(this.cmbFakulteAdi_SelectedIndexChanged);
            // 
            // lblDepartmanAdi
            // 
            this.lblDepartmanAdi.AutoSize = true;
            this.lblDepartmanAdi.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDepartmanAdi.Location = new System.Drawing.Point(300, 69);
            this.lblDepartmanAdi.Name = "lblDepartmanAdi";
            this.lblDepartmanAdi.Size = new System.Drawing.Size(150, 26);
            this.lblDepartmanAdi.TabIndex = 18;
            this.lblDepartmanAdi.Text = "Departman Adı";
            // 
            // lblFakulteAdi
            // 
            this.lblFakulteAdi.AutoSize = true;
            this.lblFakulteAdi.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFakulteAdi.Location = new System.Drawing.Point(300, 30);
            this.lblFakulteAdi.Name = "lblFakulteAdi";
            this.lblFakulteAdi.Size = new System.Drawing.Size(112, 26);
            this.lblFakulteAdi.TabIndex = 17;
            this.lblFakulteAdi.Text = "Fakülte Adı";
            // 
            // dGVOdaDemirbas
            // 
            this.dGVOdaDemirbas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVOdaDemirbas.Location = new System.Drawing.Point(31, 399);
            this.dGVOdaDemirbas.Name = "dGVOdaDemirbas";
            this.dGVOdaDemirbas.Size = new System.Drawing.Size(1221, 223);
            this.dGVOdaDemirbas.TabIndex = 16;
            // 
            // grpOdaGoster
            // 
            this.grpOdaGoster.Controls.Add(this.lblPersonelNoGoruntule);
            this.grpOdaGoster.Controls.Add(this.lblPersonelSoyadiGoruntule);
            this.grpOdaGoster.Controls.Add(this.lblPersonelAdiGoruntule);
            this.grpOdaGoster.Controls.Add(this.label1);
            this.grpOdaGoster.Controls.Add(this.lblPersonelBilgiGoruntule);
            this.grpOdaGoster.Controls.Add(this.lblPersonelNo);
            this.grpOdaGoster.Controls.Add(this.lblPersonelSoyadi);
            this.grpOdaGoster.Controls.Add(this.lblPersonAdi);
            this.grpOdaGoster.Controls.Add(this.lblPersonelBilgileri);
            this.grpOdaGoster.Controls.Add(this.btnDokumanlastir);
            this.grpOdaGoster.Controls.Add(this.btnDemirbasAta);
            this.grpOdaGoster.Location = new System.Drawing.Point(31, 135);
            this.grpOdaGoster.Name = "grpOdaGoster";
            this.grpOdaGoster.Size = new System.Drawing.Size(1221, 258);
            this.grpOdaGoster.TabIndex = 15;
            this.grpOdaGoster.TabStop = false;
            this.grpOdaGoster.Text = "Oda Görüntüle";
            // 
            // lblPersonelNoGoruntule
            // 
            this.lblPersonelNoGoruntule.AutoSize = true;
            this.lblPersonelNoGoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelNoGoruntule.ForeColor = System.Drawing.Color.White;
            this.lblPersonelNoGoruntule.Location = new System.Drawing.Point(267, 190);
            this.lblPersonelNoGoruntule.Name = "lblPersonelNoGoruntule";
            this.lblPersonelNoGoruntule.Size = new System.Drawing.Size(0, 25);
            this.lblPersonelNoGoruntule.TabIndex = 24;
            // 
            // lblPersonelSoyadiGoruntule
            // 
            this.lblPersonelSoyadiGoruntule.AutoSize = true;
            this.lblPersonelSoyadiGoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelSoyadiGoruntule.ForeColor = System.Drawing.Color.White;
            this.lblPersonelSoyadiGoruntule.Location = new System.Drawing.Point(267, 155);
            this.lblPersonelSoyadiGoruntule.Name = "lblPersonelSoyadiGoruntule";
            this.lblPersonelSoyadiGoruntule.Size = new System.Drawing.Size(0, 25);
            this.lblPersonelSoyadiGoruntule.TabIndex = 23;
            // 
            // lblPersonelAdiGoruntule
            // 
            this.lblPersonelAdiGoruntule.AutoSize = true;
            this.lblPersonelAdiGoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelAdiGoruntule.ForeColor = System.Drawing.Color.White;
            this.lblPersonelAdiGoruntule.Location = new System.Drawing.Point(267, 120);
            this.lblPersonelAdiGoruntule.Name = "lblPersonelAdiGoruntule";
            this.lblPersonelAdiGoruntule.Size = new System.Drawing.Size(0, 25);
            this.lblPersonelAdiGoruntule.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(599, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 21;
            // 
            // lblPersonelBilgiGoruntule
            // 
            this.lblPersonelBilgiGoruntule.AutoSize = true;
            this.lblPersonelBilgiGoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelBilgiGoruntule.ForeColor = System.Drawing.Color.White;
            this.lblPersonelBilgiGoruntule.Location = new System.Drawing.Point(267, 79);
            this.lblPersonelBilgiGoruntule.Name = "lblPersonelBilgiGoruntule";
            this.lblPersonelBilgiGoruntule.Size = new System.Drawing.Size(0, 25);
            this.lblPersonelBilgiGoruntule.TabIndex = 20;
            // 
            // lblPersonelNo
            // 
            this.lblPersonelNo.AutoSize = true;
            this.lblPersonelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelNo.ForeColor = System.Drawing.Color.White;
            this.lblPersonelNo.Location = new System.Drawing.Point(55, 190);
            this.lblPersonelNo.Name = "lblPersonelNo";
            this.lblPersonelNo.Size = new System.Drawing.Size(136, 25);
            this.lblPersonelNo.TabIndex = 16;
            this.lblPersonelNo.Text = "Personel No:";
            // 
            // lblPersonelSoyadi
            // 
            this.lblPersonelSoyadi.AutoSize = true;
            this.lblPersonelSoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelSoyadi.ForeColor = System.Drawing.Color.White;
            this.lblPersonelSoyadi.Location = new System.Drawing.Point(55, 155);
            this.lblPersonelSoyadi.Name = "lblPersonelSoyadi";
            this.lblPersonelSoyadi.Size = new System.Drawing.Size(84, 25);
            this.lblPersonelSoyadi.TabIndex = 17;
            this.lblPersonelSoyadi.Text = "Soyadı:";
            // 
            // lblPersonAdi
            // 
            this.lblPersonAdi.AutoSize = true;
            this.lblPersonAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonAdi.ForeColor = System.Drawing.Color.White;
            this.lblPersonAdi.Location = new System.Drawing.Point(55, 120);
            this.lblPersonAdi.Name = "lblPersonAdi";
            this.lblPersonAdi.Size = new System.Drawing.Size(49, 25);
            this.lblPersonAdi.TabIndex = 18;
            this.lblPersonAdi.Text = "Adı:";
            // 
            // lblPersonelBilgileri
            // 
            this.lblPersonelBilgileri.AutoSize = true;
            this.lblPersonelBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelBilgileri.ForeColor = System.Drawing.Color.White;
            this.lblPersonelBilgileri.Location = new System.Drawing.Point(54, 79);
            this.lblPersonelBilgileri.Name = "lblPersonelBilgileri";
            this.lblPersonelBilgileri.Size = new System.Drawing.Size(173, 25);
            this.lblPersonelBilgileri.TabIndex = 19;
            this.lblPersonelBilgileri.Text = "Personel Bilgileri";
            // 
            // btnDokumanlastir
            // 
            this.btnDokumanlastir.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDokumanlastir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDokumanlastir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDokumanlastir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDokumanlastir.Location = new System.Drawing.Point(1019, 177);
            this.btnDokumanlastir.Name = "btnDokumanlastir";
            this.btnDokumanlastir.Size = new System.Drawing.Size(164, 60);
            this.btnDokumanlastir.TabIndex = 13;
            this.btnDokumanlastir.Text = "Dökümanlaştır";
            this.btnDokumanlastir.UseVisualStyleBackColor = false;
            this.btnDokumanlastir.Click += new System.EventHandler(this.btnDokumanlastir_Click);
            // 
            // btnDemirbasAta
            // 
            this.btnDemirbasAta.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDemirbasAta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDemirbasAta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDemirbasAta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDemirbasAta.Location = new System.Drawing.Point(1019, 44);
            this.btnDemirbasAta.Name = "btnDemirbasAta";
            this.btnDemirbasAta.Size = new System.Drawing.Size(164, 60);
            this.btnDemirbasAta.TabIndex = 14;
            this.btnDemirbasAta.Text = "Demirbaş Ata";
            this.btnDemirbasAta.UseVisualStyleBackColor = false;
            this.btnDemirbasAta.Click += new System.EventHandler(this.btnDemirbasAta_Click);
            // 
            // btnOdaArama
            // 
            this.btnOdaArama.BackColor = System.Drawing.Color.Transparent;
            this.btnOdaArama.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOdaArama.BackgroundImage")));
            this.btnOdaArama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOdaArama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdaArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdaArama.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOdaArama.Location = new System.Drawing.Point(738, 69);
            this.btnOdaArama.Name = "btnOdaArama";
            this.btnOdaArama.Size = new System.Drawing.Size(189, 48);
            this.btnOdaArama.TabIndex = 15;
            this.btnOdaArama.Text = "Arama";
            this.btnOdaArama.UseVisualStyleBackColor = false;
            this.btnOdaArama.Click += new System.EventHandler(this.btnOdaArama_Click);
            // 
            // cmbGoreAra
            // 
            this.cmbGoreAra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGoreAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbGoreAra.FormattingEnabled = true;
            this.cmbGoreAra.Location = new System.Drawing.Point(738, 30);
            this.cmbGoreAra.Name = "cmbGoreAra";
            this.cmbGoreAra.Size = new System.Drawing.Size(189, 33);
            this.cmbGoreAra.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.lblOdaGoruntule);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1296, 94);
            this.panel1.TabIndex = 13;
            // 
            // lblOdaGoruntule
            // 
            this.lblOdaGoruntule.AutoSize = true;
            this.lblOdaGoruntule.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdaGoruntule.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOdaGoruntule.Location = new System.Drawing.Point(169, 26);
            this.lblOdaGoruntule.Name = "lblOdaGoruntule";
            this.lblOdaGoruntule.Size = new System.Drawing.Size(303, 45);
            this.lblOdaGoruntule.TabIndex = 12;
            this.lblOdaGoruntule.Text = "Oda Görüntüle ";
            // 
            // FrmOdaArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOdaArama";
            this.Text = "frmArama";
            this.Load += new System.EventHandler(this.FrmOdaArama_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVOdaDemirbas)).EndInit();
            this.grpOdaGoster.ResumeLayout(false);
            this.grpOdaGoster.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblOdaGoruntule;
        private System.Windows.Forms.ComboBox cmbGoreAra;
        private System.Windows.Forms.Button btnOdaArama;
        private System.Windows.Forms.GroupBox grpOdaGoster;
        private System.Windows.Forms.Button btnDokumanlastir;
        private System.Windows.Forms.Button btnDemirbasAta;
        private System.Windows.Forms.Label lblPersonelNoGoruntule;
        private System.Windows.Forms.Label lblPersonelSoyadiGoruntule;
        private System.Windows.Forms.Label lblPersonelAdiGoruntule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPersonelBilgiGoruntule;
        private System.Windows.Forms.Label lblPersonelNo;
        private System.Windows.Forms.Label lblPersonelSoyadi;
        private System.Windows.Forms.Label lblPersonAdi;
        private System.Windows.Forms.Label lblPersonelBilgileri;
        private System.Windows.Forms.DataGridView dGVOdaDemirbas;
        private System.Windows.Forms.ComboBox cmbDepartmanAdi;
        private System.Windows.Forms.ComboBox cmbFakulteAdi;
        private System.Windows.Forms.Label lblDepartmanAdi;
        private System.Windows.Forms.Label lblFakulteAdi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPersonelAta;
        private System.Windows.Forms.ComboBox cmbPersonelAta;
    }
}