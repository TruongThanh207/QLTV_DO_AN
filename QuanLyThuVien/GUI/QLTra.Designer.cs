namespace QuanLyThuVien
{
    partial class QLTra
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLTra));
            this.grvCTTra = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayMuon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoNgayMuon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TienPhat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCTTra = new DevExpress.XtraGrid.GridControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridTra = new DevExpress.XtraGrid.GridControl();
            this.grvTra = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaPT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvMaDG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaDG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayTra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TienPhatKyNay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtNgayTra = new System.Windows.Forms.DateTimePicker();
            this.cbMaDG = new System.Windows.Forms.ComboBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenDG = new System.Windows.Forms.TextBox();
            this.txtMaPT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btnXoasach = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemsach = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.MaPM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtTienPhatKyNay = new System.Windows.Forms.TextBox();
            this.cbMaPM = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grvCTTra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCTTra)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grvCTTra
            // 
            this.grvCTTra.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaSach,
            this.TenSach,
            this.NgayMuon,
            this.SoNgayMuon,
            this.TienPhat});
            this.grvCTTra.GridControl = this.gridCTTra;
            this.grvCTTra.Name = "grvCTTra";
            this.grvCTTra.OptionsBehavior.Editable = false;
            this.grvCTTra.OptionsView.ShowGroupPanel = false;
            // 
            // MaSach
            // 
            this.MaSach.FieldName = "Mã sách";
            this.MaSach.Name = "MaSach";
            this.MaSach.Visible = true;
            this.MaSach.VisibleIndex = 0;
            this.MaSach.Width = 65;
            // 
            // TenSach
            // 
            this.TenSach.FieldName = "Tên sách";
            this.TenSach.Name = "TenSach";
            this.TenSach.Visible = true;
            this.TenSach.VisibleIndex = 1;
            this.TenSach.Width = 112;
            // 
            // NgayMuon
            // 
            this.NgayMuon.FieldName = "Ngày mượn";
            this.NgayMuon.Name = "NgayMuon";
            this.NgayMuon.Visible = true;
            this.NgayMuon.VisibleIndex = 2;
            this.NgayMuon.Width = 92;
            // 
            // SoNgayMuon
            // 
            this.SoNgayMuon.FieldName = "Số ngày mượn";
            this.SoNgayMuon.Name = "SoNgayMuon";
            this.SoNgayMuon.Visible = true;
            this.SoNgayMuon.VisibleIndex = 3;
            this.SoNgayMuon.Width = 88;
            // 
            // TienPhat
            // 
            this.TienPhat.FieldName = "Tiền phạt";
            this.TienPhat.Name = "TienPhat";
            this.TienPhat.Visible = true;
            this.TienPhat.VisibleIndex = 4;
            this.TienPhat.Width = 85;
            // 
            // gridCTTra
            // 
            this.gridCTTra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCTTra.Location = new System.Drawing.Point(2, 27);
            this.gridCTTra.MainView = this.grvCTTra;
            this.gridCTTra.Name = "gridCTTra";
            this.gridCTTra.Size = new System.Drawing.Size(411, 240);
            this.gridCTTra.TabIndex = 0;
            this.gridCTTra.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvCTTra});
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridTra);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1144, 367);
            this.panel2.TabIndex = 9;
            // 
            // gridTra
            // 
            this.gridTra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTra.Location = new System.Drawing.Point(0, 0);
            this.gridTra.MainView = this.grvTra;
            this.gridTra.Name = "gridTra";
            this.gridTra.Size = new System.Drawing.Size(1144, 367);
            this.gridTra.TabIndex = 0;
            this.gridTra.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvTra});
            this.gridTra.Click += new System.EventHandler(this.gridTra_Click);
            // 
            // grvTra
            // 
            this.grvTra.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaPT,
            this.gvMaDG,
            this.MaDG,
            this.NgayTra,
            this.MaNV,
            this.TienPhatKyNay});
            this.grvTra.GridControl = this.gridTra;
            this.grvTra.Name = "grvTra";
            this.grvTra.OptionsBehavior.Editable = false;
            this.grvTra.OptionsView.ShowGroupPanel = false;
            // 
            // MaPT
            // 
            this.MaPT.FieldName = "Mã phiếu trả";
            this.MaPT.Name = "MaPT";
            this.MaPT.Visible = true;
            this.MaPT.VisibleIndex = 0;
            // 
            // gvMaDG
            // 
            this.gvMaDG.FieldName = "Mã phiếu mượn";
            this.gvMaDG.Name = "gvMaDG";
            this.gvMaDG.Visible = true;
            this.gvMaDG.VisibleIndex = 1;
            // 
            // MaDG
            // 
            this.MaDG.FieldName = "Mã đọc giả";
            this.MaDG.Name = "MaDG";
            this.MaDG.Visible = true;
            this.MaDG.VisibleIndex = 2;
            // 
            // NgayTra
            // 
            this.NgayTra.FieldName = "Ngày trả";
            this.NgayTra.Name = "NgayTra";
            this.NgayTra.Visible = true;
            this.NgayTra.VisibleIndex = 3;
            // 
            // MaNV
            // 
            this.MaNV.FieldName = "Mã nhân viên";
            this.MaNV.Name = "MaNV";
            this.MaNV.Visible = true;
            this.MaNV.VisibleIndex = 4;
            // 
            // TienPhatKyNay
            // 
            this.TienPhatKyNay.FieldName = "Tiền phạt kỳ này";
            this.TienPhatKyNay.Name = "TienPhatKyNay";
            // 
            // dtNgayTra
            // 
            this.dtNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayTra.Location = new System.Drawing.Point(449, 33);
            this.dtNgayTra.Name = "dtNgayTra";
            this.dtNgayTra.Size = new System.Drawing.Size(151, 21);
            this.dtNgayTra.TabIndex = 25;
            // 
            // cbMaDG
            // 
            this.cbMaDG.FormattingEnabled = true;
            this.cbMaDG.Location = new System.Drawing.Point(135, 83);
            this.cbMaDG.Name = "cbMaDG";
            this.cbMaDG.Size = new System.Drawing.Size(151, 21);
            this.cbMaDG.TabIndex = 23;
            this.cbMaDG.Text = "Chọn mã đọc giả";
            this.cbMaDG.SelectedIndexChanged += new System.EventHandler(this.cbMaDG_SelectedIndexChanged);
            // 
            // txtMaNV
            // 
            this.txtMaNV.BackColor = System.Drawing.Color.White;
            this.txtMaNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaNV.Font = new System.Drawing.Font("Arial", 10F);
            this.txtMaNV.ForeColor = System.Drawing.Color.Black;
            this.txtMaNV.Location = new System.Drawing.Point(449, 128);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(151, 16);
            this.txtMaNV.TabIndex = 22;
            this.txtMaNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(319, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Mã NV:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(319, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Tiền phạt kỳ này:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mã đọc giả:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã phiếu trả:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTenDG
            // 
            this.txtTenDG.BackColor = System.Drawing.Color.White;
            this.txtTenDG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenDG.Font = new System.Drawing.Font("Arial", 10F);
            this.txtTenDG.ForeColor = System.Drawing.Color.Black;
            this.txtTenDG.Location = new System.Drawing.Point(135, 134);
            this.txtTenDG.Name = "txtTenDG";
            this.txtTenDG.Size = new System.Drawing.Size(151, 16);
            this.txtTenDG.TabIndex = 13;
            this.txtTenDG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMaPT
            // 
            this.txtMaPT.BackColor = System.Drawing.Color.White;
            this.txtMaPT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaPT.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPT.ForeColor = System.Drawing.Color.Black;
            this.txtMaPT.Location = new System.Drawing.Point(135, 37);
            this.txtMaPT.Name = "txtMaPT";
            this.txtMaPT.ReadOnly = true;
            this.txtMaPT.Size = new System.Drawing.Size(151, 16);
            this.txtMaPT.TabIndex = 10;
            this.txtMaPT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMaPT.TextChanged += new System.EventHandler(this.txtMaPT_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(319, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ngày trả:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(7, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tên đọc giả:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnXoasach
            // 
            this.btnXoasach.Appearance.BackColor = System.Drawing.Color.Firebrick;
            this.btnXoasach.Appearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnXoasach.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoasach.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnXoasach.Appearance.Options.UseBackColor = true;
            this.btnXoasach.Appearance.Options.UseBorderColor = true;
            this.btnXoasach.Appearance.Options.UseFont = true;
            this.btnXoasach.Appearance.Options.UseForeColor = true;
            this.btnXoasach.Appearance.Options.UseImage = true;
            this.btnXoasach.Appearance.Options.UseTextOptions = true;
            this.btnXoasach.AppearanceHovered.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnXoasach.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnXoasach.AppearanceHovered.Options.UseBackColor = true;
            this.btnXoasach.AppearanceHovered.Options.UseForeColor = true;
            this.btnXoasach.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnXoasach.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoasach.ImageOptions.Image")));
            this.btnXoasach.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnXoasach.Location = new System.Drawing.Point(261, 11);
            this.btnXoasach.Name = "btnXoasach";
            this.btnXoasach.Size = new System.Drawing.Size(107, 34);
            this.btnXoasach.TabIndex = 4;
            this.btnXoasach.Text = "Xóa sách";
            this.btnXoasach.Click += new System.EventHandler(this.btnXoasach_Click);
            // 
            // btnThemsach
            // 
            this.btnThemsach.Appearance.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThemsach.Appearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnThemsach.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemsach.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnThemsach.Appearance.Options.UseBackColor = true;
            this.btnThemsach.Appearance.Options.UseBorderColor = true;
            this.btnThemsach.Appearance.Options.UseFont = true;
            this.btnThemsach.Appearance.Options.UseForeColor = true;
            this.btnThemsach.Appearance.Options.UseImage = true;
            this.btnThemsach.Appearance.Options.UseTextOptions = true;
            this.btnThemsach.AppearanceHovered.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThemsach.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnThemsach.AppearanceHovered.Options.UseBackColor = true;
            this.btnThemsach.AppearanceHovered.Options.UseForeColor = true;
            this.btnThemsach.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnThemsach.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemsach.ImageOptions.Image")));
            this.btnThemsach.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnThemsach.Location = new System.Drawing.Point(66, 11);
            this.btnThemsach.Name = "btnThemsach";
            this.btnThemsach.Size = new System.Drawing.Size(128, 34);
            this.btnThemsach.TabIndex = 2;
            this.btnThemsach.Text = "Thêm sách";
            this.btnThemsach.Click += new System.EventHandler(this.btnThemsach_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnXoasach);
            this.panel3.Controls.Add(this.btnThemsach);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(2, 210);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(411, 57);
            this.panel3.TabIndex = 7;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.panel3);
            this.groupControl1.Controls.Add(this.gridCTTra);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl1.Location = new System.Drawing.Point(729, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(415, 269);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "CHI TIẾT PHIẾU TRẢ";
            // 
            // MaPM
            // 
            this.MaPM.FieldName = "Mã phiếu mượn";
            this.MaPM.Name = "MaPM";
            this.MaPM.Visible = true;
            this.MaPM.VisibleIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupControl2);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.groupControl1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 427);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1144, 269);
            this.panel4.TabIndex = 8;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txtTienPhatKyNay);
            this.groupControl2.Controls.Add(this.cbMaPM);
            this.groupControl2.Controls.Add(this.label7);
            this.groupControl2.Controls.Add(this.dtNgayTra);
            this.groupControl2.Controls.Add(this.cbMaDG);
            this.groupControl2.Controls.Add(this.txtMaNV);
            this.groupControl2.Controls.Add(this.label6);
            this.groupControl2.Controls.Add(this.label4);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.txtTenDG);
            this.groupControl2.Controls.Add(this.txtMaPT);
            this.groupControl2.Controls.Add(this.label5);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(729, 210);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "THÔNG TIN TRẢ";
            // 
            // txtTienPhatKyNay
            // 
            this.txtTienPhatKyNay.BackColor = System.Drawing.Color.White;
            this.txtTienPhatKyNay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTienPhatKyNay.Font = new System.Drawing.Font("Arial", 10F);
            this.txtTienPhatKyNay.ForeColor = System.Drawing.Color.Black;
            this.txtTienPhatKyNay.Location = new System.Drawing.Point(449, 82);
            this.txtTienPhatKyNay.Name = "txtTienPhatKyNay";
            this.txtTienPhatKyNay.Size = new System.Drawing.Size(151, 16);
            this.txtTienPhatKyNay.TabIndex = 29;
            this.txtTienPhatKyNay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbMaPM
            // 
            this.cbMaPM.FormattingEnabled = true;
            this.cbMaPM.Location = new System.Drawing.Point(135, 170);
            this.cbMaPM.Name = "cbMaPM";
            this.cbMaPM.Size = new System.Drawing.Size(151, 21);
            this.cbMaPM.TabIndex = 28;
            this.cbMaPM.Text = "Chọn mã phiếu mượn";
            this.cbMaPM.SelectedIndexChanged += new System.EventHandler(this.cbMaPM_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(7, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Mã phiếu mượn:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnXoa);
            this.panel5.Controls.Add(this.btnLuu);
            this.panel5.Controls.Add(this.btnThem);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 210);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(729, 59);
            this.panel5.TabIndex = 6;
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
            this.btnXoa.AppearanceHovered.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnXoa.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnXoa.AppearanceHovered.Options.UseBackColor = true;
            this.btnXoa.AppearanceHovered.Options.UseForeColor = true;
            this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnXoa.Location = new System.Drawing.Point(397, 11);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(107, 34);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.btnLuu.AppearanceHovered.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLuu.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnLuu.AppearanceHovered.Options.UseBackColor = true;
            this.btnLuu.AppearanceHovered.Options.UseForeColor = true;
            this.btnLuu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnLuu.Location = new System.Drawing.Point(233, 11);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(107, 34);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
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
            this.btnThem.Location = new System.Drawing.Point(28, 11);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(128, 34);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl1.Appearance.Image")));
            this.labelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Appearance.Options.UseImage = true;
            this.labelControl1.Appearance.Options.UseImageAlign = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl1.Location = new System.Drawing.Point(19, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(236, 32);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "QUẢN LÝ TRẢ";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 60);
            this.panel1.TabIndex = 7;
            // 
            // QLTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "QLTra";
            this.Size = new System.Drawing.Size(1144, 696);
            ((System.ComponentModel.ISupportInitialize)(this.grvCTTra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCTTra)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView grvCTTra;
        private DevExpress.XtraGrid.Columns.GridColumn MaSach;
        private DevExpress.XtraGrid.Columns.GridColumn TenSach;
        private DevExpress.XtraGrid.Columns.GridColumn NgayMuon;
        private DevExpress.XtraGrid.Columns.GridColumn SoNgayMuon;
        private DevExpress.XtraGrid.GridControl gridCTTra;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gridTra;
        private DevExpress.XtraGrid.Views.Grid.GridView grvTra;
        private DevExpress.XtraGrid.Columns.GridColumn MaPT;
        private DevExpress.XtraGrid.Columns.GridColumn gvMaDG;
        private DevExpress.XtraGrid.Columns.GridColumn MaDG;
        private DevExpress.XtraGrid.Columns.GridColumn NgayTra;
        private DevExpress.XtraGrid.Columns.GridColumn MaNV;
        private System.Windows.Forms.DateTimePicker dtNgayTra;
        private System.Windows.Forms.ComboBox cbMaDG;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenDG;
        private System.Windows.Forms.TextBox txtMaPT;
        private System.Windows.Forms.Label label5;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnXoasach;
        private DevExpress.XtraEditors.SimpleButton btnThemsach;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.Columns.GridColumn MaPM;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.Columns.GridColumn TienPhatKyNay;
        private System.Windows.Forms.TextBox txtTienPhatKyNay;
        private System.Windows.Forms.ComboBox cbMaPM;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraGrid.Columns.GridColumn TienPhat;
    }
}
