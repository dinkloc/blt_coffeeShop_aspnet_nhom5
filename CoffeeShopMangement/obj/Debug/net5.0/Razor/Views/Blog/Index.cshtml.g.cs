#pragma checksum "E:\Ki2Nam3\LapTrinhWeb\CoffeeShopManagement\CoffeeShopMangement\CoffeeShopMangement\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ec77287f535867387e2803a3b2af4e194a00d9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#line 1 "E:\Ki2Nam3\LapTrinhWeb\CoffeeShopManagement\CoffeeShopMangement\CoffeeShopMangement\Views\_ViewImports.cshtml"
using CoffeeShopMangement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Ki2Nam3\LapTrinhWeb\CoffeeShopManagement\CoffeeShopMangement\CoffeeShopMangement\Views\_ViewImports.cshtml"
using CoffeeShopMangement.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\Ki2Nam3\LapTrinhWeb\CoffeeShopManagement\CoffeeShopMangement\CoffeeShopMangement\Views\Blog\Index.cshtml"
using PagedList.Core.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ec77287f535867387e2803a3b2af4e194a00d9d", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1fbff6ed3fb2df6caccf6b3bc2e967120906a6a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList.Core.IPagedList<CoffeeShopMangement.Models.TinDang>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-full"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "E:\Ki2Nam3\LapTrinhWeb\CoffeeShopManagement\CoffeeShopMangement\CoffeeShopMangement\Views\Blog\Index.cshtml"
  
    ViewData["TiTle"] = "Blog - " + ViewBag.CurrentPage;
    Layout = "~/Views/Shared/_Layout.cshtml";
    int PageCurrent = ViewBag.CurrentPage;
    int PageNext = PageCurrent + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main class=""main-content"">
    <div class=""breadcrumb-area breadcrumb-height"" data-bg-image=""~/assets/images/breadcrumb/bg/1-1-1920x373.jpg"">
        <div class=""container h-100"">
            <div class=""row h-100"">
                <div class=""col-lg-12"">
                    <div class=""breadcrumb-item"">
                        <h2 class=""breadcrumb-heading"">Tin nổi bật</h2>
                        <ul>
                            <li>
                                <a href=""/"">Home <i class=""pe-7s-angle-right""></i></a>
                            </li>
                            <li>Tin nổi bật</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""blog-area blog-column-2 section-space-y-axis-100"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-1""></div>
