using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.DTO;
using System.Data;

namespace QuanLyThuVien.DAL
{
    class DocGiaDAL : DatabaseAccess
    {
        private static DocGiaDAL instance;

        public static DocGiaDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new DocGiaDAL();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private DocGiaDAL() { }

        #region Methods
        public List<DocGiaDTO> LoadDocGia()
        {
            DatabaseAcess.Instance.OpenConnection();
            List<DocGiaDTO> list = new List<DocGiaDTO>();

            DataTable data = DatabaseAcess.Instance.ExcuteQuery("USP_LOADDOCGIA");

            // lọc qua DTO
            foreach (DataRow row in data.Rows)
            {
                DocGiaDTO theloai = new DocGiaDTO(row);
                list.Add(theloai);
            }
            DatabaseAcess.Instance.CloseConnection();
            return list;
        }

        //Dung lay danh sach the loai len combobox
        public DataTable LoadDocGiaToComboBox()
        {

            List<DocGiaDTO> data = LoadDocGia();

            DataTable dt = new DataTable();
            dt.Columns.Add("Mã DG");
            dt.Columns.Add("Tên DG");

            foreach (DocGiaDTO docgia in data)
            {
                dt.Rows.Add(docgia.MaDG, docgia.HoTen);
            }

            return dt;

        }

        public DateTime GetNgayHetHanByMaDocGia(string ma)
        {
            object ngayhethan = DatabaseAcess.Instance.ExecuteScalar("USP_GETNGAYHETHANBYMADOCGIA @Ma", new object[] { ma });
            DateTime ret = Convert.ToDateTime(ngayhethan);
            return ret;
        }

        public bool UpdateTongNo(string maDG, double tien)
        {
            string query = "USP_UPDATETONGNO @maDG , @tien";
            int ret = DatabaseAcess.Instance.ExecuteNonQuery(query, new object[] { maDG, tien });
            if (ret > 0)
                return true;
            else
                return false;
        }

        public double GetTongNo(string maDG)
        {
            double ret;
            try
            {
                ret = Convert.ToDouble(DatabaseAcess.Instance.ExecuteScalar("select TongNo from DOCGIA where maDG='" + maDG + "'"));

            } catch { return -1; }
            return ret;
        }
        #endregion
    }
}
