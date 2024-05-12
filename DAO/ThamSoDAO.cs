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
    public class ThamSoDAO
    {
        DataTable dt = new DataTable();
        static SqlConnection con;
       // public ThamSoDAO()
        //{
         //   dt = GetThongTinTatCaThamSo();
         //   dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
       // }

        public static List<ThamSoDTO> GetThongTinTatCaThamSo()
        {
            string sTruyVan = "select * from  THAMSO";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<ThamSoDTO> lstts = new List<DTO.ThamSoDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ThamSoDTO ts = new ThamSoDTO();
                ts.MaThamSo = dt.Rows[i]["MaThamSo"].ToString();
                ts.TenThamSo = dt.Rows[i]["TenThamSo"].ToString();
                ts.TriGiaThamSo = int.Parse(dt.Rows[i]["TriGiaThamSo"].ToString());



                lstts.Add(ts);
            }
            DataProvider.DongKetNoi(con);
            return lstts;
        }

        public int GetGiaTriThamSo(string tenThamSo)
        {
            try
            {
                string query = "SELECT TriGiaThamSo FROM THAMSO where TenThamSo='" + tenThamSo + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return Int32.Parse(dt.Rows[0].ItemArray[0].ToString());
            }
            catch
            {
                return -1;
            }
        }

        public string GetMaThamSoLast()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT TOP 1 MaThamSo FROM THAMSO ORDER BY MaThamSo DESC", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt.Rows[0].ItemArray[0].ToString();
            }
            catch
            {
                return "TS00";
            }
        }

        public static bool Add(ThamSoDTO pThamSo)
        {
       
            string sTruyVan = string.Format(@"insert into THAMSO values(N'{0}', N'{1}',N'{2}')", pThamSo.MaThamSo, pThamSo.TenThamSo, pThamSo.TriGiaThamSo);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }



        public static bool Delete(string pMaThamSo)
        {
        

            string sTruyVan = string.Format(@"delete from THAMSO where MaThamSo=N'{0}'", pMaThamSo);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }


        public static bool Update(ThamSoDTO pThamSo)
        {
        

            string sTruyVan = string.Format(@"update THAMSO set TenThamSo=N'{0}',TriGiaThamSo=N'{1}' where MaThamSo=N'{2}'",pThamSo.TenThamSo, pThamSo.TriGiaThamSo, pThamSo.MaThamSo);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

    }
}
