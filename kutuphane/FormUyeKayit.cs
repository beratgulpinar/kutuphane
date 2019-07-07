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

namespace kutuphane
{
    public partial class FormUyeKayit : Form
    {

        public FormUyeKayit()
        {
            InitializeComponent();
        }

        private void FormUyeKayit_Load(object sender, EventArgs e)
        {


        }

        SqlConnection sqlConn = new SqlConnection(@"Data Source=DESKTOP-2KBETUG\SQLEXPRESS;Initial Catalog=dbKutuphane;Integrated Security=True");

        private void BttnAnasayfa_Click(object sender, EventArgs e)
        {
            FormAnasayfa objFormAnasayfa = new FormAnasayfa();
            this.Hide();
            objFormAnasayfa.Show();
        }

        private void BttnKaydet_Click(object sender, EventArgs e)
        {
            sqlConn.Open();
            SqlCommand komut = new SqlCommand("insert into UyeKayit(TC,Ad,Soyad,Telefon,Email,Adres) values (@Tc,@Ad,@Soyad,@Telefon,@Email,@Adres)",sqlConn);
            komut.Parameters.AddWithValue("@TC", txtTcNo.Text);
            komut.Parameters.AddWithValue("@Ad", txtAd.Text);
            komut.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
            komut.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@Email", txtEmail.Text);
            komut.Parameters.AddWithValue("@Adres", txtAdres.Text);

            try
            {
                komut.ExecuteNonQuery();
                MessageBox.Show("Üye Eklendi.");

                txtTcNo.Clear();
                txtAd.Clear();
                txtSoyad.Clear();
                txtTelefon.Clear();
                txtEmail.Clear();
                txtAdres.Clear();
            }
            catch
            {
                MessageBox.Show("Üye Eklenemedi. Bilgileri Kontrol Ediniz.");
            }

            sqlConn.Close();
        }

        private void TxtTcNo_Enter(object sender, EventArgs e)
        {
            if (txtTcNo.Text == "--Tc No Giriniz--")
            {
                txtTcNo.Text = "";
                txtTcNo.ForeColor = Color.Black;
            }
        }

        private void TxtTcNo_Leave(object sender, EventArgs e)
        {
            if (txtTcNo.Text == "")
            {
                txtTcNo.Text = "--Tc No Giriniz--";
                txtTcNo.ForeColor = Color.DimGray;
            }
        }

        private void TxtAd_Enter(object sender, EventArgs e)
        {
            if (txtAd.Text == "--Ad Giriniz--")
            {
                txtAd.Text = "";
                txtAd.ForeColor = Color.Black;
            }
        }

        private void TxtAd_Leave(object sender, EventArgs e)
        {
            if (txtAd.Text == "")
            {
                txtAd.Text = "--Ad Giriniz--";
                txtAd.ForeColor = Color.DimGray;
            }
        }

        private void TxtSoyad_Enter(object sender, EventArgs e)
        {
            if (txtSoyad.Text == "--Soyad Giriniz--")
            {
                txtSoyad.Text = "";
                txtSoyad.ForeColor = Color.Black;
            }
        }

        private void TxtSoyad_Leave(object sender, EventArgs e)
        {
            if (txtSoyad.Text == "")
            {
                txtSoyad.Text = "--Soyad Giriniz--";
                txtSoyad.ForeColor = Color.DimGray;
            }
        }

        private void TxtTelefon_Enter(object sender, EventArgs e)
        {
            if (txtTelefon.Text == "--Telefon Giriniz--")
            {
                txtTelefon.Text = "";
                txtTelefon.ForeColor = Color.Black;
            }
        }

        private void TxtTelefon_Leave(object sender, EventArgs e)
        {
            if (txtTelefon.Text == "")
            {
                txtTelefon.Text = "--Telefon Giriniz--";
                txtTelefon.ForeColor = Color.DimGray;
            }
        }

        private void TxtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "--E-mail Giriniz--")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "--E-mail Giriniz--";
                txtEmail.ForeColor = Color.DimGray;
            }
        }

        private void TxtAdres_Enter(object sender, EventArgs e)
        {
            if (txtAdres.Text == "--Adres Giriniz--")
            {
                txtAdres.Text = "";
                txtAdres.ForeColor = Color.Black;
            }
        }

        private void TxtAdres_Leave(object sender, EventArgs e)
        {
            if (txtAdres.Text == "")
            {
                txtAdres.Text = "--Adres Giriniz--";
                txtAdres.ForeColor = Color.DimGray;
            }
        }
    }
}
