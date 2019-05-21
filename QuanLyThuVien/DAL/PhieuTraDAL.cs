using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.DTO;
using System.Data;

namespace QuanLyThuVien.DAL
{
    class PhieuTraDAL : DatabaseAccess
    {
        private static PhieuTraDAL instance;

        public static PhieuTraDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuTraDAL();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private PhieuTraDAL() { }

        #region Methods
        public List<PhieuTraDTO> LoadPhieuTra()
        {
            DatabaseAcess.Instance.OpenConnection();
            List<PhieuTraDTO> list = new List<PhieuTraDTO>();

            DataTable data = DatabaseAcess.Instance.ExcuteQuery("USP_LOADPHIEUTRA");

            // lọc qua DTO
            foreach (DataRow row in data.Rows)
            {
                PhieuTraDTO phieutra = new PhieuTraDTO(row);
                list.Add(phieutra);
            }
            DatabaseAcess.Instance.CloseConnection();
            return list;
        }

        public bool SavePhieuTra(string maPT, string maPM, string maDG, string ngayTra, string maNV, string tienPhatKyNay)
        {
            int ret = DatabaseAcess.Instance.ExecuteNonQuery("SAVEPHIEUTRA @maPT , @maPM , @maDG , @ngayTra , @maNV , @tienPhatKyNay", new object[] { maPT,maPM, maDG, Convert.ToDateTime(ngayTra), maNV, Convert.ToDouble(tienPhatKyNay) });
            if (ret > 0)
                return true;
            return false;
        }

        public bool SaveCTPhieuTra(string maPT, string maSach, string soNgayMuon, string tienPhat)
        {
            int ret = DatabaseAcess.Instance.ExecuteNonQuery("SAVECTPHIEUTRA @maPT , @maSach , @soNgayMuon , @tienPhat", new object[] { maPT, maSach,Convert.ToInt32(soNgayMuon),Convert.ToDouble(tienPhat) });

            int ret1 = DatabaseAcess.Instance.ExecuteNonQuery("USP_UPDATETINHTRANGBOOK @Ma , @TinhTrang", new object[] { maSach, true });
            if (ret > 0 && ret1 > 0)
                return true;
            return false;
        }

        public List<PhieuTraDTO> LoadAllPMByMaDG(string maDG)
        {
            DatabaseAcess.Instance.OpenConnection();

            DataTable data = DatabaseAcess.Instance.ExcuteQuery("USP_GETALLMAPMBYMADOCGIA @Ma", new object[] { maDG });

            List<PhieuTraDTO> list = new List<PhieuTraDTO>();

            foreach (DataRow row in data.Rows)
            {
                PhieuTraDTO phieumuon = new PhieuTraDTO(row);
                list.Add(phieumuon);
            }

            DatabaseAcess.Instance.CloseConnection();

            return list;
        }
        #endregion
    }
}
