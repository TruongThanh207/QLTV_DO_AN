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
    }
}
