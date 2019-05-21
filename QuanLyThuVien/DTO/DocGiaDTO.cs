using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DTO
{
    class DocGiaDTO
    {
        public string MaDG { get; set; }
        public string HoTen { get; set; }
        public string MaLDG { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public DateTime NgayLapThe { get; set; }
        public DateTime NgayHetHan { get; set; }
        public bool TinhTrangThe { get; set; }
        public double TongNo { get; set; }

        public DocGiaDTO(DataRow row)
        {
            MaDG = (string)row["MaDG"];
            HoTen = (string)row["HoTen"];
            MaLDG = (string)row["MaLDG"];
            NgaySinh = (DateTime)row["NgaySinh"];
            DiaChi = (string)row["DiaChi"];
            Email = (string)row["Email"];
            NgayLapThe = (DateTime)row["NgayLapThe"];
            NgayHetHan = (DateTime)row["NgayHetHan"];
            TinhTrangThe = (bool)row["TinhTrangThe"];
            TongNo = Convert.ToDouble(row["TongNo"]);
        }
    }
}
