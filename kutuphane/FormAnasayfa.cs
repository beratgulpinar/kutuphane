using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphane
{
    public partial class FormAnasayfa : Form
    {
        public FormAnasayfa()
        {
            InitializeComponent();
        }

        private void BttnUyeKayit_Click(object sender, EventArgs e)
        {
            FormUyeKayit objFormUyeKayit = new FormUyeKayit();
            this.Hide();
            objFormUyeKayit.Show();
        }

        private void BttnUyeListesi_Click(object sender, EventArgs e)
        {
            FormUyeListesi objFormUyeListesi = new FormUyeListesi();
            this.Hide();
            objFormUyeListesi.Show();
        }

        private void BttnKitapKayit_Click(object sender, EventArgs e)
        {
            FormKitapKayit objFormKitapKayit = new FormKitapKayit();
            this.Hide();
            objFormKitapKayit.Show();
        }

        private void BttnKitapListesi_Click(object sender, EventArgs e)
        {
            FormKitapListesi objFormKitapListesi = new FormKitapListesi();
            this.Hide();
            objFormKitapListesi.Show();
        }

        private void BttnKitapOdunc_Click(object sender, EventArgs e)
        {
            FormKitapOdunc objFormKitapOdunc = new FormKitapOdunc();
            this.Hide();
            objFormKitapOdunc.Show();
        }

        private void BttnKitapTeslim_Click(object sender, EventArgs e)
        {
            FormKitapTeslim objFormKitapTeslim = new FormKitapTeslim();
            this.Hide();
            objFormKitapTeslim.Show();
        }

        private void BttnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
