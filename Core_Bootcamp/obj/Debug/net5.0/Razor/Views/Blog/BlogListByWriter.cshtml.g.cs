#pragma checksum "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Blog\BlogListByWriter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96e740f0ca29c2e2bd81db955402863c78d99e48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogListByWriter), @"mvc.1.0.view", @"/Views/Blog/BlogListByWriter.cshtml")]
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
#line 1 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Blog\BlogListByWriter.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96e740f0ca29c2e2bd81db955402863c78d99e48", @"/Views/Blog/BlogListByWriter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f365fb037698328c5339416bf793f3dd1f7f062", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_BlogListByWriter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Blog\BlogListByWriter.cshtml"
  
    ViewData["Title"] = "BlogListByWriter";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>BlogListByWriter</h1>\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Başlık</th>\r\n        <th>Tarih</th>\r\n        <th>Kategori</th>\r\n        <th>Durum</th>\r\n        <th>İŞLEMLER</th>\r\n    </tr>\r\n");
#nullable restore
#line 18 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Blog\BlogListByWriter.cshtml"
     if (Model.Count < 1)
    {



#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"alert alert-danger\">\r\n        <p>Henüz bloğunuz bulunmamaktadır</p>\r\n    </div>\r\n");
#nullable restore
#line 25 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Blog\BlogListByWriter.cshtml"
    }
    else
    {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Blog\BlogListByWriter.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 31 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Blog\BlogListByWriter.cshtml"
       Write(item.BlogID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 32 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Blog\BlogListByWriter.cshtml"
       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 33 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Blog\BlogListByWriter.cshtml"
        Write(((DateTime)item.CreateDate).ToString("dd-MMM-yyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 34 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Blog\BlogListByWriter.cshtml"
       Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 35 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Blog\BlogListByWriter.cshtml"
       Write(item.BlogStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td><a");
            BeginWriteAttribute("href", " href=\"", 821, "\"", 855, 2);
            WriteAttributeValue("", 828, "/Blog/EditBlog/", 828, 15, true);
#nullable restore
#line 36 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Blog\BlogListByWriter.cshtml"
WriteAttributeValue("", 843, item.BlogID, 843, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">GÜNCELLE</a> || <a");
            BeginWriteAttribute("href", " href=\"", 896, "\"", 932, 2);
            WriteAttributeValue("", 903, "/Blog/DeleteBlog/", 903, 17, true);
#nullable restore
#line 36 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Blog\BlogListByWriter.cshtml"
WriteAttributeValue("", 920, item.BlogID, 920, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return confirm(\'Silmek istediğine emin misin?\');\" class=\"btn btn-danger\">SİL</a></td>\r\n    </tr>");
#nullable restore
#line 37 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Blog\BlogListByWriter.cshtml"
         }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Blog\BlogListByWriter.cshtml"
          
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
