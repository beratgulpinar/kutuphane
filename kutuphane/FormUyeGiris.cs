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
    public partial class FormUyeGiris : Form
    {
        public FormUyeGiris()
        {
            InitializeComponent();
        }

        SqlConnection sqlConn = new SqlConnection(@"Data Source=DESKTOP-2KBETUG\SQLEXPRESS;Initial Catalog=dbKutuphane;Integrated Security=True");

        private void BttnUyeGiris_Click(object sender, EventArgs e)
        {
            sqlConn.Open();

            string query = "Select * from UyeKayit Where Ad = '" + txtKullaniciAdi.Text.Trim() + "' and Tc = '" + txtSifre.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlConn);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                FormUyeKitapListesi objFormUyeKitapListesi = new FormUyeKitapListesi();
                this.Hide();
                objFormUyeKitapListesi.sifre = txtSifre.Text;
                objFormUyeKitapListesi.Show();
                
            }
            else
            {
                MessageBox.Show("Adını ve Şifreni Kontrol Et!");
            }

            sqlConn.Close();
        }

        private void BttnGeri_Click_1(object sender, EventArgs e)
        {
            FormGirisSecim objFormGirisSecim = new FormGirisSecim();
            this.Hide();
            objFormGirisSecim.Show();
        }
    }
}
