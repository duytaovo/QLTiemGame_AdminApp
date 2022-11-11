using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyTiemGame.DAO;

namespace QuanLyTiemGame
{
    public partial class fMember : Form
    {
        MemberDAO db;
        DataTable mays;
        DataTable dt_mays;


        DataSet khach_hang;
        DataTable dt_khach_hang;
        public fMember()
        {
            db = new MemberDAO();
            InitializeComponent();
        }

        private void btnXemThongTinNV_Click(object sender, EventArgs e)
        {
            try
            {

                string ma_KH = txtTenDangNhap.Text;
                khach_hang = db.ThongTinKhachHangTheoTenDangNhap(ma_KH);
                dt_khach_hang = khach_hang.Tables[0];
                dataGridViewKhachHang.DataSource = dt_khach_hang;

                if (dataGridViewKhachHang.CurrentCell != null)
                {
                    int r2 = dataGridViewKhachHang.CurrentCell.RowIndex;
                    // Chuyển thông tin lên panel
                    this.txtTenDangNhap.Text = dataGridViewKhachHang.Rows[r2].Cells[1].Value.ToString();


                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Bạn Không có quyền truy xuất");
            }
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            try
            {
                string err = "";
                if (!db.ThemKhachHang(ref err, txtTenDangNhap.Text, txtMatKhau.Text))
                    MessageBox.Show("Lỗi :" + err);
                else

                {
                    MessageBox.Show("Thêm Khach Hàng Thành Công");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi!!! Thử Lại Lần Sau. ");
            }
        }

        private void fMember_Load(object sender, EventArgs e)
        {
            try
            {
                mays = db.LayKhachHang();
                dt_mays = mays;
                dataGridViewKhachHang.DataSource = dt_mays;
            }
            catch (SqlException)
            {
                MessageBox.Show("Bạn Không có quyền truy xuất");
            }
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            try
            {
                string err = "";
                if (!db.CapNhapKhachHang(ref err, txtTenDangNhap.Text, txtMatKhau.Text))
                    MessageBox.Show("Lỗi :" + err);
                else
                {
                    MessageBox.Show("Sửa Khach Hang Thành Công");
                    fMember_Load(null,null);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi!!! Thử Lại Lần Sau. ");
            }
        }

        private void dataGridViewKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewKhachHang.CurrentCell != null)
            {
                int r = dataGridViewKhachHang.CurrentCell.RowIndex;
                // Chuyển thông tin lên panel
                this.txtTenDangNhap.Text = dataGridViewKhachHang.Rows[r].Cells[1].Value.ToString();

            }
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            int r = dataGridViewKhachHang.CurrentCell.RowIndex;
            if (dataGridViewKhachHang.Rows[r].Cells[0].Value.ToString() == null)
                MessageBox.Show("Hãy chọn Nhân Viên cần xóa!!!");

            else
            {
                try
                {
                    string err = " ";
                    // Khai báo biến traloi 
                    DialogResult traloi;
                    // Hiện hộp thoại hỏi đáp 
                    string ma_nhan_vien = dataGridViewKhachHang.Rows[r].Cells[1].Value.ToString();
                  
                    traloi = MessageBox.Show("Chắc xóa không?", "Trả lời",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    // Kiểm tra có nhắp chọn nút Ok không? 
                    if (traloi == DialogResult.OK)
                    {

                        if (db.XoaKhachHang(ref err, ma_nhan_vien))
                        {
                            MessageBox.Show("Xóa Thành Công");
                            fMember_Load(null, null);

                        }
                        else
                            MessageBox.Show("Lỗi :" + err);
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi!!! Thử Lại Lần Sau.");
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
