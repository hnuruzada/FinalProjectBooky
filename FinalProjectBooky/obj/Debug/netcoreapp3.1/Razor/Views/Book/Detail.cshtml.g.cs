#pragma checksum "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Book\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67c052b9c108a1a795a54e4e487760f676ce7b2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Detail), @"mvc.1.0.view", @"/Views/Book/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67c052b9c108a1a795a54e4e487760f676ce7b2e", @"/Views/Book/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d62860b27b3a71eb22080424e5489284e5ea8419", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Assets/images/book16.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Assets/images/book17.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Assets/images/book18.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Assets/images/book19.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Assets/js/book-detail-page.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Hesen\source\repos\FinalProjectBooky\FinalProjectBooky\Views\Book\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("CSS", async() => {
                WriteLiteral("\r\n        <link href=\"https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css\" rel=\"stylesheet\" integrity=\"sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3\" crossorigin=\"anonymous\">\r\n\r\n");
            }
            );
            WriteLiteral(@"
<section class=""page-title"">
    <div class=""container"">
        <div class=""title"">
            <h1>BOOK DETAILS</h1>
        </div>
    </div>
</section>
<section class=""book-content"">
    <div class=""container"">
        <div class=""rsp-book-img"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "67c052b9c108a1a795a54e4e487760f676ce7b2e6669", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"cover\">\r\n            <div class=\"book\">\r\n                <label for=\"page-1\" class=\"book__page book__page--1\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "67c052b9c108a1a795a54e4e487760f676ce7b2e7967", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
                </label>

                <label for=""page-2"" class=""book__page book__page--4"">
                    <div class=""page__content"">
                        <h1 class=""page__content-title"">I</h1>
                        <div class=""page__content-text"">
                            <p>
                                His name was Gaal Dornick and he was just a country boy who had never seen Trantor
                                before. That is, not in real life. He had seen it many times on the hyper-video, and
                                occasionally in tremendous three-dimensional newscasts covering an Imperial
                                Coronation or the opening of a Galactic Council. Even though he had lived all his
                                life on the world of Synnax, which circled a star at the edges of the Blue Drift, he
                                was not cut off from civilization, you see. At that time, no place in the Galaxy
                             ");
            WriteLiteral(@"   was.
                            </p>
                            <p>
                                His name was Gaal Dornick and he was just a country boy who had never seen Trantor
                                before. That is, not in real life. He had seen it many times on the hyper-video, and
                                occasionally in tremendous three-dimensional newscasts covering an Imperial
                                Coronation or the opening of a Galactic Council. Even though he had lived all his
                                life on the world of Synnax, which circled a star at the edges of the Blue Drift, he
                                was not cut off from civilization, you see. At that time, no place in the Galaxy
                                was.
                            </p>


                        </div>
                        <div class=""page__number"">3</div>
                    </div>
                </label>

                <!-- Resets the pag");
            WriteLiteral(@"e -->
                <input type=""radio"" name=""page"" id=""page-1"" />

                <!-- Goes to the second page -->
                <input type=""radio"" name=""page"" id=""page-2"" />
                <label class=""book__page book__page--2"">
                    <div class=""book__page-front"">
                        <div class=""page__content"">
                            <h1 class=""page__content-book-title"">Foundation</h1>
                            <h2 class=""page__content-author"">Isaac Asimov</h2>

                            <p class=""page__content-credits"">
                                Introduction by
                                <span>Paul Krugman</span>
                            </p>

                            <p class=""page__content-credits"">
                                Illustrations by
                                <span>Alex Wells</span>
                            </p>

                            <div class=""page__content-copyright"">
                              ");
            WriteLiteral(@"  <p>The Folio Society</p>
                                <p>London - MMXII</p>
                            </div>
                        </div>
                    </div>
                    <div class=""book__page-back"">
                        <div class=""page__content"">
                            <h1 class=""page__content-title"">Contents</h1>
                            <table class=""page__content-table"">
                                <tr>
                                    <td align=""left"">Part I</td>
                                    <td align=""left"">The Psycohistorians</td>
                                    <td align=""right"">3</td>
                                </tr>
                                <tr>
                                    <td align=""left"">Part II</td>
                                    <td align=""left"">The Encyclopedists</td>
                                    <td align=""right"">43</td>
                                </tr>
                                ");
            WriteLiteral(@"<tr>
                                    <td align=""left"">Part III</td>
                                    <td align=""left"">The Mayors</td>
                                    <td align=""right"">87</td>
                                </tr>
                                <tr>
                                    <td align=""left"">Part IV</td>
                                    <td align=""left"">The Traders</td>
                                    <td align=""right"">147</td>
                                </tr>
                                <tr>
                                    <td align=""left"">Part V</td>
                                    <td align=""left"">The Merchant Princes</td>
                                    <td align=""right"">173</td>
                                </tr>
                            </table>

                            <div class=""page__number"">2</div>
                        </div>
                    </div>
                </label>
            </div>
   ");
            WriteLiteral(@"     </div>
        <div class=""book-details"">
            <div class=""details"">
                <h1>Book Name</h1>
                <ul>
                    <li>Author: <span>Author Name</span> </li>
                    <li>Category: <span>Historical,Action</span></li>
                    <li>SkuCode: <span>1524324</span></li>
                    <li>Language: <span>English</span></li>
                    <li>Page: <span>250</span></li>
                    <li>Publish: <span>1997</span></li>
                    <li>Price: <span>$100</span></li>
                </ul>
            </div>
            <div class=""Add-Cart"">
                <div class=""quantity"">
                    <button class=""btn minus-btn disabled"" type=""button"">-</button>
                    <input type=""text"" id=""quantity"" value=""1"">
                    <button class=""btn plus-btn"" type=""button"">+</button>
                </div>
                <div class=""btn-cart"">
                    <button type=""submit"">Add To Cart");
            WriteLiteral(@"</button>
                </div>
            </div>
            <div class=""buy-it-now"">
                <button type=""submit"">Buy It Now</button>
            </div>
        </div>
    </div>
</section>
<section class=""tabs"">
    <div class=""container"">
        <div class=""tabset"">
            <!-- Tab 1 -->
            <input type=""radio"" name=""tabset"" id=""tab1"" aria-controls=""description"" checked>
            <label for=""tab1"">DESCRIPTION</label>
            <!-- Tab 2 -->
            <input type=""radio"" name=""tabset"" id=""tab2"" aria-controls=""bookInformation"">
            <label for=""tab2"">INFORMATION</label>
            <!-- Tab 3 -->
            <input type=""radio"" name=""tabset"" id=""tab3"" aria-controls=""reviews"">
            <label for=""tab3"">REVIEWS(0)</label>

            <div class=""tab-panels"">
                <div id=""description"" class=""tab-panel"">
                    <h2>Book Summary</h2>
                    <p>
                        Lorem ipsum dolor sit amet consectetu");
            WriteLiteral(@"r adipisicing elit. Eligendi dolorem ut deserunt
                        soluta libero voluptatum mollitia illum sapiente aut natus enim vitae reiciendis,
                        magnam, laborum quidem fugiat molestias officiis. Sit eum tenetur tempore ipsam
                        molestias doloribus mollitia incidunt dolore, doloremque ducimus aliquam laborum magnam
                        aperiam, atque officia deserunt odio! Velit!
                    </p>
                </div>
                <div id=""bookInformation"" class=""tab-panel"">

                    <p><strong>Book:</strong> Book Name</p>
                    <p><strong>Author:</strong> Author Name</p>
                    <p><strong>Page:</strong> 250</p>
                    <p><strong>Category:</strong> Action,Criminal</p>
                    <p><strong>Date:</strong> 1993</p>

                </div>

                <div id=""reviews"" class=""tab-panel"">
                    <div id=""comments"">
                        <h2 class=");
            WriteLiteral(@"""reviews-title"">Reviews</h2>
                        <ul class=""commentlist"">
                            <li class=""comment-even"">
                                <div id=""comment-1"" class=""comment_container"">
                                    <div class=""comment-text"">
                                        <p class=""info"">
                                            <span class=""author"">Joshua Garcia </span>
                                            <span class=""time"">27.04.2018</span>
                                        </p>
                                        <div class=""description"">
                                            <p>
                                                Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean
                                                commodo ligula eget dolor. Aenean massa. Cum sociis Theme
                                                natoque penatibus et magnis dis parturient montes, nascetur
                         ");
            WriteLiteral(@"                       ridiculus mus.
                                            </p>
                                        </div>
                                    </div>
                                </div>
                            </li>
                            <li class=""comment-odd"">
                                <div id=""comment-2"" class=""comment_container"">
                                    <div class=""comment-text"">
                                        <p class=""info"">
                                            <span class=""author"">Joan Stanley </span>
                                            <span class=""time"">27.04.2018</span>
                                        </p>
                                        <div class=""description"">
                                            <p>
                                                Etiam rhoncus. Maecenas tempus, tellus eget condimentum rhoncus,
                                                sem quam semper lib");
            WriteLiteral(@"ero, sit amet adipiscing sem neque sed ipsum.
                                                Nam quam nunc, blandit vel, luctus pulvinar, hendrerit
                                            </p>
                                        </div>
                                    </div>
                                </div>
                            </li>
                        </ul>

                    </div>

                    <div class=""reviewform"">
                        <div class=""reviewtitle"">
                            <h1>Add a review</h1>
                            <div class=""form"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67c052b9c108a1a795a54e4e487760f676ce7b2e20501", async() => {
                WriteLiteral(@"
                                    <div class=""input"">

                                        <p>Your review *</p>
                                        <textarea class=""form-control"" id=""exampleFormControlTextarea1"" rows=""3""></textarea>
                                    </div>

                                    <div class=""input"">
                                        <label for=""exampleInputPassword1"" class=""form-label"">Name*</label>
                                        <input type=""text"" class=""form-control"" id=""exampleInputPassword1"">
                                    </div>
                                    <div class=""input"">
                                        <label for=""exampleInputEmail1"" class=""form-label"">Email*</label>
                                        <input type=""email"" class=""form-control"" id=""exampleInputEmail1""
                                               aria-describedby=""emailHelp"">
                                    </div>

                ");
                WriteLiteral(@"                    <div class=""form-check"">
                                        <input type=""checkbox"" class=""form-check-input"" id=""exampleCheck1"">
                                        <label class=""form-check-label"" for=""exampleCheck1"">
                                            Save my name, email,and website in this browser for the next time I comment.
                                        </label>
                                    </div>
                                    <button type=""submit"" class=""btn"">Submit</button>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

<section class=""related-books"">

    <div class=""container"">
        <div class=""related-title"">
            <h1>RELATED BOOKS</h1>
        </div>
        <div class=""row"">
            <div class=""col col-lg-3 col-md-6 col-sm-12"">
                <div class=""card"">
                    <div class=""face face1"">
                        <div class=""content"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "67c052b9c108a1a795a54e4e487760f676ce7b2e24017", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 13990, "\"", 13997, 0);
            EndWriteAttribute();
            WriteLiteral(@"><h3>Book Name</h3></a>
                        </div>
                    </div>
                    <div class=""face face2"">
                        <div class=""content"">
                            <div class=""content-info"">
                                <span>Author Name</span>
                                <span>100$</span>
                            </div>
                            <a href=""#"">ADD TO CART</a>
                        </div>
                    </div>
                </div>
            </div>

            <div class=""col col-lg-3 col-md-6 col-sm-12"">
                <div class=""card"">
                    <div class=""face face1"">
                        <div class=""content"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "67c052b9c108a1a795a54e4e487760f676ce7b2e25996", async() => {
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
            WriteLiteral("\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 14826, "\"", 14833, 0);
            EndWriteAttribute();
            WriteLiteral(@"><h3>Book Name</h3></a>
                        </div>
                    </div>
                    <div class=""face face2"">
                        <div class=""content"">
                            <div class=""content-info"">
                                <span>Author Name</span>
                                <span>100$</span>
                            </div>
                            <a href=""#"">ADD TO CART</a>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col col-lg-3 col-md-6 col-sm-12"">
                <div class=""card"">
                    <div class=""face face1"">
                        <div class=""content"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "67c052b9c108a1a795a54e4e487760f676ce7b2e27973", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 15660, "\"", 15667, 0);
            EndWriteAttribute();
            WriteLiteral(@"><h3>Book Name</h3></a>
                        </div>
                    </div>
                    <div class=""face face2"">
                        <div class=""content"">
                            <div class=""content-info"">
                                <span>Author Name</span>
                                <span>100$</span>
                            </div>
                            <a href=""#"">ADD TO CART</a>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col col-lg-3 col-md-6 col-sm-12"">
                <div class=""card"">
                    <div class=""face face1"">
                        <div class=""content"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "67c052b9c108a1a795a54e4e487760f676ce7b2e29950", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 16494, "\"", 16501, 0);
            EndWriteAttribute();
            WriteLiteral(@"><h3>Book Name</h3></a>
                        </div>
                    </div>
                    <div class=""face face2"">
                        <div class=""content"">
                            <div class=""content-info"">
                                <span>Author Name</span>
                                <span>100$</span>
                            </div>
                            <a href=""#"">ADD TO CART</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>



");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js\"></script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67c052b9c108a1a795a54e4e487760f676ce7b2e31945", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
