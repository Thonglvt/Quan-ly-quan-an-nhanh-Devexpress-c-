using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_HoaDonBanHang
    {
        QL_QuanAnNhanhDataContext db;
        public List<tblHoaDonBanHang> getAll()
        {
            db = new QL_QuanAnNhanhDataContext();
            return db.tblHoaDonBanHangs.ToList();
        }
        public List<DTO_HoaDon_KH_NV_BG_SP> getAll2()
        {
            db = new QL_QuanAnNhanhDataContext();
            var lst = from a in db.tblHoaDonBanHangs
                      join b in db.tblChiTietHDs on a.MaHD equals b.MaHD
                      join c in db.tblNhanViens on a.MaNV equals c.MaNV
                      join d in db.tblKhachHangs on a.MaKH equals d.MaKH
                      join e in db.tblBangGias on b.MaBangGia equals e.MaBangGia
                      join f in db.tblSanPhams on e.MaSP equals f.MaSP
                      select new DTO_HoaDon_KH_NV_BG_SP
                      {
                          MaHD = a.MaHD,
                          TenKH = d.TenKH,
                          TenNV = c.TenNV,
                          TenSP = f.TenSP,
                          SoLuong = Convert.ToInt32(b.SoLuong),
                          DonGia = Convert.ToDouble(b.DonGia),
                          MaNV = c.MaNV,
                          MaBangGia = e.MaBangGia,
                          MaKH = d.MaKH,
                          MaSP = f.MaSP,
                          NgayLap = Convert.ToDateTime(a.NgayLap),
                          ThanhTien = Convert.ToDouble(b.SoLuong * b.DonGia),
                          TongTien = Convert.ToDouble(a.TongTien),
                          GiamGia = Convert.ToInt32(a.GiamGia),
                      };
            return lst.ToList();
        }
        public string insert(tblHoaDonBanHang pHDBH)
        {
            try
            {
                db = new QL_QuanAnNhanhDataContext();
                db.tblHoaDonBanHangs.InsertOnSubmit(pHDBH);
                db.SubmitChanges();
                return "1";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string update(tblHoaDonBanHang pHDBH)
        {
            try
            {
                db = new QL_QuanAnNhanhDataContext();
                var hdbh = db.tblHoaDonBanHangs.FirstOrDefault(n => n.MaHD == pHDBH.MaHD);
                if (hdbh != null)
                {
                    hdbh.PhuThu = pHDBH.PhuThu;
                    hdbh.GiamGia = pHDBH.GiamGia;
                    hdbh.TrangThai = pHDBH.TrangThai;
                }
                db.SubmitChanges();
                return "1";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string delete(string pMaHD)
        {
            try
            {
                db = new QL_QuanAnNhanhDataContext();
                tblHoaDonBanHang hdbh = db.tblHoaDonBanHangs.FirstOrDefault(n => n.MaHD == pMaHD);
                db.tblHoaDonBanHangs.DeleteOnSubmit(hdbh);
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
