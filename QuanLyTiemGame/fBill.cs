using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace QuanLyTiemGame
{
    public partial class fBill : Form
    {
        public fBill()
        {
            InitializeComponent();
        }

        private void fBill_Load(object sender, EventArgs e)
        {

            this.reportViewerBill.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            try
            {
                reportViewerBill.LocalReport.ReportEmbeddedResource = "QuanLyTiemGame.ReportBill.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource();
                //reportDataSource.Name = "dataset.DataSet1";
               // reportDataSource.Value = db.NhanVientheoMaNV(maNV);
                //reportViewerBill.LocalReport.DataSources.Add(reportDataSource);

                this.reportViewerBill.RefreshReport();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
