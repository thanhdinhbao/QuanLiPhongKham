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
    public class LoaiDonViDAO
    {
        DataTable dt = new DataTable();
        static SqlConnection con;
       // public LoaiDonViDAO()
       // {
        //    dt = GetThongTinTatCaLoaiDonVi();
         //   dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
        //}
    public static List<LoaiDonViDTO> GetThongTinTatCaLoaiDonVi()
        {
        string sTruyVan = "select * from  LOAIDONVI";
        con = DataProvider.MoKetNoi();
        DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
        if (dt.Rows.Count == 0)
        {
            return null;
        }

        List<LoaiDonViDTO> lstdv = new List<DTO.LoaiDonViDTO>();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
                LoaiDonViDTO dv = new LoaiDonViDTO();
                dv.MaLoaiDonVi = dt.Rows[i]["MaLoaiDonVi"].ToString();
                dv.TenLoaiDonVi = dt.Rows[i]["TenLoaiDonVi"].ToString();
                lstdv.Add(dv);
        }
        DataProvider.DongKetNoi(con);
        return lstdv;
    }

        public static bool Add(LoaiDonViDTO pLoaiDonVi)
        {
           
            string sTruyVan = string.Format(@"insert into LOAIDONVI values(N'{0}', N'{1}')", pLoaiDonVi.MaLoaiDonVi, pLoaiDonVi.TenLoaiDonVi);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool Delete(string pMaLoaiDonVi)
        {
  
            string sTruyVan = string.Format(@"delete from LOAIDONVI where MaLoaiDonVi=N'{0}'", pMaLoaiDonVi);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }


        public static bool Update(LoaiDonViDTO pLoaiDonVi)
        {
        
            string sTruyVan = string.Format(@"update LOAIDONVI set TenLoaiDonVi=N'{0}' where MaLoaiDonVi=N'{1}'",pLoaiDonVi.TenLoaiDonVi, pLoaiDonVi.MaLoaiDonVi);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }


        public string GetMaLoaiDonViLast()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT TOP 1 MaLoaiDonVi FROM LOAIDONVI ORDER BY MaLoaiDonVi DESC", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt.Rows[0].ItemArray[0].ToString();
            }
            catch
            {
                return "DV00";
            }
        }

    }
}
