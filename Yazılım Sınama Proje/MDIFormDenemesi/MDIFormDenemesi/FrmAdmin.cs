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
    public partial class FrmAdminPaneli : Form
    {
        
        public FrmAdminPaneli()
        {
            InitializeComponent();
            StokGoruntule.MdiParent = this;
            StokDemirbasKaydi.MdiParent = this;
            PersonelGoruntule.MdiParent = this;
            PersonelArama.MdiParent = this;
            OdaSorumlusuAta.MdiParent = this;
            OdaGoruntule.MdiParent = this;
            OdaDemirbasAtama.MdiParent = this;
            OdaArama.MdiParent = this;
           
        }
        FrmStokGoruntule StokGoruntule = new FrmStokGoruntule();
        frmStokDemirbasKayit StokDemirbasKaydi = new frmStokDemirbasKayit();
        frmDemirbasAtaDokumAl PersonelGoruntule = new frmDemirbasAtaDokumAl();//oluşturma esnasından sonra form ismi değiştirilemedi
        frmPersonelArama PersonelArama = new frmPersonelArama();
        FrmOdaSorumlusuAta OdaSorumlusuAta = new FrmOdaSorumlusuAta();
        frmOdaGoruntule OdaGoruntule = new frmOdaGoruntule();
        frmDemirbasEkleme OdaDemirbasAtama = new frmDemirbasEkleme();
        FrmOdaArama OdaArama = new FrmOdaArama();
        FrmOdaEkle OdaEKle = new FrmOdaEkle();
        
           
        private void stokGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StokGoruntule.Show();
            StokDemirbasKaydi.Hide();
            PersonelGoruntule.Hide();
            PersonelArama.Hide();
            OdaSorumlusuAta.Hide();
            OdaGoruntule.Hide();
            OdaDemirbasAtama.Hide();
            OdaArama.Hide();
            OdaEKle.Hide();
            
        }

        private void stoğaDemirbaşEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StokGoruntule.Hide();
            StokDemirbasKaydi.Show();
            PersonelGoruntule.Hide();
            PersonelArama.Hide();
            OdaSorumlusuAta.Hide();
            OdaGoruntule.Hide();
            OdaDemirbasAtama.Hide();
            OdaArama.Hide();
            OdaEKle.Hide();
            
        }

        private void personelGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StokGoruntule.Hide();
            StokDemirbasKaydi.Hide();
            PersonelGoruntule.Hide();
            PersonelArama.Show();
            OdaSorumlusuAta.Hide();
            OdaGoruntule.Hide();
            OdaDemirbasAtama.Hide();
            OdaArama.Hide();
            OdaEKle.Hide();
            
        }

        private void personelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StokGoruntule.Hide();
            StokDemirbasKaydi.Hide();
            PersonelGoruntule.Hide();
            PersonelArama.Hide();
            OdaSorumlusuAta.Hide();
            OdaGoruntule.Hide();
            OdaDemirbasAtama.Hide();
            OdaArama.Hide();
            OdaEKle.Hide();
            
        }

        private void odaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StokGoruntule.Hide();
            StokDemirbasKaydi.Hide();
            PersonelGoruntule.Hide();
            PersonelArama.Hide();
            OdaSorumlusuAta.Hide();
            OdaGoruntule.Hide();
            OdaDemirbasAtama.Hide();
            OdaArama.Hide();
            OdaEKle.Show();
           
        }

        private void odaGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StokGoruntule.Hide();
            StokDemirbasKaydi.Hide();
            PersonelGoruntule.Hide();
            PersonelArama.Hide();
            OdaSorumlusuAta.Hide();
            OdaGoruntule.Hide();
            OdaDemirbasAtama.Hide();
            OdaArama.Show();
            OdaEKle.Hide();
           
        }

        private void odayaDemirbaşAtaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StokGoruntule.Hide();
            StokDemirbasKaydi.Hide();
            PersonelGoruntule.Hide();
            PersonelArama.Hide();
            OdaSorumlusuAta.Hide();
            OdaGoruntule.Hide();
            OdaDemirbasAtama.Show();
            OdaArama.Hide();
            OdaEKle.Hide();
            
        }

        
    }
}
