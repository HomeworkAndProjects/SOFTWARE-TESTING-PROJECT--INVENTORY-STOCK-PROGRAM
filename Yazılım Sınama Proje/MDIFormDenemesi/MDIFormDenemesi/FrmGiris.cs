using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
namespace MDIFormDenemesi
{
   
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

       
        FrmAdminPaneli AdminEkrani = new FrmAdminPaneli();
        frmYardim YardımEkrani = new frmYardim();
        FrmNormal NormalKullaniciEkrani = new FrmNormal();
        DemirbasTakipEntities1 db = new DemirbasTakipEntities1();
        private void btnLogin_Click(object sender, EventArgs e)
        {           
            GirisKontrol GirdiKontrol = new GirisKontrol();
            tblKullanici Kullanici = new tblKullanici();
            if (GirdiKontrol.SadeceMetinAl(txtUser.Text)&&(txtPass.Text!=""))
            {
                Kullanici.kullaniciAdi = GirdiKontrol.cikisMetni;//metin her fonksiyon çağrıldığında değişiyor             
                if (GirdiKontrol.SayiveyaMetinAl(txtPass.Text))
                {
                    Kullanici.kullaniciSifre = GirdiKontrol.cikisMetni;// şifreyi atadı 
                    var dbGelen = db.tblKullanicis.Where(w => w.kullaniciAdi == Kullanici.kullaniciAdi).FirstOrDefault();///sorgu
                    if (dbGelen != null)//kullanıcı varsa
                    {
                        dbGelen.kullaniciAdi = GirdiKontrol.bosluklariAt(dbGelen.kullaniciAdi);// sondaki boşlukları at
                        dbGelen.kullaniciSifre = GirdiKontrol.bosluklariAt(dbGelen.kullaniciSifre);

                        if (dbGelen.kullaniciSifre.ToString() == Kullanici.kullaniciSifre)// şifre doğruysa
                        {
                            if (dbGelen.yetki == false)// admin mi normal kullanıcu mı true:admin false:normal
                            {
                                NormalKullaniciEkrani.Show();
                                AdminEkrani.Hide();
                                this.Hide();
                            }
                            if (dbGelen.yetki == true)
                            {
                                AdminEkrani.Show();
                                NormalKullaniciEkrani.Hide();
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Yanlış Şifre Girdiniz!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Aranan Kullanıcı Bulunamadı!");
                    }
                }
                else
                { MessageBox.Show("Hatalı  Giriş!"); }
            }
            else
                 { MessageBox.Show("Hatalı  Giriş!");
                
            }
              
        }

        private void btnYardim_Click(object sender, EventArgs e)
        {
            YardımEkrani.Show();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            txtUser.Text = "";
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.Text = "";
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
