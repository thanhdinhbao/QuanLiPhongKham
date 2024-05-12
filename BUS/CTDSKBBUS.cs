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
    public class CTDSKBBUS
    {
        //CTDSKBDAO dao_ctdskb = new CTDSKBDAO();
        public bool ThemBenhNhanVaoDanhSach(CTDSKBDTO pCTDSKB)
        {
            return CTDSKBDAO.ThemCTDSKB(pCTDSKB);
        }

        public bool Delete(string pMaCTDSKB)
        {
            return CTDSKBDAO.Delete(pMaCTDSKB);
        }

        public bool Update(CTDSKBDTO pCTDSKB)
        {
            return CTDSKBDAO.Update(pCTDSKB);
        }

        public static List<CTDSKBDTO> GetThongTinTatCaCT_DSKB()
        {
            return CTDSKBDAO.GetThongTinTatCaCT_DSKB();
        }
       // public DataTable GetThongTinTatCaCT_DSKB()
       // {
          //  return CTDSKBDAO.GetThongTinTatCaCT_DSKB();
       // }

        public string GetNextMaCTDSKB()
        {
            
            string lastNumString = dao_ctdskb.GetLastMaCTDSKB();
            string lastNumStringRemove = lastNumString.Remove(0, 2); //Lay phan so ra
            int lastNum = Int32.Parse(lastNumStringRemove);
            int nextNum = lastNum + 1;
            string nextNumString = nextNum.ToString();
            while (nextNumString.Length < 7)// 7 chu so
            {
                nextNumString = "0" + nextNumString;
            }

            return "CT" + nextNumString;
        }

        CTDSKBDAO dao_ctdskb = new CTDSKBDAO();
        public DataTable GetThongTinBenhNhanKhamBenh(string maPK, string maBenhNhan, string tenBenhNhan, string ngayKham, string cmnd, string sdt)
        {
            return dao_ctdskb.GetThongTinBenhNhanKhamBenh(maPK, maBenhNhan, tenBenhNhan, ngayKham, cmnd, sdt);
        }

        public bool KiemTraBenhNhanCoTrongDanhSach(string maDS, string mabenhNhan)
        {
            return dao_ctdskb.KiemTraBenhNhanCoTrongDanhSach(maDS, mabenhNhan);
        }

        public string GetMaCTDSKB(string maDSKB, string maBenhNhan)
        {
            return dao_ctdskb.GetMaCTDSKB(maDSKB, maBenhNhan);
        }
    }
}
