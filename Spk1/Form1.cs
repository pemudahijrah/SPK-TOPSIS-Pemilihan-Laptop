using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Spk1
{
    public partial class frmutama : Form
    {
        public frmutama()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnmulai_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMulai fm = new FrmMulai();
            fm.Show();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnbantuan_Click(object sender, EventArgs e)
        {
            Bantuan bn = new Bantuan();
            this.Hide();
            bn.Show();
        }

        private void btnabout_Click(object sender, EventArgs e)
        {
            tentang tt = new tentang();
            this.Hide();
            tt.Show();
        }
    }
}
