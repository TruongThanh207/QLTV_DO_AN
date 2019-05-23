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
    class LoaiDocGiaBLL
    {
        private static LoaiDocGiaBLL instance;

        public static LoaiDocGiaBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoaiDocGiaBLL();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private LoaiDocGiaBLL() { }

        public List<LoaiDocGiaDTO> ShowLoaiDocGia()
        {
            List<LoaiDocGiaDTO> data = LoaiDocGiaDAL.Instance.LoadLoaiDocGia();

            return data;
        }

        public DataTable ShowLoaiDocGiaToCombobox()
        {
            DataTable data = LoaiDocGiaDAL.Instance.LoadLoaiDocGiaToComboBox();
            return data;
        }
        public string DeleteLDG(string Ma)
        {
            if (LoaiDocGiaDAL.Instance.DeleteLDG(Ma))
                return "Xóa thành công!";
            else
                return "Xóa thất bại! Có lỗi xảy ra.";
        }
        public string SaveLoaiDG(string Ma, string Ten)
        {
            //kiểm tra điều kiện
            if (Ten == "")
                return "Thêm thất bại! Các trường không được bỏ trống!";

            // lưu xuống CSDL

            if (LoaiDocGiaDAL.Instance.SaveLOAIDG(Ma, Ten))
                return "Thêm thành công!";
            else
                return "Thêm thất bại! Có lỗi xảy ra.";

        }

        public string UpdateLoaiDG(string Ma, string Ten)
        {
            //kiểm tra điều kiện
            if (Ten == "")
                return "Sửa thất bại! Các trường không được bỏ trống!";


            // lưu xuống CSDL

            if (LoaiDocGiaDAL.Instance.UpdateLoaiDG(Ma, Ten))
                return "Sửa thành công!";
            else
                return "Sửa thất bại! Có lỗi xảy ra.";

        }
    }
}
