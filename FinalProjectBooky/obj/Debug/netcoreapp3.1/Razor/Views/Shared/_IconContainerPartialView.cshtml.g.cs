#pragma checksum "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Shared\_IconContainerPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "451da35d23e84eaa1dfb7df25641abecd7634c62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__IconContainerPartialView), @"mvc.1.0.view", @"/Views/Shared/_IconContainerPartialView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"451da35d23e84eaa1dfb7df25641abecd7634c62", @"/Views/Shared/_IconContainerPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d62860b27b3a71eb22080424e5489284e5ea8419", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__IconContainerPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<IconContainer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Shared\_IconContainerPartialView.cshtml"
     foreach(IconContainer icon in Model){
        

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"icons\" style=\"display:flex;justify-content:center\">\r\n                ");
#nullable restore
#line 7 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Shared\_IconContainerPartialView.cshtml"
           Write(Html.Raw(@icon.Icon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"content\">\r\n                    <h3>");
#nullable restore
#line 9 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Shared\_IconContainerPartialView.cshtml"
                   Write(icon.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <p>");
#nullable restore
#line 10 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Shared\_IconContainerPartialView.cshtml"
                  Write(icon.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 13 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Shared\_IconContainerPartialView.cshtml"

           
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<IconContainer>> Html { get; private set; }
    }
}
#pragma warning restore 1591