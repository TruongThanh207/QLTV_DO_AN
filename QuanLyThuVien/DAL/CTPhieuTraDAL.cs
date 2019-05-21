using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.DTO;
using System.Data;

namespace QuanLyThuVien.DAL
{
    class CTPhieuTraDAL : DatabaseAccess
    {
        private static CTPhieuTraDAL instance;

        public static CTPhieuTraDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new CTPhieuTraDAL();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private CTPhieuTraDAL() { }

        #region Methods
        public List<CTPhieuTraDTO> LoadCTPhieuTraByMaPT(string MaPT)
        {
            DatabaseAcess.Instance.OpenConnection();
            List<CTPhieuTraDTO> list = new List<CTPhieuTraDTO>();

            DataTable data = DatabaseAcess.Instance.ExcuteQuery("USP_LOADCTPHIEUTRABYMAPT @Ma", new object[] { MaPT });

            // lọc qua DTO
            foreach (DataRow row in data.Rows)
            {
                CTPhieuTraDTO ctphieutra = new CTPhieuTraDTO(row);
                list.Add(ctphieutra);
            }
            DatabaseAcess.Instance.CloseConnection();
            return list;
        }
        #endregion
    }
}