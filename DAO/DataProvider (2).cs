using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DataProvider
    {
        //Thực hiện mở kết nối
        public static SqlConnection MoKetNoi()
        {
            string s = @"Data Source=LAPTOP-KK1DMKC1\SQLEXPRESS;Initial Catalog=PKBSGD;Integrated Security=True";
            SqlConnection KetNoi = new SqlConnection(s);
            KetNoi.Open();
            return KetNoi;
        }

        //Thực hiện đóng kết nối
        public static void DongKetNoi(SqlConnection KetNoi)
        {
            KetNoi.Close();
        }

        // Thực hiện truy vấn trả về bảng dữ liệu
        public static DataTable TruyVanLayDuLieu(string sTruyVan, SqlConnection KetNoi)
        {
            SqlDataAdapter da = new SqlDataAdapter(sTruyVan, KetNoi);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // Thực hiện truy vấn không trả về dữ liệu
        public static bool TruyVanKhongLayDuLieu(string sTruyVan, SqlConnection KetNoi)
        {
            try
            {
                SqlCommand cm = new SqlCommand(sTruyVan, KetNoi);
                cm.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
