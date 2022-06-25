
namespace GUI
{
    partial class FrmDialogThongTinCaNhan
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDialogThongTinCaNhan));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.txtDiaChi = new DevExpress.XtraEditors.MemoEdit();
            this.txtCCCD = new DevExpress.XtraEditors.TextEdit();
            this.txtSDT = new DevExpress.XtraEditors.TextEdit();
            this.rbtnNu = new System.Windows.Forms.RadioButton();
            this.rbtnNam = new System.Windows.Forms.RadioButton();
            this.deNgaySInh = new DevExpress.XtraEditors.DateEdit();
            this.txtTenNV = new DevExpress.XtraEditors.TextEdit();
            this.txtManV = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcgThongTIn = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lbHoTen = new DevExpress.XtraLayout.LayoutControlItem();
            this.lbNgaySinh = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lbDiaChi = new DevExpress.XtraLayout.LayoutControlItem();
            this.lbSDT = new DevExpress.XtraLayout.LayoutControlItem();
            this.lbCCCD = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCCCD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgaySInh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgaySInh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtManV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgThongTIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbHoTen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbNgaySinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbDiaChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbSDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbCCCD)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnSua,
            this.btnLuu,
            this.btnDong,
            this.btnRefresh,
            this.btnHuy});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
            // 
            // bar2
            // 
            this.bar2.BarAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10F);
            this.bar2.BarAppearance.Normal.Options.UseFont = true;
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSua, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLuu, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHuy, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDong)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 0;
            this.btnSua.ImageOptions.Image = global::GUI.Properties.Resources.pencolor_16x16;
            this.btnSua.ImageOptions.LargeImage = global::GUI.Properties.Resources.pencolor_32x32;
            this.btnSua.Name = "btnSua";
            this.btnSua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Enabled = false;
            this.btnLuu.Id = 1;
            this.btnLuu.ImageOptions.Image = global::GUI.Properties.Resources.saveall_16x161;
            this.btnLuu.ImageOptions.LargeImage = global::GUI.Properties.Resources.saveall_32x321;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Enabled = false;
            this.btnHuy.Id = 4;
            this.btnHuy.ImageOptions.Image = global::GUI.Properties.Resources.delete_16x16;
            this.btnHuy.ImageOptions.LargeImage = global::GUI.Properties.Resources.delete_32x32;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Id = 3;
            this.btnRefresh.ImageOptions.SvgImage = global::GUI.Properties.Resources.paymentrefund2;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // btnDong
            // 
            this.btnDong.Caption = "Đóng";
            this.btnDong.Id = 2;
            this.btnDong.ImageOptions.SvgImage = global::GUI.Properties.Resources.actions_deletecircled2;
            this.btnDong.Name = "btnDong";
            this.btnDong.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDong_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(797, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 348);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(797, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 318);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(797, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 318);
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.txtDiaChi);
            this.lcMain.Controls.Add(this.txtCCCD);
            this.lcMain.Controls.Add(this.txtSDT);
            this.lcMain.Controls.Add(this.rbtnNu);
            this.lcMain.Controls.Add(this.rbtnNam);
            this.lcMain.Controls.Add(this.deNgaySInh);
            this.lcMain.Controls.Add(this.txtTenNV);
            this.lcMain.Controls.Add(this.txtManV);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 30);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.Root;
            this.lcMain.Size = new System.Drawing.Size(797, 318);
            this.lcMain.TabIndex = 4;
            this.lcMain.Text = "layoutControl1";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(129, 226);
            this.txtDiaChi.MenuManager = this.barManager1;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtDiaChi.Properties.Appearance.Options.UseFont = true;
            this.txtDiaChi.Size = new System.Drawing.Size(639, 60);
            this.txtDiaChi.StyleController = this.lcMain;
            this.txtDiaChi.TabIndex = 12;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(513, 184);
            this.txtCCCD.MenuManager = this.barManager1;
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtCCCD.Properties.Appearance.Options.UseFont = true;
            this.txtCCCD.Size = new System.Drawing.Size(255, 28);
            this.txtCCCD.StyleController = this.lcMain;
            this.txtCCCD.TabIndex = 11;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(129, 184);
            this.txtSDT.MenuManager = this.barManager1;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtSDT.Properties.Appearance.Options.UseFont = true;
            this.txtSDT.Size = new System.Drawing.Size(262, 28);
            this.txtSDT.StyleController = this.lcMain;
            this.txtSDT.TabIndex = 10;
            // 
            // rbtnNu
            // 
            this.rbtnNu.Font = new System.Drawing.Font("Tahoma", 10F);
            this.rbtnNu.Location = new System.Drawing.Point(593, 139);
            this.rbtnNu.Name = "rbtnNu";
            this.rbtnNu.Size = new System.Drawing.Size(175, 31);
            this.rbtnNu.TabIndex = 8;
            this.rbtnNu.Text = "Nữ";
            this.rbtnNu.UseVisualStyleBackColor = true;
            // 
            // rbtnNam
            // 
            this.rbtnNam.Checked = true;
            this.rbtnNam.Font = new System.Drawing.Font("Tahoma", 10F);
            this.rbtnNam.Location = new System.Drawing.Point(405, 139);
            this.rbtnNam.Name = "rbtnNam";
            this.rbtnNam.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbtnNam.Size = new System.Drawing.Size(174, 31);
            this.rbtnNam.TabIndex = 7;
            this.rbtnNam.TabStop = true;
            this.rbtnNam.Text = "Nam";
            this.rbtnNam.UseVisualStyleBackColor = true;
            // 
            // deNgaySInh
            // 
            this.deNgaySInh.EditValue = null;
            this.deNgaySInh.Location = new System.Drawing.Point(129, 139);
            this.deNgaySInh.MenuManager = this.barManager1;
            this.deNgaySInh.Name = "deNgaySInh";
            this.deNgaySInh.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.deNgaySInh.Properties.Appearance.Options.UseFont = true;
            this.deNgaySInh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgaySInh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgaySInh.Size = new System.Drawing.Size(262, 28);
            this.deNgaySInh.StyleController = this.lcMain;
            this.deNgaySInh.TabIndex = 6;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(129, 97);
            this.txtTenNV.MenuManager = this.barManager1;
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtTenNV.Properties.Appearance.Options.UseFont = true;
            this.txtTenNV.Size = new System.Drawing.Size(639, 28);
            this.txtTenNV.StyleController = this.lcMain;
            this.txtTenNV.TabIndex = 5;
            // 
            // txtManV
            // 
            this.txtManV.Location = new System.Drawing.Point(129, 55);
            this.txtManV.MenuManager = this.barManager1;
            this.txtManV.Name = "txtManV";
            this.txtManV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtManV.Properties.Appearance.Options.UseFont = true;
            this.txtManV.Size = new System.Drawing.Size(639, 28);
            this.txtManV.StyleController = this.lcMain;
            this.txtManV.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgThongTIn});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(797, 318);
            this.Root.TextVisible = false;
            // 
            // lcgThongTIn
            // 
            this.lcgThongTIn.Enabled = false;
            this.lcgThongTIn.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.lbHoTen,
            this.lbNgaySinh,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.lbDiaChi,
            this.lbSDT,
            this.lbCCCD});
            this.lcgThongTIn.Location = new System.Drawing.Point(0, 0);
            this.lcgThongTIn.Name = "lcgThongTIn";
            this.lcgThongTIn.Padding = new DevExpress.XtraLayout.Utils.Padding(9, 9, 9, 12);
            this.lcgThongTIn.Size = new System.Drawing.Size(777, 298);
            this.lcgThongTIn.Text = "Thông tin cá nhân";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.txtManV;
            this.layoutControlItem1.Enabled = false;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(753, 42);
            this.layoutControlItem1.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem1.Text = "Mã #";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(97, 21);
            // 
            // lbHoTen
            // 
            this.lbHoTen.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbHoTen.AppearanceItemCaption.Options.UseFont = true;
            this.lbHoTen.Control = this.txtTenNV;
            this.lbHoTen.Location = new System.Drawing.Point(0, 42);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(753, 42);
            this.lbHoTen.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lbHoTen.Text = "Họ và tên";
            this.lbHoTen.TextSize = new System.Drawing.Size(97, 21);
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbNgaySinh.AppearanceItemCaption.Options.UseFont = true;
            this.lbNgaySinh.Control = this.deNgaySInh;
            this.lbNgaySinh.Location = new System.Drawing.Point(0, 84);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(376, 45);
            this.lbNgaySinh.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lbNgaySinh.Text = "Ngày sinh";
            this.lbNgaySinh.TextSize = new System.Drawing.Size(97, 21);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.Control = this.rbtnNam;
            this.layoutControlItem4.Location = new System.Drawing.Point(376, 84);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(188, 45);
            this.layoutControlItem4.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem5.Control = this.rbtnNu;
            this.layoutControlItem5.Location = new System.Drawing.Point(564, 84);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(189, 45);
            this.layoutControlItem5.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbDiaChi.AppearanceItemCaption.Options.UseFont = true;
            this.lbDiaChi.Control = this.txtDiaChi;
            this.lbDiaChi.Location = new System.Drawing.Point(0, 171);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(753, 74);
            this.lbDiaChi.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lbDiaChi.Text = "Địa chỉ";
            this.lbDiaChi.TextSize = new System.Drawing.Size(97, 21);
            // 
            // lbSDT
            // 
            this.lbSDT.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbSDT.AppearanceItemCaption.Options.UseFont = true;
            this.lbSDT.Control = this.txtSDT;
            this.lbSDT.Location = new System.Drawing.Point(0, 129);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(376, 42);
            this.lbSDT.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lbSDT.Text = "Số điện thoại";
            this.lbSDT.TextSize = new System.Drawing.Size(97, 21);
            // 
            // lbCCCD
            // 
            this.lbCCCD.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbCCCD.AppearanceItemCaption.Options.UseFont = true;
            this.lbCCCD.Control = this.txtCCCD;
            this.lbCCCD.Location = new System.Drawing.Point(376, 129);
            this.lbCCCD.Name = "lbCCCD";
            this.lbCCCD.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 2, 2, 2);
            this.lbCCCD.Size = new System.Drawing.Size(377, 42);
            this.lbCCCD.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lbCCCD.Text = "CCCD/CMND";
            this.lbCCCD.TextSize = new System.Drawing.Size(97, 21);
            // 
            // FrmDialogThongTinCaNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 348);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("FrmDialogThongTinCaNhan.IconOptions.Image")));
            this.Name = "FrmDialogThongTinCaNhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thay đổi thông tin cá nhân";
            this.Load += new System.EventHandler(this.FrmDialogThongTinCaNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCCCD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgaySInh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgaySInh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtManV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgThongTIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbHoTen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbNgaySinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbDiaChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbSDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbCCCD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.MemoEdit txtDiaChi;
        private DevExpress.XtraEditors.TextEdit txtCCCD;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private System.Windows.Forms.RadioButton rbtnNu;
        private System.Windows.Forms.RadioButton rbtnNam;
        private DevExpress.XtraEditors.DateEdit deNgaySInh;
        private DevExpress.XtraEditors.TextEdit txtTenNV;
        private DevExpress.XtraEditors.TextEdit txtManV;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem lbHoTen;
        private DevExpress.XtraLayout.LayoutControlItem lbNgaySinh;
        private DevExpress.XtraLayout.LayoutControlItem lbSDT;
        private DevExpress.XtraLayout.LayoutControlItem lbCCCD;
        private DevExpress.XtraLayout.LayoutControlItem lbDiaChi;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlGroup lcgThongTIn;
    }
}