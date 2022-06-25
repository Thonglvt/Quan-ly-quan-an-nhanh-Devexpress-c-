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
    public partial class FrmDialogDoiPass : DevExpress.XtraEditors.XtraForm
    {
        BLL_TaiKhoan bllTk;
        public FrmDialogDoiPass()
        {
            InitializeComponent();
        }
        private void FrmDialogDoiPass_Load(object sender, EventArgs e)
        {
            txtPassOld.Focus();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(txtPassOld.Text.Trim()==string.Empty)
            {
                XtraMessageBox.Show("Vui lòng nhập mật khẩu cũ.", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassOld.Focus();
                return;
            }
            if (txtPassNew.Text.Trim() == string.Empty)
            {
                XtraMessageBox.Show("Vui lòng nhập mật khẩu mới.", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassNew.Focus();
                return;
            }
            if (txtPassConfirm.Text.Trim() == string.Empty)
            {
                XtraMessageBox.Show("Vui lòng xác nhận mật khẩu mới.", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassConfirm.Focus();
                return;
            }
            if(!txtPassNew.Text.Trim().Equals(txtPassConfirm.Text.Trim()))
            {
                XtraMessageBox.Show("Mật khẩu xác nhận không khớp với mật khẩu mới.", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassConfirm.Focus();
                return;
            }

            bllTk = new BLL_TaiKhoan();
            //Check pass cũ
            var check = bllTk.getAll().FirstOrDefault(t => t.username == DTO_SessionLogin.username 
            && t.password == BLL_HamXuLy.MaHoaMD5(txtPassOld.Text.Trim()));
            if(check==null)
            {
                XtraMessageBox.Show("Mật khẩu cũ không chính xác.", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassOld.Focus();
                return;
            }
            tblTaiKhoan tk = new tblTaiKhoan();
            tk.username = check.username;
            tk.password = BLL_HamXuLy.MaHoaMD5(txtPassConfirm.Text);
            tk.active = check.active;

            string kqDoiPass = bllTk.doiMatKhau(tk);
            if(kqDoiPass.Equals("1"))
            {
                XtraMessageBox.Show("Đổi mật khẩu thành công.", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            XtraMessageBox.Show("Error: "+ kqDoiPass, "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

     
    }
}