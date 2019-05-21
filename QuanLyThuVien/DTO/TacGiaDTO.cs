using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DTO
{
    class TacGiaDTO
    {
        public string MaTG { get; set; }
        public string TenTG { get; set; }

        public TacGiaDTO(DataRow row)
        {
            MaTG = (string)row["MaTG"];
            TenTG = (string)row["TenTG"];
        }
    }
}
