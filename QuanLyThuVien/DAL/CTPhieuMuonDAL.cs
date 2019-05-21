using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.DTO;
using System.Data;

namespace QuanLyThuVien.DAL
{
    class CTPhieuMuonDAL : DatabaseAccess
    {
        private static CTPhieuMuonDAL instance;

        public static CTPhieuMuonDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new CTPhieuMuonDAL();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private CTPhieuMuonDAL() { }

        #region Methods
        public List<CTPhieuMuonDTO> LoadCTPhieuMuonByMaPM(string MaPM)
        {
            DatabaseAcess.Instance.OpenConnection();
            List<CTPhieuMuonDTO> list = new List<CTPhieuMuonDTO>();

            DataTable data = DatabaseAcess.Instance.ExcuteQuery("USP_LOADCTPHIEUMUONBYMAPM @Ma",new object[] { MaPM } );

            // lọc qua DTO
            foreach (DataRow row in data.Rows)
            {
                CTPhieuMuonDTO ctphieumuon = new CTPhieuMuonDTO(row);
                list.Add(ctphieumuon);
            }
            DatabaseAcess.Instance.CloseConnection();
            return list;
        }
        #endregion
    }
}