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
    public class EditSalesReceiptModel : PageModel
    {
        private ProductService productService { set; get; }

        private SalesReceiptService salesReceiptService { set; get; }

        public Receipt salesReceipt { set; get; }

        [BindProperty]
        public int salesReceiptId { set; get; }

        [BindProperty]
        public List<Product> products { set; get; }

        public Product product { set; get; }

        public ReceiptDetails inventoryInfo { set; get; }
        [TempData]
        public string message { set; get; }

        public EditSalesReceiptModel()
        {
            productService = new ProductService();

            salesReceiptService = new SalesReceiptService();

            message = string.Empty;
        }

        public void OnGet(int id)
        {
            try
            {
                products = productService.ReadProducts();
                salesReceipt = salesReceiptService.FindReceiptById(id);
            } catch (Exception e)
            {
                message = e.Message;
            }
        }

        public void OnPostAddProduct(int id, int productId, int quantity)
        {
            salesReceipt = salesReceiptService.FindReceiptById(id);

            product = productService.FindProduct(productId);

            if (product.Quantity < quantity)
            {
                message = $"Số lượng bán không được vượt quá số lượng tồn. {product.Name} - Tồn : {product.Quantity}";
            }
            else
            {
                inventoryInfo = new ReceiptDetails();
                inventoryInfo.ProductId = productId;
                inventoryInfo.Quantity = quantity;

                if (salesReceipt == null)
                {
                    salesReceipt = new Receipt();
                    salesReceipt.Id = id;
                    salesReceipt.CreatedDate = DateTime.Now;
                    salesReceipt.receiptDetailsList = new List<ReceiptDetails>();
                    salesReceipt.receiptDetailsList.Add(inventoryInfo);
                }
                else
                {
                    int index = -1;
                    index = salesReceipt.receiptDetailsList.FindIndex(inv => inv.ProductId == inventoryInfo.ProductId);
                    if (index != -1)
                    {
                        salesReceipt.receiptDetailsList[index] = inventoryInfo;
                    }
                    else
                    {
                        salesReceipt.receiptDetailsList.Add(inventoryInfo);
                    }
                }

                try
                {
                    salesReceiptService.SaveReceipt(salesReceipt);

                }
                catch (Exception e)
                {
                    message = e.Message;
                }
            }

            Response.Redirect($"EditSalesReceipt?id={id}");
        }
        public void OnPost()
        {
            Response.Redirect("/SalesReceipt");
        }
        public void OnPostDeleteProduct(int productId, int invId)
        {
            salesReceipt = salesReceiptService.FindReceiptById(invId);

            int index = salesReceipt.receiptDetailsList.FindIndex(i => i.ProductId == productId);

            salesReceipt.receiptDetailsList.RemoveAt(index);

            salesReceiptService.SaveReceipt(salesReceipt);

            Response.Redirect($"EditSalesReceipt?id={invId}");
        }
    }
}
