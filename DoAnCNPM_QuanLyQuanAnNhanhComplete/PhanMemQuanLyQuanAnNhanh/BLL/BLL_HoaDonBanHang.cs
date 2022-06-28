using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLL_HoaDonBanHang
    {
        DAL_HoaDonBanHang dalHDBD;
        public List<tblHoaDonBanHang> getAll()
        {
            dalHDBD = new DAL_HoaDonBanHang();
            return dalHDBD.getAll();
        }
        public List<DTO_HoaDon_KH_NV_BG_SP> getAll2()
        {
            dalHDBD = new DAL_HoaDonBanHang();
            return dalHDBD.getAll2();
        }
        public List<DTO_HoaDon_KH_NV_BG_SP> getAllByMaHD(string pMaHD)
        {
            dalHDBD = new DAL_HoaDonBanHang();
            return dalHDBD.getAll2().Where(t=>t.MaHD == pMaHD).ToList();
        }
        public List<DTO_HoaDon_KH_NV_BG_SP> getHD_KH_NV()
        {
            dalHDBD = new DAL_HoaDonBanHang();
            return dalHDBD.getHD_KH_NV().OrderByDescending(a => a.NgayLap).ToList();
        }
        public List<DTO_HoaDon_KH_NV_BG_SP> getHD_KH_NV_ByMaNV(string pMaNV)
        {
            dalHDBD = new DAL_HoaDonBanHang();
            return dalHDBD.getHD_KH_NV().Where(t => t.MaNV == pMaNV).OrderByDescending(a => a.NgayLap).ToList();
        }

        #region CRUD
        public string insert(tblHoaDonBanHang pHDBH)
        {
            dalHDBD = new DAL_HoaDonBanHang();
            return dalHDBD.insert(pHDBH);
        }
        public string update(tblHoaDonBanHang pHDBH)
        {
            dalHDBD = new DAL_HoaDonBanHang();
            return dalHDBD.update(pHDBH);
        }
        public string delete(string pMaHD)
        {
            dalHDBD = new DAL_HoaDonBanHang();
            return dalHDBD.delete(pMaHD);
        }
        #endregion


    }
}
