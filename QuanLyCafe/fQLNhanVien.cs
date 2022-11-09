using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyCafe.DAO;
namespace QuanLyCafe
{
    public partial class fQLNhanVien : Form
    {
        NhanVienDAO db;
        string strConnect = "Data Source = DESKTOP-12J6D6C;" + "Initial Catalog = QLTiemGame;" + "Integrated Security=True";
        SqlConnection conn = null;
        SqlCommand command = new SqlCommand();
        SqlDataAdapter dap = null;
        DataTable dt = null;

   
        DataSet nhanvien;
        DataTable dt_nhanvien;
        public fQLNhanVien()
        {
            db = new NhanVienDAO();
            InitializeComponent();
         
            layNVFromProc();
        }

        private void layNVFromProc()
        {
            DataTable dtMonHoc = null;
            NhanVienDAO dbMonHoc = new NhanVienDAO();
            try
            {
                dtMonHoc = new DataTable();
                dtMonHoc.Clear();

                DataTable dataDisplay = dbMonHoc.layNVFromProc();
                dtMonHoc = dataDisplay;
                dataGridViewNV.DataSource = dtMonHoc;


            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không lấy được nội dung trong table. Lỗi rồi!!!" + ex);
            }
        }

        private void fQLNhanVien_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnect);
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {

            try
            {
                string err = "";
                if (!db.ThemNhanVien(ref err, txtTenDangNhap.Text, txtMatKhau.Text, txtHoTenNV.Text, cmbGioiTinhNV.Text, txtSoDT.Text,txtDiaChiNV.Text,txtVaiTroNV.Text, txtTienLuongNV.Text))
                    MessageBox.Show("Lỗi :" + err);
                else

                {
                    MessageBox.Show("Thêm Nhân Viên Thành Công");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi!!! Thử Lại Lần Sau. ");
            }

           
        }

        private void dataGridViewNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            try
            {
                string err = "";
                if (!db.CapNhapNhanVien(ref err, txtTenDangNhap.Text, txtMatKhau.Text, txtHoTenNV.Text,dateTimePickerNSNV.Value, cmbGioiTinhNV.Text, txtSoDT.Text, txtDiaChiNV.Text, txtVaiTroNV.Text, txtTienLuongNV.Text))
                    MessageBox.Show("Lỗi :" + err);
                else
                {
                    MessageBox.Show("Sửa Nhân Viên Thành Công");
                    layNVFromProc();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi!!! Thử Lại Lần Sau. ");
            }
        }

        private void dataGridViewNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewNV.CurrentCell != null)
            {
                int r = dataGridViewNV.CurrentCell.RowIndex;
                // Chuyển thông tin lên panel
                this.txtTenDangNhap.Text = dataGridViewNV.Rows[r].Cells[1].Value.ToString();
                this.txtHoTenNV.Text = dataGridViewNV.Rows[r].Cells[2].Value.ToString();
                this.dateTimePickerNSNV.Text = dataGridViewNV.Rows[r].Cells[3].Value.ToString();
                this.txtSoDT.Text = dataGridViewNV.Rows[r].Cells[4].Value.ToString();
                this.cmbGioiTinhNV.Text = dataGridViewNV.Rows[r].Cells[5].Value.ToString();
                this.txtDiaChiNV.Text = dataGridViewNV.Rows[r].Cells[6].Value.ToString();
                this.txtVaiTroNV.Text = dataGridViewNV.Rows[r].Cells[7].Value.ToString();
                this.txtTienLuongNV.Text = dataGridViewNV.Rows[r].Cells[8].Value.ToString();
               
            }
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            int r = dataGridViewNV.CurrentCell.RowIndex;
            if (dataGridViewNV.Rows[r].Cells[0].Value.ToString() == null)
                MessageBox.Show("Hãy chọn Nhân Viên cần xóa!!!");

            else
            {
                try
                {
                    string err = " ";
                    // Khai báo biến traloi 
                    DialogResult traloi;
                    // Hiện hộp thoại hỏi đáp 
                    string ma_nhan_vien = dataGridViewNV.Rows[r].Cells[0].Value.ToString();
                    MessageBox.Show(ma_nhan_vien);
                    traloi = MessageBox.Show("Chắc xóa không?", "Trả lời",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    // Kiểm tra có nhắp chọn nút Ok không? 
                    if (traloi == DialogResult.OK)
                    {

                        if (db.XoaNhanVien(ref err, ma_nhan_vien))
                        {
                            MessageBox.Show("Xóa Thành Công");
                            layNVFromProc();
                       
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

        private void btnXemThongTinNV_Click(object sender, EventArgs e)
        {
            int r = dataGridViewNV.CurrentCell.RowIndex;
            try
            {
                string ma_nhan_vien = dataGridViewNV.Rows[r].Cells[0].Value.ToString();
                string maNV = txtMaNV.Text;
                btnXoaNV.Enabled = true;
                nhanvien = db.NhanVientheoMaNV(maNV);
                dt_nhanvien = nhanvien.Tables[0];
                dataGridViewNV.DataSource = dt_nhanvien;
            }
            catch (SqlException)
            {
                MessageBox.Show("Bạn Không có quyền truy xuất");
            }
        }
    }
}
