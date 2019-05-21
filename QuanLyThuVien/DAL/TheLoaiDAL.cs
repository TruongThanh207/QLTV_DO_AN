using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.DTO;
using System.Data;

namespace QuanLyThuVien.DAL
{
    class TheLoaiDAL : DatabaseAccess
    {
        private static TheLoaiDAL instance;

        public static TheLoaiDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new TheLoaiDAL();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private TheLoaiDAL() { }

        #region Methods
        public List<TheLoaiDTO> LoadTheLoai()
        {
            DatabaseAcess.Instance.OpenConnection();
            List<TheLoaiDTO> list = new List<TheLoaiDTO>();

            DataTable data = DatabaseAcess.Instance.ExcuteQuery("USP_LOADTHELOAI");

            // lọc qua DTO
            foreach (DataRow row in data.Rows)
            {
                TheLoaiDTO theloai = new TheLoaiDTO(row);
                list.Add(theloai);
            }
            DatabaseAcess.Instance.CloseConnection();
            return list;
        }

        //Dung lay danh sach the loai len combobox
        public DataTable LoadTheLoaiToComboBox()
        {
            DatabaseAcess.Instance.OpenConnection();

            List<TheLoaiDTO> data = LoadTheLoai();

            DataTable dt = new DataTable();
            dt.Columns.Add("Mã TL");
            dt.Columns.Add("Tên TL");

            foreach (TheLoaiDTO theloai in data)
            {
                dt.Rows.Add(theloai.MaTL, theloai.MaTL + " - " + theloai.TenTL);
            }
            DatabaseAcess.Instance.CloseConnection();
            return dt;

        }

             #endregion
    }
}
