using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_BangGia
    {
        QL_QuanAnNhanhDataContext db;

        public List<DTO_BangGia_SanPham> getAll()
        {
            db = new QL_QuanAnNhanhDataContext();
            var lst = from a in db.tblBangGias
                      join b in db.tblSanPhams on a.MaSP equals b.MaSP
                      select new DTO_BangGia_SanPham
                      {
                          MaSP = b.MaSP,
                          TenSP = b.TenSP,
                          MaNhomSP = b.MaNhomSP,
                          TrangThai = Convert.ToBoolean(b.TrangThai),
                          MaBangGia = a.MaBangGia,
                          Hinh = DAL_HamXuLy.ByArrayToImage(b.Hinh.ToArray()),
                          MaSize = a.MaSize,
                          Gia = Convert.ToDouble(a.Gia),
                          NgayCapNhat = Convert.ToDateTime(a.NgayCapNhat),
                      };
            return lst.ToList();
        }

        public string insert(tblBangGia pSP)
        {
            try
            {
                db = new QL_QuanAnNhanhDataContext();
                db.tblBangGias.InsertOnSubmit(pSP);
                db.SubmitChanges();
                return "1";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string update(tblBangGia pSP)
        {
            try
            {
                db = new QL_QuanAnNhanhDataContext();
                var sp = db.tblBangGias.FirstOrDefault(n => n.MaBangGia == pSP.MaBangGia);
                if (sp != null)
                {
                    sp.Gia = pSP.Gia;
                    sp.NgayCapNhat = DateTime.Now;
                }
                db.SubmitChanges();
                return "1";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string delete(int pMaBG)
        {
            try
            {
                db = new QL_QuanAnNhanhDataContext();
                var sp = db.tblBangGias.FirstOrDefault(n => n.MaBangGia == pMaBG);
                db.tblBangGias.DeleteOnSubmit(sp);
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
