#pragma checksum "C:\Users\kevin\Desktop\Dojo\dotNET\ASP2\QuotingDojo\Views\Shared\NavPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58f076aa3d73a77329ef8aa2486a60a342be551c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_NavPartial), @"mvc.1.0.view", @"/Views/Shared/NavPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/NavPartial.cshtml", typeof(AspNetCore.Views_Shared_NavPartial))]
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
#line 1 "C:\Users\kevin\Desktop\Dojo\dotNET\ASP2\QuotingDojo\Views\_ViewImports.cshtml"
using QuotingDojo;

#line default
#line hidden
#line 2 "C:\Users\kevin\Desktop\Dojo\dotNET\ASP2\QuotingDojo\Views\_ViewImports.cshtml"
using QuotingDojo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58f076aa3d73a77329ef8aa2486a60a342be551c", @"/Views/Shared/NavPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1590bf4c09dff90063a94a6cfc81488d471e1d42", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_NavPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 365, true);
            WriteLiteral(@"<nav class=""navbar navbar-expand-sm bg-dark navbar-dark"">
    <a class=""navbar-brand"">Quoting Dojo</a>
    <ul class=""navbar-nav"">
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/"">Enter Quote</a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/quotes"">View Quotes</a>
        </li>
    </ul>
</nav>");
            EndContext();
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
