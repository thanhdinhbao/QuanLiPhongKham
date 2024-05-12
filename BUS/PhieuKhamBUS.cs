using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class PhieuKhamBUS
    {
       // PhieuKhamDAO dao_phieuKham = new PhieuKhamDAO();

        public bool ThemPhieuKham(PhieuKhamDTO pPhieuKham)
        {
            return PhieuKhamDAO.ThemPhieuKham(pPhieuKham);
        }

        public bool Delete(string pMaPhieuKham)
        {
            return PhieuKhamDAO.Delete(pMaPhieuKham);
        }

        public bool Update(PhieuKhamDTO pPhieuKham)
        {
            return PhieuKhamDAO.Update(pPhieuKham);
        }

        public static List<PhieuKhamDTO> GetThongTinTatCaPhieuKham()
        {
            return PhieuKhamDAO.GetThongTinTatCaPhieuKham();
        }



        PhieuKhamDAO dao_phieuKham = new PhieuKhamDAO();


        public DataTable GetTatCaMaPK(string maPKGoiY)
        {
            return dao_phieuKham.GetTatCaMaPK(maPKGoiY);
        }

        public string GetNextMaPK()
        {
            string lastNumString = dao_phieuKham.GetMaPKLast();
            string lastNumStringRemove = lastNumString.Remove(0, 2); //Lay phan so ra
            int lastNum = Int32.Parse(lastNumStringRemove);
            int nextNum = lastNum + 1;
            string nextNumString = nextNum.ToString();
            while (nextNumString.Length < 7)// 7 chu so
            {
                nextNumString = "0" + nextNumString;
            }

            return "PK" + nextNumString;
        }
    }
}
