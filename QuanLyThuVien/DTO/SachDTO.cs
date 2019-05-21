using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DTO
{
    class SachDTO
    {
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public string MaTL { get; set; }
        public string MaTG { get; set; }
        public int NamXB { get; set; }
        public string NXB { get; set; }
        public DateTime NgayNhap { get; set; }
        public double TriGia { get; set; }
        public bool TinhTrang { get; set; }
        public string AnhBia { get; set; }

        public SachDTO() { }
        public SachDTO(DataRow row)
        {
            MaSach = (string)row["MaSach"];
            TenSach = (string)row["TenSach"];
            MaTL = (string)row["MaTL"];
            MaTG = (string)row["MaTG"];
            NamXB = (int)row["NamXB"];
            NXB = (string)row["NXB"];
            NgayNhap = (DateTime)row["NgayNhap"];
            TriGia = Convert.ToDouble(row["TriGia"]);
            TinhTrang = (bool)row["TinhTrang"];
            string Anh = row["AnhBia"].ToString();
            if (Anh == "")
            {
                this.AnhBia = "Không có ảnh";
            }
            else
                this.AnhBia = Anh;
        }
    }
}
