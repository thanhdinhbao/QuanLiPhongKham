using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DanhSachKhamBenhDTO
    {

        private string maDSKB;
        private DateTime ngayKhamBenh;

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

        public DateTime NgayKhamBenh
        {
            get
            {
                return ngayKhamBenh;
            }

            set
            {
                ngayKhamBenh = value;
            }
        }

        public DanhSachKhamBenhDTO(string pMaDSKB, DateTime pNgayKhamBenh)
        {
            maDSKB = pMaDSKB;
            ngayKhamBenh = pNgayKhamBenh;
        }

        public DanhSachKhamBenhDTO()
        {
            this.maDSKB = "";
            this.ngayKhamBenh = DateTime.Now;
        } 
    }
}
