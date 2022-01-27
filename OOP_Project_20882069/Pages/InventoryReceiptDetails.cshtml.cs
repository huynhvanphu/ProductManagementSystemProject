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
    public class InventoryReceiptDetailsModel : PageModel
    {
        private InventoryReceiptService inventoryReceiptService { set; get; }

        private ProductService productService { set; get; }
            
        public Receipt inventoryReceipt { set; get; }

        public List<Product> products { set; get; }

        public string message { set; get; }

        public InventoryReceiptDetailsModel()
        {
            inventoryReceiptService = new InventoryReceiptService();

            productService = new ProductService();

            message = string.Empty;
        }

        public void OnGet(int id)
        {
            try
            {
                inventoryReceipt = inventoryReceiptService.FindReceiptById(id);

                products = productService.ReadProducts();
            } catch (Exception e)
            {
                message = e.Message;
            }
        }
    }
}
