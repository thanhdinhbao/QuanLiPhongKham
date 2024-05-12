using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class HoaDonDAO : DataProvider
    {
        static SqlConnection con;
        DataTable dt = new DataTable();
        //public HoaDonDAO()
        //{
        // dt = GetThongTinTatCaHoaDon();
        // dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
        // }

        public static List<HoaDonDTO> GetThongTinTatCaHoaDon()
        {
            string sTruyVan = "select * from  HOADON";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<HoaDonDTO> lsthd = new List<DTO.HoaDonDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDonDTO hd = new HoaDonDTO();
                hd.MaHoaDon = dt.Rows[i]["MaHoaDon"].ToString();
                hd.MaPK = dt.Rows[i]["MaPK"].ToString();
                hd.TienKham = int.Parse(dt.Rows[i]["TienKham"].ToString());
                hd.TienThuoc = int.Parse(dt.Rows[i]["TienThuoc"].ToString());
                




                lsthd.Add(hd);
            }
            DataProvider.DongKetNoi(con);
            return lsthd;
        }

        public DataTable BaoCaoDoanhThu(int thang, int nam)
        {
            try
            {
                con = DataProvider.MoKetNoi();
                string query = "exec BaoCaoDoanhThu @thang='" + thang + "', @nam='" + nam + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public string GetMaHoaDonLast()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT TOP 1 MaHoaDon FROM HOADON ORDER BY MaHoaDon DESC", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt.Rows[0].ItemArray[0].ToString();
            }
            catch
            {
                return "HD00000000";
            }
        }

        public bool XoaHoaDonCoMaPK(string maPK)
        {
            try
            {
                string query = @"delete from HOADON where MaPK='" + maPK + "'";
                con.Open();
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.ExecuteNonQuery();
                }
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Add(HoaDonDTO pHoaDon)
        {
      
            string sTruyVan = string.Format(@"insert into HOADON values(N'{0}', N'{1}',N'{2}', {3}')", pHoaDon.MaHoaDon, pHoaDon.MaPK, pHoaDon.TienKham, pHoaDon.TienThuoc);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public DataTable GetThongTinHoaDonFromPhieuKham(string maPK)
        {
            try
            {
                string query = "exec LayThongTinHoaDon @MaPK='" + maPK + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public static bool Delete(string pMaDt)
        {
      
            string sTruyVan = string.Format(@"delete from HOADON where MaHoaDon=N'{0}'", con);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }


        public static bool Update(HoaDonDTO pHoaDon)
        {
     
            string sTruyVan = string.Format(@"update HOADON set MaPK=N'{0}',
               TienKham ='{1}',TienThuoc =N'{2}' where MaHoaDon=N'{3}'",
                pHoaDon.MaPK, pHoaDon.TienKham, pHoaDon.TienThuoc, pHoaDon.MaHoaDon);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

    }
}
