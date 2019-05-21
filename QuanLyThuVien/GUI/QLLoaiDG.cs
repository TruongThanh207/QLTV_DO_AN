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
                {
                    _instance = new QLLoaiDG();
                }

                return _instance;
            }
        }

        int flag = 0;
        public QLLoaiDG()
        {
            InitializeComponent();
            ShowLoaiDocGia();
            Lock(false);
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        public void Lock(bool b)
        {
            if (b)
            {
                btnLuu.Enabled = false;
                txtMaLDG.ReadOnly = false;
                txtTenLDG.ReadOnly = false;
            }
            else
            {
                btnLuu.Enabled = true;
                txtTenLDG.ReadOnly = true;
                txtMaLDG.ReadOnly = true;              
            }
        }
        public void ShowLoaiDocGia()
        {
            List<LoaiDocGiaDTO> listLDG = LoaiDocGiaBLL.Instance.ShowLoaiDocGia();
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã loại đọc giả");
            dt.Columns.Add("Tên loại đọc giả");
            foreach (LoaiDocGiaDTO LDG in listLDG)
            {
                dt.Rows.Add(LDG.MaLDG, LDG.TenLDG);
                gridLDG.DataSource = dt;
                grvLDG.ClearSelection();
                BookDetailBinding();
            }
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
       
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            flag = 1;
            Lock(false);
            btnSua.Enabled = false;
            btnXoa.Enabled = true;
            btnXoa.Text = "Huỷ";
            txtTenLDG.Text = "";

            //Lấy mã sách mới nhất

            txtMaLDG.Text = Utilities.Instance.NextID("LDG", grvLDG.GetRowCellValue(grvLDG.RowCount - 1, grvLDG.Columns[0]).ToString());
        }


    }
}
