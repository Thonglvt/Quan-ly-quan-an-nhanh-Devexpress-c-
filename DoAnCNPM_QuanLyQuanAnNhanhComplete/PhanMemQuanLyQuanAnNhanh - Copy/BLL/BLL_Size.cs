using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLL_Size
    {
        DAL_Size dalSize;

        public List<tblSize> getAll()
        {
            dalSize = new DAL_Size();
            return dalSize.getAll();
        }
    }
}
