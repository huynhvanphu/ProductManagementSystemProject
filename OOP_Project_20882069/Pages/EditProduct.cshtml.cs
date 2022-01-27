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
    public class EditProductModel : PageModel
    {
        private ProductService productService { set; get; }

        private CommodityService commodityService { set; get; }

        public EditProductModel()
        {
            productService = new ProductService();
            commodityService = new CommodityService();
            message = string.Empty;
        }
        [BindProperty]
        public Product product { set; get; }

        [BindProperty]
        public List<Commodity> commodities { get; set; }

        public string message { set; get; }

        public void OnGet(int id)
        {
            try
            {
                product = productService.FindProduct(id);
                commodities = commodityService.ReadCommodity();
            } catch (Exception e)
            {
                message = e.Message;
            }
        }
        public void OnPost()
        {
            try
            {
                productService.SaveProducts(product);
                Response.Redirect("Index");
            }
            catch (Exception e)
            {
                message = e.Message;
            }
        }
    }
}
