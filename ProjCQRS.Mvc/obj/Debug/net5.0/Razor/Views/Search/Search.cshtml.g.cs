#pragma checksum "C:\Users\MONSTER\source\repos\ProjCQRS\ProjCQRS.Mvc\Views\Search\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9991284b6b331a6d04e00e0ecb24b7b50da7b52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_Search), @"mvc.1.0.view", @"/Views/Search/Search.cshtml")]
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
#line 1 "C:\Users\MONSTER\source\repos\ProjCQRS\ProjCQRS.Mvc\Views\_ViewImports.cshtml"
using ProjCQRS.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\MONSTER\source\repos\ProjCQRS\ProjCQRS.Mvc\Views\Search\Search.cshtml"
using ProjCQRS.Mvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9991284b6b331a6d04e00e0ecb24b7b50da7b52", @"/Views/Search/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46443aca69b50dde6d2879cbe3b0b4edcd77abef", @"/Views/_ViewImports.cshtml")]
    public class Views_Search_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\MONSTER\source\repos\ProjCQRS\ProjCQRS.Mvc\Views\Search\Search.cshtml"
  
    var products = ViewBag.Products as List<Product>;
    var categories = ViewBag.Categories as List<Category>;
    var searchkeyword = ViewBag.SearchKeyword;
    ViewData["Title"] = "Search List";
    int count = 0;
    int count1 = 0;


