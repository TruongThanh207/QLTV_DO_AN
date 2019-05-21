using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.DAL;
using QuanLyThuVien.DTO;
namespace QuanLyThuVien.BLL
{
    class SachBLL
    {
        private static SachBLL instance;

        public static SachBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new SachBLL();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private SachBLL() { }

        public List<SachDTO> ShowBook()
        {
            List<SachDTO> data =  SachDAL.Instance.LoadBooks();

            return data;
        }

        public string SaveBook(string Ma, string Ten, string TL, string TG, string NamXB, string NXB
            , DateTime NgayNhap, string TriGia, string TinhTrang, string AnhBia)
        {
            //kiểm tra điều kiện
            if (Ma == "" || Ten == "" || TL == "" || TG == "" || NamXB == "" || NXB == "" || TriGia == ""
                || TinhTrang == "")
                return "Thêm thất bại! Các trường không được bỏ trống!";
            if (ThamSoBLL.Instance.KiemTraQuyDinhSach(Convert.ToInt32(NamXB), NgayNhap) == false)
                return "Thêm thất bại! Thời gian xuất bản phải nhỏ hơn 8 năm so với hiện tại";

            // lưu xuống CSDL

            if (SachDAL.Instance.SaveBook(Ma, Ten, TL, TG, NamXB, NXB
            , NgayNhap.ToString(), TriGia, TinhTrang, AnhBia))
                return "Thêm thành công!";
            else
                return "Thêm thất bại! Có lỗi xảy ra.";

        }

        public string UpdateBook(string Ma, string Ten, string TL, string TG, string NamXB, string NXB
           , string NgayNhap, string TriGia, string TinhTrang, string AnhBia)
        {
            //kiểm tra điều kiện
            if (Ma == "" || Ten == "" || TL == "" || TG == "" || NamXB == "" || NXB == "" || NgayNhap == "" || TriGia == ""
                || TinhTrang == "")
                return "Sửa thất bại! Các trường không được bỏ trống!";
            if (ThamSoBLL.Instance.KiemTraQuyDinhSach(Convert.ToInt32(NamXB), Convert.ToDateTime(NgayNhap)) == false)
                return "Sửa thất bại! Thời gian xuất bản phải nhỏ hơn 8 năm so với hiện tại";

            // lưu xuống CSDL

            if (SachDAL.Instance.UpdateBook(Ma, Ten, TL, TG, NamXB, NXB
            , NgayNhap, TriGia, TinhTrang, AnhBia))
                return "Sửa thành công!";
            else
                return "Sửa thất bại! Có lỗi xảy ra.";

        }

        public string DeleteBook(string Ma)
        {
            if (SachDAL.Instance.DeleteBook(Ma))
                return "Xóa thành công!";
            else
                return "Xóa thất bại! Có lỗi xảy ra.";
        }

        public bool GetTinhTrangSachByMaSach(string ma)
        {
            return SachDAL.Instance.GetTinhTrangSachByMaSach(ma);
        }

        public void UpdateTinhTrangSachTra(string Ma)
        {
            SachDAL.Instance.UpdateTinhTrangSachTra(Ma);
        }
    }
}
