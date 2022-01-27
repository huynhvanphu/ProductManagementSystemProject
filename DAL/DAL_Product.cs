using System;
using System.Collections.Generic;
using System.IO;
using Entities;
using Newtonsoft.Json;

namespace DAL
{
    public class DAL_Product
    {
        private string FilePathToProducts { set; get; }

        public DAL_Product()
        {
            FilePathToProducts = FilePathList.pathToProducts;
        }
        
        public List<Product> ReadProducts()
        {
            StreamReader stream = new StreamReader(FilePathToProducts);
            List<Product> products = JsonConvert.DeserializeObject<List<Product>>(stream.ReadToEnd());
            stream.Close();
            return products;
        }
        public bool SaveProductsList(List<Product> productsList)
        {
            if (!File.Exists(FilePathToProducts))
            {
                throw new Exception("File lưu trữ không tồn tại");
            }
            StreamWriter stream = new StreamWriter(FilePathToProducts);
            string jsonFile = JsonConvert.SerializeObject(productsList);
            stream.Write(jsonFile);
            stream.Close();
            return true;
        }
        public bool SaveProduct(Product product)
        {
            List<Product> productsList = ReadProducts();
            int maxID = 0;
            if (product.Id == 0)
            {
                if (productsList.Count > 0)
                {
                    foreach (var pd in productsList)
                    {
                        if (maxID < pd.Id) maxID = pd.Id;
                    }
                }
                product.Id = maxID + 1;
                productsList.Add(product);
            }
            else
            {
                var index = productsList.FindIndex(p => p.Id == product.Id);
                productsList[index] = product;
            }
            return SaveProductsList(productsList);
        }
        public bool DeleteProduct(int id)
        {
            List<Product> productsList = ReadProducts();
            int index = productsList.FindIndex(p => p.Id == id);
            productsList.RemoveAt(index);
            return SaveProductsList(productsList);
        }
    }
}
