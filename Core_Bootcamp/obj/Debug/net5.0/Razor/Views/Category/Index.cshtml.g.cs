#pragma checksum "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7631da50c3a62b9f64ad856a5a87d37de72eda5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
#line 1 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Category\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7631da50c3a62b9f64ad856a5a87d37de72eda5", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f365fb037698328c5339416bf793f3dd1f7f062", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Kategori Adı</th>\r\n        <th>İşlemler</th>\r\n    </tr>\r\n    <tr>\r\n");
#nullable restore
#line 15 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Category\Index.cshtml"
         if (Model.Count < 1)
        {



#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"alert alert-danger\">\r\n            <p>KATEGORİ BULUNMUYOR</p>\r\n        </div>\r\n");
#nullable restore
#line 22 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Category\Index.cshtml"
        }
        else
        {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Category\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <td>");
#nullable restore
#line 27 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Category\Index.cshtml"
       Write(item.CategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 28 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Category\Index.cshtml"
       Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td><a");
            BeginWriteAttribute("href", " href=\"", 565, "\"", 572, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">SİL</a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 616, "\"", 623, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Güncelle</a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 673, "\"", 680, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">Detay</a>\r\n        \r\n        </td>\r\n");
#nullable restore
#line 34 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Category\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Category\Index.cshtml"
         }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tr>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
