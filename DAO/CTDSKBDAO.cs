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
    
    public class CTDSKBDAO : DataProvider
    {
        static SqlConnection con;
        DataTable dt = new DataTable();

       // public CTDSKBDAO()
       // {
         //   dt = GetThongTinTatCaCT_DSKB();
         //   dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };// gán cột đầu trong datatable làm khóa 9 và duy nhất 
       // }

        public static List<CTDSKBDTO> GetThongTinTatCaCT_DSKB()
        {
            string sTruyVan = "select * from  CT_DSKB";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<CTDSKBDTO> lstctdskb = new List<DTO.CTDSKBDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CTDSKBDTO ct = new CTDSKBDTO();
                ct.MaCTDSKB = dt.Rows[i]["MaCTDSKB"].ToString();
                ct.MaDSKB = dt.Rows[i]["MaDSKB"].ToString();
                ct.MaBenhNhan = dt.Rows[i]["MaBenhNhan"].ToString();




                lstctdskb.Add(ct);
            }
            DataProvider.DongKetNoi(con);
            return lstctdskb;
        }

        public string GetLastMaCTDSKB()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT TOP 1 MaCTDSKB FROM CT_DSKB ORDER BY MaCTDSKB DESC", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt.Rows[0].ItemArray[0].ToString();
            }
            catch
            {
                return "CT0000000";
            }
        }

        public static bool ThemCTDSKB(CTDSKBDTO pCTDSKB)
        {
          
            string sTruyVan = string.Format(@"insert into CT_DSKB values(N'{0}', N'{1}',N'{2}')", pCTDSKB.MaCTDSKB, pCTDSKB.MaDSKB, pCTDSKB.MaBenhNhan);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public DataTable GetThongTinBenhNhanKhamBenh(string maPK, string maBenhNhan, string tenBenhNhan, string ngayKham, string cmnd, string sdt)
        {
            try
            {
                string query = @"exec TraCuuDanhSachBenhNhanKhamBenh @maPK='" + maPK
                                + "',@maBenhNhan='" + maBenhNhan
                                + "', @tenBenhNhan=N'" + tenBenhNhan
                                + "', @MaDSKB_NgayKham='" + ngayKham
                                + "', @cmnd='" + cmnd
                                + "', @sdt='" + sdt
                                + "'";
                con = DataProvider.MoKetNoi();
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

        public string GetMaCTDSKB(string maDSKB, string maBenhNhan)
        {
            try
            {
                string query = @"exec KiemTraBenhNhanCoTrongDanhSach @maBenhNhan='" + maBenhNhan
                                + @"', @maDSKB='" + maDSKB + @"'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows[0] != null)
                {
                    return dt.Rows[0].ItemArray[0].ToString();
                }
                else
                    return "";
            }
            catch
            {
                return "";
            }
        }

        public  static bool Delete(string pMaCTDSKB)
        {
         
            string sTruyVan = string.Format(@"delete from CT_DSKB where MaCTDSKB=N'{0}'", con);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }


        public static  bool Update(CTDSKBDTO pCTDSKB)
        {
            
            string sTruyVan = string.Format(@"update CT_DSKB set MaCTDSKB=N'{0}',MaDSKB=N'{1}', where MaBenhNhan=N'{2}'",
               pCTDSKB.MaCTDSKB, pCTDSKB.MaDSKB, pCTDSKB.MaBenhNhan);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public bool KiemTraBenhNhanCoTrongDanhSach(string maDS, string maBenhNhan)
        {
            try
            {
                string query = @"exec KiemTraBenhNhanCoTrongDanhSach @maBenhNhan='" + maBenhNhan
                                + @"', @maDSKB='" + maDS + @"'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows[0] != null)
                {
                    return true;
                }
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }
    }
}


