using QuanLyThuVien.DAL;
using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.BLL
{
    class PhieuTraBLL
    {
        private static PhieuTraBLL instance;

        public static PhieuTraBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuTraBLL();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private PhieuTraBLL() { }

        public List<PhieuTraDTO> ShowPhieuTra()
        {
            List<PhieuTraDTO> data = PhieuTraDAL.Instance.LoadPhieuTra();

            return data;
        }

        public List<CTPhieuTraDTO> ShowCTPhieuTraByMaPT(string MaPT)
        {
            List<CTPhieuTraDTO> data = CTPhieuTraDAL.Instance.LoadCTPhieuTraByMaPT(MaPT);
            return data;
        }

        public string SavePhieuTra(string maPT, string maPM, string maDG, string ngayTra, string maNV, string tienPhatKyNay, DataTable dtCTTra)
        {

            string output = "";

            if (PhieuTraDAL.Instance.SavePhieuTra(maPT, maPM, maDG, ngayTra, maNV, tienPhatKyNay))
            {
                foreach (DataRow data in dtCTTra.Rows)
                {
                    if (!PhieuTraDAL.Instance.SaveCTPhieuTra(maPT, data["Mã sách"].ToString(), data["Số ngày mượn"].ToString(), data["Tiền phạt"].ToString()))
                    {
                        output = "Thêm chi tiết phiếu trả thất bại!";
                        return output;
                    }
                }
                //cap nhat lai tong no
                DocGiaBLL.Instance.UpdateTongNo(maDG, Convert.ToDouble(tienPhatKyNay));
                output = "Thêm phiếu trả thành công!";
            }
            else
            {
                output = "Thêm phiếu trả thất bại!";
            }

            return output;
        }
    }
}
