#pragma checksum "C:\Users\ahmet akpınar\Desktop\çalışmalar\kurumsal\CompanySiteV2\CompanySite\Views\BackSide\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cbea24a70ca67094691fbc2908e82c0eeb3d3da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BackSide_Login), @"mvc.1.0.view", @"/Views/BackSide/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cbea24a70ca67094691fbc2908e82c0eeb3d3da", @"/Views/BackSide/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7073ad1d25b071c5afe6ec0ab130a591298c61b5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_BackSide_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/LoginStyle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ahmet akpınar\Desktop\çalışmalar\kurumsal\CompanySiteV2\CompanySite\Views\BackSide\Login.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cbea24a70ca67094691fbc2908e82c0eeb3d3da4488", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n   \r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4cbea24a70ca67094691fbc2908e82c0eeb3d3da4822", async() => {
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
    <link href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"" rel=""stylesheet"" />
    <link href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.bundle.min.js"" rel=""stylesheet"" />
    <link href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"" rel=""stylesheet"" />
    <link href=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"" rel=""stylesheet"" />
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js""></script>
    <script src=""https://unpkg.com/sweetalert/dist/sweetalert.min.js""></script>
    <title>Login</title>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cbea24a70ca67094691fbc2908e82c0eeb3d3da7376", async() => {
                WriteLiteral(@"
    <div class=""container-fluid px-1 px-md-5 px-lg-1 px-xl-5 py-5 mx-auto"" style=""margin-top:7%; padding-left:20rem!important; padding-right:20rem!important;"">
        <div class=""card card0 border-0"">
            <div class=""row d-flex"">
                <div class=""col-lg-6"">
                    <div class=""card1 pb-5"">
                        <div class=""row"">
                            <img src=""https://i.imgur.com/CXQmsmF.png"" class=""logo"">
                        </div>
                        <div class=""row px-3 justify-content-center mt-4 mb-5 border-line"">
                            <img src=""https://i.imgur.com/uNGdWHi.png"" class=""image"">
                        </div>
                    </div>
                </div>
                <div class=""col-lg-6"">
                    <div class=""card2 card border-0 px-4 py-5"" style=""margin-top:15%;"">

                        <div class=""row px-3"">
                            <label class=""mb-1""><h6 class=""mb-0 text-sm"">Kullanıcı Adı</h6");
                WriteLiteral(@"></label>
                            <input class=""mb-4"" type=""text"" name=""userName"" id=""UserName"" style=""text-align:center;"" placeholder=""Kullanıcı Adı Giriniz"">
                        </div>
                        <div class=""row px-3"">
                            <label class=""mb-1""><h6 class=""mb-0 text-sm"">Parola</h6></label>
                            <input type=""password"" name=""password"" id=""Password"" style=""text-align:center;"" placeholder=""Parola Giriniz"">
                        </div>
                        <div class=""row px-3 mb-4"">
");
                WriteLiteral(@"                        </div>
                        <div class=""row mb-3 px-3"">
                            <button type=""button"" class=""btn btn-primary text-center"" onclick=""LoginProcess()"">Giriş Yap</button>
                        </div>

                    </div>
                </div>
            </div>
            <div class=""bg-blue py-4"">
                <div class=""row px-3"">
                    <small class=""ml-4 ml-sm-5 mb-2"">Copyright &copy; 2019. All rights reserved.</small>
                    <div class=""social-contact ml-4 ml-sm-auto"">
                        <span class=""fa fa-facebook mr-4 text-sm""></span>
                        <span class=""fa fa-google-plus mr-4 text-sm""></span>
                        <span class=""fa fa-linkedin mr-4 text-sm""></span>
                        <span class=""fa fa-twitter mr-4 mr-sm-5 text-sm""></span>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</html>

<script>
    function NullFieldControl() {
        const userName = document.getElementById('UserName');
        const passW = document.getElementById('Password');
        if (userName.value.trim() === null || userName.value.trim() === """") {
            userName.style.borderRadius = ""3px"";
            userName.style.borderColor = ""Red"";
            return false;
        } else if (passW.value.trim() === null || passW.value.trim() === """") {
            passW.style.borderRadius = ""3px"";
            passW.style.borderColor = ""Red"";
            return false;
        } else {
            passW.style.borderRadius = """";
            passW.style.borderColor = """";
            userName.style.borderRadius = """";
            userName.style.borderColor = """";
            return true;
        }
    }
        function LoginProcess() {
            const userName = document.getElementById('UserName');
            const passW = document.getElementById('Password');

            if (NullFieldCon");
            WriteLiteral("trol()) {\r\n                 $.ajax({\r\n                 url: \'");
#nullable restore
#line 102 "C:\Users\ahmet akpınar\Desktop\çalışmalar\kurumsal\CompanySiteV2\CompanySite\Views\BackSide\Login.cshtml"
                  Write(Url.Action("LoginProcess" , "BackSide"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                 type: 'Post',
                     data: { userName: userName.value, password: passW.value },
                  success: function (data) {
                      console.log(data);
                      if (data.success) {
                          location.href='/BackSide/Index'
                      } else {
                          swal({
                              title: ""Bir sorunla karşılaştık!"",
                              text: data.resText,
                              icon: ""error"",
                              button: ""Kapat"",
                          });
                      }
                    },
                     error: function (data) {
                        swal({
                            title: ""Bir sorunla karşılaştık!"",
                            text: data.resText,
                            icon: ""error"",
                            button: ""Kapat"",
                        });
                    }
                });
     ");
            WriteLiteral("       }\r\n        }\r\n\r\n\r\n</script>\r\n\r\n");
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
