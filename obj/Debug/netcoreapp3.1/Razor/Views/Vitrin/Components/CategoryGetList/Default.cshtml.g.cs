#pragma checksum "C:\Users\nando\Desktop\FoodApp\Views\Vitrin\Components\CategoryGetList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e55d6a572f9237b906bcbce0fe0a6161c176fc15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vitrin_Components_CategoryGetList_Default), @"mvc.1.0.view", @"/Views/Vitrin/Components/CategoryGetList/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e55d6a572f9237b906bcbce0fe0a6161c176fc15", @"/Views/Vitrin/Components/CategoryGetList/Default.cshtml")]
    public class Views_Vitrin_Components_CategoryGetList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FoodApp.Data.Models.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"panel-group category-products\" id=\"accordian\">\r\n    <!--category-productsr-->\r\n    <div class=\"panel panel-default\">\r\n\r\n");
#nullable restore
#line 7 "C:\Users\nando\Desktop\FoodApp\Views\Vitrin\Components\CategoryGetList\Default.cshtml"
         foreach(var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""panel-heading"">
            <h4 class=""panel-title"">
                <a data-toggle=""collapse"" data-parent=""#accordian"" href=""#sportswear"">
                    <span class=""badge pull-right""><i class=""fa fa-plus""></i></span>
                    ");
#nullable restore
#line 13 "C:\Users\nando\Desktop\FoodApp\Views\Vitrin\Components\CategoryGetList\Default.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </a>\r\n            </h4>\r\n        </div>\r\n");
#nullable restore
#line 17 "C:\Users\nando\Desktop\FoodApp\Views\Vitrin\Components\CategoryGetList\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n\r\n</div><!--/category-products-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FoodApp.Data.Models.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
