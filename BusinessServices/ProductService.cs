using System;
using Entities;
using DAL;
using System.Collections.Generic;
using System.Linq;

namespace BusinessServices
{
    public class ProductService
    {
        private DAL_Product dalProduct { set; get; }
        private DAL_Commodity dalCommodity { set; get; }
        private InventoryReceiptService inventoryReceiptService { set; get; }
        private SalesReceiptService salesReceiptService { set; get; }

        public ProductService()
        {
            dalProduct = new DAL_Product();
            dalCommodity = new DAL_Commodity();
            inventoryReceiptService = new InventoryReceiptService();
            salesReceiptService = new SalesReceiptService();
        }
        public List<Product> ReadProducts() => dalProduct.ReadProducts();

        public void SaveProducts(Product product)
        {
            if (product.ExpiryDate < DateTime.Now)
            {
                throw new Exception("Hạn sử dụng không được nhỏ hơn thời gian hiện tại");
            }
            if (product.YearOfProduction == 0)
            {
                throw new Exception("Nhập sai hạn sử dụng");
            }
            if (product.YearOfProduction > DateTime.Now.Year)
            {
                throw new Exception("Năm sản xuất không được lớn hơn năm hiện tại");
            }
            dalProduct.SaveProduct(product);
        }

        public Product FindProduct(int id)
        {
            List<Product> products = dalProduct.ReadProducts();
            Product product = products.Where(p => p.Id == id).FirstOrDefault();
            if (product == null)
            {
                throw new Exception("Không tìm thấy sản phẩm");
            }
            return product;
        }

        public void DeleteProduct(int id) => dalProduct.DeleteProduct(id);

        public List<Product> FindByName(string key)
        {
            List<Product> products = dalProduct.ReadProducts();
            var query = (from p in products where p.Name.Contains(key) select p).ToList();
            if (query.Count == 0)
            {
                throw new Exception("Không tìm thấy sản phẩm");
            }
            return query;
        }

        public List<Product> FindByManufacturer(string key)
        {
            List<Product> products = dalProduct.ReadProducts();
            var query = (from p in products where p.Manufacturer.Contains(key) select p).ToList();
            if (query.Count == 0)
            {
                throw new Exception("Không tìm thấy sản phẩm");
            }
            return query;
        }

        public List<Product> FindByYearOfProduction(string key)
        {
            bool success = int.TryParse(key, out int year);
            if (success)
            {
                List<Product> products = dalProduct.ReadProducts();
                var query = (from p in products where p.YearOfProduction == year select p).ToList();
                if (query.Count == 0)
                {
                    throw new Exception("Không tìm thấy sản phẩm");
                }
                return query;
            }
            else
            {
                throw new Exception("Thông tin nhập vào không hợp lệ");
            }
        }

        public List<Product> FindByCommodity(string key)
        {
            List<Product> products = dalProduct.ReadProducts();
            List<Commodity> commodities = dalCommodity.ReadCommodity();
            var comid = (from com in commodities where com.ComName.Contains(key) select com.ComId).FirstOrDefault();
            var query = (from p in products where p.Id == comid select p).ToList();
            if (query.Count == 0)
            {
                throw new Exception("Không tìm thấy sản phẩm");
            }
            return query;
        }

        public int totalQuantity(int id, List<Receipt> inventoryReceipts, List<Receipt> salesReceipts)
        {
            int total = 0;

            foreach (var inv in inventoryReceipts)
            {
                foreach (var inf in inv.receiptDetailsList)
                {
                    if (inf.ProductId == id)
                    {
                        total += inf.Quantity;
                    }
                }
            }
            foreach (var sr in salesReceipts)
            {
                foreach (var srf in sr.receiptDetailsList)
                {
                    if (srf.ProductId == id)
                    {
                        total -= srf.Quantity;
                    }
                }
            }

            return total;
        }

        public void QuantityUpdate()
        {
            List<Receipt> inventoryReceipts = inventoryReceiptService.ReadReceipts();

            //return inventoryReceipts.Count;

            List<Receipt> salesReceipts = salesReceiptService.ReadReceipts();

            List<Product> products = dalProduct.ReadProducts();

            foreach (var p in products)
            {
                p.Quantity = totalQuantity(p.Id, inventoryReceipts, salesReceipts);
            }

            dalProduct.SaveProductsList(products);
        }
    }
}
