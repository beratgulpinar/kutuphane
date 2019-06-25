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
    public partial class FormUyeKitapListesi : Form
    {
        public FormUyeKitapListesi()
        {
            InitializeComponent();
        }

        SqlConnection sqlConn = new SqlConnection(@"Data Source=DESKTOP-2KBETUG\SQLEXPRESS;Initial Catalog=dbKutuphane;Integrated Security=True");

        public string sifre { get; set; }

        private void BttnKitaplariGoster_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dadapter = new SqlDataAdapter("select * from KitapKayit", sqlConn);
            DataTable dtable = new DataTable();
            dadapter.Fill(dtable);
            dataGridView1.DataSource = dtable;
        }

        private void BttnOduncGoster_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dadapter = new SqlDataAdapter("select * from KitapOdunc where KiralayanTc='"+ sifre.Trim() +"' ", sqlConn);
            DataTable dtable = new DataTable();
            dadapter.Fill(dtable);
            dataGridView1.DataSource = dtable;
        }
    }
}
