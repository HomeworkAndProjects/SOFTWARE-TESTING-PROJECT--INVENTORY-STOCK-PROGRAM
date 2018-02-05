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
    public partial class frmStokDemirbasKayit : Form
    {
        public frmStokDemirbasKayit()
        {
            InitializeComponent();
        }
        DemirbasTakipEntities1 db = new DemirbasTakipEntities1();
        tblFakulte secilenFakulte;
        tblDepartman secilenDepartman;
        GirisKontrol GirdiKontrol = new GirisKontrol();
        private void frmStokDemirbasKayit_Load(object sender, EventArgs e)
        {          
            cmbDepartmanAdi.Enabled = false;
            var Fakulteler = db.tblFakultes.ToList();
            cmbFakulteAdi.Items.Clear();
            foreach (var item in Fakulteler)
            {
                cmbFakulteAdi.Items.Add(item.fakulteAdi);
            }
            cmbDepartmanAdi.Enabled = true;
            var demirbasTurleri = db.tblDemirbasTurus.ToList();
            foreach (var item in demirbasTurleri)
            {
                cmbDemirbasTuru.Items.Add(item.demirbasTuruAdi);
            }
        }

        private void cmbFakulteAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenFakulteAdi = cmbFakulteAdi.Text;
            secilenFakulte = db.tblFakultes.Where(w => w.fakulteAdi == secilenFakulteAdi).FirstOrDefault();
            var departmanlar = db.tblDepartmen.Where(w => w.fakulteID == secilenFakulte.fakulteID);
            cmbDepartmanAdi.Items.Clear();
            foreach (var item in departmanlar)
            {
                cmbDepartmanAdi.Items.Add(item.departmanAdi);
            }
            cmbDepartmanAdi.Enabled = true;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string eklenecekDemirbasAdi = "";
            string eklenecekDemirbasTuru = "";
            decimal eklenecekDemirbasFiyati = .2M;
            DateTime eklenecekDemirbasAlimTarihi;
            int eklenecekDemirbasAdeti;
            int eklenecekDemirbasTuruID;
            tblDemirbasTuru tempDemirbasTuru = new tblDemirbasTuru();
            if (GirdiKontrol.SadeceMetinAl(txtDemirbasAdi.Text))
            { eklenecekDemirbasAdi = GirdiKontrol.cikisMetni; }
            else
            { MessageBox.Show("Hatalı  Demirbaş Adı Girişi!"); }
            eklenecekDemirbasTuru = cmbDemirbasTuru.Text;
            tempDemirbasTuru = db.tblDemirbasTurus.Where(w => w.demirbasTuruAdi == eklenecekDemirbasTuru).FirstOrDefault(); 
                //tempDemirbasTuru nün ID sini kullanacağız
            
            
            
            string tam = "", ondalik = "";//fonksiyona yollamak için
            if (GirdiKontrol.SadeceSayiAl(txtFiyatTamKisim.Text))
            {
                tam = GirdiKontrol.cikisMetni;
                if (GirdiKontrol.SadeceSayiAl(txtFiyatOndalikKisim.Text))
                {
                    ondalik = GirdiKontrol.cikisMetni;
                    eklenecekDemirbasFiyati = GirdiKontrol.MetniDecimalYap(tam,ondalik);
                }
            }
            else
            {
                MessageBox.Show("Hatalı Fiyat Girişi");
            }
            eklenecekDemirbasAlimTarihi = dateDemirbasAlimTarihi.Value;
            eklenecekDemirbasAdeti = Convert.ToInt32(numAdetinYazilmasi.Value);
            tblDemirba eklenecekDemirbas = new tblDemirba();
            eklenecekDemirbas.demirbasAdi = eklenecekDemirbasAdi;
            eklenecekDemirbas.demirbasTuruID = tempDemirbasTuru.demirbasTuruID;
            eklenecekDemirbas.fiyat = eklenecekDemirbasFiyati;
            eklenecekDemirbas.alimTarihi = eklenecekDemirbasAlimTarihi;
            eklenecekDemirbas.adet = eklenecekDemirbasAdeti;
            eklenecekDemirbas.departmanID = 2;
            eklenecekDemirbas.fakulteID = 1;
            db.tblDemirbas.Add(eklenecekDemirbas);
            db.SaveChanges();
            MessageBox.Show("Demirbaş Ekleme İşlemi Başarılı!");
        }

        private void cmbDepartmanAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenDepartmanAdi = cmbDepartmanAdi.Text;
            secilenDepartman = db.tblDepartmen.Where(w => w.departmanAdi == secilenDepartmanAdi).FirstOrDefault();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
