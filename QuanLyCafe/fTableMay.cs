using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyCafe.DAO;
namespace QuanLyCafe
{
    public partial class fTableMay : Form
    {
        MayDAO db;
        SqlCommand command = new SqlCommand();
        SqlDataAdapter dap = null;
        DataTable dt = null;

        DataTable mays;
        DataTable dt_mays;


        DataSet may;
        DataTable dt_may;
        public fTableMay()
        {
            db = new MayDAO();
            InitializeComponent();
        }

        private void fTableMay_Load(object sender, EventArgs e)
        {

            try { 
                mays = db.LayMay();
                dt_mays = mays;
                dataGridViewMay.DataSource = dt_mays;
            }
            catch (SqlException)
            {
                MessageBox.Show("Bạn Không có quyền truy xuất");
            }
        }

        private void btnXemThongTinNV_Click(object sender, EventArgs e)
        {
            int r = dataGridViewMay.CurrentCell.RowIndex;
            try
            {
             /*   string ma_may = dataGridViewMay.Rows[r].Cells[0].Value.ToString();*/
                string ma_may = txtMaMay.Text;
                may = db.MayTheoMaMay(ma_may);
                dt_may = may.Tables[0];
                dataGridViewMay.DataSource = dt_may;

                if (dataGridViewMay.CurrentCell != null)
                {
                    int r2 = dataGridViewMay.CurrentCell.RowIndex;
                    // Chuyển thông tin lên panel
                    this.txtMaMay.Text = dataGridViewMay.Rows[r2].Cells[1].Value.ToString();
                    this.cmbLoaiMay.Text = dataGridViewMay.Rows[r2].Cells[2].Value.ToString();
                    this.txtGiaTien.Text = dataGridViewMay.Rows[r2].Cells[3].Value.ToString();
                    this.cmbTrangThai.Text = dataGridViewMay.Rows[r2].Cells[4].Value.ToString();

                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Bạn Không có quyền truy xuất");
            }
        }

        private void dataGridViewMay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewMay.CurrentCell != null)
            {
                int r = dataGridViewMay.CurrentCell.RowIndex;
                // Chuyển thông tin lên panel
                this.txtMaMay.Text = dataGridViewMay.Rows[r].Cells[1].Value.ToString();
                this.cmbLoaiMay.Text = dataGridViewMay.Rows[r].Cells[2].Value.ToString();
                this.txtGiaTien.Text = dataGridViewMay.Rows[r].Cells[3].Value.ToString();
                this.cmbTrangThai.Text = dataGridViewMay.Rows[r].Cells[4].Value.ToString();

            }
        }

        private void btnBatTatMay_Click(object sender, EventArgs e)
        {
            try
            {
                string trang_thai_may;
                if (cmbTrangThai.Text == "Bật")
                {
                    trang_thai_may = "Tắt";
                }
                else
                {
                    trang_thai_may = "Bật";
                }
                string err = "";
                if (!db.CapNhapTrangThaiMay(ref err, txtMaMay.Text, trang_thai_may))
                    MessageBox.Show("Lỗi :" + err);
                else
                {
                    MessageBox.Show(trang_thai_may + "thành công");
                    fTableMay_Load(null, null);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi!!! Thử Lại Lần Sau. ");
            }
        }
    }
}
