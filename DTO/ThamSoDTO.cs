using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class ThamSoDTO
    {
        private string maThamSo;
        private string tenThamSo;
        private int triGiaThamSo;

        public string MaThamSo
        {
            get
            {
                return maThamSo;
            }

            set
            {
                maThamSo = value;
            }
        }

        public string TenThamSo
        {
            get
            {
                return tenThamSo;
            }

            set
            {
                tenThamSo = value;
            }
        }

        public int TriGiaThamSo
        {
            get
            {
                return triGiaThamSo;
            }

            set
            {
                triGiaThamSo = value;
            }
        }

        public ThamSoDTO(string pMaThamSo, string pTenThamSo, int pTriGiaThamSo)
        {
            maThamSo = pMaThamSo;
            tenThamSo = pTenThamSo;
            triGiaThamSo = pTriGiaThamSo;
        }
        public ThamSoDTO()
        {
            this.MaThamSo = " ";
            this.TenThamSo = " ";
            this.TriGiaThamSo = 0;
        }
    }
}
