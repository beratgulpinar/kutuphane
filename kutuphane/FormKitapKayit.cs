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

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BttnKaydet_Click(object sender, EventArgs e)
        {
            
        }

        private void BttnKaydet_Click_1(object sender, EventArgs e)
        {

            sqlConn.Open();

            SqlCommand UyeKayitKomutu = new SqlCommand("KitapKayitPro", sqlConn);
            UyeKayitKomutu.CommandType = CommandType.StoredProcedure;

            SqlParameter KitapNo = new SqlParameter("@KitapNo", SqlDbType.Int);
            KitapNo.Direction = ParameterDirection.Input;
            KitapNo.Value = txtKitapNo.Text;
            UyeKayitKomutu.Parameters.Add(KitapNo);

            SqlParameter KitapAdi = new SqlParameter("@KitapAdi", SqlDbType.NVarChar, 50);
            KitapAdi.Direction = ParameterDirection.Input;
            KitapAdi.Value = txtKitapAdi.Text;
            UyeKayitKomutu.Parameters.Add(KitapAdi);

            SqlParameter KitapTuru = new SqlParameter("@KitapTuru", SqlDbType.NVarChar, 50);
            KitapTuru.Direction = ParameterDirection.Input;
            KitapTuru.Value = txtKitapTuru.Text;
            UyeKayitKomutu.Parameters.Add(KitapTuru);

            SqlParameter BasimTarihi = new SqlParameter("@BasimTarihi", SqlDbType.Date);
            BasimTarihi.Direction = ParameterDirection.Input;
            BasimTarihi.Value = txtBasimTarih.Text;
            UyeKayitKomutu.Parameters.Add(BasimTarihi);

            SqlParameter Yazar = new SqlParameter("@Yazar", SqlDbType.NVarChar, 50);
            Yazar.Direction = ParameterDirection.Input;
            Yazar.Value = txtYazar.Text;
            UyeKayitKomutu.Parameters.Add(Yazar);

            SqlParameter Sayfa = new SqlParameter("@Sayfa", SqlDbType.NVarChar, 50);
            Sayfa.Direction = ParameterDirection.Input;
            Sayfa.Value = txtSayfa.Text;
            UyeKayitKomutu.Parameters.Add(Sayfa);

            SqlParameter YayinEvi = new SqlParameter("@YayinEvi", SqlDbType.NVarChar, 50);
            YayinEvi.Direction = ParameterDirection.Input;
            YayinEvi.Value = txtYayinEvi.Text;
            UyeKayitKomutu.Parameters.Add(YayinEvi);

            SqlParameter Stok = new SqlParameter("@Stok", SqlDbType.Int);
            Stok.Direction = ParameterDirection.Input;
            Stok.Value = txtStok.Text;
            UyeKayitKomutu.Parameters.Add(Stok);

            try
            {
                UyeKayitKomutu.ExecuteNonQuery();
                MessageBox.Show("Kitap Eklendi.");
            }
            catch
            {
                MessageBox.Show("Kitap Ekleme Başarısız. Bilgileri Kontrol Ediniz.");
            }

            sqlConn.Close();

            txtKitapNo.Clear();
            txtKitapAdi.Clear();
            txtKitapTuru.Clear();
            txtBasimTarih.Clear();
            txtYazar.Clear();
            txtSayfa.Clear();
            txtYayinEvi.Clear();
            txtStok.Clear();
        }

        private void BttnTemizle_Click(object sender, EventArgs e)
        {
            
        }
    }
}
