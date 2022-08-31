#pragma checksum "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Writer\WriterNavbar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cb85b0a8bebcd9366b0a6c813bdefd28d644be8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Writer_WriterNavbar), @"mvc.1.0.view", @"/Views/Writer/WriterNavbar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cb85b0a8bebcd9366b0a6c813bdefd28d644be8", @"/Views/Writer/WriterNavbar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f365fb037698328c5339416bf793f3dd1f7f062", @"/Views/_ViewImports.cshtml")]
    public class Views_Writer_WriterNavbar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<nav class=""sidebar sidebar-offcanvas"" id=""sidebar"">
    <ul class=""nav"">
        <li class=""nav-item nav-profile"">
            <a href=""#"" class=""nav-link"">
                <div class=""nav-profile-image"">
                    <img src=""/writer/assets/images/faces/face1.jpg"" alt=""profile"">
                    <span class=""login-status online""></span>
                    <!--change to offline or busy as needed-->
                </div>
                <div class=""nav-profile-text d-flex flex-column"">
                    <span class=""font-weight-bold mb-2"">Yazar Adı Soyadı</span>
                    <span class=""text-secondary text-small"">Unvan</span>
                </div>
                <i class=""mdi mdi-bookmark-check text-success nav-profile-badge""></i>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Dashboard/Index/"">
                <span class=""menu-title"">Dashboard</span>
                <i class=""mdi mdi-home menu-icon""></i>
      ");
            WriteLiteral(@"      </a>
        </li>

        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Writer/WriterEditProfile/"">
                <span class=""menu-title"">Profilim</span>
                <i class=""mdi mdi-contacts menu-icon""></i>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Blog/Add"">
                <span class=""menu-title"">Bloglarım</span>
                <i class=""mdi mdi-format-list-bulleted menu-icon""></i>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Writter/WritterMessage/"">
                <span class=""menu-title"">Mesajlar</span>
                <i class=""mdi mdi-chart-bar menu-icon""></i>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Notification/AllNotifications/"">
                <span class=""menu-title"">Bildirimler</span>
                <i class=""mdi mdi-notification-clear-all menu-icon""></i>
           ");
            WriteLiteral(@" </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Blog/Index/"">
                <span class=""menu-title"">Siteye Git</span>
                <i class=""mdi mdi-table-large menu-icon""></i>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" data-toggle=""collapse"" href=""#general-pages"" aria-expanded=""false"" aria-controls=""general-pages"">
                <span class=""menu-title"">Yorumlar</span>
                <i class=""menu-arrow""></i>
                <i class=""mdi mdi-medical-bag menu-icon""></i>
            </a>
            <div class=""collapse"" id=""general-pages"">
                <ul class=""nav flex-column sub-menu"">
                    <li class=""nav-item""> <a class=""nav-link"" href=""../../pages/samples/blank-page.html""> Onaylı Yorumlar </a></li>
                    <li class=""nav-item""> <a class=""nav-link"" href=""../../pages/samples/login.html""> Onay Bekleyen Yorumlar </a></li>
                </ul>
            </d");
            WriteLiteral(@"iv>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Blog/Index/"">
                <span class=""menu-title"">Siteye Git</span>
                <i class=""mdi mdi-settings-box menu-icon""></i>
            </a>
        </li>
        <li class=""nav-item sidebar-actions"">
            <span class=""nav-link"">
                <div class=""border-bottom"">
                    <h6 class=""font-weight-normal mb-3"">YENİ BLOG YAZ</h6>
                </div>
                <a href=""/Blog/AddBlog"" class=""btn btn-block btn-lg btn-gradient-primary mt-4"">+ Yeni Blog Ekle</a>

            </span>
        </li>
    </ul>
</nav>");
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
