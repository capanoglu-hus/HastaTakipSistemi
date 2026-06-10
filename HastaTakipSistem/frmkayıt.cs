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
    public partial class frmkayıt : Form
    {
        public frmkayıt()
        {
            InitializeComponent();
        }
        frmSqlBaglantısı bgl = new frmSqlBaglantısı();
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            /*
             create procedure [dbo].[kayitOl]
                @kulAdi varchar(50),
                @sifre varchar(50)
                as 
                begin 
                insert into tbl_Login(kulAdi,sifre) values(@kulAdi,@sifre)
                end 
             */
            if (txtKulAdi.Text != "" && txtSifre.Text != "")
            {
                SqlCommand kayit = new SqlCommand("kayitOl", bgl.baglan());
                kayit.CommandType = CommandType.StoredProcedure;
                kayit.Parameters.AddWithValue("kulAdi", txtKulAdi.Text);
                kayit.Parameters.AddWithValue("sifre", txtSifre.Text);
                kayit.ExecuteNonQuery();
                MessageBox.Show("kayıt başarılı", "kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("lütfen Tüm alanları doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
