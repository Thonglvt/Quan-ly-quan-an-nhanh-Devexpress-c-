using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLL_SanPham
    {
        DAL_SanPham dalSP;
        public List<tblSanPham> getAll()
        {
            dalSP = new DAL_SanPham();
            return dalSP.getAll();
        }
        public string insert(tblSanPham pSanPham)
        {
            dalSP = new DAL_SanPham();
            return dalSP.insert(pSanPham);
        }
        public string update(tblSanPham pSanPham)
        {
            dalSP = new DAL_SanPham();
            return dalSP.update(pSanPham);
        }
        public string delete(string pMaSP)
        {
            dalSP = new DAL_SanPham();
            return dalSP.delete(pMaSP);
        }

        public string AutoCreateID(int size, bool upperCase)
        {
            string id = "";
            do
            {
                StringBuilder sb = new StringBuilder();
                char c;

                Random rand = new Random();
                for (int i = 0; i < size; i++)
                {
                    c = Convert.ToChar(Convert.ToInt32(rand.Next(65, 87)));
                    sb.Append(c);
                }
                id = sb.ToString().ToUpper();
                if (upperCase)
                {
                    id = sb.ToString().ToUpper();
                }
            } while (checkKhoaChinh(id));

            return id;
        }
        public bool checkKhoaChinh(string pMaSP)
        {
            dalSP = new DAL_SanPham();
            List<tblSanPham> lst = dalSP.getAll();
            foreach (tblSanPham sp in lst)
            {
                if (sp.MaSP.Trim().Equals(pMaSP.Trim()))
                    return true;
            }
            return false;

        }
    }
}
