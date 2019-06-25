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
    public partial class FormGirisSecim : Form
    {
        public FormGirisSecim()
        {
            InitializeComponent();
        }

        private void BttnAdmin_Click(object sender, EventArgs e)
        {
            FormAdminGiris objFormGiris = new FormAdminGiris();
            this.Hide();
            objFormGiris.Show();
        }

        private void BttnUye_Click(object sender, EventArgs e)
        {
            FormUyeGiris objFormUyeGiris = new FormUyeGiris();
            this.Hide();
            objFormUyeGiris.Show();
        }
    }
}
