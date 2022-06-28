using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_NhomSanPham
    {
        QL_QuanAnNhanhDataContext db;

        public List<tblNhomSP> getAll()
        {
            db = new QL_QuanAnNhanhDataContext();
            return db.tblNhomSPs.ToList();
        }
    }
}
