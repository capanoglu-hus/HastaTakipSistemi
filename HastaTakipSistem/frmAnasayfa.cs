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
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }
        frmSqlBaglantısı bgl = new frmSqlBaglantısı();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmAnasayfa_Load(object sender, EventArgs e)
        {
            Listele();
            durumDoldur();
            bolumDoldur();
        }

        private void Listele()
        {
            SqlCommand liste = new SqlCommand("listele", bgl.baglan());
            SqlDataAdapter da = new SqlDataAdapter(liste);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void durumDoldur()
        {
            SqlCommand durum = new SqlCommand("durumDoldur", bgl.baglan());
            SqlDataAdapter da = new SqlDataAdapter(durum);
            DataTable dt = new DataTable();
            da.Fill(dt);
            txtDurum.DataSource = dt;
            txtDurum.DisplayMember = "durumAd";
            txtDurum.ValueMember = "durumID";
        }

        private void bolumDoldur()
        {
            SqlCommand durum = new SqlCommand("bolumDoldur", bgl.baglan());
            SqlDataAdapter da = new SqlDataAdapter(durum);
            DataTable dt = new DataTable();
            da.Fill(dt);
            txtBolum.DataSource = dt;
            txtBolum.DisplayMember = "bolumAd";
            txtBolum.ValueMember = "bolumID";
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int degisken = dataGridView1.SelectedCells[0].RowIndex;
            txtID.Text = dataGridView1.Rows[degisken].Cells[0].Value.ToString();
            txtAD.Text = dataGridView1.Rows[degisken].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[degisken].Cells[2].Value.ToString();
            txtTC.Text = dataGridView1.Rows[degisken].Cells[3].Value.ToString();
            txtTelefon.Text = dataGridView1.Rows[degisken].Cells[4].Value.ToString();
            txtYas.Text = dataGridView1.Rows[degisken].Cells[5].Value.ToString();
            txtCinsiyet.Text = dataGridView1.Rows[degisken].Cells[6].Value.ToString();
            txtSikayet.Text = dataGridView1.Rows[degisken].Cells[7].Value.ToString();
            txtTarih.Text = dataGridView1.Rows[degisken].Cells[8].Value.ToString();
            txtDurum.SelectedValue = dataGridView1.Rows[degisken].Cells[9].Value.ToString();
            txtBolum.SelectedValue = dataGridView1.Rows[degisken].Cells[10].Value.ToString();
            lblEx.Text= dataGridView1.Rows[degisken].Cells[11].Value.ToString();


        }

        private void rbEvet_CheckedChanged(object sender, EventArgs e)
        {
            if(rbEvet.Checked == true)
            {
                lblEx.Text = "True";

            }
            else
            {
                lblEx.Text = "False";
            }
        }

        private void lblEx_TextChanged(object sender, EventArgs e)
        {
            if(lblEx.Text == "True")
            {
                rbEvet.Checked = true;
            }
            else
            {
                rbHayır.Checked = true;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAD.Text != "" && txtSoyad.Text != "" && txtTC.Text != "" && txtDurum.Text != "" && txtSikayet.Text != "" && txtTelefon.Text != "" && txtYas.Text != "" && txtCinsiyet.Text != "" && txtBolum.Text != "")
            {
                kaydet();
            }
            else
            {
                MessageBox.Show("Lütfen alanları doldurun ", "kayıt başarısız ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kaydet()
        {
            SqlCommand kaydet = new SqlCommand("kaydet", bgl.baglan());
            kaydet.CommandType = CommandType.StoredProcedure;
            kaydet.Parameters.AddWithValue("ad", txtAD.Text.ToString());
            kaydet.Parameters.AddWithValue("soyad", txtSoyad.Text.ToString());
            kaydet.Parameters.AddWithValue("tc", txtTC.Text.ToString());
            kaydet.Parameters.AddWithValue("tel", txtTelefon.Text.ToString());
            kaydet.Parameters.AddWithValue("yas", int.Parse(txtYas.Text.ToString()));
            kaydet.Parameters.AddWithValue("cins", txtCinsiyet.Text.ToString());
            kaydet.Parameters.AddWithValue("sikayet", txtSikayet.Text.ToString());
            kaydet.Parameters.AddWithValue("tarih", DateTime.Now);
            kaydet.Parameters.AddWithValue("durum", txtDurum.SelectedValue);
            kaydet.Parameters.AddWithValue("bolum", txtBolum.SelectedValue);
            if(lblEx.Text == "True")
            {
                kaydet.Parameters.AddWithValue("ex", 1);
            }
            else
            {
                kaydet.Parameters.AddWithValue("ex", 0);
            }
            kaydet.ExecuteNonQuery();
            MessageBox.Show("başarılı ", "kayıt başarılı ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Sil();
        }
        private void Sil()
        {
            DialogResult dr = MessageBox.Show($"{txtID.Text} numaralı kayıt silinecek onaylıyor musunuz ? ", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                SqlCommand sil = new SqlCommand("sil", bgl.baglan());
                sil.CommandType = CommandType.StoredProcedure;
                sil.Parameters.AddWithValue("id", int.Parse(txtID.Text));
                sil.ExecuteNonQuery();
                MessageBox.Show(" kayıt başarılıyla silindi ", "kayıt silindi ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Listele();
        }

        private void btnGuncelleme_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"{txtID.Text} numaralı kayıt güncellenecek onaylıyor musunuz ? ", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                guncelle();
            }
            Listele();
        }

        private void guncelle()
        {

            SqlCommand guncelle = new SqlCommand("guncelle", bgl.baglan());
            guncelle.CommandType = CommandType.StoredProcedure;
            guncelle.Parameters.AddWithValue("id", int.Parse(txtID.Text));
            guncelle.Parameters.AddWithValue("ad", txtAD.Text.ToString());
            guncelle.Parameters.AddWithValue("soyad", txtSoyad.Text.ToString());
            guncelle.Parameters.AddWithValue("tc", txtTC.Text.ToString());
            guncelle.Parameters.AddWithValue("tel", txtTelefon.Text.ToString());
            guncelle.Parameters.AddWithValue("yas", int.Parse(txtYas.Text.ToString()));
            guncelle.Parameters.AddWithValue("cins", txtCinsiyet.Text.ToString());
            guncelle.Parameters.AddWithValue("sikayet", txtSikayet.Text.ToString());
            guncelle.Parameters.AddWithValue("tarih", DateTime.Now);
            guncelle.Parameters.AddWithValue("durum", txtDurum.SelectedValue);
            guncelle.Parameters.AddWithValue("bolum", txtBolum.SelectedValue);
            if (lblEx.Text == "True")
            {
                guncelle.Parameters.AddWithValue("ex", 1);
            }
            else
            {
                guncelle.Parameters.AddWithValue("ex", 0);
            }
            guncelle.ExecuteNonQuery();
            MessageBox.Show("başarılı ", "güncelleme başarılı ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void temizle()
        {
            txtAD.Text = "";
            txtID.Text = "";
            txtSoyad.Text = "";
            txtTC.Text = "";
            txtTelefon.Text = "";
            txtYas.Text = "";
            txtCinsiyet.Text = "";
            txtBolum.Text = "";
            txtSikayet.Text = "";
            txtTarih.Text = "";
            txtDurum.Text = "";
            rbHayır.Checked = true;
            lblEx.Text = "False";

        }

        private void btnFormtemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnIstatistik_Click(object sender, EventArgs e)
        {
            frmIstatistik fr = new frmIstatistik();
            fr.Show();
        }
    }
}
