using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DTO
{
    class CTPhieuTraDTO
    {
        public string MaPT { get; set; }
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public DateTime NgayMuon { get; set; }
        public int SoNgayMuon { get; set; }
        public double TienPhat { get; set; }

        public CTPhieuTraDTO(DataRow row)
        {
            MaSach = (string)row["MaSach"];
            TenSach = (string)row["TenSach"];
            NgayMuon = (DateTime)row["NgayMuon"];
            SoNgayMuon = Convert.ToInt32(row["SoNgayMuon"]);
            TienPhat = Convert.ToDouble(row["TienPhat"]);
        }
    }
}
