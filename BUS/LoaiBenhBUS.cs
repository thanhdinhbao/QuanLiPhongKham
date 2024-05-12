using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
   public  class LoaiBenhBUS
    {
        //LoaiBenhDAO dao_loaiBenh = new LoaiBenhDAO();
        public bool Add(LoaiBenhDTO pLoaiBenh)
        {
            return LoaiBenhDAO.Add(pLoaiBenh);
        }

        public bool Delete(string pMaLoaiBenh)
        {
            return LoaiBenhDAO.Delete(pMaLoaiBenh);
        }

        public bool Update(LoaiBenhDTO pLoaiBenh)
        {
            return LoaiBenhDAO.Update(pLoaiBenh);
        }

        public static List<LoaiBenhDTO> GetThongTinTatCaLoaiBenh()
        {
            return LoaiBenhDAO.GetThongTinTatCaLoaiBenh();
        }

        public string GetMaLoaiBenhNext()
        {
            LoaiBenhDAO dao_loaiBenh = new LoaiBenhDAO();
            string lastNumString = dao_loaiBenh.GetMaLoaiBenhLast();
            string lastNumStringRemove = lastNumString.Remove(0, 2); //Lay phan so ra
            int lastNum = Int32.Parse(lastNumStringRemove);
            int nextNum = lastNum + 1;
            string nextNumString = nextNum.ToString();
            while (nextNumString.Length < 2)// gom 2 chu so
            {
                nextNumString = "0" + nextNumString;
            }

            return "LB" + nextNumString;
        }
    }
}
