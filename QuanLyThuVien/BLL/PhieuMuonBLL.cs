using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.DAL;
using QuanLyThuVien.DTO;
using System.Windows.Forms;
using System.Data;

namespace QuanLyThuVien.BLL
{
    class PhieuMuonBLL
    {
        private static PhieuMuonBLL instance;

        public static PhieuMuonBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuMuonBLL();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private PhieuMuonBLL() { }

        public List<PhieuMuonDTO> ShowPhieuMuon()
        {
            List<PhieuMuonDTO> data = PhieuMuonDAL.Instance.LoadPhieuMuon();

            return data;
        }

        public List<CTPhieuMuonDTO> ShowCTPhieuMuonByMaPM(string MaPM)
        {
            List<CTPhieuMuonDTO> data = CTPhieuMuonDAL.Instance.LoadCTPhieuMuonByMaPM(MaPM);

            return data;
        }

        public string SavePhieuMuon(string maPM, string maDG, string ngayMuon, string maNV, string hanTra, int sl, List<string> maSach)
        {
            //kiểm tra quy định mượn
            string output = "";
            string ret = ThamSoBLL.Instance.KiemTraQuyDinhMuon(maDG, sl);
            if (ret == "OK")
            {

                if (PhieuMuonDAL.Instance.SavePhieuMuon(maPM, maDG, ngayMuon, maNV, hanTra))
                {
                    for(int i=0;i<sl;i++)
                    {
                        if (PhieuMuonDAL.Instance.SaveCTPhieuMuon(maPM, maSach[i]) == false)
                        {
                            output = "Thêm chi tiết phiếu mượn thất bại";
                            return output;
                        }
                    }
                    output = "Thêm phiếu mượn thành công!";
                }
                else
                {
                    output = "Thêm phiếu mượn thất bại!";
                }
            }
            else
            {
                output = "Có lỗi: " + ret + "\nVui lòng kiểm tra lại!";
                
            }
            return output;
        }

        public List<PhieuMuonDTO> ShowPhieuMuonByMaDG(string maDG)
        {
            return PhieuMuonDAL.Instance.LoadAllPMByMaDG(maDG);
        }
        
        public DataTable ShowMaPMToComboBox(string maDG)
        {
            List<PhieuMuonDTO> listPM = PhieuMuonBLL.Instance.ShowPhieuMuonByMaDG(maDG);
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã phiếu mượn");
            dt.Columns.Add("Ngày mượn");


            foreach (PhieuMuonDTO phieumuon in listPM)
            {
                dt.Rows.Add(phieumuon.MaPM, phieumuon.NgayMuon);
            }

            return dt;
        }

        public void SetTinhTrangPhieuMuon(string maPM)
        {
            int flag = 0;
            List<bool> data = PhieuMuonDAL.Instance.LoadAllTinhTrangSachByMaPM(maPM);
            foreach(bool b in data)
            {
                if (!b)
                    return;
            }

            if (flag == 0)
            {//tình trạng phiếu= false
                PhieuMuonDAL.Instance.UpdateTinhTrangPhieuMuon(maPM, true);
            }

        }
    }
}
