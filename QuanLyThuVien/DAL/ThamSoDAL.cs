using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.DTO;
using System.Data;

namespace QuanLyThuVien.DAL
{
    class ThamSoDAL : DatabaseAccess
    {
        private static ThamSoDAL instance;

        public static ThamSoDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThamSoDAL();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private ThamSoDAL() { }

        #region Methods
        public ThamSoDTO LoadThamSo()
        {
            DatabaseAcess.Instance.OpenConnection();
            

            DataTable data = DatabaseAcess.Instance.ExcuteQuery("USP_LOADTHAMSO");
            ThamSoDTO thamso = new ThamSoDTO(data.Rows[0]);

            DatabaseAcess.Instance.CloseConnection();
            return thamso;
        }

        public bool UpdateThamSo(string tuoitoida, string tuoitoithieu, string thoihanthe, string soluongTGtoida, string dknhansach, string sosachmuontoida
           , string thoigianmuontoida, string tienphatmotngay)
        {
            int Tuoitoida = Convert.ToInt32(tuoitoida);
            int Tuoitoithieu = Convert.ToInt32(tuoitoithieu);
            int Thoihanthe = Convert.ToInt32(thoihanthe);
            int SoluongTGtoida = Convert.ToInt32(soluongTGtoida);
            int Dknhansach = Convert.ToInt32(dknhansach);
            int Sosachmuontoida = Convert.ToInt32(sosachmuontoida);
            int Thoigianmuontoida = Convert.ToInt32(thoigianmuontoida);
            double Tienphat = Convert.ToDouble(tienphatmotngay);

            string query = "USP_UPDATETHAMSO @Tuoitoida , @Tuoitoithieu , @Thoihanthe , @SoluongTGtoida , @Dknhansach , @Sosachmuontoida , @Thoigianmuontoida , @Tienphat ";
            int ret = DatabaseAcess.Instance.ExecuteNonQuery(query, new object[] { Tuoitoida, Tuoitoithieu, Thoihanthe, SoluongTGtoida, Dknhansach, Sosachmuontoida, Thoigianmuontoida, Tienphat });
            if (ret > 0)
                return true;
            else
                return false;
        }

        #endregion
    }
}
