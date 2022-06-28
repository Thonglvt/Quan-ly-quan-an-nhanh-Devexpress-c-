using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLL_PhanQuyen
    {
        DAL_PhanQuyen dalPQ;

        public BLL_PhanQuyen() { }

        public List<UserRights> lstRightsByGroup(string pMaNhom)
        {
            dalPQ = new DAL_PhanQuyen();
            return dalPQ.getRightsByNhom(pMaNhom);
        }

        public bool kiemTraPhanQuyenForUser(string pMaNhomNguoiDung, string pMaMenu)
        {
            dalPQ = new DAL_PhanQuyen();
            var pq = dalPQ.getPhanQuyen().FirstOrDefault(t => t.MaNhomNguoiDung == pMaNhomNguoiDung && t.MaMenu == pMaMenu);
            return pq != null ? true : false;//True: Đã phân quyền cho nhóm này
        }
        public bool AddOrUpdateTblPhanQuyen(string pMaNhomND, string pMaMenu, bool pCoQuyen)
        {
            dalPQ = new DAL_PhanQuyen();
            return dalPQ.AddOrUpdatePhanQuyen(pMaNhomND, pMaMenu, pCoQuyen);
        }
        public List<tblPhanQuyen> getRightsByNhomNoJoin(string pMaNhom)
        {
            dalPQ = new DAL_PhanQuyen();
            return dalPQ.getRightsByNhomNoJoin(pMaNhom);
        }
    }
}
