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
    public class DeleteProductModel : PageModel
    {
        private ProductService productService { set; get; }
        private CommodityService commodityService { set; get; }

        public DeleteProductModel()
        {
            productService = new ProductService();
            commodityService = new CommodityService();
        }
        [BindProperty]
        public Product product { set; get; }

        [BindProperty]
        public Commodity commodity { set; get; }

        public string message { set; get; }

        public void OnGet(int id)
        {
            try
            {
                product = productService.FindProduct(id);
                commodity = commodityService.FindComById(product.Commodity);
            } catch (Exception e)
            {
                message = e.Message;
            }
        }
        public void OnPost()
        {
            try
            {
                productService.DeleteProduct(product.Id);
            }
            catch (Exception e)
            {
                message = e.Message;
            }
            Response.Redirect("Index");
        }
    }
}
