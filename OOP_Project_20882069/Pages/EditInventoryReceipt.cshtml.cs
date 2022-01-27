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
    public class EditInventoryReceiptModel : PageModel
    {
        private InventoryReceiptService inventoryReceiptService { set; get; }

        private ProductService productService { set; get; }

        public Receipt inventoryReceipt { set; get; }

        [BindProperty]
        public List<Product> products { set; get; }

        public ReceiptDetails inventoryInfo { set; get; }

        public string message { set; get; }

        public EditInventoryReceiptModel()
        {
            inventoryReceiptService = new InventoryReceiptService();

            productService = new ProductService();
        }

        public void OnGet(int id)
        {
            try
            {
                inventoryReceipt = inventoryReceiptService.FindReceiptById(id);
            } catch (Exception e)
            {
                message = e.Message;
            }
            
            products = productService.ReadProducts();
        }
        public void OnPostAddProduct(int id, int productId, int quantity)
        {
            inventoryReceipt = inventoryReceiptService.FindReceiptById(id);

            inventoryInfo = new ReceiptDetails();
            inventoryInfo.ProductId = productId;
            inventoryInfo.Quantity = quantity;

            if (inventoryReceipt == null)
            {
                inventoryReceipt = new Receipt();
                inventoryReceipt.Id = id;
                inventoryReceipt.CreatedDate = DateTime.Now;
                inventoryReceipt.receiptDetailsList = new List<ReceiptDetails>();
                inventoryReceipt.receiptDetailsList.Add(inventoryInfo);
            }
            else
            {
                int index = -1;
                index = inventoryReceipt.receiptDetailsList.FindIndex(inv => inv.ProductId == inventoryInfo.ProductId);
                if (index != -1)
                {
                    inventoryReceipt.receiptDetailsList[index] = inventoryInfo;
                }
                else
                {
                    inventoryReceipt.receiptDetailsList.Add(inventoryInfo);
                }
            }

            try
            {
                inventoryReceiptService.SaveReceipt(inventoryReceipt);
                Response.Redirect($"EditInventoryReceipt?id={id}");
            }
            catch (Exception e)
            {
                message = e.Message;
            }
        }
        public void OnPost()
        {
            //InventoryReceiptService.DeleteInventoryReceipts(inventoryReceiptId);
            Response.Redirect("/InventoryReceipt");
        }
        public void OnPostDeleteProduct(int productId, int invId)
        {
            inventoryReceipt = inventoryReceiptService.FindReceiptById(invId);

            int index = inventoryReceipt.receiptDetailsList.FindIndex(i => i.ProductId == productId);

            inventoryReceipt.receiptDetailsList.RemoveAt(index);

            inventoryReceiptService.SaveReceipt(inventoryReceipt);

            Response.Redirect($"EditInventoryReceipt?id={invId}&{index}");
        }
    }
}
