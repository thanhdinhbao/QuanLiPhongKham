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
    public class LoaiThuocDAO
    {
        DataTable dt = new DataTable();
        static SqlConnection con;
        //public LoaiThuocDAO()
       // {
       //     dt = GetThongTinTatCaLoaiThuoc();
         //   dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
        //}

        public static List<LoaiThuocDTO> GetThongTinTatCaLoaiThuoc()
        {
            string sTruyVan = "select * from  LOAITHUOC";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<LoaiThuocDTO> lstdv = new List<DTO.LoaiThuocDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LoaiThuocDTO lt = new LoaiThuocDTO();
                lt.MaLoaiThuoc = dt.Rows[i]["MaLoaiThuoc"].ToString();
                lt.TenLoaiThuoc = dt.Rows[i]["TenLoaiThuoc"].ToString();
                lt.MaLoaiDonVi = dt.Rows[i]["MaLoaiDonVi"].ToString();
                lt.MaLoaiCachDung = dt.Rows[i]["MaLoaiCachDung"].ToString();
                lt.DonGia = int.Parse(dt.Rows[i]["DonGia"].ToString());






                lstdv.Add(lt);
            }
            DataProvider.DongKetNoi(con);
            return lstdv;
        }
        public static bool Add(LoaiThuocDTO pLoaiThuoc)
        {
            string sTruyVan = string.Format(@"insert into LOAITHUOC values(N'{0}', N'{1}',N'{2}',N'{3}',N'{4}')", pLoaiThuoc.MaLoaiThuoc, pLoaiThuoc.TenLoaiThuoc, pLoaiThuoc.MaLoaiDonVi, pLoaiThuoc.MaLoaiCachDung, pLoaiThuoc.DonGia);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool Delete(string pMaLoaiThuoc)
        {
         

            string sTruyVan = string.Format(@"delete from LOAITHUOC where MaLoaiThuoc=N'{0}'", pMaLoaiThuoc);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }


        public static bool Update(LoaiThuocDTO pLoaiThuoc)
        {
       

            string sTruyVan = string.Format(@"update LOAITHUOC set TenLoaiThuoc=N'{0}',MaLoaiDonVi=N'{1}',MaLoaiCachDung=N'{2}',DonGia={3} where MaLoaiThuoc=N'{4}'", pLoaiThuoc.TenLoaiThuoc, pLoaiThuoc.MaLoaiDonVi, pLoaiThuoc.MaLoaiCachDung, pLoaiThuoc.DonGia, pLoaiThuoc.MaLoaiThuoc);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public DataTable TimKiemThuoc(string maThuoc, string tenThuoc, string tenLoaiDonVi, string cachDung, string donGia)
        {
            try
            {
                string query = @"exec TimKiemThuoc @maLoaiThuoc = '" + maThuoc
                               + @"', @tenLoaiThuoc = N'" + tenThuoc
                               + @"', @tenLoaiDonVi = N'" + tenLoaiDonVi
                               + @"', @tenLoaiCachDung = N'" + cachDung
                               + @"', @donGia = '" + donGia + @"'";
                //phai using System.Data.SqlClient;
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

        public static DataTable GetThongTinCanShowVeThuoc()
        {
            try
            {
                //phai using System.Data.SqlClient;
                con = DataProvider.MoKetNoi();
                SqlDataAdapter da = new SqlDataAdapter("exec GetThongTinVeThuoc", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public string GetMaLoaiThuocFromTen(string tenThuoc)
        {
            string query = @"select MaLoaiThuoc from LOAITHUOC where TenLoaiThuoc = '" + tenThuoc + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt.Rows[0].ItemArray[0].ToString();
        }

        public string GetMaLoaiThuocLast()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT TOP 1 MaLoaiThuoc FROM LOAITHUOC where MaLoaiThuoc like 'LT%' ORDER BY MaLoaiThuoc DESC", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt.Rows[0].ItemArray[0].ToString();
            }
            catch
            {
                return "LT00";
            }

        }
    }
}
