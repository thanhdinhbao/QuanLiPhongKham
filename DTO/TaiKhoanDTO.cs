using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoanDTO
    {
        private string tenTaiKhoan;
        private string tenHienThi;
        private string chucVu;
        private int quyen;
        private string matKhau;

        public string TenTaiKhoan
        {
            get
            {
                return tenTaiKhoan;
            }

            set
            {
                tenTaiKhoan = value;
            }
        }

        public string TenHienThi
        {
            get
            {
                return tenHienThi;
            }

            set
            {
                tenHienThi = value;
            }
        }

        public string ChucVu
        {
            get
            {
                return chucVu;
            }

            set
            {
                chucVu = value;
            }
        }

        public int Quyen
        {
            get
            {
                return quyen;
            }

            set
            {
                quyen = value;
            }
        }

        public string MatKhau
        {
            get
            {
                return matKhau;
            }

            set
            {
                matKhau = value;
            }
        }

        public TaiKhoanDTO()
        {
            this.TenHienThi = "";
            this.TenTaiKhoan = "";
            this.ChucVu = "";
            this.Quyen = 0;
            this.MatKhau = "";
        }


        public TaiKhoanDTO(string TenTaiKhoan, string TenHienThi, string ChucVu, int Quyen, string MatKhau)
        {
            this.TenHienThi = TenHienThi;
            this.TenTaiKhoan = TenTaiKhoan;
            this.ChucVu = ChucVu;
            this.Quyen = Quyen;
            this.MatKhau = MatKhau;
        }
    }
}
