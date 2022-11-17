
namespace QuanLyCafe
{
    partial class fChiTietHoaDon
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
            this.dtgv_ChiTietHoaDon = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ChiTietHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_ChiTietHoaDon
            // 
            this.dtgv_ChiTietHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_ChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ChiTietHoaDon.Location = new System.Drawing.Point(41, 22);
            this.dtgv_ChiTietHoaDon.Name = "dtgv_ChiTietHoaDon";
            this.dtgv_ChiTietHoaDon.RowHeadersWidth = 51;
            this.dtgv_ChiTietHoaDon.RowTemplate.Height = 24;
            this.dtgv_ChiTietHoaDon.Size = new System.Drawing.Size(760, 272);
            this.dtgv_ChiTietHoaDon.TabIndex = 0;
            // 
            // fChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 362);
            this.Controls.Add(this.dtgv_ChiTietHoaDon);
            this.Name = "fChiTietHoaDon";
            this.Text = "fChiTietHoaDon";
            this.Load += new System.EventHandler(this.fChiTietHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ChiTietHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_ChiTietHoaDon;
    }
}