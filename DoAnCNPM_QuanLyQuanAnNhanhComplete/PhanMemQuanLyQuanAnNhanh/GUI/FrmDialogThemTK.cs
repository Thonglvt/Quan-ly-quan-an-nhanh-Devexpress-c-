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
    public partial class FrmDialogThemTK : DevExpress.XtraEditors.XtraForm
    {
        BLL_TaiKhoan bllTK;
        public delegate void GETDATA();
        public GETDATA guiFormCha;
        private string formName="";
        public FrmDialogThemTK(string formName)
        {
            InitializeComponent();
            this.formName = formName;
        }



        #region Method
        #endregion

        #region Event
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            //Check input
            if (!BLL_HamXuLy.CheckUsername(txtUsername.Text))
            {
                XtraMessageBox.Show(lbUsername.Text + " không đúng định dạng.", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (BLL_HamXuLy.CheckPassword(txtPass.Text))
            {
                XtraMessageBox.Show(lbPass.Text + " không đúng định dạng.\n- Chứa ít nhất 1 số" +
                    "\n- Một chữ hoa\n- Độ dài từ 8 ký tự trở lên", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtConfirmPass.Equals(txtPass.Text))
            {
                XtraMessageBox.Show(lbConfirmPass.Text + " không chính xác.", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Kiểm tra tồn tại username
            bllTK = new BLL_TaiKhoan();
            var check = bllTK.getAll().FirstOrDefault(t => t.username == txtUsername.Text);
            if(check!=null)
            {
                XtraMessageBox.Show(lbUsername.Text + " đã tồn tại.", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tblTaiKhoan tk = new tblTaiKhoan();
            tk.username = txtUsername.Text;
            tk.password = BLL_HamXuLy.MaHoaMD5(txtConfirmPass.Text);
            tk.active = chkActive.Checked;
            string kqIns = bllTK.insert(tk);
            if (kqIns.Equals("1"))
            {
                XtraMessageBox.Show("Đăng ký thành công.\nTài khoản " + tk.username + 
                    " sẽ có mật khẩu là " + tk.password, "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                if (this.formName.Equals(new FrmNguoiDung().Name) && guiFormCha != null)
                {
                    guiFormCha();
                }
                this.Close();
                return;
            }
            XtraMessageBox.Show("Error: "+kqIns, "Thông báo [Message]", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        #endregion


    }
}