#pragma checksum "D:\VisualStudio2019\DesignPatterns\DesignPatternsPractice\DesignPatternsASP\Views\ProductDetail\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f19082c9dde5a7884ecbca250fe4f3a711a22a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductDetail_Index), @"mvc.1.0.view", @"/Views/ProductDetail/Index.cshtml")]
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
#line 1 "D:\VisualStudio2019\DesignPatterns\DesignPatternsPractice\DesignPatternsASP\Views\_ViewImports.cshtml"
using DesignPatternsASP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\VisualStudio2019\DesignPatterns\DesignPatternsPractice\DesignPatternsASP\Views\_ViewImports.cshtml"
using DesignPatternsASP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f19082c9dde5a7884ecbca250fe4f3a711a22a4", @"/Views/ProductDetail/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"312594cd2d0a7a3ad9d21235391710d9fc8ab710", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductDetail_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\VisualStudio2019\DesignPatterns\DesignPatternsPractice\DesignPatternsASP\Views\ProductDetail\Index.cshtml"
  
    decimal totalLocal = (decimal)ViewBag.TotalLocal;
    decimal totalForeign = (decimal)ViewBag.TotalForeign;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-lg-12\">\r\n        <label>Total local</label>\r\n        <b>");
#nullable restore
#line 9 "D:\VisualStudio2019\DesignPatterns\DesignPatternsPractice\DesignPatternsASP\Views\ProductDetail\Index.cshtml"
      Write(totalLocal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b><br />\r\n        <label>Total extranjero</label>\r\n        <b>");
#nullable restore
#line 11 "D:\VisualStudio2019\DesignPatterns\DesignPatternsPractice\DesignPatternsASP\Views\ProductDetail\Index.cshtml"
      Write(totalForeign);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n    </div>\r\n</div>");
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
