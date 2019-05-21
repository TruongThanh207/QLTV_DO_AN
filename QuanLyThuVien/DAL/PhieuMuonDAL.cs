using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.DTO;
using System.Data;

namespace QuanLyThuVien.DAL
{
    class PhieuMuonDAL : DatabaseAccess
    {
        private static PhieuMuonDAL instance;

        public static PhieuMuonDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuMuonDAL();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private PhieuMuonDAL() { }

        #region Methods
        public List<PhieuMuonDTO> LoadPhieuMuon()
        {

            List<PhieuMuonDTO> list = new List<PhieuMuonDTO>();

            DataTable data = DatabaseAcess.Instance.ExcuteQuery("USP_LOADPHIEUMUON");

            // lọc qua DTO
            foreach (DataRow row in data.Rows)
            {
                PhieuMuonDTO phieumuon = new PhieuMuonDTO(row);
                list.Add(phieumuon);
            }

            return list;
        }

        public bool SavePhieuMuon(string maPM, string maDG, string ngayMuon, string maNV, string hanTra)
        {
            int ret = DatabaseAcess.Instance.ExecuteNonQuery("USP_SAVEPHIEUMUON @maPM , @maDG , @ngayMuon , @maNV , @hanTra", new object[] { maPM, maDG, Convert.ToDateTime(ngayMuon),maNV, Convert.ToDateTime(hanTra)});
            if (ret > 0)
                return true;
            return false;
        }

        public bool SaveCTPhieuMuon(string maPM, string maSach)
        {
            int ret = DatabaseAcess.Instance.ExecuteNonQuery("USP_SAVECTPHIEUMUON @maPM , @maSach", new object[] { maPM, maSach });

            int ret1 = DatabaseAcess.Instance.ExecuteNonQuery("USP_UPDATETINHTRANGBOOK @Ma , @TinhTrang", new object[] { maSach, false });
            if (ret > 0 && ret1 > 0)
                return true;
            return false;
        }

        public List<PhieuMuonDTO> LoadAllPMByMaDG(string maDG)
        {
            DatabaseAcess.Instance.OpenConnection();

            DataTable data = DatabaseAcess.Instance.ExcuteQuery("USP_GETALLMAPMBYMADOCGIA @Ma", new object[] { maDG });

            List<PhieuMuonDTO> list = new List<PhieuMuonDTO>();

            foreach (DataRow row in data.Rows)
            {
                PhieuMuonDTO phieumuon = new PhieuMuonDTO(row);
                list.Add(phieumuon);
            }

            DatabaseAcess.Instance.CloseConnection();

            return list;
        }

        public List<bool> LoadAllTinhTrangSachByMaPM(string maPM)
        {
            List<bool> lstinhTrang = new List<bool>();

            DataTable data = DatabaseAcess.Instance.ExcuteQuery("GETALLTINHTRANGSACHBYMAPM @maPM",new object[] { maPM});

            // lọc qua DTO
            foreach (DataRow row in data.Rows)
            {
                bool b = (bool)row["TinhTrang"];
                lstinhTrang.Add(b);
            }
            return lstinhTrang;
        }

        public bool UpdateTinhTrangPhieuMuon(string maPM, bool b)
        {
            if(DatabaseAcess.Instance.ExecuteNonQuery("USP_UPDATETINHTRANGPM @maPM , @tinhTrang", new object[] { maPM, b }) > 0)
            {
                return true;
            }
            return false;
        }
        #endregion
    }
}
