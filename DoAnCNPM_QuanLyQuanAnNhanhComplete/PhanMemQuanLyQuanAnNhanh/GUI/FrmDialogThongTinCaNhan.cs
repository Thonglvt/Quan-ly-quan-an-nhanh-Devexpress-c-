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
    public partial class FrmDialogThongTinCaNhan : DevExpress.XtraEditors.XtraForm
    {
        BLL_NhanVien bllNV;
        tblNhanVien nv;
        public FrmDialogThongTinCaNhan()
        {
            InitializeComponent();
        }

        #region Method
        void dongMoGiaoTac()
        {
            btnLuu.Enabled = !btnLuu.Enabled;
            btnHuy.Enabled = !btnHuy.Enabled;
            lcgThongTIn.Enabled = !lcgThongTIn.Enabled;
            btnSua.Enabled = !btnSua.Enabled;
        }
        void loadData()
        {
            bllNV = new BLL_NhanVien();
            var user = bllNV.getAll().FirstOrDefault(t => t.username == DTO_SessionLogin.username);
            if(user!=null)
            {
                nv = (tblNhanVien)user;
                txtManV.Text = user.MaNV;
                txtSDT.Text = user.SDT;
                txtTenNV.Text = user.TenNV;
                txtDiaChi.Text = user.DiaChi;
                txtCCCD.Text = user.CCCD;
                if(user.GioiTinh.Equals("Nam"))
                    rbtnNam.Checked=true;
                else
                    rbtnNu.Checked = true;
                deNgaySInh.EditValue = user.NgaySinh;
            }    
        }
        #endregion



        #region Event
        private void FrmDialogThongTinCaNhan_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dongMoGiaoTac();
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //check input
            if(txtTenNV.Text == string.Empty)
            {
                XtraMessageBox.Show("Vui lòng nhập "+lbHoTen.Text, "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtSDT.Text == string.Empty)
            {
                XtraMessageBox.Show("Vui lòng nhập "+lbSDT.Text, "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtCCCD.Text == string.Empty)
            {
                XtraMessageBox.Show("Vui lòng nhập " + lbCCCD.Text, "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtDiaChi.Text == string.Empty)
            {
                XtraMessageBox.Show("Vui lòng nhập " + lbDiaChi.Text, "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!BLL_HamXuLy.CheckPhone(txtSDT.Text))
            {
                XtraMessageBox.Show(lbSDT.Text +" không đúng định dạng", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bllNV = new BLL_NhanVien();
            var checkTonTaiSDT = bllNV.getAll().FirstOrDefault(t => t.SDT == txtSDT.Text && t.SDT != nv.SDT);
            if(checkTonTaiSDT != null)
            {
                XtraMessageBox.Show(lbSDT.Text + " đã tồn tại.", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var checkTonTaiCCCD = bllNV.getAll().FirstOrDefault(t => t.CCCD == txtCCCD.Text && t.CCCD != nv.CCCD);
            if (checkTonTaiCCCD != null)
            {
                XtraMessageBox.Show(lbCCCD.Text + " đã tồn tại.", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tblNhanVien nvUp = new tblNhanVien();
            nvUp.MaNV = nv.MaNV;
            nvUp.TenNV = txtTenNV.Text;
            nvUp.SDT = txtSDT.Text;
            nvUp.CCCD = txtCCCD.Text;
            nvUp.DiaChi = txtDiaChi.Text;
            nvUp.NgaySinh = Convert.ToDateTime(deNgaySInh.EditValue);
            nvUp.GioiTinh = (rbtnNam.Checked == true) ? "Nam" : "Nữ";

            string kqUpd = bllNV.update(nvUp);
            if (kqUpd.Equals("1"))
            {
                XtraMessageBox.Show("Cập nhật thông tin thành công.", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            XtraMessageBox.Show("Error: "+ kqUpd, "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            dongMoGiaoTac();
            loadData();
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dongMoGiaoTac();
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadData();
        }
        #endregion

        
    }
}