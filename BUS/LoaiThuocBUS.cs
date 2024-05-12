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
    public class LoaiThuocBUS
    {
        //LoaiThuocDAO dao_loaiThuoc = new LoaiThuocDAO();
        public static bool Add(LoaiThuocDTO pLoaiThuoc)
        {
            return LoaiThuocDAO.Add(pLoaiThuoc);
        }

        public static bool Delete(string pMaLoaiThuoc)
        {
            return LoaiThuocDAO.Delete(pMaLoaiThuoc);
        }

        public static bool Update(LoaiThuocDTO pLoaiThuoc)
        {
            return LoaiThuocDAO.Update(pLoaiThuoc);
        }

        public static List<LoaiThuocDTO> GetThongTinTatCaLoaiThuoc()
        {
            return LoaiThuocDAO.GetThongTinTatCaLoaiThuoc();
        }


        LoaiThuocDAO dao_loaiThuoc = new LoaiThuocDAO();
        public DataTable TimKiemThuoc(string maThuoc, string tenThuoc, string tenLoaiDonVi, string cachDung, string donGia)
        {
            return dao_loaiThuoc.TimKiemThuoc(maThuoc, tenThuoc, tenLoaiDonVi, cachDung, donGia);
        }


        public static  DataTable GetThongTinCanShowVeThuoc()
        {
            //LoaiThuocDAO dao_loaiThuoc = new LoaiThuocDAO();
            return LoaiThuocDAO.GetThongTinCanShowVeThuoc();
        }

        public string GetMaLoaiThuocNext()
        {
            string lastNumString = dao_loaiThuoc.GetMaLoaiThuocLast();
            string lastNumStringRemove = lastNumString.Remove(0, 2); //Lay phan so ra
            int lastNum = Int32.Parse(lastNumStringRemove);
            int nextNum = lastNum + 1;
            string nextNumString = nextNum.ToString();
            while (nextNumString.Length < 2)// gom 2 chu so
            {
                nextNumString = "0" + nextNumString;
            }

            return "LT" + nextNumString;
        }

        public string GetMaLoaiThuocFromTen(string tenThuoc)
        {
            return dao_loaiThuoc.GetMaLoaiThuocFromTen(tenThuoc);
        }
    }
}
