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
    public class BenhNhanBUS
    {

        //Thêm Bệnh Nhân
        public bool ThemBenhNhan(BenhNhanDTO bn)
        {
            return BenhNhanDAO.ThemBenhNhan(bn);
        }


        //Xóa Bệnh Nhân
        public bool XoaBenhNhan(string bn)
        {
            return BenhNhanDAO.XoaBenhNhan(bn);
        }


        //Cập Nhật Bệnh Nhân
        public bool CapNhatBenhNhan(BenhNhanDTO pBenhNhan)
        {
            return BenhNhanDAO.CapNhatBenhNhan(pBenhNhan);
        }

        //Lấy DS Bệnh Nhân
        public static List<BenhNhanDTO> LayDSTatCaBenhNhan()
        {
            return BenhNhanDAO.LayDSTatCaBenhNhan();
        }


        // public DataTable GetThongTinTatCaBenhNhan()
        //{
        //  return dal_benhNhan.GetThongTinTatCaBenhNhan();
        // }


        //Lấy mã bệnh nhân tiếp theo
         public static string LayMaBenhNhanNext()
        {
            BenhNhanDAO dal_benhNhan = new BenhNhanDAO();
            string lastNumString = dal_benhNhan.GetMaBenhNhanLast();
            string lastNumStringRemove = lastNumString.Remove(0, 2); //Lay phan so ra
            int lastNum = Int32.Parse(lastNumStringRemove);
            int nextNum = lastNum + 1;
            string nextNumString = nextNum.ToString();
            while (nextNumString.Length < 7)
            {
                nextNumString = "0" + nextNumString;
            }

            return "BN" + nextNumString;
        }


        //lấy tên từ mã bệnh nhân



        public string GetTenFromMaBenhNhan(string pMaBenhNhan)
         {
          return BenhNhanDAO.GetTenFromMaBenhNhan(pMaBenhNhan);
         }

         public DataTable Get_Ten()
         {
            BenhNhanDAO dao_benhNhan = new BenhNhanDAO();
            return dao_benhNhan.Get_Ten();
        }

        public DataTable TimBenhNhan(string maBN, string hoTen, string cmnd, string gioiTinh, string namSinh, string sdt, string diaChi)
        {
            BenhNhanDAO dao_benhNhan = new BenhNhanDAO();
            return dao_benhNhan.TimBenhNhan(maBN, hoTen, cmnd, gioiTinh, namSinh, sdt, diaChi);


        }


        //  public string GetTenFromMaBenhNhan(string pMaBenhNhan)
        // {
        //     return BenhNhanDAO.GetTenFromMaBenhNhan(pMaBenhNhan);
        // }
    }
}