
namespace QuanLyTiemGame
{
    partial class Add_foods_image
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ptB_image = new System.Windows.Forms.PictureBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptB_image)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(132, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Browse";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Image = global::QuanLyTiemGame.Properties.Resources.ok;
            this.button1.Location = new System.Drawing.Point(267, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 78);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ptB_image
            // 
            this.ptB_image.BackColor = System.Drawing.Color.Silver;
            this.ptB_image.Location = new System.Drawing.Point(121, 12);
            this.ptB_image.Name = "ptB_image";
            this.ptB_image.Size = new System.Drawing.Size(239, 184);
            this.ptB_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptB_image.TabIndex = 2;
            this.ptB_image.TabStop = false;
            // 
            // btn_browse
            // 
            this.btn_browse.BackColor = System.Drawing.Color.Silver;
            this.btn_browse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_browse.Image = global::QuanLyTiemGame.Properties.Resources.browse;
            this.btn_browse.Location = new System.Drawing.Point(121, 202);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(87, 79);
            this.btn_browse.TabIndex = 1;
            this.btn_browse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_browse.UseVisualStyleBackColor = false;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(293, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "OK";
            // 
            // Add_foods_image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.BackgroundImage = global::QuanLyTiemGame.Properties.Resources.back410;
            this.ClientSize = new System.Drawing.Size(497, 336);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptB_image);
            this.Controls.Add(this.btn_browse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_foods_image";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_foods_image";
            ((System.ComponentModel.ISupportInitialize)(this.ptB_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.PictureBox ptB_image;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}