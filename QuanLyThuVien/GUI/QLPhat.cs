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
    public partial class QLPhat : DevExpress.XtraEditors.XtraUserControl
    {
        int flag = 0;
        public QLPhat()
        {
            InitializeComponent();
            ShowPhieuPhat();
            cbMaDG.DataSource = DocGiaBLL.Instance.ShowDocGiaToCombobox();
            cbMaDG.DisplayMember = "Mã DG";
            cbMaDG.ValueMember = "Tên DG";
            txtTenDG.Text = cbMaDG.SelectedValue.ToString();
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            txtMaPP.ReadOnly = true;
            txtMaNV.ReadOnly = true;
            cbMaDG.Enabled = false;
            txtTenDG.ReadOnly = true;
            txtTienThu.ReadOnly = true;
            txtTienConLai.ReadOnly = true;
        }

        public void ShowPhieuPhat()
        {
            List<PhieuPhatDTO> listPP = PhieuPhatBLL.Instance.ShowPhieuPhat();
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã phiếu phạt");
            dt.Columns.Add("Mã đọc giả");
            dt.Columns.Add("Số tiền thu");
            dt.Columns.Add("Còn lại");
            dt.Columns.Add("Mã nhân viên");
            foreach (PhieuPhatDTO phieuphat in listPP)
            {
                dt.Rows.Add(phieuphat.MaPP, phieuphat.MaDG, phieuphat.SoTienThu.ToString(), phieuphat.ConLai.ToString(), phieuphat.MaNV);
            }
            gridPhat.DataSource = dt;
            grvPhat.ClearSelection();

            //
            PhieuPhatDetailBinding();
        }

        public void PhieuPhatDetailBinding()
        {

            if (txtMaPP.DataBindings.Count > 0)
                txtMaPP.DataBindings.RemoveAt(0);
            if (txtTienThu.DataBindings.Count > 0)
                txtTienThu.DataBindings.RemoveAt(0);
            if (txtTienConLai.DataBindings.Count > 0)
                txtTienConLai.DataBindings.RemoveAt(0);
            if (txtMaNV.DataBindings.Count > 0)
                txtMaNV.DataBindings.RemoveAt(0);

            txtMaPP.DataBindings.Add(new Binding("Text", gridPhat.DataSource, "Mã phiếu phạt")
            {
                DataSourceUpdateMode = DataSourceUpdateMode.Never,
                ControlUpdateMode = ControlUpdateMode.OnPropertyChanged
            });
            txtTienThu.DataBindings.Add(new Binding("Text", gridPhat.DataSource, "Số tiền thu")
            {
                DataSourceUpdateMode = DataSourceUpdateMode.Never,
                ControlUpdateMode = ControlUpdateMode.OnPropertyChanged
            });
            txtTienConLai.DataBindings.Add(new Binding("Text", gridPhat.DataSource, "Còn lại")
            {
                DataSourceUpdateMode = DataSourceUpdateMode.Never,
                ControlUpdateMode = ControlUpdateMode.OnPropertyChanged
            });

            txtMaNV.DataBindings.Add(new Binding("Text", gridPhat.DataSource, "Mã nhân viên")
            {
                DataSourceUpdateMode = DataSourceUpdateMode.Never,
                ControlUpdateMode = ControlUpdateMode.OnPropertyChanged
            });

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //generate mã
            if(grvPhat.RowCount < 1)
            {
                txtMaPP.Text =  Utilities.Instance.NextID("PP", "PP000");
            }
            else
            {
                txtMaPP.Text = Utilities.Instance.NextID("PP", grvPhat.GetRowCellValue(grvPhat.RowCount - 1, grvPhat.Columns[0]).ToString());
            }
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            txtMaPP.ReadOnly = true;
            txtMaNV.ReadOnly = true;
            cbMaDG.Enabled = true;
            txtTenDG.ReadOnly = true;
            txtTienThu.ReadOnly = false;
            txtTienConLai.ReadOnly = true;
            // xóa input
            txtTenDG.Text = txtTienConLai.Text = txtTienThu.Text = "";
            cbMaDG.Text = "Chọn mã đọc giả";
            flag = 1;
            btnXoa.Text = "Hủy";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ret = PhieuPhatBLL.Instance.SavePhieuPhat(txtMaPP.Text, cbMaDG.Text, txtTienThu.Text, txtTienConLai.Text, txtMaNV.Text);
            MessageBox.Show(ret, "Thông báo", MessageBoxButtons.OK);
            ShowPhieuPhat();
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            txtMaPP.ReadOnly = true;
            txtMaNV.ReadOnly = true;
            cbMaDG.Enabled = false;
            txtTenDG.ReadOnly = true;
            txtTienThu.ReadOnly = true;
            txtTienConLai.ReadOnly = true;
            flag = 0;
            btnXoa.Text = "Xóa";
        }

        private void cbMaDG_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenDG.Text = "";
            txtTenDG.Text = cbMaDG.SelectedValue.ToString();
        }

        private void gridPhat_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;
            btnXoa.Text = "Xóa";
            cbMaDG.Text = "";
            string MaDG = grvPhat.GetRowCellValue(grvPhat.FocusedRowHandle, grvPhat.Columns[1]).ToString();
            cbMaDG.Text = MaDG;
            txtTenDG.Text = cbMaDG.SelectedValue.ToString();
        }

        private void txtTienThu_TextChanged(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                double TongNo = DocGiaBLL.Instance.LoadTongNo(cbMaDG.Text);
                if (TongNo < 0)
                {
                    MessageBox.Show("Có lỗi xảy ra vui lòng thử lại!");
                }
                else
                {
                    txtTienConLai.Text = (TongNo - Convert.ToDouble(txtTienThu.Text)).ToString();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                if (MessageBox.Show("Bạn có muốn hủy phiếu phạt này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {            
                    ShowPhieuPhat();
                    flag = 0;
                    btnXoa.Text = "Xóa";
                    txtMaPP.Text = "";
                    cbMaDG.Text = "Chọn mã đọc giả";
                    txtTenDG.Text = "";
                    txtTienThu.Text = "";
                    txtTienConLai.Text = "";
                }

            }
            else
            {
                if (MessageBox.Show("Bạn có muốn xóa phiếu phạt này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string ret = PhieuPhatBLL.Instance.DeletePhieuPhat(txtMaPP.Text, cbMaDG.Text, txtTienThu.Text);
                    MessageBox.Show(ret, "Thông báo", MessageBoxButtons.OK);
                    ShowPhieuPhat();
                    btnLuu.Enabled = false;
                    btnXoa.Enabled = false;
                    txtMaPP.ReadOnly = true;
                    txtMaNV.ReadOnly = true;
                    cbMaDG.Enabled = false;
                    txtTenDG.ReadOnly = true;
                    txtTienThu.ReadOnly = true;
                    txtTienConLai.ReadOnly = true;
                }
            }
        }
    }
}
