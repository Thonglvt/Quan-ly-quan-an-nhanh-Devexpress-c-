
namespace GUI
{
    partial class FrmDialogDoiPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDialogDoiPass));
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.txtPassOld = new DevExpress.XtraEditors.TextEdit();
            this.lbPassOld = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtPassNew = new DevExpress.XtraEditors.TextEdit();
            this.lbPassNew = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtPassConfirm = new DevExpress.XtraEditors.TextEdit();
            this.lbConfirm = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassOld.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbPassOld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassNew.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbPassNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassConfirm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            this.SuspendLayout();
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.layoutControl1);
            this.lcMain.Controls.Add(this.btnExit);
            this.lcMain.Controls.Add(this.btnConfirm);
            this.lcMain.Controls.Add(this.txtPassConfirm);
            this.lcMain.Controls.Add(this.txtPassNew);
            this.lcMain.Controls.Add(this.txtPassOld);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 0);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.Root;
            this.lcMain.Size = new System.Drawing.Size(544, 206);
            this.lcMain.TabIndex = 0;
            this.lcMain.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lbPassOld,
            this.lbPassNew,
            this.lbConfirm,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(544, 206);
            this.Root.TextVisible = false;
            // 
            // txtPassOld
            // 
            this.txtPassOld.Location = new System.Drawing.Point(203, 17);
            this.txtPassOld.Name = "txtPassOld";
            this.txtPassOld.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtPassOld.Properties.Appearance.Options.UseFont = true;
            this.txtPassOld.Properties.PasswordChar = '*';
            this.txtPassOld.Size = new System.Drawing.Size(324, 28);
            this.txtPassOld.StyleController = this.lcMain;
            this.txtPassOld.TabIndex = 4;
            // 
            // lbPassOld
            // 
            this.lbPassOld.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbPassOld.AppearanceItemCaption.Options.UseFont = true;
            this.lbPassOld.Control = this.txtPassOld;
            this.lbPassOld.Location = new System.Drawing.Point(0, 0);
            this.lbPassOld.Name = "lbPassOld";
            this.lbPassOld.Size = new System.Drawing.Size(524, 42);
            this.lbPassOld.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lbPassOld.Text = "Mật khẩu cũ";
            this.lbPassOld.TextSize = new System.Drawing.Size(174, 21);
            // 
            // txtPassNew
            // 
            this.txtPassNew.Location = new System.Drawing.Point(203, 59);
            this.txtPassNew.Name = "txtPassNew";
            this.txtPassNew.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtPassNew.Properties.Appearance.Options.UseFont = true;
            this.txtPassNew.Properties.PasswordChar = '*';
            this.txtPassNew.Size = new System.Drawing.Size(324, 28);
            this.txtPassNew.StyleController = this.lcMain;
            this.txtPassNew.TabIndex = 5;
            // 
            // lbPassNew
            // 
            this.lbPassNew.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbPassNew.AppearanceItemCaption.Options.UseFont = true;
            this.lbPassNew.Control = this.txtPassNew;
            this.lbPassNew.Location = new System.Drawing.Point(0, 42);
            this.lbPassNew.Name = "lbPassNew";
            this.lbPassNew.Size = new System.Drawing.Size(524, 42);
            this.lbPassNew.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lbPassNew.Text = "Mật khẩu mới";
            this.lbPassNew.TextSize = new System.Drawing.Size(174, 21);
            // 
            // txtPassConfirm
            // 
            this.txtPassConfirm.Location = new System.Drawing.Point(203, 101);
            this.txtPassConfirm.Name = "txtPassConfirm";
            this.txtPassConfirm.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtPassConfirm.Properties.Appearance.Options.UseFont = true;
            this.txtPassConfirm.Properties.PasswordChar = '*';
            this.txtPassConfirm.Size = new System.Drawing.Size(324, 28);
            this.txtPassConfirm.StyleController = this.lcMain;
            this.txtPassConfirm.TabIndex = 6;
            // 
            // lbConfirm
            // 
            this.lbConfirm.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbConfirm.AppearanceItemCaption.Options.UseFont = true;
            this.lbConfirm.Control = this.txtPassConfirm;
            this.lbConfirm.Location = new System.Drawing.Point(0, 84);
            this.lbConfirm.Name = "lbConfirm";
            this.lbConfirm.Size = new System.Drawing.Size(524, 42);
            this.lbConfirm.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lbConfirm.Text = "Xác nhận mật khẩu mới";
            this.lbConfirm.TextSize = new System.Drawing.Size(174, 21);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnConfirm.Appearance.Options.UseFont = true;
            this.btnConfirm.ImageOptions.SvgImage = global::GUI.Properties.Resources.checkbox1;
            this.btnConfirm.Location = new System.Drawing.Point(328, 143);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(107, 44);
            this.btnConfirm.StyleController = this.lcMain;
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.Control = this.btnConfirm;
            this.layoutControlItem4.Location = new System.Drawing.Point(311, 126);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(121, 60);
            this.layoutControlItem4.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // btnExit
            // 
            this.btnExit.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.ImageOptions.SvgImage = global::GUI.Properties.Resources.actions_deletecircled4;
            this.btnExit.Location = new System.Drawing.Point(449, 143);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(78, 44);
            this.btnExit.StyleController = this.lcMain;
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem5.Control = this.btnExit;
            this.layoutControlItem5.Location = new System.Drawing.Point(432, 126);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(92, 60);
            this.layoutControlItem5.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Location = new System.Drawing.Point(12, 138);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(307, 56);
            this.layoutControl1.TabIndex = 9;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.layoutControl1;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 126);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(311, 60);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(307, 56);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // FrmDialogDoiPass
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 206);
            this.Controls.Add(this.lcMain);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("FrmDialogDoiPass.IconOptions.Image")));
            this.MinimizeBox = false;
            this.Name = "FrmDialogDoiPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐỔI MẬT KHẨU";
            this.Load += new System.EventHandler(this.FrmDialogDoiPass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassOld.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbPassOld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassNew.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbPassNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassConfirm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnConfirm;
        private DevExpress.XtraEditors.TextEdit txtPassConfirm;
        private DevExpress.XtraEditors.TextEdit txtPassNew;
        private DevExpress.XtraEditors.TextEdit txtPassOld;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem lbPassOld;
        private DevExpress.XtraLayout.LayoutControlItem lbPassNew;
        private DevExpress.XtraLayout.LayoutControlItem lbConfirm;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}