using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DTO
{
    class PhieuMuonDTO
    {
        public string MaPM { get; set; }
        public string MaDG { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime HanTra { get; set; }
        public string MaNV { get; set; }
        public bool TinhTrang { get; set;}

        public PhieuMuonDTO(DataRow row)
        {
            MaPM = (string)row["MaPM"];
            MaDG = (string)row["MaDG"];
            NgayMuon = (DateTime)row["NgayMuon"];
            HanTra = (DateTime)row["HanTra"];
            MaNV = row["MaNV"].ToString();
            TinhTrang = (bool)row["TinhTrang"];
        }
    }
}
