using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_TaiKhoan
    {
        QL_QuanAnNhanhDataContext db;

        public List<tblTaiKhoan> getAll()
        {
            db = new QL_QuanAnNhanhDataContext();
            return db.tblTaiKhoans.ToList();
        }
        public List<DTO_TaiKhoan_NV> getTK_NV()
        {
            db = new QL_QuanAnNhanhDataContext();
            var lst = from a in db.tblTaiKhoans
                      join b in db.tblNhanViens on a.username equals b.username
                      into ab
                      from c in ab.DefaultIfEmpty()
                      select new DTO_TaiKhoan_NV
                      {
                          username = a.username,
                          password = a.password,
                          MaNV = c.MaNV,
                          TenNV = c.TenNV,
                          SDT = c.SDT,
                          CCCD = c.CCCD,
                          active = Convert.ToBoolean(a.active),
                      };
            return lst.ToList();
        }

        public List<tblTaiKhoan> getAccount()
        {
            db = new QL_QuanAnNhanhDataContext();
            return db.tblTaiKhoans.Select(l => l).ToList<tblTaiKhoan>();
        }
        public List<tblNhanVien> getAccountEmployeeMix()
        {
            db = new QL_QuanAnNhanhDataContext();
            var accEmpMix = from a in db.tblTaiKhoans
                            join b in db.tblNhanViens
                            on a.username equals b.username
                            select b;
            return accEmpMix.ToList<tblNhanVien>();
        }
        public List<tblNhanVien> getNguoiDungByNhom(string maNhomND)
        {
            db = new QL_QuanAnNhanhDataContext();
            var lst = from a in db.tblNguoiDungNhomNguoiDungs.Where(t => t.MaNhomNguoiDung == maNhomND)
                      join b in db.tblNhanViens
                      on a.username equals b.username
                      select b;

            return lst.ToList<tblNhanVien>();
        }
        public List<tblNguoiDungNhomNguoiDung> getTblNguoiDungNhomNguoiDung()
        {
            db = new QL_QuanAnNhanhDataContext();
            return db.tblNguoiDungNhomNguoiDungs.Select(t => t).ToList();
        }
        public void addUserToGroup(string pUsernane, string pMaNhom)
        {
            db = new QL_QuanAnNhanhDataContext();
            tblNguoiDungNhomNguoiDung ndnnd = new tblNguoiDungNhomNguoiDung();
            ndnnd.username = pUsernane;
            ndnnd.MaNhomNguoiDung = pMaNhom;
            ndnnd.GhiChu = "";
            db.tblNguoiDungNhomNguoiDungs.InsertOnSubmit(ndnnd);
            db.SubmitChanges();
        }
        public void removeUserFromGroup(string pUsernane, string pMaNhom)
        {
            db = new QL_QuanAnNhanhDataContext();
            tblNguoiDungNhomNguoiDung ndnnd = db.tblNguoiDungNhomNguoiDungs.FirstOrDefault(t => t.username == pUsernane && t.MaNhomNguoiDung == pMaNhom);
            if (ndnnd != null)
                db.tblNguoiDungNhomNguoiDungs.DeleteOnSubmit(ndnnd);
            db.SubmitChanges();
        }

        public string insert(tblTaiKhoan pSP)
        {
            try
            {
                db = new QL_QuanAnNhanhDataContext();
                db.tblTaiKhoans.InsertOnSubmit(pSP);
                db.SubmitChanges();
                return "1";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string doiMatKhau(tblTaiKhoan pSP)
        {
            try
            {
                db = new QL_QuanAnNhanhDataContext();
                var sp = db.tblTaiKhoans.FirstOrDefault(n => n.username == pSP.username);
                if (sp != null)
                {
                    sp.password = pSP.password;
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
        public string CapNhatTrangThai(tblTaiKhoan pSP)
        {
            try
            {
                db = new QL_QuanAnNhanhDataContext();
                var sp = db.tblTaiKhoans.FirstOrDefault(n => n.username == pSP.username);
                if (sp != null)
                {
                    sp.active = pSP.active;
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
        public string delete(string pUs)
        {
            try
            {
                db = new QL_QuanAnNhanhDataContext();
                var sp = db.tblTaiKhoans.FirstOrDefault(n => n.username == pUs);
                db.tblTaiKhoans.DeleteOnSubmit(sp);
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
