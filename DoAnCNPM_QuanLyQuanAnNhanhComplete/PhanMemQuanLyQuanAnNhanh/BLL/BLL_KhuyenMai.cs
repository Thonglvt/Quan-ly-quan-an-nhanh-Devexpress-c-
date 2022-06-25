using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLL_KhuyenMai
    {
        DAL_KhuyenMai dalKM;
        public List<tblChuongTrinhKhuyenMai> getAll()
        {
            dalKM = new DAL_KhuyenMai();
            return dalKM.getAll();
        }

        public string insert(tblChuongTrinhKhuyenMai pSP)
        {
            dalKM = new DAL_KhuyenMai();
            return dalKM.insert(pSP);
        }
        public string update(tblChuongTrinhKhuyenMai pSP)
        {
            dalKM = new DAL_KhuyenMai();
            return dalKM.update(pSP);
        }
        public string delete(string pMaKM)
        {
            dalKM = new DAL_KhuyenMai();
            return dalKM.delete(pMaKM);
        }

        public string create_ID_KM(string pre)
        {
            dalKM = new DAL_KhuyenMai();
            string ID = "";
            try
            {
                dalKM = new DAL_KhuyenMai();
                var KMLast = dalKM.getAll().Where(t => t.MaKhuyenMai.StartsWith(pre)).OrderByDescending(a => a.MaKhuyenMai).Select(t => t.MaKhuyenMai).First();
                int IDInt = Convert.ToInt32(KMLast.Substring(20, 3));
                //Thực hiện tăng dần
                if (IDInt >= 0 && IDInt < 9)
                    ID += "000" + (IDInt + 1);
                else if (IDInt >= 9 && IDInt < 99)
                    ID += "00" + (IDInt + 1);
                else
                    ID += "0" + (IDInt + 1);
            }
            catch (Exception)
            {
                return "0000";
            }
            return ID;
        }
    }
}
