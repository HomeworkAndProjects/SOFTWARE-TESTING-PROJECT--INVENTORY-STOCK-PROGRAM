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
    public partial class frmDemirbasEkleme : Form
    {
        public frmDemirbasEkleme()
        {
            InitializeComponent();
        }
        tblFakulte secilenFakulte;
        tblDepartman secilenDepartman;
        tblOda secilenOda;
        tblDemirba secilenDemirbas;

        private void btnDemirbasEkle_Click(object sender, EventArgs e)
        {
            int atanacakDemirbasSayisi = Convert.ToInt32(numDemirbasSayisi.Value);
            if (atanacakDemirbasSayisi > secilenDemirbas.adet)
            {
                MessageBox.Show("Mevcut demirbaş adetinden fazla girdi isteği!Lütfen atanacak demirbaş adetini azaltınız");
            }
            else
            {
                tblOdaDemirba temp = new tblOdaDemirba();
                secilenDemirbas.adet -= atanacakDemirbasSayisi;
                temp.adet = atanacakDemirbasSayisi;
                temp.demirbasID = secilenDemirbas.demirbasID;
                temp.odaID = secilenOda.odaID;
                temp.personelID = 1;// odalara personel atanırken güncellenmeli 
                db.tblOdaDemirbas.Add(temp);
                db.tblDemirbas.Add(secilenDemirbas);
                db.SaveChanges();
                MessageBox.Show("Atama işlemi Başarılı!");
            }
        }
        DemirbasTakipEntities1 db = new DemirbasTakipEntities1();
        private void frmDemirbasEkleme_Load(object sender, EventArgs e)
        {
            cmbDemirbasAdi.Enabled = false;
            cmbDepartmanAdi.Enabled = false;
            cmbOdaAdi.Enabled = false;
            var Fakulteler = db.tblFakultes.ToList();
            cmbFakulteAdi.Items.Clear();
            foreach (var item in Fakulteler)
            {
                cmbFakulteAdi.Items.Add(item.fakulteAdi);
            }
            cmbDepartmanAdi.Enabled = true;
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

        private void cmbDepartmanAdı_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenDepartmanAdi = cmbDepartmanAdi.Text;
            secilenDepartman = db.tblDepartmen.Where(w => w.departmanAdi == secilenDepartmanAdi).FirstOrDefault();
            var odalar = db.tblOdas.Where(w => w.departmanID == secilenDepartman.departmanID);
            cmbOdaAdi.Items.Clear();
            foreach (var item in odalar)
            {
                if(item.odaAdi !=null)
                {
                    cmbOdaAdi.Items.Add(item.odaAdi);
                }
            }
            cmbOdaAdi.Enabled = true;
        }

        private void cmbOdaAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenOdaAdi = cmbOdaAdi.Text;
            secilenOda = db.tblOdas.Where(w => w.odaAdi == secilenOdaAdi).FirstOrDefault();
            var demirbaslar = db.tblDemirbas.ToList();
            cmbDemirbasAdi.Items.Clear();
            foreach (var item in demirbaslar)
            {
                cmbDemirbasAdi.Items.Add(item.demirbasAdi);
            }
            cmbDemirbasAdi.Enabled = true;
        }

        private void cmbDemirbasAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seciliDemirbasAdi =cmbDemirbasAdi.Text;
            secilenDemirbas = db.tblDemirbas.Where(w => w.demirbasAdi == seciliDemirbasAdi).FirstOrDefault();
        }
    }
}
