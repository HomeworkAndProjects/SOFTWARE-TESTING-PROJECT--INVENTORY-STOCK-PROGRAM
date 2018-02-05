using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace MDIFormDenemesi
{
    public partial class FrmOdaArama : Form
    {
        public FrmOdaArama()
        {
            InitializeComponent();
        }
       
        
        DemirbasTakipEntities1 db = new DemirbasTakipEntities1();
        tblFakulte secilenFakulte;
        tblDepartman secilenDepartman;
        tblOdaDemirba secilenOda;
        frmDemirbasEkleme DemirbasAtama = new frmDemirbasEkleme();
        
        private void FrmOdaArama_Load(object sender, EventArgs e)
        {
            var Fakulteler = db.tblFakultes.ToList();
            cmbDepartmanAdi.Enabled = false;
            cmbGoreAra.Enabled = false;
            cmbGoreAra.Items.Clear();
            foreach (var item in Fakulteler)
            {
                if (item.fakulteAdi != null)
                {
                    cmbFakulteAdi.Items.Add(item.fakulteAdi);
                }
            }
        }

        private void cmbFakulteAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenFakulteAdi = cmbFakulteAdi.Text;
            secilenFakulte = db.tblFakultes.Where(w => w.fakulteAdi == secilenFakulteAdi).FirstOrDefault();
            var departmanlar = db.tblDepartmen.Where(w => w.fakulteID == secilenFakulte.fakulteID).ToList();
            foreach (var item in departmanlar)
            {
                if (item.departmanAdi != null)
                {
                    cmbDepartmanAdi.Items.Add(item.departmanAdi);
                }
            }
            cmbDepartmanAdi.Enabled = true;
        }

        private void cmbDepartmanAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenDepartmanAdi = cmbDepartmanAdi.Text;
            secilenDepartman = db.tblDepartmen.Where(w => w.departmanAdi == secilenDepartmanAdi).FirstOrDefault();
            var odalar = db.tblOdas.Where(w => w.departmanID == secilenDepartman.departmanID).ToList();
            cmbGoreAra.Items.Clear();
            foreach (var item in odalar)
            {
                if (item.odaID != null)
                {
                    cmbGoreAra.Items.Add(item.odaID);
                }
            }
            cmbGoreAra.Enabled = true;
        }

        private void btnOdaArama_Click(object sender, EventArgs e)
        {
            int secilenOdaNumarasi = Convert.ToInt32(cmbGoreAra.Text);
            secilenOda = db.tblOdaDemirbas.Where(w => w.odaID == secilenOdaNumarasi).FirstOrDefault();


            
            if (secilenOda.personelID != null)
            {
                dGVOdaDemirbas.DataSource = "";
                tblPersonel tempPersonel = db.tblPersonels.Where(w => w.personelID == secilenOda.personelID).FirstOrDefault();
                lblPersonelAdiGoruntule.Text = tempPersonel.personelAdi;
                lblPersonelSoyadiGoruntule.Text = tempPersonel.personelSoyadi;
                lblPersonelNoGoruntule.Text = tempPersonel.personelID.ToString();
                dGVOdaDemirbas.DataSource = db.tblOdaDemirbas.ToList();
                var personeller = db.tblPersonels.ToList();
                foreach (var item in personeller)
                {
                    if (item.personelAdi != null)
                    {
                        cmbPersonelAta.Items.Add(item.personelAdi);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen Odaya Personel Ataması Yapınız!");
            }
        }

        private void btnDemirbasAta_Click(object sender, EventArgs e)
        {
            DemirbasAtama.Show();
        }

        

        private void btnPersonelAta_Click(object sender, EventArgs e)
        {
            string secilenPersonelAdi = cmbPersonelAta.Text;
            tblPersonel secilenPersonel = db.tblPersonels.Where(w => w.personelAdi == secilenPersonelAdi).FirstOrDefault();
            secilenOda.personelID = secilenPersonel.personelID;
            db.SaveChanges();
            MessageBox.Show("Personel Ataması Gerçekleştirildi!");
        }

        private void btnDokumanlastir_Click(object sender, EventArgs e)
        {
            string cikti = "",demirbasKodu="";
            var demirbaslar = db.tblOdaDemirbas.Where(w => w.odaDemirbasAtamaID == secilenOda.odaDemirbasAtamaID).ToList();
            int siraNumarasi = 1;
            tblDemirba tempDemirbas;
            foreach (var item in demirbaslar)
            {
                demirbasKodu += secilenFakulte.fakulteID + "." + secilenDepartman.departmanID + "." + item.demirbasID;
                cikti += "   " + siraNumarasi + "    " + demirbasKodu + "    "  + item.adet + Environment.NewLine;                  
            }

            try
            {
                iTextSharp.text.Document raporum = new iTextSharp.text.Document();
                // PDF oluşturması ve konumun belirlenmesi
                PdfWriter.GetInstance(raporum, new FileStream("C:\\Users\\DELL\\Desktop\\Yazılım Sınama Proje\\Proje\\DemirbaşTakip\\EntityFrameworkDeneme\\V5-MDI\\MDIFormDenemesi\\Dokumanlar\\Raporum.pdf", FileMode.Create));
                if (raporum.IsOpen() == false)
                {
                    raporum.Open();
                    raporum.Add(new Paragraph(cikti));
                    raporum.Close();
                    MessageBox.Show("Döküman başarı ile oluşturuldu");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("raporum pdf dosyası kapatılmadan kayıt yapılamaz!");
            }
        }
    }
}
