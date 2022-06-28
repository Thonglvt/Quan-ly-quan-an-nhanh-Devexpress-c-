using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_NhanVien
    {
        QL_QuanAnNhanhDataContext db;

        public List<tblNhanVien> getAll()
        {
            db = new QL_QuanAnNhanhDataContext();
            return db.tblNhanViens.ToList();
        }

        public string insert(tblNhanVien pSP)
        {
            try
            {
                db = new QL_QuanAnNhanhDataContext();
                db.tblNhanViens.InsertOnSubmit(pSP);
                db.SubmitChanges();
                return "1";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string update(tblNhanVien pSP)
        {
            try
            {
                db = new QL_QuanAnNhanhDataContext();
                var sp = db.tblNhanViens.FirstOrDefault(n => n.MaNV == pSP.MaNV);
                if (sp != null)
                {
                    sp.TenNV = pSP.TenNV;
                    sp.NgaySinh = pSP.NgaySinh;
                    sp.GioiTinh = pSP.GioiTinh;
                    sp.DiaChi = pSP.DiaChi;
                    sp.SDT = pSP.SDT;
                    sp.CCCD = pSP.CCCD;

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
        public string update_TK_NV(string pMaNV,string pUsername)
        {
            try
            {
                db = new QL_QuanAnNhanhDataContext();
                var sp = db.tblNhanViens.FirstOrDefault(n => n.MaNV == pMaNV);
                if (sp != null)
                {
                    sp.username = pUsername;
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
        public string deleteNV(string pMaNV)
        {
            try
            {
                db = new QL_QuanAnNhanhDataContext();
                tblNhanVien nv = db.tblNhanViens.FirstOrDefault(n => n.MaNV == pMaNV);
                db.tblNhanViens.DeleteOnSubmit(nv);
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
