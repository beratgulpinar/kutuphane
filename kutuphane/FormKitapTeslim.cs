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
    public partial class FormKitapTeslim : Form
    {
        public FormKitapTeslim()
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

        private void BttnListele_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dadapter = new SqlDataAdapter("select * from KitapOdunc", sqlConn);
            DataTable dtable = new DataTable();
            dadapter.Fill(dtable);
            dataGridView1.DataSource = dtable;
        }

        private void BttnTeslim_Click(object sender, EventArgs e)
        {
            sqlConn.Open();
            SqlCommand komut = new SqlCommand("delete from KitapOdunc Where KitapNo=@KitapNo", sqlConn);
            komut.Parameters.AddWithValue("@KitapNo", txtKitapNo.Text);
            try
            {
                komut.ExecuteNonQuery();
                MessageBox.Show("Kitap Teslim Alındı.");

                txtKitapNo.Clear();
            }
            catch
            {
                MessageBox.Show("Kitap Teslim Alınamadı. Bilgileri Kontrol Ediniz.");
            }

            SqlDataAdapter dadapter = new SqlDataAdapter("select * from KitapOdunc", sqlConn);
            DataTable dtable = new DataTable();
            dadapter.Fill(dtable);
            dataGridView1.DataSource = dtable;

            sqlConn.Close();
        }
    }
}
