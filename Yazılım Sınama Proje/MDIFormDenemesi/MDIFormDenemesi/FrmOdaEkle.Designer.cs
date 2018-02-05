namespace MDIFormDenemesi
{
    partial class FrmOdaEkle
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
            this.btnOdaEkle = new System.Windows.Forms.Button();
            this.txtOdaAdi = new System.Windows.Forms.TextBox();
            this.lblOdaEkle = new System.Windows.Forms.Label();
            this.lblDepartmanAdi = new System.Windows.Forms.Label();
            this.cmbDepartmanlar = new System.Windows.Forms.ComboBox();
            this.cmbFakulteler = new System.Windows.Forms.ComboBox();
            this.lblFakulteAdi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOdaEkle
            // 
            this.btnOdaEkle.BackColor = System.Drawing.Color.PaleGreen;
            this.btnOdaEkle.Location = new System.Drawing.Point(320, 202);
            this.btnOdaEkle.Name = "btnOdaEkle";
            this.btnOdaEkle.Size = new System.Drawing.Size(118, 47);
            this.btnOdaEkle.TabIndex = 0;
            this.btnOdaEkle.Text = "Oda Ekle";
            this.btnOdaEkle.UseVisualStyleBackColor = false;
            this.btnOdaEkle.Click += new System.EventHandler(this.btnOdaEkle_Click);
            // 
            // txtOdaAdi
            // 
            this.txtOdaAdi.Location = new System.Drawing.Point(282, 157);
            this.txtOdaAdi.MaxLength = 10;
            this.txtOdaAdi.Name = "txtOdaAdi";
            this.txtOdaAdi.Size = new System.Drawing.Size(156, 20);
            this.txtOdaAdi.TabIndex = 1;
            // 
            // lblOdaEkle
            // 
            this.lblOdaEkle.AutoSize = true;
            this.lblOdaEkle.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdaEkle.Location = new System.Drawing.Point(67, 149);
            this.lblOdaEkle.Name = "lblOdaEkle";
            this.lblOdaEkle.Size = new System.Drawing.Size(89, 28);
            this.lblOdaEkle.TabIndex = 2;
            this.lblOdaEkle.Text = "Oda Adı";
            // 
            // lblDepartmanAdi
            // 
            this.lblDepartmanAdi.AutoSize = true;
            this.lblDepartmanAdi.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDepartmanAdi.Location = new System.Drawing.Point(67, 104);
            this.lblDepartmanAdi.Name = "lblDepartmanAdi";
            this.lblDepartmanAdi.Size = new System.Drawing.Size(161, 28);
            this.lblDepartmanAdi.TabIndex = 3;
            this.lblDepartmanAdi.Text = "Departman Adı";
            // 
            // cmbDepartmanlar
            // 
            this.cmbDepartmanlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartmanlar.FormattingEnabled = true;
            this.cmbDepartmanlar.Location = new System.Drawing.Point(282, 112);
            this.cmbDepartmanlar.Name = "cmbDepartmanlar";
            this.cmbDepartmanlar.Size = new System.Drawing.Size(156, 21);
            this.cmbDepartmanlar.TabIndex = 4;
            // 
            // cmbFakulteler
            // 
            this.cmbFakulteler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFakulteler.FormattingEnabled = true;
            this.cmbFakulteler.Location = new System.Drawing.Point(282, 72);
            this.cmbFakulteler.Name = "cmbFakulteler";
            this.cmbFakulteler.Size = new System.Drawing.Size(156, 21);
            this.cmbFakulteler.TabIndex = 6;
            this.cmbFakulteler.SelectedIndexChanged += new System.EventHandler(this.cmbFakulteler_SelectedIndexChanged);
            // 
            // lblFakulteAdi
            // 
            this.lblFakulteAdi.AutoSize = true;
            this.lblFakulteAdi.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFakulteAdi.Location = new System.Drawing.Point(67, 64);
            this.lblFakulteAdi.Name = "lblFakulteAdi";
            this.lblFakulteAdi.Size = new System.Drawing.Size(119, 28);
            this.lblFakulteAdi.TabIndex = 5;
            this.lblFakulteAdi.Text = "Fakülte Adı";
            // 
            // FrmOdaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(516, 284);
            this.Controls.Add(this.cmbFakulteler);
            this.Controls.Add(this.lblFakulteAdi);
            this.Controls.Add(this.cmbDepartmanlar);
            this.Controls.Add(this.lblDepartmanAdi);
            this.Controls.Add(this.lblOdaEkle);
            this.Controls.Add(this.txtOdaAdi);
            this.Controls.Add(this.btnOdaEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOdaEkle";
            this.Text = "FrmOdaEkle";
            this.Load += new System.EventHandler(this.FrmOdaEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdaEkle;
        private System.Windows.Forms.TextBox txtOdaAdi;
        private System.Windows.Forms.Label lblOdaEkle;
        private System.Windows.Forms.Label lblDepartmanAdi;
        private System.Windows.Forms.ComboBox cmbDepartmanlar;
        private System.Windows.Forms.ComboBox cmbFakulteler;
        private System.Windows.Forms.Label lblFakulteAdi;
    }
}