using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TaiKhoan_NV
    {
        public string username { get; set; }
        public string password { get; set; }
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string SDT { get; set; }
        public string CCCD { get; set; }
        public bool active { get; set; }


    }
}
