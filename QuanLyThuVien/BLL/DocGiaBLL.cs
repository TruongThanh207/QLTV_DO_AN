using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.DAL;
using QuanLyThuVien.DTO;
using System.Data;

namespace QuanLyThuVien.BLL
{
    class DocGiaBLL
    {
        private static DocGiaBLL instance;

        public static DocGiaBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new DocGiaBLL();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private DocGiaBLL() { }

        public List<DocGiaDTO> ShowDocGia()
        {
            List<DocGiaDTO> data = DocGiaDAL.Instance.LoadDocGia();

            return data;
        }

        public DataTable ShowDocGiaToCombobox()
        {
            DataTable data = DocGiaDAL.Instance.LoadDocGiaToComboBox();
            return data;
        }

        public DateTime ShowNgayHetHanByMaDocGia(string ma)
        {
            return DocGiaDAL.Instance.GetNgayHetHanByMaDocGia(ma);
        }

        public void UpdateTongNo(string ma, double tien)
        {
            DocGiaDAL.Instance.UpdateTongNo(ma, tien);
        }

        public double LoadTongNo(string maDG)
        {
            return DocGiaDAL.Instance.GetTongNo(maDG);
        }
        public string DeleteDocGia(string Ma)
        {
            
            if (DocGiaDAL.Instance.DeleteDocGia(Ma))
                return "Xóa thành công!";
            else
                return "Xóa thất bại! Có lỗi xảy ra.";
        }
        public string SaveDocGia(string Ma, string Ten, string LDG, DateTime NS, string DiaChi, string Email, DateTime NLT, DateTime NHH, string TTT, string TN)
        {
            //kiểm tra điều kiện
            if (Ma == "" || Ten == "" || LDG == null || DiaChi == "" || Email == "" )
                return "Thêm thất bại! Các trường không được bỏ trống!";

            // lưu xuống CSDL

            if (DocGiaDAL.Instance.SaveDocGia(Ma, Ten, LDG, NS.ToString(), DiaChi, Email, NLT.ToString(), NHH.ToString(), TTT.ToString(), TN))
                return "Thêm thành công!";
            else
                return "Thêm thất bại! Có lỗi xảy ra.";

        }
        public string UpdateDocGia(string Ma, string Ten, string LDG, DateTime NS, string DiaChi, string Email, DateTime NLT, DateTime NHH, string TTT, string TN)
        {
            //kiểm tra điều kiện
            if (Ma == "" || Ten == "" || LDG == null || DiaChi == "" || Email == "")
                return "Sửa thất bại! Các trường không được bỏ trống!";

            // lưu xuống CSDL

            if (DocGiaDAL.Instance.UpdateDocGia(Ma, Ten, LDG, NS.ToString(), DiaChi, Email, NLT.ToString(), NHH.ToString(), TTT, TN))
                return "Sửa thành công!";
            else
                return "Sửa thất bại! Có lỗi xảy ra.";

        }


    }
}
