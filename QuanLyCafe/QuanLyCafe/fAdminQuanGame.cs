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
    public partial class fAdminQuanGame : Form
    {
        DataTable dtHoaDon = null;
        DataTable dtMay = null;
        DataTable dtDichVu = null;
        DataTable dtUuDai = null;
        DataTable dtNhanVien = null;

        string err;
        LogicHoaDon dbHoaDon = new LogicHoaDon();
        LogicMay dbMay = new LogicMay();
        LogicDichVu dbDichVu = new LogicDichVu();
        LogicUuDai dbUuDai = new LogicUuDai();
        LogicNhanVien dbNhanVien = new LogicNhanVien();
        public fAdminQuanGame()
        {
            InitializeComponent();
            Loaddata();
        }


        void Loaddata()
        {
            //DataBindings.Clear();
            LoadHoaDon();
            LoadMay();
            LoadDichVu();
            LoadUuDai();
            LoadNhanVien();

            DienThongTinTuDong_May();
            DienThongTinTuDong_DichVu();
            DienThongTinTuDong_UuDai();
            DienThongTinTuDong_NhanVien();
        }

        void LoadHoaDon()
        {
            try
            {
                dtHoaDon = new DataTable();
                dtHoaDon.Clear();

                DataTable dataDisplay = dbHoaDon.XemDanhSachHoaDon();
                dtHoaDon = dataDisplay;
                dtgv_bill.DataSource = dtHoaDon;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không lấy được nội dung trong table. Lỗi rồi!!!" + ex);
            }
        }

        void LoadMay()
        {
            try
            {
                dtMay = new DataTable();
                dtMay.Clear();

                DataTable dataDisplay = dbMay.XemDanhSachMay();
                dtMay = dataDisplay;
                dtgv_may.DataSource = dtMay;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không lấy được nội dung trong table. Lỗi rồi!!!" + ex);
            }
        }

        void LoadDichVu()
        {
            try
            {
                dtDichVu = new DataTable();
                dtDichVu.Clear();

                DataTable dataDisplay = dbDichVu.XemDanhSachDichVu();
                dtDichVu = dataDisplay;
                dtgv_dichVu.DataSource = dtDichVu;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không lấy được nội dung trong table. Lỗi rồi!!!" + ex);
            }
        }

        void LoadUuDai()
        {
            try
            {
                dtUuDai = new DataTable();
                dtUuDai.Clear();

                DataTable dataDisplay = dbUuDai.XemDanhSachUuDai();
                dtUuDai = dataDisplay;
                dtgv_uuDai.DataSource = dtUuDai;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không lấy được nội dung trong table. Lỗi rồi!!!" + ex);
            }
        }

        void LoadNhanVien()
        {
            try
            {
                dtNhanVien = new DataTable();
                dtNhanVien.Clear();

                DataTable dataDisplay = dbNhanVien.XemDanhSachNhanVien();
                dtNhanVien = dataDisplay;
                dtgv_nhanVien.DataSource = dtNhanVien;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không lấy được nội dung trong table. Lỗi rồi!!!" + ex);
            }
        }

        private void btn_viewBill_Click(object sender, EventArgs e)
        {

        }

        private void btn_searchFood_Click(object sender, EventArgs e)
        {

        }

        private void btn_viewFood_Click(object sender, EventArgs e)
        {

        }

        private void btn_editFood_Click(object sender, EventArgs e)
        {

        }

        private void btn_deleteFood_Click(object sender, EventArgs e)
        {

        }

        private void btn_addFood_Click(object sender, EventArgs e)
        {

        }

        private void dtgv_food_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void btn_addFood_Click_1(object sender, EventArgs e)
        {

        }
 
        void DienThongTinTuDong_May()
        {
            txt_mayID.DataBindings.Clear();
            txt_maMay.DataBindings.Clear();
            txt_loaiMay.DataBindings.Clear();
            txt_gia.DataBindings.Clear();
            txt_trangThai.DataBindings.Clear();

            txt_mayID.DataBindings.Add("Text", dtgv_may.DataSource, "id", true, DataSourceUpdateMode.Never);
            txt_maMay.DataBindings.Add("Text", dtgv_may.DataSource, "ma_may", true, DataSourceUpdateMode.Never);
            txt_loaiMay.DataBindings.Add("Text", dtgv_may.DataSource, "loai_may", true, DataSourceUpdateMode.Never);
            txt_gia.DataBindings.Add("Value", dtgv_may.DataSource, "gia_tien_mot_gio", true, DataSourceUpdateMode.Never);
            txt_trangThai.DataBindings.Add("Text", dtgv_may.DataSource, "trang_thai", true, DataSourceUpdateMode.Never);
        }
        void DienThongTinTuDong_DichVu()
        {
            txt_dichVuId.DataBindings.Clear();
            txt_maDichVu.DataBindings.Clear();
            txt_loaiDichVu.DataBindings.Clear();
            txt_tenMon.DataBindings.Clear();
            txt_giaDichVu.DataBindings.Clear();
            txt_soLuongDichVu.DataBindings.Clear();
            txt_trangThaiDichVu.DataBindings.Clear();

            txt_dichVuId.DataBindings.Add("Text", dtgv_dichVu.DataSource, "id", true, DataSourceUpdateMode.Never);
            txt_maDichVu.DataBindings.Add("Text", dtgv_dichVu.DataSource, "ma_dich_vu", true, DataSourceUpdateMode.Never);
            txt_loaiDichVu.DataBindings.Add("Text", dtgv_dichVu.DataSource, "loai_dich_vu", true, DataSourceUpdateMode.Never);
            txt_tenMon.DataBindings.Add("Text", dtgv_dichVu.DataSource, "ten_mon", true, DataSourceUpdateMode.Never);
            txt_giaDichVu.DataBindings.Add("Text", dtgv_dichVu.DataSource, "gia", true, DataSourceUpdateMode.Never);
            txt_soLuongDichVu.DataBindings.Add("Text", dtgv_dichVu.DataSource, "so_luong", true, DataSourceUpdateMode.Never);
            txt_trangThaiDichVu.DataBindings.Add("Text", dtgv_dichVu.DataSource, "status_dich_vu", true, DataSourceUpdateMode.Never);
        }

        void DienThongTinTuDong_UuDai()
        {
            txt_uuDaiId.DataBindings.Clear();
            txt_uuDaiMaUuDai.DataBindings.Clear();
            txt_uuDaiGiamGia.DataBindings.Clear();
            txt_uuDaiIdDichVu.DataBindings.Clear();
            txt_uuDaiIdNgayBatDau.DataBindings.Clear();
            txt_uuDaiIdNgayKetThuc.DataBindings.Clear();
            txt_uuDaiTrangThai.DataBindings.Clear();

            txt_uuDaiId.DataBindings.Add("Text", dtgv_uuDai.DataSource, "id", true, DataSourceUpdateMode.Never);
            txt_uuDaiMaUuDai.DataBindings.Add("Text", dtgv_uuDai.DataSource, "ma_uu_dai", true, DataSourceUpdateMode.Never);
            txt_uuDaiGiamGia.DataBindings.Add("Text", dtgv_uuDai.DataSource, "giam_gia", true, DataSourceUpdateMode.Never);
            txt_uuDaiIdDichVu.DataBindings.Add("Text", dtgv_uuDai.DataSource, "id_qua_tang_dich_vu", true, DataSourceUpdateMode.Never);
            txt_uuDaiIdNgayBatDau.DataBindings.Add("Text", dtgv_uuDai.DataSource, "StartDay", true, DataSourceUpdateMode.Never);
            txt_uuDaiIdNgayKetThuc.DataBindings.Add("Text", dtgv_uuDai.DataSource, "EndDay", true, DataSourceUpdateMode.Never);
            txt_uuDaiTrangThai.DataBindings.Add("Text", dtgv_uuDai.DataSource, "status_uu_dai", true, DataSourceUpdateMode.Never);
        }
        void DienThongTinTuDong_NhanVien()
        {
            txt_nvMa.DataBindings.Clear();
            txt_nvHoten.DataBindings.Clear();
            txt_nvGioitinh.DataBindings.Clear();
            txt_nvNgaySinh.DataBindings.Clear();
            txt_nvTenDangNhap.DataBindings.Clear();
            txt_nvPassWord.DataBindings.Clear();
            txt_nvNgayTao.DataBindings.Clear();
            txt_nvSoDienThoai.DataBindings.Clear();
            txt_nvDiachi.DataBindings.Clear();
            txt_nvVaiTro.DataBindings.Clear();
            txt_nvTrangThai.DataBindings.Clear();

            txt_nvMa.DataBindings.Add("Text", dtgv_nhanVien.DataSource, "ma_nhan_vien", true, DataSourceUpdateMode.Never);
            txt_nvHoten.DataBindings.Add("Text", dtgv_nhanVien.DataSource, "ho_ten", true, DataSourceUpdateMode.Never);
            txt_nvGioitinh.DataBindings.Add("Text", dtgv_nhanVien.DataSource, "gioi_tinh", true, DataSourceUpdateMode.Never);
            txt_nvNgaySinh.DataBindings.Add("Text", dtgv_nhanVien.DataSource, "ngay_sinh", true, DataSourceUpdateMode.Never);
            txt_nvTenDangNhap.DataBindings.Add("Text", dtgv_nhanVien.DataSource, "ten_dang_nhap", true, DataSourceUpdateMode.Never);
            txt_nvPassWord.DataBindings.Add("Text", dtgv_nhanVien.DataSource, "mat_khau", true, DataSourceUpdateMode.Never);
            txt_nvNgayTao.DataBindings.Add("Text", dtgv_nhanVien.DataSource, "ngay_tao_tai_khoan", true, DataSourceUpdateMode.Never);
            txt_nvSoDienThoai.DataBindings.Add("Text", dtgv_nhanVien.DataSource, "so_dien_thoai", true, DataSourceUpdateMode.Never);
            txt_nvDiachi.DataBindings.Add("Text", dtgv_nhanVien.DataSource, "dia_chi", true, DataSourceUpdateMode.Never);
            txt_nvVaiTro.DataBindings.Add("Text", dtgv_nhanVien.DataSource, "vai_tro", true, DataSourceUpdateMode.Never);
            txt_nvTrangThai.DataBindings.Add("Text", dtgv_nhanVien.DataSource, "status_tai_khoan", true, DataSourceUpdateMode.Never);
        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_addMay_Click(object sender, EventArgs e)
        {
            try
            {
                string loai_may = this.txt_loaiMay.Text;
                dbMay.ThemMay(loai_may, ref err);
                MessageBox.Show("Thêm thành công!");
                //this.Loaddata();
                LoadMay();
                DienThongTinTuDong_May();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Không thêm được, Lỗi rồi! " + ex + err);
            }
        }

        private void btn_dichVuThem_Click(object sender, EventArgs e)
        {
            try
            {
                string ma_dich_vu = txt_maDichVu.Text;
                string ten_dich_vu = txt_loaiDichVu.Text;
                string ten_mon = txt_tenMon.Text;
                int gia_moi_san_pham = (int)txt_giaDichVu.Value;
                int so_luong = (int)txt_soLuongDichVu.Value;
                dbDichVu.ThemDichVu(ma_dich_vu, ten_dich_vu, ten_mon, gia_moi_san_pham, so_luong, ref err);
                MessageBox.Show("Thêm thành công!");
                //this.Loaddata();
                LoadDichVu();
                DienThongTinTuDong_DichVu();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thêm được, Lỗi rồi! " + ex + err);
            }
        }

        private void btn_themUuDai_Click(object sender, EventArgs e)
        {
            try
            {
                string ma_uu_dai = txt_uuDaiMaUuDai.Text;
                /*int giam_gia = Convert.ToInt32(txt_uuDaiGiamGia.Text);
                int id_dich_vu = Convert.ToInt32(txt_uuDaiIdDichVu.Text);*/
                string giam_gia = txt_uuDaiGiamGia.Text;
                string id_dich_vu = txt_uuDaiIdDichVu.Text;
                string ngay_bat_dau = txt_uuDaiIdNgayBatDau.Text;
                string ngay_ket_thuc =txt_uuDaiIdNgayKetThuc.Text;

                dbUuDai.ThemUuDai(ma_uu_dai, giam_gia, id_dich_vu, ngay_bat_dau, ngay_ket_thuc, ref err);
                
                MessageBox.Show("Thêm thành công!");
                //this.Loaddata();
                LoadUuDai();
                DienThongTinTuDong_UuDai();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thêm được, Lỗi rồi! " + ex);
            }
        }

        private void btn_nhanVienThem_Click(object sender, EventArgs e)
        {
            try
            {
                string ten_dang_nhap = txt_nvTenDangNhap.Text;
                string mat_khau = txt_nvPassWord.Text;
                string ho_ten = txt_nvHoten.Text;
                string ngay_sinh = txt_nvNgaySinh.Text;
                string gioi_tinh = txt_nvGioitinh.Text;
                string so_dien_thoai = txt_nvSoDienThoai.Text;
                string dia_chi = txt_nvDiachi.Text;
                string vai_tro = txt_nvVaiTro.Text;
                dbNhanVien.ThemNhanVien(ten_dang_nhap, mat_khau, ho_ten, ngay_sinh, gioi_tinh, so_dien_thoai, dia_chi, vai_tro, ref err);

                MessageBox.Show("Thêm thành công!");
                //this.Loaddata();
                LoadNhanVien();
                DienThongTinTuDong_NhanVien();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thêm được, Lỗi rồi! " + ex);
            }
        }

        private void btn_xoaMay_Click(object sender, EventArgs e)
        {
            string ma_may = txt_maMay.Text;
            dbMay.XoaMay(ma_may, ref err);

            MessageBox.Show("Xoá thành công!");
            //this.Loaddata();
            LoadMay();
            DienThongTinTuDong_May();
            /*try
            {
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thêm được, Lỗi rồi! ");
            }*/
        }

        private void btn_xoaDichVu_Click(object sender, EventArgs e)
        {
            try
            {
                int id_dich_vu = Int32.Parse(txt_dichVuId.Text);
                dbDichVu.XoaDichVu(id_dich_vu, ref err);

                MessageBox.Show("Xoá thành công!");
                this.Loaddata();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thêm được, Lỗi rồi! " + ex);
            }
        }

        private void btn_xoaUuDai_Click(object sender, EventArgs e)
        {
            try
            {
                string ma_uu_dai = txt_uuDaiMaUuDai.Text;
                dbUuDai.XoaUuDai(ma_uu_dai, ref err);

                MessageBox.Show("Xoá thành công!");
                this.Loaddata();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thêm được, Lỗi rồi! " + ex);
            }
        }

        private void btn_xoaNhanVien_Click(object sender, EventArgs e)
        {
            try 
            {
                string ten_dang_nhap = txt_nvTenDangNhap.Text;
                dbNhanVien.XoaNhanVien(ten_dang_nhap, ref err);

                MessageBox.Show("Xoá thành công!");
                this.Loaddata();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thêm được, Lỗi rồi! " + ex);
            }
        }

        private void fAdminQuanGame_Load(object sender, EventArgs e)
        {

        }

        private void btn_editMay_Click(object sender, EventArgs e)
        {
            try
            {
                string ma_may = txt_maMay.Text;
                string loai_may = txt_loaiMay.Text;
                int gia_may = (int)txt_gia.Value;
                dbMay.SuaThongtinMay(ma_may, loai_may, gia_may, ref err);

                MessageBox.Show("Sửa thành công!");
                this.Loaddata();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không sửa được, Lỗi rồi! " + ex);
            }
        }

        private void btn_editDichVu_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txt_dichVuId.Text);
                string ma_dich_vu = txt_maDichVu.Text;
                string loai_dich_vu = txt_loaiDichVu.Text;
                string ten_mon = txt_tenMon.Text;
                int gia_tien = (int)txt_giaDichVu.Value;
                int so_luong = (int)txt_soLuongDichVu.Value;
                dbDichVu.SuaThongTinDichVu(id, ma_dich_vu, loai_dich_vu, ten_mon, gia_tien, so_luong, ref err);

                MessageBox.Show("Sửa thành công!");
                this.Loaddata();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không sửa được, Lỗi rồi! " + ex);
            }
        }

        private void btn_editUuDai_Click(object sender, EventArgs e)
        {
            try
            {
                string ma_uu_dai = txt_uuDaiMaUuDai.Text;
                int giam_gia = Convert.ToInt32(txt_uuDaiGiamGia.Text);
                int id_dich_vu = Convert.ToInt32(txt_uuDaiIdDichVu.Text);
                string startDay = txt_uuDaiIdNgayBatDau.Text;
                string endDay = txt_uuDaiIdNgayKetThuc.Text;
                dbUuDai.SuaThongTinUuDai(ma_uu_dai, giam_gia, id_dich_vu, startDay, endDay, ref err);

                MessageBox.Show("Sửa thành công!");
                this.Loaddata();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không sửa được, Lỗi rồi! " + ex);
            }
        }

        private void btn_editNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                string ten_dang_nhap = txt_nvTenDangNhap.Text;
                string mat_khau = txt_nvPassWord.Text;
                string ho_ten = txt_nvHoten.Text;
                string ngay_sinh = txt_nvNgaySinh.Text;
                string gioi_tinh = txt_nvGioitinh.Text;
                string so_dien_thoai = txt_nvSoDienThoai.Text;
                string dia_chi = txt_nvDiachi.Text;
                string vai_tro = txt_nvVaiTro.Text;
                dbNhanVien.SuaNhanVien(ten_dang_nhap, mat_khau, ho_ten, ngay_sinh, gioi_tinh, so_dien_thoai, dia_chi, vai_tro, ref err);

                MessageBox.Show("Sửa thành công!");
                this.Loaddata();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không sửa được, Lỗi rồi! " + ex);
            }
        }

        private void btn_xemMay_Click(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void btn_xemDichVu_Click(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void btn_XemUuDai_Click(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void btn_xemNhanVien_Click(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void btn_searchMay_Click(object sender, EventArgs e)
        {
            try
            {
                dtMay = new DataTable();
                dtMay.Clear();

                string ma_may = txt_maMay.Text;
                string loai_may = txt_loaiMay.Text;
                string gia_moi_gio = (txt_gia.Value).ToString();
                string trang_thai = txt_trangThai.Text;
                //dbMay.LayThongTinMay(ma_may);

                DataTable dataDisplay = dbMay.XemThongTinMay(ma_may, loai_may, gia_moi_gio, trang_thai);
                dtMay = dataDisplay;
                dtgv_may.DataSource = dtMay;

                //MessageBox.Show("Sửa thành công!");
                //this.Loaddata();
                DienThongTinTuDong_May();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không xem được, Lỗi rồi! " + ex);
            }
        }

        private void btn_searchDichVu_Click(object sender, EventArgs e)
        {
            try
            {
                dtDichVu = new DataTable();
                dtDichVu.Clear();

                string ma_dich_vu = txt_maDichVu.Text;
                string loai_dich_vu = txt_loaiDichVu.Text;
                string ten_mon = txt_tenMon.Text;
                string gia = txt_giaDichVu.Value.ToString() ;
                string status_dich_vu = txt_trangThaiDichVu.Text;
                if (String.Compare(status_dich_vu, "", true) == 0)
                    status_dich_vu = "2";
                //dbMay.LayThongTinMay(ma_may);

                //MessageBox.Show(dbDichVu.XemThongTinDichVu1(ma_dich_vu, loai_dich_vu, ten_mon, gia, status_dich_vu));

                DataTable dataDisplay = dbDichVu.XemThongTinDichVu(ma_dich_vu, loai_dich_vu, ten_mon, gia, status_dich_vu);
                dtDichVu = dataDisplay;
                dtgv_dichVu.DataSource = dtDichVu;

                //MessageBox.Show("Sửa thành công!");
                //this.Loaddata();
                DienThongTinTuDong_DichVu();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không xem được, Lỗi rồi! " + ex);
            }
        }

        private void btn_searchUuDai_Click(object sender, EventArgs e)
        {
            try
            {
                dtUuDai = new DataTable();
                dtUuDai.Clear();

                string ma_uu_dai = txt_uuDaiMaUuDai.Text;
                string giam_gia = txt_uuDaiGiamGia.Text;
                // bien string co gia tri la "" khong the chuyen sang kieu int duoc
                string id_qua = txt_uuDaiIdDichVu.Text;
                string start_day = txt_uuDaiIdNgayBatDau.Text;
                string end_day = txt_uuDaiIdNgayKetThuc.Text;
                string ngay_cu_the = txt_searchNgayApDung.Text;
                string status_uu_dai = txt_uuDaiTrangThai.Text;
                if (String.Compare(status_uu_dai, "", true) == 0)
                    status_uu_dai = "2";
                if (String.Compare(giam_gia, "", true) == 0)
                    giam_gia = "0";
                if (String.Compare(id_qua, "", true) == 0)
                    id_qua = "0";
                //dbMay.LayThongTinMay(ma_may);
                //MessageBox.Show(dbUuDai.XemThongTinUuDai1(ma_uu_dai, giam_gia, id_qua, start_day, end_day, ngay_cu_the, status_uu_dai));
                DataTable dataDisplay = dbUuDai.XemThongTinUuDai(ma_uu_dai, giam_gia, id_qua, start_day, end_day, ngay_cu_the, status_uu_dai);
                dtUuDai = dataDisplay;
                dtgv_uuDai.DataSource = dtUuDai;

                //MessageBox.Show("Sửa thành công!");
                //this.Loaddata();
                DienThongTinTuDong_UuDai();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không xem được, Lỗi rồi! " + ex);
            }
        }

        private void btn_searchNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                dtNhanVien = new DataTable();   
                dtNhanVien.Clear();

                string ma_nhan_vien = txt_nvMa.Text;
                string ho_ten = txt_nvHoten.Text;
                string gioi_tinh = txt_nvGioitinh.Text;
                string ngay_sinh = txt_nvNgaySinh.Text;
                string dia_chi = txt_nvDiachi.Text;
                string vai_tro = txt_nvVaiTro.Text;
                string status = txt_nvTrangThai.Text;
                string ten_dang_nhap = txt_nvTenDangNhap.Text;
                string ngay_tao = txt_nvNgayTao.Text;

                if (String.Compare(status, "", true) == 0)
                    status = "2";
                //dbMay.LayThongTinMay(ma_may);

                DataTable dataDisplay = dbNhanVien.XemThongTinNhanVien(ma_nhan_vien, ho_ten, gioi_tinh,
                                                                        ngay_sinh, dia_chi, vai_tro,
                                                                        status, ten_dang_nhap, ngay_tao);
                dtNhanVien = dataDisplay;
                dtgv_nhanVien.DataSource = dtNhanVien;

                //MessageBox.Show("Sửa thành công!");
                //this.Loaddata();
                DienThongTinTuDong_NhanVien();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không xem được, Lỗi rồi! " + ex);
            }
        }
    }


}
 