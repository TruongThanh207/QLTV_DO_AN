using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DTO
{
    class PhieuPhatDTO
    {
        public string MaPP { get; set;}
        public string MaDG { get; set; }
        public double SoTienThu { get; set; }
        public double ConLai { get; set; }
        public string MaNV { get; set; }

        public PhieuPhatDTO(DataRow row)
        {
            MaPP = row["MaPP"].ToString();
            MaDG = row["MaDG"].ToString();
            SoTienThu = Convert.ToDouble(row["SoTienThu"]);
            ConLai = Convert.ToDouble(row["ConLai"]);
            MaNV = row["MaNV"].ToString();
        }
    }
}
