#pragma checksum "C:\Users\ahmet akpınar\Desktop\çalışmalar\kurumsal\CompanySiteV2\CompanySite\Views\Home\Blog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b7b87b6da155dc843d858b78a927e998f57b9b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Blog), @"mvc.1.0.view", @"/Views/Home/Blog.cshtml")]
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
#line 1 "C:\Users\ahmet akpınar\Desktop\çalışmalar\kurumsal\CompanySiteV2\CompanySite\Views\_ViewImports.cshtml"
using CompanySite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ahmet akpınar\Desktop\çalışmalar\kurumsal\CompanySiteV2\CompanySite\Views\_ViewImports.cshtml"
using CompanySite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b7b87b6da155dc843d858b78a927e998f57b9b1", @"/Views/Home/Blog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7073ad1d25b071c5afe6ec0ab130a591298c61b5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Blog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/blog/01.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ahmet akpınar\Desktop\çalışmalar\kurumsal\CompanySiteV2\CompanySite\Views\Home\Blog.cshtml"
  
    ViewData["Title"] = "Blog";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!--hero section start-->

<section class=""page-title position-relative overflow-hidden shape-1 right"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-6"">
                <div class=""bg-white p-md-5 p-3 d-inline-block"">
                    <h1 class=""font-w-3 mb-4""><span class=""text-primary font-w-5"">Blog</span> </h1>
                    <nav aria-label=""breadcrumb"">
                        <ol class=""breadcrumb"">
                            <li class=""breadcrumb-item"">
                                <a");
            BeginWriteAttribute("href", " href=\"", 604, "\"", 638, 1);
