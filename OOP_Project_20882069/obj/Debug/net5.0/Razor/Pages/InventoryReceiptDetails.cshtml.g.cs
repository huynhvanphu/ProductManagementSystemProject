#pragma checksum "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/InventoryReceiptDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ee6582cebc1f2e932c397ef14c5c83ee2d13059"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OOP_Project_20882069.Pages.Pages_InventoryReceiptDetails), @"mvc.1.0.razor-page", @"/Pages/InventoryReceiptDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ee6582cebc1f2e932c397ef14c5c83ee2d13059", @"/Pages/InventoryReceiptDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01f177720139a5b4b0ddaef06f6339f87ec79b00", @"/Pages/_ViewImports.cshtml")]
    public class Pages_InventoryReceiptDetails : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "InventoryReceipt", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/InventoryReceiptDetails.cshtml"
  
    ViewData["Title"] = "Chi tiết hoá đơn";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/InventoryReceiptDetails.cshtml"
 if (Model.inventoryReceipt != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1 class=\"hightlight\">Chi tiết hoá đơn</h1>\n    <div class=\"row\" style=\"height:100%\">\n        <div class=\"col-sm-2\">\n            <p><strong>Mã hoá đơn</strong></p>\n        </div>\n        <div class=\"col-sm-10\">\n            <p>");
#nullable restore
#line 14 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/InventoryReceiptDetails.cshtml"
          Write(Model.inventoryReceipt.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        </div>\n\n        <div class=\"col-sm-2\">\n            <p><strong>Ngày tạo</strong></p>\n        </div>\n        <div class=\"col-sm-10\">\n            <p>");
#nullable restore
#line 21 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/InventoryReceiptDetails.cshtml"
          Write(Model.inventoryReceipt.CreatedDate.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
        </div>
        <div class=""col-sm-12""><h3>Chi tiết sản phẩm nhập</h3></div>
        <div class=""col-sm-12"">
            <table class=""table table-bordered"">
                <tr class=""bg-warning"">
                    <th>STT</th>
                    <th>Tên sản phẩm</th>
                    <th>Số lượng</th>
                </tr>
");
#nullable restore
#line 31 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/InventoryReceiptDetails.cshtml"
                  
                    int i = 1;
                    foreach (var inf in Model.inventoryReceipt.receiptDetailsList)
                    {
                        var productName = (from p in Model.products
                                           where p.Id == inf.ProductId
                                           select p.Name).FirstOrDefault();

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 39 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/InventoryReceiptDetails.cshtml"
                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 40 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/InventoryReceiptDetails.cshtml"
                           Write(productName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 41 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/InventoryReceiptDetails.cshtml"
                           Write(inf.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        </tr>\n");
#nullable restore
#line 43 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/InventoryReceiptDetails.cshtml"
                        i++;
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ee6582cebc1f2e932c397ef14c5c83ee2d130597191", async() => {
                WriteLiteral("Trở lại");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n    </div>\n");
#nullable restore
#line 50 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/InventoryReceiptDetails.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/InventoryReceiptDetails.cshtml"
 if (!string.IsNullOrEmpty(Model.message))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning\">\n        ");
#nullable restore
#line 54 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/InventoryReceiptDetails.cshtml"
   Write(Model.message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n");
#nullable restore
#line 56 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/InventoryReceiptDetails.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OOP_Project_20882069.Pages.InventoryReceiptDetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OOP_Project_20882069.Pages.InventoryReceiptDetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OOP_Project_20882069.Pages.InventoryReceiptDetailsModel>)PageContext?.ViewData;
        public OOP_Project_20882069.Pages.InventoryReceiptDetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
