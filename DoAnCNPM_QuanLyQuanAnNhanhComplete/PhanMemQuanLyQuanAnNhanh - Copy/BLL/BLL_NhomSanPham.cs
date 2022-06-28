using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLL_NhomSanPham
    {
        DAL_NhomSanPham dalNSP;
        public List<tblNhomSP> getAll()
        {
            dalNSP = new DAL_NhomSanPham();
            return dalNSP.getAll();
        }
    }
}
