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
using DevExpress.XtraTreeList.Nodes;

namespace GUI
{
    public partial class FrmPhanQuyen : DevExpress.XtraEditors.XtraForm
    {
        BLL_NhomNguoiDung bllNhomND = new BLL_NhomNguoiDung();
        BLL_PhanQuyen bllPQ = new BLL_PhanQuyen();
        BLL_TaiKhoan bllND = new BLL_TaiKhoan();
        public FrmPhanQuyen()
        {
            InitializeComponent();
        }

        private void FrmPhanQuyen_Load(object sender, EventArgs e)
        {
            loadNhomQuyen();
        }
        void loadNhomQuyen()
        {
            gridControlNhomQuyen.DataSource = bllNhomND.lstGroup();
        }

        private void gridViewNhomND_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            loadRights();
            loadUserByNhom();
        }
        void loadRights()
        {
            bllPQ = new BLL_PhanQuyen();
            var maNhom = gridViewNhomND.GetRowCellValue(gridViewNhomND.FocusedRowHandle, gridViewNhomND.Columns["MaNhom"]);
            var lst = bllPQ.lstRightsByGroup(maNhom.ToString());
            treeList.DataSource = lst.ToList();
            treeList.ExpandAll();
            treeList.ForceInitialize();
            treeList.BestFitColumns();
            groupControlRights.Text = "Quyền của nhóm người dùng [" + maNhom.ToString() + "]:";
        }
        void refresh()
        {
            bllPQ = new BLL_PhanQuyen();
            var maNhom = gridViewNhomND.GetRowCellValue(gridViewNhomND.FocusedRowHandle, gridViewNhomND.Columns["MaNhom"]);
            var lst = bllPQ.lstRightsByGroup(maNhom.ToString());
            treeList.DataSource = lst.ToList();
        }
        void loadUserByNhom()
        {
            bllND = new BLL_TaiKhoan();
            var maNhom = gridViewNhomND.GetRowCellValue(gridViewNhomND.FocusedRowHandle, gridViewNhomND.Columns["MaNhom"]);
            var lst = bllND.lstEmpByGroup(maNhom.ToString());
            gridControlUserOfNhomQuyen.DataSource = lst.ToList();
            groupControlUserOfNhomND.Text = "Người dùng thuộc nhóm người dùng [" + maNhom.ToString() + "]:";
        }
        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadRights();
        }

        private void btnluu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            var NhomND = gridViewNhomND.GetRowCellValue(gridViewNhomND.FocusedRowHandle, gridViewNhomND.Columns["MaNhom"]);
            var node = treeList.GetNodeList();
            for (int i = 0; i < node.Count; i++)
            {
                string maNhomND = NhomND.ToString();
                string maMenu = node[i].GetDisplayText(colMaMenu).ToString();
                bool coQuyen = (bool)node[i].GetValue(colCoQuyen);
                bllPQ.AddOrUpdateTblPhanQuyen(maNhomND, maMenu, coQuyen);
            }
            XtraMessageBox.Show("Thao tác thành công [Success]", "Thông báo [Message]"
                    , MessageBoxButtons.OK, MessageBoxIcon.None);
            loadRights();
        }
        private void treeList_ShownEditor(object sender, EventArgs e)
        {
        }
    }
}