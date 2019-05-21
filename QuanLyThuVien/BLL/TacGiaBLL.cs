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
    class TacGiaBLL
    {
        private static TacGiaBLL instance;

        public static TacGiaBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new TacGiaBLL();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private TacGiaBLL() { }

        public List<TacGiaDTO> ShowTacGia()
        {
            List<TacGiaDTO> data = TacGiaDAL.Instance.LoadTacGia();

            return data;
        }

        public DataTable ShowTacGiaToCombobox()
        {
            DataTable data = TacGiaDAL.Instance.LoadTacGiaToComboBox();
            return data;
        }
    }
}
