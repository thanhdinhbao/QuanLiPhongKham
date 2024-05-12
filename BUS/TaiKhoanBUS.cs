using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class TaiKhoanBUS
    {
        //TaiKhoanDAO dao_taikhoan = new TaiKhoanDAO();
        public bool ThemTaiKhoan(TaiKhoanDTO pTaiKhoan)
        {
            return TaiKhoanDAO.ThemTaiKhoan(pTaiKhoan);
        }

        public bool Delete(string pTenTaiKhoan)
        {
            return TaiKhoanDAO.Delete(pTenTaiKhoan);
        }

        public bool Update(TaiKhoanDTO pTaiKhoan)
        {
            return TaiKhoanDAO.Update(pTaiKhoan);
        }

        public static List<TaiKhoanDTO> GetThongTinTatCaTaiKhoan()
        {
            return TaiKhoanDAO.GetThongTinTatCaTaiKhoan();
        }


        TaiKhoanDAO dao_taikhoan = new TaiKhoanDAO();
        public string GetTenFromTenTaiKhoan(string pTenTaiKhoan)
        {
            return dao_taikhoan.GetTenFromTenTaiKhoan(pTenTaiKhoan);
        }
        public string GetChucVuFromTenTaiKhoan(string pTenTaiKhoan)
        {
            return dao_taikhoan.GetChucVuFromTenTaiKhoan(pTenTaiKhoan);
        }
        public string GetMatKhauFromTenTaiKhoan(string pTenTaiKhoan)
        {
            return dao_taikhoan.GetMatKhauFromTenTaiKhoan(pTenTaiKhoan);
        }

        public string GetQuyenFromTenTaiKhoan(string pTenTaiKhoan)
        {
            return dao_taikhoan.GetQuyenFromTenTaiKhoan(pTenTaiKhoan);
        }
    }

    public static class Hash256
    {
        public static string Hash256Data(string data)
        {
            // Create a SHA256   

            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(data));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
