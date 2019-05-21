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
    }
}
