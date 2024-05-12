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
    public class CachDungBUS
    {
       // CachDungDAO dao_loaiCachDung = new CachDungDAO();
        public static bool Add(CachDungDTO pLoaiCachDung)
        {
            return CachDungDAO.Add(pLoaiCachDung);
        }

        public static bool Delete(string pMaLoaiCachDung)
        {
            return CachDungDAO.Delete(pMaLoaiCachDung);
        }

        public static bool Update(CachDungDTO pLoaiCachDung)

        {
            return CachDungDAO.Update(pLoaiCachDung);
        }

        public static List<CachDungDTO> GetThongTinTatCaCachDung()
        {
            return CachDungDAO.GetThongTinTatCaCachDung();
        }
        //public static DataTable GetThongTinTatCaCachDung()
       // {
        //    return CachDungDAO.GetThongTinTatCaCachDung();
       // }

        public static string GetMaLoaiCachDungNext()
        {
            CachDungDAO dao_loaiCachDung = new CachDungDAO();
            string lastNumString = CachDungDAO.GetMaLoaiCachDungLast();
            string lastNumStringRemove = lastNumString.Remove(0, 2); //Lay phan so ra
            int lastNum = Int32.Parse(lastNumStringRemove);
            int nextNum = lastNum + 1;
            string nextNumString = nextNum.ToString();
            while (nextNumString.Length < 2)// gom 2 chu so
            {
                nextNumString = "0" + nextNumString;
            }

            return "CD" + nextNumString;
        }
    }
}
