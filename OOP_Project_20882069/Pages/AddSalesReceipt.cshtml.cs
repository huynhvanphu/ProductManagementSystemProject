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
    public class AddSalesReceiptModel : PageModel
    {
        private ProductService productService { set; get; }

        private SalesReceiptService salesReceiptService { set; get; }

        private InventoryReceiptService inventoryReceiptService { set; get; }

        public string message { set; get; }

        [BindProperty]
        public List<Product> products { set; get; }

        public Product product { set; get; }

        [BindProperty]
        public int salesReceiptId { set; get; }

        public Receipt salesReceipt { set; get; }

        public List<Receipt> salesReceiptsList { set; get; }

        public ReceiptDetails inventoryInfo { set; get; }

        public AddSalesReceiptModel()
        {
            productService = new ProductService();

            salesReceiptService = new SalesReceiptService();

            inventoryReceiptService = new InventoryReceiptService();

            message = string.Empty;
        }

        public void OnGet(int? id)
        {
            products = productService.ReadProducts();

            if (id == null)
            {
                salesReceiptId = salesReceiptService.GenerateID();
            }
            else
            {
                salesReceiptId = (int)id;

                salesReceipt = salesReceiptService.FindReceiptById(salesReceiptId);
            }
        }
        public void OnpostAddProduct(int id, int productId, int quantity)
        {
            product = productService.FindProduct(productId);

            if (product.Quantity < quantity)
            {
                message = $"Số lượng bán không được vượt quá số lượng tồn. {product.Name} - Tồn : {product.Quantity}";

            }
            else
            {
               try
                {
                    salesReceipt = salesReceiptService.FindReceiptById(id);

                } catch (Exception e)
                {
                    message = e.Message;
                }
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
            Response.Redirect($"AddSalesReceipt?id={id}");
        }
        public void OnPost()
        {
            inventoryReceiptService.DeleteReceipts(salesReceiptId);

            Response.Redirect("/SalesReceipt");
        }
    }
}
