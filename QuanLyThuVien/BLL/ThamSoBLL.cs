using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.DAL;
using QuanLyThuVien.DTO;
namespace QuanLyThuVien.BLL
{
    class ThamSoBLL
    {
        private static ThamSoBLL instance;

        public static ThamSoBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThamSoBLL();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private ThamSoBLL() { }

        public ThamSoDTO ShowThamSo()
        {
            ThamSoDTO data = ThamSoDAL.Instance.LoadThamSo();

            return data;
        }

        public string UpdateThamSo(string tuoitoida, string tuoitoithieu, string thoihanthe, string soluongTGtoida, string dknhansach, string sosachmuontoida
           , string thoigianmuontoida, string tienphatmotngay)
        {
            //kiểm tra điều kiện
            if (tuoitoida == "" || tuoitoithieu == "" || thoihanthe == "" || soluongTGtoida == "" || dknhansach == "" || sosachmuontoida == "" || thoigianmuontoida == "" || tienphatmotngay == "")
                return "Sửa thất bại! Các trường không được bỏ trống!";

            // lưu xuống CSDL

            if (ThamSoDAL.Instance.UpdateThamSo(tuoitoida, tuoitoithieu, thoihanthe, soluongTGtoida, dknhansach, sosachmuontoida, thoigianmuontoida, tienphatmotngay))
                return "Sửa thành công!";
            else
                return "Sửa thất bại! Có lỗi xảy ra.";

        }

        public bool KiemTraQuyDinhSach( int NamXB, DateTime NgayNhap)
        {
            //kiểm tra điều kiện
            ThamSoDTO kiemtra = ShowThamSo();

            //kiểm tra năm XB
            if (NgayNhap.Year - NamXB >= 0 && NgayNhap.Year - NamXB <= kiemtra.DieuKienNhanSach)
                return true; //đúng
            else
                return false; // sai
        }

        public string KiemTraQuyDinhMuon(string Ma, int sl)
        {
            //kiểm tra tình trạng thẻ
            DateTime ngayhethan = DocGiaBLL.Instance.ShowNgayHetHanByMaDocGia(Ma);
            DateTime now = DateTime.Now;
            TimeSpan t = new TimeSpan(0, 0, 0);
            if(now - ngayhethan > t) // điều kiện sai
            {
                return "Thẻ đọc giả đã hết hạn!";
            }


            //kiểm tra không có sách mượn quá hạn

            //load tất cả mã phiếu mượn theo mã đọc giả

            List<PhieuMuonDTO> listPM = PhieuMuonBLL.Instance.ShowPhieuMuonByMaDG(Ma);

            foreach (PhieuMuonDTO pm in listPM)
            {
                //kiểm tra tình trạng phiếu
                if (pm.TinhTrang == false && DateTime.Now - pm.HanTra > t)
                    return "Có sách mượn quá hạn!";
            }

            //kiểm tra số lượng sách mượn
            ThamSoDTO ts = ShowThamSo();
            if (sl > ts.SoSachMuonToiDa)
                return "Vượt quá giới hạn mượn sách tối đa!";

            return "OK";
        }

        public double GetTienPhatMotNgay()
        {

            return ShowThamSo().TienPhatMotNgay;
        }
        public int ThoiHanThe()
        {
            ThamSoDTO tht = ShowThamSo();
            return tht.ThoiHanThe;
        }
    }
}
