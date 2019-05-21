using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.DTO;
using System.Data;

namespace QuanLyThuVien.DAL
{
    class BaoCaoTheoTheLoaiDAL : DatabaseAccess
    {
        private static BaoCaoTheoTheLoaiDAL instance;

        public static BaoCaoTheoTheLoaiDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new BaoCaoTheoTheLoaiDAL();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private BaoCaoTheoTheLoaiDAL() { }

        #region Methods
        public bool SaveBaoCaoTheoTheLoai(string ma, int thang, int nam)
        {
            string query = "USP_BCMUONTHEOTHELOAI @thangbaocao , @nambaocao , @maBC";

            int ret = DatabaseAcess.Instance.ExecuteNonQuery(query, new object[] { thang, nam, ma});
            //int ret = DatabaseAcess.Instance.ExecuteNonQuery("insert into SACH values('S010','ach','TL001','TG001',2019,'io',2/2/2019,12000,'True','Không có ảnh')"); 
            if (ret > 0)
                return true;
            else
                return false;
        }

        public DataTable LoadData(string thang, string nam)
        {
            DataTable data = DatabaseAcess.Instance.ExcuteQuery("USP_CREATECTBAOCAOTHEOTHELOAI @thang , @nam", new object[] { thang, nam });
            return data;
        }

        public bool SaveCTBaoCaoTheoTheLoai(string maBCTL, string maTL, string tenTL, int soLuotMuon, float tiLe)
        {
            int ret = DatabaseAcess.Instance.ExecuteNonQuery("USP_SAVECTBCTHEOTHELOAI @maBCTL , @maTl , @tenTL , @soLuotMuon , @tiLe", new object[] { maBCTL, maTL, tenTL, soLuotMuon, tiLe });
            if (ret > 0)
                return true;
            else
                return false;
        }


        public DataTable LoadCTBaoCaoTheoTheLoai(string maBCTL)
        {
            DataTable data = DatabaseAcess.Instance.ExcuteQuery("USP_LOADCTBAOCAOTHEOTL @ma", new object[] { maBCTL});
            return data;
        }

        public string LoadMaBCTLTheoTime(int thang, int nam)
        {
            object data = DatabaseAcess.Instance.ExecuteScalar("USP_GETMABCTLTHEOTIME @thang , @nam", new object[] { thang, nam });
            if (data == null)
            {
                return "";
            }
            else return data.ToString();
        }

        public string LoadLastMaBC()
        {
            string query = "SELECT TOP (1) MaBCTL FROM BAOCAOTHEOTHELOAI ORDER BY MaBCTL DESC";

            object ret =  DatabaseAcess.Instance.ExecuteScalar(query);

            return ret.ToString();

        }
        #endregion
    }
}
