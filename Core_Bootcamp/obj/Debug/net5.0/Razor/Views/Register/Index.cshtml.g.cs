#pragma checksum "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Register\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "040faaf2795958afc506e3d2149256ec9dbdffe7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Register_Index), @"mvc.1.0.view", @"/Views/Register/Index.cshtml")]
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
#line 1 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\_ViewImports.cshtml"
using Core_Bootcamp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\_ViewImports.cshtml"
using Core_Bootcamp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"040faaf2795958afc506e3d2149256ec9dbdffe7", @"/Views/Register/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f365fb037698328c5339416bf793f3dd1f7f062", @"/Views/_ViewImports.cshtml")]
    public class Views_Register_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Writer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Register\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<script src=\"https://unpkg.com/sweetalert/dist/sweetalert.min.js\"></script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "040faaf2795958afc506e3d2149256ec9dbdffe73821", async() => {
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
            WriteLiteral(@"
<!--/banner-->
<div class=""banner-inner"">
</div>
<ol class=""breadcrumb"">
    <li class=""breadcrumb-item"">
        <a href=""index.html"">Home</a>
    </li>
    <li class=""breadcrumb-item active"">Register</li>
</ol>
<!--//banner-->
<!--/main-->
<section class=""main-content-w3layouts-agileits"">
    <div class=""container"">
        <h3 class=""tittle"">Register Now</h3>
        <div class=""inner-sec"">
            <div class=""login p-5 bg-light mx-auto mw-100"">
");
#nullable restore
#line 24 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Register\Index.cshtml"
                using (Html.BeginForm("Index", "Register", FormMethod.Post))
               {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"form-row\">\r\n                        <div class=\"col-md-6 mb-3\">\r\n                            <label for=\"validationCustom01\">Ad</label>\r\n\r\n");
            WriteLiteral("                            ");
#nullable restore
#line 31 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Register\Index.cshtml"
                       Write(Html.TextBoxFor(x => x.WriterName,new {@class="form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 32 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Register\Index.cshtml"
                       Write(Html.ValidationMessageFor(x => x.WriterName,"", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-6 mb-3\">\r\n                            <label for=\"validationCustom02\">Soyad</label>\r\n                            ");
#nullable restore
#line 36 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Register\Index.cshtml"
                       Write(Html.TextBoxFor(x => x.WriterSurname, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 37 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Register\Index.cshtml"
                       Write(Html.ValidationMessageFor(x => x.WriterSurname, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""form-row"">
                        <div class=""col-md-6 mb-3"">
                            <label for=""validationCustom01"">Mail</label>

                            ");
#nullable restore
#line 44 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Register\Index.cshtml"
                       Write(Html.TextBoxFor(x => x.WriterMail, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 45 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Register\Index.cshtml"
                       Write(Html.ValidationMessageFor(x => x.WriterMail, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-6 mb-3\">\r\n                            <label for=\"validationCustom02\">Görsel Dosya Yolu</label>\r\n                            ");
#nullable restore
#line 49 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Register\Index.cshtml"
                       Write(Html.TextBoxFor(x=>x.Image, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""form-row"">
                        <div class=""form-group col-md-6"">
                            <label for=""exampleInputPassword1 mb-2"">Password</label>
                            ");
#nullable restore
#line 55 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Register\Index.cshtml"
                       Write(Html.TextBoxFor(x => x.Password, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 56 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Register\Index.cshtml"
                       Write(Html.ValidationMessageFor(x => x.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n");
            WriteLiteral(@"
                    </div>
                    <button type=""submit"" class=""btn btn-primary submit mb-4"">Kayıt Ol</button>
                    <p>
                        <a href=""#"" id=""btn1"">Şartları okudum kabul ediyorum</a>
                    </p>
");
#nullable restore
#line 68 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Register\Index.cshtml"
               }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>
    </div>
    <script>
        $('#btn1').click(function () {
            swal(""Sitemiz mail adresinden bilgi ve haber e postalarını spam ölçüsüne varmadan gönderilmeye devam edilecektir. eğer eposta bülteninden çıkmak isterseniz mail ileti dizisini durdurabilirsiniz. şifre ve mail adreslerniz şifrelenmiş formatta herhangi bir kullanıcının görmeyeceği şekilde saklanır"");
        });
    </script>
</section>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Writer> Html { get; private set; }
    }
}
#pragma warning restore 1591