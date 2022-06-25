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
    public partial class FrmXacNhanPass : DevExpress.XtraEditors.XtraForm
    {
        BLL_TaiKhoan bllTK;
        public delegate void GETDATA();
        public GETDATA guiFormCha;
        string formName="";
        public FrmXacNhanPass(string formName)
        {
            InitializeComponent();
            this.formName = formName;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bllTK = new BLL_TaiKhoan();
            var check = bllTK.getAll().FirstOrDefault(t => t.username == DTO_SessionLogin.username && t.password == BLL_HamXuLy.MaHoaMD5(txtPass.Text));
            if(check==null)
            {
                XtraMessageBox.Show("Xác nhận mật khẩu không đúng.", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.formName.Equals(new FrmNguoiDung().Name) && guiFormCha != null)
            {
                guiFormCha();
            }
            this.Close();
            return;


        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}