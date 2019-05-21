namespace QuanLyThuVien.GUI
{
    partial class BCSachTraTre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BCSachTraTre));
            this.SoNgayTraTre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnThongKe = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TenSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grvCTBCSachTT = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NgayMuon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCTBCSachTT = new DevExpress.XtraGrid.GridControl();
            this.btnLapBaoCao = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtNgayBC = new System.Windows.Forms.DateTimePicker();
            this.txtMaBC = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grvCTBCSachTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCTBCSachTT)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SoNgayTraTre
            // 
            this.SoNgayTraTre.FieldName = "Số ngày trả trễ";
            this.SoNgayTraTre.Name = "SoNgayTraTre";
            this.SoNgayTraTre.Visible = true;
            this.SoNgayTraTre.VisibleIndex = 3;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Appearance.BackColor = System.Drawing.Color.White;
            this.btnThongKe.Appearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnThongKe.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnThongKe.Appearance.Options.UseBackColor = true;
            this.btnThongKe.Appearance.Options.UseBorderColor = true;
            this.btnThongKe.Appearance.Options.UseFont = true;
            this.btnThongKe.Appearance.Options.UseForeColor = true;
            this.btnThongKe.Appearance.Options.UseImage = true;
            this.btnThongKe.Appearance.Options.UseTextOptions = true;
            this.btnThongKe.AppearanceHovered.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThongKe.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.AppearanceHovered.Options.UseBackColor = true;
            this.btnThongKe.AppearanceHovered.Options.UseForeColor = true;
            this.btnThongKe.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnThongKe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKe.ImageOptions.Image")));
            this.btnThongKe.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnThongKe.Location = new System.Drawing.Point(644, 67);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(134, 27);
            this.btnThongKe.TabIndex = 32;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(258, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 30;
            this.label1.Text = "Mã báo cáo:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(15, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 21);
            this.label5.TabIndex = 28;
            this.label5.Text = "Ngày:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TenSach
            // 
            this.TenSach.FieldName = "Tên sách";
            this.TenSach.Name = "TenSach";
            this.TenSach.Visible = true;
            this.TenSach.VisibleIndex = 1;
            // 
            // MaSach
            // 
            this.MaSach.FieldName = "Mã sách";
            this.MaSach.Name = "MaSach";
            this.MaSach.Visible = true;
            this.MaSach.VisibleIndex = 0;
            // 
            // grvCTBCSachTT
            // 
            this.grvCTBCSachTT.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaSach,
            this.TenSach,
            this.NgayMuon,
            this.SoNgayTraTre});
            this.grvCTBCSachTT.GridControl = this.gridCTBCSachTT;
            this.grvCTBCSachTT.Name = "grvCTBCSachTT";
            this.grvCTBCSachTT.OptionsView.ShowGroupPanel = false;
            // 
            // NgayMuon
            // 
            this.NgayMuon.FieldName = "Ngày mượn";
            this.NgayMuon.Name = "NgayMuon";
            this.NgayMuon.Visible = true;
            this.NgayMuon.VisibleIndex = 2;
            // 
            // gridCTBCSachTT
            // 
            this.gridCTBCSachTT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCTBCSachTT.Location = new System.Drawing.Point(0, 0);
            this.gridCTBCSachTT.MainView = this.grvCTBCSachTT;
            this.gridCTBCSachTT.Name = "gridCTBCSachTT";
            this.gridCTBCSachTT.Size = new System.Drawing.Size(1144, 483);
            this.gridCTBCSachTT.TabIndex = 1;
            this.gridCTBCSachTT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvCTBCSachTT});
            // 
            // btnLapBaoCao
            // 
            this.btnLapBaoCao.Appearance.BackColor = System.Drawing.Color.White;
            this.btnLapBaoCao.Appearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnLapBaoCao.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapBaoCao.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLapBaoCao.Appearance.Options.UseBackColor = true;
            this.btnLapBaoCao.Appearance.Options.UseBorderColor = true;
            this.btnLapBaoCao.Appearance.Options.UseFont = true;
            this.btnLapBaoCao.Appearance.Options.UseForeColor = true;
            this.btnLapBaoCao.Appearance.Options.UseImage = true;
            this.btnLapBaoCao.Appearance.Options.UseTextOptions = true;
            this.btnLapBaoCao.AppearanceHovered.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLapBaoCao.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnLapBaoCao.AppearanceHovered.Options.UseBackColor = true;
            this.btnLapBaoCao.AppearanceHovered.Options.UseForeColor = true;
            this.btnLapBaoCao.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnLapBaoCao.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLapBaoCao.ImageOptions.Image")));
            this.btnLapBaoCao.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnLapBaoCao.Location = new System.Drawing.Point(819, 67);
            this.btnLapBaoCao.Name = "btnLapBaoCao";
            this.btnLapBaoCao.Size = new System.Drawing.Size(134, 27);
            this.btnLapBaoCao.TabIndex = 26;
            this.btnLapBaoCao.Text = "Lập báo cáo";
            this.btnLapBaoCao.Click += new System.EventHandler(this.btnLapBaoCao_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridCTBCSachTT);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1144, 483);
            this.panel2.TabIndex = 7;
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
            this.labelControl1.Size = new System.Drawing.Size(377, 32);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "THỐNG KÊ SÁCH TRẢ TRỄ";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.txtMaBC);
            this.panel1.Controls.Add(this.dtNgayBC);
            this.panel1.Controls.Add(this.btnThongKe);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnLapBaoCao);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 117);
            this.panel1.TabIndex = 6;
            // 
            // dtNgayBC
            // 
            this.dtNgayBC.Font = new System.Drawing.Font("Tahoma", 11F);
            this.dtNgayBC.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayBC.Location = new System.Drawing.Point(84, 71);
            this.dtNgayBC.Name = "dtNgayBC";
            this.dtNgayBC.Size = new System.Drawing.Size(104, 25);
            this.dtNgayBC.TabIndex = 34;
            this.dtNgayBC.ValueChanged += new System.EventHandler(this.dtNgayBC_ValueChanged);
            // 
            // txtMaBC
            // 
            this.txtMaBC.Location = new System.Drawing.Point(379, 71);
            this.txtMaBC.Name = "txtMaBC";
            this.txtMaBC.Size = new System.Drawing.Size(100, 21);
            this.txtMaBC.TabIndex = 35;
            // 
            // BCSachTraTre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "BCSachTraTre";
            this.Size = new System.Drawing.Size(1144, 600);
            ((System.ComponentModel.ISupportInitialize)(this.grvCTBCSachTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCTBCSachTT)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn SoNgayTraTre;
        private DevExpress.XtraEditors.SimpleButton btnThongKe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.Columns.GridColumn TenSach;
        private DevExpress.XtraGrid.Columns.GridColumn MaSach;
        private DevExpress.XtraGrid.Views.Grid.GridView grvCTBCSachTT;
        private DevExpress.XtraGrid.Columns.GridColumn NgayMuon;
        private DevExpress.XtraGrid.GridControl gridCTBCSachTT;
        private DevExpress.XtraEditors.SimpleButton btnLapBaoCao;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtNgayBC;
        private System.Windows.Forms.TextBox txtMaBC;
    }
}
