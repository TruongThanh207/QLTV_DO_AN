using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.GUI
{
    public partial class PrintBCSachTraTre : Form
    {
        string ngayBC, ma;
        public PrintBCSachTraTre(string ma, string ngay)
        {
            InitializeComponent();
            ngayBC = ngay;
            this.ma = ma;
        }

        private void documentViewer1_Load(object sender, EventArgs e)
        {

        }

        private void PrintBCSachTraTre_Load(object sender, EventArgs e)
        {

            RPSachTraTre report = new RPSachTraTre();
            report.Parameters["ma"].Value = ma;
            report.Parameters["ma"].Visible = false;
            report.Parameters["Ngay"].Value = ngayBC;
            report.Parameters["Ngay"].Visible = false;
            documentViewer1.DocumentSource = report;
            report.CreateDocument();

        }
    }
}
