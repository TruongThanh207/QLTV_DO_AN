using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DTO
{
    class PhieuTraDTO
    {
        public string MaPT { get; set; }
        public string MaPM { get; set; }
        public string MaDG { get; set; }
        public DateTime NgayTra { get; set; }
        public string MaNV { get; set; }
        public double TienPhatKyNay { get; set; }

        public PhieuTraDTO(DataRow row)
        {
            MaPT = (string)row["MaPT"];
            MaPM = (string)row["MaPM"];
            MaDG = (string)row["MaDG"];
            NgayTra = (DateTime)row["NgayTra"];
            MaNV = row["MaNV"].ToString();
            TienPhatKyNay = Convert.ToDouble(row["TienPhatKyNay"]);
        }
    }
}
