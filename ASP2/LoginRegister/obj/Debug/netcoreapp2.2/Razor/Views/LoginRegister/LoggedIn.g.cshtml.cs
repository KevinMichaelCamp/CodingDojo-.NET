#pragma checksum "C:\Users\kevin\Desktop\Dojo\dotNET\ASP2\LoginRegister\Views\LoginRegister\LoggedIn.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bdceef8e7f06a55f7dbe26fdf49f9a10b91ef2d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LoginRegister_LoggedIn), @"mvc.1.0.view", @"/Views/LoginRegister/LoggedIn.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/LoginRegister/LoggedIn.cshtml", typeof(AspNetCore.Views_LoginRegister_LoggedIn))]
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
#line 1 "C:\Users\kevin\Desktop\Dojo\dotNET\ASP2\LoginRegister\Views\_ViewImports.cshtml"
using LoginRegister;

#line default
#line hidden
#line 1 "C:\Users\kevin\Desktop\Dojo\dotNET\ASP2\LoginRegister\Views\LoginRegister\LoggedIn.cshtml"
using LoginRegister.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdceef8e7f06a55f7dbe26fdf49f9a10b91ef2d3", @"/Views/LoginRegister/LoggedIn.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0eb5d83f43bca865722101104078a4685b5742f", @"/Views/_ViewImports.cshtml")]
    public class Views_LoginRegister_LoggedIn : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LogUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 94, true);
            WriteLiteral("\r\n<div class=\"jumbotron\">\r\n    <h1 class=\"display-4\">Log In Success!</h1>\r\n</div>\r\n<h1>Email: ");
            EndContext();
            BeginContext(140, 11, false);
#line 7 "C:\Users\kevin\Desktop\Dojo\dotNET\ASP2\LoginRegister\Views\LoginRegister\LoggedIn.cshtml"
      Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(151, 5, true);
            WriteLiteral("</h1>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LogUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
