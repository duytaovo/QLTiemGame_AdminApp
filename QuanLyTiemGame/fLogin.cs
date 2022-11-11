using QuanLyTiemGame.DAO;
using QuanLyTiemGame.DTO;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace QuanLyTiemGame
{
    public partial class fLogin : Form
    {
        NhanVienDAO db;
        public fLogin()
        {
            db = new NhanVienDAO();
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, System.EventArgs e)
        {
            string userName = txtTenDangNhap.Text;
            string passWord = txtMatKhau.Text;
            if (Login(userName, passWord))
            {
                Account loginAccount = AccountDAO.Instance.GetAccountByUserName(userName);
                fTableManager f = new fTableManager(loginAccount);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                ptB_warming.Visible = true;
                lb_saiMK.Text = "Sai tên tài khoản hoặc mật khẩu!!!";
                //MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }


        private void pictureBox7_Click(object sender, System.EventArgs e)
        {
            btn_Login_Click(sender, e);
        }


        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = true;
        }

        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = false;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
              string strConnectionString = @"Data Source = DESKTOP-12J6D6C;" + "Initial Catalog = QLTiemGame;" + "Integrated Security=True";
            //dt ket noi db
              SqlConnection conn = new SqlConnection(strConnectionString);
            try
            {
                conn.Open();
                SqlParameter ten_dang_nhap = new SqlParameter("@ten_dang_nhap", txtTenDangNhap.Text);
                SqlParameter mat_khau = new SqlParameter("@mat_khau", txtMatKhau.Text);
                SqlCommand cmd = new SqlCommand("proc_Login", conn);
                cmd.Parameters.Add(ten_dang_nhap);
                cmd.Parameters.Add(mat_khau);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader data = cmd.ExecuteReader();

                if (data.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!");
                }
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Có lỗi!");
            }
           


        }

        private void txt_LoginName_Enter(object sender, System.EventArgs e)
        {
            if(txtTenDangNhap.Text == "Username")
            {
                txtTenDangNhap.Text = "";
                txtTenDangNhap.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txt_LoginName_Leave(object sender, System.EventArgs e)
        {
            if (txtTenDangNhap.Text == "")
            {
                txtTenDangNhap.Text = "Username";
                txtTenDangNhap.ForeColor = System.Drawing.Color.Silver;
            }
        }

        private void txt_PassWord_Enter(object sender, System.EventArgs e)
        {
            if (txtMatKhau.Text == "Password")
            {
                txtMatKhau.Text = "";
                txtMatKhau.ForeColor = System.Drawing.Color.Black;
                txtMatKhau.PasswordChar = '*';
            }
        }

        private void txt_PassWord_Leave(object sender, System.EventArgs e)
        {
            if (txtMatKhau.Text == "")
            {
                txtMatKhau.Text = "Password";
                txtMatKhau.ForeColor = System.Drawing.Color.Silver;
                txtMatKhau.PasswordChar = '\0';
            }
        }

        private void pictureBox6_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void fLogin_Load(object sender, System.EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = false;
        }

        private void txt_PassWord_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void label3_Click(object sender, System.EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, System.EventArgs e)
        {

        }
    }
}
