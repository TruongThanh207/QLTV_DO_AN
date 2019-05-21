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
    public partial class BCSachTraTre : DevExpress.XtraEditors.XtraUserControl
    {
        private static BCSachTraTre _instance;
        public static BCSachTraTre Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BCSachTraTre();
                return _instance;
            }
        }
        public BCSachTraTre()
        {
            InitializeComponent();
            btnLapBaoCao.Enabled = false;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            btnLapBaoCao.Enabled = true;
            DataTable data = new DataTable();
            string maBCSTT = BaoCaoSachTraTreBLL.Instance.GetMaBCSTTTheoTime(Convert.ToDateTime(dtNgayBC.Text));
            if (maBCSTT != "")
            {
                txtMaBC.Text = maBCSTT;
                data = BaoCaoSachTraTreBLL.Instance.ShowCTBaoCaoSachTraTre(txtMaBC.Text);
            }
            else
            {
                //tạo mã báo cáo với tháng = this
                txtMaBC.Text = Utilities.Instance.NextID("BC", BaoCaoTheoTheLoaiBLL.Instance.GetLastMaBC());


                string message = BaoCaoSachTraTreBLL.Instance.SaveBaoCaoSachTraTre(txtMaBC.Text, dtNgayBC.Text);

                if (message != "OK")
                {
                    MessageBox.Show(message);
                }
                else
                {
                    data = BaoCaoSachTraTreBLL.Instance.ShowCTBaoCaoSachTraTre(txtMaBC.Text);
                }
            }
            gridCTBCSachTT.DataSource = data;
        }

        private void dtNgayBC_ValueChanged(object sender, EventArgs e)
        {
            txtMaBC.Text = "";
        }

        private void btnLapBaoCao_Click(object sender, EventArgs e)
        {
            PrintBCSachTraTre frmPrint = new PrintBCSachTraTre(txtMaBC.Text, dtNgayBC.Text);
            frmPrint.ShowDialog();
        }
    }
}
