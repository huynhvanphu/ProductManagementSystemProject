using System;
using System.Collections.Generic;
using System.IO;
using Entities;
using Newtonsoft.Json;

namespace DAL
{
    public class DAL_Commodity
    {
        private string FilePathToCommodity { set; get; }

        public DAL_Commodity()
        {
            FilePathToCommodity = FilePathList.pathToCommodities;
        }
        public List<Commodity> ReadCommodity()
        {
            StreamReader stream = new StreamReader(FilePathToCommodity);
            List<Commodity> commodities = JsonConvert.DeserializeObject<List<Commodity>>(stream.ReadToEnd());
            stream.Close();
            return commodities;
        }
        public bool SaveCommodititiesList(List<Commodity> commodities)
        {
            if (!File.Exists(FilePathToCommodity))
            {
                throw new Exception("File lưu trữ không tồn tại");
            }
            StreamWriter stream = new StreamWriter(FilePathToCommodity);
            string jsonFile = JsonConvert.SerializeObject(commodities);
            stream.Write(jsonFile);
            stream.Close();
            return true;
        }
        public bool SaveCommodity(Commodity commodity)
        {
            List<Commodity> commoditiesList = ReadCommodity();
            int maxID = 0;
            if (commodity.ComId == 0)
            {
                if (commoditiesList.Count > 0)
                {
                    foreach (var comm in commoditiesList)
                    {
                        if (maxID < comm.ComId) maxID = comm.ComId;
                    }
                }
                commodity.ComId = maxID + 1;
                commoditiesList.Add(commodity);
            }
            else
            {
                var index = commoditiesList.FindIndex(c => c.ComId == commodity.ComId);
                commoditiesList[index] = commodity;
            }
            return SaveCommodititiesList(commoditiesList);
        }
        public void DeleteCom(int id)
        {
            List<Commodity> commodities = ReadCommodity();

            DAL_Product dalProduct = new DAL_Product();

            List<Product> products = dalProduct.ReadProducts();

            foreach (var p in products)
            {
                if (p.Commodity == id)
                {
                    dalProduct.DeleteProduct(p.Id);
                }
            }
            int index = commodities.FindIndex(c => c.ComId == id);
            commodities.RemoveAt(index);
            SaveCommodititiesList(commodities);
        }
    }
}
