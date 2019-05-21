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
using QuanLyThuVien.DTO;
using QuanLyThuVien.BLL;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace QuanLyThuVien
{
    public partial class QLTra : DevExpress.XtraEditors.XtraUserControl
    {
        private static QLTra _instance;

        public static QLTra Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new QLTra();
                return _instance;
            }
        }

        int flag;
        GridControl gridCTPhieuMuon;
        GridView grvCTPM;
        public QLTra()
        {
            InitializeComponent();
            ShowPhieuTra();
            flag = 1;
            cbMaDG.DataSource = DocGiaBLL.Instance.ShowDocGiaToCombobox();
            cbMaDG.DisplayMember = "Mã DG";
            cbMaDG.ValueMember = "Tên DG";
            txtTenDG.Text = cbMaDG.SelectedValue.ToString();
            btnThemsach.Enabled = false;
            btnXoasach.Enabled = false;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
        }

        public void ShowPhieuTra()
        {
            List<PhieuTraDTO> listPT = PhieuTraBLL.Instance.ShowPhieuTra();
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã phiếu trả");
            dt.Columns.Add("Mã phiếu mượn");
            dt.Columns.Add("Mã đọc giả");
            dt.Columns.Add("Ngày trả");
            dt.Columns.Add("Mã nhân viên");
            dt.Columns.Add("Tiền phạt kỳ này");
            foreach (PhieuTraDTO phieutra in listPT)
            {
                dt.Rows.Add(phieutra.MaPT, phieutra.MaPM, phieutra.MaDG, phieutra.NgayTra.ToString(), phieutra.MaNV, phieutra.TienPhatKyNay.ToString());
            }
            gridTra.DataSource = dt;
            grvTra.ClearSelection();

            //
            PhieuTraDetailBinding();

        }

        public void ShowCTPhieuTra(string MaPT)
        {
            List<CTPhieuTraDTO> listCTPT = PhieuTraBLL.Instance.ShowCTPhieuTraByMaPT(MaPT);
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã sách");
            dt.Columns.Add("Tên sách");
            dt.Columns.Add("Ngày mượn");
            dt.Columns.Add("Số ngày mượn");
            dt.Columns.Add("Tiền phạt");

            foreach (CTPhieuTraDTO ctphieutra in listCTPT)
            {
                dt.Rows.Add(ctphieutra.MaSach, ctphieutra.TenSach, ctphieutra.NgayMuon, ctphieutra.SoNgayMuon, ctphieutra.TienPhat);
            }
            gridCTTra.DataSource = dt;
            grvCTTra.ClearSelection();
        }

        public void PhieuTraDetailBinding()
        {

            if (txtMaPT.DataBindings.Count > 0)
                txtMaPT.DataBindings.RemoveAt(0);
            if (dtNgayTra.DataBindings.Count > 0)
                dtNgayTra.DataBindings.RemoveAt(0);
            if (txtMaNV.DataBindings.Count > 0)
                txtMaNV.DataBindings.RemoveAt(0);
            if (txtTienPhatKyNay.DataBindings.Count > 0)
                txtTienPhatKyNay.DataBindings.RemoveAt(0);

            txtMaPT.DataBindings.Add(new Binding("Text", gridTra.DataSource, "Mã phiếu trả")
            {
                DataSourceUpdateMode = DataSourceUpdateMode.Never,
                ControlUpdateMode = ControlUpdateMode.OnPropertyChanged
            });
            dtNgayTra.DataBindings.Add(new Binding("Value", gridTra.DataSource, "Ngày trả")
            {
                DataSourceUpdateMode = DataSourceUpdateMode.Never,
                ControlUpdateMode = ControlUpdateMode.OnPropertyChanged
            });
            txtTienPhatKyNay.DataBindings.Add(new Binding("Text", gridTra.DataSource, "Tiền phạt kỳ này")
            {
                DataSourceUpdateMode = DataSourceUpdateMode.Never,
                ControlUpdateMode = ControlUpdateMode.OnPropertyChanged
            });

            txtMaNV.DataBindings.Add(new Binding("Text", gridTra.DataSource, "Mã nhân viên")
            {
                DataSourceUpdateMode = DataSourceUpdateMode.Never,
                ControlUpdateMode = ControlUpdateMode.OnPropertyChanged
            });

        }

        private void gridTra_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                //ánh xạ mã đọc giả + tên đọc giả
                cbMaDG.Text = "";
                string MaDG = grvTra.GetRowCellValue(grvTra.FocusedRowHandle, grvTra.Columns[2]).ToString();
                cbMaDG.Text = MaDG;
                txtTenDG.Text = cbMaDG.SelectedValue.ToString();

                //ánh xạ mã phiếu mượn
                cbMaPM.Text = "";
                string MaPM = grvTra.GetRowCellValue(grvTra.FocusedRowHandle, grvTra.Columns[1]).ToString();
                cbMaPM.Text = MaPM;
            }
        }

        private void txtMaPT_TextChanged(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                string t = (sender as TextBox).Text;
                ShowCTPhieuTra(t);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThemsach.Enabled = true;
            btnXoasach.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
            flag = 2;
            // nút xóa => hủy
            btnXoa.Text = "Hủy";

            //Hiển thị CT phiếu mượn
            ClearInput();
            XuLyHienThiGridCTPhieuMuon();

            txtMaPT.Text = Utilities.Instance.NextID("PT", grvTra.GetRowCellValue(grvTra.RowCount - 1, grvTra.Columns[0]).ToString());
        }

        void ClearInput()
        {
            txtMaPT.Text = "";
            txtTenDG.Text = "";
            txtMaNV.Text = "";
            dtNgayTra.Value = DateTime.Now;
            cbMaDG.Text = "Chọn mã đọc giả";
            cbMaPM.Text = "Chọn mã phiếu mượn";
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã sách");
            dt.Columns.Add("Tên sách");
            dt.Columns.Add("Ngày mượn");
            dt.Columns.Add("Số ngày mượn");
            dt.Columns.Add("Tiền phạt");
            gridCTTra.DataSource = dt;
        }

        void XuLyHienThiGridCTPhieuMuon()
        {
            gridTra.Visible = false;
            gridCTPhieuMuon = new GridControl();
            grvCTPM = new GridView(gridCTPhieuMuon);
            gridCTPhieuMuon.ViewCollection.Add(grvCTPM);


            List<CTPhieuMuonDTO> listCTPM = PhieuMuonBLL.Instance.ShowCTPhieuMuonByMaPM(cbMaPM.Text);
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã sách");
            dt.Columns.Add("Tên sách");
            dt.Columns.Add("Thể loại");
            dt.Columns.Add("Tác giả");
            dt.Columns.Add("Tick");
            foreach (CTPhieuMuonDTO ctphieumuon in listCTPM)
            {
                dt.Rows.Add(ctphieumuon.MaSach, ctphieumuon.TenSach, ctphieumuon.TheLoai, ctphieumuon.TacGia, false);
            }
            grvCTPM.OptionsSelection.MultiSelect = true;
            grvCTPM.OptionsBehavior.Editable = false;
            gridCTPhieuMuon.DataSource = dt;
            grvCTPM.ClearSelection();

            gridCTPhieuMuon.MainView = grvCTPM;
            gridCTPhieuMuon.Parent = panel2;
            gridCTPhieuMuon.Dock = DockStyle.Fill;

            panel2.Controls.Add(gridCTPhieuMuon);
        }

        private void cbMaDG_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(flag == 2)
            {
                // đổ vào danh sách mã DG - auto

                // ánh xạ vào tên DG
                txtTenDG.Text = "";
                txtTenDG.Text = cbMaDG.SelectedValue.ToString();

                // đổ vào mã PM theo mã DG
                cbMaPM.Text = "";
                cbMaPM.DataSource = PhieuMuonBLL.Instance.ShowMaPMToComboBox(cbMaDG.Text);
                cbMaPM.DisplayMember = "Mã phiếu mượn";
                cbMaPM.ValueMember = "Ngày mượn";
            }
        }

        private void cbMaPM_SelectedIndexChanged(object sender, EventArgs e)
        {
            // load sách lên grid
            List<CTPhieuMuonDTO> listCTPM = PhieuMuonBLL.Instance.ShowCTPhieuMuonByMaPM(cbMaPM.Text);
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã sách");
            dt.Columns.Add("Tên sách");
            dt.Columns.Add("Thể loại");
            dt.Columns.Add("Tác giả");
            dt.Columns.Add("Tick");
            foreach (CTPhieuMuonDTO ctphieumuon in listCTPM)
            {
                dt.Rows.Add(ctphieumuon.MaSach, ctphieumuon.TenSach, ctphieumuon.TheLoai, ctphieumuon.TacGia, false);
            }
            gridCTPhieuMuon.DataSource = dt;
        }

        private void btnThemsach_Click(object sender, EventArgs e)
        {
            int[] handle = grvCTPM.GetSelectedRows();

            for (int i = 0; i < handle.Length; i++)
            {
                //Kiểm tra tình trạng sách xem sách đã trả chưa
                if (SachBLL.Instance.GetTinhTrangSachByMaSach(grvCTPM.GetRowCellValue(handle[i], grvCTPM.Columns[0]).ToString()))
                    MessageBox.Show(string.Format("Sách có mã {0} đã trả. Mời chọn sách khác!", grvCTPM.GetRowCellValue(handle[i], grvCTPM.Columns[0]).ToString()), "Thông báo", MessageBoxButtons.OK);
                else
                {
                    //nếu sách chưa trả: load ngày mượn
                    if (grvCTPM.GetRowCellValue(handle[i], grvCTPM.Columns[4]).ToString() == "False")
                    {
                        //ngay muon
                        string ngaymuon = cbMaPM.SelectedValue.ToString();                 
                        string masach = grvCTPM.GetRowCellValue(handle[i], grvCTPM.Columns[0]).ToString();
                        string tensach = grvCTPM.GetRowCellValue(handle[i], grvCTPM.Columns[1]).ToString();
                        TimeSpan temp = DateTime.Now - Convert.ToDateTime(ngaymuon);
                        int songaymuon = temp.Days;
                        string tienphat = "";
                        if (songaymuon > 4)
                            tienphat = ((songaymuon - 4) * ThamSoBLL.Instance.GetTienPhatMotNgay()).ToString();
                        else
                            tienphat = "0";
                        grvCTPM.SetRowCellValue(handle[i], grvCTPM.Columns[4], true);
                        CreateNewRow(masach, tensach, ngaymuon, songaymuon.ToString(),tienphat);
                        double tienphatkynay = Convert.ToDouble(txtTienPhatKyNay.Text) + Convert.ToDouble(tienphat);
                        txtTienPhatKyNay.Text = tienphatkynay.ToString();
                    }
                }
            }
        }

        private void CreateNewRow(string val1, string val2, string val3, string val4, string val5)
        {

            //add a new row 
            grvCTTra.AddNewRow();
            //set a new row cell value. The static GridControl.NewItemRowHandle field allows you to retrieve the added row 
            grvCTTra.SetRowCellValue(GridControl.NewItemRowHandle, grvCTTra.Columns[0], val1);
            grvCTTra.SetRowCellValue(GridControl.NewItemRowHandle, grvCTTra.Columns[1], val2);
            grvCTTra.SetRowCellValue(GridControl.NewItemRowHandle, grvCTTra.Columns[2], val3);
            grvCTTra.SetRowCellValue(GridControl.NewItemRowHandle, grvCTTra.Columns[3], val4);
            grvCTTra.SetRowCellValue(GridControl.NewItemRowHandle, grvCTTra.Columns[4], val5);
        }

        private void btnXoasach_Click(object sender, EventArgs e)
        {
            //set Tick = false
            string masach = grvCTTra.GetRowCellValue(grvCTTra.FocusedRowHandle, grvCTTra.Columns[0]).ToString();
            for (int i = 0; i < grvCTPM.RowCount; i++)
            {
                if (masach == grvCTPM.GetRowCellValue(i, grvCTPM.Columns[0]).ToString())
                {
                    grvCTPM.SetRowCellValue(i, grvCTPM.Columns[4], false);
                }

            }
            grvCTTra.DeleteRow(grvCTTra.FocusedRowHandle);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //kiểm tra trường trống
            if (cbMaDG.Text == "Chọn mã đọc giả" || cbMaPM.Text == "Chọn mã phiếu mượn")
            {
                MessageBox.Show("Vui lòng chọn mã đọc giả hoặc mã phiếu mượn!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            //lưu phiếu trả vào CSDL
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã sách");
            dt.Columns.Add("Số ngày mượn");
            dt.Columns.Add("Tiền phạt");

            for (int i=0; i <grvCTTra.RowCount;i++)
            {
                string masach = grvCTTra.GetRowCellValue(grvCTTra.GetRowHandle(i), grvCTTra.Columns[0]).ToString();
                string songaymuon = grvCTTra.GetRowCellValue(grvCTTra.GetRowHandle(i), grvCTTra.Columns[3]).ToString();
                string tienphat = grvCTTra.GetRowCellValue(grvCTTra.GetRowHandle(i), grvCTTra.Columns[4]).ToString();
                dt.Rows.Add(masach, songaymuon, tienphat);
            }
            string ketqua = PhieuTraBLL.Instance.SavePhieuTra(txtMaPT.Text, cbMaPM.Text, cbMaDG.Text, dtNgayTra.Text, txtMaNV.Text, txtTienPhatKyNay.Text, dt);
            //check lại tình trạng phiếu mượn
            if (ketqua == "Thêm phiếu trả thành công!")
            {
                flag = 1;
                PhieuMuonBLL.Instance.SetTinhTrangPhieuMuon(cbMaPM.Text);
                btnXoa.Text = "Xóa";
            }
            MessageBox.Show(ketqua, "Thông báo", MessageBoxButtons.OK);
            gridCTPhieuMuon.Visible = false;
            gridTra.Visible = true;
            ClearInput();
            ShowPhieuTra();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (flag == 2)
            {
                if (MessageBox.Show("Bạn có muốn hủy phiếu trả này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    gridCTPhieuMuon.Visible = false;
                    gridTra.Visible = true;
                    ClearInput();
                    ShowPhieuTra();
                    flag = 1;
                    btnXoa.Text = "Xóa";

                }

            }
        }
    }
}
