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
    public class DanhSachKhamBenhBUS
    {
        //DanhSachKhamBenhDAO dao_danhSachKhamBenh = new DanhSachKhamBenhDAO();

        public bool ThemDanhSach(DanhSachKhamBenhDTO pDSKB)
        {
            return DanhSachKhamBenhDAO.ThemDanhSach(pDSKB);
        }

        public bool Delete(string pMaDSKB)
        {
            return DanhSachKhamBenhDAO.Delete(pMaDSKB);
        }

        public bool Update(DanhSachKhamBenhDTO pDSKB)
        {
            return DanhSachKhamBenhDAO.Update(pDSKB);
        }

        public static List<DanhSachKhamBenhDTO> GetThongTinTatCaDanhSach()
        {
            return DanhSachKhamBenhDAO.GetThongTinTatCaDanhSach();
        }

        DanhSachKhamBenhDAO dao_danhSachKhamBenh = new DanhSachKhamBenhDAO();
        public bool CheckDanhSachTonTai(string maDS)
        {
            return dao_danhSachKhamBenh.CheckDanhSachTonTai(maDS);
        }

        public DataTable LayDanhSachKhamBenh(DateTime date)
        {
            string mdy = date.Month.ToString() + @"/" + date.Day.ToString() + @"/" + date.Year.ToString();
            return dao_danhSachKhamBenh.LayDanhSachKhamBenh(mdy);
        }
    }
}
