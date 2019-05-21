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
    public partial class QLTheLoai : DevExpress.XtraEditors.XtraUserControl
    {
        private static QLTheLoai _instance;

        public static QLTheLoai Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new QLTheLoai();
                return _instance;
            }
        }
        public QLTheLoai()
        {
            InitializeComponent();
        }
    }
}
