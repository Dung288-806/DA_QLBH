using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBH_ProductManagement.DTO;

namespace QLBH_ProductManagement.DAO
{
    public class RatesDAO
    {
        public List<RatesDTO> getRates()
        {
            string sql = "SELECT * FROM TIENTE";
            DataTable data = ConnectionDB.getData(sql);
            List<RatesDTO> list = new List<RatesDTO>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                RatesDTO rates = new RatesDTO();
                rates.iMaTT = data.Rows[i]["MaTT"].ToString();
                rates.iTenTT = data.Rows[i]["TenTT"].ToString();
                rates.iTGQD = data.Rows[i]["TGQD"].ToString();
                rates.iActive = bool.Parse(data.Rows[i]["Active"].ToString());
                list.Add(rates);
            }
            return list;
        }
    }
}
