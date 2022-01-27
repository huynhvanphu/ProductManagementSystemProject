using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Entities;
using BusinessServices;

namespace OOP_Project_20882069.Pages
{
    public class InventoryReceiptModel : PageModel
    {
        private InventoryReceiptService inventoryReceiptService { set; get; }

        private ProductService productService { set; get; }

        public List<Receipt> inventoryReceipts { set; get; }

        public Receipt inventoryReceipt { set; get; }

        public List<Product> products { set; get; }

        public string message { set; get; }

        public InventoryReceiptModel()
        {
            inventoryReceiptService = new InventoryReceiptService();
            productService = new ProductService();
            inventoryReceipts = new List<Receipt>();
            message = string.Empty;
        }

        public void OnGet()
        {
            productService.QuantityUpdate();

            inventoryReceipts = inventoryReceiptService.ReadReceipts();

            products = productService.ReadProducts();

        }
        public void OnPostSearch(string searchKey)
        {
            if (searchKey == null)
            {
                inventoryReceipts = inventoryReceiptService.ReadReceipts();
            }
            else
            {
                if (int.TryParse(searchKey, out int id))
                {
                    inventoryReceipt = inventoryReceiptService.FindReceiptById(id);
                    inventoryReceipts.Add(inventoryReceipt);
                }
            }
        }
        public void OnPostSortDate(DateTime fromDate, DateTime toDate)
        {
            inventoryReceipts = inventoryReceiptService.SortDate(fromDate, toDate);
        }
    }
}
