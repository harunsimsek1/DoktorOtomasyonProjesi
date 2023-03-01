using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DoktorOtomasyonProjesi
{
    //VERİTABINI DİĞER FORMLARDAN ÇAĞIRABİLECEĞİMİZ BİR SINIF TANIMLADIK
    class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            //BURADA VERİTABINIMIZIN UZANTISINI GİRDİK VE BAĞLANTIYI AÇTIK
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-F59JTTH\\SQLEXPRESS;Initial Catalog=DbDoctorOtamasyon;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
