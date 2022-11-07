
namespace QuanLyCafe
{
    partial class fTableManager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lv_Bill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Menu = new System.Windows.Forms.Button();
            this.ptB_monDangChon = new System.Windows.Forms.PictureBox();
            this.txt_priceMonDangChon = new System.Windows.Forms.Label();
            this.tb_totalPrice = new System.Windows.Forms.TextBox();
            this.nm_disCount = new System.Windows.Forms.NumericUpDown();
            this.btn_swicthTable = new System.Windows.Forms.Button();
            this.cb_switchTable = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_disCount = new System.Windows.Forms.Button();
            this.btn_check = new System.Windows.Forms.Button();
            this.nm_foodCount = new System.Windows.Forms.NumericUpDown();
            this.btn_addFood = new System.Windows.Forms.Button();
            this.cb_Food = new System.Windows.Forms.ComboBox();
            this.cb_Category = new System.Windows.Forms.ComboBox();
            this.flp_Talble = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptB_monDangChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_disCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_foodCount)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thoongToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1213, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thoongToolStripMenuItem
            // 
            this.thoongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thoongToolStripMenuItem.Name = "thoongToolStripMenuItem";
            this.thoongToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.thoongToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.lv_Bill);
            this.panel2.Controls.Add(this.btn_Menu);
            this.panel2.Controls.Add(this.ptB_monDangChon);
            this.panel2.Controls.Add(this.txt_priceMonDangChon);
            this.panel2.Location = new System.Drawing.Point(656, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(545, 424);
            this.panel2.TabIndex = 2;
            // 
            // lv_Bill
            // 
            this.lv_Bill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lv_Bill.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_Bill.GridLines = true;
            this.lv_Bill.HideSelection = false;
            this.lv_Bill.Location = new System.Drawing.Point(0, 0);
            this.lv_Bill.Name = "lv_Bill";
            this.lv_Bill.Size = new System.Drawing.Size(545, 198);
            this.lv_Bill.TabIndex = 0;
            this.lv_Bill.UseCompatibleStateImageBehavior = false;
            this.lv_Bill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên đồ uống";
            this.columnHeader1.Width = 127;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 116;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 144;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 197;
            // 
            // btn_Menu
            // 
            this.btn_Menu.BackColor = System.Drawing.Color.Brown;
            this.btn_Menu.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Menu.ForeColor = System.Drawing.Color.White;
            this.btn_Menu.Location = new System.Drawing.Point(461, 365);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(81, 56);
            this.btn_Menu.TabIndex = 9;
            this.btn_Menu.Text = "Menu";
            this.btn_Menu.UseVisualStyleBackColor = false;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // ptB_monDangChon
            // 
            this.ptB_monDangChon.Location = new System.Drawing.Point(87, 168);
            this.ptB_monDangChon.Name = "ptB_monDangChon";
            this.ptB_monDangChon.Size = new System.Drawing.Size(299, 286);
            this.ptB_monDangChon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptB_monDangChon.TabIndex = 7;
            this.ptB_monDangChon.TabStop = false;
            // 
            // txt_priceMonDangChon
            // 
            this.txt_priceMonDangChon.AutoSize = true;
            this.txt_priceMonDangChon.Location = new System.Drawing.Point(403, 274);
            this.txt_priceMonDangChon.Name = "txt_priceMonDangChon";
            this.txt_priceMonDangChon.Size = new System.Drawing.Size(0, 17);
            this.txt_priceMonDangChon.TabIndex = 8;
            // 
            // tb_totalPrice
            // 
            this.tb_totalPrice.Location = new System.Drawing.Point(945, 631);
            this.tb_totalPrice.Name = "tb_totalPrice";
            this.tb_totalPrice.ReadOnly = true;
            this.tb_totalPrice.Size = new System.Drawing.Size(114, 22);
            this.tb_totalPrice.TabIndex = 3;
            this.tb_totalPrice.Text = "0";
            this.tb_totalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nm_disCount
            // 
            this.nm_disCount.Location = new System.Drawing.Point(808, 631);
            this.nm_disCount.Name = "nm_disCount";
            this.nm_disCount.Size = new System.Drawing.Size(114, 22);
            this.nm_disCount.TabIndex = 2;
            this.nm_disCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_swicthTable
            // 
            this.btn_swicthTable.BackColor = System.Drawing.Color.Brown;
            this.btn_swicthTable.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_swicthTable.ForeColor = System.Drawing.Color.White;
            this.btn_swicthTable.Location = new System.Drawing.Point(663, 586);
            this.btn_swicthTable.Name = "btn_swicthTable";
            this.btn_swicthTable.Size = new System.Drawing.Size(114, 36);
            this.btn_swicthTable.TabIndex = 1;
            this.btn_swicthTable.Text = "Chuyển bàn";
            this.btn_swicthTable.UseVisualStyleBackColor = false;
            this.btn_swicthTable.Click += new System.EventHandler(this.btn_swicthTable_Click);
            // 
            // cb_switchTable
            // 
            this.cb_switchTable.FormattingEnabled = true;
            this.cb_switchTable.Location = new System.Drawing.Point(665, 628);
            this.cb_switchTable.Name = "cb_switchTable";
            this.cb_switchTable.Size = new System.Drawing.Size(112, 24);
            this.cb_switchTable.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(943, 586);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tổng";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_disCount
            // 
            this.btn_disCount.BackColor = System.Drawing.Color.Brown;
            this.btn_disCount.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_disCount.ForeColor = System.Drawing.Color.White;
            this.btn_disCount.Location = new System.Drawing.Point(806, 586);
            this.btn_disCount.Name = "btn_disCount";
            this.btn_disCount.Size = new System.Drawing.Size(114, 36);
            this.btn_disCount.TabIndex = 1;
            this.btn_disCount.Text = "Giảm giá(%)";
            this.btn_disCount.UseVisualStyleBackColor = false;
            // 
            // btn_check
            // 
            this.btn_check.BackColor = System.Drawing.Color.Brown;
            this.btn_check.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_check.ForeColor = System.Drawing.Color.White;
            this.btn_check.Location = new System.Drawing.Point(1083, 586);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(114, 67);
            this.btn_check.TabIndex = 1;
            this.btn_check.Text = "Thanh toán";
            this.btn_check.UseVisualStyleBackColor = false;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // nm_foodCount
            // 
            this.nm_foodCount.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nm_foodCount.Location = new System.Drawing.Point(1011, 98);
            this.nm_foodCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nm_foodCount.Name = "nm_foodCount";
            this.nm_foodCount.Size = new System.Drawing.Size(66, 33);
            this.nm_foodCount.TabIndex = 2;
            this.nm_foodCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_addFood
            // 
            this.btn_addFood.BackColor = System.Drawing.Color.Brown;
            this.btn_addFood.Font = new System.Drawing.Font("Tw Cen MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addFood.ForeColor = System.Drawing.Color.White;
            this.btn_addFood.Location = new System.Drawing.Point(1083, 53);
            this.btn_addFood.Name = "btn_addFood";
            this.btn_addFood.Size = new System.Drawing.Size(114, 78);
            this.btn_addFood.TabIndex = 1;
            this.btn_addFood.Text = "THÊM MÓN";
            this.btn_addFood.UseVisualStyleBackColor = false;
            this.btn_addFood.Click += new System.EventHandler(this.btn_addFood_Click);
            // 
            // cb_Food
            // 
            this.cb_Food.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Food.FormattingEnabled = true;
            this.cb_Food.Location = new System.Drawing.Point(659, 98);
            this.cb_Food.Name = "cb_Food";
            this.cb_Food.Size = new System.Drawing.Size(344, 33);
            this.cb_Food.TabIndex = 0;
            this.cb_Food.Enter += new System.EventHandler(this.cb_Food_Enter);
            // 
            // cb_Category
            // 
            this.cb_Category.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Category.FormattingEnabled = true;
            this.cb_Category.Location = new System.Drawing.Point(660, 52);
            this.cb_Category.Name = "cb_Category";
            this.cb_Category.Size = new System.Drawing.Size(344, 33);
            this.cb_Category.TabIndex = 0;
            this.cb_Category.SelectedIndexChanged += new System.EventHandler(this.cb_Category_SelectedIndexChanged);
            // 
            // flp_Talble
            // 
            this.flp_Talble.AutoScroll = true;
            this.flp_Talble.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.flp_Talble.BackgroundImage = global::QuanLyCafe.Properties.Resources.Picture31;
            this.flp_Talble.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flp_Talble.Location = new System.Drawing.Point(39, 52);
            this.flp_Talble.Name = "flp_Talble";
            this.flp_Talble.Size = new System.Drawing.Size(575, 588);
            this.flp_Talble.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(39, 626);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(575, 26);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Vui lòng chọn bàn, chọn đồ uống và click \"THÊM MÓN\"";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.BackgroundImage = global::QuanLyCafe.Properties.Resources.back4;
            this.ClientSize = new System.Drawing.Size(1213, 678);
            this.Controls.Add(this.nm_foodCount);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_addFood);
            this.Controls.Add(this.tb_totalPrice);
            this.Controls.Add(this.cb_Food);
            this.Controls.Add(this.nm_disCount);
            this.Controls.Add(this.cb_Category);
            this.Controls.Add(this.btn_swicthTable);
            this.Controls.Add(this.cb_switchTable);
            this.Controls.Add(this.flp_Talble);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_disCount);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mền quản lý quán Cà phê";
            this.Load += new System.EventHandler(this.fTableManager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptB_monDangChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_disCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_foodCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lv_Bill;
        private System.Windows.Forms.ComboBox cb_Category;
        private System.Windows.Forms.NumericUpDown nm_disCount;
        private System.Windows.Forms.Button btn_swicthTable;
        private System.Windows.Forms.ComboBox cb_switchTable;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.NumericUpDown nm_foodCount;
        private System.Windows.Forms.ComboBox cb_Food;
        private System.Windows.Forms.FlowLayoutPanel flp_Talble;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox tb_totalPrice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_disCount;
        private System.Windows.Forms.PictureBox ptB_monDangChon;
        private System.Windows.Forms.Label txt_priceMonDangChon;
        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_addFood;
    }
}