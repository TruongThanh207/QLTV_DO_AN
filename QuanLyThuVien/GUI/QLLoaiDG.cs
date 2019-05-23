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
using System.Data.SqlClient;
using QuanLyThuVien.BLL;
using QuanLyThuVien.DTO;
using DevExpress;
namespace QuanLyThuVien.GUI
{
    public partial class QLLoaiDG : DevExpress.XtraEditors.XtraUserControl
    {
        private static QLLoaiDG _instance;

        public static QLLoaiDG Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new QLLoaiDG();
                return _instance;
            }
        }
        int flag = 0;
        public QLLoaiDG()
        {
            InitializeComponent();
            ShowLoaiDocGia();
            Lock(true);
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        public void Lock(bool b)
        {
            if (b)
            {
                btnLuu.Enabled = false;
                txtMaLDG.ReadOnly = true;
                txtTenLDG.ReadOnly = true;
            }
            else
            {
                btnLuu.Enabled = true;
                txtTenLDG.ReadOnly = false;
                txtMaLDG.ReadOnly = true; 
            }
        }
        public void ShowLoaiDocGia()
        {
            List<LoaiDocGiaDTO> listBooks = LoaiDocGiaBLL.Instance.ShowLoaiDocGia();
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã loại đọc giả");
            dt.Columns.Add("Tên loại đọc giả");
           
            foreach (LoaiDocGiaDTO book in listBooks)
            {
                dt.Rows.Add(book.MaLDG, book.TenLDG);
            }
            gridLDG.DataSource = dt;
            grvLDG.ClearSelection();
            BookDetailBinding();
        }
        public void BookDetailBinding()
        {
            if (txtMaLDG.DataBindings.Count > 0)
                txtMaLDG.DataBindings.RemoveAt(0);
            if (txtTenLDG.DataBindings.Count > 0)
                txtTenLDG.DataBindings.RemoveAt(0);


            txtMaLDG.DataBindings.Add(new Binding("Text", gridLDG.DataSource, "Mã loại đọc giả")
            {
                DataSourceUpdateMode = DataSourceUpdateMode.Never,
                ControlUpdateMode = ControlUpdateMode.OnPropertyChanged
            });
            txtTenLDG.DataBindings.Add(new Binding("Text", gridLDG.DataSource, "Tên loại đọc giả")
            {
                DataSourceUpdateMode = DataSourceUpdateMode.Never,
                ControlUpdateMode = ControlUpdateMode.OnPropertyChanged
            });
        }
        private void gridLDG_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Text = "Xoá";
            btnXoa.Enabled = true;
            Lock(true);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 1;
            Lock(false); 
            btnSua.Enabled = false;
            btnXoa.Enabled = true;
            txtTenLDG.Text = "";
            btnXoa.Text = "Huỷ";
           


            txtMaLDG.Text = Utilities.Instance.NextID("LDG", grvLDG.GetRowCellValue(grvLDG.RowCount - 1, grvLDG.Columns[0]).ToString());
        }
    

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 2;
            Lock(false);
            txtMaLDG.ReadOnly = true;
            btnXoa.Text = "Huỷ";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Huỷ")
            {
                if (MessageBox.Show("Bạn có muốn huỷ không!", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    btnXoa.Text = "Xoá";
                    txtTenLDG.Text = "";
                    Lock(false);
                    btnLuu.Enabled = false;
                    btnXoa.Enabled = false;
                }

            }
            else if (btnXoa.Text == "Xoá")
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string ret = LoaiDocGiaBLL.Instance.DeleteLDG(txtMaLDG.Text);
                    MessageBox.Show(ret);
                    ShowLoaiDocGia();
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {

                string ret = LoaiDocGiaBLL.Instance.SaveLoaiDG(txtMaLDG.Text, txtTenLDG.Text);
                MessageBox.Show(ret);
                if (ret == "Thêm thành công!")
                    Lock(true);
            }
            else if (flag == 2)
            {

                string ret = LoaiDocGiaBLL.Instance.UpdateLoaiDG(txtMaLDG.Text, txtTenLDG.Text);
                MessageBox.Show(ret);
                if (ret == "Sửa thành công!")
                    Lock(true);
            }
            ShowLoaiDocGia();
        }
    }
}
