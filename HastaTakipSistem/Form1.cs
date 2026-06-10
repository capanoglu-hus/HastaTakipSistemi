using System;

using System.Data;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace HastaTakipSistem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        frmSqlBaglantısı bgl = new frmSqlBaglantısı();
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            frmkayıt fr = new frmkayıt();
            fr.Show();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if(txtKulAdi.Text != "" && txtSifre.Text != "")
            {
                SqlCommand giris = new SqlCommand("girisYap", bgl.baglan());
                giris.CommandType = CommandType.StoredProcedure;
                giris.Parameters.AddWithValue("kulAdi", txtKulAdi.Text);
                giris.Parameters.AddWithValue("sifre", txtSifre.Text);
                SqlDataReader dr = giris.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("giriş işlemi başarılı", "başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmAnasayfa fr = new frmAnasayfa();
                    this.Hide();
                    fr.Show();

                } else
                {
                    MessageBox.Show("giriş işlemi başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("lütfen kontrol et", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
