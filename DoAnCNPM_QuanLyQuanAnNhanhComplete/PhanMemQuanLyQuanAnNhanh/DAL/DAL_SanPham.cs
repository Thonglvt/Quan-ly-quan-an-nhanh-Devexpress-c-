using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_SanPham
    {
        QL_QuanAnNhanhDataContext db;
        public List<tblSanPham> getAll()
        {
            db = new QL_QuanAnNhanhDataContext();
            return db.tblSanPhams.ToList();
        }
        public string insert(tblSanPham pSP)
        {
            try
            {
                db = new QL_QuanAnNhanhDataContext();
                db.tblSanPhams.InsertOnSubmit(pSP);
                db.SubmitChanges();
                return "1";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string update(tblSanPham pSP)
        {
            try
            {
                db = new QL_QuanAnNhanhDataContext();
                var sp = db.tblSanPhams.FirstOrDefault(n => n.MaSP == pSP.MaSP);
                if (sp != null)
                {
                    sp.TenSP = pSP.TenSP;
                    sp.TrangThai = pSP.TrangThai;
                    sp.MaNhomSP = pSP.MaNhomSP;
                    db.SubmitChanges();
                    return "1";
                }
                return "0";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string delete(string pMaSP)
        {
            try
            {
                db = new QL_QuanAnNhanhDataContext();
                tblSanPham sp = db.tblSanPhams.FirstOrDefault(n => n.MaSP == pMaSP);
                db.tblSanPhams.DeleteOnSubmit(sp);
                db.SubmitChanges();
                return "1";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


        public string AutoCreateID(int size, bool lowerCase)
        {
            StringBuilder sb = new StringBuilder();
            char c;

            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                c = Convert.ToChar(Convert.ToInt32(rand.Next(65, 87)));
                sb.Append(c);
            }
            if (lowerCase)
            {
                return sb.ToString().ToLower();
            }
            return sb.ToString();
        }
    }
}
