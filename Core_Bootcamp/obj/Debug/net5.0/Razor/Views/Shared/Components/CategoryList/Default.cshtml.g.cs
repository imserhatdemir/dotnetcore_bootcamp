#pragma checksum "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Shared\Components\CategoryList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff63b2572cc26db578c369629a7ec8fc207883c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategoryList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff63b2572cc26db578c369629a7ec8fc207883c0", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f365fb037698328c5339416bf793f3dd1f7f062", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CategoryList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"tech-btm\">\r\n    <h4>Categories</h4>\r\n    <ul class=\"list-group single\">\r\n");
#nullable restore
#line 6 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Shared\Components\CategoryList\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"list-group-item d-flex justify-content-between align-items-center\">\r\n            ");
#nullable restore
#line 9 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Shared\Components\CategoryList\Default.cshtml"
       Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <span class=\"badge badge-primary badge-pill\">0</span>\r\n        </li>\r\n");
#nullable restore
#line 12 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Shared\Components\CategoryList\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
