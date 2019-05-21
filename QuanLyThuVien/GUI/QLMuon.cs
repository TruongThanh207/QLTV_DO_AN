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
    public partial class QLMuon : DevExpress.XtraEditors.XtraUserControl
    {
        private static QLMuon _instance;
        //1: phieu muon
        //2: sach
        int flag = 1;
        GridControl gridSach;
        GridView grvSach;
        public static QLMuon Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new QLMuon();
                return _instance;
            }
        }
        public QLMuon()
        {
            InitializeComponent();

            ShowPhieuMuon();
            cbMaDG.DataSource = DocGiaBLL.Instance.ShowDocGiaToCombobox();
            cbMaDG.DisplayMember = "Mã DG";
            cbMaDG.ValueMember = "Tên DG";
            txtTenDG.Text = cbMaDG.SelectedValue.ToString();
            btnThemsach.Enabled = false;
            btnXoasach.Enabled = false;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
        }

        public void ShowPhieuMuon()
        {
            List<PhieuMuonDTO> listPM = PhieuMuonBLL.Instance.ShowPhieuMuon();
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã phiếu mượn");
            dt.Columns.Add("Mã đọc giả");
            dt.Columns.Add("Ngày mượn");
            dt.Columns.Add("Mã nhân viên");
            dt.Columns.Add("Hạn trả");
            foreach (PhieuMuonDTO phieumuon in listPM)
            {
                dt.Rows.Add(phieumuon.MaPM, phieumuon.MaDG, phieumuon.NgayMuon.ToString(), phieumuon.MaNV, phieumuon.HanTra.ToString());
            }
            gridMuon.DataSource = dt;
            grvMuon.ClearSelection();

            //
            PhieuMuonDetailBinding();

        }

        public void ShowCTPhieuMuon(string MaPM)
        {
            List<CTPhieuMuonDTO> listCTPM = PhieuMuonBLL.Instance.ShowCTPhieuMuonByMaPM(MaPM);
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã sách");
            dt.Columns.Add("Tên sách");
            dt.Columns.Add("Thể loại");
            dt.Columns.Add("Tác giả");
            foreach (CTPhieuMuonDTO ctphieumuon in listCTPM)
            {
                dt.Rows.Add(ctphieumuon.MaSach, ctphieumuon.TenSach, ctphieumuon.TheLoai, ctphieumuon.TacGia);
            }
            gridCTMuon.DataSource = dt;
            grvCTMuon.ClearSelection();
        }

        public void PhieuMuonDetailBinding()
        {
 
            if(txtMaPM.DataBindings.Count > 0)
                txtMaPM.DataBindings.RemoveAt(0);
            if (dtNgayMuon.DataBindings.Count > 0)
                dtNgayMuon.DataBindings.RemoveAt(0);
            if (dtHanTra.DataBindings.Count > 0)
                dtHanTra.DataBindings.RemoveAt(0);
            if (txtMaNV.DataBindings.Count > 0)
                txtMaNV.DataBindings.RemoveAt(0);

            txtMaPM.DataBindings.Add(new Binding("Text", gridMuon.DataSource, "Mã phiếu mượn")
            {
                DataSourceUpdateMode = DataSourceUpdateMode.Never,
                ControlUpdateMode = ControlUpdateMode.OnPropertyChanged
            });
            dtNgayMuon.DataBindings.Add(new Binding("Value", gridMuon.DataSource, "Ngày mượn")
            {
                DataSourceUpdateMode = DataSourceUpdateMode.Never,
                ControlUpdateMode = ControlUpdateMode.OnPropertyChanged
            });
            dtHanTra.DataBindings.Add(new Binding("Value", gridMuon.DataSource, "Hạn trả")
            {
                DataSourceUpdateMode = DataSourceUpdateMode.Never,
                ControlUpdateMode = ControlUpdateMode.OnPropertyChanged
            });

            txtMaNV.DataBindings.Add(new Binding("Text", gridMuon.DataSource, "Mã nhân viên")
            {
                DataSourceUpdateMode = DataSourceUpdateMode.Never,
                ControlUpdateMode = ControlUpdateMode.OnPropertyChanged
            });

        }

        private void cbMaDG_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            txtTenDG.Text = "";
            txtTenDG.Text = cbMaDG.SelectedValue.ToString();
        }

        private void txtMaPM_TextChanged(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                string t = (sender as TextBox).Text;
                ShowCTPhieuMuon(t);
            }
        }

        private void gridMuon_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                cbMaDG.Text = "";
                string MaDG = grvMuon.GetRowCellValue(grvMuon.FocusedRowHandle, grvMuon.Columns[1]).ToString();
                cbMaDG.Text = MaDG;
                txtTenDG.Text = cbMaDG.SelectedValue.ToString();
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

            XuLyHienThiGridSach();
            ClearInput();

            txtMaPM.Text = Utilities.Instance.NextID("M", grvMuon.GetRowCellValue(grvMuon.RowCount - 1, grvMuon.Columns[0]).ToString());

        }


        void ClearInput()
        {
            txtMaPM.Text = "";
            txtTenDG.Text = "";
            txtMaNV.Text = "";
            dtHanTra.Value = DateTime.Now + new TimeSpan(4,0,0,0);
            dtNgayMuon.Value = DateTime.Now;
            cbMaDG.Text = "Chọn mã đọc giả";
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã sách");
            dt.Columns.Add("Tên sách");
            dt.Columns.Add("Thể loại");
            dt.Columns.Add("Tác giả");
            gridCTMuon.DataSource = dt;
        }

        void XuLyHienThiGridSach()
        {
            gridMuon.Visible = false;
            gridSach = new GridControl();
            grvSach = new GridView(gridSach);
            gridSach.ViewCollection.Add(grvSach);


            List<SachDTO> listBooks = SachBLL.Instance.ShowBook();
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã sách");
            dt.Columns.Add("Tên sách");
            dt.Columns.Add("Thể loại");
            dt.Columns.Add("Tác giả");
            dt.Columns.Add("Năm XB");
            dt.Columns.Add("Nhà xuất bản");
            dt.Columns.Add("Ngày nhập");
            dt.Columns.Add("Trị giá");
            dt.Columns.Add("Tình trạng");
            dt.Columns.Add("Ảnh bìa");
            dt.Columns.Add("Tick");
            foreach (SachDTO book in listBooks)
            {
                dt.Rows.Add(book.MaSach, book.TenSach, book.MaTL.ToString(), book.MaTG, book.NamXB.ToString(), book.NXB, book.NgayNhap.ToString(), book.TriGia.ToString(), book.TinhTrang.ToString(), book.AnhBia, false);
            }
            grvSach.OptionsSelection.MultiSelect = true;
            grvSach.OptionsBehavior.Editable = false;
            gridSach.DataSource = dt;
            grvSach.ClearSelection();

            gridSach.MainView = grvSach;
            gridSach.Parent = panel2;
            gridSach.Dock = DockStyle.Fill;

            panel2.Controls.Add(gridSach);
        }

        private void btnThemsach_Click(object sender, EventArgs e)
        {
            int[] handle = grvSach.GetSelectedRows();

            for (int i = 0; i < handle.Length; i++)
            {
                if (grvSach.GetRowCellValue(handle[i], grvSach.Columns[8]).ToString() == "False")
                    MessageBox.Show(string.Format("Sách có mã {0} không có sẵn. Mời chọn sách khác!", grvSach.GetRowCellValue(handle[i], grvSach.Columns[0]).ToString()), "Thông báo",MessageBoxButtons.OK);
                else
                {
                    if (grvSach.GetRowCellValue(handle[i], grvSach.Columns[10]).ToString() == "False")
                    {
                        string theloai = grvSach.GetRowCellValue(handle[i], grvSach.Columns[2]).ToString();
                        string masach = grvSach.GetRowCellValue(handle[i], grvSach.Columns[0]).ToString();
                        string tensach = grvSach.GetRowCellValue(handle[i], grvSach.Columns[1]).ToString();
                        string tacgia = grvSach.GetRowCellValue(handle[i], grvSach.Columns[3]).ToString();

                        grvSach.SetRowCellValue(handle[i], grvSach.Columns[10], true);
                        CreateNewRow(masach, tensach, theloai, tacgia);
                    }
                }
            }
        }

        private void CreateNewRow(string val1, string val2, string val3, string val4)
        {

            //add a new row 
            grvCTMuon.AddNewRow();
            //set a new row cell value. The static GridControl.NewItemRowHandle field allows you to retrieve the added row 
            grvCTMuon.SetRowCellValue(GridControl.NewItemRowHandle, grvCTMuon.Columns[0], val1);
            grvCTMuon.SetRowCellValue(GridControl.NewItemRowHandle, grvCTMuon.Columns[1], val2);
            grvCTMuon.SetRowCellValue(GridControl.NewItemRowHandle, grvCTMuon.Columns[2], val3);
            grvCTMuon.SetRowCellValue(GridControl.NewItemRowHandle, grvCTMuon.Columns[3], val4);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            //lưu xuống CSDL
            List<string> lmasach = new List<string>();
            for (int i = 0; i < grvCTMuon.RowCount; i++)
            {
                string ma = grvCTMuon.GetRowCellValue(grvCTMuon.GetRowHandle(i), grvCTMuon.Columns[0]).ToString();
                lmasach.Add(ma);
            }
            string ketqua = PhieuMuonBLL.Instance.SavePhieuMuon(txtMaPM.Text, cbMaDG.Text, dtNgayMuon.Text, txtMaNV.Text, dtHanTra.Text, grvCTMuon.RowCount, lmasach);
            if (ketqua == "Thêm phiếu mượn thành công!")
            {
                flag = 1;
                btnXoa.Text = "Xóa";
            }
            MessageBox.Show(ketqua, "Thông báo", MessageBoxButtons.OK);
            gridSach.Visible = false;
            gridMuon.Visible = true;
            ClearInput();
            ShowPhieuMuon();


        }

        private void btnXoasach_Click(object sender, EventArgs e)
        {
            //set Tick = false
            string masach = grvCTMuon.GetRowCellValue(grvCTMuon.FocusedRowHandle, grvCTMuon.Columns[0]).ToString();
            for(int i =0; i < grvSach.RowCount;i++)
            {
                if(masach == grvSach.GetRowCellValue(i, grvSach.Columns[0]).ToString())
                {
                    grvSach.SetRowCellValue(i, grvSach.Columns[10], false);
                }
            
            }
            grvCTMuon.DeleteRow(grvCTMuon.FocusedRowHandle);
        }

        private void grvCTMuon_InitNewRow(object sender, InitNewRowEventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(flag ==2)
            {
                if(MessageBox.Show("Bạn có muốn hủy phiếu mượn này?","Thông báo",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    gridSach.Visible = false;
                    gridMuon.Visible = true;
                    ClearInput();
                    ShowPhieuMuon();
                    flag = 1;
                    btnXoa.Text = "Xóa";

                }

            }
        }
    }
}
