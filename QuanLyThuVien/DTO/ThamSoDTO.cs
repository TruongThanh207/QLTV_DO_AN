using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DTO
{
    class ThamSoDTO
    {
        public int TuoiToiDa { get; set; }
        public int TuoiToiThieu { get; set; }
        public int ThoiHanThe { get; set; }
        public int SoLuongTGToiDa { get; set; }
        public int DieuKienNhanSach{ get; set; }
        public int SoSachMuonToiDa { get; set; }
        public int ThoiGianMuonToiDa { get; set; }
        public double TienPhatMotNgay { get; set; }

        private ThamSoDTO() { }
        public ThamSoDTO(DataRow row)
        {
            TuoiToiDa = (int)row["TuoiToiDa"];
            TuoiToiThieu = (int)row["TuoiToiThieu"];
            ThoiHanThe = (int)row["ThoiHanThe"];
            SoLuongTGToiDa = (int)row["SoLuongTGToiDa"];
            DieuKienNhanSach = (int)row["DieuKienNhanSach"];
            SoSachMuonToiDa = (int)row["SoSachMuonToiDa"];
            ThoiGianMuonToiDa = (int)row["ThoiGianMuonToiDa"];
            TienPhatMotNgay = Convert.ToDouble(row["TienPhatMotNgay"]);
        }
    }
}
