using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QuanLyTiemGame
{
    public partial class Add_foods_image : Form
    {
        public Add_foods_image()
        {
            InitializeComponent();
        }
        public static string link_Image;

        OpenFileDialog open;

        public static string Link_Image { get => link_Image; set => link_Image = value; }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.Filter = "Image File (*.jpg, *png)|*.jpg; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Link_Image = open.FileName;
                fTableManager.links_image.Add(Link_Image);
                this.ptB_image.BackgroundImageLayout = ImageLayout.Zoom;
                this.ptB_image.Image = new Bitmap(open.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Link_Image == null)
            {
                MessageBox.Show("Vui lòng thêm ảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Link_Image = txt_link.Text;
            this.Close();
        }
    }
}
