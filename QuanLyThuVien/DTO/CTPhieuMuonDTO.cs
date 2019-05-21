using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DTO
{
    class CTPhieuMuonDTO
    {
        public string MaPM { get; set; }
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public string TheLoai { get; set; }
        public string TacGia { get; set; }

        public CTPhieuMuonDTO(DataRow row)
        {
            MaSach = (string)row["MaSach"];
            TenSach = (string)row["TenSach"];
            TheLoai = (string)row["TenTL"];
            TacGia = (string)row["TenTG"];
        }
    }
}
