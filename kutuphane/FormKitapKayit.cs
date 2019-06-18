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
    public partial class FormKitapKayit : Form
    {
        public FormKitapKayit()
        {
            InitializeComponent();
        }

        SqlConnection sqlConn = new SqlConnection(@"Data Source=DESKTOP-2KBETUG\SQLEXPRESS;Initial Catalog=dbKutuphane;Integrated Security=True");

        private void BttnAnasayfa_Click(object sender, EventArgs e)
        {
            FormAnasayfa objFormAnasayfa = new FormAnasayfa();
            this.Hide();
            objFormAnasayfa.Show();
        }

        private void BttnKaydet_Click_1(object sender, EventArgs e)
        {

            sqlConn.Open();
            SqlCommand komut = new SqlCommand("insert into KitapKayit(KitapNo,KitapAdi,KitapTuru,BasimTarihi,Yazar,Sayfa,YayinEvi,Stok) values (@KitapNo,@KitapAdi,@KitapTuru,@BasimTarihi,@Yazar,@Sayfa,@YayinEvi,@Stok)", sqlConn);
            komut.Parameters.AddWithValue("@KitapNo", txtKitapNo.Text);
            komut.Parameters.AddWithValue("@KitapAdi", txtKitapAdi.Text);
            komut.Parameters.AddWithValue("@KitapTuru", txtKitapTuru.Text);
            komut.Parameters.AddWithValue("@BasimTarihi", txtBasimTarih.Text);
            komut.Parameters.AddWithValue("@Yazar", txtYazar.Text);
            komut.Parameters.AddWithValue("@Sayfa", txtSayfa.Text);
            komut.Parameters.AddWithValue("@YayinEvi", txtYayinEvi.Text);
            komut.Parameters.AddWithValue("@Stok", txtStok.Text);


            try
            {
                komut.ExecuteNonQuery();
                MessageBox.Show("Kitap Eklendi.");

                txtKitapNo.Clear();
                txtKitapAdi.Clear();
                txtKitapTuru.Clear();
                txtBasimTarih.Clear();
                txtYazar.Clear();
                txtSayfa.Clear();
                txtYayinEvi.Clear();
                txtStok.Clear();
            }
            catch
            {
                MessageBox.Show("Kitap Ekleme Başarısız. Bilgileri Kontrol Ediniz.");
            }

            sqlConn.Close();

            
        }
    }
}
