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
    public class AddProductModel : PageModel
    {
        public AddProductModel()
        {
            productService = new ProductService();
            commodityService = new CommodityService();
        }
        [BindProperty]
        public Product product { set; get; }

        [BindProperty]
        public List<Commodity> commodities { set; get; }

        public string message { set; get; }

        private ProductService productService { set; get; }

        private CommodityService commodityService { set; get; }

        public void OnGet()
        {
            message = "";
            commodities = commodityService.ReadCommodity();
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