#nullable restore
#line 18 "C:\Users\ahmet akpınar\Desktop\çalışmalar\kurumsal\CompanySiteV2\CompanySite\Views\Home\Blog.cshtml"
WriteAttributeValue("", 611, Url.Action("Index","Home"), 611, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><i class=""las la-home me-1""></i>Anasayfa</a>
                            </li>
                           
                            <li class=""breadcrumb-item active"" aria-current=""page"">Blog </li>
                        </ol>
                    </nav>
                </div>
            </div>
        </div>
    </div>
    <canvas id=""canvas-1""></canvas>
</section>

<!--hero section end-->
<!--body content start-->

    <!--blog start-->

    <section>
        <div class=""container"">
            <div class=""row justify-content-center"">
                <div class=""col-lg-10"">
                    <!-- Blog Card -->
                    <div class=""card post-card rounded border-0 shadow-none"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9b7b87b6da155dc843d858b78a927e998f57b9b16252", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <div class=""card-body pt-4 pb-0 px-0"">
                            <ul class=""list-inline"">
                                <li class=""list-inline-item"">
                                    <a href=""#"" class=""text-grey""><i class=""lar la-user-circle me-1""></i> Admin</a>
                                </li>
                                <li class=""list-inline-item"">
                                    <a href=""#"" class=""text-grey""><i class=""las la-eye me-1""></i> 05 Jan, 2022</a>
                                </li>
                            </ul>
                            <h2 class=""mt-3 mb-0 font-w-5"">
                                Grow your business insights with inspiring news
                            </h2>
                        </div>
                    </div>
                    <p class=""mt-5 mb-0 lead"">Est quis sit phasellus proin proin fringilla eu quis. Placerat praesent blandit urna eu pellentesque dictum. Aliquam duis quam interdum quis. Urna, r");
            WriteLiteral(@"utrum aenean lacus phasellus. Ipsum, ac porttitor lacus orci, cras lacus, quis leo. Magna donec dictum cras nullam platea. Diam rhoncus massa lectus pellentesque tristique. Amet commodo, egestas vitae bibendum. Volutpat elit condimentum integer tortor porttitor justo vel lobortis risus</p>
                    <blockquote class=""box-shadow rounded border-0 p-lg-5 p-3 my-5 h5 font-w-4"">
                        “Sollicitudin eget massa, elementum, purus nec fermentum vitae, elementum. Tincidunt vulputate lorem cursus id. Dictum tincidunt mi ornare tristique. Id sit elit pulvinar eu. Tempus vel, mauris sed proin aliquet vulputate cras est. Ut ornare eget a viverra.” <span class=""mt-2 d-block text-primary fst-italic"">- Leena Ivy</span>
                    </blockquote>
                    <div class=""d-md-flex justify-content-between"">
                        <div class=""d-flex align-items-center"">
                            <h6 class=""mb-0 me-4"">Share It:</h6>
                            <div class=""socia");
            WriteLiteral(@"l-icons"">
                                <ul class=""list-inline mb-0"">
                                    <li>
                                        <a href=""#""><i class=""la la-facebook""></i></a>
                                    </li>
                                    <li>
                                        <a href=""#""><i class=""la la-dribbble""></i></a>
                                    </li>
                                    <li>
                                        <a href=""#""><i class=""la la-instagram""></i></a>
                                    </li>
                                    <li>
                                        <a href=""#""><i class=""la la-twitter""></i></a>
                                    </li>
                                    <li>
                                        <a href=""#""><i class=""la la-linkedin""></i></a>
                                    </li>
                                </ul>
                            </div>
          ");
            WriteLiteral(@"              </div>
                        <div class=""d-flex align-items-center text-md-end mt-5 mt-md-0"">
                            <h6 class=""mb-0 me-4"">Tags: </h6>
                            <ul class=""list-inline mb-0 widget-tags"">
                                <li class=""list-inline-item"">
                                    <a class=""d-inline-block m-1 rounded"" href=""#"">Bootstrap 5</a>
                                </li>
                                <li class=""list-inline-item"">
                                    <a class=""d-inline-block m-1 rounded"" href=""#"">Data Science</a>
                                </li>
                                <li class=""list-inline-item"">
                                    <a class=""d-inline-block m-1 rounded"" href=""#"">Analytics</a>
                                </li>
                            </ul>
                        </div>
                    </div>
                    <div class=""row my-6"">
                        <!--<div c");
            WriteLiteral(@"lass=""col-md-6 mb-5 mb-md-0"">-->
                            <!-- Blog Card -->
                            <!--<div class=""card post-card rounded border-0"">
                                <img class=""rounded img-fluid"" src=""~/images/blog/01.jpg"" alt=""Image"">
                                <div class=""card-body p-4"">
                                    <ul class=""list-inline"">
                                        <li class=""list-inline-item"">
                                            <a href=""#"" class=""text-grey""><i class=""lar la-user-circle me-1""></i> Admin</a>
                                        </li>
                                        <li class=""list-inline-item"">
                                            <a href=""#"" class=""text-grey""><i class=""las la-eye me-1""></i> 05 Jan, 2022</a>
                                        </li>
                                    </ul>
                                    <h2 class=""h4 my-3"">
                                        Grow your ");
            WriteLiteral(@"business insights with inspiring news
                                    </h2>
                                    <a class=""post-btn float-end"" href=""blog-single.html""><i class=""las la-long-arrow-alt-right""></i></a>
                                </div>
                            </div>-->
                            <!-- End Blog Card -->
                        <!--</div>
                        <div class=""col-md-6"">-->
                            <!-- Blog Card -->
                            <!--<div class=""card post-card rounded border-0"">
                                <img class=""rounded img-fluid"" src=""~/images/blog/02.jpg"" alt=""Image"">
                                <div class=""card-body p-4"">
                                    <ul class=""list-inline"">
                                        <li class=""list-inline-item"">
                                            <a href=""#"" class=""text-grey""><i class=""lar la-user-circle me-1""></i> Admin</a>
                                   ");
            WriteLiteral(@"     </li>
                                        <li class=""list-inline-item"">
                                            <a href=""#"" class=""text-grey""><i class=""las la-eye me-1""></i> 05 Jan, 2022</a>
                                        </li>
                                    </ul>
                                    <h2 class=""h4 my-3"">
                                        Stacht is a big milestone for your business success
                                    </h2>
                                    <a class=""post-btn float-end"" href=""blog-single.html""><i class=""las la-long-arrow-alt-right""></i></a>
                                </div>
                            </div>-->
                            <!-- End Blog Card -->
                        <!--</div>-->
                    </div>
");
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n\r\n    <!--blog end-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
