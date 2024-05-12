using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CTDSKBDTO
    {
        private string maCTDSKB;
        private string maDSKB;
        private string maBenhNhan;

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

        public string MaDSKB
        {
            get
            {
                return maDSKB;
            }

            set
            {
                maDSKB = value;
            }
        }

        public string MaBenhNhan
        {
            get
            {
                return maBenhNhan;
            }

            set
            {
                maBenhNhan = value;
            }
        }

        public CTDSKBDTO(string pMaCTDSKB, string pMaDSKB, string pMaBenhNhan)
        {
            maCTDSKB = pMaCTDSKB;
            maDSKB = pMaDSKB;
            maBenhNhan = pMaBenhNhan;
        }
        public CTDSKBDTO()
        {
            this.maCTDSKB = "";
            this.maDSKB = "";
            this.maBenhNhan = "";
        }
    }
}
