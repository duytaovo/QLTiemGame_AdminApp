using QuanLyCafe.DAO;
using QuanLyCafe.DTO;
using System.Windows.Forms;

namespace QuanLyCafe
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, System.EventArgs e)
        {
            string userName = txt_LoginName.Text;
            string passWord = txt_PassWord.Text;
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
            txt_PassWord.UseSystemPasswordChar = true;
        }

        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            txt_PassWord.UseSystemPasswordChar = false;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            btn_Login_Click(sender, e);
        }

        private void txt_LoginName_Enter(object sender, System.EventArgs e)
        {
            if(txt_LoginName.Text == "Username")
            {
                txt_LoginName.Text = "";
                txt_LoginName.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txt_LoginName_Leave(object sender, System.EventArgs e)
        {
            if (txt_LoginName.Text == "")
            {
                txt_LoginName.Text = "Username";
                txt_LoginName.ForeColor = System.Drawing.Color.Silver;
            }
        }

        private void txt_PassWord_Enter(object sender, System.EventArgs e)
        {
            if (txt_PassWord.Text == "Password")
            {
                txt_PassWord.Text = "";
                txt_PassWord.ForeColor = System.Drawing.Color.Black;
                txt_PassWord.PasswordChar = '*';
            }
        }

        private void txt_PassWord_Leave(object sender, System.EventArgs e)
        {
            if (txt_PassWord.Text == "")
            {
                txt_PassWord.Text = "Password";
                txt_PassWord.ForeColor = System.Drawing.Color.Silver;
                txt_PassWord.PasswordChar = '\0';
            }
        }

        private void pictureBox6_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void fLogin_Load(object sender, System.EventArgs e)
        {
            txt_PassWord.UseSystemPasswordChar = false;
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
