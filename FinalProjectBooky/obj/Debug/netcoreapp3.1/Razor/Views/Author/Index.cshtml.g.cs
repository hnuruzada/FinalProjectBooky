#pragma checksum "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Author\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb28a4ff500368982be6a1cb75428f5357dd48b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Author_Index), @"mvc.1.0.view", @"/Views/Author/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb28a4ff500368982be6a1cb75428f5357dd48b6", @"/Views/Author/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d62860b27b3a71eb22080424e5489284e5ea8419", @"/Views/_ViewImports.cshtml")]
    public class Views_Author_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AuthorVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:200px;height:200px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Assets/js/author.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Author\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<section class=\"author-profile\" style=\"background-image: url(/Assets/images/bg-author_1920x545.webp);\">\r\n    <div class=\"profile\">\r\n        <div class=\"profile-img\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fb28a4ff500368982be6a1cb75428f5357dd48b64820", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 288, "~/Assets/images/", 288, 16, true);
#nullable restore
#line 11 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Author\Index.cshtml"
AddHtmlAttributeValue("", 304, Model.Author.Image, 304, 19, false);

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
            WriteLiteral("\r\n        </div>\r\n        <div class=\"author-name\">\r\n            <h2>");
#nullable restore
#line 14 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Author\Index.cshtml"
           Write(Model.Author.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 14 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Author\Index.cshtml"
                              Write(Model.Author.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        </div>\r\n        <div class=\"author-books\">\r\n            <span>");
#nullable restore
#line 17 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Author\Index.cshtml"
             Write(Model.Author.AuthorBooks.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Books</span>\r\n        </div>\r\n        <div class=\"author-info\">\r\n            <p>\r\n               ");
#nullable restore
#line 21 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Author\Index.cshtml"
          Write(Model.Author.Resume);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n        </div>\r\n    </div>\r\n</section>\r\n<section class=\"all-author-books\">\r\n    <div class=\"title\">\r\n        <h1>All ");
#nullable restore
#line 28 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Author\Index.cshtml"
           Write(Model.Author.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("`s Books</h1>\r\n    </div>\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n           ");
#nullable restore
#line 32 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Author\Index.cshtml"
      Write(await Html.PartialAsync("_AuthorBookPartialView",Model));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <div class=""loadMore"">
                <a href=""#"">LOAD MORE BOOKS</a>
            </div>
        </div>
    </div>
</section>
<section class=""other-authors"">
    <div class=""other-author-title"">
        <h1>VIEW ANOTHER AUTHORS</h1>
    </div>
    <div class=""container"">
        <div class=""row"">
           
            ");
#nullable restore
#line 46 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Author\Index.cshtml"
       Write(await Html.PartialAsync("_AuthorsPartialView",Model.Authors));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            \r\n        </div>\r\n    </div>\r\n     \r\n</section>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
    <script>
       $( document ).ready(function () {
    $("".moreBox"").slice(0, 4).show();
      if ($("".blogBox:hidden"").length != 0) {
        $("".loadMore"").show();
      }   
      $("".loadMore"").on('click', function (e) {
        e.preventDefault();
        $("".moreBox:hidden"").slice(0, 4).slideDown();
        if ($("".moreBox:hidden"").length == 0) {
          $("".loadMore"").fadeOut('slow');
        }
      });
    });
    </script>
   
        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb28a4ff500368982be6a1cb75428f5357dd48b69921", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AuthorVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
