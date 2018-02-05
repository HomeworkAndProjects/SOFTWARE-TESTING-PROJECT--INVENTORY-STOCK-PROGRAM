namespace MDIFormDenemesi
{
    partial class FrmStokGoruntule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStokGoruntule));
            this.dGVStokDemirbaslar = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupDemirbasAra = new System.Windows.Forms.GroupBox();
            this.btnDemirbasAra = new System.Windows.Forms.Button();
            this.cmbGoreAra = new System.Windows.Forms.ComboBox();
            this.radioAdeteGoreAra = new System.Windows.Forms.RadioButton();
            this.radioAdaGoreAra = new System.Windows.Forms.RadioButton();
            this.radioTariheGoreAra = new System.Windows.Forms.RadioButton();
            this.radioTureGoreAra = new System.Windows.Forms.RadioButton();
            this.radioFiyataGoreAra = new System.Windows.Forms.RadioButton();
            this.dateAlimTarihineGoreAra = new System.Windows.Forms.DateTimePicker();
            this.numAdeteGoreAra = new System.Windows.Forms.NumericUpDown();
            this.btnDemirbasEkle = new System.Windows.Forms.Button();
            this.btnDemirbasAta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVStokDemirbaslar)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupDemirbasAra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdeteGoreAra)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVStokDemirbaslar
            // 
            this.dGVStokDemirbaslar.AllowUserToAddRows = false;
            this.dGVStokDemirbaslar.AllowUserToDeleteRows = false;
            this.dGVStokDemirbaslar.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.dGVStokDemirbaslar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVStokDemirbaslar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dGVStokDemirbaslar.Location = new System.Drawing.Point(0, 316);
            this.dGVStokDemirbaslar.Name = "dGVStokDemirbaslar";
            this.dGVStokDemirbaslar.ReadOnly = true;
            this.dGVStokDemirbaslar.Size = new System.Drawing.Size(974, 325);
            this.dGVStokDemirbaslar.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 27.75F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(326, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(371, 45);
            this.label4.TabIndex = 5;
            this.label4.Text = "Demirbaş İşlemleri";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaGreen;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(974, 100);
            this.panel3.TabIndex = 6;
            // 
            // groupDemirbasAra
            // 
            this.groupDemirbasAra.Controls.Add(this.btnDemirbasAra);
            this.groupDemirbasAra.Controls.Add(this.cmbGoreAra);
            this.groupDemirbasAra.Controls.Add(this.radioAdeteGoreAra);
            this.groupDemirbasAra.Controls.Add(this.radioAdaGoreAra);
            this.groupDemirbasAra.Controls.Add(this.radioTariheGoreAra);
            this.groupDemirbasAra.Controls.Add(this.radioTureGoreAra);
            this.groupDemirbasAra.Controls.Add(this.radioFiyataGoreAra);
            this.groupDemirbasAra.Controls.Add(this.dateAlimTarihineGoreAra);
            this.groupDemirbasAra.Controls.Add(this.numAdeteGoreAra);
            this.groupDemirbasAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupDemirbasAra.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupDemirbasAra.Location = new System.Drawing.Point(13, 109);
            this.groupDemirbasAra.Name = "groupDemirbasAra";
            this.groupDemirbasAra.Size = new System.Drawing.Size(768, 171);
            this.groupDemirbasAra.TabIndex = 7;
            this.groupDemirbasAra.TabStop = false;
            this.groupDemirbasAra.Text = "Demirbaş Ara";
            // 
            // btnDemirbasAra
            // 
            this.btnDemirbasAra.BackColor = System.Drawing.Color.Transparent;
            this.btnDemirbasAra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDemirbasAra.BackgroundImage")));
            this.btnDemirbasAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDemirbasAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDemirbasAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDemirbasAra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDemirbasAra.Location = new System.Drawing.Point(321, 102);
            this.btnDemirbasAra.Name = "btnDemirbasAra";
            this.btnDemirbasAra.Size = new System.Drawing.Size(160, 46);
            this.btnDemirbasAra.TabIndex = 23;
            this.btnDemirbasAra.Text = "Demirbaş Ara";
            this.btnDemirbasAra.UseVisualStyleBackColor = false;
            this.btnDemirbasAra.Click += new System.EventHandler(this.btnDemirbasAra_Click);
            // 
            // cmbGoreAra
            // 
            this.cmbGoreAra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGoreAra.FormattingEnabled = true;
            this.cmbGoreAra.Location = new System.Drawing.Point(288, 64);
            this.cmbGoreAra.Name = "cmbGoreAra";
            this.cmbGoreAra.Size = new System.Drawing.Size(193, 32);
            this.cmbGoreAra.TabIndex = 18;
            // 
            // radioAdeteGoreAra
            // 
            this.radioAdeteGoreAra.AutoSize = true;
            this.radioAdeteGoreAra.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radioAdeteGoreAra.Location = new System.Drawing.Point(608, 28);
            this.radioAdeteGoreAra.Name = "radioAdeteGoreAra";
            this.radioAdeteGoreAra.Size = new System.Drawing.Size(125, 28);
            this.radioAdeteGoreAra.TabIndex = 17;
            this.radioAdeteGoreAra.TabStop = true;
            this.radioAdeteGoreAra.Text = "Adete Göre";
            this.radioAdeteGoreAra.UseVisualStyleBackColor = true;
            this.radioAdeteGoreAra.CheckedChanged += new System.EventHandler(this.radioAdeteGoreAra_CheckedChanged);
            // 
            // radioAdaGoreAra
            // 
            this.radioAdaGoreAra.AutoSize = true;
            this.radioAdaGoreAra.Checked = true;
            this.radioAdaGoreAra.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radioAdaGoreAra.Location = new System.Drawing.Point(28, 28);
            this.radioAdaGoreAra.Name = "radioAdaGoreAra";
            this.radioAdaGoreAra.Size = new System.Drawing.Size(109, 28);
            this.radioAdaGoreAra.TabIndex = 13;
            this.radioAdaGoreAra.TabStop = true;
            this.radioAdaGoreAra.Text = "Ada Göre";
            this.radioAdaGoreAra.UseVisualStyleBackColor = true;
            this.radioAdaGoreAra.CheckedChanged += new System.EventHandler(this.radioAdaGoreAra_CheckedChanged);
            // 
            // radioTariheGoreAra
            // 
            this.radioTariheGoreAra.AutoSize = true;
            this.radioTariheGoreAra.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radioTariheGoreAra.Location = new System.Drawing.Point(410, 28);
            this.radioTariheGoreAra.Name = "radioTariheGoreAra";
            this.radioTariheGoreAra.Size = new System.Drawing.Size(186, 28);
            this.radioTariheGoreAra.TabIndex = 16;
            this.radioTariheGoreAra.TabStop = true;
            this.radioTariheGoreAra.Text = "Alım Tarihine Göre";
            this.radioTariheGoreAra.UseVisualStyleBackColor = true;
            this.radioTariheGoreAra.CheckedChanged += new System.EventHandler(this.radioTariheGoreAra_CheckedChanged);
            // 
            // radioTureGoreAra
            // 
            this.radioTureGoreAra.AutoSize = true;
            this.radioTureGoreAra.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radioTureGoreAra.Location = new System.Drawing.Point(152, 28);
            this.radioTureGoreAra.Name = "radioTureGoreAra";
            this.radioTureGoreAra.Size = new System.Drawing.Size(115, 28);
            this.radioTureGoreAra.TabIndex = 14;
            this.radioTureGoreAra.TabStop = true;
            this.radioTureGoreAra.Text = "Türe Göre";
            this.radioTureGoreAra.UseVisualStyleBackColor = true;
            this.radioTureGoreAra.CheckedChanged += new System.EventHandler(this.radioTureGoreAra_CheckedChanged);
            // 
            // radioFiyataGoreAra
            // 
            this.radioFiyataGoreAra.AutoSize = true;
            this.radioFiyataGoreAra.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radioFiyataGoreAra.Location = new System.Drawing.Point(273, 28);
            this.radioFiyataGoreAra.Name = "radioFiyataGoreAra";
            this.radioFiyataGoreAra.Size = new System.Drawing.Size(124, 28);
            this.radioFiyataGoreAra.TabIndex = 15;
            this.radioFiyataGoreAra.TabStop = true;
            this.radioFiyataGoreAra.Text = "Fiyata Göre";
            this.radioFiyataGoreAra.UseVisualStyleBackColor = true;
            this.radioFiyataGoreAra.CheckedChanged += new System.EventHandler(this.radioFiyataGoreAra_CheckedChanged);
            // 
            // dateAlimTarihineGoreAra
            // 
            this.dateAlimTarihineGoreAra.Location = new System.Drawing.Point(245, 60);
            this.dateAlimTarihineGoreAra.Name = "dateAlimTarihineGoreAra";
            this.dateAlimTarihineGoreAra.Size = new System.Drawing.Size(307, 29);
            this.dateAlimTarihineGoreAra.TabIndex = 21;
            // 
            // numAdeteGoreAra
            // 
            this.numAdeteGoreAra.Location = new System.Drawing.Point(329, 62);
            this.numAdeteGoreAra.Name = "numAdeteGoreAra";
            this.numAdeteGoreAra.Size = new System.Drawing.Size(120, 29);
            this.numAdeteGoreAra.TabIndex = 22;
            // 
            // btnDemirbasEkle
            // 
            this.btnDemirbasEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnDemirbasEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDemirbasEkle.BackgroundImage")));
            this.btnDemirbasEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDemirbasEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDemirbasEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDemirbasEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDemirbasEkle.Location = new System.Drawing.Point(802, 109);
            this.btnDemirbasEkle.Name = "btnDemirbasEkle";
            this.btnDemirbasEkle.Size = new System.Drawing.Size(160, 56);
            this.btnDemirbasEkle.TabIndex = 18;
            this.btnDemirbasEkle.Text = "Demirbaş Ekle";
            this.btnDemirbasEkle.UseVisualStyleBackColor = false;
            this.btnDemirbasEkle.Click += new System.EventHandler(this.btnDemirbasEkle_Click);
            // 
            // btnDemirbasAta
            // 
            this.btnDemirbasAta.BackColor = System.Drawing.Color.Transparent;
            this.btnDemirbasAta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDemirbasAta.BackgroundImage")));
            this.btnDemirbasAta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDemirbasAta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDemirbasAta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDemirbasAta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDemirbasAta.Location = new System.Drawing.Point(802, 185);
            this.btnDemirbasAta.Name = "btnDemirbasAta";
            this.btnDemirbasAta.Size = new System.Drawing.Size(160, 59);
            this.btnDemirbasAta.TabIndex = 19;
            this.btnDemirbasAta.Text = "Odaya Demirbaş Ata";
            this.btnDemirbasAta.UseVisualStyleBackColor = false;
            this.btnDemirbasAta.Click += new System.EventHandler(this.btnDemirbasAta_Click);
            // 
            // FrmStokGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(974, 641);
            this.Controls.Add(this.btnDemirbasAta);
            this.Controls.Add(this.btnDemirbasEkle);
            this.Controls.Add(this.groupDemirbasAra);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dGVStokDemirbaslar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmStokGoruntule";
            this.Load += new System.EventHandler(this.FrmStokGoruntule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVStokDemirbaslar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupDemirbasAra.ResumeLayout(false);
            this.groupDemirbasAra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdeteGoreAra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dGVStokDemirbaslar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupDemirbasAra;
        private System.Windows.Forms.NumericUpDown numAdeteGoreAra;
        private System.Windows.Forms.DateTimePicker dateAlimTarihineGoreAra;
        private System.Windows.Forms.ComboBox cmbGoreAra;
        private System.Windows.Forms.RadioButton radioAdeteGoreAra;
        private System.Windows.Forms.RadioButton radioAdaGoreAra;
        private System.Windows.Forms.RadioButton radioTariheGoreAra;
        private System.Windows.Forms.RadioButton radioTureGoreAra;
        private System.Windows.Forms.RadioButton radioFiyataGoreAra;
        private System.Windows.Forms.Button btnDemirbasEkle;
        private System.Windows.Forms.Button btnDemirbasAta;
        private System.Windows.Forms.Button btnDemirbasAra;
    }
}