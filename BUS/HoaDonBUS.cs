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
    public class HoaDonBUS
    {
        //HoaDonDAO dao_hoaDon = new HoaDonDAO();
        public bool Add(HoaDonDTO pHoaDon)
        {
            return HoaDonDAO.Add(pHoaDon);
        }

        public bool Delete(string pMaHoaDon)
        {
            return HoaDonDAO.Delete(pMaHoaDon);
        }

        public bool Update(HoaDonDTO pHoaDon)
        {
            return HoaDonDAO.Update(pHoaDon);
        }

        public static List<HoaDonDTO> GetThongTinTatCaHoaDon()
        {
            return HoaDonDAO.GetThongTinTatCaHoaDon();
        }



        HoaDonDAO dao_hoaDon = new HoaDonDAO();
        public DataTable BaoCaoDoanhThu(int thang, int nam)
        {
            return dao_hoaDon.BaoCaoDoanhThu(thang, nam);
        }

        public string GetMaHoaDonNext(int congThem = 0)
        {
            

            string lastNumString = dao_hoaDon.GetMaHoaDonLast();
            string lastNumStringRemove = lastNumString.Remove(0, 2); //Lay phan so ra
            int lastNum = Int32.Parse(lastNumStringRemove);
            int nextNum = lastNum + 1 + congThem;
            string nextNumString = nextNum.ToString();
            while (nextNumString.Length < 8)// gom 8 so
            {
                nextNumString = "0" + nextNumString;
            }

            return "HD" + nextNumString;
        }

        public DataTable GetThongTinHoaDonFromPhieuKham(string maPK)
        {

            return dao_hoaDon.GetThongTinHoaDonFromPhieuKham(maPK);
        }

        public bool XoaHoaDonCoMaPK(string maPK)
        {
            return dao_hoaDon.XoaHoaDonCoMaPK(maPK);
        }
    }
}
