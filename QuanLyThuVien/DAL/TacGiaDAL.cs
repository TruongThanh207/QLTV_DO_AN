using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.DTO;
using System.Data;

namespace QuanLyThuVien.DAL
{
    class TacGiaDAL : DatabaseAccess
    {
        private static TacGiaDAL instance;

        public static TacGiaDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new TacGiaDAL();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private TacGiaDAL() { }

        #region Methods
        public List<TacGiaDTO> LoadTacGia()
        {
            DatabaseAcess.Instance.OpenConnection();
            List<TacGiaDTO> list = new List<TacGiaDTO>();

            DataTable data = DatabaseAcess.Instance.ExcuteQuery("USP_LOADTACGIA");

            // lọc qua DTO
            foreach (DataRow row in data.Rows)
            {
                TacGiaDTO theloai = new TacGiaDTO(row);
                list.Add(theloai);
            }
            DatabaseAcess.Instance.CloseConnection();
            return list;
        }

        //Dung lay danh sach tacgia len combobox
        public DataTable LoadTacGiaToComboBox()
        {
            DatabaseAcess.Instance.OpenConnection();

            List<TacGiaDTO> data = LoadTacGia();

            DataTable dt = new DataTable();
            dt.Columns.Add("Mã TG");
            dt.Columns.Add("Tên TG");

            foreach (TacGiaDTO tacgia in data)
            {
                dt.Rows.Add(tacgia.MaTG, tacgia.MaTG + " - " + tacgia.TenTG);
            }
            DatabaseAcess.Instance.CloseConnection();
            return dt;

        }

        //public DataTable LoadTacGia(int i = 0)
        //{
        //    DatabaseAcess.Instance.OpenConnection();
        //    List<TacGiaDTO> list = new List<TacGiaDTO>();

        //    DataTable data = DatabaseAcess.Instance.ExcuteQuery("USP_LOADTHELOAI");

        //    DatabaseAcess.Instance.CloseConnection();
        //    return data;
        //}
        #endregion
    }
}
