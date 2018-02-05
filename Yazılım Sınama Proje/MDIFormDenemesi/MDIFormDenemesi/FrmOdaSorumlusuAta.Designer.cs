namespace MDIFormDenemesi
{
    partial class FrmOdaSorumlusuAta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOdaSorumlusuAta));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.comboOdaSeciniz = new System.Windows.Forms.ComboBox();
            this.comboSorumluSecin = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOdaSorumlusuKaydet = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(576, 73);
            this.panel2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(79, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(437, 45);
            this.label4.TabIndex = 12;
            this.label4.Text = "Oda Sorumlusu Atama";
            // 
            // comboOdaSeciniz
            // 
            this.comboOdaSeciniz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOdaSeciniz.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.comboOdaSeciniz.FormattingEnabled = true;
            this.comboOdaSeciniz.Location = new System.Drawing.Point(28, 55);
            this.comboOdaSeciniz.Name = "comboOdaSeciniz";
            this.comboOdaSeciniz.Size = new System.Drawing.Size(131, 31);
            this.comboOdaSeciniz.TabIndex = 11;
            // 
            // comboSorumluSecin
            // 
            this.comboSorumluSecin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSorumluSecin.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboSorumluSecin.FormattingEnabled = true;
            this.comboSorumluSecin.Location = new System.Drawing.Point(195, 55);
            this.comboSorumluSecin.Name = "comboSorumluSecin";
            this.comboSorumluSecin.Size = new System.Drawing.Size(137, 31);
            this.comboSorumluSecin.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(33, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Oda Seçiniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(191, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sorumlu Seçin";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.btnOdaSorumlusuKaydet);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboSorumluSecin);
            this.panel1.Controls.Add(this.comboOdaSeciniz);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 118);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnOdaSorumlusuKaydet
            // 
            this.btnOdaSorumlusuKaydet.BackColor = System.Drawing.Color.Transparent;
            this.btnOdaSorumlusuKaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOdaSorumlusuKaydet.BackgroundImage")));
            this.btnOdaSorumlusuKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOdaSorumlusuKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdaSorumlusuKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdaSorumlusuKaydet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOdaSorumlusuKaydet.Location = new System.Drawing.Point(391, 42);
            this.btnOdaSorumlusuKaydet.Name = "btnOdaSorumlusuKaydet";
            this.btnOdaSorumlusuKaydet.Size = new System.Drawing.Size(125, 44);
            this.btnOdaSorumlusuKaydet.TabIndex = 18;
            this.btnOdaSorumlusuKaydet.Text = "Kaydet";
            this.btnOdaSorumlusuKaydet.UseVisualStyleBackColor = false;
            // 
            // FrmOdaSorumlusuAta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 191);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOdaSorumlusuAta";
            this.Text = "frmAtaKaydet";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboOdaSeciniz;
        private System.Windows.Forms.ComboBox comboSorumluSecin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOdaSorumlusuKaydet;
    }
}