#pragma checksum "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Shared\_CategoryTagBlogPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "624ed8e484b0fff83b8243252e1afec09bdd57df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__CategoryTagBlogPartialView), @"mvc.1.0.view", @"/Views/Shared/_CategoryTagBlogPartialView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"624ed8e484b0fff83b8243252e1afec09bdd57df", @"/Views/Shared/_CategoryTagBlogPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d62860b27b3a71eb22080424e5489284e5ea8419", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__CategoryTagBlogPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("overflow:hidden;width:100%;height:250px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin:0 0 2rem 2rem;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Shared\_CategoryTagBlogPartialView.cshtml"
 foreach (Blog blog in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card col col-lg-5 col-md-5 col-sm-12 col-xs-12 col-12\" style=\"height:100%;margin:10px 10px 10px 0;\">\r\n        <div class=\"item\">\r\n            <div class=\"image\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "624ed8e484b0fff83b8243252e1afec09bdd57df6085", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 260, "~/Assets/images/", 260, 16, true);
#nullable restore
#line 8 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Shared\_CategoryTagBlogPartialView.cshtml"
AddHtmlAttributeValue("", 276, blog.Image, 276, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""content"">
                <div class=""info"" style=""display:flex;margin:10px 0 1.5rem 3rem;justify-content:space-between;"">
                    <div class=""date-publisher"">
                        <span style=""font-size:14px;opacity:0.6;"">");
#nullable restore
#line 13 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Shared\_CategoryTagBlogPartialView.cshtml"
                                                             Write(blog.Date.ToString("MMMM dd,yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <span style=\"font-size:14px;opacity:0.6;\">-</span>\r\n                        <span style=\"font-size:14px;opacity:0.6;\">by ");
#nullable restore
#line 15 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Shared\_CategoryTagBlogPartialView.cshtml"
                                                                Write(blog.Publisher.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 15 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Shared\_CategoryTagBlogPartialView.cshtml"
                                                                                     Write(blog.Publisher.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                    <div class=\"comments\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "624ed8e484b0fff83b8243252e1afec09bdd57df9323", async() => {
                WriteLiteral("\r\n                            <i class=\"fas fa-comments\" style=\"font-size:14px;opacity:0.6;\"></i>\r\n                            <span style=\"font-size:14px;opacity:0.6;\">(");
#nullable restore
#line 20 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Shared\_CategoryTagBlogPartialView.cshtml"
                                                                  Write(blog.Comments.Where(c=>c.IsAccess==true).Count());

#line default
#line hidden
#nullable disable
                WriteLiteral(")</span>\r\n                        ");
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
#line 18 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Shared\_CategoryTagBlogPartialView.cshtml"
                                                                       WriteLiteral(blog.Id);

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
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "624ed8e484b0fff83b8243252e1afec09bdd57df12376", async() => {
                WriteLiteral("<h3 style=\"margin-left:3rem; font-size:18px; color:black;\">\r\n");
#nullable restore
#line 25 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Shared\_CategoryTagBlogPartialView.cshtml"
                      if (blog.Title.Length < 30)
                    {
                       

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Shared\_CategoryTagBlogPartialView.cshtml"
                  Write(blog.Title);

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Shared\_CategoryTagBlogPartialView.cshtml"
                                  

                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Shared\_CategoryTagBlogPartialView.cshtml"
                    Write(blog.Title.Substring(0,30) + "...");

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Shared\_CategoryTagBlogPartialView.cshtml"
                                                             
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </h3>");
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
#line 24 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Shared\_CategoryTagBlogPartialView.cshtml"
                                                               WriteLiteral(blog.Id);

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
            WriteLiteral("\r\n                <p style=\"font-size:14px;margin-left:3rem;\">\r\n");
#nullable restore
#line 36 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Shared\_CategoryTagBlogPartialView.cshtml"
                     if (blog.Description.Length < 100)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Shared\_CategoryTagBlogPartialView.cshtml"
                   Write(blog.Description);

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Shared\_CategoryTagBlogPartialView.cshtml"
                                         

                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Shared\_CategoryTagBlogPartialView.cshtml"
                    Write(blog.Description.Substring(0,100) + "...");

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Shared\_CategoryTagBlogPartialView.cshtml"
                                                                    
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </p>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "624ed8e484b0fff83b8243252e1afec09bdd57df17855", async() => {
                WriteLiteral("read more");
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
#line 46 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Shared\_CategoryTagBlogPartialView.cshtml"
                                                               WriteLiteral(blog.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 50 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Shared\_CategoryTagBlogPartialView.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
