#pragma checksum "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Shared\Components\WriterAbountOnDashboard\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cb62c8c3ea8712cdfda4b365433bcd974a56b25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_WriterAbountOnDashboard_Default), @"mvc.1.0.view", @"/Views/Shared/Components/WriterAbountOnDashboard/Default.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Shared\Components\WriterAbountOnDashboard\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cb62c8c3ea8712cdfda4b365433bcd974a56b25", @"/Views/Shared/Components/WriterAbountOnDashboard/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f365fb037698328c5339416bf793f3dd1f7f062", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_WriterAbountOnDashboard_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Writer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-12 grid-margin stretch-card\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <h4 class=\"card-title\">Recent Updates</h4>\r\n                <h1>Selam ");
#nullable restore
#line 9 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Shared\Components\WriterAbountOnDashboard\Default.cshtml"
                     Write(ViewBag.v);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 10 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Shared\Components\WriterAbountOnDashboard\Default.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"d-flex mt-5 align-items-top\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 446, "\"", 463, 1);
#nullable restore
#line 13 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Shared\Components\WriterAbountOnDashboard\Default.cshtml"
WriteAttributeValue("", 452, item.Image, 452, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-sm rounded-circle mr-3\" alt=\"image\">\r\n                        <div class=\"mb-0 flex-grow\">\r\n\r\n                            <h5 class=\"mr-2 mb-2\">");
#nullable restore
#line 16 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Shared\Components\WriterAbountOnDashboard\Default.cshtml"
                                             Write(item.WriterName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 16 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Shared\Components\WriterAbountOnDashboard\Default.cshtml"
                                                              Write(item.WriterSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p class=\"mb-0 font-weight-light\">");
#nullable restore
#line 17 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Shared\Components\WriterAbountOnDashboard\Default.cshtml"
                                                         Write(item.WriterAbout);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"ml-auto\">\r\n                            <i class=\"mdi mdi-heart-outline text-muted\"></i>\r\n                        </div>\r\n                    </div>");
#nullable restore
#line 22 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Shared\Components\WriterAbountOnDashboard\Default.cshtml"
                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Writer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
