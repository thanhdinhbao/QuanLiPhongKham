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

    public class LoaiBenhDAO : DataProvider
    {
        static SqlConnection con;
        DataTable dt = new DataTable();

        //public LoaiBenhDAO()
        // {
        //  dt = GetThongTinTatCaLoaiBenh();
        //  dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
        //}


        public static List<LoaiBenhDTO> GetThongTinTatCaLoaiBenh()
        {
            string sTruyVan = "select * from  LOAIBENH";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<LoaiBenhDTO> lstlb = new List<DTO.LoaiBenhDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LoaiBenhDTO lb = new LoaiBenhDTO();
                lb.MaLoaiBenh = dt.Rows[i]["MaLoaiBenh"].ToString();
                lb.TenLoaiBenh = dt.Rows[i]["TenLoaiBenh"].ToString();
                





                lstlb.Add(lb);
            }
            DataProvider.DongKetNoi(con);
            return lstlb;
        }

        public static  bool Add(LoaiBenhDTO pLoaiBenh)
        {
       

            string sTruyVan = string.Format(@"insert into LOAIBENH values(N'{0}', N'{1}')", pLoaiBenh.MaLoaiBenh, pLoaiBenh.TenLoaiBenh);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool Delete(string pMaLoaiBenh)
        {
       
            string sTruyVan = string.Format(@"delete from LOAIBENH where MaLoaiBenh=N'{0}'", pMaLoaiBenh);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }


        public static bool Update(LoaiBenhDTO pLoaiBenh)
        {
       
            string sTruyVan = string.Format(@"update LOAIBENH set TenLoaiBenh=N'{0}' where MaLoaiBenh=N'{1}'",pLoaiBenh.TenLoaiBenh, pLoaiBenh.MaLoaiBenh);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public string GetMaLoaiBenhLast()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT TOP 1 MaLoaiBenh FROM LOAIBENH ORDER BY MaLoaiBenh DESC", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt.Rows[0].ItemArray[0].ToString();
            }
            catch
            {
                return "LB00";
            }
        }

    }
}
