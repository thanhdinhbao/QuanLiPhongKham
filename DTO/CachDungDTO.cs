using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
     public class CachDungDTO
    {

        string smaLoaiCachDung, stenLoaiCachDung;

        public string SMaLoaiCachDung
        {
            get
            {
                return smaLoaiCachDung;
            }

            set
            {
                smaLoaiCachDung = value;
            }
        }

        public string STenLoaiCachDung
        {
            get
            {
                return stenLoaiCachDung;
            }

            set
            {
                stenLoaiCachDung = value;
            }
        }

        public CachDungDTO(string pMaLoaiCachDung, string pTenLoaiCachDung)
        {
            smaLoaiCachDung = pMaLoaiCachDung;
            stenLoaiCachDung = pTenLoaiCachDung;
        }

        public CachDungDTO()
        {
            this.smaLoaiCachDung = "";
            this.stenLoaiCachDung = "";
        }
    }
}
