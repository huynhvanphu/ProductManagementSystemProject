#pragma checksum "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/Statistics.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80f9ed743d63b76ee68842e5a28de0271159b350"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OOP_Project_20882069.Pages.Pages_Statistics), @"mvc.1.0.razor-page", @"/Pages/Statistics.cshtml")]
namespace OOP_Project_20882069.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/_ViewImports.cshtml"
using OOP_Project_20882069;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80f9ed743d63b76ee68842e5a28de0271159b350", @"/Pages/Statistics.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01f177720139a5b4b0ddaef06f6339f87ec79b00", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Statistics : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/Statistics.cshtml"
  
    ViewData["Title"] = "Thống kê";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container mt-3"">
    <div class=""row"">
        <div class=""col-md-6 text-center"">
            <h3 class=""bg-warning"">Danh sách hàng tồn</h3>
            <table style=""width: 100%"" class=""table table-bordered table-hover"">
                <tr>
                    <th>STT</th>
                    <th>Mã sản phẩm</th>
                    <th>Tên sản phẩm</th>
                    <th>Số lượng tồn</th>
                </tr>
");
#nullable restore
#line 17 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/Statistics.cshtml"
                  
                    int i = 1;
                    foreach (var p in Model.products)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 22 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/Statistics.cshtml"
                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 23 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/Statistics.cshtml"
                           Write(p.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 24 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/Statistics.cshtml"
                           Write(p.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 25 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/Statistics.cshtml"
                           Write(p.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        </tr>\n");
#nullable restore
#line 27 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/Statistics.cshtml"
                        i++;
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </table>
        </div>
        <div class=""col-md-6 text-center"">
            <h3 class=""bg-success"">Danh sách hàng quá hạn</h3>
            <table style=""width: 100%"" class=""table table-bordered table-hover"">
                <tr>
                    <th>STT</th>
                    <th>Mã sản phẩm</th>
                    <th>Tên sản phẩm</th>
                    <th>Ngày hết hạn</th>
                    <th>Số lượng</th>
                </tr>
");
#nullable restore
#line 42 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/Statistics.cshtml"
                  
                    int j = 1;
                    foreach (var p in Model.products)
                    {
                        if (p.ExpiryDate < DateTime.Now && p.Quantity > 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\n                                <td>");
#nullable restore
#line 49 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/Statistics.cshtml"
                               Write(j);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 50 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/Statistics.cshtml"
                               Write(p.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 51 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/Statistics.cshtml"
                               Write(p.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 52 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/Statistics.cshtml"
                               Write(p.ExpiryDate.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 53 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/Statistics.cshtml"
                               Write(p.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            </tr>\n");
#nullable restore
#line 55 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/Statistics.cshtml"
                            j++;
                        }
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\n        </div>\n    </div>\n</div>\n\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OOP_Project_20882069.Pages.StatisticsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OOP_Project_20882069.Pages.StatisticsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OOP_Project_20882069.Pages.StatisticsModel>)PageContext?.ViewData;
        public OOP_Project_20882069.Pages.StatisticsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
