using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAL
{
    class LoaiDocGiaDAL : DatabaseAccess
    {
      
            private static LoaiDocGiaDAL instance;

            public static LoaiDocGiaDAL Instance
            {
                get
                {
                    if (instance == null)
                        instance = new LoaiDocGiaDAL();
                    return instance;
                }

                private set
                {
                    instance = value;
                }
            }

            private LoaiDocGiaDAL() { }

            #region Methods
            public List<LoaiDocGiaDTO> LoadLoaiDocGia()
            {
                DatabaseAcess.Instance.OpenConnection();
                List<LoaiDocGiaDTO> list = new List<LoaiDocGiaDTO>();

                DataTable data = DatabaseAcess.Instance.ExcuteQuery("USP_LOADDOCGIA");

                // lọc qua DTO
                foreach (DataRow row in data.Rows)
                {
                    LoaiDocGiaDTO theloai = new LoaiDocGiaDTO(row);
                    list.Add(theloai);
                }
                DatabaseAcess.Instance.CloseConnection();
                return list;
            }

            //Dung lay danh sach the loai len combobox
            public DataTable LoadLoaiDocGiaToComboBox()
            {

                List<LoaiDocGiaDTO> data = LoadLoaiDocGia();

                DataTable dt = new DataTable();
                dt.Columns.Add("Mã LDG");
                dt.Columns.Add("Tên LDG");

                foreach (LoaiDocGiaDTO loaidocgia in data)
                {
                    dt.Rows.Add(loaidocgia.MaLDG, loaidocgia.TenLDG);
                }

                return dt;

            }

            #endregion
    }
    
}