#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Product List Welcome</h1>\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12 mt-3\">\r\n");
#nullable restore
#line 16 "C:\Users\MONSTER\source\repos\ProjCQRS\ProjCQRS.Mvc\Views\Search\Search.cshtml"
             if (products != null && products.Count() > 0)
            {
                string title = "-";
                string desc = "-";
                int qua = 0;
                string catName = "-";

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h4>Result for \"");
#nullable restore
#line 22 "C:\Users\MONSTER\source\repos\ProjCQRS\ProjCQRS.Mvc\Views\Search\Search.cshtml"
                           Write(searchkeyword);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" of Product</h4>\r\n");
            WriteLiteral(@"                <div class=""table-responsive"">
                    <table id=""mytable"" class=""table table-bordred table-striped"">
                        <thead>
                            <tr>
                                <th scope=""col"">#</th>
                                <th scope=""col"">Title</th>
                                <th scope=""col"">Description</th>
                                <th scope=""col"">Quantity</th>
                                <th scope=""col"">Category</th>
                                <th scope=""col"">#</th>
                                <th scope=""col"">#</th>
                                <th scope=""col"">#</th>
                            </tr>
                        </thead>

                        <tbody>
");
#nullable restore
#line 40 "C:\Users\MONSTER\source\repos\ProjCQRS\ProjCQRS.Mvc\Views\Search\Search.cshtml"
                             foreach (var item in products)
                            {
                                if (item.Title != null)
                                {
                                    title = item.Title;
                                }

                                if (item.Description != null)
                                {
                                    desc = item.Description;
                                }

                                if (item.Quantity > 0)
                                {
                                    qua = item.Quantity;
                                }

                                if (item.Category != null)
                                {
                                    catName = item.Category.CategoryName;
                                }
                                count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 63 "C:\Users\MONSTER\source\repos\ProjCQRS\ProjCQRS.Mvc\Views\Search\Search.cshtml"
                                   Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 64 "C:\Users\MONSTER\source\repos\ProjCQRS\ProjCQRS.Mvc\Views\Search\Search.cshtml"
                                   Write(title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 65 "C:\Users\MONSTER\source\repos\ProjCQRS\ProjCQRS.Mvc\Views\Search\Search.cshtml"
                                   Write(desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 66 "C:\Users\MONSTER\source\repos\ProjCQRS\ProjCQRS.Mvc\Views\Search\Search.cshtml"
                                   Write(qua);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 67 "C:\Users\MONSTER\source\repos\ProjCQRS\ProjCQRS.Mvc\Views\Search\Search.cshtml"
                                   Write(catName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td><a");
            BeginWriteAttribute("href", " href=\"", 2715, "\"", 2746, 2);
            WriteAttributeValue("", 2722, "/Update-Product/", 2722, 16, true);
#nullable restore
#line 68 "C:\Users\MONSTER\source\repos\ProjCQRS\ProjCQRS.Mvc\Views\Search\Search.cshtml"
WriteAttributeValue("", 2738, item.Id, 2738, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-sm\" data-title=\"Edit\">Edit</a></td>\r\n                                    <td><a");
            BeginWriteAttribute("href", " href=\"", 2854, "\"", 2885, 2);
            WriteAttributeValue("", 2861, "/Product-Detail/", 2861, 16, true);
#nullable restore
#line 69 "C:\Users\MONSTER\source\repos\ProjCQRS\ProjCQRS.Mvc\Views\Search\Search.cshtml"
WriteAttributeValue("", 2877, item.Id, 2877, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning btn-sm\" data-title=\"Info\">Info</a></td>\r\n                                    <td><a");
            BeginWriteAttribute("href", " href=\"", 2993, "\"", 3024, 2);
            WriteAttributeValue("", 3000, "/Delete-Product/", 3000, 16, true);
#nullable restore
#line 70 "C:\Users\MONSTER\source\repos\ProjCQRS\ProjCQRS.Mvc\Views\Search\Search.cshtml"
WriteAttributeValue("", 3016, item.Id, 3016, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-sm\" data-title=\"Delete\">Delete</a></td>\r\n                                </tr>\r\n");
#nullable restore
#line 72 "C:\Users\MONSTER\source\repos\ProjCQRS\ProjCQRS.Mvc\Views\Search\Search.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n");
#nullable restore
#line 76 "C:\Users\MONSTER\source\repos\ProjCQRS\ProjCQRS.Mvc\Views\Search\Search.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 78 "C:\Users\MONSTER\source\repos\ProjCQRS\ProjCQRS.Mvc\Views\Search\Search.cshtml"
             if (categories != null && categories.Count() > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h4>Result for \"");
#nullable restore
#line 80 "C:\Users\MONSTER\source\repos\ProjCQRS\ProjCQRS.Mvc\Views\Search\Search.cshtml"
                           Write(searchkeyword);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" of Categories</h4>
                <div class=""table-responsive"">
                    <table id=""mytable"" class=""table table-bordred table-striped"">
                        <thead>
                            <tr>
                                <th scope=""col"">#</th>
                                <th scope=""col"">Category Name</th>
                                <th scope=""col"">Min. Stock Quantity</th>
                                <th scope=""col"">Total Product</th>
                                <th scope=""col"">#</th>
                                <th scope=""col"">#</th>
                                <th scope=""col"">#</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 95 "C:\Users\MONSTER\source\repos\ProjCQRS\ProjCQRS.Mvc\Views\Search\Search.cshtml"
                             foreach (var item in categories)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 98 "C:\Users\MONSTER\source\repos\ProjCQRS\ProjCQRS.Mvc\Views\Search\Search.cshtml"
                                   Write(count1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 99 "C:\Users\MONSTER\source\repos\ProjCQRS\ProjCQRS.Mvc\Views\Search\Search.cshtml"
                                   Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 100 "C:\Users\MONSTER\source\repos\ProjCQRS\ProjCQRS.Mvc\Views\Search\Search.cshtml"
                                   Write(item.MinStockQuantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 101 "C:\Users\MONSTER\source\repos\ProjCQRS\ProjCQRS.Mvc\Views\Search\Search.cshtml"
                                   Write(item.Products.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td><a");
            BeginWriteAttribute("href", " href=\"", 4581, "\"", 4613, 2);
            WriteAttributeValue("", 4588, "/Update-Category/", 4588, 17, true);
#nullable restore
#line 102 "C:\Users\MONSTER\source\repos\ProjCQRS\ProjCQRS.Mvc\Views\Search\Search.cshtml"
WriteAttributeValue("", 4605, item.Id, 4605, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-sm\" data-title=\"Edit\">Edit</a></td>\r\n                                    <td><a");
            BeginWriteAttribute("href", " href=\"", 4721, "\"", 4753, 2);
            WriteAttributeValue("", 4728, "/Category-Detail/", 4728, 17, true);
#nullable restore
#line 103 "C:\Users\MONSTER\source\repos\ProjCQRS\ProjCQRS.Mvc\Views\Search\Search.cshtml"
WriteAttributeValue("", 4745, item.Id, 4745, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning btn-sm\" data-title=\"Info\">Info</a></td>\r\n                                    <td><a");
            BeginWriteAttribute("href", " href=\"", 4861, "\"", 4893, 2);
            WriteAttributeValue("", 4868, "/Delete-Category/", 4868, 17, true);
#nullable restore
#line 104 "C:\Users\MONSTER\source\repos\ProjCQRS\ProjCQRS.Mvc\Views\Search\Search.cshtml"
WriteAttributeValue("", 4885, item.Id, 4885, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-sm\" data-title=\"Delete\">Delete</a></td>\r\n                                </tr>\r\n");
#nullable restore
#line 106 "C:\Users\MONSTER\source\repos\ProjCQRS\ProjCQRS.Mvc\Views\Search\Search.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n");
#nullable restore
#line 110 "C:\Users\MONSTER\source\repos\ProjCQRS\ProjCQRS.Mvc\Views\Search\Search.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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