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

        SqlConnection sqlConn = new SqlConnection(@"Data Source=DESKTOP-2KBETUG\SQLEXPRESS;Initial Catalog=dbKutuphane;Integrated Security=True");

        public void verilerigoster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, sqlConn);
            DataSet ds = new DataSet();
            da.Fill(ds);
        }

        private void BttnAnasayfa_Click(object sender, EventArgs e)
        {
            FormAnasayfa objFormAnasayfa = new FormAnasayfa();
            this.Hide();
            objFormAnasayfa.Show();
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

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
            }
            catch
            {
                MessageBox.Show("Üye Eklenemedi. Bilgileri Kontrol Ediniz.");
            }

            sqlConn.Close();

            txtTcNo.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            txtTelefon.Clear();
            txtEmail.Clear();
            txtAdres.Clear();
        }

        private void BttnTemizle_Click(object sender, EventArgs e)
        {
            
        }
    }
}
