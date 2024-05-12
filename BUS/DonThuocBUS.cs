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
    public class DonThuocBUS
    {
        //DonThuocDAO dao_donThuoc = new DonThuocDAO();
        public bool Add(DonThuocDTO pDonThuoc)
        {
            return DonThuocDAO.Add(pDonThuoc);
        }

        public bool Delete(string pMaDonThuoc)
        {
            return DonThuocDAO.Delete(pMaDonThuoc);
        }

        public bool Update(DonThuocDTO pDonThuoc)
        {
            return DonThuocDAO.Update(pDonThuoc);
        }

        public static List<DonThuocDTO> GetThongTinTatCaDonThuoc()
        {
            return DonThuocDAO.GetThongTinTatCaDonThuoc();
        }


        public string GetMaDonThuocNext(int congThem = 0)
        {
            DonThuocDAO dao_donThuoc = new DonThuocDAO();
            string lastNumString = dao_donThuoc.GetMaDonThuocLast();
            string lastNumStringRemove = lastNumString.Remove(0, 2); //Lay phan so ra
            int lastNum = Int32.Parse(lastNumStringRemove);
            int nextNum = lastNum + 1 + congThem;
            string nextNumString = nextNum.ToString();
            while (nextNumString.Length < 8)// gom 8 so
            {
                nextNumString = "0" + nextNumString;
            }

            return "DT" + nextNumString;
        }
        DonThuocDAO dao_donThuoc = new DonThuocDAO();
        public DataTable GetThongTinDonThuocFromPhieuKham(string maPK)
        {
            return dao_donThuoc.GetThongTinDonThuocFromPhieuKham(maPK);
        }

        public DataTable GetThongTinTienThuocFromPhieuKham(string maPK)
        {
            return dao_donThuoc.GetThongTinTienThuocFromPhieuKham(maPK);
        }
        public DataTable GetBangThongKeSuDungThuoc(int thang, int nam)
        {
            return dao_donThuoc.GetBangThongKeSuDungThuoc(thang, nam);
        }

        public bool XoaDonThuocCoMaPK(string maPK)
        {
            return dao_donThuoc.XoaDonThuocCoMaPK(maPK);
        }
    }
}
