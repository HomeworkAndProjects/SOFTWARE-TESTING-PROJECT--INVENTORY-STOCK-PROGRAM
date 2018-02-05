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
    public partial class FrmNormal : Form
    {
        public FrmNormal()
        {
            InitializeComponent();
        }
        frmPersonelArama PersonelArama = new frmPersonelArama();
        frmDemirbasAtaDokumAl PersonelGoruntule = new frmDemirbasAtaDokumAl();//yanlış form ismi
        FrmOdaArama OdaArama = new FrmOdaArama();
        frmOdaGoruntule OdaGoruntule = new frmOdaGoruntule();
        FrmOdaSorumlusuAta OdaSorumlusuAta = new FrmOdaSorumlusuAta();
        frmDemirbasEkleme OdayaDemirbasEkleme = new frmDemirbasEkleme();
        private void personelGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelArama.Visible = true;
            PersonelGoruntule.Visible = false;
            OdaArama.Visible = false;
            OdaSorumlusuAta.Visible = false;
            OdayaDemirbasEkleme.Visible = false;
        }

        private void odaGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelArama.Visible = false;
            PersonelGoruntule.Visible = false;
            OdaArama.Visible = true;
            OdaSorumlusuAta.Visible = false;
            OdayaDemirbasEkleme.Visible = false;
        }

        private void odayaDemirbaşAtaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelArama.Visible = false;
            PersonelGoruntule.Visible = false;
            OdaArama.Visible = false;
            OdaSorumlusuAta.Visible = false;
            OdayaDemirbasEkleme.Visible = true;
        }
    }
}
