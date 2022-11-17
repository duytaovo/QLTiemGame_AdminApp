using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCafe.Logic_Layer;


namespace QuanLyCafe
{
    public partial class fChiTietHoaDon : Form
    {
        string MaHoaDon_global = "";
        DataTable dtChiTietHoaDon = null;
        LogicChiTietHoaDon dbChiTietHoaDon = new LogicChiTietHoaDon();

        public fChiTietHoaDon(string MaHoaDon)
        {
            InitializeComponent();
            MaHoaDon_global = MaHoaDon;
            LoadChiTietHoaDon(MaHoaDon_global);
        }

        private void fChiTietHoaDon_Load(object sender, EventArgs e)
        {

        }

        void LoadChiTietHoaDon(string MaHoaDon)
        {
            try
            {
                dtChiTietHoaDon = new DataTable();
                dtChiTietHoaDon.Clear();

                DataTable dataDisplay = dbChiTietHoaDon.XemChiTietHoaDon(MaHoaDon);
                dtChiTietHoaDon = dataDisplay;
                dtgv_ChiTietHoaDon.DataSource = dtChiTietHoaDon;

                //MessageBox.Show(dbChiTietHoaDon.XemChiTietHoaDon1(MaHoaDon));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không lấy được nội dung trong table. Lỗi rồi!!!" + ex);
            }
        }
    }
}
