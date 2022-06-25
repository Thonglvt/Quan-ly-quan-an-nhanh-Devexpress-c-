using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLL_ChiTietHoaDonBanHang
    {
        DAL_ChiTietHoaDonBanHang dalCTHDBH;
        public List<tblChiTietHD> getAll()
        {
            dalCTHDBH = new DAL_ChiTietHoaDonBanHang();

            return dalCTHDBH.getAll();
        }
        //CRUD
        public string insert(tblChiTietHD pCTHD)
        {
            dalCTHDBH = new DAL_ChiTietHoaDonBanHang();
            return dalCTHDBH.insert(pCTHD);
        }
        public string update(tblChiTietHD pCTHD)
        {
            dalCTHDBH = new DAL_ChiTietHoaDonBanHang();
            return dalCTHDBH.update(pCTHD);
        }
        public string delete(string pMaHD, int pMaBG)
        {
            dalCTHDBH = new DAL_ChiTietHoaDonBanHang();
            return dalCTHDBH.delete(pMaHD, pMaBG);
        }
    }
}
