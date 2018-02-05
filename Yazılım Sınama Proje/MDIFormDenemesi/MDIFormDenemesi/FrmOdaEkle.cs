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
    public partial class FrmOdaEkle : Form
    {
        public FrmOdaEkle()
        {
            InitializeComponent();
        }
        GirisKontrol GirdiKontrol = new GirisKontrol();
        DemirbasTakipEntities1 db = new DemirbasTakipEntities1();
        private void btnOdaEkle_Click(object sender, EventArgs e)
        {
            tblOda tempOda = new tblOda();
            if ((txtOdaAdi.Text == "") || (cmbDepartmanlar.Text == ""))
            {
                MessageBox.Show("Boş alan bırakamazsınız");
            }
            else if(GirdiKontrol.SayiveyaMetinAl(txtOdaAdi.Text))
            {
                tempOda.odaAdi = GirdiKontrol.cikisMetni;
                tblDepartman tempDepartman = new tblDepartman(); // odaya departman id si eklemek için 
                string departmanAdi = cmbDepartmanlar.Text;// departmanı bulup idsini eklemek için
                tempDepartman = db.tblDepartmen.Where(w => w.departmanAdi == departmanAdi).FirstOrDefault();
                tempOda.departmanID = tempDepartman.departmanID;// oda departman id yi atama
                // oda adı var mı sorgusu
                var Oda = db.tblOdas.Where(w => w.departmanID == tempDepartman.departmanID && w.odaAdi == tempOda.odaAdi).FirstOrDefault();
                if (Oda != null)
                {
                    MessageBox.Show("Belirtilen oda adı mevcut!Lütfen başka bir oda adı giriniz");
                }
                else
                {
                    db.tblOdas.Add(tempOda);
                    db.SaveChanges();
                    MessageBox.Show("Oda Başarıyla Eklendi!");
                }
                
            }
            else
            {
                MessageBox.Show("Hatalı Oda Gİrişi!");
            }
            
        }

        private void FrmOdaEkle_Load(object sender, EventArgs e)
        {
            
            var Fakulteler = db.tblFakultes.ToList();
            foreach (var item in Fakulteler)
            {
                cmbFakulteler.Items.Add(item.fakulteAdi);
            }
            cmbDepartmanlar.Enabled = false;
        }

        private void cmbFakulteler_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenFakulteAdi = cmbFakulteler.Text;
            tblFakulte secilenFakulte = db.tblFakultes.Where(w => w.fakulteAdi == secilenFakulteAdi).FirstOrDefault();
            var fakulteDepartmanlari = db.tblDepartmen.Where(w => w.fakulteID == secilenFakulte.fakulteID);
            cmbDepartmanlar.Items.Clear();
            foreach (var item in fakulteDepartmanlari)
            {
                cmbDepartmanlar.Items.Add(item.departmanAdi);
            }
            cmbDepartmanlar.Enabled = true;
        }
    }
}
