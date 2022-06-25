using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLL_TaiKhoan
    {
        DAL_TaiKhoan dalTK;

        public List<tblTaiKhoan> getAll()
        {
            dalTK = new DAL_TaiKhoan();
            return dalTK.getAll();
        }
        public List<DTO_TaiKhoan_NV> getTK_NV()
        {
            dalTK = new DAL_TaiKhoan();
            return dalTK.getTK_NV();
        }


        public List<tblTaiKhoan> lstUsers()
        {
            dalTK = new DAL_TaiKhoan();
            return dalTK.getAccount();  
        }
        public List<tblNhanVien> lstAccountEmployeeMix()
        {
            dalTK = new DAL_TaiKhoan();
            return dalTK.getAccountEmployeeMix();
        }
        public List<tblNhanVien> lstEmpByGroup(string pMaNhom)
        {
            dalTK = new DAL_TaiKhoan();
            return dalTK.getNguoiDungByNhom(pMaNhom);
        }
        public bool kiemTraNguoiDungTonTaiInNhomND(string pUsername, string pMaNhom)
        {
            dalTK = new DAL_TaiKhoan();
            List<tblNguoiDungNhomNguoiDung> lstNDNND = dalTK.getTblNguoiDungNhomNguoiDung();
            tblNguoiDungNhomNguoiDung ndnnd = lstNDNND.FirstOrDefault(t => t.username == pUsername && t.MaNhomNguoiDung == pMaNhom);
            return (ndnnd != null) ? true : false; //True: đã tồn tại
        }
        public bool insertUserToGroup(string pUsername, string pMaNhom)
        {
            dalTK = new DAL_TaiKhoan();
            bool kq = true;
            try
            {
                dalTK.addUserToGroup(pUsername, pMaNhom);
            }
            catch (Exception e)
            {

                kq = false;
            }
            return kq;
        }
        public bool removeUserFromGroup(string pUsername, string pMaNhom)
        {
            dalTK = new DAL_TaiKhoan();
            bool kq = true;
            try
            {
                dalTK.removeUserFromGroup(pUsername, pMaNhom);
            }
            catch (Exception e)
            {

                kq = false;
            }
            return kq;
        }


        public string insert(tblTaiKhoan pSP)
        {
            dalTK = new DAL_TaiKhoan();
            return dalTK.insert(pSP);
        }
        public string doiMatKhau(tblTaiKhoan pSP)
        {
            dalTK = new DAL_TaiKhoan();
            return dalTK.doiMatKhau(pSP);
        }
        public string CapNhatTrangThai(tblTaiKhoan pSP)
        {
            dalTK = new DAL_TaiKhoan();
            return dalTK.CapNhatTrangThai(pSP);
        }
        public string delete(string pUs)
        {
            dalTK = new DAL_TaiKhoan();
            return dalTK.delete(pUs);
        }
    }
}
