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
    public partial class FormKitapListesi : Form
    {
        public FormKitapListesi()
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

        private void BttnKitaplariGoster_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dadapter = new SqlDataAdapter("select * from KitapKayit", sqlConn);
            DataTable dtable = new DataTable();
            dadapter.Fill(dtable);
            dataGridView1.DataSource = dtable;
        }

        private void BttnKitapSil_Click(object sender, EventArgs e)
        {
            sqlConn.Open();
            SqlCommand komut = new SqlCommand("delete from KitapKayit Where KitapNo=@KitapNo", sqlConn);
            komut.Parameters.AddWithValue("@KitapNo", txtKitapSil.Text);
            try
            {
                komut.ExecuteNonQuery();
                MessageBox.Show("Kitap Silindi.");
            }
            catch
            {
                MessageBox.Show("Kitap Silinemedi. Bilgileri Kontrol Ediniz.");
            }

            SqlDataAdapter dadapter = new SqlDataAdapter("select * from KitapKayit", sqlConn);
            DataTable dtable = new DataTable();
            dadapter.Fill(dtable);
            dataGridView1.DataSource = dtable;

            sqlConn.Close();
            txtKitapSil.Clear();
        }
    }
}
