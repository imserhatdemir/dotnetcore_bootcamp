#pragma checksum "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87b7946c35d1a212a35e9e6012f7c414b2519e20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index), @"mvc.1.0.view", @"/Views/Dashboard/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87b7946c35d1a212a35e9e6012f7c414b2519e20", @"/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f365fb037698328c5339416bf793f3dd1f7f062", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content-wrapper"">
    <div class=""page-header"">
        <h3 class=""page-title"">
            <span class=""page-title-icon bg-gradient-primary text-white mr-2"">
                <i class=""mdi mdi-home""></i>
            </span> Dashboard
        </h3>
        <nav aria-label=""breadcrumb"">
            <ul class=""breadcrumb"">
                <li class=""breadcrumb-item active"" aria-current=""page"">
                    <span></span>Overview <i class=""mdi mdi-alert-circle-outline icon-sm text-primary align-middle""></i>
                </li>
            </ul>
        </nav>
    </div>
    
    <div class=""row"">
        <div class=""col-md-4 stretch-card grid-margin"">
            <div class=""card bg-gradient-danger card-img-holder text-white"">
                <div class=""card-body"">
                    <img src=""/writer/assets/images/dashboard/circle.svg"" class=""card-img-absolute"" alt=""circle-image"" />
                    <h4 class=""font-weight-normal mb-3"">
                        Site");
            WriteLiteral("deki Blog Sayısı <i class=\"mdi mdi-chart-line mdi-24px float-right\"></i>\r\n                    </h4>\r\n                    <h2 class=\"mb-5\">");
#nullable restore
#line 31 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Dashboard\Index.cshtml"
                                Write(ViewBag.V1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
            WriteLiteral(@"                </div>
            </div>
        </div>
        <div class=""col-md-4 stretch-card grid-margin"">
            <div class=""card bg-gradient-info card-img-holder text-white"">
                <div class=""card-body"">
                    <img src=""/writer/assets/images/dashboard/circle.svg"" class=""card-img-absolute"" alt=""circle-image"" />
                    <h4 class=""font-weight-normal mb-3"">
                        Sizin blog sayınız<i class=""mdi mdi-bookmark-outline mdi-24px float-right""></i>
                    </h4>
                    <h2 class=""mb-5"">");
#nullable restore
#line 43 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Dashboard\Index.cshtml"
                                Write(ViewBag.V2);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                </div>
            </div>
        </div>
        <div class=""col-md-4 stretch-card grid-margin"">
            <div class=""card bg-gradient-success card-img-holder text-white"">
                <div class=""card-body"">
                    <img src=""/writer/assets/images/dashboard/circle.svg"" class=""card-img-absolute"" alt=""circle-image"" />
                    <h4 class=""font-weight-normal mb-3"">
                        Toplam Kategori sayısı <i class=""mdi mdi-diamond mdi-24px float-right""></i>
                    </h4>
                    <h2 class=""mb-5"">");
#nullable restore
#line 54 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Dashboard\Index.cshtml"
                                Write(ViewBag.V3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    ");
#nullable restore
#line 59 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Dashboard\Index.cshtml"
Write(await Component.InvokeAsync("BlogListDashboard"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 60 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Dashboard\Index.cshtml"
Write(await Component.InvokeAsync("WriterAbountOnDashboard"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n    ");
#nullable restore
#line 63 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Dashboard\Index.cshtml"
Write(await Component.InvokeAsync("CategoryDashboardList"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n    <!-- content-wrapper ends -->\r\n    <!-- partial:partials/_footer.html -->\r\n\r\n<script src=\"/writer/assets/js/dashboard.js\"></script>\r\n\r\n");
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
