
using QuanLyThuVien.DAL;
using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.BLL
{
    class BaoCaoSachTraTreBLL
    {
        private static BaoCaoSachTraTreBLL instance;

        public static BaoCaoSachTraTreBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new BaoCaoSachTraTreBLL();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private BaoCaoSachTraTreBLL() { }

        public string SaveBaoCaoSachTraTre(string ma, string ngay)
        {
            //kiểm tra điều kiện
            if (ngay == "" || ma == "")
                return "Các trường không được bỏ trống!";

            // lưu xuống CSDL

            if (BaoCaoSachTraTreDAL.Instance.SaveBaoCaoSachTraTre(ma, Convert.ToDateTime(ngay)))
            {
                string temp = SaveCTBaoCaoSachTraTre(ma, ngay);
                if (temp != "OK")
                    return temp;

            }
            return "OK";
        }

        public string SaveCTBaoCaoSachTraTre(string ma, string ngay)
        {
            //load data
            DataTable data = BaoCaoSachTraTreDAL.Instance.LoadData(Convert.ToDateTime(ngay));

            //xử lí

            List<CTBCSachTraTreDTO> listCT = new List<CTBCSachTraTreDTO>();

            foreach (DataRow row in data.Rows)
            {

                CTBCSachTraTreDTO newCTBC = new CTBCSachTraTreDTO(row, ma);
                listCT.Add(newCTBC);
            }

            //luu vao sql

            foreach (CTBCSachTraTreDTO ct in listCT)
            {
                if (!BaoCaoSachTraTreDAL.Instance.SaveCTBaoCaoSachTraTre(ct.MaBCSTT, ct.MaSach, ct.TenSach, ct.NgayMuon, ct.SoNgayTraTre))
                {

                    return "Lỗi hiển thị CT báo cáo.";
                };
            }

            return "OK";

        }

        public DataTable ShowCTBaoCaoSachTraTre(string maBCSTT)
        {
            DataTable data = BaoCaoSachTraTreDAL.Instance.LoadCTBaoCaoSachTraTre(maBCSTT);

            return data;
        }

        public string GetMaBCSTTTheoTime(DateTime ngay)
        {
            string data = BaoCaoSachTraTreDAL.Instance.LoadMaBCSTTTheoTime(ngay);
            if (data == "")
                return "";
            else
                return data;
        }

        public string GetLastMaBC()
        {
            return BaoCaoSachTraTreDAL.Instance.LoadLastMaBC();
        }

    }
}
