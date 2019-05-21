using QuanLyThuVien.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.DTO;

namespace QuanLyThuVien.BLL
{
    class BaoCaoTheoTheLoaiBLL
    {
        private static BaoCaoTheoTheLoaiBLL instance;

        public static BaoCaoTheoTheLoaiBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new BaoCaoTheoTheLoaiBLL();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private BaoCaoTheoTheLoaiBLL() { }

        public string SaveBaoCaoTheoTL(string ma, string thang, string nam)
        {
            //kiểm tra điều kiện
            if (thang == "" || nam == "" || ma == "")
                return "Các trường không được bỏ trống!";

            // lưu xuống CSDL

            if (BaoCaoTheoTheLoaiDAL.Instance.SaveBaoCaoTheoTheLoai(ma,Convert.ToInt32(thang), Convert.ToInt32(nam)))
            {
                string temp = SaveCTBaoCaoTheoTL(ma, thang, nam);
                if (temp != "OK")
                    return temp;

            }
            return "OK";
        }

        public string SaveCTBaoCaoTheoTL(string ma, string thang, string nam)
        {
            //load data
            DataTable data = BaoCaoTheoTheLoaiDAL.Instance.LoadData(thang, nam);

            //xử lí

            List<CTBCMuonTheoTheLoaiDTO> listCT = new List<CTBCMuonTheoTheLoaiDTO>();

            foreach(DataRow row in data.Rows)
            {

                CTBCMuonTheoTheLoaiDTO newCTBC = new CTBCMuonTheoTheLoaiDTO(row, ma);
                listCT.Add(newCTBC);
            }

            //luu vao sql

            foreach(CTBCMuonTheoTheLoaiDTO ct in listCT)
            {
                if (!BaoCaoTheoTheLoaiDAL.Instance.SaveCTBaoCaoTheoTheLoai(ct.MaBCTL, ct.MaTL, ct.TenTL, ct.SoLuotMuon, ct.TiLe))
                {

                    return "Lỗi hiển thị CT báo cáo.";
                };
            }

            return "OK";

        }

        public DataTable ShowCTBaoCaoTheoTheLoai(string maBCTL)
        {
           DataTable data = BaoCaoTheoTheLoaiDAL.Instance.LoadCTBaoCaoTheoTheLoai(maBCTL);

            return data;
        }

        public string GetMaBCTLTheoTime(int thang, int nam)
        {
            string data = BaoCaoTheoTheLoaiDAL.Instance.LoadMaBCTLTheoTime(thang, nam);
            if (data == "")
                return "";
            else
                return data;
        }

        public string GetLastMaBC()
        {
            return BaoCaoTheoTheLoaiDAL.Instance.LoadLastMaBC();
        }
    }
}
