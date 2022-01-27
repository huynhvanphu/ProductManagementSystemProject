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
    public class SalesReceiptModel : PageModel
    {
        private ProductService productService { set; get; }

        private SalesReceiptService salesReceiptService { set; get; }

        public List<Receipt> salesReceipts { set; get; }

        public Receipt salesReceipt { set; get; }

        public List<Product> products { set; get; }

        public SalesReceiptModel()
        {
            productService = new ProductService();

            salesReceiptService = new SalesReceiptService();
        }

        public void OnGet()
        {
            productService.QuantityUpdate();

            salesReceipts = salesReceiptService.ReadReceipts();

            products = productService.ReadProducts();
        }
        public void OnPostSearch(string searchKey)
        {
            if (searchKey == null)
            {
                salesReceipts = salesReceiptService.ReadReceipts();
            }
            else
            {
                if (int.TryParse(searchKey, out int id))
                {
                    salesReceipt = salesReceiptService.FindReceiptById(id);

                    salesReceipts = new List<Receipt>();

                    salesReceipts.Add(salesReceipt);
                }
                else
                {
                    salesReceipts = new List<Receipt>();
                }
            }
        }
        public void OnPostSortDate(DateTime fromDate, DateTime toDate)
        {
            salesReceipts = salesReceiptService.SortDate(fromDate, toDate);
        }
    }
}
