using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuanLyThuVien
{
    public partial class QLDocGia : DevExpress.XtraEditors.XtraUserControl
    {
        private static QLDocGia _instance;

        public static QLDocGia Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new QLDocGia();
                return _instance;
            }
        }

        public QLDocGia()
        {
            InitializeComponent();
        }
    }
}
