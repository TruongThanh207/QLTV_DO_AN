namespace QuanLyThuVien.GUI
{
    partial class QLTacGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLTacGia));
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.MaTG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grvTacGia = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TenTG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridTacGia = new DevExpress.XtraGrid.GridControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.grChucNang = new DevExpress.XtraEditors.GroupControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grvTacGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTacGia)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grChucNang)).BeginInit();
            this.grChucNang.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.BackColor = System.Drawing.Color.ForestGreen;
            this.btnLuu.Appearance.BorderColor = System.Drawing.SystemColors.InactiveBorder;
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
            this.btnLuu.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLuu.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnLuu.AppearanceHovered.Options.UseBackColor = true;
            this.btnLuu.AppearanceHovered.Options.UseForeColor = true;
            this.btnLuu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnLuu.Location = new System.Drawing.Point(29, 83);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(107, 34);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            // 
            // MaTG
            // 
            this.MaTG.FieldName = "Mã tác giả";
            this.MaTG.Name = "MaTG";
            this.MaTG.Visible = true;
            this.MaTG.VisibleIndex = 0;
            // 
            // grvTacGia
            // 
            this.grvTacGia.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaTG,
            this.TenTG});
            this.grvTacGia.GridControl = this.gridTacGia;
            this.grvTacGia.Name = "grvTacGia";
            this.grvTacGia.OptionsView.ShowGroupPanel = false;
            // 
            // TenTG
            // 
            this.TenTG.FieldName = "Tên tác giả";
            this.TenTG.Name = "TenTG";
            this.TenTG.Visible = true;
            this.TenTG.VisibleIndex = 1;
            // 
            // gridTacGia
            // 
            this.gridTacGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTacGia.Location = new System.Drawing.Point(0, 0);
            this.gridTacGia.MainView = this.grvTacGia;
            this.gridTacGia.Name = "gridTacGia";
            this.gridTacGia.Size = new System.Drawing.Size(1144, 449);
            this.gridTacGia.TabIndex = 0;
            this.gridTacGia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvTacGia});
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridTacGia);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1144, 449);
            this.panel2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(157, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã tác giả:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.Location = new System.Drawing.Point(259, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(157, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên tác giả:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Gray;
            this.textBox2.Location = new System.Drawing.Point(259, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(206, 22);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.textBox1);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.textBox2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(2, 27);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(689, 151);
            this.panel6.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.groupControl1.Controls.Add(this.panel6);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(693, 180);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "THÔNG TIN TÁC GIẢ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnLuu);
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(2, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(447, 151);
            this.panel3.TabIndex = 0;
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
            this.btnXoa.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXoa.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnXoa.AppearanceHovered.Options.UseBackColor = true;
            this.btnXoa.AppearanceHovered.Options.UseForeColor = true;
            this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnXoa.Location = new System.Drawing.Point(166, 83);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(107, 34);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            // 
            // btnThem
            // 
            this.btnThem.Appearance.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThem.Appearance.BorderColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnThem.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnThem.Appearance.Options.UseBackColor = true;
            this.btnThem.Appearance.Options.UseBorderColor = true;
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Appearance.Options.UseForeColor = true;
            this.btnThem.Appearance.Options.UseImage = true;
            this.btnThem.Appearance.Options.UseTextOptions = true;
            this.btnThem.AppearanceDisabled.BackColor = System.Drawing.Color.Silver;
            this.btnThem.AppearanceDisabled.Options.UseBackColor = true;
            this.btnThem.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThem.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnThem.AppearanceHovered.Options.UseBackColor = true;
            this.btnThem.AppearanceHovered.Options.UseForeColor = true;
            this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnThem.Location = new System.Drawing.Point(29, 10);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(107, 34);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            // 
            // btnSua
            // 
            this.btnSua.Appearance.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSua.Appearance.BorderColor = System.Drawing.SystemColors.HotTrack;
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
            this.btnSua.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSua.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnSua.AppearanceHovered.Options.UseBackColor = true;
            this.btnSua.AppearanceHovered.Options.UseForeColor = true;
            this.btnSua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnSua.Location = new System.Drawing.Point(166, 10);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(107, 34);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            // 
            // grChucNang
            // 
            this.grChucNang.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.grChucNang.Controls.Add(this.panel3);
            this.grChucNang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grChucNang.Location = new System.Drawing.Point(693, 0);
            this.grChucNang.Name = "grChucNang";
            this.grChucNang.Size = new System.Drawing.Size(451, 180);
            this.grChucNang.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.grChucNang);
            this.panel4.Controls.Add(this.groupControl1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 516);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1144, 180);
            this.panel4.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Image = global::QuanLyThuVien.Properties.Resources.quyensach2;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "QUẢN LÝ TÁC GIẢ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 67);
            this.panel1.TabIndex = 7;
            // 
            // QLTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "QLTacGia";
            this.Size = new System.Drawing.Size(1144, 696);
            ((System.ComponentModel.ISupportInitialize)(this.grvTacGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTacGia)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grChucNang)).EndInit();
            this.grChucNang.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraGrid.Columns.GridColumn MaTG;
        private DevExpress.XtraGrid.Views.Grid.GridView grvTacGia;
        private DevExpress.XtraGrid.Columns.GridColumn TenTG;
        private DevExpress.XtraGrid.GridControl gridTacGia;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel6;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.GroupControl grChucNang;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}
