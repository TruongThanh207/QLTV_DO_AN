using DevExpress.XtraBars;
using QuanLyThuVien.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class frmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void tileBarItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {

        }

        private void aceQLSach_Click(object sender, EventArgs e)
        {
            QLSach qlSach = new QLSach();
            containerMain.Controls.Add(qlSach);
            tbStatus.Visible = false;
            qlSach.Dock = DockStyle.Fill;
            qlSach.BringToFront();
        }

        private void aceQLTheLoai_Click(object sender, EventArgs e)
        {
            QLTheLoai qlTheLoai = new QLTheLoai();
            containerMain.Controls.Add(qlTheLoai);
            tbStatus.Visible = false;
            qlTheLoai.Dock = DockStyle.Fill;
            qlTheLoai.BringToFront();
        }

   
        private void aceQLDocGia_Click(object sender, EventArgs e)
        {
            QLDocGia qlDocGia = new QLDocGia();
            containerMain.Controls.Add(qlDocGia);
            tbStatus.Visible = false;
            qlDocGia.Dock = DockStyle.Fill;
            qlDocGia.BringToFront();
        }

        private void aceQLTacGia_Click(object sender, EventArgs e)
        {
            QLTacGia qlTacGia = new QLTacGia();
            containerMain.Controls.Add(qlTacGia);
            tbStatus.Visible = false;
            qlTacGia.Dock = DockStyle.Fill;
            qlTacGia.BringToFront();
        }

        private void aceQLMuon_Click(object sender, EventArgs e)
        {
            QLMuon qlMuon = new QLMuon();
            containerMain.Controls.Add(qlMuon);
            tbStatus.Visible = false;
            qlMuon.Dock = DockStyle.Fill;
            qlMuon.BringToFront();
        }

        private void aceQLTra_Click(object sender, EventArgs e)
        {
            QLTra qlTra = new QLTra();
            containerMain.Controls.Add(qlTra);
            tbStatus.Visible = false;
            qlTra.Dock = DockStyle.Fill;
            qlTra.BringToFront();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void aceMuonTheoTL_Click(object sender, EventArgs e)
        {
            BCMuonTheoTL bcMuonTheoTL = new BCMuonTheoTL();
            containerMain.Controls.Add(bcMuonTheoTL);
            tbStatus.Visible = false;
            bcMuonTheoTL.Dock = DockStyle.Fill;
            bcMuonTheoTL.BringToFront();
        }

        private void aceSachTraTre_Click(object sender, EventArgs e)
        {
            BCSachTraTre bcSachTraTre = new BCSachTraTre();
            containerMain.Controls.Add(bcSachTraTre);
            tbStatus.Visible = false;
            bcSachTraTre.Dock = DockStyle.Fill;
            bcSachTraTre.BringToFront();
        }

        private void aceQLNhanVien_Click(object sender, EventArgs e)
        {
            QLNhanVien qlNhanVien = new QLNhanVien();
            containerMain.Controls.Add(qlNhanVien);
            tbStatus.Visible = false;
            qlNhanVien.Dock = DockStyle.Fill;
            qlNhanVien.BringToFront();
        }

        private void aceQuyDinh_Click(object sender, EventArgs e)
        {
            QLQuyDinh qlQuyDinh = new QLQuyDinh();
            containerMain.Controls.Add(qlQuyDinh);
            tbStatus.Visible = false;
            qlQuyDinh.Dock = DockStyle.Fill;
            qlQuyDinh.BringToFront();
        }


        private void aceThongTinCaNhan_Click(object sender, EventArgs e)
        {
            ThongTinCaNhan info = new ThongTinCaNhan();
            containerMain.Controls.Add(info);
            tbStatus.Visible = false;
            info.Dock = DockStyle.Fill;
            info.BringToFront();
        }

        private void aceQLPhatTien_Click(object sender, EventArgs e)
        {
            QLPhat qlPhat = new QLPhat();
            containerMain.Controls.Add(qlPhat);
            tbStatus.Visible = false;
            qlPhat.Dock = DockStyle.Fill;
            qlPhat.BringToFront();
        }

        private void aceQLLoaiDG_Click(object sender, EventArgs e)
        {
            QLLoaiDG qlLoaiDG = new QLLoaiDG();
            containerMain.Controls.Add(qlLoaiDG);
            tbStatus.Visible = false;
            qlLoaiDG.Dock = DockStyle.Fill;
            qlLoaiDG.BringToFront();
        }
    }
}
