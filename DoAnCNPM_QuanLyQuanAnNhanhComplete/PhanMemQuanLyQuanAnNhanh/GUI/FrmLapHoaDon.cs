using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class FrmLapHoaDon : DevExpress.XtraEditors.XtraForm
    {
        BLL_NhomSanPham bllNhomSP;
        BLL_BangGia bllBangGia;
        BLL_AutoCreateID bllAutoID;
        BLL_HoaDonBanHang bllHDBH;
        BLL_ChiTietHoaDonBanHang bllCTHDBH;
        BLL_KhuyenMai bllKM;

        List<DTO_HoaDon_KH_NV_BG_SP> lstChiTietDonHangTam = new List<DTO_HoaDon_KH_NV_BG_SP>();
        double tienThanhToan = 0;
        public FrmLapHoaDon()
        {
            InitializeComponent();
        }

        #region Method
        private void checkKhuyenMai()
        {
            bllKM = new BLL_KhuyenMai();
            var check = bllKM.getAll().FirstOrDefault(t => t.NgayBatDau <= DateTime.Now && t.NgayKetThuc >= DateTime.Now);
            if(check!=null)
            {
                txtGiamGia.Text = check.GiamGia.ToString();
                txtMoTaKM.Visible = !txtMoTaKM.Visible;
                txtMoTaKM.Text = "Chương trình khuyến mãi áp dụng từ ngày " + check.NgayBatDau.ToString()
                    + " đên ngày " + check.NgayKetThuc;
            }
        }
        private void loadSLE_NhomSP()
        {
            bllNhomSP = new BLL_NhomSanPham();
            sleNhomSP.Properties.DataSource = bllNhomSP.getAll();
            sleNhomSP.Properties.DisplayMember = "TenNhomSP";
            sleNhomSP.Properties.ValueMember = "MaNhomSP";

        }
        private void loadData()
        {
            bllBangGia = new BLL_BangGia();
            gcSP.DataSource = bllBangGia.getAll();
            gvSP.RowHeight = 110;
            gvSP.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent;

            //CheckKhuyenMai
            checkKhuyenMai();
        }
        private void dongMoGiaoTac()
        {
            btnTaoDon.Enabled = !btnTaoDon.Enabled;
            btnHuy.Enabled = !btnHuy.Enabled;
            btnThanhToan.Enabled = !btnThanhToan.Enabled;
            lcgGioHang.Enabled = !lcgGioHang.Enabled;
            colAddCTHD.Visible = !colAddCTHD.Visible;
        }
        int soLuongTmp;
        void getSoLuongFromFromCon(int soLuong)
        {
            soLuongTmp = soLuong;
        }
        void updateThanhTienTrenListTam()
        {
            foreach (DTO_HoaDon_KH_NV_BG_SP item in lstChiTietDonHangTam)
            {
                item.ThanhTien = item.SoLuong * item.DonGia;
            }
        }
        private void GanTxtTienThanhToan()
        {
            double tongTien = 0;
            foreach (var item in lstChiTietDonHangTam)
            {
                tongTien += item.SoLuong * item.DonGia;
            }
            
            tongTien = tongTien - (tongTien * Convert.ToDouble(txtGiamGia.Text) / 100);
            txtTienThanhToan.Text = string.Format("{0:0,0 đ}", tongTien);
            tienThanhToan = tongTien;
        }
        private void GanTienThua()
        {
            if (txtTienNhan.Text != string.Empty)
            {
                double tienThua = 0;
                double tienNhan = Convert.ToDouble(txtTienNhan.Text);
                tienThua = tienNhan - (lstChiTietDonHangTam.Sum(t => t.ThanhTien) - (lstChiTietDonHangTam.Sum(t => t.ThanhTien) * Convert.ToDouble(txtGiamGia.Text) / 100));
                txtTienThua.Text = tienThua <= 0 ? "0" : string.Format("{0:0,0 đ}", tienThua);
            }
        }
        #endregion

        #region Event
        private void FrmLapHoaDon_Load(object sender, EventArgs e)
        {
            loadData();
            btnAddCTHD.Click += BtnAddCTHD_Click;
            btnXoaCTDH.Click += BtnXoaCTDH_Click;
            txtNhanVien.Text = DTO_SessionLogin.MaNV + "-" + DTO_SessionLogin.TenNV;
        }

        private void BtnXoaCTDH_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn muốn xóa món này?", "Thông báo [Message]", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var maBangGia = gvCTHD.GetRowCellValue(gvCTHD.FocusedRowHandle, gvCTHD.Columns["MaBangGia"]);
                lstChiTietDonHangTam.Remove(lstChiTietDonHangTam.Find(t => t.MaBangGia == Convert.ToInt32(maBangGia)));
                gcChiTietDonHang.RefreshDataSource();
                GanTxtTienThanhToan();
                GanTienThua();
            }
        }

        private void BtnAddCTHD_Click(object sender, EventArgs e)
        {
            bllBangGia = new BLL_BangGia();
            var maBangGia = gvSP.GetRowCellValue(gvSP.FocusedRowHandle, gvSP.Columns["MaBangGia"]);
            DTO_BangGia_SanPham bgsp = bllBangGia.findByMaBangGia(Convert.ToInt32(maBangGia));

            //Mở formDialog số lượng và nhận dữ liệu từ formDialog số lượng 
            FrmDialogSoLuong frm = new FrmDialogSoLuong(bgsp);
            frm.guiFormCha = new FrmDialogSoLuong.GETDATA(getSoLuongFromFromCon);
            frm.ShowDialog();
            int a = soLuongTmp;

            //Tồn tại sản phẩm trong giỏ hàng update soLuong
            DTO_HoaDon_KH_NV_BG_SP find = lstChiTietDonHangTam.FirstOrDefault(t => t.MaBangGia == Convert.ToInt32(maBangGia));
           if(find !=null)
            {
                find.SoLuong += soLuongTmp;
                updateThanhTienTrenListTam();
                gcChiTietDonHang.RefreshDataSource();
                GanTxtTienThanhToan();
                GanTienThua();
                return;
            }    

            DTO_HoaDon_KH_NV_BG_SP bgKH = new DTO_HoaDon_KH_NV_BG_SP();
            bgKH.MaBangGia = Convert.ToInt32(maBangGia);
            bgKH.TenSP = gvSP.GetRowCellValue(gvSP.FocusedRowHandle, gvSP.Columns["TenSP"]).ToString();
            bgKH.MaSP = gvSP.GetRowCellValue(gvSP.FocusedRowHandle, gvSP.Columns["MaSP"]).ToString();
            bgKH.MaSize = gvSP.GetRowCellValue(gvSP.FocusedRowHandle, gvSP.Columns["MaSize"]).ToString();
            bgKH.SoLuong = soLuongTmp;
            bgKH.DonGia = Convert.ToDouble(gvSP.GetRowCellValue(gvSP.FocusedRowHandle, gvSP.Columns["Gia"]).ToString());
            lstChiTietDonHangTam.Add(bgKH);
            updateThanhTienTrenListTam();
            GanTxtTienThanhToan();
            GanTienThua();
            gcChiTietDonHang.DataSource = lstChiTietDonHangTam;
            gcChiTietDonHang.RefreshDataSource();
        }

        private void sleNhomSP_BeforePopup(object sender, EventArgs e)
        {
            loadSLE_NhomSP();
        }
        private void sleNhomSP_View_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            bllBangGia = new BLL_BangGia();

            var maNhom = sleNhomSP_View.GetRowCellValue(e.RowHandle, sleNhomSP_View.Columns["MaNhomSP"]);
            if(maNhom!=null)
            {
                gcSP.DataSource = bllBangGia.getAllByNhomSP(maNhom.ToString());
            }    
        }
        private void gvSP_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            //if (e.Column.FieldName == "TenSP")
            //{
            //    string giaKM = View.GetRowCellDisplayText(e.RowHandle, View.Columns["GiaSauKhuyenMai"]);
            //    string Gia = View.GetRowCellDisplayText(e.RowHandle, View.Columns["GiaBan"]);
            //    if (!giaKM.Equals(Gia))
            //    {
            //        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
            //        e.Appearance.ForeColor = Color.Green;
            //    }
            //}
        }
        private void btnTaoDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnTaoDon.Enabled = !btnTaoDon.Enabled;
            btnHuy.Enabled = !btnHuy.Enabled;
            btnThanhToan.Enabled = !btnThanhToan.Enabled;
            lcgGioHang.Enabled = !lcgGioHang.Enabled;
            lbStatusDon.Caption = "Đang tạo đơn...";
            colAddCTHD.Visible = !colAddCTHD.Visible;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dongMoGiaoTac();
            lbStatusDon.Caption = "Đang trống.";
            lstChiTietDonHangTam = new List<DTO_HoaDon_KH_NV_BG_SP>();
            gcChiTietDonHang.DataSource = lstChiTietDonHangTam;
            txtTienThanhToan.Text = "0";
        }

        private void btnThanhToan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bllAutoID = new BLL_AutoCreateID();
            bllHDBH = new BLL_HoaDonBanHang();
            bllCTHDBH = new BLL_ChiTietHoaDonBanHang();
            if (XtraMessageBox.Show("Xác nhận thanh toán?", "Thông báo [Message]", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Thêm hóa đơn
                tblHoaDonBanHang hdbh = new tblHoaDonBanHang();
                hdbh.MaHD = bllAutoID.create_ID_HD();
                hdbh.MaNV = DTO_SessionLogin.MaNV;
                hdbh.MaKH = "06062022KH000001";
                hdbh.NgayLap = DateTime.Now;
                hdbh.PhuThu = 0;
                hdbh.GiamGia = 0;
                hdbh.TongTien = 0;
                hdbh.TrangThai = true;
                string kqInsHD = bllHDBH.insert(hdbh);
                if (!kqInsHD.Equals("1"))
                {
                    XtraMessageBox.Show("Error: " + kqInsHD, "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //Thêm chi tiết hóa đơn
                foreach (var item in lstChiTietDonHangTam)
                {
                    tblChiTietHD cthd = new tblChiTietHD();
                    cthd.MaHD = hdbh.MaHD;
                    cthd.MaBangGia = item.MaBangGia;
                    cthd.SoLuong = item.SoLuong;
                    cthd.DonGia = 0;
                    cthd.ThanhTien = 0;

                    string kqInsCTDH = bllCTHDBH.insert(cthd);
                    if (!kqInsCTDH.Equals("1"))
                    {
                        XtraMessageBox.Show("Error: " + kqInsCTDH, "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                //update giam gia
                hdbh.GiamGia = Convert.ToInt32(txtGiamGia.Text);
                string kqUpdaHD = bllHDBH.update(hdbh);
                XtraMessageBox.Show("Đã tạo hóa đơn có mã #" + hdbh.MaHD, "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                //Mở report
                bllHDBH = new BLL_HoaDonBanHang();
                List<DTO_HoaDon_KH_NV_BG_SP> lstPXKH = bllHDBH.getAllByMaHD(hdbh.MaHD);
                using (FrmPrint frm = new FrmPrint())
                {
                    double tienNhan = string.IsNullOrEmpty(txtTienNhan.Text) ? 0 : Convert.ToDouble(txtTienNhan.Text);

                    //double tienThua = string.IsNullOrEmpty(txtTienThua.Text) ? 0 : Convert.ToDouble(txtTienThua.Text);
                    double tongTien = lstPXKH.Select(t => t.TongTien).First();
                    double giamGia = lstPXKH.Select(t => t.GiamGia).First();
                    double tienThua = tienNhan - tongTien;

                    frm.printInvoice(lstPXKH, tienNhan,tienThua);
                    frm.ShowDialog();
                }
                //
                dongMoGiaoTac();
                lbStatusDon.Caption = "Đơn trống.";
                lstChiTietDonHangTam = new List<DTO_HoaDon_KH_NV_BG_SP>();
                gcChiTietDonHang.DataSource = lstChiTietDonHangTam;
                txtTienThanhToan.Text = "0";
                txtTienNhan.Text = string.Empty;
                txtTienThua.Text = "0";
            }
        }
        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadData();
        }
        private void txtTienNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtTienNhan_EditValueChanged(object sender, EventArgs e)
        {
            GanTienThua();
        }
        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        #endregion


    }
}