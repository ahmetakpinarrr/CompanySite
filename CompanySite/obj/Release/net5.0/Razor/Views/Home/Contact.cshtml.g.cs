#pragma checksum "C:\Users\90538\source\repos\CompanySite\CompanySite\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "231e042b01706daea0b13347869d6d42ce9bf828"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
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
#line 1 "C:\Users\90538\source\repos\CompanySite\CompanySite\Views\_ViewImports.cshtml"
using CompanySite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\90538\source\repos\CompanySite\CompanySite\Views\_ViewImports.cshtml"
using CompanySite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"231e042b01706daea0b13347869d6d42ce9bf828", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7073ad1d25b071c5afe6ec0ab130a591298c61b5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\90538\source\repos\CompanySite\CompanySite\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!--hero section start-->

<section class=""page-title position-relative overflow-hidden shape-1 right"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-8"">
                <div class=""bg-white p-md-5 p-3 d-inline-block"">
                    <h1 class=""font-w-3 mb-4""><span class=""text-primary font-w-5"">??leti??im</span> </h1>
                    <nav aria-label=""breadcrumb"">
                        <ol class=""breadcrumb"">
                            <li class=""breadcrumb-item"">
                                <a");
            BeginWriteAttribute("href", " href=\"", 607, "\"", 641, 1);
