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

        private void TxtKitapNo_Enter(object sender, EventArgs e)
        {
            if (txtKitapNo.Text=="--Kitap No Giriniz--")
            {
                txtKitapNo.Text = "";
                txtKitapNo.ForeColor = Color.Black;
            }
        }

        private void TxtKitapNo_Leave(object sender, EventArgs e)
        {
            if (txtKitapNo.Text == "")
            {
                txtKitapNo.Text = "--Kitap No Giriniz--";
                txtKitapNo.ForeColor = Color.DimGray;
            }
        }

        private void TxtKitapAdi_Enter(object sender, EventArgs e)
        {
            if (txtKitapAdi.Text == "--Kitap Adı Giriniz--")
            {
                txtKitapAdi.Text = "";
                txtKitapAdi.ForeColor = Color.Black;
            }
        }

        private void TxtKitapAdi_Leave(object sender, EventArgs e)
        {
            if (txtKitapAdi.Text == "")
            {
                txtKitapAdi.Text = "--Kitap Adı Giriniz--";
                txtKitapAdi.ForeColor = Color.DimGray;
            }
        }

        private void TxtKitapTuru_Enter(object sender, EventArgs e)
        {
            if (txtKitapTuru.Text == "--Kitap Türü Giriniz--")
            {
                txtKitapTuru.Text = "";
                txtKitapTuru.ForeColor = Color.Black;
            }
        }

        private void TxtKitapTuru_Leave(object sender, EventArgs e)
        {
            if (txtKitapTuru.Text == "")
            {
                txtKitapTuru.Text = "--Kitap Türü Giriniz--";
                txtKitapTuru.ForeColor = Color.DimGray;
            }
        }

        private void TxtBasimTarih_Enter(object sender, EventArgs e)
        {
            if (txtBasimTarih.Text == "--Basım Tarihi Giriniz--")
            {
                txtBasimTarih.Text = "";
                txtBasimTarih.ForeColor = Color.Black;
            }
        }

        private void TxtBasimTarih_Leave(object sender, EventArgs e)
        {
            if (txtBasimTarih.Text == "")
            {
                txtBasimTarih.Text = "--Basım Tarihi Giriniz--";
                txtBasimTarih.ForeColor = Color.DimGray;
            }
        }

        private void TxtYazar_Enter(object sender, EventArgs e)
        {
            if (txtYazar.Text == "--Yazar Giriniz--")
            {
                txtYazar.Text = "";
                txtYazar.ForeColor = Color.Black;
            }
        }

        private void TxtYazar_Leave(object sender, EventArgs e)
        {
            if (txtYazar.Text == "")
            {
                txtYazar.Text = "--Yazar Giriniz--";
                txtYazar.ForeColor = Color.DimGray;
            }
        }

        private void TxtSayfa_Enter(object sender, EventArgs e)
        {
            if (txtSayfa.Text == "--Sayfa Sayısı Giriniz--")
            {
                txtSayfa.Text = "";
                txtSayfa.ForeColor = Color.Black;
            }
        }

        private void TxtSayfa_Leave(object sender, EventArgs e)
        {
            if (txtSayfa.Text == "")
            {
                txtSayfa.Text = "--Sayfa Sayısı Giriniz--";
                txtSayfa.ForeColor = Color.DimGray;
            }
        }

        private void TxtYayinEvi_Enter(object sender, EventArgs e)
        {
            if (txtYayinEvi.Text == "--Yayın Evi Giriniz--")
            {
                txtYayinEvi.Text = "";
                txtYayinEvi.ForeColor = Color.Black;
            }
        }

        private void TxtYayinEvi_Leave(object sender, EventArgs e)
        {
            if (txtYayinEvi.Text == "")
            {
                txtYayinEvi.Text = "--Yayın Evi Giriniz--";
                txtYayinEvi.ForeColor = Color.DimGray;
            }
        }

        private void TxtStok_Enter(object sender, EventArgs e)
        {
            if (txtStok.Text == "--Stok Giriniz--")
            {
                txtStok.Text = "";
                txtStok.ForeColor = Color.Black;
            }
        }

        private void TxtStok_Leave(object sender, EventArgs e)
        {
            if (txtStok.Text == "")
            {
                txtStok.Text = "--Stok Giriniz--";
                txtStok.ForeColor = Color.DimGray;
            }
        }
    }
}
