#pragma checksum "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/EditProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a680086dfb4eb7af9f5b74ca6bf66921f23f24a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OOP_Project_20882069.Pages.Pages_EditProduct), @"mvc.1.0.razor-page", @"/Pages/EditProduct.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a680086dfb4eb7af9f5b74ca6bf66921f23f24a1", @"/Pages/EditProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01f177720139a5b4b0ddaef06f6339f87ec79b00", @"/Pages/_ViewImports.cshtml")]
    public class Pages_EditProduct : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/EditProduct.cshtml"
  
    ViewData["Title"] = "Sửa sản phẩm";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/EditProduct.cshtml"
 if (Model.product != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1 class=\"hightlight text-center\">Sửa sản phẩm</h1>\n    <div class=\"container\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a680086dfb4eb7af9f5b74ca6bf66921f23f24a15448", async() => {
                WriteLiteral("\n            <div class=\"form-group\">\n                <label for=\"productName\">Tên sản phẩm:</label>\n                <input type=\"text\" class=\"form-control\" id=\"productName\"");
                BeginWriteAttribute("value", " value=\"", 442, "\"", 469, 1);
#nullable restore
#line 13 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/EditProduct.cshtml"
WriteAttributeValue("", 450, Model.product.Name, 450, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Name\" placeholder=\"Nhập tên sản phẩm\" required>\n            </div>\n            <div class=\"form-group\">\n                <label for=\"expiryDate\">Hạn sử dụng:</label>\n                <input type=\"date\" class=\"form-control\" id=\"expiryDate\"");
                BeginWriteAttribute("value", " value=\"", 713, "\"", 769, 1);
#nullable restore
#line 17 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/EditProduct.cshtml"
WriteAttributeValue("", 721, Model.product.ExpiryDate.ToString("yyyy-MM-dd"), 721, 48, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"ExpiryDate\" required>\n            </div>\n            <div class=\"form-group\">\n                <label for=\"manufacturer\">Công ty sản xuất:</label>\n                <input type=\"text\" class=\"form-control\" id=\"manufacturer\"");
                BeginWriteAttribute("value", " value=\"", 996, "\"", 1042, 1);
#nullable restore
#line 21 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/EditProduct.cshtml"
WriteAttributeValue("", 1004, Model.product.Manufacturer.ToString(), 1004, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""Manufacturer"" placeholder=""Nhập công ty sản xuất"" required>
            </div>
            <div class=""form-group"">
                <label for=""yearOfProduction"">Năm sản xuất:</label>
                <input type=""text"" class=""form-control"" id=""yearOfProduction""");
                BeginWriteAttribute("value", " value=\"", 1311, "\"", 1350, 1);
#nullable restore
#line 25 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/EditProduct.cshtml"
WriteAttributeValue("", 1319, Model.product.YearOfProduction, 1319, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""YearOfProduction"" placeholder=""Nhập năm sản xuất"" required>
            </div>
            <div class=""form-group"">
                <div class=""form-outline"">
                    <label for=""commodity"">Loại hàng:</label>
                    <select class=""form-control"" id=""commodity"" name=""commodity"">
");
#nullable restore
#line 31 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/EditProduct.cshtml"
                         foreach (var comm in Model.commodities)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a680086dfb4eb7af9f5b74ca6bf66921f23f24a18914", async() => {
#nullable restore
#line 33 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/EditProduct.cshtml"
                                                            Write(comm.ComName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/EditProduct.cshtml"
                               WriteLiteral(comm.ComId);

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
#line 34 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/EditProduct.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </select>
                </div>
            </div>
            <div class=""form-group"">
                <div class=""col-sm-offset-2 col-sm-10"">
                    <button type=""submit"" class=""btn btn-primary mr-1"">Lưu thông tin</button>
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a680086dfb4eb7af9f5b74ca6bf66921f23f24a111629", async() => {
                    WriteLiteral("Huỷ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                </div>\n            </div>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n");
#nullable restore
#line 46 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/EditProduct.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/EditProduct.cshtml"
 if (!string.IsNullOrEmpty(Model.message))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning\">\n        ");
#nullable restore
#line 50 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/EditProduct.cshtml"
   Write(Model.message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n");
#nullable restore
#line 52 "/Volumes/Felix Huynh/Đồ án LT HĐT/20882069/OOP_Project_20882069/Pages/EditProduct.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OOP_Project_20882069.Pages.EditProductModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OOP_Project_20882069.Pages.EditProductModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OOP_Project_20882069.Pages.EditProductModel>)PageContext?.ViewData;
        public OOP_Project_20882069.Pages.EditProductModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591