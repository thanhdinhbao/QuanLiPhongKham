using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuKhamDTO
    {
        private string maPK;
        private string maCTDSKB;
        private string trieuChung;
        private string maLoaiBenh;

        public string MaPK
        {
            get
            {
                return maPK;
            }

            set
            {
                maPK = value;
            }
        }

        public string MaCTDSKB
        {
            get
            {
                return maCTDSKB;
            }

            set
            {
                maCTDSKB = value;
            }
        }

        public string TrieuChung
        {
            get
            {
                return trieuChung;
            }

            set
            {
                trieuChung = value;
            }
        }

        public string MaLoaiBenh
        {
            get
            {
                return maLoaiBenh;
            }

            set
            {
                maLoaiBenh = value;
            }
        }

        public PhieuKhamDTO(string pMaPK, string pMaCTDSKB, string pTrieuChung, string pMaLoaiBenh)
        {
            maPK = pMaPK;
            maCTDSKB = pMaCTDSKB;
            trieuChung = pTrieuChung;
            maLoaiBenh = pMaLoaiBenh;

        }
        public PhieuKhamDTO()
        {
            this.MaPK = "";
            this.MaCTDSKB = " ";
            this.TrieuChung = "";
            this.MaLoaiBenh = "";
        }
    }
}
