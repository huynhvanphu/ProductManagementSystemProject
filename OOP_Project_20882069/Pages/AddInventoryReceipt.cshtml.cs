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
    public class AddInventoryReceiptModel : PageModel
    {
        private ProductService productService { set; get; }

        private InventoryReceiptService inventoryReceiptService { set; get; }

        [BindProperty]
        public List<Product> products { set; get; }

        [BindProperty]
        public int inventoryReceiptId { set; get; }

        public Receipt inventoryReceipt { set; get; }

        public List<Receipt> inventoryReceiptsList { set; get; }

        public ReceiptDetails inventoryInfo { set; get; }

        public string message { set; get; }

        public AddInventoryReceiptModel()
        {
            message = string.Empty;
            productService = new ProductService();
            inventoryReceiptService = new InventoryReceiptService();
        }

        public void OnGet(int? id)
        {
            products = productService.ReadProducts();

            if (id == null)
            {
                inventoryReceiptId = inventoryReceiptService.GenerateID();
            }
            else
            {
                inventoryReceiptId = (int)id;

                try
                {
                    inventoryReceipt = inventoryReceiptService.FindReceiptById(inventoryReceiptId);
                } catch (Exception e)
                {
                    message = e.Message;
                }
            }
        }
        public void OnpostAddProduct(int id, int productId, int quantity)
        {
            try
            {
                inventoryReceipt = inventoryReceiptService.FindReceiptById(id);

            } catch (Exception e)
            {
                message = e.Message;
            }

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
                Response.Redirect($"AddInventoryReceipt?id={id}");
            }
            catch (Exception e)
            {
                message = e.Message;
            }
        }
        public void OnPost()
        {
            inventoryReceiptService.DeleteReceipts(inventoryReceiptId);
            Response.Redirect("/InventoryReceipt");
        }
    }
}
