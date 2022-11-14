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

using Aspose.Words;//Thêm thư viện này (file Dll\Aspose.Word.dll)
//using Aspose.Words.Tables;//Thêm thư viện này (file Dll\Aspose.Word.dll)
using ThuVienWinform.Report.AsposeWordExtension;//thêm thư viện này (File Lib\ReportExtentionMethod.cs)
namespace QuanLyTiemGame
{
    public partial class fQuanLyMay : Form
    {
        ServiceDAO db;
        MayDAO db2;
        SqlCommand command = new SqlCommand();
        SqlDataAdapter dap = null;
        DataTable dt = null;

        DataTable dichvus;
        DataTable dt_dichvus;


        DataSet may;
        DataTable dt_may;

        object tinh_tien_may;

        object tinh_tien_dich_vu;
        object tong;
        public fQuanLyMay()
        {
            InitializeComponent();
            db = new ServiceDAO();
            db2 = new MayDAO();
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
            try
            {
                
                string ma_KH = txtMaMay.Text;
                tinh_tien_may =db2.LayTienMay(ma_KH);
           
                tinh_tien_dich_vu =db2.LayTienDichVu(ma_KH);
               
                object tinh_tien_ma_giam_gia = db2.LayTienMaGiamGia(cmbUuDai.Text);
                //int tong = Int32.Parse(tinh_tien_dich_vu.ToString()) + Int32.Parse(tinh_tien_may.ToString()) - tinh_tien_ma_giam_gia;
                object tong_tien = db2.LayTienTong(ma_KH, cmbUuDai.Text);
                var homNay = DateTime.Now;
                //Bước 1: Nạp file mẫu
                Document baoCao = new Document("Temp\\Mau_Bao_Cao.doc");

                //Bước 2: Điền các thông tin cố định
                baoCao.MailMerge.Execute(new[] { "Ngay_Thang_Nam_BC" }, new[] { string.Format("TPHCM, ngày {0} tháng {1} năm {2}", homNay.Day, homNay.Month, homNay.Year) });
                baoCao.MailMerge.Execute(new[] { "Ho_Ten" }, new[] { txtMaMay.Text });
                baoCao.MailMerge.Execute(new[] { "SDT" }, new[] { tinh_tien_ma_giam_gia });
                baoCao.MailMerge.Execute(new[] { "Nguoi_Yeu" }, new[] { "" });
                baoCao.MailMerge.Execute(new[] { "Que_Quan" }, new[] { "" });

                //Bước 3: Điền thông tin lên bảng
                Aspose.Words.Tables.Table bangThongTinGiaDinh = baoCao.GetChild(NodeType.Table, 1, true) as Aspose.Words.Tables.Table;//Lấy bảng thứ 2 trong file mẫu
                int hangHienTai = 1;
                int hangTiepTheo = 2;
                int hangTiepTheo3 = 3;
                int hangTiepTheo4 = 4;
      

                bangThongTinGiaDinh.PutValue(hangHienTai, 0, "1");//Cột STT
              //  bangThongTinGiaDinh.PutValue(hangHienTai, 1, "Máy");//Cột Họ và tên
                bangThongTinGiaDinh.PutValue(hangHienTai, 2, tinh_tien_may.ToString());//Cột quan hệ

                bangThongTinGiaDinh.PutValue(hangTiepTheo, 0, "2");//Cột STT
                //bangThongTinGiaDinh.PutValue(hangTiepTheo, 1, "Dịch vụ");//Cột Họ và tên
                bangThongTinGiaDinh.PutValue(hangTiepTheo, 2, tinh_tien_dich_vu.ToString());//Cột quan hệ

                bangThongTinGiaDinh.PutValue(hangTiepTheo3, 0, "3");//Cột STT
                //bangThongTinGiaDinh.PutValue(hangTiepTheo3, 1, "Mã giảm giá ( nếu có) ");//Cột Họ và tên
                bangThongTinGiaDinh.PutValue(hangTiepTheo3, 2, tinh_tien_ma_giam_gia.ToString());//Cột quan hệ

                bangThongTinGiaDinh.PutValue(hangTiepTheo4, 0, "4");//Cột STT
                //bangThongTinGiaDinh.PutValue(hangTiepTheo4, 1, "Tổng tiền : ");//Cột Họ và tên
                bangThongTinGiaDinh.PutValue(hangTiepTheo4, 2, tong_tien.ToString());//Cột quan hệ


                //Bước 4: Lưu và mở file
                baoCao.SaveAndOpenFile("BaoCao.doc");
            }
            catch (SqlException)
            {
                MessageBox.Show("Có lỗi kiểm tra lại !");
            }

          
        }

        private void cb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_Category.Text == "Khách hàng thường xuyên")
            {
                btn_BatMay.Enabled = false;
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled=false;
                btn_BatMay.Enabled = true;
            }
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {
           
        }

        private void tabDichVu_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void btnMoForm_Click(object sender, EventArgs e)
        {
            fMember f = new fMember();
            f.ShowDialog();
            this.Show();
        }
    }
}
