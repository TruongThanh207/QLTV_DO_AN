namespace QuanLyThuVien
{
    partial class QLSach
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLSach));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gridSach = new DevExpress.XtraGrid.GridControl();
            this.grvSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TheLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TacGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NhaXB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NamXB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TriGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TinhTrang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AnhBia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.grChucNang = new DevExpress.XtraEditors.GroupControl();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dtNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.cbTacGia = new System.Windows.Forms.ComboBox();
            this.cbTheLoai = new System.Windows.Forms.ComboBox();
            this.rdbBorrowed = new System.Windows.Forms.RadioButton();
            this.rdbTrong = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNXB = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTriGia = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtNamXB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.ptbAnhBia = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvSach)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grChucNang)).BeginInit();
            this.grChucNang.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnhBia)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 81);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Image = global::QuanLyThuVien.Properties.Resources.quyensach2;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "QUẢN LÝ SÁCH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gridSach
            // 
            this.gridSach.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.True;
            this.gridSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSach.Location = new System.Drawing.Point(0, 81);
            this.gridSach.MainView = this.grvSach;
            this.gridSach.Name = "gridSach";
            this.gridSach.Size = new System.Drawing.Size(1144, 344);
            this.gridSach.TabIndex = 0;
            this.gridSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvSach});
            this.gridSach.Click += new System.EventHandler(this.gridSach_Click);
            // 
            // grvSach
            // 
            this.grvSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaSach,
            this.TenSach,
            this.TheLoai,
            this.TacGia,
            this.NhaXB,
            this.NamXB,
            this.NgayNhap,
            this.TriGia,
            this.TinhTrang,
            this.AnhBia});
            this.grvSach.GridControl = this.gridSach;
            this.grvSach.Name = "grvSach";
            this.grvSach.OptionsBehavior.Editable = false;
            this.grvSach.OptionsSelection.MultiSelect = true;
            this.grvSach.OptionsView.ShowGroupPanel = false;
            // 
            // MaSach
            // 
            this.MaSach.FieldName = "Mã sách";
            this.MaSach.Name = "MaSach";
            this.MaSach.Visible = true;
            this.MaSach.VisibleIndex = 0;
            this.MaSach.Width = 83;
            // 
            // TenSach
            // 
            this.TenSach.FieldName = "Tên sách";
            this.TenSach.Name = "TenSach";
            this.TenSach.Visible = true;
            this.TenSach.VisibleIndex = 1;
            this.TenSach.Width = 143;
            // 
            // TheLoai
            // 
            this.TheLoai.FieldName = "Thể loại";
            this.TheLoai.Name = "TheLoai";
            this.TheLoai.Visible = true;
            this.TheLoai.VisibleIndex = 2;
            this.TheLoai.Width = 101;
            // 
            // TacGia
            // 
            this.TacGia.FieldName = "Tác giả";
            this.TacGia.Name = "TacGia";
            this.TacGia.Visible = true;
            this.TacGia.VisibleIndex = 3;
            this.TacGia.Width = 139;
            // 
            // NhaXB
            // 
            this.NhaXB.FieldName = "Nhà xuất bản";
            this.NhaXB.Name = "NhaXB";
            this.NhaXB.Visible = true;
            this.NhaXB.VisibleIndex = 5;
            this.NhaXB.Width = 123;
            // 
            // NamXB
            // 
            this.NamXB.FieldName = "Năm XB";
            this.NamXB.Name = "NamXB";
            this.NamXB.Visible = true;
            this.NamXB.VisibleIndex = 4;
            this.NamXB.Width = 98;
            // 
            // NgayNhap
            // 
            this.NgayNhap.FieldName = "Ngày nhập";
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.Visible = true;
            this.NgayNhap.VisibleIndex = 6;
            this.NgayNhap.Width = 138;
            // 
            // TriGia
            // 
            this.TriGia.FieldName = "Trị giá";
            this.TriGia.Name = "TriGia";
            this.TriGia.Visible = true;
            this.TriGia.VisibleIndex = 7;
            this.TriGia.Width = 99;
            // 
            // TinhTrang
            // 
            this.TinhTrang.FieldName = "Tình trạng";
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.Visible = true;
            this.TinhTrang.VisibleIndex = 8;
            this.TinhTrang.Width = 108;
            // 
            // AnhBia
            // 
            this.AnhBia.FieldName = "Ảnh bìa";
            this.AnhBia.Name = "AnhBia";
            this.AnhBia.Visible = true;
            this.AnhBia.VisibleIndex = 9;
            this.AnhBia.Width = 82;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.grChucNang);
            this.panel4.Controls.Add(this.groupControl1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 425);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1144, 271);
            this.panel4.TabIndex = 2;
            // 
            // grChucNang
            // 
            this.grChucNang.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.grChucNang.Controls.Add(this.panel8);
            this.grChucNang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grChucNang.Location = new System.Drawing.Point(853, 0);
            this.grChucNang.Name = "grChucNang";
            this.grChucNang.Size = new System.Drawing.Size(291, 271);
            this.grChucNang.TabIndex = 6;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnLuu);
            this.panel8.Controls.Add(this.btnXoa);
            this.panel8.Controls.Add(this.btnThem);
            this.panel8.Controls.Add(this.btnSua);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(2, 27);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(287, 242);
            this.panel8.TabIndex = 1;
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.BackColor = System.Drawing.Color.ForestGreen;
            this.btnLuu.Appearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Appearance.Options.UseBackColor = true;
            this.btnLuu.Appearance.Options.UseBorderColor = true;
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Appearance.Options.UseForeColor = true;
            this.btnLuu.Appearance.Options.UseImage = true;
            this.btnLuu.Appearance.Options.UseTextOptions = true;
            this.btnLuu.AppearanceDisabled.BackColor = System.Drawing.Color.Silver;
            this.btnLuu.AppearanceDisabled.Options.UseBackColor = true;
            this.btnLuu.AppearanceHovered.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLuu.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnLuu.AppearanceHovered.Options.UseBackColor = true;
            this.btnLuu.AppearanceHovered.Options.UseForeColor = true;
            this.btnLuu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnLuu.Location = new System.Drawing.Point(48, 131);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(107, 34);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.BackColor = System.Drawing.Color.Firebrick;
            this.btnXoa.Appearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Appearance.Options.UseBackColor = true;
            this.btnXoa.Appearance.Options.UseBorderColor = true;
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Appearance.Options.UseForeColor = true;
            this.btnXoa.Appearance.Options.UseImage = true;
            this.btnXoa.Appearance.Options.UseTextOptions = true;
            this.btnXoa.AppearanceDisabled.BackColor = System.Drawing.Color.Silver;
            this.btnXoa.AppearanceDisabled.Options.UseBackColor = true;
            this.btnXoa.AppearanceHovered.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnXoa.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnXoa.AppearanceHovered.Options.UseBackColor = true;
            this.btnXoa.AppearanceHovered.Options.UseForeColor = true;
            this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnXoa.Location = new System.Drawing.Point(48, 189);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(107, 34);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThem.Appearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnThem.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnThem.Appearance.Options.UseBackColor = true;
            this.btnThem.Appearance.Options.UseBorderColor = true;
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Appearance.Options.UseForeColor = true;
            this.btnThem.Appearance.Options.UseImage = true;
            this.btnThem.Appearance.Options.UseTextOptions = true;
            this.btnThem.AppearanceHovered.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThem.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnThem.AppearanceHovered.Options.UseBackColor = true;
            this.btnThem.AppearanceHovered.Options.UseForeColor = true;
            this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnThem.Location = new System.Drawing.Point(48, 11);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(107, 34);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Appearance.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSua.Appearance.BorderColor = System.Drawing.Color.SandyBrown;
            this.btnSua.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSua.Appearance.Options.UseBackColor = true;
            this.btnSua.Appearance.Options.UseBorderColor = true;
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.Appearance.Options.UseForeColor = true;
            this.btnSua.Appearance.Options.UseImage = true;
            this.btnSua.Appearance.Options.UseTextOptions = true;
            this.btnSua.AppearanceDisabled.BackColor = System.Drawing.Color.Silver;
            this.btnSua.AppearanceDisabled.Options.UseBackColor = true;
            this.btnSua.AppearanceHovered.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSua.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnSua.AppearanceHovered.Options.UseBackColor = true;
            this.btnSua.AppearanceHovered.Options.UseForeColor = true;
            this.btnSua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnSua.Location = new System.Drawing.Point(48, 70);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(107, 34);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.groupControl1.Controls.Add(this.panel6);
            this.groupControl1.Controls.Add(this.panel7);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(853, 271);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "THÔNG TIN SÁCH";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dtNgayNhap);
            this.panel6.Controls.Add(this.cbTacGia);
            this.panel6.Controls.Add(this.cbTheLoai);
            this.panel6.Controls.Add(this.rdbBorrowed);
            this.panel6.Controls.Add(this.rdbTrong);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.txtNXB);
            this.panel6.Controls.Add(this.txtMaSach);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.txtTriGia);
            this.panel6.Controls.Add(this.txtTenSach);
            this.panel6.Controls.Add(this.txtNamXB);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(199, 27);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(652, 242);
            this.panel6.TabIndex = 0;
            // 
            // dtNgayNhap
            // 
            this.dtNgayNhap.CustomFormat = "dd/MM/yyyy";
            this.dtNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayNhap.Location = new System.Drawing.Point(461, 102);
            this.dtNgayNhap.Name = "dtNgayNhap";
            this.dtNgayNhap.Size = new System.Drawing.Size(154, 21);
            this.dtNgayNhap.TabIndex = 25;
            // 
            // cbTacGia
            // 
            this.cbTacGia.FormattingEnabled = true;
            this.cbTacGia.Location = new System.Drawing.Point(134, 102);
            this.cbTacGia.Name = "cbTacGia";
            this.cbTacGia.Size = new System.Drawing.Size(160, 21);
            this.cbTacGia.TabIndex = 24;
            this.cbTacGia.Text = "Chọn tác giả";
            // 
            // cbTheLoai
            // 
            this.cbTheLoai.FormattingEnabled = true;
            this.cbTheLoai.Location = new System.Drawing.Point(134, 143);
            this.cbTheLoai.Name = "cbTheLoai";
            this.cbTheLoai.Size = new System.Drawing.Size(160, 21);
            this.cbTheLoai.TabIndex = 23;
            this.cbTheLoai.Text = "Chọn thể loại";
            // 
            // rdbBorrowed
            // 
            this.rdbBorrowed.AutoSize = true;
            this.rdbBorrowed.Location = new System.Drawing.Point(213, 188);
            this.rdbBorrowed.Name = "rdbBorrowed";
            this.rdbBorrowed.Size = new System.Drawing.Size(81, 17);
            this.rdbBorrowed.TabIndex = 22;
            this.rdbBorrowed.TabStop = true;
            this.rdbBorrowed.Text = "Đang mượn";
            this.rdbBorrowed.UseVisualStyleBackColor = true;
            // 
            // rdbTrong
            // 
            this.rdbTrong.AutoSize = true;
            this.rdbTrong.Location = new System.Drawing.Point(139, 188);
            this.rdbTrong.Name = "rdbTrong";
            this.rdbTrong.Size = new System.Drawing.Size(53, 17);
            this.rdbTrong.TabIndex = 21;
            this.rdbTrong.TabStop = true;
            this.rdbTrong.Text = "Trống";
            this.rdbTrong.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(42, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã sách:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(42, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Tình trạng:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(349, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nhà xuất bản:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(349, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Ngày nhập:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNXB
            // 
            this.txtNXB.BackColor = System.Drawing.Color.White;
            this.txtNXB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNXB.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNXB.ForeColor = System.Drawing.Color.Black;
            this.txtNXB.Location = new System.Drawing.Point(461, 7);
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.Size = new System.Drawing.Size(154, 16);
            this.txtNXB.TabIndex = 4;
            this.txtNXB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMaSach
            // 
            this.txtMaSach.BackColor = System.Drawing.Color.White;
            this.txtMaSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaSach.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSach.ForeColor = System.Drawing.Color.Black;
            this.txtMaSach.Location = new System.Drawing.Point(134, 7);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.ReadOnly = true;
            this.txtMaSach.Size = new System.Drawing.Size(160, 16);
            this.txtMaSach.TabIndex = 0;
            this.txtMaSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(349, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Trị giá:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(42, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tác giả:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(42, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên sách:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(349, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Năm xuất bản:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTriGia
            // 
            this.txtTriGia.BackColor = System.Drawing.Color.White;
            this.txtTriGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTriGia.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTriGia.ForeColor = System.Drawing.Color.Black;
            this.txtTriGia.Location = new System.Drawing.Point(461, 144);
            this.txtTriGia.Name = "txtTriGia";
            this.txtTriGia.Size = new System.Drawing.Size(154, 16);
            this.txtTriGia.TabIndex = 7;
            this.txtTriGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTenSach
            // 
            this.txtTenSach.BackColor = System.Drawing.Color.White;
            this.txtTenSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenSach.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSach.ForeColor = System.Drawing.Color.Black;
            this.txtTenSach.Location = new System.Drawing.Point(134, 53);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(160, 16);
            this.txtTenSach.TabIndex = 1;
            this.txtTenSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNamXB
            // 
            this.txtNamXB.BackColor = System.Drawing.Color.White;
            this.txtNamXB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNamXB.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamXB.ForeColor = System.Drawing.Color.Black;
            this.txtNamXB.Location = new System.Drawing.Point(461, 54);
            this.txtNamXB.Name = "txtNamXB";
            this.txtNamXB.Size = new System.Drawing.Size(154, 16);
            this.txtNamXB.TabIndex = 5;
            this.txtNamXB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(42, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Thể loại:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.ptbAnhBia);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(2, 27);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(197, 242);
            this.panel7.TabIndex = 1;
            // 
            // ptbAnhBia
            // 
            this.ptbAnhBia.Location = new System.Drawing.Point(17, 29);
            this.ptbAnhBia.Name = "ptbAnhBia";
            this.ptbAnhBia.Size = new System.Drawing.Size(136, 167);
            this.ptbAnhBia.TabIndex = 21;
            this.ptbAnhBia.TabStop = false;
            // 
            // QLSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.gridSach);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "QLSach";
            this.Size = new System.Drawing.Size(1144, 696);
            this.Load += new System.EventHandler(this.QLSach_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvSach)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grChucNang)).EndInit();
            this.grChucNang.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnhBia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private DevExpress.XtraGrid.GridControl gridSach;
        private DevExpress.XtraGrid.Views.Grid.GridView grvSach;
        private DevExpress.XtraGrid.Columns.GridColumn MaSach;
        private DevExpress.XtraGrid.Columns.GridColumn TenSach;
        private DevExpress.XtraGrid.Columns.GridColumn TheLoai;
        private DevExpress.XtraGrid.Columns.GridColumn TacGia;
        private DevExpress.XtraGrid.Columns.GridColumn NhaXB;
        private DevExpress.XtraGrid.Columns.GridColumn NamXB;
        private DevExpress.XtraGrid.Columns.GridColumn NgayNhap;
        private DevExpress.XtraGrid.Columns.GridColumn TriGia;
        private DevExpress.XtraGrid.Columns.GridColumn TinhTrang;
        private DevExpress.XtraGrid.Columns.GridColumn AnhBia;
        private DevExpress.XtraEditors.GroupControl grChucNang;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        public System.Windows.Forms.TextBox txtMaSach;
        public System.Windows.Forms.TextBox txtTenSach;
        public System.Windows.Forms.TextBox txtTriGia;
        public System.Windows.Forms.TextBox txtNXB;
        public System.Windows.Forms.PictureBox ptbAnhBia;
        public System.Windows.Forms.RadioButton rdbBorrowed;
        public System.Windows.Forms.RadioButton rdbTrong;
        public System.Windows.Forms.ComboBox cbTheLoai;
        public System.Windows.Forms.ComboBox cbTacGia;
        private System.Windows.Forms.DateTimePicker dtNgayNhap;
        public System.Windows.Forms.TextBox txtNamXB;
    }
}
