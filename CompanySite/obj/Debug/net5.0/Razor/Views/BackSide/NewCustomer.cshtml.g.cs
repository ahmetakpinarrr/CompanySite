#pragma checksum "C:\Users\ahmet akpınar\Desktop\çalışmalar\kurumsal\CompanySiteV2\CompanySite\Views\BackSide\NewCustomer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55ac0c2d0ea8a13e6ad6fb8222bc05d3dafafff1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BackSide_NewCustomer), @"mvc.1.0.view", @"/Views/BackSide/NewCustomer.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55ac0c2d0ea8a13e6ad6fb8222bc05d3dafafff1", @"/Views/BackSide/NewCustomer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7073ad1d25b071c5afe6ec0ab130a591298c61b5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_BackSide_NewCustomer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ahmet akpınar\Desktop\çalışmalar\kurumsal\CompanySiteV2\CompanySite\Views\BackSide\NewCustomer.cshtml"
  
    ViewData["Title"] = "NewCustomer";
    Layout = "~/Views/Shared/_LayoutBack.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row mb-4"" style=""overflow:hidden;"">
    <div class=""col-md-11 col-md-6 mb-md-0 mb-4"" style=""overflow:hidden;"">
        <div class=""card"" style=""padding:35px;"" >
            <div class=""card-header pb-0"">
                <div class=""row"" style=""overflow:hidden;"">
                    <div class=""col-lg-6 col-7"" style=""overflow:hidden;"">
                        <h6>Potansiyel Müşteri İlişkileri</h6>
