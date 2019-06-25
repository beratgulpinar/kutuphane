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
    public partial class FormKitapOdunc : Form
    {
        public FormKitapOdunc()
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

        private void BttnAra_Click(object sender, EventArgs e)
        {
            sqlConn.Open();
            SqlCommand komut = new SqlCommand("select * from KitapKayit where KitapAdi like '%" + txtKitapAra.Text + "%'", sqlConn);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            sqlConn.Close();

        }

        private void BttnKaydet_Click(object sender, EventArgs e)
        {
            sqlConn.Open();
            SqlCommand komut = new SqlCommand("insert into KitapOdunc(KitapNo,KiralayanTc,KiralamaTarihi,TeslimTarihi) values(@KitapNo,@KiralayanTc,@KiralamaTarihi,@TeslimTarihi)",sqlConn);
            komut.Parameters.AddWithValue("@KitapNo", txtKitapNo.Text);
            komut.Parameters.AddWithValue("@KiralayanTc", txtKiralayanTcNo.Text);
            komut.Parameters.AddWithValue("@KiralamaTarihi", txtKiralamaTarihi.Text);
            komut.Parameters.AddWithValue("@TeslimTarihi", txtTeslimTarihi.Text);

            try
            {
                komut.ExecuteNonQuery();
                MessageBox.Show("Kitap Ödünç Verildi.");

                txtKitapNo.Clear();
                txtKiralayanTcNo.Clear();
                txtKiralamaTarihi.Clear();
                txtTeslimTarihi.Clear();
            }
            catch
            {
                MessageBox.Show("Kitap Ödünç Verilemedi. Bilgileri Kontrol Ediniz.");
            }

            sqlConn.Close();

        }

        private void FormKitapOdunc_Load(object sender, EventArgs e)
        {
            txtKiralamaTarihi.Text = DateTime.Now.ToShortDateString();
            txtTeslimTarihi.Text = Convert.ToString(DateTime.Today.AddDays(21));
        }

        private void TxtKitapNo_Enter(object sender, EventArgs e)
        {
            if (txtKitapNo.Text == "--Kitap No Giriniz--")
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

        private void TxtKiralayanTcNo_Enter(object sender, EventArgs e)
        {
            if (txtKiralayanTcNo.Text == "--Tc No Giriniz--")
            {
                txtKiralayanTcNo.Text = "";
                txtKiralayanTcNo.ForeColor = Color.Black;
            }
        }

        private void TxtKiralayanTcNo_Leave(object sender, EventArgs e)
        {
            if (txtKiralayanTcNo.Text == "")
            {
                txtKiralayanTcNo.Text = "--Tc No Giriniz--";
                txtKiralayanTcNo.ForeColor = Color.DimGray;
            }
        }

        private void TxtKitapAra_Enter(object sender, EventArgs e)
        {
            if (txtKitapAra.Text == "--Kitap Adı Giriniz--")
            {
                txtKitapAra.Text = "";
                txtKitapAra.ForeColor = Color.Black;
            }
        }

        private void TxtKitapAra_Leave(object sender, EventArgs e)
        {
            if (txtKitapAra.Text == "")
            {
                txtKitapAra.Text = "--Kitap Adı Giriniz--";
                txtKitapAra.ForeColor = Color.DimGray;
            }
        }
    }
}
