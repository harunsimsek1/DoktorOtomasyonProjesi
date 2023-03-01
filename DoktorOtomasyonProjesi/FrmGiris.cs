using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace DoktorOtomasyonProjesi
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        //TANIMLANAN SQL ADRESİNİ ALTTAKİ YÖNTEMLE ÇAĞIRDIK
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //FORMU HAREKET ETTİRME KODLARI
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            //SİSTEME GİRİŞ YAPILACAK ID VE ŞİFRE BİLGİSİNİ DOĞRULUĞUNU KONTROL EDEN SORGU VE KOMUTLARI YAZDIK
            SqlCommand komut = new SqlCommand("Select * From tbl_doktor where Doktor_id=@p1 AND Doktor_sifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtid.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                bool success = int.TryParse(txtid.Text, out int doktor_id);
                if (success)
                {
                    AppUser.Doktor_id = doktor_id;
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı ID bilgisi girdiniz");
                    return;
                }
                FrmAnaEkran fr = new FrmAnaEkran(txtid.Text);
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre");
            }
            bgl.baglanti().Close();
        }
    }
}