");
            WriteLiteral("                    </div>\r\n");
            WriteLiteral("                </div>\r\n            </div>\r\n            <div class=\"card-body px-0 pb-2\" style=\"overflow:hidden;\">\r\n                <div class=\"table-responsive\">\r\n                    <table");
            BeginWriteAttribute("class", " class=\"", 1948, "\"", 1956, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""CustomersTbl"" style=""width:100%;"">
                    </table>
                </div>
            </div>
        </div>
    </div>

</div>

<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Müşteri Soru/Cevap </h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55ac0c2d0ea8a13e6ad6fb8222bc05d3dafafff15368", async() => {
                WriteLiteral("\r\n                    <input hidden type=\"text\"  id=\"registerId\" name=\"name\"");
                BeginWriteAttribute("value", " value=\"", 2791, "\"", 2799, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                    <div class=""form-group"">
                        <label for=""recipient-name"" class=""col-form-label"">Ad - Soyad :</label>
                        <input type=""text"" class=""form-control messageCustomer"" id=""customerName"">
                    </div>
                    <div class=""form-group"">
                        <label for=""recipient-name"" class=""col-form-label"">Telefon :</label>
                        <input type=""text"" class=""form-control messageCustomer"" id=""customerPhone"">
                    </div>
                    <div class=""form-group"">
                        <label for=""recipient-name"" class=""col-form-label"">E-Posta :</label>
                        <input type=""text"" class=""form-control messageCustomer"" id=""customerMail"">
                    </div>
                    <div class=""form-group"">
                        <label for=""message-text"" class=""col-form-label"">Mesaj:</label>
                        <textarea class=""form-control messageCustomer"" id=""C");
                WriteLiteral(@"ustomerMessageMdl""></textarea>
                    </div>
                    <br />
                    <hr />
                    <div class=""form-group"">
                        <label for=""message-text"" class=""col-form-label"">Konu :</label>
                        <input style=""border:solid 2px; padding:10px;"" class=""form-control"" id=""mailSubject"">
                    </div>

                    <div class=""form-group"">
                        <label for=""message-text"" class=""col-form-label"">Mail içeriği :</label>
                        <textarea style=""border:solid 2px; padding:10px;"" class=""form-control"" id=""AnswerText""></textarea>
                    </div>
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
            <div class=""modal-footer"">
                <p id=""resultMail"" style=""color:green;"" ></p>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Kapat</button>
                <button type=""button"" class=""btn btn-primary"" onclick=""SendAnswer()"">Mail Gönder</button>
            </div>
        </div>
    </div>
</div>



");
            DefineSection("pageFooterScript", async() => {
                WriteLiteral("\r\n\r\n    <script>\r\n        $(function () { FillGuestTable(); });\r\n        function FillGuestTable() {\r\n            \r\n\r\n            $.ajax({\r\n\r\n                url: \'");
#nullable restore
#line 104 "C:\Users\ahmet akpınar\Desktop\çalışmalar\kurumsal\CompanySiteV2\CompanySite\Views\BackSide\NewCustomer.cshtml"
                 Write(Url.Action("GetCustomersNew" , "BackSide"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                type: 'GET',
                success: function (data) {
                    console.log(data);
                    $('#CustomersTbl').DataTable(
                        {
                            ""bDestroy"": true,
                            ""responsive"": true, ""lengthChange"": false, ""autoWidth"": false,
                            ""bDestroy"": true,
                            order: [[1, ""desc""]],
                            data: data.data,
                            columns: [
                                {
                                    title: ""-"", data: 'id', 'render': function (data, row, meta) {
                                        //console.log(meta['answered']);
                                        if (meta['answered'] == 0) {
                                            console.log(""Sıfır"");
                                            return ""<button title=\""Görüntüle ve Cevapla\"" onclick=\""DetailModal("" +data+"")\""  data-toggle=\""modal\"" data-targe");
                WriteLiteral(@"t=\""#exampleModal\"" class=\""btn btn-warning\""><i class=\""fa fa-envelope\""></i> </button>"";
                                        } else {
                                            return ""<button class=\""btn btn-success\""> Cevaplandı </button>"";
                                        }

                                    }
                                },
                                {
                                    title: 'Tarih', data: 'createdDate', 'render': function (data) {

                                        if (data == null) {
                                            return ""-"";
                                        } else {
                                            return data;
                                        }
                                    }
                                },
                                { title: 'Ad', data: 'guestName' },
                                { title: 'Soyad', data: 'guestSurname' },
                        ");
                WriteLiteral(@"        { title: 'E-Posta', data: 'guestEmail' },
                                { title: 'Telefon', data: 'guestPhone' },
                                { title: 'Mesaj', data: 'guestMessage' }
                            ]
                        });

                }
                , error: function (data) { }
            });

        
        }


        function DetailModal(value) {
            document.getElementById('resultMail').style.display = ""none"";
            var customerName = document.getElementById('customerName');
            var customerPhone = document.getElementById('customerPhone');
            var customerMail = document.getElementById('customerMail');
            var CustomerMessageMdl = document.getElementById('CustomerMessageMdl');
            var registerId = document.getElementById('registerId');

            $.ajax({
                url: '");
#nullable restore
#line 163 "C:\Users\ahmet akpınar\Desktop\çalışmalar\kurumsal\CompanySiteV2\CompanySite\Views\BackSide\NewCustomer.cshtml"
                 Write(Url.Action("GetDataCustomer" , "BackSide"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                type: 'GET',
                data: { regId: value },
                success: function (data) {
                    if (data.success) {
                        console.log(data);
                        data = data.data;
                        registerId.value = data.id;
                        customerName.value = data.guestName + "" ""+ data.guestSurname;
                        customerPhone.value = data.guestPhone;
                        customerMail.value = data.guestEmail;
                        CustomerMessageMdl.innerHTML = data.guestMessage;

                        $('#exampleModal').modal('show');
                    } else {
                        swal({
                            title: data.resText,
                            icon: ""Error"",
                            button: ""Kapat"",
                        });
                    }
                },
                error: function (data) {

                    swal({
                        titl");
                WriteLiteral(@"e: data.resText,
                        icon: ""Error"",
                        button: ""Kapat"",
                    });
                }

            });

        }

        function SendAnswer() {

            var Email = {
                Subject:  $('#mailSubject').val(),
                MailContext:$('#AnswerText').val(),
                MailAddress: $('#customerMail').val(),
                RegisterId: $('#registerId').val()
            };

               $.ajax({
                url: '");
#nullable restore
#line 208 "C:\Users\ahmet akpınar\Desktop\çalışmalar\kurumsal\CompanySiteV2\CompanySite\Views\BackSide\NewCustomer.cshtml"
                 Write(Url.Action("SentMail" , "BackSide"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                type: 'post',
                data: { Email: Email },
                success: function (data) {
                    if (data.success) {
                        RemoveBoxMailModal();
                        document.getElementById('resultMail').style.display = ""inherit"";
                        document.getElementById('resultMail').innerHTML = data.resText;
                        FillGuestTable();
                        $('#exampleModal').modal('hide');
                    } else {
                        document.getElementById('resultMail').style.display = ""none"";
                        swal({
                            title: data.resText,
                            icon: ""Error"",
                            button: ""Kapat"",
                        });
                    }

                },
                   error: function (data) {
                       document.getElementById('resultMail').style.display = ""none"";
                       swal({
          ");
                WriteLiteral(@"                 title: data.resText,
                           icon: ""Error"",
                           button: ""Kapat"",
                       });

                   }

            });

        }


        function RemoveBoxMailModal() {
            $('#mailSubject').val('');
            $('#AnswerText').val('');
            $('#customerMail').val('');
        }



    </script>


");
            }
            );
            WriteLiteral("\r\n");
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
