using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DTO
{
    class LoaiDocGiaDTO
    {
        public string MaLDG { get; set; }
        public string TenLDG { get; set; }
        public LoaiDocGiaDTO() { }
        public LoaiDocGiaDTO(DataRow row)
        {
            MaLDG = (string)row["MaLDG"];
            TenLDG = (string)row["TenLDG"];

        }
    }
    
}
