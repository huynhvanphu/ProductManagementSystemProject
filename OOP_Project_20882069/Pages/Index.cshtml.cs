using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Entities;
using BusinessServices;

namespace OOP_Project_20882069.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            productService = new ProductService();
            commodityService = new CommodityService();
        }
        public List<Product> products { set; get; }

        [BindProperty]
        public int comCount { set; get; }

        [BindProperty]
        public List<Commodity> commodities { set; get; }

        public string message { set; get; }

        private ProductService productService { set; get; }

        private CommodityService commodityService { set; get; }

        public void OnGet()
        {
            products = productService.ReadProducts();
            commodities = commodityService.ReadCommodity();
            comCount = commodities.Count;
            message = string.Empty;
        }
        public void OnPost(string searchKey, string searchAttribute)
        {
            if (searchKey == null) searchKey = string.Empty;
            commodities = commodityService.ReadCommodity();
            switch (searchAttribute)
            {
                case "Manufacturer":
                    products = productService.FindByManufacturer(searchKey);
                    break;
                case "YearOfProduction":
                    try
                    {
                        products = productService.FindByYearOfProduction(searchKey);
                    }
                    catch (Exception e)
                    {
                        message = e.Message;
                    }
                    break;
                case "Commodity":
                    products = productService.FindByCommodity(searchKey);
                    break;
                default:
                    products = productService.FindByName(searchKey);
                    break;
            }
        }
    }
}
