using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_KhuyenMai
    {
        QL_QuanAnNhanhDataContext db;

        public List<tblChuongTrinhKhuyenMai> getAll()
        {
            db = new QL_QuanAnNhanhDataContext();
            return db.tblChuongTrinhKhuyenMais.ToList();
        }
        public string insert(tblChuongTrinhKhuyenMai pSP)
        {
            try
            {
                db = new QL_QuanAnNhanhDataContext();
                db.tblChuongTrinhKhuyenMais.InsertOnSubmit(pSP);
                db.SubmitChanges();
                return "1";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string update(tblChuongTrinhKhuyenMai pSP)
        {
            try
            {
                db = new QL_QuanAnNhanhDataContext();
                var sp = db.tblChuongTrinhKhuyenMais.FirstOrDefault(n => n.MaKhuyenMai == pSP.MaKhuyenMai);
                if (sp != null)
                {
                    sp.NgayKetThuc = pSP.NgayKetThuc;
                    sp.GiamGia = pSP.GiamGia;
                    sp.MoTa = pSP.MoTa;
                }
                db.SubmitChanges();
                return "1";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string delete(string pMaKM)
        {
            try
            {
                db = new QL_QuanAnNhanhDataContext();
                var sp = db.tblChuongTrinhKhuyenMais.FirstOrDefault(n => n.MaKhuyenMai == pMaKM);
                db.tblChuongTrinhKhuyenMais.DeleteOnSubmit(sp);
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
