using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_CaLamViec
    {
        QL_QuanAnNhanhDataContext db;
        public List<tblCaLamViec> getAllCaLamViec()
        {
            db = new QL_QuanAnNhanhDataContext();
            return db.tblCaLamViecs.ToList();
        }

        /// <summary>
        /// Tạo mã tự động theo kích thước và cho phép chữ thường
        /// </summary>
        /// <param name="size">Kích thước chuỗi</param>
        /// <param name="lowerCase">Convert chữ thường</param>
        /// <returns></returns>
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

        public string insert(tblCaLamViec pCaLV)
        {
            try
            {
                db = new QL_QuanAnNhanhDataContext();
                db.tblCaLamViecs.InsertOnSubmit(pCaLV);
                db.SubmitChanges();
                return "1";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string update(tblCaLamViec pCaLV)
        {
            try
            {
                db = new QL_QuanAnNhanhDataContext();
                var ca = db.tblCaLamViecs.FirstOrDefault(n => n.MaCa == pCaLV.MaCa);
                if (ca != null)
                {
                    ca.TenCa = pCaLV.TenCa;
                    ca.GioBD = pCaLV.GioBD;
                    ca.GioKT = pCaLV.GioKT;
                    ca.SoTien = pCaLV.SoTien;
                }
                db.SubmitChanges();
                return "1";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string delete(string pMaCa)
        {
            try
            {
                db = new QL_QuanAnNhanhDataContext();
                tblCaLamViec ca = db.tblCaLamViecs.FirstOrDefault(n => n.MaCa == pMaCa);
                db.tblCaLamViecs.DeleteOnSubmit(ca);
                db.SubmitChanges();
                return "1";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
