#pragma checksum "C:\Users\kevin\Desktop\Dojo\dotNET\ASP2\QuotingDojo\Views\Quotes\Quotes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7dde849a898dcf9742e06f5f4dab7c46e642a04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Quotes_Quotes), @"mvc.1.0.view", @"/Views/Quotes/Quotes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Quotes/Quotes.cshtml", typeof(AspNetCore.Views_Quotes_Quotes))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7dde849a898dcf9742e06f5f4dab7c46e642a04", @"/Views/Quotes/Quotes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1590bf4c09dff90063a94a6cfc81488d471e1d42", @"/Views/_ViewImports.cshtml")]
    public class Views_Quotes_Quotes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Quote>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(14, 96, true);
            WriteLiteral("<div class=\"jumbotron\">\r\n    <h1 class=\"display-4\">All Quotes</h1>\r\n</div>\r\n\r\n<main>\r\n    <ul>\r\n");
            EndContext();
#line 8 "C:\Users\kevin\Desktop\Dojo\dotNET\ASP2\QuotingDojo\Views\Quotes\Quotes.cshtml"
     foreach(var quote in ViewBag.Quotes)
    {

#line default
#line hidden
            BeginContext(160, 26, true);
            WriteLiteral("        <li class=\"mt-3\">\"");
            EndContext();
            BeginContext(187, 16, false);
#line 10 "C:\Users\kevin\Desktop\Dojo\dotNET\ASP2\QuotingDojo\Views\Quotes\Quotes.cshtml"
                     Write(quote["Content"]);

#line default
#line hidden
            EndContext();
            BeginContext(203, 50, true);
            WriteLiteral("\"</li>\r\n        <li class=\"border-bottom ml-3\"> - ");
            EndContext();
            BeginContext(254, 13, false);
#line 11 "C:\Users\kevin\Desktop\Dojo\dotNET\ASP2\QuotingDojo\Views\Quotes\Quotes.cshtml"
                                     Write(quote["User"]);

#line default
#line hidden
            EndContext();
            BeginContext(267, 4, true);
            WriteLiteral(" at ");
            EndContext();
            BeginContext(272, 19, false);
#line 11 "C:\Users\kevin\Desktop\Dojo\dotNET\ASP2\QuotingDojo\Views\Quotes\Quotes.cshtml"
                                                       Write(quote["Created_At"]);

#line default
#line hidden
            EndContext();
            BeginContext(291, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 12 "C:\Users\kevin\Desktop\Dojo\dotNET\ASP2\QuotingDojo\Views\Quotes\Quotes.cshtml"
    }

#line default
#line hidden
            BeginContext(305, 18, true);
            WriteLiteral("    </ul>\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Quote> Html { get; private set; }
    }
}
#pragma warning restore 1591
