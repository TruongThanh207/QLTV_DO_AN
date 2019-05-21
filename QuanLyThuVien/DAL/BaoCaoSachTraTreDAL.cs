using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static QuanLyThuVien.DAL.DatabaseAccess;

namespace QuanLyThuVien.DAL
{
    class BaoCaoSachTraTreDAL
    {
        private static BaoCaoSachTraTreDAL instance;

        public static BaoCaoSachTraTreDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new BaoCaoSachTraTreDAL();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private BaoCaoSachTraTreDAL() { }

        #region Methods
        public bool SaveBaoCaoSachTraTre(string ma, DateTime ngay)
        {
            string query = "USP_SAVEBAOCAOSACHTRATRE @ma , @ngay";

            int ret = DatabaseAcess.Instance.ExecuteNonQuery(query, new object[] { ma, ngay });
            //int ret = DatabaseAcess.Instance.ExecuteNonQuery("insert into SACH values('S010','ach','TL001','TG001',2019,'io',2/2/2019,12000,'True','Không có ảnh')"); 
            if (ret > 0)
                return true;
            else
                return false;
        }

        public DataTable LoadData(DateTime ngay)
        {
            DataTable data = DatabaseAcess.Instance.ExcuteQuery("USP_CREATECTBAOCAOSACHTRATRE @ngay", new object[] { ngay });
            return data;
        }

        public bool SaveCTBaoCaoSachTraTre(string maBCSTT, string maSach, string tenSach, DateTime ngayMuon, int soNgayTraTre)
        {
            int ret = DatabaseAcess.Instance.ExecuteNonQuery("USP_SAVECTBCSACHTRATRE @maBCSTT , @maSach , @tenSach , @ngayMuon , @soNgayTraTre", new object[] { maBCSTT, maSach, tenSach, ngayMuon, soNgayTraTre });
            if (ret > 0)
                return true;
            else
                return false;
        }

        public DataTable LoadCTBaoCaoSachTraTre(string maBCSTT)
        {
            DataTable data = DatabaseAcess.Instance.ExcuteQuery("USP_LOADCTBCSACHTRATRE @ma", new object[] { maBCSTT });
            return data;
        }

        public string LoadMaBCSTTTheoTime(DateTime ngay)
        {
            object data = DatabaseAcess.Instance.ExecuteScalar("USP_GETMABCSTTTHEOTIME @ngay", new object[] { ngay });
            if (data == null)
            {
                return "";
            }
            else return data.ToString();
        }

        public string LoadLastMaBC()
        {
            string query = "SELECT TOP (1) MaBCSTT FROM BAOCAOSACHTRATRE ORDER BY MaBCSTT DESC";

            object ret = DatabaseAcess.Instance.ExecuteScalar(query);

            return ret.ToString();

        }
        #endregion
    }
}
