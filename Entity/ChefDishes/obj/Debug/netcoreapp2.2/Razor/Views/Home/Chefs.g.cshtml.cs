#pragma checksum "C:\Users\kevin\Desktop\Dojo\dotNET\Entity\ChefDishes\Views\Home\Chefs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea048cb4c61501ee5e140dd69d94b0d1e412888b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Chefs), @"mvc.1.0.view", @"/Views/Home/Chefs.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Chefs.cshtml", typeof(AspNetCore.Views_Home_Chefs))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea048cb4c61501ee5e140dd69d94b0d1e412888b", @"/Views/Home/Chefs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d1e193f657faf9fe25e69ea403b96cbdb646ae2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Chefs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Chef>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 251, true);
            WriteLiteral("\r\n<div class=\"jumbotron\">\r\n    <h1 class=\"display-4\">All Chefs</h1>\r\n</div>\r\n<main>\r\n    <table class=\"table\">\r\n        <thead>\r\n            <th>Name</th>\r\n            <th>Age</th>\r\n            <th># of Dishes</th>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 14 "C:\Users\kevin\Desktop\Dojo\dotNET\Entity\ChefDishes\Views\Home\Chefs.cshtml"
         foreach (var chef in Model)
        {
            var now = DateTime.Now; 
            var age = now.Year - @chef.Dob.Year;
            Console.WriteLine(age);
          if (@chef.Dob.Date > now.AddYears(-age))
          {
              age--;
          }

#line default
#line hidden
            BeginContext(544, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(575, 14, false);
#line 24 "C:\Users\kevin\Desktop\Dojo\dotNET\Entity\ChefDishes\Views\Home\Chefs.cshtml"
           Write(chef.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(589, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(591, 13, false);
#line 24 "C:\Users\kevin\Desktop\Dojo\dotNET\Entity\ChefDishes\Views\Home\Chefs.cshtml"
                           Write(chef.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(604, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(628, 3, false);
#line 25 "C:\Users\kevin\Desktop\Dojo\dotNET\Entity\ChefDishes\Views\Home\Chefs.cshtml"
           Write(age);

#line default
#line hidden
            EndContext();
            BeginContext(631, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(655, 24, false);
#line 26 "C:\Users\kevin\Desktop\Dojo\dotNET\Entity\ChefDishes\Views\Home\Chefs.cshtml"
           Write(chef.CreatedDishes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(679, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 28 "C:\Users\kevin\Desktop\Dojo\dotNET\Entity\ChefDishes\Views\Home\Chefs.cshtml"
        }

#line default
#line hidden
            BeginContext(712, 39, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Chef>> Html { get; private set; }
    }
}
#pragma warning restore 1591
