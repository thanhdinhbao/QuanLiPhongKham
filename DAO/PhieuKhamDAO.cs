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
    public class PhieuKhamDAO 
    {

        DataTable dt = new DataTable();
        static SqlConnection con;

       // public PhieuKhamDAO()
        //{
         //   dt = GetThongTinTatCaPhieuKham();
          //  dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
       // }
        public static List<PhieuKhamDTO> GetThongTinTatCaPhieuKham()
        {
            string sTruyVan = "select * from  PHIEUKHAM";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<PhieuKhamDTO> lstpk = new List<DTO.PhieuKhamDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PhieuKhamDTO pk = new PhieuKhamDTO();
                pk.MaPK = dt.Rows[i]["MaPK"].ToString();
                pk.MaCTDSKB = dt.Rows[i]["MaCTDSKB"].ToString();
                pk.TrieuChung = dt.Rows[i]["TrieuChung"].ToString();
                pk.MaLoaiBenh = dt.Rows[i]["MaLoaiBenh"].ToString();







                lstpk.Add(pk);
            }
            DataProvider.DongKetNoi(con);
            return lstpk;
        }
        public DataTable GetTatCaMaPK(string maPKGoiY)
        {

            try
            {
                string query = @"select top 5 MaPK from PHIEUKHAM where MaPK like '" + maPKGoiY + @"' + '%'";
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

        public string GetMaPKLast()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT TOP 1 MaPK FROM PHIEUKHAM ORDER BY MaPK DESC", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt.Rows[0].ItemArray[0].ToString();
            }
            catch
            {
                return "PK0000000";
            }
        }

        public static bool ThemPhieuKham(PhieuKhamDTO pPhieuKham)
        {
       

            string sTruyVan = string.Format(@"insert into PHIEUKHAM values(N'{0}', N'{1}',N'{2}', {3}')", pPhieuKham.MaPK, pPhieuKham.MaCTDSKB, pPhieuKham.TrieuChung, pPhieuKham.MaLoaiBenh);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool Delete(string pMaPK)
        {
           
            string sTruyVan = string.Format(@"delete from PHIEUKHAM where MaPK=N'{0}'", con);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }


        public static bool Update(PhieuKhamDTO pPhieuKham)
        {
        

            string sTruyVan = string.Format(@"update PHIEUKHAM set MaCTDSKB=N'{0}',TrieuChung=N'{1}',MaLoaiBenh=N'{2}',
                where MaPK=N'{3}'",
         pPhieuKham.MaCTDSKB, pPhieuKham.TrieuChung, pPhieuKham.MaLoaiBenh, pPhieuKham.MaPK);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }


    }
}
