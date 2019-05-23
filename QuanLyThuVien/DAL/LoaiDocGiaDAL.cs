using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAL
{
    class LoaiDocGiaDAL : DatabaseAccess
    {

        private static LoaiDocGiaDAL instance;

        public static LoaiDocGiaDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoaiDocGiaDAL();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private LoaiDocGiaDAL() { }

        #region Methods
        public List<LoaiDocGiaDTO> LoadLoaiDocGia()
        {
            DatabaseAcess.Instance.OpenConnection();
            List<LoaiDocGiaDTO> list = new List<LoaiDocGiaDTO>();

            DataTable data = DatabaseAcess.Instance.ExcuteQuery("USP_LOADLOAIDOCGIA");

            // lọc qua DTO
            foreach (DataRow row in data.Rows)
            {
                LoaiDocGiaDTO theloai = new LoaiDocGiaDTO(row);
                list.Add(theloai);
            }
            DatabaseAcess.Instance.CloseConnection();
            return list;
        }

        //Dung lay danh sach the loai len combobox
        public DataTable LoadLoaiDocGiaToComboBox()
        {

              DatabaseAcess.Instance.OpenConnection();

            List<LoaiDocGiaDTO> data = LoadLoaiDocGia();

            DataTable dt = new DataTable();
            dt.Columns.Add("Mã LDG");
            dt.Columns.Add("Tên LDG");

            foreach (LoaiDocGiaDTO loaitacgia in data)
            {
                dt.Rows.Add(loaitacgia.MaLDG + " - " + loaitacgia.TenLDG, loaitacgia.MaLDG);
            }
            DatabaseAcess.Instance.CloseConnection();
            return dt;


        }

        public bool SaveLOAIDG(string Ma, string Ten)
        {

            string query = "USP_SAVELOAIDG @MaLDG , @TenLDG";

            int ret = DatabaseAcess.Instance.ExecuteNonQuery(query, new object[] { Ma, Ten });
            //int ret = DatabaseAcess.Instance.ExecuteNonQuery("insert into SACH values('S010','ach','TL001','TG001',2019,'io',2/2/2019,12000,'True','Không có ảnh')"); 
            if (ret > 0)
                return true;
            else
                return false;
        }

        public bool UpdateLoaiDG(string Ma, string Ten)
        {

            string query = "USP_UPDATELOAIDG @MaLDG , @TenLDG";
            int ret = DatabaseAcess.Instance.ExecuteNonQuery(query, new object[] { Ma, Ten });
            if (ret > 0)
                return true;
            else
                return false;
        }

        public bool DeleteLDG(string Ma)
        {
            //string query = "USP_DELETEBOOK @Ma";
            //int ret = DatabaseAcess.Instance.ExecuteNonQuery(query, new object[] { Ma});

            string query = "delete from LOAIDOCGIA where MaLDG ='" + Ma + "'";
            int ret = DatabaseAcess.Instance.ExecuteNonQuery(query);

            if (ret > 0)
                return true;
            else
                return false;
        }


        #endregion
    }

}
