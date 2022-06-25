using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Ribbon;

namespace GUI
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BLL_NhanVien bllNV = new BLL_NhanVien();
        BLL_Menu bllMenu = new BLL_Menu();
        BLL_PhanQuyen bllPQ = new BLL_PhanQuyen();
        public FrmMain()
        {
            InitializeComponent();
        }

        #region Method
        //Hàm thêm form vào main form
        void addForm(Type tForm)
        {
            //Kiểm tra hiện tại form đã mở hay chưa?
            foreach (Form frm in MdiChildren)
            {
                //Nếu đang mở thì active lên
                if (frm.GetType() == tForm)
                {
                    frm.Activate();
                    return;
                }
            }
            //Add form vào Control
            Form f = (Form)Activator.CreateInstance(tForm);
            f.MdiParent = this;
            f.Show();
        }
        void skin()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Office 2016 Colorful";
        }

        void AddOrUpdateChucNangHeThong()
        {
            bllMenu = new BLL_Menu();
            //Vào menu tổng
            foreach (RibbonPage page in ribbon.Pages)
            {
                if (bllMenu.kiemTraChucNangDaTonTai(page.Name))//Cập nhật
                {
                    bool kq = bllMenu.ChekUpdateTowParameter(page.Name, page.Text);
                }
                else//Thêm mới
                {
                    bool kq = bllMenu.ChekAddTowParam(page.Name, page.Text.Trim());
                }
                //Vào group menu
                foreach (RibbonPageGroup pageGroup in page.Groups)
                {
                    if (bllMenu.kiemTraChucNangDaTonTai(pageGroup.Name))
                    {
                        bool kq = bllMenu.ChekUpdateThreeParameter(pageGroup.Name, pageGroup.Text, page.Name);
                    }
                    else
                    {
                        bool kq = bllMenu.ChekAddThreeParam(pageGroup.Name, pageGroup.Text, page.Name);
                    }
                    //Vào button
                    foreach (BarItemLink barItemLink in pageGroup.ItemLinks)
                    {
                        if (bllMenu.kiemTraChucNangDaTonTai(barItemLink.Item.Name))
                        {
                            bool kq = bllMenu.ChekUpdateThreeParameter(barItemLink.Item.Name, barItemLink.Item.Caption, pageGroup.Name);
                        }
                        else
                        {
                            bool kq = bllMenu.ChekAddThreeParam(barItemLink.Item.Name, barItemLink.Item.Caption, pageGroup.Name);
                        }
                    }
                }
            }
        }
        public void loadRights()
        {
            bllPQ = new BLL_PhanQuyen();
            var dt = bllPQ.getRightsByNhomNoJoin(DTO_SessionLogin.username);

            foreach (RibbonPage page in ribbon.Pages)//Vào menu tổng
            {
                foreach (var item in dt)
                {
                    if (item.MaMenu == page.Name && item.CoQuyen == false)
                    {
                        page.Visible = false;
                    }
                }
                foreach (RibbonPageGroup pageGroup in page.Groups)//Vào group menu
                {
                    foreach (var item in dt)
                    {
                        if (item.MaMenu == pageGroup.Name && item.CoQuyen == false)
                        {
                            pageGroup.Visible = false;
                        }
                    }
                    foreach (BarItemLink barItemLink in pageGroup.ItemLinks)
                    {
                        foreach (var item in dt)
                        {
                            if (item.MaMenu == barItemLink.Item.Name && item.CoQuyen == false)
                            {
                                barItemLink.Visible = false;
                            }
                        }
                    }
                }
            }
        }

        #endregion


        #region Event
        private void FrmMain_Load(object sender, EventArgs e)
        {
            skin();
            AddOrUpdateChucNangHeThong();
            loadRights();
            lbThongTinNhanVien.Caption = "( " + DTO_SessionLogin.MaNV + " - "
                                                + DTO_SessionLogin.TenNV + " )";
        }
        private void btnLapHoaDon_ItemClick(object sender, ItemClickEventArgs e)
        {
            //addForm(typeof(FrmLapHoaDon));
            FrmLapHoaDon frm = new FrmLapHoaDon();
            frm.Show();
        }
        private void btnMonAn_ItemClick(object sender, ItemClickEventArgs e)
        {
            addForm(typeof(FrmSanPham));
        }

        private void btnBangGia_ItemClick(object sender, ItemClickEventArgs e)
        {
            addForm(typeof(FrmBangGia));

        }
        private void btnKhuyenMai_ItemClick(object sender, ItemClickEventArgs e)
        {
            addForm(typeof(FrmKhuyenMai));
        }
        private void btnDoiPass_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmDialogDoiPass frm = new FrmDialogDoiPass();
            frm.ShowDialog();
        }
        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmDangNhap frm = new FrmDangNhap();
            frm.Show();
            this.Close();
        }
        private void btnTTCN_ItemClick(object sender, ItemClickEventArgs e)
        {
            bllNV = new BLL_NhanVien();
            //kiểm tra tài khoản thuộc user
            var check = bllNV.getAll().FirstOrDefault(t => t.username == DTO_SessionLogin.username);
            if (check == null)
            {
                XtraMessageBox.Show("Tài khoản này chưa đăng ký thông tin.", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FrmDialogThongTinCaNhan frm = new FrmDialogThongTinCaNhan();
            frm.ShowDialog();
        }
        private void btnNguoiDung_ItemClick(object sender, ItemClickEventArgs e)
        {
            addForm(typeof(FrmNguoiDung));
        }
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (XtraMessageBox.Show("Xác nhận thoát?", "Thông báo [Message]", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            //{
            //    e.Cancel = true;
            //}
            //
            //if (e.CloseReason == CloseReason.UserClosing)
            //{
            //    dynamic result = MessageBox.Show("Do You Want To Exit?", "Application Name", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (result == DialogResult.Yes)
            //    {
            //        Application.Exit();
            //    }

            //    if (result == DialogResult.No)
            //    {
            //        e.Cancel = true;
            //    }
            //}
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnNhomND_ItemClick(object sender, ItemClickEventArgs e)
        {
            addForm(typeof(FrmNhomNguoiDung));
        }
        private void btnPhanQuyen_ItemClick(object sender, ItemClickEventArgs e)
        {
            addForm(typeof(FrmPhanQuyen));
        }
        #endregion


    }
}