using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DTO
{
    class CTBCMuonTheoTheLoaiDTO
    {
        public string MaBCTL { get; set; }
        public string MaTL { get; set; }
        public string TenTL { get; set; }
        public int SoLuotMuon { get; set; }
        public float TiLe { get; set; }


        public CTBCMuonTheoTheLoaiDTO(DataRow row, string maBCTL)
        {
            MaBCTL = maBCTL;
            MaTL = (string)row["MaTL"];
            TenTL = (string)row["TenTL"];
            SoLuotMuon = Convert.ToInt32(row["soluotmuon"]);
            TiLe = (float)Convert.ToDouble(row["tile"]);
        }

    }
}
