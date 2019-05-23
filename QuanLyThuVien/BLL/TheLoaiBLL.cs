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
    class TheLoaiBLL
    {
        private static TheLoaiBLL instance;

        public static TheLoaiBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new TheLoaiBLL();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private TheLoaiBLL() { }

        public List<TheLoaiDTO> ShowTheLoai()
        {
            List<TheLoaiDTO> data = TheLoaiDAL.Instance.LoadTheLoai();

            return data;
        }

        public DataTable ShowTheLoaiToCombobox()
        {
            DataTable data = TheLoaiDAL.Instance.LoadTheLoaiToComboBox();
           return data;
        }
    }
}
