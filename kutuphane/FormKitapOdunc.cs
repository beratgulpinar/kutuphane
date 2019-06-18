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
            SqlCommand komut = new SqlCommand("insert into KitapOdunc(KitapNo,KiralayanTc,KiralamaTarihi,TeslimTarihi) values (@KitapNo,@KiralayanTc,@KiralamaTarihi,@TeslimTarihi)",sqlConn);
            komut.Parameters.AddWithValue("@KitapNo", txtKitapNo.Text);
            komut.Parameters.AddWithValue("@KiralayanTc", txtKiralayanTcNo.Text);
            komut.Parameters.AddWithValue("@KiralamaTarihi", txtKiralamaTarih.Text);
            komut.Parameters.AddWithValue("@TeslimTarihi", txtTeslimTarih.Text);
            
            try
            {
                komut.ExecuteNonQuery();
                MessageBox.Show("Kitap Ödünç Verildi.");

                txtKitapNo.Clear();
                txtKiralayanTcNo.Clear();
                txtKiralamaTarih.Clear();
                txtTeslimTarih.Clear();
            }
            catch
            {
                MessageBox.Show("Kitap Ödünç Verilemedi. Bilgileri Kontrol Ediniz.");
            }

            sqlConn.Close();

        }

        private void FormKitapOdunc_Load(object sender, EventArgs e)
        {
            txtKiralamaTarih.Text = DateTime.Now.ToShortDateString();
            txtTeslimTarih.Text = Convert.ToString(DateTime.Today.AddDays(21));
        }
    }
}
