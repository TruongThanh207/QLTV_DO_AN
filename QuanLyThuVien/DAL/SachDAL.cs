using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.DTO;
using System.Data;

namespace QuanLyThuVien.DAL
{
    class SachDAL:DatabaseAccess
    {
        private static SachDAL instance;

        public static SachDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new SachDAL();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private SachDAL() { }

        #region Methods
        public List<SachDTO> LoadBooks()
        {
            List<SachDTO> list = new List<SachDTO>();

            DataTable data = DatabaseAcess.Instance.ExcuteQuery("USP_LOADBOOKS");

            // lọc qua DTO
            foreach(DataRow row in data.Rows)
            {
                SachDTO book = new SachDTO(row);
                list.Add(book);
            }
            return list;
        }

        public bool SaveBook(string Ma, string Ten, string TL, string TG, string NamXB, string NXB
            , string NgayNhap, string TriGia, string TinhTrang, string AnhBia)
        {
            int namXB = Convert.ToInt32(NamXB);
            DateTime ngaynhap = Convert.ToDateTime(NgayNhap);
            bool tinhtrang;
            if (TinhTrang == "True")
                tinhtrang = true;
            else
                tinhtrang = false;
            double trigia = Convert.ToDouble(TriGia);
            string query = "USP_SAVEBOOK @Ma , @Ten , @MaTL , @MaTG , @NamXB , @NXB , @NgayNhap , @TriGia , @TinhTrang , @AnhBia";

            int ret = DatabaseAcess.Instance.ExecuteNonQuery(query, new object[] { Ma, Ten, TL, TG, namXB, NXB, ngaynhap, trigia, tinhtrang, AnhBia });
            //int ret = DatabaseAcess.Instance.ExecuteNonQuery("insert into SACH values('S010','ach','TL001','TG001',2019,'io',2/2/2019,12000,'True','Không có ảnh')"); 
            if (ret > 0)
                return true;
            else
                return false; 
        }

        public bool UpdateBook(string Ma, string Ten, string TL, string TG, string NamXB, string NXB
            , string NgayNhap, string TriGia, string TinhTrang, string AnhBia)
        {
            int namXB = Convert.ToInt32(NamXB);
            DateTime ngaynhap = Convert.ToDateTime(NgayNhap);
            bool tinhtrang;
            if (TinhTrang == "True")
                tinhtrang = true;
            else
                tinhtrang = false;
            double trigia = Convert.ToDouble(TriGia);
            string query = "USP_UPDATEBOOK @Ma , @Ten , @MaTL , @MaTG , @NamXB , @NXB , @NgayNhap , @TriGia , @TinhTrang , @AnhBia";
            int ret = DatabaseAcess.Instance.ExecuteNonQuery(query, new object[] { Ma, Ten, TL, TG, namXB, NXB, ngaynhap, trigia, tinhtrang, AnhBia });
            if (ret > 0)
                return true;
            else
                return false;
        }

        public bool DeleteBook(string Ma)
        {
            //string query = "USP_DELETEBOOK @Ma";
            //int ret = DatabaseAcess.Instance.ExecuteNonQuery(query, new object[] { Ma});

            string query = "delete from SACH where MaSach ='" + Ma + "'";
            int ret = DatabaseAcess.Instance.ExecuteNonQuery(query);

            if (ret > 0)
                return true;
            else
                return false;
        }

        public bool GetTinhTrangSachByMaSach(string ma)
        {
            object TinhTrang = DatabaseAcess.Instance.ExecuteScalar("USP_GETTINHTRANGBYMASACH @Ma", new object[] { ma });
            bool ret = Convert.ToBoolean(TinhTrang);
            return ret;
        }

        public bool UpdateTinhTrangSachTra(string maSach)
        {
            int ret1 = DatabaseAcess.Instance.ExecuteNonQuery("USP_UPDATETINHTRANGBOOK @Ma , @TinhTrang", new object[] { maSach, true });
            if (ret1 > 0)
                return true;
            return false;
        }
        #endregion
    }
}
