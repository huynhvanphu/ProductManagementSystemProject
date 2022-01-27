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
    public class EditCommodityModel : PageModel
    {
        private CommodityService commodityService { set; get; }

        [BindProperty]
        public Commodity commodity { set; get; }

        public string message { get; set; }

        public EditCommodityModel()
        {
            commodityService = new CommodityService();
            message = string.Empty;
        }

        public void OnGet(int id)
        {
            try
            {
                commodity = commodityService.FindComById(id);

            } catch (Exception e)
            {
                message = e.Message;
            }
        }
        public void OnPost()
        {
            try
            {
                commodityService.SaveCommodity(commodity);
                Response.Redirect("Commodity");
            }
            catch (Exception e)
            {
                message = e.Message;
            }
        }
    }
}
