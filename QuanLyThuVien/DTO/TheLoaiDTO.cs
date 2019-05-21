using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DTO
{
    class TheLoaiDTO
    {
        public string MaTL { get; set; }
        public string TenTL { get; set; }


        public TheLoaiDTO(DataRow row)
        {
            MaTL = (string)row["MaTL"];
            TenTL = (string)row["TenTL"];
        }
    }

}
