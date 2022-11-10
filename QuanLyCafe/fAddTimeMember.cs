using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyCafe.DAO;

namespace QuanLyCafe
{
    public partial class fAddTimeMember : Form
    {
        MemberDAO db;
        DataTable mays;
        DataTable dt_mays;


        DataSet khach_hang;
        DataTable dt_khach_hang;
        public fAddTimeMember()
        {
            db = new MemberDAO();
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
          
            try
            {

                string ma_KH = txtTimKiem.Text;
                khach_hang = db.ThongTinKhachHangTheoTenDangNhap(ma_KH);
                dt_khach_hang = khach_hang.Tables[0];
                dataGridViewNapTien.DataSource = dt_khach_hang;

               if (dataGridViewNapTien.CurrentCell != null)
                {
                    int r2 = dataGridViewNapTien.CurrentCell.RowIndex;
                    // Chuyển thông tin lên panel
                    this.txtTenDangNhap.Text = dataGridViewNapTien.Rows[r2].Cells[1].Value.ToString();
                    this.txtSoTienConLai.Text = dataGridViewNapTien.Rows[r2].Cells[2].Value.ToString();
                 

                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Bạn Không có quyền truy xuất");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                string err = "";
               
                if (!db.CapNhapTienKhachHang(ref err, txtTenDangNhap.Text, int.Parse(txtSoTienNapThem.Text)))
                    MessageBox.Show("Lỗi :" + err);
                else
                {
                    MessageBox.Show("Nạp tiền thành Công");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi!!! Thử Lại Lần Sau. ");
            }
        }
    }
}
