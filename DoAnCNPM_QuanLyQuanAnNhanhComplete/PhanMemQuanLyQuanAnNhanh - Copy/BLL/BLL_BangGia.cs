using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class BLL_BangGia
    {
        DAL_BangGia dalBG;

        public List<DTO_BangGia_SanPham> getAll()
        {
            dalBG = new DAL_BangGia();
            return dalBG.getAll();
        }
        public List<DTO_BangGia_SanPham> getAllByNhomSP(string pMaNhom)
        {
            dalBG = new DAL_BangGia();
            return dalBG.getAll().Where(t => t.MaNhomSP == pMaNhom).ToList();
        }
        public DTO_BangGia_SanPham findByMaBangGia(int pMaBangGia)
        {
            dalBG = new DAL_BangGia();
            return dalBG.getAll().FirstOrDefault(t => t.MaBangGia == pMaBangGia);
        }

        public string insert(tblBangGia pSP)
        {
            dalBG = new DAL_BangGia();
            return dalBG.insert(pSP);
        }
        public string update(tblBangGia pSP)
        {
            dalBG = new DAL_BangGia();
            return dalBG.update(pSP);
        }
        public string delete(int pMaBG)
        {
            dalBG = new DAL_BangGia();
            return dalBG.delete(pMaBG);
        }
    }
}
