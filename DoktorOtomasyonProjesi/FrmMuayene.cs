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
    public partial class FrmMuayene : Form
    {
        public string _idh;
        public string _idd;
        public string _idm;
        public FrmMuayene(string idh)
        {
            InitializeComponent();
            _idh = idh;
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void btncikis_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FrmMuayene_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from tbl_hasta where Hasta_id = '" + _idh + "'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                var age = (DateTime.Today - DateTime.Parse(dr[3].ToString()));
                txthid.Text = dr[0].ToString();
                txthad.Text = dr[1].ToString();
                txthsoyad.Text = dr[2].ToString();
                txthyas.Text = ((int)(age.TotalDays / 365)).ToString();
                txthcinsiyet.Text = dr[4].ToString();
                txthkan.Text = dr[5].ToString();
                txthtc.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();

            btnRaporYaz.Enabled = false;
            btnReceteYaz.Enabled = false;
            btnTahlilIste.Enabled = false;
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            _idd = AppUser.Doktor_id.ToString();
            SqlCommand komut = new SqlCommand("Insert Into tbl_muayene (Muayene_tani, Muayene_sikayet, Hasta_id, Doktor_id) values (@d1,@d2,@d3,@d4)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", rcthtani.Text);
            komut.Parameters.AddWithValue("@d2", rcthsikayet.Text);
            komut.Parameters.AddWithValue("@d3", txthid.Text);
            komut.Parameters.AddWithValue("@d4", _idd);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            SqlCommand komut2 = new SqlCommand("Select top(1) Muayene_tani, Muayene_sikayet, Muayene_id from tbl_muayene inner join  tbl_doktor on tbl_doktor.Doktor_id = tbl_muayene.Doktor_id where tbl_muayene.Doktor_id = ' " + _idd + " ' order by tbl_muayene.Muayene_id desc", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                rcthtani.Text = dr2[0].ToString();
                rcthsikayet.Text = dr2[1].ToString();
                _idm = dr2[2].ToString();
            }
            bgl.baglanti().Close();

            btnRaporYaz.Enabled = true;
            btnReceteYaz.Enabled = true;
            btnTahlilIste.Enabled = true;
        }

        private void btnReceteYaz_Click(object sender, EventArgs e)
        {
            FrmRecete fr = new FrmRecete(txthid.Text);
            fr.Show();
        }

        private void btnTahlilIste_Click(object sender, EventArgs e)
        {
            FrmTahlil fr = new FrmTahlil(txthid.Text);
            fr.Show();
        }

        private void btnRaporYaz_Click(object sender, EventArgs e)
        {
            FrmRapor fr = new FrmRapor(txthid.Text, _idm);
            fr.Show();
        }
    }
}
