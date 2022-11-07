
namespace QuanLyCafe
{
    partial class Foods
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
            this.flp_DanhSachDoUong = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flp_DanhSachDoUong
            // 
            this.flp_DanhSachDoUong.AutoScroll = true;
            this.flp_DanhSachDoUong.Location = new System.Drawing.Point(72, 35);
            this.flp_DanhSachDoUong.Name = "flp_DanhSachDoUong";
            this.flp_DanhSachDoUong.Size = new System.Drawing.Size(822, 618);
            this.flp_DanhSachDoUong.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::QuanLyCafe.Properties.Resources.cancel_48px;
            this.pictureBox1.Location = new System.Drawing.Point(920, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Foods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.BackgroundImage = global::QuanLyCafe.Properties.Resources.back4;
            this.ClientSize = new System.Drawing.Size(967, 688);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flp_DanhSachDoUong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Foods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Foods";
            this.Load += new System.EventHandler(this.Foods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_DanhSachDoUong;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}