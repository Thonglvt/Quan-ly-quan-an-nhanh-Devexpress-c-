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
    public partial class FrmNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        BLL_TaiKhoan bllTK;
        BLL_NhanVien bllNV;
        bool confirm = false;
        public FrmNguoiDung()
        {
            InitializeComponent();
        }

        #region Method
        void loadData()
        {
            bllTK = new BLL_TaiKhoan();
            gcTK.DataSource = bllTK.getTK_NV();
        }
        void loadSLE()
        {
            bllNV = new BLL_NhanVien();
            sleNhanVien_GC.DataSource = bllNV.getAll();
            sleNhanVien_GC.DisplayMember = "TenNV";
            sleNhanVien_GC.ValueMember = "MaNV";
        }
        void chuyenDoiConfirm()
        {
            this.confirm = !this.confirm;
        }
        #endregion


        #region Event
        private void FrmNguoiDung_Load(object sender, EventArgs e)
        {
            loadSLE();
            loadData();
            btnLuu_GC.Click += BtnLuu_GC_Click;
            btnXoaTK.Click += BtnXoaTK_Click;
        }

        private void BtnXoaTK_Click(object sender, EventArgs e)
        {
            var username = gvTk.GetRowCellValue(gvTk.FocusedRowHandle, gvTk.Columns["username"]);
            //check tài khoản có người sử dụng
            bllNV = new BLL_NhanVien();
            var check = bllNV.getAll().FirstOrDefault(t => t.username == username.ToString());
            if (check != null)
            {
                XtraMessageBox.Show("Không thể xóa (Vì tài khoản này đã có người sở hữu)", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(username.Equals("admin"))
            {
                XtraMessageBox.Show("Không thể xóa tài khoản này.", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
            if (XtraMessageBox.Show("Xác nhận xóa?", "Thông báo [Message]", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FrmXacNhanPass frm = new FrmXacNhanPass(this.Name);
                frm.guiFormCha = new FrmXacNhanPass.GETDATA(chuyenDoiConfirm);
                frm.ShowDialog();

                if(this.confirm==true)
                {
                    bllTK = new BLL_TaiKhoan();
                    string kqDel = bllTK.delete(username.ToString());
                    if(kqDel.Equals("1"))
                        XtraMessageBox.Show("Xóa thành công tài khoản "+username.ToString(), "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                        XtraMessageBox.Show("Error: "+kqDel, "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    loadData();
                    chuyenDoiConfirm();
                }    
            }
        }
        private void BtnLuu_GC_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Xác nhận cập nhật?", "Thông báo [Message]", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var maNV = gvTk.GetRowCellValue(gvTk.FocusedRowHandle, gvTk.Columns["MaNV"]);
                var username = gvTk.GetRowCellValue(gvTk.FocusedRowHandle, gvTk.Columns["username"]);
                var active = gvTk.GetRowCellValue(gvTk.FocusedRowHandle, gvTk.Columns["active"]);

                tblTaiKhoan tk = new tblTaiKhoan();
                tk.username = username.ToString();
                tk.active = Convert.ToBoolean(active);
                string kqUpdTK = bllTK.CapNhatTrangThai(tk);
                if (!kqUpdTK.Equals("1"))
                {
                    XtraMessageBox.Show("Error: " + kqUpdTK, "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (maNV != null)
                {
                    bllNV = new BLL_NhanVien();
                    bllTK = new BLL_TaiKhoan();
                    var checkNV_TK_TB = bllNV.getAll().FirstOrDefault(t => t.MaNV == maNV.ToString()&&t.username == username.ToString());

                    var checkNV_TK = bllNV.getAll().FirstOrDefault(t => t.MaNV == maNV.ToString());

                    if (!string.IsNullOrEmpty(checkNV_TK.username) && checkNV_TK_TB==null)
                    {
                        XtraMessageBox.Show("Cập nhật thất bại (Nhân viên này đã có tài khoản).", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        loadData();
                        return;
                    }
                    string kqUpdNV = bllNV.update_TK_NV(maNV.ToString(), username.ToString());
                    if (kqUpdNV.Equals("1"))
                    {
                        XtraMessageBox.Show("Cập nhật thành công.", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        XtraMessageBox.Show("Error: " + kqUpdNV, "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
               
                loadData();

            }
        }

        private void sleNhanVien_GC_BeforePopup(object sender, EventArgs e)
        {
            //loadSLE();
        }
        private void btnThemTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDialogThemTK frm = new FrmDialogThemTK(this.Name);
            frm.guiFormCha = new FrmDialogThemTK.GETDATA(loadData);
            frm.ShowDialog();
        }
        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        #endregion


    }
}