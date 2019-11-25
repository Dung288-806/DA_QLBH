using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBH_ProductManagement.DTO;

namespace QLBH_ProductManagement.DAO
{
    public class GroupOfGoodsDAO
    {
        public List<GroupOfGoodsDTO> getGroupOfGoods()
        {
            string sql = "SELECT * FROM NHOMHANG";
            DataTable data = ConnectionDB.getData(sql);
            List<GroupOfGoodsDTO> list = new List<GroupOfGoodsDTO>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                GroupOfGoodsDTO GroupOfGoods = new GroupOfGoodsDTO();
                GroupOfGoods.iMaNhom = data.Rows[i]["MaNhom"].ToString();
                GroupOfGoods.iTenNhom = data.Rows[i]["TenNhom"].ToString();
                GroupOfGoods.iGhiChu = data.Rows[i]["GhiChu"].ToString();
                GroupOfGoods.iActive = bool.Parse(data.Rows[i]["Active"].ToString());
                list.Add(GroupOfGoods);
            }
            return list;
        }
    }
}
