using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_NhomNguoiDung
    {
        DAL_NhomNguoiDung dalNND;
        DAL_PhanQuyen dalPQPQNND;
        public BLL_NhomNguoiDung() { }
        public List<tblNhomNguoiDung> lstGroup()
        {
            dalNND = new DAL_NhomNguoiDung();
            return dalNND.getNhomNguoiDung();
        }
        public bool checkKhoaChinh(string pMaNhom)
        {
            dalNND = new DAL_NhomNguoiDung();
            foreach (tblNhomNguoiDung item in dalNND.getNhomNguoiDung())
            {
                if (pMaNhom.Equals(item.MaNhom.Trim()))
                    return true;//True: Tồn tại
            }
            return false;
        }
        public bool checkKhoaNgoaiOnTblPhanQuyen(string pMaNhom)
        {
            dalPQPQNND = new DAL_PhanQuyen();
            foreach (tblPhanQuyen item in dalPQPQNND.getPhanQuyen())
            {
                if (pMaNhom.Equals(item.MaNhomNguoiDung.Trim()))
                    return true;//True: Tồn tại
            }
            return false;
        }
        public bool insert(string pMaNhom, string pTenNhom, string pGhiChu)
        {
            dalNND = new DAL_NhomNguoiDung();
            bool kq=true;
            try
            {
                dalNND.addNhomNguoiDung(pMaNhom, pTenNhom, pGhiChu);
            }
            catch (Exception)
            {
                kq = false;
            }
            return kq;
        }
        public bool update(string pMaNhom, string pTenNhom, string pGhiChu)
        {
            dalNND = new DAL_NhomNguoiDung();
            bool kq = true;
            try
            {
                dalNND.updateNhomNguoiDung(pMaNhom, pTenNhom, pGhiChu);
            }
            catch (Exception)
            {
                kq = false;
            }
            return kq;
        }
        public bool delete(string pMaNhom)
        {
            dalNND = new DAL_NhomNguoiDung();
            bool kq = true;
            try
            {
                dalNND.deleteNhomNguoiDung(pMaNhom);
            }
            catch (Exception)
            {
                kq = false;
            }
            return kq;
        }
    }
}
