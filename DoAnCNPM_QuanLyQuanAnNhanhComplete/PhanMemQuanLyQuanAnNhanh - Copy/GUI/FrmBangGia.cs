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
using DTO;
using BLL;

namespace GUI
{
    public partial class FrmBangGia : DevExpress.XtraEditors.XtraForm
    {
        BLL_BangGia bllBG;
        BLL_SanPham bllSP;
        BLL_Size bllSize;
        BLL_ChiTietHoaDonBanHang bllCTHD;
        public FrmBangGia()
        {
            InitializeComponent();
        }
        #region Method
        void loadData()
        {
            bllBG = new BLL_BangGia();
            gcSP.DataSource = bllBG.getAll();
        }
        void loadSLE_SP()
        {
            bllSP = new BLL_SanPham();
            sleSP.Properties.DataSource = bllSP.getAll();
            sleSP.Properties.DisplayMember = "TenSP";
            sleSP.Properties.ValueMember = "MaSP";

        }
        void loadSLE_Size()
        {
            bllSize = new BLL_Size();
            sleSize.Properties.DataSource = bllSize.getAll();
            sleSize.Properties.DisplayMember = "MaSize";
            sleSize.Properties.ValueMember = "MaSize";
        }
        void dongMoGiaoTac()
        {
            btnThem.Enabled = !btnThem.Enabled;
            btnLuuMoi.Enabled = !btnLuuMoi.Enabled;
            btnHuy.Enabled = !btnHuy.Enabled;
            lcgNhapTT.Enabled = !lcgNhapTT.Enabled;
        }
        #endregion

        #region Event
        private void FrmBangGia_Load(object sender, EventArgs e)
        {
            loadData();
            btnXoa.Click += BtnXoa_Click;
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            bllBG = new BLL_BangGia();
            bllCTHD = new BLL_ChiTietHoaDonBanHang();
            //Check khóa ngoại
            var maBG = gvSP.GetRowCellValue(gvSP.FocusedRowHandle, gvSP.Columns["MaBangGia"]);
            var check = bllCTHD.getAll().FirstOrDefault(t => t.MaBangGia == Convert.ToInt32(maBG));
            if(check!=null)
            {
                XtraMessageBox.Show("Không thể xóa (Vì bảng giá này đã được sử dụng)", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (XtraMessageBox.Show("Xác nhận xóa?", "Thông báo [Message]", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string kqDel = bllBG.delete(Convert.ToInt32(maBG));
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

        private void sleSP_BeforePopup(object sender, EventArgs e)
        {
            loadSLE_SP();
        }
        private void sleSize_BeforePopup(object sender, EventArgs e)
        {
            loadSLE_Size();
        }
        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadData();
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dongMoGiaoTac();
        }

        private void btnLuuMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(sleSP.EditValue==null)
            {
                XtraMessageBox.Show("Vui lòng chọn " + lbSanPham.Text, "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sleSP.Focus();
                return;
            }
            if (sleSize.EditValue == null)
            {
                XtraMessageBox.Show("Vui lòng chọn " + lbSize.Text, "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sleSize.Focus();
                return;
            }
            if (txtGiaBan.Value <= 0)
            {
                XtraMessageBox.Show("Vui lòng nhập " + lbGiaBan.Text, "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGiaBan.Focus();
                return;
            }
            //Check sản phẩm thuộc size đã có giá
            var check = bllBG.getAll().FirstOrDefault(t => t.MaSP == sleSP.EditValue.ToString() && t.MaSize == sleSize.EditValue.ToString());
            if(check!=null)
            {
                XtraMessageBox.Show("Sản phẩm thuộc size này đã có giá.", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //
            tblBangGia bg = new tblBangGia();
            bg.MaSP = sleSP.EditValue.ToString();
            bg.MaSize = sleSize.EditValue.ToString();
            bg.Gia = Convert.ToDouble(txtGiaBan.Value);
            bg.NgayCapNhat = DateTime.Now;

            string kqIns = bllBG.insert(bg);
            if (kqIns.Equals("1"))
            {
                XtraMessageBox.Show("Thêm thành công.", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.None);
                dongMoGiaoTac();
                loadData();
                return;
            }
            XtraMessageBox.Show("Error: "+kqIns, "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);


            
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dongMoGiaoTac();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        #endregion


    }
}