using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_ChiTietHoaDonBanHang
    {
        QL_QuanAnNhanhDataContext db;

        public List<tblChiTietHD> getAll()
        {
            db = new QL_QuanAnNhanhDataContext();

            return db.tblChiTietHDs.ToList();
        }
        public string insert(tblChiTietHD pCTHD)
        {
            try
            {
                db = new QL_QuanAnNhanhDataContext();
                db.tblChiTietHDs.InsertOnSubmit(pCTHD);
                db.SubmitChanges();
                return "1";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string update(tblChiTietHD pCTHD)
        {
            try
            {
                db = new QL_QuanAnNhanhDataContext();
                var ct = db.tblChiTietHDs.FirstOrDefault(n => n.MaHD == pCTHD.MaHD);
                if (ct != null)
                {
                    ct.MaBangGia = pCTHD.MaBangGia;
                    ct.SoLuong = pCTHD.SoLuong;
                }
                db.SubmitChanges();
                return "1";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string delete(string pMaHD, int pMaBG)
        {
            try
            {
                db = new QL_QuanAnNhanhDataContext();
                tblChiTietHD ct = db.tblChiTietHDs.FirstOrDefault(n => n.MaHD == pMaHD && n.MaBangGia == pMaBG);
                db.tblChiTietHDs.DeleteOnSubmit(ct);
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
