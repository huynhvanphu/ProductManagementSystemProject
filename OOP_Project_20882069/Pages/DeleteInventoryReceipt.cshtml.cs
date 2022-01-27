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
    public class DeleteInventoryReceiptModel : PageModel
    {
        private InventoryReceiptService inventoryReceiptService { set; get; }

        [BindProperty]
        public Receipt inventoryReceipt { set; get; }

        public DeleteInventoryReceiptModel()
        {
            inventoryReceiptService = new InventoryReceiptService();
        }

        public void OnGet(int id)
        {
            inventoryReceipt = inventoryReceiptService.FindReceiptById(id);
        }
        public void OnPost()
        {
            inventoryReceiptService.DeleteReceipts(inventoryReceipt.Id);

            Response.Redirect("InventoryReceipt");
        }
    }
}
