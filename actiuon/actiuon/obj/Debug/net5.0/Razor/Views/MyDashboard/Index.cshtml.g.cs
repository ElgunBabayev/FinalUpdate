#pragma checksum "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\MyDashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3abc949078e9a4bb4339b2914818ca10d68f221"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MyDashboard_Index), @"mvc.1.0.view", @"/Views/MyDashboard/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3abc949078e9a4bb4339b2914818ca10d68f221", @"/Views/MyDashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db14fd8ffa430d8fa6b85ac7fa1384d73999f3b4", @"/Views/_ViewImports.cshtml")]
    public class Views_MyDashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyDashboardViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "MyProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("spec form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("ProdImg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("small text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<header>
    <div class=""describe"">
        <h3>Dashboard</h3>
        <ul class=""breadcrumb"">
            <li><a href=""../FinalProjectFull/index.html"">Home</a></li>
            <li>Dahsboard</li>
        </ul>
    </div>
</header>
<section id=""dashboard"">
    <div class=""container"">
        <div class=""row d-flex"">
            <div class=""side-btn col-3 d-flex flex-column gap-4"">
                <button class=""dashboard"" data-filter=""side-text-dashboard"">Dashboard</button>
                <button class=""dashboard"" data-filter=""side-text-profile"">My Profile</button>
                <button class=""dashboard"" data-filter=""side-text-my-product"">My Products</button>
                <button class=""dashboard"" data-filter=""side-text-picked"">Picked Products</button>
            </div>
            <div class=""side-text-dashboard group-wrapper d-flex col-9"">
                <div class=""col-6 mt-2"">
                    <div class=""sold d-flex flex-column"">
                        <div class=""sold-he");
            WriteLiteral("ader\"><h5>My Products</h5></div>\r\n                        <div class=\"sold-body\"><h4>");
#nullable restore
#line 24 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\MyDashboard\Index.cshtml"
                                              Write(Model.Products.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4></div>
                    </div>
                </div>
                <div class=""col-6 mt-2"">
                    <div class=""sold d-flex flex-column"">
                        <div class=""sold-header""><h5>Pending Product</h5></div>
                        <div class=""sold-body""><h4>");
#nullable restore
#line 30 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\MyDashboard\Index.cshtml"
                                              Write(Model.Products.Where(x => x.StatusId == 1).Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4></div>
                    </div>
                </div>
                <div class=""col-6 mt-2"">
                    <div class=""sold d-flex flex-column"">
                        <div class=""sold-header""><h5>Picked Product</h5></div>
                        <div class=""sold-body""><h4>");
#nullable restore
#line 36 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\MyDashboard\Index.cshtml"
                                              Write(Model.Bids.Where(x=>x.AppUserName==User.Identity.Name).Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4></div>
                    </div>
                </div>
                <div class=""col-6 mt-2"">
                    <div class=""sold d-flex flex-column"">
                        <div class=""sold-header""><h5>Purchase</h5></div>
                        <div class=""sold-body""><h4>0</h4></div>
                    </div>
                </div>
            </div>

            <div class=""side-text-profile group-wrapper col-9 d-none"">
                <div class=""row"">
                    <div class=""col-6"">
                        <div class=""personal-inf d-flex"">
                            <div class=""pers-img col-4"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a3abc949078e9a4bb4339b2914818ca10d68f2219721", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2554, "~/img/", 2554, 6, true);
#nullable restore
#line 52 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\MyDashboard\Index.cshtml"
AddHtmlAttributeValue("", 2560, Model.AppUser.ProfilePhoto, 2560, 27, false);

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
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"pers-inf d-flex col-8\">\r\n                                <div class=\"pers-name d-flex\">\r\n                                    <p>");
#nullable restore
#line 56 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\MyDashboard\Index.cshtml"
                                  Write(Model.AppUser.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <p>");
#nullable restore
#line 57 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\MyDashboard\Index.cshtml"
                                  Write(Model.AppUser.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n                                <p class=\"pers-occ\">");
#nullable restore
#line 59 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\MyDashboard\Index.cshtml"
                                               Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-wrap\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3abc949078e9a4bb4339b2914818ca10d68f22112583", async() => {
                WriteLiteral(@"
                        <div class=""row d-flex"">
                            <div class=""col-6"">
                                <div class=""form-inner"">
                                    <input type=""text"" placeholder=""First Name"" />
                                </div>
                            </div>
                            <div class=""col-6"">
                                <div class=""form-inner"">
                                    <input type=""text"" placeholder=""Last Name"" />
                                </div>
                            </div>
                            <div class=""col-6"">
                                <div class=""form-inner"">
                                    <input type=""text"" placeholder=""User Name"" />
                                </div>
                            </div>
                        </div>
                        <div class=""form-button d-flex"">
                            <button type=""submit"" class=""update"">Update</button>
 ");
                WriteLiteral("                           <button type=\"submit\" class=\"cancel\">Cancel</button>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
            <div class=""side-text-my-product group-wrapper col-9 d-none"">
                <div class=""row"">
                    <div class=""pend-head d-flex"">
                        <div class=""pend-title col-4"">My Products</div>
                        <div class=""add-prod col-4"">
                            <button type=""submit"" class=""add-prodct"">Add product</button>
                        </div>
                    </div>
                </div>
                <div class=""table-wrap"">
                    <table>
                        <thead>
                            <tr>
                                <th>Image</th>
                                <th>Name</th>
                                <th>Category</th>
                                <th>Bid Amount(USD)</th>
                                <th>Session Time</th>
                                <th>Status</th>
                            </tr>
                        </thead>");
            WriteLiteral("\n                        <tbody>\r\n");
#nullable restore
#line 112 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\MyDashboard\Index.cshtml"
                             foreach (Product item in Model.Products)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a3abc949078e9a4bb4339b2914818ca10d68f22117177", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5712, "~/img/", 5712, 6, true);
#nullable restore
#line 116 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\MyDashboard\Index.cshtml"
AddHtmlAttributeValue("", 5718, item.Image, 5718, 11, false);

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
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>");
#nullable restore
#line 118 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\MyDashboard\Index.cshtml"
                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 119 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\MyDashboard\Index.cshtml"
                                   Write(item.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 120 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\MyDashboard\Index.cshtml"
                                   Write(item.Prise);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                    <td>
                                        <div class=""cooldown-intable"">
                                            <ul class=""d-flex justify-content-around"" style=""padding:inherit; margin:0; "" data-countdown=");
#nullable restore
#line 123 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\MyDashboard\Index.cshtml"
                                                                                                                                    Write(item.EndDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@">
                                                <li data-days=""00"">00</li>
                                                <li data-hours=""00"">00</li>
                                                <li data-minuts=""00"">00</li>
                                                <li data-seconds=""00"">00</li>
                                            </ul>
                                        </div>
                                    </td>
");
#nullable restore
#line 131 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\MyDashboard\Index.cshtml"
                                     if (item.StatusId == 1)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td class=\"text-warning\">Pending</td>\r\n");
#nullable restore
#line 134 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\MyDashboard\Index.cshtml"
                                    }
                                   else if (item.StatusId == 2)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td class=\"text-success\">Approved</td>\r\n");
#nullable restore
#line 138 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\MyDashboard\Index.cshtml"
                                    }
                                    else 
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td class=\"text-danger\">Rejected</td>\r\n");
#nullable restore
#line 142 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\MyDashboard\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </tr>\r\n");
#nullable restore
#line 145 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\MyDashboard\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </tbody>
                    </table>
                </div>
            </div>
            <div class=""side-text-picked group-wrapper col-9 d-none"">
                <div class=""row"">
                    <div class=""pend-head d-flex jusify-content-start"">
                        <div class=""pend-title col-4"">Picked Product</div>
                    </div>
                </div>
                <div class=""table-wrap"">
                    <table>
                        <thead>
                            <tr>
                                <th>Image</th>
                                <th>Name</th>
                                <th>Category</th>
                                <th>Min.Price(USD)</th>
                                <th>Session Time</th>
                                <th>Action</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 170 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\MyDashboard\Index.cshtml"
                             foreach (Bids item in Model.Bids.Where(x=>x.AppUserName==User.Identity.Name))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a3abc949078e9a4bb4339b2914818ca10d68f22123846", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 8625, "~/img/", 8625, 6, true);
#nullable restore
#line 174 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\MyDashboard\Index.cshtml"
AddHtmlAttributeValue("", 8631, item.Product.Image, 8631, 19, false);

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
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>");
#nullable restore
#line 176 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\MyDashboard\Index.cshtml"
                                   Write(item.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 177 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\MyDashboard\Index.cshtml"
                                   Write(item.Product.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 178 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\MyDashboard\Index.cshtml"
                                   Write(item.Product.Prise);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                    <td>
                                        <div class=""cooldown-intable"">
                                            <ul class=""d-flex justify-content-around"" style=""padding:inherit; margin:0; "" data-countdown=");
#nullable restore
#line 181 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\MyDashboard\Index.cshtml"
                                                                                                                                    Write(item.Product.EndDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@">
                                                <li data-days=""00"">00</li>
                                                <li data-hours=""00"">00</li>
                                                <li data-minuts=""00"">00</li>
                                                <li data-seconds=""00"">00</li>
                                            </ul>
                                        </div>
                                    </td>
                                    <td>
                                        <a");
            BeginWriteAttribute("href", " href=\"", 9715, "\"", 9747, 2);
            WriteAttributeValue("", 9722, "/Product/", 9722, 9, true);
#nullable restore
#line 190 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\MyDashboard\Index.cshtml"
WriteAttributeValue("", 9731, item.Product.Id, 9731, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Peace Bid</a>\r\n                                    </td>\r\n\r\n                                </tr>\r\n");
#nullable restore
#line 194 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\MyDashboard\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"add-prod-modal d-flex d-none\">\r\n        <div class=\"modal-p col-6\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3abc949078e9a4bb4339b2914818ca10d68f22128522", async() => {
                WriteLiteral("\r\n                <div class=\"row d-flex\">\r\n                    <div class=\"col-5\">\r\n                        <div class=\"modal-pic\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a3abc949078e9a4bb4339b2914818ca10d68f22128953", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#nullable restore
#line 208 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\MyDashboard\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProdImg);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3abc949078e9a4bb4339b2914818ca10d68f22130649", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
#nullable restore
#line 209 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\MyDashboard\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProdImg);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""col-7"">
                        <div class=""modal-info d-flex mt-4"">
                            <div class=""modal-inner col-9 ms-5"">
                                <input type=""text"" placeholder=""Product name"" name=""Name"" />
                            </div>
                            <div class=""modal-inner col-9 ms-5"">
                                <input type=""text"" placeholder=""Min. price"" name=""Prise"" />
                            </div>
                            <div class=""modal-inner col-6 ms-5"">
                                <select name=""CategoryId"" id=""modal-cate"" class=""w-100"">
");
#nullable restore
#line 222 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\MyDashboard\Index.cshtml"
                                     foreach (Category item in Model.Categories)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3abc949078e9a4bb4339b2914818ca10d68f22133405", async() => {
#nullable restore
#line 224 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\MyDashboard\Index.cshtml"
                                                            Write(item.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 224 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\MyDashboard\Index.cshtml"
                                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 225 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\MyDashboard\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                </select>
                            </div>
                            <div class=""modal-inner col-6 ms-5"">
                                <label>Session Date</label>
                                <input name=""EndDate"" type=""date"" id=""session-time"" />
                            </div>
                            <div class=""submit-prod col-9 d-flex ms-5"">
                                <button type=""submit"" class=""sub-but"">
                                    Submit Product
                                </button>
                                <a href=""#"" class=""canc-but close-add-prod-modal"">Cancel</a>
                            </div>
                        </div>
                    </div>
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
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 204 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\MyDashboard\Index.cshtml"
AddHtmlAttributeValue("", 10142, Url.Action("Add", "Product"), 10142, 29, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n<input type=\"hidden\" id=\"prodCount\"");
            BeginWriteAttribute("value", " value=\"", 12376, "\"", 12398, 1);
#nullable restore
#line 246 "C:\Users\MSI\Desktop\FinalProjectFull\actiuon\actiuon\Views\MyDashboard\Index.cshtml"
WriteAttributeValue("", 12384, ViewBag.Count, 12384, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n<!-- <div style=\"height: 100vh\"></div> -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyDashboardViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
