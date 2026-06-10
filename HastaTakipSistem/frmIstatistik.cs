using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaTakipSistem
{
    public partial class frmIstatistik : Form
    {
        public frmIstatistik()
        {
            InitializeComponent();
        }
        frmSqlBaglantısı bgl = new frmSqlBaglantısı();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmIstatistik_Load(object sender, EventArgs e)
        {
            toplamHasta();
            yasOrtalama();
            erkekHasta();
            kadınHasta();
            exHasta();
        }
        private void toplamHasta()
        {
            SqlCommand toplam = new SqlCommand("select COUNT(*) from tbl_HastaBilgi",bgl.baglan());
            SqlDataReader dr = toplam.ExecuteReader();
            while (dr.Read())
            {
                lblToplamHasta.Text = dr[0].ToString();
            }
        }

        private void yasOrtalama()
        {
            SqlCommand yasOrt = new SqlCommand("select AVG(hYas) from tbl_HastaBilgi", bgl.baglan());
            SqlDataReader dr = yasOrt.ExecuteReader();
            while (dr.Read())
            {
                lblYasOrt.Text = dr[0].ToString();
            }
        }
        private void erkekHasta()
        {
            SqlCommand erkekHst = new SqlCommand("select COUNT(*) from tbl_HastaBilgi where hCinsiyet ='Erkek'", bgl.baglan());
            SqlDataReader dr = erkekHst.ExecuteReader();
            while (dr.Read())
            {
                lblErkekHasta.Text = dr[0].ToString();
            }
        }

        private void kadınHasta()
        {
            SqlCommand kadınHst = new SqlCommand("select COUNT(*) from tbl_HastaBilgi where hCinsiyet ='Kadın'", bgl.baglan());
            SqlDataReader dr = kadınHst.ExecuteReader();
            while (dr.Read())
            {
                lblKadınhasta.Text = dr[0].ToString();
            }
        }

        private void exHasta()
        {
            SqlCommand exHasta = new SqlCommand("select COUNT(*) from tbl_HastaBilgi where hExMi= 1", bgl.baglan());
            SqlDataReader dr = exHasta.ExecuteReader();
            while (dr.Read())
            {
                lblExHasta.Text = dr[0].ToString();
            }
        }

    }
}
