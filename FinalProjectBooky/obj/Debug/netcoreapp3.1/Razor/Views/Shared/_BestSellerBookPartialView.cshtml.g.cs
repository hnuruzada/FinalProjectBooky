#pragma checksum "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Shared\_BestSellerBookPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3be60cb1ab6d5c802cde14abb137ad1b5105ae15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__BestSellerBookPartialView), @"mvc.1.0.view", @"/Views/Shared/_BestSellerBookPartialView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3be60cb1ab6d5c802cde14abb137ad1b5105ae15", @"/Views/Shared/_BestSellerBookPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d62860b27b3a71eb22080424e5489284e5ea8419", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__BestSellerBookPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Book>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("book-main-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "book", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "author", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "addbasket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Shared\_BestSellerBookPartialView.cshtml"
 foreach (Book book in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""item"">
                    <div class=""card"">
                        <div class=""card-header"">
                            <div class=""wrap"">
                                <div class=""perspective"">
                                    <div class=""book-wrap"">
                                        <div class=""book book-1"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3be60cb1ab6d5c802cde14abb137ad1b5105ae156758", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 484, "~/Assets/images/", 484, 16, true);
#nullable restore
#line 13 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Shared\_BestSellerBookPartialView.cshtml"
AddHtmlAttributeValue("", 500, book.Image, 500, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n                                        <div class=\"title book-1\"");
            BeginWriteAttribute("style", " style=\"", 593, "\"", 639, 3);
            WriteAttributeValue("", 601, "background-color:", 601, 17, true);
#nullable restore
#line 14 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Shared\_BestSellerBookPartialView.cshtml"
WriteAttributeValue(" ", 618, book.LeftSideColor, 619, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 638, ";", 638, 1, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                                        <div class=\"book-back book-1\"");
            BeginWriteAttribute("style", " style=\"", 718, "\"", 764, 3);
            WriteAttributeValue("", 726, "background-color:", 726, 17, true);
#nullable restore
#line 15 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Shared\_BestSellerBookPartialView.cshtml"
WriteAttributeValue(" ", 743, book.BackSideColor, 744, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 763, ";", 763, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <div class=\"text\">\r\n                                                <h3>");
#nullable restore
#line 17 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Shared\_BestSellerBookPartialView.cshtml"
                                               Write(book.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                                <p>\r\n                                                    <span>");
#nullable restore
#line 19 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Shared\_BestSellerBookPartialView.cshtml"
                                                     Write(book.Summary);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                                    
                                                </p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""card-body"">
                            <div class=""title"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3be60cb1ab6d5c802cde14abb137ad1b5105ae1511014", async() => {
                WriteLiteral("\r\n                                    <h3>");
#nullable restore
#line 31 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Shared\_BestSellerBookPartialView.cshtml"
                                   Write(book.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Shared\_BestSellerBookPartialView.cshtml"
                                                                               WriteLiteral(book.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"author-name\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3be60cb1ab6d5c802cde14abb137ad1b5105ae1513930", async() => {
                WriteLiteral("<span>");
#nullable restore
#line 35 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Shared\_BestSellerBookPartialView.cshtml"
                                                                                                       Write(book.AuthorBooks.FirstOrDefault().Author.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 35 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Shared\_BestSellerBookPartialView.cshtml"
                                                                                                                                                      Write(book.AuthorBooks.FirstOrDefault().Author.Surname);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Shared\_BestSellerBookPartialView.cshtml"
                                                                                WriteLiteral(book.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"price\">\r\n");
#nullable restore
#line 38 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Shared\_BestSellerBookPartialView.cshtml"
                     if (book.CampaignId == null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span><span>$</span>");
#nullable restore
#line 40 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Shared\_BestSellerBookPartialView.cshtml"
                                       Write(book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 41 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Shared\_BestSellerBookPartialView.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span><span>$</span>");
#nullable restore
#line 44 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Shared\_BestSellerBookPartialView.cshtml"
                                        Write(book.Price * (100 - book.Campaign.DiscountPercent)/100);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <p class=\"campaign\">$");
#nullable restore
#line 45 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Shared\_BestSellerBookPartialView.cshtml"
                                        Write(book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 46 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Shared\_BestSellerBookPartialView.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    \r\n                                \r\n                            </div>\r\n                            <div class=\"add-to-cart\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3be60cb1ab6d5c802cde14abb137ad1b5105ae1519361", async() => {
                WriteLiteral("Add To Cart");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Shared\_BestSellerBookPartialView.cshtml"
                                                                                                WriteLiteral(book.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2804, "\"", 2811, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"far fa-heart\"></i></a>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\n");
#nullable restore
#line 57 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Shared\_BestSellerBookPartialView.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
