#pragma checksum "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Order\ViewCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1de939409fa2bd2573384aac7045fe5421bba506"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_ViewCart), @"mvc.1.0.view", @"/Views/Order/ViewCart.cshtml")]
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
#line 1 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\_ViewImports.cshtml"
using FinalProjectBooky;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\_ViewImports.cshtml"
using FinalProjectBooky.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\_ViewImports.cshtml"
using FinalProjectBooky.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1de939409fa2bd2573384aac7045fe5421bba506", @"/Views/Order/ViewCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d62860b27b3a71eb22080424e5489284e5ea8419", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_ViewCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "book", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration:none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "removecartitem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("cart-remove-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "removeall", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("removeall"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color:white;color:blue;width:80%; display:flex;justify-content:center;align-items:center;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Assets/js/view-cart.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Order\ViewCart.cshtml"
  
    ViewData["Title"] = "ViewCart";
    double totalprice = 0;

#line default
#line hidden
#nullable disable
            DefineSection("CSS", async() => {
                WriteLiteral(@"
<link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"" rel=""stylesheet""
      integrity=""sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"" crossorigin=""anonymous"">
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">
");
            }
            );
            WriteLiteral(@"<section class=""view-cart-page-title"">
    <div class=""container"">
        <div class=""row"">
            <div class=""title"">
                <h1>View Cart</h1>
            </div>
        </div>
    </div>
</section>
<section class=""shopping-cart"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-9 left-side"">
                <table>
                    <thead>
                        <tr>
                            <th class=""item"">Items</th>
                            <th class=""price"">Price</th>
                            <th class=""qty"">Quantity</th>
                            <th class=""total-price"">Total</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 35 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Order\ViewCart.cshtml"
                         foreach (var item in Model.BasketItems)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span style=\"display:none\">");
#nullable restore
#line 37 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Order\ViewCart.cshtml"
                                                   Write(totalprice+= item.Book.CampaignId == null ? item.Count * item.Book.Price : item.Count * item.Book.Price * (100 - item.Book.Campaign.DiscountPercent) / 100);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            <tr class=""cart-items"">
                                <td class=""item-info"">
                                    <div class=""item-image-info"">
                                        <div class=""item-image"">
                                            <a");
            BeginWriteAttribute("href", " href=\"", 1916, "\"", 1923, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1de939409fa2bd2573384aac7045fe5421bba50610751", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1985, "~/Assets/images/", 1985, 16, true);
#nullable restore
#line 43 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Order\ViewCart.cshtml"
AddHtmlAttributeValue("", 2001, item.Book.Image, 2001, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </a>\r\n                                        </div>\r\n                                        <div class=\"item-title\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1de939409fa2bd2573384aac7045fe5421bba50612556", async() => {
                WriteLiteral("\r\n                                                <span class=\"item-name\">\r\n");
#nullable restore
#line 49 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Order\ViewCart.cshtml"
                                                     if (item.Book.Name.Length > 20)
                                                    {
                                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Order\ViewCart.cshtml"
                                                    Write(item.Book.Name.Substring(0,20) + "...");

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Order\ViewCart.cshtml"
                                                                                                 
                                                    }
                                                    else
                                                    {
                                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Order\ViewCart.cshtml"
                                                   Write(item.Book.Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Order\ViewCart.cshtml"
                                                                       
                                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                </span>\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Order\ViewCart.cshtml"
                                                                                           WriteLiteral(item.Book.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                            <div class=\"author-item\">\r\n\r\n                                                <span class=\"author\">\r\n");
#nullable restore
#line 63 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Order\ViewCart.cshtml"
                                                     foreach (var auth in item.Book.AuthorBooks)
                                                    {
                                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Order\ViewCart.cshtml"
                                                    Write(auth.Author.Name.Substring(0,1) + ".");

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Order\ViewCart.cshtml"
                                                                                            Write(auth.Author.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span> </span>\r\n");
#nullable restore
#line 66 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Order\ViewCart.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                </span>
                                            </div>
                                        </div>
                                    </div>
                                </td>
                                <td class=""item-price"">
                                    <span class=""money"">
                                        $");
#nullable restore
#line 74 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Order\ViewCart.cshtml"
                                          if (item.Book.CampaignId == null)
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Order\ViewCart.cshtml"
                                       Write(item.Book.Price);

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Order\ViewCart.cshtml"
                                                            
                                        }
                                        else
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Order\ViewCart.cshtml"
                                        Write((item.Book.Price*(100-item.Book.Campaign.DiscountPercent)/100));

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span style=\"text-decoration:line-through;\">$");
#nullable restore
#line 82 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Order\ViewCart.cshtml"
                                                                                    Write(item.Book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 83 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Order\ViewCart.cshtml"

                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </span>\r\n                                </td>\r\n                                <td class=\"item-quantity\">\r\n                                    <div class=\"inp-num\">\r\n                                        <a data-id=\"");
#nullable restore
#line 89 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Order\ViewCart.cshtml"
                                               Write(item.Book.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"down\" id=\"downbtn\"><i class=\"fas fa-chevron-left\"></i></a>\r\n                                        <span class=\"inp-value\">");
#nullable restore
#line 90 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Order\ViewCart.cshtml"
                                                           Write(item.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        <a data-id=\"");
#nullable restore
#line 91 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Order\ViewCart.cshtml"
                                               Write(item.Book.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" class=""up"" id=""upbtn""><i class=""fas fa-chevron-right""></i></a>
                                    </div>
                                </td>
                                <td class=""item-total "">

                                    <span data-id=""");
#nullable restore
#line 96 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Order\ViewCart.cshtml"
                                              Write(item.Book.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"money-t\">\r\n                                        $");
#nullable restore
#line 97 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Order\ViewCart.cshtml"
                                          if (item.Book.CampaignId == null)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span>");
#nullable restore
#line 99 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Order\ViewCart.cshtml"
                                              Write(item.Count *item.Book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 100 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Order\ViewCart.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span>");
#nullable restore
#line 103 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Order\ViewCart.cshtml"
                                              Write(((item.Book.Price*(100-item.Book.Campaign.DiscountPercent)/100)*item.Count).ToString("f2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 104 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Order\ViewCart.cshtml"

                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </span>\r\n\r\n                                    <div class=\"remove\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1de939409fa2bd2573384aac7045fe5421bba50624495", async() => {
                WriteLiteral("\r\n                                            <span>Remove</span>\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 109 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Order\ViewCart.cshtml"
                                                                                               WriteLiteral(item.Book.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n\r\n\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 117 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Order\ViewCart.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                    </tbody>\r\n                </table>\r\n");
#nullable restore
#line 123 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Order\ViewCart.cshtml"
                 if (Model.BasketItems.Count != 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"clear-all\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1de939409fa2bd2573384aac7045fe5421bba50627898", async() => {
                WriteLiteral("\r\n                            Delete All\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 130 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Order\ViewCart.cshtml"
                }
                else
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div style=\"background-image: url(/Assets/images/empty_cart.gif);background-repeat: no-repeat;width:900px;height:400px;background-position:center;\">\r\n                    </div>\r\n");
#nullable restore
#line 136 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Order\ViewCart.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
            <div class=""col-lg-3 right-side"">
                <div class=""card"">
                    <div class=""card-header"">
                        <h1>Order Summary</h1>
                    </div>
                    <div class=""card-body"">
                        <h4>Total Price</h4>
                        <span class=""total_price"">$ <span>");
#nullable restore
#line 146 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Order\ViewCart.cshtml"
                                                     Write(totalprice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></span>\r\n                    </div>\r\n                    <div class=\"card-footer\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1de939409fa2bd2573384aac7045fe5421bba50630921", async() => {
                WriteLiteral("Checkout");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
<script src=""//cdn.jsdelivr.net/npm/sweetalert2@11""></script>

<script>
    $("".cart-remove-btn"").click(function (e) {
        e.preventDefault()
        console.log($(this).attr(""href""))
        Swal.fire({
            title: 'Are you sure?',
            text: ""You won't be able to revert this!"",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Yes, delete it!'
        }).then((result) => {
            if (result.isConfirmed) {
                var link = $(this).attr(""href"");
                fetch(link).then(response => response.json()).then(data => {
                    if (data.status == 200) {
                        location.reload(true)
                    } else {
                        Swal.fire(
                            'Not found!',
                            'Your file can not be deleted.',
                            'Failed'
            ");
                WriteLiteral(@"            )
                    }
                });
            }
        })
    })
    $("".removeall"").click(function (e) {
        e.preventDefault()
        console.log($(this).attr(""href""))
        Swal.fire({
            title: 'Are you sure?',
            text: ""You won't be able to revert this!"",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Yes, delete all!'
        }).then((result) => {
            if (result.isConfirmed) {
                var link = $(this).attr(""href"");
                fetch(link).then(response => response.json()).then(data => {
                    if (data.status == 200) {
                        location.reload(true)
                    } else {
                        Swal.fire(
                            'Not found!',
                            'Your file can not be deleted.',
                            'Failed'
");
                WriteLiteral(@"                        )
                    }
                });
            }
        })
    })
</script>
<script>
     $(document).ready(function(){

           $(document).on(""click"","".down"",function(e){
               e.preventDefault();
                 var id= $(this).attr(""data-id"")
                 var total=document.querySelector("".total_price"")
                 var money=document.querySelectorAll("".money-t"")
                 console.log(id)
              $.ajax({
                  url:""/book/decrease"",
                  data:{
                      id:id
                  },
                  type:""post"",
                  datatype:""json"",
                  success: function(data) {
                      money.forEach(mon=>{
                          if(id==mon.getAttribute(""data-id"")){
                              mon.innerHTML=data.price
                              console.log(data.price)
                          }
                      })
                     ");
                WriteLiteral(@" total.innerHTML=`${data.totalPrice}`

                   }
              })

           })


           $(document).on(""click"","".up"",function(e){
               e.preventDefault();
                 var id= $(this).attr(""data-id"")
                 var total=document.querySelector("".total_price"")
                 var money=document.querySelectorAll("".money-t"")
                 console.log(id)
              $.ajax({
                  url:""/book/increase"",
                  data:{
                      id:id
                  },
                  type:""post"",
                  datatype:""json"",
                  success: function(data) {
                      money.forEach(mon=>{
                          if(id==mon.getAttribute(""data-id"")){
                              mon.innerHTML=data.price
                              console.log(data.price)
                          }
                      })
                      total.innerHTML=`${data.totalPrice}`

                   }
  ");
                WriteLiteral(@"            })

           })


    })


</script>
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/prefixfree/1.0.7/prefixfree.min.js""></script>
<script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js""
        integrity=""sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM"" crossorigin=""anonymous"">
</script>
<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js""></script>
");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1de939409fa2bd2573384aac7045fe5421bba50637541", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
