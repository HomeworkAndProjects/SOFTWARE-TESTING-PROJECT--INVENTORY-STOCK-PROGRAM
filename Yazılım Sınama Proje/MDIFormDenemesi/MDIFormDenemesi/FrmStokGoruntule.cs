using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIFormDenemesi
{
    public partial class FrmStokGoruntule : Form
    {
        public FrmStokGoruntule()
        {
            InitializeComponent();
            cmbGoreAra.Visible = true;
            dateAlimTarihineGoreAra.Visible = false;
            numAdeteGoreAra.Visible = false;
        }
        frmStokDemirbasKayit DemirbasEkle = new frmStokDemirbasKayit();
        frmDemirbasEkleme OdaDemirbaşAtama = new frmDemirbasEkleme();
        DemirbasTakipEntities1 db = new DemirbasTakipEntities1();
        tblDemirba secilenDemirbas = new tblDemirba();
        private void btnDemirbasAta_Click(object sender, EventArgs e)
        {
            OdaDemirbaşAtama.Show();
        }
        public int aramaTercihi=1;//
        // 1 ise ada göre sıralama
        // 2 ise türe göre sıralama
        // 3 ise fiyata göre sıralama
        // 4 ise alım tarihine göre
        // 5 ise adede göre
        private void radioAdaGoreAra_CheckedChanged(object sender, EventArgs e)
        {
            
            cmbGoreAra.Visible = true;
            aramaTercihi = 1;
            dateAlimTarihineGoreAra.Visible = false;
            numAdeteGoreAra.Visible = false;
        }

        private void radioTureGoreAra_CheckedChanged(object sender, EventArgs e)
        {
            cmbGoreAra.Visible = true;
            cmbGoreAra.Items.Clear();          
            dateAlimTarihineGoreAra.Visible = false;
            numAdeteGoreAra.Visible = false;
            var DemirbasTurleri = db.tblDemirbasTurus.ToList();
            aramaTercihi = 2;
            foreach (var item in DemirbasTurleri)
            {
                cmbGoreAra.Items.Add(item.demirbasTuruAdi);
            }
        }

        private void radioFiyataGoreAra_CheckedChanged(object sender, EventArgs e)
        {
            aramaTercihi = 3;
            cmbGoreAra.Visible = true;
            dateAlimTarihineGoreAra.Visible = false;
            numAdeteGoreAra.Visible = false;
            var FiyataGoreDemirbaslar = db.tblDemirbas.ToList();
            cmbGoreAra.Items.Clear();
            foreach (var item in FiyataGoreDemirbaslar)
            {
                cmbGoreAra.Items.Add(item.fiyat);
            }
        }

        private void radioTariheGoreAra_CheckedChanged(object sender, EventArgs e)
        {
            aramaTercihi = 4;
            cmbGoreAra.Visible = false;
            dateAlimTarihineGoreAra.Visible = true;
            numAdeteGoreAra.Visible = false;
            //buralar buton clickte olacak
            //System.DateTime arananTarih = dateAlimTarihineGoreAra.Value;
            //var Veriler = db.tblDemirbas.Where(w => w.alimTarihi == arananTarih).ToList();
            //dGVStokDemirbaslar.DataSource = Veriler;
        }

        private void radioAdeteGoreAra_CheckedChanged(object sender, EventArgs e)
        {
            aramaTercihi = 5;
            cmbGoreAra.Visible = false;          
            dateAlimTarihineGoreAra.Visible = false;
            numAdeteGoreAra.Visible = true;
            var Demirbaslar = db.tblDemirbas.ToList();
            cmbGoreAra.Items.Clear();
            foreach (var item in Demirbaslar)
            {
                cmbGoreAra.Items.Add(item.demirbasAdi);
            }
        }
        
        private void btnDemirbasEkle_Click(object sender, EventArgs e)
        {
            DemirbasEkle.Show();
        }

        private void FrmStokGoruntule_Load(object sender, EventArgs e)
        {
            var Demirbaslar = db.tblDemirbas.ToList();
            cmbGoreAra.Items.Clear();
            foreach (var item in Demirbaslar)
            {
                cmbGoreAra.Items.Add(item.demirbasAdi);
            }
        }

        private void btnDemirbasAra_Click(object sender, EventArgs e)
        {
            if(aramaTercihi==1)//demirbaş adına göre 
            {
                string secilenAd = cmbGoreAra.Text;
                dGVStokDemirbaslar.DataSource = db.tblDemirbas.Where(w => w.demirbasAdi == secilenAd).ToList();
            }
             else if (aramaTercihi == 2)// türe göre ara
            {
                string secilenAd = cmbGoreAra.Text;
                var tempDerirbasTuru = db.tblDemirbasTurus.Where(w => w.demirbasTuruAdi == secilenAd).FirstOrDefault();
                dGVStokDemirbaslar.DataSource = db.tblDemirbas.Where(w => w.demirbasTuruID == tempDerirbasTuru.demirbasTuruID).ToList();
            }
            else if(aramaTercihi==3)// fiyata göre 
            {
                decimal secilenFiyat = Convert.ToDecimal(cmbGoreAra.Text);
                dGVStokDemirbaslar.DataSource = db.tblDemirbas.Where(w => w.fiyat == secilenFiyat).ToList();
            }
            else if (aramaTercihi == 4)//tarihe göre 
            {
                DateTime secilenTarih = dateAlimTarihineGoreAra.Value;
                dGVStokDemirbaslar.DataSource = db.tblDemirbas.Where(w => w.alimTarihi == secilenTarih).ToList();
            }
            else if (aramaTercihi == 5)
            {
                int secilenAdet = Convert.ToInt32(numAdeteGoreAra.Value);
                dGVStokDemirbaslar.DataSource = db.tblDemirbas.Where(w => w.adet == secilenAdet).ToList();
            }
                
            }
        }
    }
