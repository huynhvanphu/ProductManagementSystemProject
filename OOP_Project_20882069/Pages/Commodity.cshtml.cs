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
    public class CommodityModel : PageModel
    {
        private CommodityService commodityService { set; get; }

        [BindProperty]
        public List<Commodity> commodities { set; get; }

        [BindProperty]
        public Commodity commodity { set; get; }

        [TempData]
        public string message { set; get; }

        public CommodityModel()
        {
            commodityService = new CommodityService();
            message = string.Empty;
        }

        public void OnGet()
        {
            commodities = commodityService.ReadCommodity();
        }
        public void OnPost()
        {
            try
            {
                commodityService.SaveCommodity(commodity);
                message = "Đã thêm thành công!!!";
                Response.Redirect("./Commodity");

            }
            catch (Exception e)
            {
                message = "Thêm thất bại. Lỗi: " + e.Message;
            }
        }
        public void OnPostSearch(string searchKey, string searchAttribute)
        {
            if (searchKey == null) searchKey = "";

            switch (searchAttribute)
            {
                case "ComId":
                    bool success = int.TryParse(searchKey, out int id);
                    if (success)
                    {
                        List<Commodity> comList = new List<Commodity>();

                        commodity = commodityService.FindComById(id);
                        comList.Add(commodity);
                        commodities = comList;
                    }
                    break;
                default:
                    commodities = commodityService.FindComByName(searchKey);
                    break;
            }
        }
    }
}
