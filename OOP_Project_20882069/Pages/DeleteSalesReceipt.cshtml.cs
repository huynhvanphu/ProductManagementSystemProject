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
    public class DeleteSalesReceiptModel : PageModel
    {
        private SalesReceiptService salesReceiptService { set; get; }

        [BindProperty]
        public Receipt salesReceipt { set; get; }

        public string message { set; get; }

        public DeleteSalesReceiptModel()
        {
            salesReceiptService = new SalesReceiptService();
        }

        public void OnGet(int id)
        {
            try
            {
                salesReceipt = salesReceiptService.FindReceiptById(id);

            } catch (Exception e)
            {
                message = e.Message;
            }
        }
        public void OnPost()
        {
            salesReceiptService.DeleteReceipts(salesReceipt.Id);

            Response.Redirect("SalesReceipt");
        }
    }
}
