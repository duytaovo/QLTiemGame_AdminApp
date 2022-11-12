using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyTiemGame.DAO;
using QuanLyTiemGame.DTO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using Aspose.Words.Tables;
using Aspose.Words;//Thêm thư viện này (file Dll\Aspose.Word.dll)
using ReportExtentionMethod.cs;//thêm thư viện này (File Lib\ReportExtentionMethod.cs)
namespace QuanLyTiemGame
{
    public partial class fQuanLyMay : Form
    {
        ServiceDAO db;
        SqlCommand command = new SqlCommand();
        SqlDataAdapter dap = null;
        DataTable dt = null;

        DataTable dichvus;
        DataTable dt_dichvus;


        DataSet may;
        DataTable dt_may;


        public fQuanLyMay()
        {

            db = new ServiceDAO();
            InitializeComponent();
            LoadTable();
            LoadCategogy();
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

        private void drgvFood_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void drgvDrink_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void drgvCard_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void picOrderEventHandler(object sender, EventArgs e)
        {

        }

        private void picOrder_MouseLeave(object sender, EventArgs e)
        {

        }

        private void picOrder_MouseHover(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {
          
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                dichvus = db.LayDichVu();
                dt_dichvus = dichvus;
                drgvDV.DataSource = dt_dichvus;
            }
            catch (SqlException)
            {
                MessageBox.Show("Bạn Không có quyền truy xuất");
            }
        }
        void LoadTable()
        {

            flp_Talble.Controls.Clear();

            List<Table> tablelist = TableDAO.Instance.LoadTableList();

            foreach (Table item in tablelist)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Click += Btn_Click;
                btn.Tag = item;
                btn.Text = item.MaMay + Environment.NewLine + item.LoaiMay + Environment.NewLine + item.Status ;
                switch (item.Status)
                {
                    case "Trống":
                        //btn.Image = Image.FromFile(@"ban_khong_co_nguoi.png");
                        btn.Image = Properties.Resources.ban_khong_co_nguoi;
                        btn.ImageAlign = ContentAlignment.TopCenter;
                        btn.TextAlign = ContentAlignment.BottomCenter;
                        btn.BackColor = Color.White; //ban trong thi ban co mau xanh
                        break;
                    case "trống":
                        btn.Image = Properties.Resources.ban_khong_co_nguoi;
                        btn.ImageAlign = ContentAlignment.TopCenter;
                        btn.TextAlign = ContentAlignment.BottomCenter;
                        btn.BackColor = Color.White;
                        break;
                    default:
                        btn.Image = Properties.Resources.ban_co_nguoi;
                        btn.ImageAlign = ContentAlignment.TopCenter;
                        btn.TextAlign = ContentAlignment.BottomCenter;
                        btn.BackColor = Color.LightSalmon; // ban co nguoi thi co mau hong
                        break;
                }
                flp_Talble.Controls.Add(btn);
            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            string tableID = ((sender as Button).Tag as Table).MaMay;
            showBill(tableID);
            lv_Bill.Tag = (sender as Button).Tag;
        }
        void showBill(string id)
        {
            Table tablelist = TableDAO.Instance.LoadTableLis1(id);
            txtMaMay.Text = tablelist.MaMay;
          
        }

        private void flp_Talble_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        void LoadCategogy()
        {
            List<Food> listFood = FoodDAO.Instance.GetListCategory();
            cmbUuDai.DataSource = listFood;
            cmbUuDai.DisplayMember = "Name";
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            var homNay = DateTime.Now;
            //Bước 1: Nạp file mẫu
            Document baoCao = new Document("Template\\Quán game ABC.doc");

            //Bước 2: Điền các thông tin cố định
           // baoCao.MailMerge.Execute(new[] { "Ngay_Thang_Nam_BC" }, new[] { string.Format("Bắc Kạn, ngày {0} tháng {1} năm {2}", homNay.Day, homNay.Month, homNay.Year) });
            baoCao.MailMerge.Execute(new[] { "ma_may" }, new[] { txtMaMay.Text });
          /*  baoCao.MailMerge.Execute(new[] { "Ngay_Sinh" }, new[] { dateNgaySinh.Value.ToString("dd/MM/yyyy") });
            baoCao.MailMerge.Execute(new[] { "SDT" }, new[] { txtSoDienThoai.Text });
            baoCao.MailMerge.Execute(new[] { "Que_Quan" }, new[] { txtQueQuan.Text });
            baoCao.MailMerge.Execute(new[] { "Nguoi_Yeu" }, new[] { "Sơn Tùng MTP" });
            baoCao.MailMerge.Execute(new[] { "Nguoi_Giam_Ho" }, new[] { "Nguyễn Văn A" });*/

            //Bước 3: Điền thông tin lên bảng
            Table bangThongTinGiaDinh = baoCao.GetChild(NodeType.Table, 0, true) as Table;//Lấy bảng thứ 2 trong file mẫu
            int hangHienTai = 1;
            bangThongTinGiaDinh.InsertRows(hangHienTai, hangHienTai, 3);
            for (int i = 1; i <= 4; i++)
            {
                bangThongTinGiaDinh.PutValue(hangHienTai, 0, i.ToString());//Cột STT
                bangThongTinGiaDinh.PutValue(hangHienTai, 1, "Nguyễn Văn A");//Cột Họ và tên
                bangThongTinGiaDinh.PutValue(hangHienTai, 2, "Bố đẻ");//Cột quan hệ
                bangThongTinGiaDinh.PutValue(hangHienTai, 3, "0123456789");//Cột Số điện thoại
                hangHienTai++;
            }

            //Bước 4: Lưu và mở file
            baoCao.SaveAndOpenFile("BaoCao.doc");
        }
    }
}
