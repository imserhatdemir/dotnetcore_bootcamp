#pragma checksum "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98569a5046763ff32b24f244eeaf215c60b3c3d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#line 1 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Blog\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98569a5046763ff32b24f244eeaf215c60b3c3d5", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f365fb037698328c5339416bf793f3dd1f7f062", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""banner"">
    <div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"">
        <ol class=""carousel-indicators"">
            <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
            <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li>
            <li data-target=""#carouselExampleIndicators"" data-slide-to=""2""></li>
            <li data-target=""#carouselExampleIndicators"" data-slide-to=""3""></li>
        </ol>
        <div class=""carousel-inner"" role=""listbox"">
            <div class=""carousel-item active"">
                <div class=""carousel-caption"">
                    <h3>
                        Create the lifestyle
                        <span>you desire</span>
                    </h3>
                    <div class=""read"">
                        <a href=""single.html"" class=""btn btn-primary read-m"">Read More</a>
                    </div>
                </div>
            </div>
            <");
            WriteLiteral(@"div class=""carousel-item item2"">
                <div class=""carousel-caption"">
                    <h3>
                        Engaging Purposeful
                        <span>and Creative</span>
                    </h3>
                    <div class=""read"">
                        <a href=""single.html"" class=""btn btn-primary read-m"">Read More</a>
                    </div>
                </div>
            </div>
            <div class=""carousel-item item3"">
                <div class=""carousel-caption"">
                    <h3>
                        Create the lifestyle
                        <span>you desire</span>
                    </h3>
                    <div class=""read"">
                        <a href=""single.html"" class=""btn btn-primary read-m"">Read More</a>
                    </div>
                </div>
            </div>
            <div class=""carousel-item item4"">
                <div class=""carousel-caption"">
                    <h3>
                     ");
            WriteLiteral(@"   Engaging Purposeful
                        <span>and Creative</span>
                    </h3>
                    <div class=""read"">
                        <a href=""single.html"" class=""btn btn-primary read-m"">Read More</a>
                    </div>
                </div>
            </div>
        </div>
        <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Previous</span>
        </a>
        <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Next</span>
        </a>
    </div>
</div>
<section class=""main-content-w3layouts-agileits"">
    <div class=""container"">
        <h3 class=""tittle"">Bloglar</h3>
        <div class=""inner-sec"">
            <!--left--");
            WriteLiteral(">\r\n            <div class=\"left-blog-info-w3layouts-agileits text-left\">\r\n                <div class=\"row\">\r\n");
#nullable restore
#line 79 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Blog\Index.cshtml"
                     if (Model.Count < 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-4 alert alert-danger\">\r\n                            <p>Henüz bir blog yazısı bulunmamaktadır</p>\r\n                        </div>\r\n                        <br />\r\n");
#nullable restore
#line 85 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Blog\Index.cshtml"
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Blog\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-lg-4 card\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 3835, "\"", 3872, 2);
            WriteAttributeValue("", 3842, "/Blog/BlogReadAll/", 3842, 18, true);
#nullable restore
#line 91 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Blog\Index.cshtml"
WriteAttributeValue("", 3860, item.BlogID, 3860, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 3916, "\"", 3933, 1);
#nullable restore
#line 92 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Blog\Index.cshtml"
WriteAttributeValue("", 3922, item.Image, 3922, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 3965, "\"", 3971, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </a>

                                <div class=""card-body"">
                                    <ul class=""blog-icons my-4"">
                                        <li>
                                            <a href=""#"">
                                                <i class=""far fa-calendar-alt""></i> ");
#nullable restore
#line 99 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Blog\Index.cshtml"
                                                                                Write(((DateTime)item.CreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </a>\r\n\r\n                                        </li>\r\n                                        <li>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 4573, "\"", 4580, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <i class=\"fas fa-eye\"></i>");
#nullable restore
#line 105 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Blog\Index.cshtml"
                                                                     Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </a>\r\n                                        </li>\r\n                                        <li>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 4876, "\"", 4883, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                <i class=""fas fa-cloud""></i>0
                                            </a>
                                        </li>
                                    </ul>
                                    <h5 class=""card-title"">
                                        <a");
            BeginWriteAttribute("href", " href=\"", 5209, "\"", 5246, 2);
            WriteAttributeValue("", 5216, "/Blog/BlogReadAll/", 5216, 18, true);
#nullable restore
#line 115 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Blog\Index.cshtml"
WriteAttributeValue("", 5234, item.BlogID, 5234, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 115 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Blog\Index.cshtml"
                                                                            Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    </h5>\r\n                                    <p class=\"card-text mb-3\">");
#nullable restore
#line 117 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Blog\Index.cshtml"
                                                         Write(item.Content.Substring(0, item.Content.Substring(0, 100).LastIndexOf(" ")));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ...</p>\r\n                                    <a href=\"#\" class=\"btn btn-primary read-m\">Devamını Oku</a>\r\n                                </div>\r\n                            </div>");
#nullable restore
#line 120 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Blog\Index.cshtml"
                                  }

#line default
#line hidden
#nullable disable
#nullable restore
#line 120 "C:\Users\Serhat Demir\Desktop\Bootcamp\Core_Bootcamp\Views\Blog\Index.cshtml"
                                   }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n                <!--//left-->\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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