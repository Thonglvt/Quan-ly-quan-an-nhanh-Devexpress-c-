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
using DevExpress.XtraGrid.Views.Grid;

namespace GUI
{
    public partial class FrmKhuyenMai : DevExpress.XtraEditors.XtraForm
    {
        BLL_KhuyenMai bllKM;
        public FrmKhuyenMai()
        {
            InitializeComponent();
        }

        #region Method
        private void loadData()
        {
            bllKM = new BLL_KhuyenMai();
            gcKM.DataSource = bllKM.getAll();
        }
        void dongMoGiaoTac()
        {
            btnThem.Enabled = !btnThem.Enabled;
            btnLuuMoi.Enabled = !btnLuuMoi.Enabled;
            btnHuy.Enabled = !btnHuy.Enabled;
            lcgNhapTT.Enabled = !lcgNhapTT.Enabled;
        }
        void emptyTxt()
        {
            txtMaKM.Text = string.Empty;
            txtGiamGia.Text = "0";
            txtMoTa.Text = string.Empty;
        }
        #endregion

        #region Event
        private void FrmKhuyenMai_Load(object sender, EventArgs e)
        {
            loadData();
            btnLuu_GC.Click += BtnLuu_GC_Click;
            btnXoa_GC.Click += BtnXoa_GC_Click;
        }

