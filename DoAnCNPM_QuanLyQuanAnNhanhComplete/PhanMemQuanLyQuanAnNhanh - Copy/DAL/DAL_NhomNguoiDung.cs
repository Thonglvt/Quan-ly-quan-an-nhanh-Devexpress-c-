using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_NhomNguoiDung
    {
        QL_QuanAnNhanhDataContext db;

        public DAL_NhomNguoiDung() { }
        public List<tblNhomNguoiDung> getNhomNguoiDung()
        {
            db = new QL_QuanAnNhanhDataContext();
            return db.tblNhomNguoiDungs.Select(t => t).ToList<tblNhomNguoiDung>();
        }
        public void addNhomNguoiDung(string pMaNhom,string pTenNhom,string pGhiChu)
        {
            db = new QL_QuanAnNhanhDataContext();
            tblNhomNguoiDung nhomND = new tblNhomNguoiDung();
            nhomND.MaNhom = pMaNhom;
            nhomND.TenNhom = pTenNhom;
            nhomND.GhiChu = pGhiChu;
            db.tblNhomNguoiDungs.InsertOnSubmit(nhomND);
            db.SubmitChanges();
        }
        public void updateNhomNguoiDung(string pMaNhom, string pTenNhom, string pGhiChu)
        {
            db = new QL_QuanAnNhanhDataContext();
            var nhomND = db.tblNhomNguoiDungs.FirstOrDefault(t=>t.MaNhom == pMaNhom);
            if(nhomND!=null)
            {
                nhomND.TenNhom = pTenNhom;
                nhomND.GhiChu = pGhiChu;
            }

            db.SubmitChanges();
        }
        public void deleteNhomNguoiDung(string pMaNhom)
        {
            db = new QL_QuanAnNhanhDataContext();
            tblNhomNguoiDung nhomND = db.tblNhomNguoiDungs.FirstOrDefault(t => t.MaNhom == pMaNhom);

            if (nhomND != null)
            {
                db.tblNhomNguoiDungs.DeleteOnSubmit(nhomND);
            }
            db.SubmitChanges();
        }
    }
}
