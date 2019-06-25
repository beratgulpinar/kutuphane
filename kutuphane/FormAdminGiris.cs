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

namespace kutuphane
{
    public partial class FormAdminGiris : Form
    {
        public FormAdminGiris()
        {
            InitializeComponent();
        }

        SqlConnection sqlConn = new SqlConnection(@"Data Source=DESKTOP-2KBETUG\SQLEXPRESS;Initial Catalog=dbKutuphane;Integrated Security=True");

        private void BttnGiris_Click(object sender, EventArgs e)
        {

            sqlConn.Open();

            string query = "Select * from Giris Where KullaniciAdi = '" + txtKullaniciAdi.Text.Trim() + "' and Sifre = '" + txtSifre.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlConn);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                FormAnasayfa objFormAnasayfa = new FormAnasayfa();
                this.Hide();
                objFormAnasayfa.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adını ve Şifreni Kontrol Et!");
            }

            sqlConn.Close();

        }

        private void BttnKayit_Click(object sender, EventArgs e)
        {
            sqlConn.Open();

            SqlCommand komut = new SqlCommand("insert into Giris(KullaniciAdi,Sifre) values (@KullaniciAdi,@Sifre)", sqlConn);
            komut.Parameters.AddWithValue("@KullaniciAdi", txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@Sifre", txtSifre.Text);

            try
            {
                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarılı. Giriş Yapabilirsiniz.");
            }
            catch
            {
                MessageBox.Show("Kayıt Başarısız. Bilgileri Kontrol Ediniz.");
            }

            sqlConn.Close();
        }

        private void BttnGeri_Click(object sender, EventArgs e)
        {
            FormGirisSecim objFormGirisSecim = new FormGirisSecim();
            this.Hide();
            objFormGirisSecim.Show();
        }
    }
}
