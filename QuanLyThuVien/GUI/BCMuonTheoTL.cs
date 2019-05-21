using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyThuVien.BLL;

namespace QuanLyThuVien.GUI
{
    public partial class BCMuonTheoTL : DevExpress.XtraEditors.XtraUserControl
    {
        private static BCMuonTheoTL _instance;
        public static BCMuonTheoTL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BCMuonTheoTL();
                return _instance;
            }
        }
        public BCMuonTheoTL()
        {
            InitializeComponent();
            btnLapBaoCao.Enabled = false;
            //if (!panel2.Controls.Contains(PrintMuonTheoTL.Instance))
            //{
            //    panel2.Controls.Add(PrintMuonTheoTL.Instance);
            //    //tbStatus.Visible = false;
            //    PrintMuonTheoTL.Instance.Dock = DockStyle.Fill;
            //    PrintMuonTheoTL.Instance.BringToFront();
            //}
            //PrintMuonTheoTL.Instance.BringToFront();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // PrintMuonTheoTL.Instance.Print();
            PrintBCMuonTheoTheLoai frmPrint = new PrintBCMuonTheoTheLoai(cbThang.Text, cbNam.Text, txtMaBC.Text);
            frmPrint.ShowDialog();
            
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            btnLapBaoCao.Enabled = true;
            DataTable data = new DataTable();
            string maBCTL = BaoCaoTheoTheLoaiBLL.Instance.GetMaBCTLTheoTime(Convert.ToInt32(cbThang.Text), Convert.ToInt32(cbNam.Text));
            if(maBCTL != "")
            {
                txtMaBC.Text = maBCTL;
                data = BaoCaoTheoTheLoaiBLL.Instance.ShowCTBaoCaoTheoTheLoai(txtMaBC.Text);
            }
            else
            {
                //tạo mã báo cáo với tháng = this
                txtMaBC.Text = Utilities.Instance.NextID("BC", BaoCaoTheoTheLoaiBLL.Instance.GetLastMaBC());

                string message = BaoCaoTheoTheLoaiBLL.Instance.SaveBaoCaoTheoTL(txtMaBC.Text, cbThang.Text, cbNam.Text);
               
                if (message!= "OK")
                {
                    MessageBox.Show(message);
                }
                else
                {
                    data = BaoCaoTheoTheLoaiBLL.Instance.ShowCTBaoCaoTheoTheLoai(txtMaBC.Text);
                }
            }
            gridCTBCTheLoai.DataSource = data;
        }

        private void cbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaBC.Text = "";
        }
    }
}
