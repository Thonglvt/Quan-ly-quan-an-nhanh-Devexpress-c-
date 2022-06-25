using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLL_NhanVien
    {
        DAL_NhanVien dalNV;
        public List<tblNhanVien> getAll()
        {
            dalNV = new DAL_NhanVien();
            return dalNV.getAll();
        }
        public string insert(tblNhanVien pSP)
        {
            dalNV = new DAL_NhanVien();
            return dalNV.insert(pSP);
        }
        public string update(tblNhanVien pSP)
        {
            dalNV = new DAL_NhanVien();
            return dalNV.update(pSP);
        }
        public string update_TK_NV(string pMaNV, string pUsername)
        {
            dalNV = new DAL_NhanVien();
            return dalNV.update_TK_NV(pMaNV,pUsername);
        }
    }
}
