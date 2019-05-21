using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.Parameters;
namespace QuanLyThuVien.GUI
{
    public partial class PrintBCMuonTheoTheLoai : Form
    {
        string thang, nam, ma;
        public PrintBCMuonTheoTheLoai(string thang, string nam, string ma)
        {
            InitializeComponent();
            this.thang = thang;
            this.nam = nam;
            this.ma = ma;
        }

        private void PrintBCMuonTheoTheLoai_Load(object sender, EventArgs e)
        { 
            RPMuonTheoTL report = new RPMuonTheoTL();
            report.Parameters["ma"].Value = ma;
            report.Parameters["ma"].Visible = false;
            report.Parameters["nam"].Value = nam;
            report.Parameters["nam"].Visible = false;
            report.Parameters["thang"].Value = thang;
            report.Parameters["thang"].Visible = false;
            documentViewer1.DocumentSource = report;            
            report.CreateDocument();
        }

    }
}
