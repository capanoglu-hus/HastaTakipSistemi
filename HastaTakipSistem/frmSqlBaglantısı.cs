

using System.Data.SqlClient;

namespace HastaTakipSistem
{
    internal class frmSqlBaglantısı
    {
        string adres = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=db_HastaneYonetim;Integrated Security=True;Encrypt=False;";
        public SqlConnection baglan()
        {
            SqlConnection baglanti = new SqlConnection(adres);
            baglanti.Open();
            return baglanti;
        }
    }
}
