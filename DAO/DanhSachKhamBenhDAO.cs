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
    public class DanhSachKhamBenhDAO : DataProvider
    {
        static SqlConnection con;
        DataTable dt = new DataTable();

       // public DanhSachKhamBenhDAO()
       // {
          //  dt = GetThongTinTatCaDanhSach();
           // dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
       // }

        public static List<DanhSachKhamBenhDTO> GetThongTinTatCaDanhSach()
        {
            string sTruyVan = "select * from  DANHSACHKHAMBENH";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<DanhSachKhamBenhDTO> lstdskb = new List<DTO.DanhSachKhamBenhDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DanhSachKhamBenhDTO kb = new DanhSachKhamBenhDTO();
                kb.MaDSKB = dt.Rows[i]["MaDSKB"].ToString();
                kb.NgayKhamBenh = DateTime.Parse(dt.Rows[i]["NgayKhamBenh"].ToString());
                lstdskb.Add(kb);
            }
            DataProvider.DongKetNoi(con);
            return lstdskb;
        }

        public bool CheckDanhSachTonTai(string maDS)
        {
            try
            {
                con = DataProvider.MoKetNoi();
                SqlDataAdapter da = new SqlDataAdapter("select MaDSKB from DANHSACHKHAMBENH where MaDSKB=" + maDS, con);
                DataRow r = dt.Rows.Find(maDS);
                if (r != null)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        public static bool ThemDanhSach(DanhSachKhamBenhDTO pDSKB)
        {
         
            string sTruyVan = string.Format(@"insert into DANHSACHKHAMBENH values(N'{0}', N'{1}')", pDSKB.MaDSKB, pDSKB.NgayKhamBenh);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }


        public  static bool Delete(string pMaDSKB)
        {
            
            string sTruyVan = string.Format(@"delete from DANHSACHKHAMBENH where MaDSKB=N'{0}'", con);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public  static bool Update(DanhSachKhamBenhDTO pDSKB)
        {
        
            string sTruyVan = string.Format(@"update DANHSACHKHAMBENH set NgayKhamBenh=N'{0}', where MaDSKB=N'{1}'",
               pDSKB.MaDSKB, pDSKB.NgayKhamBenh);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public DataTable LayDanhSachKhamBenh(string mdy)
        {
            try
            {
                string query = @"exec GetDanhSachKhamBenh @ngayKhamBenh='" + mdy + @"'";
                //query = @"exec GetDanhSachKhamBenh @ngayKhamBenh='5/6/2019'";

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




    }
}
