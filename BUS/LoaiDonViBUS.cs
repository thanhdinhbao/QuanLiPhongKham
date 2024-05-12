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
    public class LoaiDonViBUS
    {
        //LoaiDonViDAO dao_loaiDonVi = new LoaiDonViDAO();
        public static  bool Add(LoaiDonViDTO pLoaiDonVi)
        {
            return LoaiDonViDAO.Add(pLoaiDonVi);
        }

        public static bool Delete(string pMaLoaiDonVi)
        {
            return LoaiDonViDAO.Delete(pMaLoaiDonVi);
        }

        public static bool Update(LoaiDonViDTO pLoaiDonVi)
        {
            return LoaiDonViDAO.Update(pLoaiDonVi);
        }

        public static List<LoaiDonViDTO> GetThongTinTatCaLoaiDonVi()
        {
            return LoaiDonViDAO.GetThongTinTatCaLoaiDonVi();
        }

        public static string GetMaLoaiDonViNext()
        {
            LoaiDonViDAO dao_loaiDonVi = new LoaiDonViDAO();
            string lastNumString = dao_loaiDonVi.GetMaLoaiDonViLast();
            string lastNumStringRemove = lastNumString.Remove(0, 2); //Lay phan so ra
            int lastNum = Int32.Parse(lastNumStringRemove);
            int nextNum = lastNum + 1;
            string nextNumString = nextNum.ToString();
            while (nextNumString.Length < 2)// gom 2 chu so
            {
                nextNumString = "0" + nextNumString;
            }

            return "DV" + nextNumString;
        }
    }
}
