using Aspose.Words;//Thêm thư viện này (file Dll\Aspose.Word.dll)
using Aspose.Words.Tables;
using System;
using System.Windows.Forms;
using ThuVienWinform.Report.AsposeWordExtension;//thêm thư viện này (File Lib\ReportExtentionMethod.cs)

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

           // this.reportViewerBill.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
          /*  try
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
            }*/
        }

        private void btnXuatBaoCao_Click(object sender, EventArgs e)
        {
        
        }
    }
}
