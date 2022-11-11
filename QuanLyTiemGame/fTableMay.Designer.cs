namespace QuanLyTiemGame
{
    partial class fTableMay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTableMay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXemThongTinNV = new System.Windows.Forms.Button();
            this.btnBatTatMay = new System.Windows.Forms.Button();
            this.cmbTrangThai = new System.Windows.Forms.ComboBox();
            this.cmbLoaiMay = new System.Windows.Forms.ComboBox();
            this.txtMaMay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewMay = new System.Windows.Forms.DataGridView();
            this.ma_may = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loai_may = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia_tien_mot_gio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trang_thai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMay)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnXemThongTinNV);
            this.groupBox1.Controls.Add(this.btnBatTatMay);
            this.groupBox1.Controls.Add(this.cmbTrangThai);
            this.groupBox1.Controls.Add(this.cmbLoaiMay);
            this.groupBox1.Controls.Add(this.txtMaMay);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtGiaTien);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 174);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cơ bản";
            // 
            // btnXemThongTinNV
            // 
            this.btnXemThongTinNV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXemThongTinNV.BackgroundImage")));
            this.btnXemThongTinNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXemThongTinNV.FlatAppearance.BorderSize = 0;
            this.btnXemThongTinNV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnXemThongTinNV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnXemThongTinNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemThongTinNV.Image = global::QuanLyTiemGame.Properties.Resources.add_user;
            this.btnXemThongTinNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemThongTinNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemThongTinNV.Location = new System.Drawing.Point(396, 33);
            this.btnXemThongTinNV.Name = "btnXemThongTinNV";
            this.btnXemThongTinNV.Size = new System.Drawing.Size(133, 33);
            this.btnXemThongTinNV.TabIndex = 6;
            this.btnXemThongTinNV.Text = "Xem thông tin máy";
            this.btnXemThongTinNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXemThongTinNV.UseVisualStyleBackColor = true;
            this.btnXemThongTinNV.Click += new System.EventHandler(this.btnXemThongTinNV_Click);
            // 
            // btnBatTatMay
            // 
            this.btnBatTatMay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBatTatMay.BackgroundImage")));
            this.btnBatTatMay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBatTatMay.FlatAppearance.BorderSize = 0;
            this.btnBatTatMay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBatTatMay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBatTatMay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatTatMay.Image = global::QuanLyTiemGame.Properties.Resources.add_user;
            this.btnBatTatMay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBatTatMay.Location = new System.Drawing.Point(396, 87);
            this.btnBatTatMay.Name = "btnBatTatMay";
            this.btnBatTatMay.Size = new System.Drawing.Size(133, 33);
            this.btnBatTatMay.TabIndex = 1;
            this.btnBatTatMay.Text = "Chuyển trạng thái máy";
            this.btnBatTatMay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBatTatMay.UseVisualStyleBackColor = true;
            this.btnBatTatMay.Click += new System.EventHandler(this.btnBatTatMay_Click);
            // 
            // cmbTrangThai
            // 
            this.cmbTrangThai.FormattingEnabled = true;
            this.cmbTrangThai.Items.AddRange(new object[] {
            "Bật ",
            "Tắt"});
            this.cmbTrangThai.Location = new System.Drawing.Point(216, 131);
            this.cmbTrangThai.Name = "cmbTrangThai";
            this.cmbTrangThai.Size = new System.Drawing.Size(108, 23);
            this.cmbTrangThai.TabIndex = 46;
            // 
            // cmbLoaiMay
            // 
            this.cmbLoaiMay.FormattingEnabled = true;
            this.cmbLoaiMay.Items.AddRange(new object[] {
            "Thường",
            "Vip"});
            this.cmbLoaiMay.Location = new System.Drawing.Point(216, 66);
            this.cmbLoaiMay.Name = "cmbLoaiMay";
            this.cmbLoaiMay.Size = new System.Drawing.Size(108, 23);
            this.cmbLoaiMay.TabIndex = 45;
            // 
            // txtMaMay
            // 
            this.txtMaMay.Location = new System.Drawing.Point(216, 33);
            this.txtMaMay.Name = "txtMaMay";
            this.txtMaMay.Size = new System.Drawing.Size(109, 21);
            this.txtMaMay.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 43;
            this.label3.Text = "Mã máy";
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(216, 99);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(108, 21);
            this.txtGiaTien.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(110, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 15);
            this.label10.TabIndex = 41;
            this.label10.Text = "Giá tiền/ giờ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 38;
            this.label1.Text = "Loại máy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Trạng thái";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewMay);
            this.panel1.Location = new System.Drawing.Point(27, 284);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 129);
            this.panel1.TabIndex = 9;
            // 
            // dataGridViewMay
            // 
            this.dataGridViewMay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_may,
            this.loai_may,
            this.gia_tien_mot_gio,
            this.trang_thai});
            this.dataGridViewMay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMay.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMay.Name = "dataGridViewMay";
            this.dataGridViewMay.Size = new System.Drawing.Size(746, 129);
            this.dataGridViewMay.TabIndex = 0;
            this.dataGridViewMay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMay_CellClick);
            // 
            // ma_may
            // 
            this.ma_may.DataPropertyName = "ma_may";
            this.ma_may.HeaderText = "Mã máy";
            this.ma_may.MinimumWidth = 7;
            this.ma_may.Name = "ma_may";
            this.ma_may.Width = 150;
            // 
            // loai_may
            // 
            this.loai_may.DataPropertyName = "loai_may";
            this.loai_may.HeaderText = "Loại máy";
            this.loai_may.MinimumWidth = 7;
            this.loai_may.Name = "loai_may";
            this.loai_may.Width = 150;
            // 
            // gia_tien_mot_gio
            // 
            this.gia_tien_mot_gio.DataPropertyName = "gia_tien_mot_gio";
            this.gia_tien_mot_gio.HeaderText = "Giá tiền một giờ";
            this.gia_tien_mot_gio.Name = "gia_tien_mot_gio";
            this.gia_tien_mot_gio.Width = 150;
            // 
            // trang_thai
            // 
            this.trang_thai.DataPropertyName = "trang_thai";
            this.trang_thai.HeaderText = "Trạng thái";
            this.trang_thai.Name = "trang_thai";
            this.trang_thai.Width = 150;
            // 
            // fTableMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "fTableMay";
            this.Text = "fTableMay";
            this.Load += new System.EventHandler(this.fTableMay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaMay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnXemThongTinNV;
        private System.Windows.Forms.Button btnBatTatMay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewMay;
        private System.Windows.Forms.ComboBox cmbTrangThai;
        private System.Windows.Forms.ComboBox cmbLoaiMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_may;
        private System.Windows.Forms.DataGridViewTextBoxColumn loai_may;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia_tien_mot_gio;
        private System.Windows.Forms.DataGridViewTextBoxColumn trang_thai;
    }
}