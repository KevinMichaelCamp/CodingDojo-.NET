#pragma checksum "C:\Users\kevin\Desktop\Dojo\dotNET\Entity\ChefDishes\Views\Home\Dishes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adb78a91a562b09b4f7c508813ad5e595231e619"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dishes), @"mvc.1.0.view", @"/Views/Home/Dishes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dishes.cshtml", typeof(AspNetCore.Views_Home_Dishes))]
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
#line 1 "C:\Users\kevin\Desktop\Dojo\dotNET\Entity\ChefDishes\Views\_ViewImports.cshtml"
using ChefDishes;

#line default
#line hidden
#line 2 "C:\Users\kevin\Desktop\Dojo\dotNET\Entity\ChefDishes\Views\_ViewImports.cshtml"
using ChefDishes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adb78a91a562b09b4f7c508813ad5e595231e619", @"/Views/Home/Dishes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d1e193f657faf9fe25e69ea403b96cbdb646ae2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dishes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dish>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 282, true);
            WriteLiteral(@"
<div class=""jumbotron"">
    <h1 class=""display-4"">All Dishes</h1>
</div>
<main>
    <table class=""table"">
        <thead>
            <th>Name</th>
            <th>Chef</th>
            <th>Calories</th>
            <th>Tastiness</th>
        </thead>
        <tbody>
");
            EndContext();
#line 15 "C:\Users\kevin\Desktop\Dojo\dotNET\Entity\ChefDishes\Views\Home\Dishes.cshtml"
         foreach (var dish in Model)
        {

#line default
#line hidden
            BeginContext(350, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(381, 9, false);
#line 18 "C:\Users\kevin\Desktop\Dojo\dotNET\Entity\ChefDishes\Views\Home\Dishes.cshtml"
           Write(dish.Name);

#line default
#line hidden
            EndContext();
            BeginContext(390, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(414, 24, false);
#line 19 "C:\Users\kevin\Desktop\Dojo\dotNET\Entity\ChefDishes\Views\Home\Dishes.cshtml"
           Write(dish.CreatedBy.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(438, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(440, 23, false);
#line 19 "C:\Users\kevin\Desktop\Dojo\dotNET\Entity\ChefDishes\Views\Home\Dishes.cshtml"
                                     Write(dish.CreatedBy.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(463, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(487, 13, false);
#line 20 "C:\Users\kevin\Desktop\Dojo\dotNET\Entity\ChefDishes\Views\Home\Dishes.cshtml"
           Write(dish.Calories);

#line default
#line hidden
            EndContext();
            BeginContext(500, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(524, 14, false);
#line 21 "C:\Users\kevin\Desktop\Dojo\dotNET\Entity\ChefDishes\Views\Home\Dishes.cshtml"
           Write(dish.Tastiness);

#line default
#line hidden
            EndContext();
            BeginContext(538, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 23 "C:\Users\kevin\Desktop\Dojo\dotNET\Entity\ChefDishes\Views\Home\Dishes.cshtml"
        }

#line default
#line hidden
            BeginContext(571, 39, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Dish>> Html { get; private set; }
    }
}
#pragma warning restore 1591