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

namespace GUI
{
    public partial class FrmDialogSoLuong : DevExpress.XtraEditors.XtraForm
    {
        DTO_BangGia_SanPham bgSP = new DTO_BangGia_SanPham();
        public delegate void GETDATA(int soLuong);
        public GETDATA guiFormCha;
        public FrmDialogSoLuong()
        {
            InitializeComponent();
        }
        public FrmDialogSoLuong(DTO_BangGia_SanPham pBangGia)
        {
            InitializeComponent();
            bgSP = pBangGia;
        }

        private void FrmDialogSoLuong_Load(object sender, EventArgs e)
        {
            txtTenSP.Text = bgSP.TenSP;
            txtGiaBan.Text = bgSP.Gia.ToString();
            
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(txtSoLuong.Value > 0)
            {
                if (guiFormCha != null)
                {
                    guiFormCha(Convert.ToInt32(txtSoLuong.Value));
                    this.Close();
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}