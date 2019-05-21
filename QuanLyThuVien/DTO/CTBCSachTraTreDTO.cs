using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DTO
{
    class CTBCSachTraTreDTO
    {
        public string MaBCSTT { get; set; }
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public DateTime NgayMuon { get; set; }
        public int SoNgayTraTre { get; set; }


        public CTBCSachTraTreDTO(DataRow row, string maBCSTT)
        {
            MaBCSTT = maBCSTT;
            MaSach = (string)row["MaSach"];
            TenSach = (string)row["TenSach"];
            NgayMuon = Convert.ToDateTime(row["NgayMuon"]);
            SoNgayTraTre = Convert.ToInt32(row["SoNgayTraTre"]);
        }
    }
}
