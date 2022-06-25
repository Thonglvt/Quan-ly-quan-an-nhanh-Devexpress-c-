using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DTO;
using System.Collections.Generic;

namespace GUI
{
    public partial class InvoiceReport : DevExpress.XtraReports.UI.XtraReport
    {
        public InvoiceReport()
        {
            InitializeComponent();
        }
        public void InitData(List<DTO_HoaDon_KH_NV_BG_SP> pLst,double pTienNhan,double pTienThoi)
        {
            foreach (DTO_HoaDon_KH_NV_BG_SP p in pLst)
            {
                this.pMaHD.Value = p.MaHD;
                this.pThuNgan.Value = p.MaNV+"-"+p.TenNV;
                this.pNgaylap.Value = p.NgayLap;
                this.pTienCanThanhToan.Value = p.TongTien;
                this.pGiamGia.Value = p.GiamGia;
                this.pTienNhan.Value = pTienNhan;
                this.pTienThua.Value = pTienThoi;

                objectDataSource1.DataSource = pLst;
                break;
            }

        }
    }
}
