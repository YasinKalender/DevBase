#pragma checksum "C:\Users\ysnbj\Documents\GitHub\DevBase\DevBase.UI\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31063c98cc24cd5dd9dbb11feb6e352aab203e8c"
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
#line 1 "C:\Users\ysnbj\Documents\GitHub\DevBase\DevBase.UI\Views\_ViewImports.cshtml"
using DevBase.Dto.DTOs.CategoryDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ysnbj\Documents\GitHub\DevBase\DevBase.UI\Views\_ViewImports.cshtml"
using DevBase.Dto.DTOs.ProductDto;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31063c98cc24cd5dd9dbb11feb6e352aab203e8c", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c9df93422e6c8cad91415ae9de7d764b5302dda", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CategoryListDto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ysnbj\Documents\GitHub\DevBase\DevBase.UI\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Index";

    Layout = "_Layout";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\ysnbj\Documents\GitHub\DevBase\DevBase.UI\Views\Category\Index.cshtml"
 using (Html.BeginForm("Index", "Category", FormMethod.Get))
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ysnbj\Documents\GitHub\DevBase\DevBase.UI\Views\Category\Index.cshtml"
Write(Html.TextBox("s"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button type=\"submit\" class=\"btn btn-primary\">Ara</button>\r\n");
#nullable restore
#line 14 "C:\Users\ysnbj\Documents\GitHub\DevBase\DevBase.UI\Views\Category\Index.cshtml"


}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table table-bordered\">\r\n\r\n    <thead>\r\n\r\n        <tr>\r\n            <th>Category Name</th>\r\n            <th></th>\r\n            <th></th>\r\n\r\n        </tr>\r\n\r\n    </thead>\r\n\r\n    <tbody>\r\n\r\n        <tr>\r\n\r\n");
#nullable restore
#line 35 "C:\Users\ysnbj\Documents\GitHub\DevBase\DevBase.UI\Views\Category\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>");
#nullable restore
#line 37 "C:\Users\ysnbj\Documents\GitHub\DevBase\DevBase.UI\Views\Category\Index.cshtml"
               Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 38 "C:\Users\ysnbj\Documents\GitHub\DevBase\DevBase.UI\Views\Category\Index.cshtml"
               Write(Html.ActionLink("Güncelle", "UpdateCategory", "Category", new { id = item.ID }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 39 "C:\Users\ysnbj\Documents\GitHub\DevBase\DevBase.UI\Views\Category\Index.cshtml"
               Write(Html.ActionLink("Sil", "DeleteCategory", "Category", new { id = item.ID }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 40 "C:\Users\ysnbj\Documents\GitHub\DevBase\DevBase.UI\Views\Category\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tr>\r\n\r\n\r\n    </tbody>\r\n\r\n\r\n\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CategoryListDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
