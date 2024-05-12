using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class TaiKhoanDAO    
    {
        DataTable dt = new DataTable();
        static SqlConnection con = DataProvider.MoKetNoi();
        //public  TaiKhoanDAO()
        //{
           // try
           // {
             //   dt = GetThongTinTatCaTaiKhoan();
             //   dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
           // }
           // catch
           // {
           //     System.Windows.Forms.MessageBox.Show("Kết nối CSDL thất bại!");

           // }

       // }

        public static List<TaiKhoanDTO> GetThongTinTatCaTaiKhoan()
        {
            string sTruyVan = "select * from  TAIKHOAN";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<TaiKhoanDTO> lsttk = new List<DTO.TaiKhoanDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TaiKhoanDTO tk = new TaiKhoanDTO();
                tk.TenTaiKhoan =  dt.Rows[i]["TenTaiKhoan"].ToString();
                tk.TenHienThi = dt.Rows[i]["TenHienThi"].ToString();
                tk.ChucVu = dt.Rows[i]["ChucVu"].ToString();
                tk.Quyen = int.Parse(dt.Rows[i]["Quyen"].ToString());
                tk.MatKhau = dt.Rows[i]["MatKhau"].ToString();


                lsttk.Add(tk);
            }
            DataProvider.DongKetNoi(con);
            return lsttk;
        }

        public string GetTenFromTenTaiKhoan(string pTenTaiKhoan)
        {
            try
            {
                string query = @"select TenHienThi from TAIKHOAN where TenTaiKhoan='" + pTenTaiKhoan + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt.Rows[0].ItemArray[0].ToString();
            }
            catch
            {
                return "";
            }

        }

        public string GetChucVuFromTenTaiKhoan(string pTenTaiKhoan)
        {
            try
            {
                string query = @"select ChucVu from TAIKHOAN where TenTaiKhoan='" + pTenTaiKhoan + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt.Rows[0].ItemArray[0].ToString();
            }
            catch
            {
                return "";
            }

        }
        public string GetMatKhauFromTenTaiKhoan(string pTenTaiKhoan)
        {
            try
            {
                con = DataProvider.MoKetNoi();
                string query = @"select MatKhau from TAIKHOAN where TenTaiKhoan='" + pTenTaiKhoan + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt.Rows[0].ItemArray[0].ToString();
                DataProvider.DongKetNoi(con);
            }
            catch
            {
                return "";
            }
        }

        public string GetQuyenFromTenTaiKhoan(string pTenTaiKhoan)
        {
            try
            {
                con = DataProvider.MoKetNoi();
                string query = @"select Quyen from TAIKHOAN where TenTaiKhoan='" + pTenTaiKhoan + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt.Rows[0].ItemArray[0].ToString();
            }
            catch
            {
                return "";
            }
        }
        /// Thêm - Xóa - Phân quyền
        // Thêm
        public static  bool ThemTaiKhoan(TaiKhoanDTO TaiKhoan)
        {
     

            string sTruyVan = string.Format(@"insert into TAIKHOAN values(N'{0}', N'{1}',N'{2}', {3},'{4}')", TaiKhoan.TenTaiKhoan, TaiKhoan.TenHienThi, TaiKhoan.ChucVu, TaiKhoan.Quyen, TaiKhoan.MatKhau);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        // Update

        public static bool Update(TaiKhoanDTO pTaiKhoan)
        {
        

            string sTruyVan = string.Format(@"update TAIKHOAN set TenHienThi=N'{0}',ChucVu=N'{1}',Quyen={2},MatKhau=N'{3}' where TenTaiKhoan=N'{4}'",
             pTaiKhoan.TenHienThi, pTaiKhoan.ChucVu, pTaiKhoan.Quyen, pTaiKhoan.MatKhau, pTaiKhoan.TenTaiKhoan);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        // Xóa
        public static bool Delete(string pTaiKhoan)
        {
        
            string sTruyVan = string.Format(@"delete from TAIKHOAN where TenTaiKhoan=N'{0}'", pTaiKhoan);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
    }
}
