using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BenhNhanDTO
    {
        //Mã bệnh nhân    

        private string smaBenhNhan;
        public string SMaBenhNhan
        {
            get
            {
                return smaBenhNhan;
            }

            set
            {
                smaBenhNhan = value;
            }
        }

        // họ tên bệnh nhân
        private string shoTen;
        public string SHoTen
        {
            get
            {
                return shoTen;
            }

            set
            {
                shoTen = value;
            }
        }

        //giới tính 
        private string sgioiTinh;
        public string SGioiTinh
        {
            get
            {
                return sgioiTinh;
            }

            set
            {
                sgioiTinh = value;
            }
        }

        // năm sinh 
        private int snamSinh;
        public int SNamSinh
        {
            get
            {
                return snamSinh;
            }

            set
            {
                snamSinh = value;
            }
        }


        //địa chỉ
        private string sdiaChi;
        public string SDiaChi
        {
            get
            {
                return sdiaChi;
            }

            set
            {
                sdiaChi = value;
            }
        }



        // số điện thoại 
        private string ssoDienThoai;
        public string SSoDienThoai
        {
            get
            {
                return ssoDienThoai;
            }

            set
            {
                ssoDienThoai = value;
            }
        }



        // chứng minh nhân dân
        private string scmnd;
        public string SCMND
        {
            get
            {
                return scmnd;
            }

            set
            {
                scmnd = value;
            }
        }
        public BenhNhanDTO()
        {
            this.SMaBenhNhan = "";
            this.SHoTen = "";
            this.SGioiTinh = "";
            this.SNamSinh = 0;
            this.SDiaChi = "";
            this.SSoDienThoai = "";
            this.SCMND = "";
        }
        public BenhNhanDTO(string pMaBenhNhan, string pHoTen, string pGioiTinh, int pNamSinh, string pDiaChi, string pSoDienThoai, string pCMND)
        {
            this.SMaBenhNhan = pMaBenhNhan;
            this.SHoTen = pHoTen;
            this.SGioiTinh = pGioiTinh;
            this.SNamSinh = pNamSinh;
            this.SDiaChi = pDiaChi;
            this.SSoDienThoai = pSoDienThoai;
            this.scmnd = pCMND;
        }

        public string tostring()
        {
            return this.ToString();
        }
    }
}

