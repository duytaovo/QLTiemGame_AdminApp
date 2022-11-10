using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe
{
    public partial class fQuanLyMay : Form
    {
        public fQuanLyMay()
        {
            InitializeComponent();
        }

        private void fQuanLyMay_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void btn_BatMay_Click(object sender, EventArgs e)
        {
            fTableMay f = new fTableMay();
            f.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fAddTimeMember f = new fAddTimeMember();
            f.ShowDialog();
            this.Show();
        }
    }
}
