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
    public partial class FrmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        BLL_TaiKhoan bllTK;
        BLL_NhanVien bllNV;
        public FrmDangNhap()
        {
            InitializeComponent();
        }
        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(DTO_SessionLogin.username))
            {
                txtUser.Text = DTO_SessionLogin.username;
            }   
            else
            {
                txtUser.Text = "0396210106";
            }    
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            bllTK = new BLL_TaiKhoan();
            string passMD5 = BLL_HamXuLy.MaHoaMD5(txtPass.Text);


            var check = bllTK.getAll().FirstOrDefault(t => t.username.Trim() == txtUser.Text.Trim()
            && t.password.Trim() == passMD5);

            if(check == null)
            {
                XtraMessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác [Incorrect username or password]",
                    "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(check.active == false)
            {
                XtraMessageBox.Show("Tài khoản này bị khóa liên hệ quản lý để biết thêm thông tin [This account is locked]",
                    "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DTO_SessionLogin.username = txtUser.Text.Trim();
            bllNV = new BLL_NhanVien();
            var checkNV = bllNV.getAll().FirstOrDefault(t => t.username == txtUser.Text.Trim());
            if(checkNV!=null)
            {
                DTO_SessionLogin.MaNV = checkNV.MaNV;
                DTO_SessionLogin.TenNV = checkNV.TenNV;
            } 
            else
            {
                DTO_SessionLogin.MaNV = "06062022NV000000";
                DTO_SessionLogin.TenNV = "Admin";
            }    

            FrmMain frm = new FrmMain();
            frm.Show();
            Hide();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}