");
#nullable restore
#line 32 "E:\Ki2Nam3\LapTrinhWeb\CoffeeShopManagement\CoffeeShopMangement\CoffeeShopMangement\Views\Blog\Index.cshtml"
                 if (Model != null && Model.Count() > 0)
                {
                    foreach (var item in Model)
                    {
                        
                        string url = $"/tin-tuc/{item.Alias}-{item.PostId}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-md-5\">\r\n                            <div class=\"blog-item\" style=\"margin-top: 20px;\">\r\n                                <div class=\"blog-img img-zoom-effect\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1719, "\"", 1730, 1);
#nullable restore
#line 41 "E:\Ki2Nam3\LapTrinhWeb\CoffeeShopManagement\CoffeeShopMangement\CoffeeShopMangement\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1726, url, 1726, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3ec77287f535867387e2803a3b2af4e194a00d9d7038", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1826, "~/images/news/", 1826, 14, true);
#nullable restore
#line 42 "E:\Ki2Nam3\LapTrinhWeb\CoffeeShopManagement\CoffeeShopMangement\CoffeeShopMangement\Views\Blog\Index.cshtml"
AddHtmlAttributeValue("", 1840, item.Thumb, 1840, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 42 "E:\Ki2Nam3\LapTrinhWeb\CoffeeShopManagement\CoffeeShopMangement\CoffeeShopMangement\Views\Blog\Index.cshtml"
AddHtmlAttributeValue("", 1858, item.Title, 1858, 11, false);

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
            WriteLiteral(@"
                                    </a>
                                </div>
                                <div class=""blog-content"">
                                    <div class=""blog-meta text-dim-gray pb-3"">
                                        <ul>
                                            <li class=""date""><i class=""fa fa-calendar-o me-2""></i>");
#nullable restore
#line 48 "E:\Ki2Nam3\LapTrinhWeb\CoffeeShopManagement\CoffeeShopMangement\CoffeeShopMangement\Views\Blog\Index.cshtml"
                                                                                             Write(item.CreatedDate.Value.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                                            <li>
                                                <span class=""comments me-3"">
                                                    <a href=""javascript:void(0)"">2 Comments</a>
                                                </span>
                                                <span class=""link-share"">
                                                    <a href=""javascript:void(0)"">Share</a>
                                                </span>
                                            </li>
                                        </ul>
                                    </div>
                                    <h3 class=""title mb-4"">
                                        <a");
            BeginWriteAttribute("href", " href=\"", 3040, "\"", 3051, 1);
#nullable restore
#line 60 "E:\Ki2Nam3\LapTrinhWeb\CoffeeShopManagement\CoffeeShopMangement\CoffeeShopMangement\Views\Blog\Index.cshtml"
WriteAttributeValue("", 3047, url, 3047, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 18px;color: #000;font-weight: 600;  font-family: \'SF Pro Display\', sans-serif;\" >");
#nullable restore
#line 60 "E:\Ki2Nam3\LapTrinhWeb\CoffeeShopManagement\CoffeeShopMangement\CoffeeShopMangement\Views\Blog\Index.cshtml"
                                                                                                                                                     Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    </h3>\r\n                                    <p class=\"short-desc mb-5\"></p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 66 "E:\Ki2Nam3\LapTrinhWeb\CoffeeShopManagement\CoffeeShopMangement\CoffeeShopMangement\Views\Blog\Index.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-md-1""></div>

                <div class=""col-lg-12"">
                    <div class=""pagination-area pt-10"">
                        <nav aria-label=""Page navigation example"">
                            <ul class=""pagination justify-content-center"">
");
#nullable restore
#line 74 "E:\Ki2Nam3\LapTrinhWeb\CoffeeShopManagement\CoffeeShopMangement\CoffeeShopMangement\Views\Blog\Index.cshtml"
                                 if (PageCurrent > 1)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"page-item\">\r\n                                        <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 3931, "\"", 3973, 2);
            WriteAttributeValue("", 3938, "/blogs.html?page=", 3938, 17, true);
#nullable restore
#line 77 "E:\Ki2Nam3\LapTrinhWeb\CoffeeShopManagement\CoffeeShopMangement\CoffeeShopMangement\Views\Blog\Index.cshtml"
WriteAttributeValue("", 3955, PageCurrent - 1, 3955, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Previous\">\r\n                                            <span class=\"fa fa-chevron-left\"></span>\r\n                                        </a>\r\n                                    </li>\r\n");
#nullable restore
#line 81 "E:\Ki2Nam3\LapTrinhWeb\CoffeeShopManagement\CoffeeShopMangement\CoffeeShopMangement\Views\Blog\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <li class=""page-item"">
                                        <a class=""page-link"" href=""/blogs.html"" aria-label=""Previous"">
                                            <span class=""fa fa-chevron-left""></span>
                                        </a>
                                    </li>
");
#nullable restore
#line 89 "E:\Ki2Nam3\LapTrinhWeb\CoffeeShopManagement\CoffeeShopMangement\CoffeeShopMangement\Views\Blog\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <li class=\"page-item active\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 4739, "\"", 4775, 2);
            WriteAttributeValue("", 4746, "/blogs.html?page=", 4746, 17, true);
#nullable restore
#line 91 "E:\Ki2Nam3\LapTrinhWeb\CoffeeShopManagement\CoffeeShopMangement\CoffeeShopMangement\Views\Blog\Index.cshtml"
WriteAttributeValue("", 4763, PageCurrent, 4763, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 91 "E:\Ki2Nam3\LapTrinhWeb\CoffeeShopManagement\CoffeeShopMangement\CoffeeShopMangement\Views\Blog\Index.cshtml"
                                                                                                                  Write(PageCurrent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                                <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 4874, "\"", 4907, 2);
            WriteAttributeValue("", 4881, "/blogs.html?page=", 4881, 17, true);
#nullable restore
#line 92 "E:\Ki2Nam3\LapTrinhWeb\CoffeeShopManagement\CoffeeShopMangement\CoffeeShopMangement\Views\Blog\Index.cshtml"
WriteAttributeValue("", 4898, PageNext, 4898, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 92 "E:\Ki2Nam3\LapTrinhWeb\CoffeeShopManagement\CoffeeShopMangement\CoffeeShopMangement\Views\Blog\Index.cshtml"
                                                                                                        Write(PageNext);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                                <li class=\"page-item\">\r\n                                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 5041, "\"", 5074, 2);
            WriteAttributeValue("", 5048, "/blogs.html?page=", 5048, 17, true);
#nullable restore
#line 94 "E:\Ki2Nam3\LapTrinhWeb\CoffeeShopManagement\CoffeeShopMangement\CoffeeShopMangement\Views\Blog\Index.cshtml"
WriteAttributeValue("", 5065, PageNext, 5065, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" aria-label=""Next"">
                                        <span class=""fa fa-chevron-right""></span>
                                    </a>
                                </li>
                            </ul>
                        </nav>
                    </div>
                </div>
            </div>
        </div>
    </div>
</main>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList.Core.IPagedList<CoffeeShopMangement.Models.TinDang>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
