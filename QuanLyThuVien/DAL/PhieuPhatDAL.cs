using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAL
{
    class PhieuPhatDAL
    {
        private static PhieuPhatDAL instance;

        public static PhieuPhatDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuPhatDAL();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private PhieuPhatDAL() { }
        public List<PhieuPhatDTO> LoadPhieuPhat()
        {
            List<PhieuPhatDTO> list = new List<PhieuPhatDTO>();

            DataTable data = DatabaseAccess.DatabaseAcess.Instance.ExcuteQuery("USP_LOADPHIEUPHAT");

            // lọc qua DTO
            foreach (DataRow row in data.Rows)
            {
                PhieuPhatDTO pp = new PhieuPhatDTO(row);
                list.Add(pp);
            }
            return list;
        }

        public string SavePhieuPhat(string maPP, string maDG, string SoTienThu, string TienConlai, string maNV )
        {
            int ret = DatabaseAccess.DatabaseAcess.Instance.ExecuteNonQuery("USP_SAVEPHIEUPHAT @maPP , @maDG , @soTienThu , @conLai , @maNV", new object[] { maPP, maDG, Convert.ToDouble(SoTienThu), Convert.ToDouble(TienConlai), maNV });
            if (ret > 0)
                return "Lưu phiếu phạt thành công!";
            else
                return "Lưu phiếu phạt thất bại!";
        }

        public string DeletePhieuPhat(string maPP)
        {
            int ret = DatabaseAccess.DatabaseAcess.Instance.ExecuteNonQuery("delete from PHIEUPHAT where MaPP ='" + maPP + "'");
            if (ret > 0)
                return "Xóa phiếu phạt thành công!";
            else
                return "Xóa phiếu phạt thất bại!";
        }

        
    }
}
