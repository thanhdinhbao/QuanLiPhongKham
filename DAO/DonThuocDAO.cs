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
    public class DonThuocDAO : DataProvider
    {
        static SqlConnection con;
        DataTable dt = new DataTable();
       // public DonThuocDAO()
        //{
           // dt = GetThongTinTatCaDonThuoc();
           // dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
       // }

        public static List<DonThuocDTO> GetThongTinTatCaDonThuoc()
        {
            string sTruyVan = "select * from  DONTHUOC";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<DonThuocDTO> lstdt = new List<DTO.DonThuocDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DonThuocDTO thuoc = new DonThuocDTO();
                thuoc.MaDT = dt.Rows[i]["MaDT"].ToString();
                thuoc.MaPK = dt.Rows[i]["MaPK"].ToString();
                thuoc.MaLoaiThuoc = dt.Rows[i]["MaLoaiThuoc"].ToString();
                thuoc.SoLuong = int.Parse(dt.Rows[i]["SoLuong"].ToString());





            lstdt.Add(thuoc);
            }
            DataProvider.DongKetNoi(con);
            return lstdt;
        }

        public DataTable GetThongTinDonThuocFromPhieuKham(string maPK)
        {
            try
            {
                string query = "exec LayThongTinDonThuoc @MaPK='" + maPK + "'";
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

        public string GetMaDonThuocLast()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT TOP 1 MaDT FROM DONTHUOC ORDER BY MaDT DESC", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt.Rows[0].ItemArray[0].ToString();
            }
            catch
            {
                return "DT00000000";
            }
        }

        public DataTable GetThongTinTienThuocFromPhieuKham(string maPK)
        {
            try
            {
                string query = "exec LayThongTinTienThuoc @MaPK='" + maPK + "'";
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

        public bool XoaDonThuocCoMaPK(string maPK)
        {
            try
            {
                string query = @"delete from DONTHUOC where MaPK='" + maPK + "'";
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

        public DataTable GetBangThongKeSuDungThuoc(int thang, int nam)
        {
            //exec ThongKeSuDungThuoc @thang='6', @nam='2019'
            try
            {
                con = DataProvider.MoKetNoi();
                string query = "exec ThongKeSuDungThuoc @thang='" + thang + "', @nam='" + nam + "'";
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


        public static  bool Add(DonThuocDTO pDonThuoc)
        {
            
            string sTruyVan = string.Format(@"insert into DONTHUOC values(N'{0}', N'{1}',N'{2}', {3}')", pDonThuoc.MaDT, pDonThuoc.MaPK, pDonThuoc.MaLoaiThuoc, pDonThuoc.SoLuong);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;

        }

        public static  bool Delete(string pMaDt)
        {
       
            string sTruyVan = string.Format(@"delete from DONTHUOC where MaDT=N'{0}'", con);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }


        public  static bool Update(DonThuocDTO pDonThuoc)
        {

            string sTruyVan = string.Format(@"update DONTHUOC set MaPK=N'{0}',
               MaLoaiThuoc ='{1}',SoLuong =N'{2}' where MaDT=N'{3}'",
                pDonThuoc.MaPK, pDonThuoc.MaLoaiThuoc, pDonThuoc.SoLuong, pDonThuoc.MaDT);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }


    }
}
