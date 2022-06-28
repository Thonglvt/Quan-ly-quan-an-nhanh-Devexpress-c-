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
    public partial class FrmSanPham : DevExpress.XtraEditors.XtraForm
    {
        BLL_SanPham bllSP;
        BLL_NhomSanPham bllNhomSP;
        BLL_BangGia bllBG;
        string filePath;
        public FrmSanPham()
        {
            InitializeComponent();
        }
        #region Method
        void loadData()
        {
            bllSP = new BLL_SanPham();
            gcSP.DataSource = bllSP.getAll();
        }
        void loadSLE_GC()
        {
            bllNhomSP = new BLL_NhomSanPham();
            sleNhomSP_GC.DataSource = bllNhomSP.getAll();
            sleNhomSP_GC.DisplayMember = "TenNhomSP";
            sleNhomSP_GC.ValueMember = "MaNhomSP";
        }
        void loadSLENhomSP()
        {
            bllNhomSP = new BLL_NhomSanPham();
            sleNhomSP.Properties.DataSource = bllNhomSP.getAll();
            sleNhomSP.Properties.DisplayMember = "TenNhomSP";
            sleNhomSP.Properties.ValueMember = "MaNhomSP";
        }
        #endregion

        #region Event
        private void FrmMonAn_Load(object sender, EventArgs e)
        {
            loadSLE_GC();
            loadData();
            btnLuu.Click += BtnLuu_Click;
            btnXoa.Click += BtnXoa_Click;
        }
        private void BtnXoa_Click(object sender, EventArgs e)
        {
            //Check khóa ngoại trên tblBangGia
            bllBG = new BLL_BangGia();
            var maSP = gvSP.GetRowCellValue(gvSP.FocusedRowHandle, gvSP.Columns["MaSP"]);
            var check = bllBG.getAll().FirstOrDefault(t => t.MaSP == maSP.ToString());
            if (check != null)
            {
                XtraMessageBox.Show("Không thể xóa (Vì sản phẩm này đã được đặt giá).", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (XtraMessageBox.Show("Xác nhận xóa?", "Thông báo [Message]",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string kqDel = bllSP.delete(maSP.ToString());
                if (kqDel.Equals("1"))
                {
                    XtraMessageBox.Show("Xóa thành công.", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.None);
                    dongMoGiaoTac();
                    loadData();
                    return;
                }
                XtraMessageBox.Show("Error: " + kqDel, "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            bllSP = new BLL_SanPham();
            var maSP = gvSP.GetRowCellValue(gvSP.FocusedRowHandle, gvSP.Columns["MaSP"]);
            var tenSP = gvSP.GetRowCellValue(gvSP.FocusedRowHandle, gvSP.Columns["TenSP"]);
            var maNhom = gvSP.GetRowCellValue(gvSP.FocusedRowHandle, gvSP.Columns["MaNhomSP"]);
            var trangThai = gvSP.GetRowCellValue(gvSP.FocusedRowHandle, gvSP.Columns["TrangThai"]);
            var hinh = gvSP.GetRowCellValue(gvSP.FocusedRowHandle, gvSP.Columns["Hinh"]);
            tblSanPham tblSanPham = new tblSanPham();
            tblSanPham.MaSP = maSP.ToString();
            tblSanPham.TenSP = tenSP.ToString();
            tblSanPham.MaNhomSP = maNhom.ToString();
            tblSanPham.TrangThai = Convert.ToBoolean(trangThai);

            
            if (XtraMessageBox.Show("Bạn muốn cập nhật?", "Thông báo [Message]",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string kqUp = bllSP.update(tblSanPham);
                if (kqUp.Equals("1"))
                {
                    XtraMessageBox.Show("Cập nhật thành công.", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.None);
                    dongMoGiaoTac();
                    loadData();
                    return;
                }
                XtraMessageBox.Show("Error: " + kqUp, "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void dongMoGiaoTac()
        {
            btnThem.Enabled = !btnThem.Enabled;
            btnLuuMoi.Enabled = !btnLuuMoi.Enabled;
            btnHuy.Enabled=!btnHuy.Enabled;
            btnDong.Enabled = !btnDong.Enabled;
            lcgThongTin.Enabled = !lcgThongTin.Enabled;
            lcgHinhAnh.Enabled = !lcgHinhAnh.Enabled;

            filePath = string.Empty;
        }
        void empty() {
            txtMaSP.Text = string.Empty;
            txtTenSP.Text = string.Empty;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bllSP = new BLL_SanPham();
            dongMoGiaoTac();
            empty();
            txtMaSP.Text = bllSP.AutoCreateID(10, true);
        }

        private void btnLuuMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(txtMaSP.Text == string.Empty)
            {
                XtraMessageBox.Show("Vui lòng nhập "+lbMaSP.Text, "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaSP.Focus();
                return;
            }
            if (txtTenSP.Text == string.Empty)
            {
                XtraMessageBox.Show("Vui lòng nhập " + lbTenSP.Text, "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenSP.Focus();
                return;
            }
            if (sleNhomSP.EditValue == null)
            {
                XtraMessageBox.Show("Vui lòng chọn " + lbNhomMon.Text, "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sleNhomSP.Focus();
                return;
            }
            tblSanPham sp = new tblSanPham();
            sp.MaSP = txtMaSP.Text;
            sp.TenSP = txtTenSP.Text.Trim();
            sp.Hinh = BLL_HamXuLy.imageToByArray(filePath);
            sp.MaNhomSP = sleNhomSP.EditValue.ToString();
            sp.TrangThai = true;

            string kqInsertSP = bllSP.insert(sp);
            if(kqInsertSP.Equals("1"))
            {
                XtraMessageBox.Show("Thêm thành công.", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.None);
                empty();
                dongMoGiaoTac();
                loadData();
                return;
            }
            XtraMessageBox.Show("Error: "+kqInsertSP, "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dongMoGiaoTac();
            empty();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadSLE_GC();
            loadData();
        }
        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBoxSource.Image = Image.FromFile(open.FileName);
                this.filePath = open.FileName;
            }
        }
        private void sleNhomSP_BeforePopup(object sender, EventArgs e)
        {
            loadSLENhomSP();
        }
        #endregion


    }
}