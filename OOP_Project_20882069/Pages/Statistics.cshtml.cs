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
    public class StatisticsModel : PageModel
    {
        private ProductService productService { set; get; }

        public List<Product> products { set; get; }

        public StatisticsModel()
        {
            productService = new ProductService();
        }

        public void OnGet()
        {
            productService.QuantityUpdate();

            products = productService.ReadProducts();
        }
    }
}
