using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyCafe.DAO;
namespace QuanLyCafe
{
    public partial class fQLNhanVien : Form
    {
        string strConnect = "Data Source = DESKTOP-12J6D6C;" + "Initial Catalog = QLTiemGame;" + "Integrated Security=True";
        SqlConnection conn = null;
        SqlCommand command = new SqlCommand();
        SqlDataAdapter dap = null;
        DataTable dt = null;
        public fQLNhanVien()
        {
            InitializeComponent();
            conn = new SqlConnection(strConnect);
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

        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
         /*   if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            try
            {
                //tao object thuc thi proc
                SqlCommand cmd = new SqlCommand("proc_ThemNhanVien", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                //Lay du lieu tu front-end
                string ten_dang_nhap = txtTenDangNhap.Text;
                string mat_khau = txtMK.Text;
                string ho_ten = txtHoTen.Text;
                string gioi_tinh = txtGioiTinh.Text;
                string dia_chi = txtDiaChi.Text;
                string vai_tro = txtVaiTro.Text;
                string so_dien_thoai = txtSDT.Text;

                //them tham so vo thu tuc
                SqlParameter p1 = new SqlParameter("@ten_dang_nhap", ten_dang_nhap);
                cmd.Parameters.Add(p1);
                SqlParameter p2 = new SqlParameter("@mat_khau", mat_khau);
                cmd.Parameters.Add(p2);
                SqlParameter p3 = new SqlParameter("@ho_ten", ho_ten);
                cmd.Parameters.Add(p3);
                *//* SqlParameter p4 = new SqlParameter("@ngay_sinh", ngay_sinh);
                 cmd.Parameters.Add(p4);*//*
                SqlParameter p5 = new SqlParameter("@gioi_tinh", gioi_tinh);
                cmd.Parameters.Add(p5);
                SqlParameter p6 = new SqlParameter("@so_dien_thoai", so_dien_thoai);
                cmd.Parameters.Add(p6);
                SqlParameter p7 = new SqlParameter("@dia_chi", dia_chi);
                cmd.Parameters.Add(p7);
                SqlParameter p8 = new SqlParameter("@vai_tro", vai_tro);
                cmd.Parameters.Add(p8);
                //
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { conn.Close(); laySPFromProc(); }*/
        }

        private void dataGridViewNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
