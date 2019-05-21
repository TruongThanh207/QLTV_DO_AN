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

namespace QuanLyThuVien.GUI
{
    public partial class QLPhatTien : DevExpress.XtraEditors.XtraUserControl
    {
        private static QLPhatTien _instance;

        public static QLPhatTien Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new QLPhatTien();
                return _instance;
            }
        }

        public QLPhatTien()
        {
            InitializeComponent();
        }

    }
}
