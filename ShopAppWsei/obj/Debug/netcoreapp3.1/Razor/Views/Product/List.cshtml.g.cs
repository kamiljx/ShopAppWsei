#pragma checksum "C:\Users\rzesz\Documents\GitHub\ShopAppWsei\ShopAppWsei\Views\Product\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9131c28986c719a7ca730988a30eefaeceec088c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ShopAppWsei.Views.Product.Views_Product_List), @"mvc.1.0.view", @"/Views/Product/List.cshtml")]
namespace ShopAppWsei.Views.Product
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
#line 2 "C:\Users\rzesz\Documents\GitHub\ShopAppWsei\ShopAppWsei\Views\_ViewImports.cshtml"
using ShopAppWsei;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rzesz\Documents\GitHub\ShopAppWsei\ShopAppWsei\Views\_ViewImports.cshtml"
using ShopAppWsei.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9131c28986c719a7ca730988a30eefaeceec088c", @"/Views/Product/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47d2859a8df058168ab73e4e9866e3ab951bf8f3", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\rzesz\Documents\GitHub\ShopAppWsei\ShopAppWsei\Views\Product\List.cshtml"
 foreach (var p in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <h3>");
#nullable restore
#line 6 "C:\Users\rzesz\Documents\GitHub\ShopAppWsei\ShopAppWsei\Views\Product\List.cshtml"
       Write(p.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <p>ID: ");
#nullable restore
#line 7 "C:\Users\rzesz\Documents\GitHub\ShopAppWsei\ShopAppWsei\Views\Product\List.cshtml"
          Write(p.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Category ");
#nullable restore
#line 8 "C:\Users\rzesz\Documents\GitHub\ShopAppWsei\ShopAppWsei\Views\Product\List.cshtml"
               Write(p.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Description ");
#nullable restore
#line 9 "C:\Users\rzesz\Documents\GitHub\ShopAppWsei\ShopAppWsei\Views\Product\List.cshtml"
                  Write(p.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Price USD ");
#nullable restore
#line 10 "C:\Users\rzesz\Documents\GitHub\ShopAppWsei\ShopAppWsei\Views\Product\List.cshtml"
                Write(p.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n");
#nullable restore
#line 12 "C:\Users\rzesz\Documents\GitHub\ShopAppWsei\ShopAppWsei\Views\Product\List.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
