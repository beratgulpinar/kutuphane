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
    public partial class FormUyeListesi : Form
    {
        public FormUyeListesi()
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

        private void BttnUyeleriGoster_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dadapter = new SqlDataAdapter("select * from UyeKayit", sqlConn);
            DataTable dtable = new DataTable();
            dadapter.Fill(dtable);
            dataGridView1.DataSource = dtable;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BttnKitapSil_Click(object sender, EventArgs e)
        {
            sqlConn.Open();
            SqlCommand komut = new SqlCommand("delete from UyeKayit Where TC=@TC",sqlConn);
            komut.Parameters.AddWithValue("@TC",txtUyeSil.Text);
            try
            {
                komut.ExecuteNonQuery();
                MessageBox.Show("Üye Silindi.");
            }
            catch
            {
                MessageBox.Show("Üye Silinemedi. Bilgileri Kontrol Ediniz.");
            }

            SqlDataAdapter dadapter = new SqlDataAdapter("select * from UyeKayit", sqlConn);
            DataTable dtable = new DataTable();
            dadapter.Fill(dtable);
            dataGridView1.DataSource = dtable;

            sqlConn.Close();
            txtUyeSil.Clear();
        }

        private void TxtKitapSil_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
