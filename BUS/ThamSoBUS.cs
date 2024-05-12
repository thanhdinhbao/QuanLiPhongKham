using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class ThamSoBUS
    {
        //ThamSoDAO dao_thamSo = new ThamSoDAO();

        public bool Add(ThamSoDTO pThamSo)
        {
            return ThamSoDAO.Add(pThamSo);
        }

        public bool Delete(string pMaThamSo)
        {
            return ThamSoDAO.Delete(pMaThamSo);
        }

        public bool Update(ThamSoDTO pThamSo)
        {
            return ThamSoDAO.Update(pThamSo);
        }

        public static List<ThamSoDTO> GetThongTinTatCaThamSo()
        {
            return ThamSoDAO.GetThongTinTatCaThamSo();
        }

        ThamSoDAO dao_thamSo = new ThamSoDAO();
        public string GetNextMaThamSo()
        {
            string lastNumString = dao_thamSo.GetMaThamSoLast();
            string lastNumStringRemove = lastNumString.Remove(0, 2); //Lay phan so ra
            int lastNum = Int32.Parse(lastNumStringRemove);
            int nextNum = lastNum + 1;
            string nextNumString = nextNum.ToString();
            while (nextNumString.Length < 2)// 2 chu so
            {
                nextNumString = "0" + nextNumString;
            }

            return "TS" + nextNumString;
        }

        public int GetGiaTriThamSo(string tenThamSo)
        {
            return dao_thamSo.GetGiaTriThamSo(tenThamSo);
        }
    }
}
