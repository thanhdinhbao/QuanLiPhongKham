using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class BenhNhanDAO : DataProvider
    {
        static SqlConnection con;
        static DataTable dt = new DataTable();
        public static List<BenhNhanDTO> LayDSTatCaBenhNhan()
        {
            string sTruyVan = "select * from BENHNHAN";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<BenhNhanDTO> lstBenhNhan = new List<DTO.BenhNhanDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                BenhNhanDTO bn = new BenhNhanDTO();
                bn.SMaBenhNhan = dt.Rows[i]["MaBenhNhan"].ToString();
                bn.SHoTen = dt.Rows[i]["HoTen"].ToString();
                bn.SCMND = dt.Rows[i]["CMND"].ToString();
                bn.SDiaChi = dt.Rows[i]["DiaChi"].ToString();
                bn.SNamSinh = int.Parse(dt.Rows[i]["NamSinh"].ToString());
                bn.SGioiTinh = dt.Rows[i]["GioiTinh"].ToString();
                bn.SSoDienThoai = dt.Rows[i]["SoDienThoai"].ToString();

                lstBenhNhan.Add(bn);
            }
            DataProvider.DongKetNoi(con);
            return lstBenhNhan;
        }

        // Thêm benh nhan 
        public static bool ThemBenhNhan(BenhNhanDTO pBenhNhan)
        {
            string sTruyVan = string.Format(@"insert into BENHNHAN values(N'{0}', N'{1}',N'{2}', {3}, N'{4}', N'{5}', N'{6}')", pBenhNhan.SMaBenhNhan, pBenhNhan.SHoTen, pBenhNhan.SGioiTinh, pBenhNhan.SNamSinh, pBenhNhan.SDiaChi, pBenhNhan.SSoDienThoai, pBenhNhan.SCMND);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        //tim benh nhan theo ma
        public DataTable TimBenhNhan(string maBN, string hoTen, string cmnd, string gioiTinh, string namSinh, string sdt, string diaChi)
        {
            try
            {
             BenhNhanDTO bn = new BenhNhanDTO();
                con = DataProvider.MoKetNoi();
            string query = "exec TimBenhNhan @maBN='" + maBN
              + "', @hoTen=N'" + hoTen
               + "', @cmnd='" + cmnd
              + "', @gioiTinh=N'" + gioiTinh
                + "', @namSinh='" + namSinh
               + "', @sdt='" + sdt
                + "', @diaChi=N'" + diaChi + "'";
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

        public static bool CapNhatBenhNhan(BenhNhanDTO bn)
        {
            string sTruyVan = string.Format(@"update BENHNHAN set HoTen=N'{0}',
               GioiTinh ='{1}',NamSinh =N'{2}',DiaChi=N'{3}',SoDienThoai='{4}',  CMND='{5}' where MaBenhNhan=N'{6}'",
                bn.SHoTen, bn.SGioiTinh, bn.SNamSinh, bn.SDiaChi, bn.SSoDienThoai, bn.SCMND, bn.SMaBenhNhan);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }


        // Xóa thông tin benh nhan
        public static bool XoaBenhNhan(string bn)
        {
            string sTruyVan = string.Format(@"delete from BENHNHAN where MaBenhNhan=N'{0}'",bn);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }



      

            public string GetMaBenhNhanLast()
            {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT TOP 1 MaBenhNhan FROM BENHNHAN ORDER BY MaBenhNhan DESC", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt.Rows[0].ItemArray[0].ToString();

            }
            catch
            {
                return "BN0000000";
            }
        }
        public  static string GetTenFromMaBenhNhan(string pMaBenhNhan)
        {
            try
            {
                string query = @"select HoTen from BENHNHAN where MaBenhNhan='" + pMaBenhNhan + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt.Rows[0].ItemArray[0].ToString();
            }
            catch
            {
                return "";
            }


        }
        #region TestLoadTenLen
        public DataTable Get_Ten()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from BENHNHAN", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        #endregion
    }
}