        private void BtnXoa_GC_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Xác nhận xóa?",
                "Thông báo [Message]", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string kqDel = bllKM.delete(gvKM.GetRowCellValue(gvKM.FocusedRowHandle, gvKM.Columns["MaKhuyenMai"]).ToString());
                if (kqDel.Equals("1"))
                {
                    XtraMessageBox.Show("Xóa thành công.", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.None);
                    loadData();
                    return;
                }
                XtraMessageBox.Show("Error: " + kqDel, "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void BtnLuu_GC_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Xác nhận cập nhật?",
                "Thông báo [Message]", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Convert.ToDateTime(gvKM.GetRowCellValue(gvKM.FocusedRowHandle, gvKM.Columns["NgayKetThuc"]))
                    < Convert.ToDateTime(gvKM.GetRowCellValue(gvKM.FocusedRowHandle, gvKM.Columns["NgayBatDau"])))
                {
                    XtraMessageBox.Show("Ngày không hợp lệ (lưu ý: Ngày bắt đầu < ngày kết thúc khuyến mãi)", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                if (Convert.ToDateTime(gvKM.GetRowCellValue(gvKM.FocusedRowHandle, gvKM.Columns["NgayKetThuc"])) < DateTime.Now)
                {
                    XtraMessageBox.Show("Vui lòng chọn ngày kết thúc lớn hơn ngày " + DateTime.Now.ToShortDateString(), "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (Convert.ToInt32(gvKM.GetRowCellValue(gvKM.FocusedRowHandle, gvKM.Columns["GiamGia"])) <= 0 || gvKM.GetRowCellValue(gvKM.FocusedRowHandle, gvKM.Columns["GiamGia"]).ToString() == string.Empty)
                {
                    XtraMessageBox.Show(lbGG.Text + " phải lớn hơn 0", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                tblChuongTrinhKhuyenMai ctkm = new tblChuongTrinhKhuyenMai();
                ctkm.MaKhuyenMai = gvKM.GetRowCellValue(gvKM.FocusedRowHandle, gvKM.Columns["MaKhuyenMai"]).ToString();
                ctkm.NgayBatDau = Convert.ToDateTime(gvKM.GetRowCellValue(gvKM.FocusedRowHandle, gvKM.Columns["NgayBatDau"]));
                ctkm.NgayKetThuc = Convert.ToDateTime(gvKM.GetRowCellValue(gvKM.FocusedRowHandle, gvKM.Columns["NgayKetThuc"]));
                ctkm.GiamGia = Convert.ToInt32(gvKM.GetRowCellValue(gvKM.FocusedRowHandle, gvKM.Columns["GiamGia"]));
                ctkm.MoTa = gvKM.GetRowCellValue(gvKM.FocusedRowHandle, gvKM.Columns["MoTa"]).ToString();
                string kqUp = bllKM.update(ctkm);
                if (kqUp.Equals("1"))
                {
                    XtraMessageBox.Show("Cập nhật thành công.", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.None);
                    loadData();
                    return;
                }
                XtraMessageBox.Show("Error: " + kqUp, "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dongMoGiaoTac();
            emptyTxt();
        }
        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dongMoGiaoTac();
            emptyTxt();
        }
        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnLuuMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(txtGiamGia.Value<=0 || txtGiamGia.Value.ToString()==string.Empty)
            {
                XtraMessageBox.Show(lbGG.Text+ " phải lớn hơn 0", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGiamGia.Focus();
                return;
            }    
            if(deNgayBD.EditValue==null)
            {
                XtraMessageBox.Show("Vui lòng chọn "+lbNgayBD.Text, "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                deNgayBD.Focus();
                return;
            }
            if (Convert.ToDateTime(deNgayBD.EditValue)<DateTime.Now)
            {
                XtraMessageBox.Show("Vui lòng chọn ngày bắt đầu lớn hơn ngày "+ DateTime.Now.ToShortDateString(), "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                deNgayBD.Focus();
                return;
            }
            if (deNgayKT.EditValue == null)
            {
                XtraMessageBox.Show("Vui lòng chọn " + lbNgayKT.Text, "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                deNgayKT.Focus();
                return;
            }
            if(Convert.ToDateTime(deNgayKT.EditValue)< Convert.ToDateTime(deNgayBD.EditValue))
            {
                XtraMessageBox.Show("Ngày không hợp lệ (lưu ý: Ngày bắt đầu < ngày kết thúc khuyến mãi)", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                deNgayKT.Focus();
                return;
            }
            //Check ngày bắt đầu KM đang trong thời gian KM
            bllKM = new BLL_KhuyenMai();
            var check = bllKM.getAll().FirstOrDefault(t => t.NgayBatDau <= Convert.ToDateTime(deNgayBD.EditValue) 
            && t.NgayKetThuc >= Convert.ToDateTime(deNgayBD.EditValue));
            if(check!=null)
            {
                XtraMessageBox.Show("Đang có khuyến mãi trong thời gian này (KM có mã #"+ check.MaKhuyenMai+").", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tblChuongTrinhKhuyenMai ctkm = new tblChuongTrinhKhuyenMai();
            string preBD = Convert.ToDateTime(deNgayBD.EditValue).ToShortDateString().Replace("/","");
            string preKT = Convert.ToDateTime(deNgayKT.EditValue).ToShortDateString().Replace("/", "");
            string pre = preBD + "KM" + preKT + "_";
            string suffix = bllKM.create_ID_KM(pre);
            ctkm.MaKhuyenMai = pre+ suffix;
            ctkm.NgayBatDau = Convert.ToDateTime(deNgayBD.EditValue);
            ctkm.NgayKetThuc = Convert.ToDateTime(deNgayKT.EditValue);
            ctkm.GiamGia = Convert.ToInt32(txtGiamGia.Text);
            ctkm.MoTa = txtMoTa.Text;

            string kqIns = bllKM.insert(ctkm);
            if (kqIns.Equals("1"))
            {
                XtraMessageBox.Show("Thêm khuyến mãi thành công.", "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.None);
                dongMoGiaoTac();
                loadData();
                return;
            }
            XtraMessageBox.Show("Error: " + kqIns, "Thông báo [Message]", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadData();
        }
        private void gvKM_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.Column.FieldName == "NgayKetThuc")
            {
                DateTime ngayKT = Convert.ToDateTime(View.GetRowCellDisplayText(e.RowHandle, View.Columns["NgayKetThuc"]));
                string strNgayKT = ngayKT.ToShortDateString();

                if (ngayKT > DateTime.Now)
                {
                    e.Appearance.ForeColor = Color.ForestGreen;
                }
                else if (strNgayKT.Equals(DateTime.Now.ToShortDateString()))
                {
                    e.Appearance.ForeColor = Color.Orange;
                }
                else
                {
                    e.Appearance.ForeColor = Color.Red;
                    //e.Column.OptionsColumn.AllowEdit = false;
                    //e.Column.OptionsColumn.AllowFocus = false;

                }
            }
        }

        #endregion

    }
}