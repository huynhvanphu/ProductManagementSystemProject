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
    public class SalesReceiptDetailsModel : PageModel
    {
        private SalesReceiptService salesReceiptService { set; get; }

        private ProductService productService { set; get; }

        public Receipt salesReceipt { set; get; }

        public List<Product> products { set; get; }

        public SalesReceiptDetailsModel()
        {
            salesReceiptService = new SalesReceiptService();

            productService = new ProductService();
        }

        public void OnGet(int id)
        {
            salesReceipt = salesReceiptService.FindReceiptById(id);

            products = productService.ReadProducts();
        }
    }
}
