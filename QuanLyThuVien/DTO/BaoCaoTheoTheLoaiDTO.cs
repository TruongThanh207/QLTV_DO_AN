using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DTO
{
    class BaoCaoTheoTheLoaiDTO
    {
        public string MaBCTL { get; set; }
        public int ThangBaoCao { get; set; }
        public int NamBaoCao { get; set; }
        public int TongLuotMuon { get; set; }
       

        public BaoCaoTheoTheLoaiDTO(DataRow row)
        {
            MaBCTL = (string)row["MaBCTL"];
            ThangBaoCao = Convert.ToInt32(row["ThangBaoCao"]);
            NamBaoCao = Convert.ToInt32(row["NamBaoCao"]);
            TongLuotMuon = Convert.ToInt32(row["TongLuotMuon"]);
        }
    }
}
