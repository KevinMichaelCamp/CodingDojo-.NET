#pragma checksum "C:\Users\kevin\Desktop\Dojo\dotNET\Entity\Crud\Views\Crud\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e833d0c1ed8a992fb0daa3d23e3004fbec887d66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Crud_Index), @"mvc.1.0.view", @"/Views/Crud/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Crud/Index.cshtml", typeof(AspNetCore.Views_Crud_Index))]
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
#line 1 "C:\Users\kevin\Desktop\Dojo\dotNET\Entity\Crud\Views\_ViewImports.cshtml"
using Crud;

#line default
#line hidden
#line 2 "C:\Users\kevin\Desktop\Dojo\dotNET\Entity\Crud\Views\_ViewImports.cshtml"
using Crud.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e833d0c1ed8a992fb0daa3d23e3004fbec887d66", @"/Views/Crud/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c402e0156657abbd65c5377838b3b7bfb231cd50", @"/Views/_ViewImports.cshtml")]
    public class Views_Crud_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Dish>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 164, true);
            WriteLiteral("\r\n<div class=\"jumbotron\">\r\n    <h1 class=\"display-4\">Welcome to CRUDelicious</h1>\r\n</div>\r\n<main>\r\n    <h2 class=\"border-bottom\">Check out some recent dishes</h2>\r\n");
            EndContext();
#line 8 "C:\Users\kevin\Desktop\Dojo\dotNET\Entity\Crud\Views\Crud\Index.cshtml"
     foreach (var dish in Model)
    {

#line default
#line hidden
            BeginContext(231, 14, true);
            WriteLiteral("        <h6><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 245, "\"", 269, 2);
            WriteAttributeValue("", 252, "show/", 252, 5, true);
#line 10 "C:\Users\kevin\Desktop\Dojo\dotNET\Entity\Crud\Views\Crud\Index.cshtml"
WriteAttributeValue("", 257, dish.DishId, 257, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(270, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(272, 9, false);
#line 10 "C:\Users\kevin\Desktop\Dojo\dotNET\Entity\Crud\Views\Crud\Index.cshtml"
                                   Write(dish.Name);

#line default
#line hidden
            EndContext();
            BeginContext(281, 8, true);
            WriteLiteral("</a> by ");
            EndContext();
            BeginContext(290, 9, false);
#line 10 "C:\Users\kevin\Desktop\Dojo\dotNET\Entity\Crud\Views\Crud\Index.cshtml"
                                                     Write(dish.Chef);

#line default
#line hidden
            EndContext();
            BeginContext(299, 7, true);
            WriteLiteral("</h6>\r\n");
            EndContext();
#line 11 "C:\Users\kevin\Desktop\Dojo\dotNET\Entity\Crud\Views\Crud\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(313, 9, true);
            WriteLiteral("</main>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Dish>> Html { get; private set; }
    }
}
#pragma warning restore 1591
