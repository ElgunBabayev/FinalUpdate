#pragma checksum "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce6b32ef611d2e334835450a0eab8f67c923101d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
namespace AspNetCore
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
#line 1 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\_ViewImports.cshtml"
using actiuon;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\_ViewImports.cshtml"
using actiuon.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\_ViewImports.cshtml"
using actiuon.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce6b32ef611d2e334835450a0eab8f67c923101d", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db14fd8ffa430d8fa6b85ac7fa1384d73999f3b4", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductCategoryViewModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<header>\r\n    <div class=\"describe\">\r\n        <h3>Live Auction</h3>\r\n        <ul class=\"breadcrumb\">\r\n            <li><a");
            BeginWriteAttribute("href", " href=\'", 153, "\'", 188, 1);
#nullable restore
#line 6 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\Product\Index.cshtml"
WriteAttributeValue("", 160, Url.Action("Index", "Home"), 160, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Home</a></li>
            <li>Auctions</li>
        </ul>
    </div>
</header>
<section id=""view"">
    <div class=""container"">
        <div class=""myBtnContainer col-3"">
            <div class=""dropdown"">
                <div class=""select"">
                    <span>Category</span>
                </div>
                <input type=""hidden"" />
                <ul class=""dropdown-menu"">
                    <a href=""/Products"">
                    <li id=""all"" data-cat-source=""all"">All</li></a>
");
#nullable restore
#line 22 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\Product\Index.cshtml"
                     foreach (Category item in Model.Categories)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=\"", 820, "\"", 854, 3);
            WriteAttributeValue("", 827, "/Category/", 827, 10, true);
#nullable restore
#line 24 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\Product\Index.cshtml"
WriteAttributeValue("", 837, item.Id, 837, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 845, "/Products", 845, 9, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <li");
            BeginWriteAttribute("id", " id=\"", 885, "\"", 898, 1);
#nullable restore
#line 25 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\Product\Index.cshtml"
WriteAttributeValue("", 890, item.Id, 890, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-cat-source=\"");
#nullable restore
#line 25 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\Product\Index.cshtml"
                                                      Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                            ");
#nullable restore
#line 26 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\Product\Index.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </li>\r\n                        </a>\r\n");
#nullable restore
#line 29 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\Product\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 37 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\Product\Index.cshtml"
                 foreach (Product item in Model.Products.Where(x => x.StatusId == 2))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"portfolio-block col-4\" id=\"watch\">\r\n                        <div class=\"auc-item mb-4\">\r\n                            <div class=\"auc-img\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 1506, "\"", 1528, 2);
            WriteAttributeValue("", 1512, "/img/", 1512, 5, true);
#nullable restore
#line 42 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\Product\Index.cshtml"
WriteAttributeValue("", 1517, item.Image, 1517, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                     style=\"width: 100%\" />\r\n                                <div class=\"cooldown\">\r\n                                    <ul data-countdown=\"");
#nullable restore
#line 45 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\Product\Index.cshtml"
                                                   Write(item.EndDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                                        <li data-days=""00"">00</li>
                                        <li data-hours=""00"">00</li>
                                        <li data-minuts=""00"">00</li>
                                        <li data-seconds=""00"">00</li>
                                    </ul>
                                </div>
                                <div class=""author-area"">
                                    <div class=""author-emo"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ce6b32ef611d2e334835450a0eab8f67c923101d8464", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2253, "~/img/", 2253, 6, true);
#nullable restore
#line 54 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\Product\Index.cshtml"
AddHtmlAttributeValue("", 2259, item.AppUser.ProfilePhoto, 2259, 26, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"author-name\">\r\n                                        <span>by ");
#nullable restore
#line 57 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\Product\Index.cshtml"
                                            Write(item.AppUser);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"auc-text\">\r\n                                <h4>");
#nullable restore
#line 62 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\Product\Index.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                <p class=\"price\">Bidding Price : <span>$");
#nullable restore
#line 63 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\Product\Index.cshtml"
                                                                   Write(item.Prise);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                                <p class=\"bid\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 2877, "\"", 2901, 2);
            WriteAttributeValue("", 2884, "/Product/", 2884, 9, true);
#nullable restore
#line 65 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\Product\Index.cshtml"
WriteAttributeValue("", 2893, item.Id, 2893, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Place A Bid</a>\r\n                                </p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 70 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\Product\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductCategoryViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
