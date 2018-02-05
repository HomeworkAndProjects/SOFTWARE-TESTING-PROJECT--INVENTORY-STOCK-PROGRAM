using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace MDIFormDenemesi
{
    public partial class frmPersonelArama : Form
    {
        public frmPersonelArama()
        {
            InitializeComponent();
        }
        
        private void ara_Click(object sender, EventArgs e)
        {
            
        }

        private void frmPersonelArama_Shown(object sender, EventArgs e)
        {
           
        }

        private void txtAra_Click(object sender, EventArgs e)
        {
            (sender as TextBox).SelectAll();
        }
        
        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            
        }
        DemirbasTakipEntities1 db = new DemirbasTakipEntities1();
        private bool isradioIsimSelect = true;
        private void radioIsmeGoreAra_CheckedChanged(object sender, EventArgs e)
        {
            isradioIsimSelect = true;
            cmbGorePersonelAra.Items.Clear();
            cmbGorePersonelAra.Text = "";
            var PersonelListesi= db.tblPersonels.ToList();
           // cmbGorePersonelAra.Items.Clear();
            foreach (var item in PersonelListesi)
            {
                cmbGorePersonelAra.Items.Add(GirdiKontrol.bosluklariAt(item.personelAdi));
            }

        }

        private void radioNumarayaGoreAra_CheckedChanged(object sender, EventArgs e)
        {
            isradioIsimSelect = false;
            cmbGorePersonelAra.Items.Clear();
            cmbGorePersonelAra.Text = "";
            var PersonelListesi = db.tblPersonels.ToList();
           // cmbGorePersonelAra.Items.Clear();
            foreach (var item in PersonelListesi)
            {
                cmbGorePersonelAra.Items.Add(item.personelID);
            }
        }

        private void btnPersonelArama_Click(object sender, EventArgs e)
        {
            if (cmbGorePersonelAra.Text == "")
            {
                MessageBox.Show("Lütfen değer giriniz!");
            }
            else
            {
                tblPersonel tempPersonel = new tblPersonel();
                if (isradioIsimSelect)// isme göre arama seçili
                {
                    string aranacakVeri = cmbGorePersonelAra.Text;
                    tempPersonel = db.tblPersonels.Where(w => w.personelAdi == aranacakVeri).FirstOrDefault();
                    lblPersonelAdiGoruntule.Text = tempPersonel.personelAdi.ToString();
                    lblPersonelSoyadiGoruntule.Text = tempPersonel.personelSoyadi;
                    lblPersonelNoGoruntule.Text = tempPersonel.personelID.ToString();


                }
                else//numaraya göre arama seçili
                {
                    int aranacakVeri = Convert.ToInt32(cmbGorePersonelAra.Text);
                    tempPersonel = db.tblPersonels.Where(w => w.personelID == aranacakVeri).FirstOrDefault();
                    lblPersonelAdiGoruntule.Text = tempPersonel.personelAdi.ToString();
                    lblPersonelSoyadiGoruntule.Text = tempPersonel.personelSoyadi;
                    lblPersonelNoGoruntule.Text = tempPersonel.personelID.ToString();
                }

            }
        }
        GirisKontrol GirdiKontrol = new GirisKontrol();
        private void frmPersonelArama_Load(object sender, EventArgs e)
        {
            cmbGorePersonelAra.Items.Clear();
            var PersonelListesi = db.tblPersonels.ToList();
            //cmbGorePersonelAra.Items.Clear();
            foreach (var item in PersonelListesi)
            {              
                cmbGorePersonelAra.Items.Add(GirdiKontrol.bosluklariAt(item.personelAdi));
            }
        }
    }
}
