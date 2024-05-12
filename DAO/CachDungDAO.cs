using DTO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class CachDungDAO : DataProvider
    {

        static SqlConnection con;
        DataTable dt = new DataTable();

        public static List<CachDungDTO> GetThongTinTatCaCachDung()
        {
            string sTruyVan = "select * from CACHDUNG";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<CachDungDTO> lstcachdung = new List<DTO.CachDungDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CachDungDTO cd = new CachDungDTO();
                cd.SMaLoaiCachDung = dt.Rows[i][0].ToString();
                cd.STenLoaiCachDung = dt.Rows[i][1].ToString();


                lstcachdung.Add(cd);
            }
            DataProvider.DongKetNoi(con);
            return lstcachdung;
        }

        public static bool Add(CachDungDTO pLoaiCachDung)
        {


            string sTruyVan = string.Format(@"insert into CACHDUNG values(N'{0}', N'{1}')", pLoaiCachDung.SMaLoaiCachDung, pLoaiCachDung.STenLoaiCachDung);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool Delete(string pMaLoaiCachDung)
        {

            string sTruyVan = string.Format(@"delete from CACHDUNG where MaLoaiCachDung=N'{0}'", pMaLoaiCachDung);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool Update(CachDungDTO pLoaiCachDung)
        {
            string sTruyVan = string.Format(@"update CACHDUNG set TenLoaiCachDung=N'{0}' where MaLoaiCachDung=N'{1}'", pLoaiCachDung.STenLoaiCachDung, pLoaiCachDung.SMaLoaiCachDung);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static string GetMaLoaiCachDungLast()
        {
            try
            {
                con = DataProvider.MoKetNoi();
                SqlDataAdapter da = new SqlDataAdapter("SELECT TOP 1 MaLoaiCachDung FROM CACHDUNG ORDER BY MaLoaiCachDung DESC", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt.Rows[0].ItemArray[0].ToString();

            }
            catch
            {
                return "CD00";
            }
        }
    }
}
