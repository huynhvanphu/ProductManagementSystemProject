#pragma checksum "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/EditInventoryReceipt.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76dbcc7eff954339b23d2b478e01eb927ab77312"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OOP_Project_20882069.Pages.Pages_EditInventoryReceipt), @"mvc.1.0.razor-page", @"/Pages/EditInventoryReceipt.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76dbcc7eff954339b23d2b478e01eb927ab77312", @"/Pages/EditInventoryReceipt.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01f177720139a5b4b0ddaef06f6339f87ec79b00", @"/Pages/_ViewImports.cshtml")]
    public class Pages_EditInventoryReceipt : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "InventoryReceipt", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("addReceipt"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "DeleteProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "AddProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/EditInventoryReceipt.cshtml"
  
    ViewData["Title"] = "Sửa hoá đơn nhập hàng";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/EditInventoryReceipt.cshtml"
 if (Model.inventoryReceipt != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3 class=\"text-danger\">");
#nullable restore
#line 8 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/EditInventoryReceipt.cshtml"
                       Write(Model.message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n    <h1 class=\"text-center hightlight\">Sửa hoá đơn nhập hàng</h1>\n    <div class=\"container\">\n        <div class=\"row\" style=\"height:100%\">\n            <div class=\"col-sm-6 col-md-6\">\n                <h2></h2>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76dbcc7eff954339b23d2b478e01eb927ab773126592", async() => {
                WriteLiteral("\n                    <div class=\"form-group\">\n                        <label for=\"productName\">Mã hoá đơn:</label>\n                        <input type=\"text\" class=\"form-control\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 659, "\"", 693, 1);
#nullable restore
#line 17 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/EditInventoryReceipt.cshtml"
WriteAttributeValue("", 667, Model.inventoryReceipt.Id, 667, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly>\n                    </div>\n                    <div class=\"form-group\">\n                        <label for=\"expiryDate\">Ngày tạo:</label>\n                        <input type=\"date\" class=\"form-control\" name=\"CreatedDate\"");
                BeginWriteAttribute("value", " value=\"", 925, "\"", 991, 1);
#nullable restore
#line 21 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/EditInventoryReceipt.cshtml"
WriteAttributeValue("", 933, Model.inventoryReceipt.CreatedDate.ToString("yyyy-MM-dd"), 933, 58, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly>\n                    </div>\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76dbcc7eff954339b23d2b478e01eb927ab773128178", async() => {
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
                WriteLiteral("\n");
                WriteLiteral("                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n\n            <div class=\"col-sm-6 col-md-6\">\n                <a data-target=\"#addProduct\" data-toggle=\"modal\" class=\"btn btn-primary text-light mb-3\" style=\"cursor:pointer\">+ Thêm/sửa sản phẩm</a>\n");
#nullable restore
#line 30 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/EditInventoryReceipt.cshtml"
                 if (Model.inventoryReceipt != null)
                {
                    if (Model.inventoryReceipt.receiptDetailsList.Count > 0)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <h3 class=""text-white bg-success text-center"">Chi tiết hoá đơn</h3>
                        <table class=""table table-bordered table-hover table-stripped"">
                            <tr>
                                <th>STT</th>
                                <th>Tên sản phẩm</th>
                                <th>Số lượng</th>
                            </tr>
");
#nullable restore
#line 42 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/EditInventoryReceipt.cshtml"
                              
                                int i = 1;
                                foreach (var inv in Model.inventoryReceipt.receiptDetailsList)
                                {
                                    var productName = (from p in Model.products
                                                       where
                                                       p.Id == inv.ProductId
                                                       select p.Name).FirstOrDefault();

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\n                                        <td>");
#nullable restore
#line 51 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/EditInventoryReceipt.cshtml"
                                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td class=\"text-center\">");
#nullable restore
#line 52 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/EditInventoryReceipt.cshtml"
                                                           Write(productName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td>");
#nullable restore
#line 53 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/EditInventoryReceipt.cshtml"
                                       Write(inv.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td>\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76dbcc7eff954339b23d2b478e01eb927ab7731213587", async() => {
                WriteLiteral("\n                                                <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 2964, "\"", 2986, 1);
#nullable restore
#line 56 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/EditInventoryReceipt.cshtml"
WriteAttributeValue("", 2972, inv.ProductId, 2972, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"productId\" />\n                                                <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 3076, "\"", 3110, 1);
#nullable restore
#line 57 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/EditInventoryReceipt.cshtml"
WriteAttributeValue("", 3084, Model.inventoryReceipt.Id, 3084, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"invId\" />\n                                                <button type=\"submit\" class=\"btn btn-danger mr-1\">Xoá</button>\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                        </td>\n                                    </tr>\n");
#nullable restore
#line 62 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/EditInventoryReceipt.cshtml"
                                    i++;
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </table>\n");
#nullable restore
#line 66 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/EditInventoryReceipt.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n        </div>\n    </div>\n");
            WriteLiteral(@"    <div class=""modal fade"" id=""addProduct"" tabindex=""-1"" role=""dialog"" aria-labelledby=""addProduct"" aria-hidden=""true"">
        <div class=""modal-dialog modal-dialog-centered"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""addProduct"">Thêm chi tiết sản phẩm</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76dbcc7eff954339b23d2b478e01eb927ab7731217724", async() => {
                WriteLiteral("\n                    <div class=\"modal-body\">\n                        <div class=\"form-group\">\n                            <label for=\"commodity\">Chọn sản phẩm:</label>\n                            <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 4518, "\"", 4552, 1);
#nullable restore
#line 87 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/EditInventoryReceipt.cshtml"
WriteAttributeValue("", 4526, Model.inventoryReceipt.Id, 4526, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"id\" readonly />\n                            <select class=\"form-control\" id=\"productId\" name=\"productId\">\n");
#nullable restore
#line 89 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/EditInventoryReceipt.cshtml"
                                 foreach (var p in Model.products)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76dbcc7eff954339b23d2b478e01eb927ab7731219078", async() => {
#nullable restore
#line 91 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/EditInventoryReceipt.cshtml"
                                                              Write(p.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 91 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/EditInventoryReceipt.cshtml"
                                       WriteLiteral(p.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 92 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/EditInventoryReceipt.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </select>
                        </div>
                        <div class=""form-group"">
                            <label for=""productName"">Số lượng:</label>
                            <input type=""number"" min=""1"" class=""form-control"" name=""quantity"" required>
                        </div>
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Huỷ</button>
                        <button type=""submit"" class=""btn btn-primary"">Lưu thông tin</button>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n");
#nullable restore
#line 108 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/EditInventoryReceipt.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 109 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/EditInventoryReceipt.cshtml"
 if (!string.IsNullOrEmpty(Model.message))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning\">\n        ");
#nullable restore
#line 112 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/EditInventoryReceipt.cshtml"
   Write(Model.message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n");
#nullable restore
#line 114 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/EditInventoryReceipt.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OOP_Project_20882069.Pages.EditInventoryReceiptModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OOP_Project_20882069.Pages.EditInventoryReceiptModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OOP_Project_20882069.Pages.EditInventoryReceiptModel>)PageContext?.ViewData;
        public OOP_Project_20882069.Pages.EditInventoryReceiptModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591