using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DTO
{
    class BaoCaoSachTraTreDTO
    {
        public string MaBCSTT { get; set; }
        public DateTime Ngay { get; set; }
    
        public BaoCaoSachTraTreDTO(DataRow row)
        {
            MaBCSTT = (string)row["MaBCSTT"];
            Ngay = Convert.ToDateTime(row["Ngay"]);
        }
    }
}
