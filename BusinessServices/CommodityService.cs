using System;
using Entities;
using DAL;
using System.Collections.Generic;
using System.Linq;

namespace BusinessServices
{
    public class CommodityService
    {
        private DAL_Commodity dalCommodity { set; get; }

        public CommodityService()
        {
            dalCommodity = new DAL_Commodity();
        }

        public List<Commodity> ReadCommodity() => dalCommodity.ReadCommodity();

        public void SaveCommodity(Commodity commodity) => dalCommodity.SaveCommodity(commodity);

        public Commodity FindComById(int id)
        {
            List<Commodity> commodities = dalCommodity.ReadCommodity();

            var com = commodities.Where(com => com.ComId == id).FirstOrDefault();

            if (com == null) throw new Exception("Không tìm thấy loại hàng");

            return com;
        }

        public void DeleteCom(int id) => dalCommodity.DeleteCom(id);

        public List<Commodity> FindComByName(string key)
        {
            List<Commodity> commodities = dalCommodity.ReadCommodity();

            var com = commodities.Where(com => com.ComName.Contains(key)).ToList();

            if (com == null) throw new Exception("Không tìm thấy loại hàng");

            return com;
        }
    }
}
