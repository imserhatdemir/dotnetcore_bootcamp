#pragma checksum "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Message\IndBox.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23e0b381527cd0831473f8199928abd395c1c7e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_IndBox), @"mvc.1.0.view", @"/Views/Message/IndBox.cshtml")]
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
#line 1 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Message\IndBox.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23e0b381527cd0831473f8199928abd395c1c7e0", @"/Views/Message/IndBox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f365fb037698328c5339416bf793f3dd1f7f062", @"/Views/_ViewImports.cshtml")]
    public class Views_Message_IndBox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Message2>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Message\IndBox.cshtml"
  
    ViewData["Title"] = "IndBox";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>IndBox</h1>
<a href=""#"" class=""btn btn-primary"">+ Yeni Mesaj</a>
<table class=""table table-bordered"">
    <tr>
        <th>#</th>
        <th>Başlık</th>
        <th>Tarih</th>
        <th>Kategori</th>
        <th>Durum</th>
        <th>İŞLEMLER</th>
    </tr>
");
#nullable restore
#line 19 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Message\IndBox.cshtml"
     if (Model.Count < 1)
    {



#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-danger\">\r\n            <p>Henüz Mesajınız bulunmamaktadır</p>\r\n        </div>\r\n");
#nullable restore
#line 26 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Message\IndBox.cshtml"
    }
    else
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Message\IndBox.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Message\IndBox.cshtml"
               Write(item.MessageID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Message\IndBox.cshtml"
               Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Message\IndBox.cshtml"
                Write(((DateTime)item.MessageDate).ToString("dd-MMM-yyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Message\IndBox.cshtml"
               Write(item.SenderUser.WriterName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Message\IndBox.cshtml"
               Write(item.MessageStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 949, "\"", 995, 2);
            WriteAttributeValue("", 956, "/Message/MessageDetails/", 956, 24, true);
#nullable restore
#line 37 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Message\IndBox.cshtml"
WriteAttributeValue("", 980, item.MessageID, 980, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">DETAY</a> || <a");
            BeginWriteAttribute("href", " href=\"", 1033, "\"", 1078, 2);
            WriteAttributeValue("", 1040, "/Message/DeleteMessage/", 1040, 23, true);
#nullable restore
#line 37 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Message\IndBox.cshtml"
WriteAttributeValue("", 1063, item.MessageID, 1063, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return confirm(\'Silmek istediğine emin misin?\');\" class=\"btn btn-danger\">SİL</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 39 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Message\IndBox.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Message\IndBox.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Message2>> Html { get; private set; }
    }
}
#pragma warning restore 1591
