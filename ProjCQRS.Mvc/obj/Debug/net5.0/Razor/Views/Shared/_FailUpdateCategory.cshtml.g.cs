#pragma checksum "C:\Users\MONSTER\source\repos\ProjCQRS\ProjCQRS.Mvc\Views\Shared\_FailUpdateCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b7025ab47da4c44d3163124038c37659f78d45a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__FailUpdateCategory), @"mvc.1.0.view", @"/Views/Shared/_FailUpdateCategory.cshtml")]
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
#line 2 "C:\Users\MONSTER\source\repos\ProjCQRS\ProjCQRS.Mvc\Views\Shared\_FailUpdateCategory.cshtml"
using ProjCQRS.Mvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b7025ab47da4c44d3163124038c37659f78d45a", @"/Views/Shared/_FailUpdateCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46443aca69b50dde6d2879cbe3b0b4edcd77abef", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__FailUpdateCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\MONSTER\source\repos\ProjCQRS\ProjCQRS.Mvc\Views\Shared\_FailUpdateCategory.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Somethings went wrong. Try again</h1>\r\n<a");
            BeginWriteAttribute("href", " href=\"", 146, "\"", 179, 2);
            WriteAttributeValue("", 153, "/Category-Detail/", 153, 17, true);
#nullable restore
#line 8 "C:\Users\MONSTER\source\repos\ProjCQRS\ProjCQRS.Mvc\Views\Shared\_FailUpdateCategory.cshtml"
WriteAttributeValue("", 170, Model.Id, 170, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info btn\" data-title=\"Back\">Back To Info</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Category> Html { get; private set; }
    }
}
#pragma warning restore 1591