#nullable restore
#line 16 "C:\Users\90538\source\repos\CompanySite\CompanySite\Views\Home\Contact.cshtml"
WriteAttributeValue("", 614, Url.Action("Index","Home"), 614, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><i class=""las la-home me-1""></i>Ana sayfa</a>
                            </li>
                            <li class=""breadcrumb-item active"" aria-current=""page"">??leti??im</li>
                        </ol>
                    </nav>
                </div>
            </div>
        </div>
    </div>
    <canvas id=""canvas-1""></canvas>
</section>


<section>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-4 col-md-6"">
                <div class=""d-flex align-items-center contact-media style-2 bg-white box-shadow rounded p-4"">
                    <div class=""me-3"">
                        <i class=""las la-map-pin""></i>
                    </div>
                    <div>
                        <h5 class=""mb-2"">Ofis</h5>
                        <span>??ekmek??y, ??stanbul</span>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-md-6 mt-5 mt-md-0"">
                <div class=""d-flex align-items");
            WriteLiteral(@"-center contact-media style-2 bg-white box-shadow rounded p-4"">
                    <div class=""me-3"">
                        <i class=""las la-envelope-open-text""></i>
                    </div>
                    <div>
                        <h5 class=""mb-2"">Email address</h5>
                        <a href=""mailto:info@opalfa.com""> info@opalfa.com</a>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-md-6 mt-5 mt-lg-0"">
                <div class=""d-flex align-items-center contact-media style-2 bg-white box-shadow rounded p-4"">
                    <div class=""me-3"">
                        <i class=""las la-phone-volume""></i>
                    </div>
                    <div>
                        <h5 class=""mb-2"">Phone number</h5>
                        <a href=""tel:+905389158366"">+90-538-915-8366</a>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row mt-8 justify-c");
            WriteLiteral(@"ontent-center text-center"">
            <div class=""col-lg-8"">
                <div class=""mb-5"">
                    <h6 class=""font-w-5 mb-3 position-relative py-1 px-3 text-primary rounded subtitle-effect box-shadow d-inline-block"">
                        <span>Mesaj B??rak??n</span>
                    </h6>
                    <h2 class=""mb-0""><span class=""font-w-5 d-block"">Bize ileti??im bilgilerinizi ve </span> Mesaj??n??z?? b??rak??n</h2>
                </div>
                
                    <div class=""messages""></div>
                    <div class=""col-md-12""  style=""display:flex; flex-direction:row; padding:0px;"">
                        <div class=""col-md-6 mb-3"">
                            <input id=""form_name"" type=""text"" name=""name"" class=""form-control"" placeholder=""Ad"" required>
                        </div>
                        <div class=""col-md-6 mb-3"">
                            <input id=""form_name1"" type=""text"" name=""name"" class=""form-control"" placeholder=""Soyad"" req");
            WriteLiteral(@"uired>
                        </div>
                    </div>
                    <div class=""col-md-12"" style=""display: flex; flex-direction: row; padding: 0px;"">
                        <div class=""col-md-6 mb-3"">
                            <input id=""form_email"" type=""email"" name=""email"" class=""form-control"" placeholder=""E-Posta"" required>
                        </div>
                        <div class=""col-md-6 mb-3"">
                            <input id=""form_phone"" type=""text"" name=""form_phone"" class=""form-control"" placeholder=""Telefon"" required>
                        </div>
                    </div>
                    <div class=""col-md-12"">
                        <textarea id=""form_message"" name=""message"" class=""form-control h-auto"" placeholder=""Mesaj"" rows=""4"" required></textarea>
                    </div>
                    <div class=""col mt-5"">
                        <button class=""btn btn-primary"" onclick=""SendMessage()"">Mesaj?? G??nder</button>
                    </");
            WriteLiteral(@"div>
                
            </div>
        </div>
    </div>
</section>
<!--contact form end-->
<!--map start-->

<section class=""overflow-hidden pt-0"">
    <div class=""container-fluid p-0"">
        <div class=""row"">
            <div class=""col"">
                <div class=""map"">
");
            WriteLiteral(@"                    <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d96250.33103905164!2d29.126228798370484!3d41.07286488752268!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14cad2e51ddddf97%3A0xee27abe63246e12a!2zw4dla21la8O2eS_EsHN0YW5idWw!5e0!3m2!1str!2str!4v1662285989427!5m2!1str!2str"" style=""border:0;""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 5715, "\"", 5733, 0);
            EndWriteAttribute();
            WriteLiteral(" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n<!--map end-->\r\n\r\n");
            DefineSection("pageFooterScript", async() => {
                WriteLiteral(@"
    <script>

        function SendMessage() {
            console.log(NullControl());
            if (!NullControl()) {

            } else {
                var newGuest = {
                    GuestName: $('#form_name').val(),
                    GuestSurname: $('#form_name1').val(),
                    GuestEmail: $('#form_email').val(),
                    GuestPhone: $('#form_phone').val(),
                    GuestMessage: $('#form_message').val(),
                };
                console.log(newGuest);
                 $.ajax({
                     url: '");
#nullable restore
#line 138 "C:\Users\90538\source\repos\CompanySite\CompanySite\Views\Home\Contact.cshtml"
                      Write(Url.Action("NewCustomerProcess" , "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                     type: 'Post',
                     data: { newCustomer: newGuest  },
                    // contentType:""application/json"",
                     success: function (data) {
                         console.log(data);
                         if (data.success) {
                             swal({
                                 title: data.resText,
                                 icon: ""success"",
                                 button: ""Kapat"",
                             });
                         } else {
                             console.log(""-"",data);
                             swal({
                                 title: ""Bir sorunla kar????la??t??k!"",
                                 text: data.resText,
                                 icon: ""error"",
                                 button: ""Kapat"",
                             });
                         }
                     },
                     error: function (data) {
                      ");
                WriteLiteral(@"   console.log(""---"",data);
                            swal({
                                title: ""Bir sorunla kar????la??t??k!"",
                                text: data.resText,
                                icon: ""error"",
                                button: ""Kapat"",
                            });
                      }
                 });
            }


        }

        function NullControl() {
            var isValid = false;
            let numReg = /[0-9]/g;
            var resText = """";
            console.log($('#form_name').val());
            if (($('#form_name').val().trim() === """" || $('#form_name1').val().trim() === """") &&( $('#form_message').val().trim() === """" || $('#form_message').val().trim() === null) ) {
                isValid = false;
                resText += ""Alanlar?? bo?? b??rakmay??n??z."";
            }
            if (validateEmail($('#form_email').val()) || $('#form_phone').val().match(numReg)) {
                isValid = true;

            } els");
                WriteLiteral(@"e {
                resText += ""\n Ge??ersiz E-Posta veya Telefon!"";
            }
            if (!isValid) {
                swal({
                    title: resText ,
                    icon: ""error"",
                    button: ""Kapat"",
                });
            }


            return isValid;
        }
        const validateEmail = (email) => {
            return email.match(
                /^(([^<>()[\]\\.,;:\s");
                WriteLiteral("@\\\"]+(\\.[^<>()[\\]\\\\.,;:\\s");
                WriteLiteral("@\\\"]+)*)|(\\\".+\\\"))");
                WriteLiteral(@"@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/
            );
        };

        $('input[name=""form_phone""]').keyup(function (e) {
            if (/\D/g.test(this.value)) {
                // Filter non-digits from input value.
                this.value = this.value.replace(/\D/g, '');
            }
        });



    </script>
");
            }
            );
            WriteLiteral("\r\n\r\n");
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
