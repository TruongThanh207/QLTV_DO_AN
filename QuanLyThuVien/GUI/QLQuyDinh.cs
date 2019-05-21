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
using QuanLyThuVien.DTO;

namespace QuanLyThuVien.GUI
{
    public partial class QLQuyDinh : DevExpress.XtraEditors.XtraUserControl
    {
        public QLQuyDinh()
        {
            InitializeComponent();
            ThamSoDTO thamso = ThamSoBLL.Instance.ShowThamSo();
            txtTuoiToiThieu.Text = thamso.TuoiToiThieu.ToString();
            txtTuoiToiDa.Text = thamso.TuoiToiDa.ToString();
            txtTienPhatMotNgay.Text = thamso.TienPhatMotNgay.ToString();
            txtThoiHanThe.Text = thamso.ThoiHanThe.ToString();
            txtThoiHanMuonToiDa.Text = thamso.ThoiGianMuonToiDa.ToString();
            txtSoSachMuonToiDa.Text = thamso.SoSachMuonToiDa.ToString();
            txtDKNhanSach.Text = thamso.DieuKienNhanSach.ToString();
            txtSoLuongTGToiDa.Text = thamso.SoLuongTGToiDa.ToString();

            txtTuoiToiThieu.ReadOnly = true;
            txtTuoiToiDa.ReadOnly = true;
            txtTienPhatMotNgay.ReadOnly = true;
            txtThoiHanThe.ReadOnly = true;
            txtThoiHanMuonToiDa.ReadOnly = true;
            txtSoSachMuonToiDa.ReadOnly = true;
            txtDKNhanSach.ReadOnly = true;
            txtSoLuongTGToiDa.ReadOnly = true;
            btnLuu.Enabled = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtTuoiToiThieu.ReadOnly = false;
            txtTuoiToiDa.ReadOnly = false;
            txtTienPhatMotNgay.ReadOnly = false;
            txtThoiHanThe.ReadOnly = false;
            txtThoiHanMuonToiDa.ReadOnly = false;
            txtSoSachMuonToiDa.ReadOnly = false;
            txtDKNhanSach.ReadOnly = false;
            txtSoLuongTGToiDa.ReadOnly = false;
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ret = ThamSoBLL.Instance.UpdateThamSo(txtTuoiToiDa.Text, txtTuoiToiThieu.Text, txtThoiHanThe.Text, txtSoLuongTGToiDa.Text, txtDKNhanSach.Text, txtSoSachMuonToiDa.Text, txtThoiHanMuonToiDa.Text, txtTienPhatMotNgay.Text);
            if(ret == "Sửa thành công!")
            {
                txtTuoiToiThieu.ReadOnly = true;
                txtTuoiToiDa.ReadOnly = true;
                txtTienPhatMotNgay.ReadOnly = true;
                txtThoiHanThe.ReadOnly = true;
                txtThoiHanMuonToiDa.ReadOnly = true;
                txtSoSachMuonToiDa.ReadOnly = true;
                txtDKNhanSach.ReadOnly = true;
                txtSoLuongTGToiDa.ReadOnly = true;
                btnLuu.Enabled = false;
            }
            MessageBox.Show(ret, "Thông báo", MessageBoxButtons.OK);
        }
    }
}
