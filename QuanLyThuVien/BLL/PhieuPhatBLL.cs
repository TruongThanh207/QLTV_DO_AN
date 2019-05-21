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
    class PhieuPhatBLL
    {
        private static PhieuPhatBLL instance;

        public static PhieuPhatBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuPhatBLL();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private PhieuPhatBLL() { }

        public List<PhieuPhatDTO> ShowPhieuPhat()
        {
            return PhieuPhatDAL.Instance.LoadPhieuPhat();
        }

        public string SavePhieuPhat(string maPP, string maDG, string soTienThu, string conLai, string maNV)
        {
            //check
            if (maPP == "" || maDG == "" || soTienThu == "" || conLai == "" || maNV == "")
                return "Các trường không được bỏ trống!";

            string ret = PhieuPhatDAL.Instance.SavePhieuPhat(maPP, maDG, soTienThu, conLai, maNV);

            if(ret == "Lưu phiếu phạt thành công!")
            {
                DocGiaBLL.Instance.UpdateTongNo(maDG, -(Convert.ToDouble(soTienThu)));
            }
            return ret;
        }

        public string DeletePhieuPhat(string maPP, string maDG, string soTienThu)
        {
            string ret = PhieuPhatDAL.Instance.DeletePhieuPhat(maPP);
            if (ret == "Xóa phiếu phạt thành công!")
            {
                DocGiaBLL.Instance.UpdateTongNo(maDG, Convert.ToDouble(soTienThu));
            }
            return ret;
        }
    }
}
