using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLL_Menu
    {
        DAL_Menu dalMenu;

        public BLL_Menu() { }
        public bool kiemTraChucNangDaTonTai(string pMaMenu)
        {
            dalMenu = new DAL_Menu();
            List<tblMenu> lstMenu = dalMenu.getMenus();
            var menu = lstMenu.FirstOrDefault(t => t.MaMenu.Trim() == pMaMenu);
            return (menu != null) ? true : false;//True: đã tồn tại
        }
        public bool ChekAddTowParam(string pMaMenu, string pTenMennu)
        {
            dalMenu = new DAL_Menu();
            return dalMenu.addMenuTowParameter(pMaMenu, pTenMennu);
        }
        public bool ChekAddThreeParam(string pMaMenu, string pTenMennu, string pParentMenu)
        {
            dalMenu = new DAL_Menu();
            return dalMenu.addMenuThreeParameter(pMaMenu, pTenMennu, pParentMenu);
        }
        public bool ChekUpdateTowParameter(string pMaMenu, string pTenMennu)
        {
            dalMenu = new DAL_Menu();
            return dalMenu.updateMenuTowParameter(pMaMenu, pTenMennu);
        }
        public bool ChekUpdateThreeParameter(string pMaMenu, string pTenMennu, string pParentMenu)
        {
            dalMenu = new DAL_Menu();
            return dalMenu.updateMenuThreeParameter(pMaMenu, pTenMennu, pParentMenu);
        }
    }
}
