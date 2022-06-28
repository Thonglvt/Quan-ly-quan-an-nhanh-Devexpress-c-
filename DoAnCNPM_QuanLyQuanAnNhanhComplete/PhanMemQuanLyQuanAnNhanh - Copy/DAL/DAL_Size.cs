using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Size
    {
        QL_QuanAnNhanhDataContext db;

        public List<tblSize> getAll()
        {
            db = new QL_QuanAnNhanhDataContext();
            return db.tblSizes.ToList();
        }
    }
}
