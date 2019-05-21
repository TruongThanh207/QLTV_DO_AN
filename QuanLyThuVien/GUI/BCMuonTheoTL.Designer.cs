namespace QuanLyThuVien.GUI
{
    partial class BCMuonTheoTL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BCMuonTheoTL));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNam = new System.Windows.Forms.ComboBox();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.btnThongKe = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLapBaoCao = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridCTBCTheLoai = new DevExpress.XtraGrid.GridControl();
            this.grvCTBCTheloai = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaTL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenTL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuotMuon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TiLe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtMaBC = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCTBCTheLoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCTBCTheloai)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.txtMaBC);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbNam);
            this.panel1.Controls.Add(this.cbThang);
            this.panel1.Controls.Add(this.btnThongKe);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnLapBaoCao);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 117);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "/";
            // 
            // cbNam
            // 
            this.cbNam.FormattingEnabled = true;
            this.cbNam.Items.AddRange(new object[] {
            "2019",
            "2020"});
            this.cbNam.Location = new System.Drawing.Point(157, 73);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(44, 21);
            this.cbNam.TabIndex = 38;
            // 
            // cbThang
            // 
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbThang.Location = new System.Drawing.Point(92, 73);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(44, 21);
            this.cbThang.TabIndex = 37;
            this.cbThang.SelectedIndexChanged += new System.EventHandler(this.cbThang_SelectedIndexChanged);
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
            this.label1.Location = new System.Drawing.Point(257, 72);
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
            this.label5.Size = new System.Drawing.Size(71, 21);
            this.label5.TabIndex = 28;
            this.label5.Text = "Tháng:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.btnLapBaoCao.Click += new System.EventHandler(this.btnLuu_Click);
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
            this.labelControl1.Size = new System.Drawing.Size(818, 32);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "THỐNG KÊ TÌNH HÌNH MƯỢN SÁCH THEO THỂ LOẠI";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridCTBCTheLoai);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1144, 483);
            this.panel2.TabIndex = 5;
            // 
            // gridCTBCTheLoai
            // 
            this.gridCTBCTheLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCTBCTheLoai.Location = new System.Drawing.Point(0, 0);
            this.gridCTBCTheLoai.MainView = this.grvCTBCTheloai;
            this.gridCTBCTheLoai.Name = "gridCTBCTheLoai";
            this.gridCTBCTheLoai.Size = new System.Drawing.Size(1144, 483);
            this.gridCTBCTheLoai.TabIndex = 1;
            this.gridCTBCTheLoai.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvCTBCTheloai});
            // 
            // grvCTBCTheloai
            // 
            this.grvCTBCTheloai.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaTL,
            this.TenTL,
            this.SoLuotMuon,
            this.TiLe});
            this.grvCTBCTheloai.GridControl = this.gridCTBCTheLoai;
            this.grvCTBCTheloai.Name = "grvCTBCTheloai";
            this.grvCTBCTheloai.OptionsView.ShowGroupPanel = false;
            // 
            // MaTL
            // 
            this.MaTL.FieldName = "Mã thể loại";
            this.MaTL.Name = "MaTL";
            this.MaTL.Visible = true;
            this.MaTL.VisibleIndex = 0;
            // 
            // TenTL
            // 
            this.TenTL.FieldName = "Tên thể loại";
            this.TenTL.Name = "TenTL";
            this.TenTL.Visible = true;
            this.TenTL.VisibleIndex = 1;
            // 
            // SoLuotMuon
            // 
            this.SoLuotMuon.FieldName = "Số lượt mượn";
            this.SoLuotMuon.Name = "SoLuotMuon";
            this.SoLuotMuon.Visible = true;
            this.SoLuotMuon.VisibleIndex = 2;
            // 
            // TiLe
            // 
            this.TiLe.FieldName = "Tỉ lệ";
            this.TiLe.Name = "TiLe";
            this.TiLe.Visible = true;
            this.TiLe.VisibleIndex = 3;
            // 
            // txtMaBC
            // 
            this.txtMaBC.Location = new System.Drawing.Point(378, 73);
            this.txtMaBC.Name = "txtMaBC";
            this.txtMaBC.Size = new System.Drawing.Size(136, 21);
            this.txtMaBC.TabIndex = 40;
            // 
            // BCMuonTheoTL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "BCMuonTheoTL";
            this.Size = new System.Drawing.Size(1144, 600);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCTBCTheLoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCTBCTheloai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton btnLapBaoCao;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnThongKe;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridCTBCTheLoai;
        private DevExpress.XtraGrid.Views.Grid.GridView grvCTBCTheloai;
        private DevExpress.XtraGrid.Columns.GridColumn MaTL;
        private DevExpress.XtraGrid.Columns.GridColumn TenTL;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuotMuon;
        private DevExpress.XtraGrid.Columns.GridColumn TiLe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbNam;
        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.TextBox txtMaBC;
    }
}
