#pragma checksum "C:\Users\Louis\source\repos\EhpadVaccin\EhpadVaccin\EhpadVaccin.WEB\Views\Personnes\ListeInjections.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5bd01c527c53a076a8a039f1caf3fde7163feef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personnes_ListeInjections), @"mvc.1.0.view", @"/Views/Personnes/ListeInjections.cshtml")]
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
#line 1 "C:\Users\Louis\source\repos\EhpadVaccin\EhpadVaccin\EhpadVaccin.WEB\Views\_ViewImports.cshtml"
using EhpadVaccin.WEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Louis\source\repos\EhpadVaccin\EhpadVaccin\EhpadVaccin.WEB\Views\_ViewImports.cshtml"
using EhpadVaccin.WEB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5bd01c527c53a076a8a039f1caf3fde7163feef", @"/Views/Personnes/ListeInjections.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2022681ac3a7ef35661e87625170ebd2a68b2e6d", @"/Views/_ViewImports.cshtml")]
    public class Views_Personnes_ListeInjections : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EhpadVaccin.ORM.Injection>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Louis\source\repos\EhpadVaccin\EhpadVaccin\EhpadVaccin.WEB\Views\Personnes\ListeInjections.cshtml"
   ViewData["Title"] = "ListeInjections"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Liste des injections</h1>\n\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 11 "C:\Users\Louis\source\repos\EhpadVaccin\EhpadVaccin\EhpadVaccin.WEB\Views\Personnes\ListeInjections.cshtml"
           Write(Html.DisplayNameFor(model => model.personne));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 14 "C:\Users\Louis\source\repos\EhpadVaccin\EhpadVaccin\EhpadVaccin.WEB\Views\Personnes\ListeInjections.cshtml"
           Write(Html.DisplayNameFor(model => model.dateInjection));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 17 "C:\Users\Louis\source\repos\EhpadVaccin\EhpadVaccin\EhpadVaccin.WEB\Views\Personnes\ListeInjections.cshtml"
           Write(Html.DisplayNameFor(model => model.dateRappel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 20 "C:\Users\Louis\source\repos\EhpadVaccin\EhpadVaccin\EhpadVaccin.WEB\Views\Personnes\ListeInjections.cshtml"
           Write(Html.DisplayNameFor(model => model.numLot));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 23 "C:\Users\Louis\source\repos\EhpadVaccin\EhpadVaccin\EhpadVaccin.WEB\Views\Personnes\ListeInjections.cshtml"
           Write(Html.DisplayNameFor(model => model.typeVaccin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 26 "C:\Users\Louis\source\repos\EhpadVaccin\EhpadVaccin\EhpadVaccin.WEB\Views\Personnes\ListeInjections.cshtml"
           Write(Html.DisplayNameFor(model => model.marque));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 32 "C:\Users\Louis\source\repos\EhpadVaccin\EhpadVaccin\EhpadVaccin.WEB\Views\Personnes\ListeInjections.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>\n        ");
#nullable restore
#line 36 "C:\Users\Louis\source\repos\EhpadVaccin\EhpadVaccin\EhpadVaccin.WEB\Views\Personnes\ListeInjections.cshtml"
   Write(Html.DisplayFor(modelItem => item.personne));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 39 "C:\Users\Louis\source\repos\EhpadVaccin\EhpadVaccin\EhpadVaccin.WEB\Views\Personnes\ListeInjections.cshtml"
   Write(Html.DisplayFor(modelItem => item.dateInjection));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 42 "C:\Users\Louis\source\repos\EhpadVaccin\EhpadVaccin\EhpadVaccin.WEB\Views\Personnes\ListeInjections.cshtml"
   Write(Html.DisplayFor(modelItem => item.dateRappel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 45 "C:\Users\Louis\source\repos\EhpadVaccin\EhpadVaccin\EhpadVaccin.WEB\Views\Personnes\ListeInjections.cshtml"
   Write(Html.DisplayFor(modelItem => item.numLot));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 48 "C:\Users\Louis\source\repos\EhpadVaccin\EhpadVaccin\EhpadVaccin.WEB\Views\Personnes\ListeInjections.cshtml"
   Write(Html.DisplayFor(modelItem => item.typeVaccin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 51 "C:\Users\Louis\source\repos\EhpadVaccin\EhpadVaccin\EhpadVaccin.WEB\Views\Personnes\ListeInjections.cshtml"
   Write(Html.DisplayFor(modelItem => item.marque));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n</tr>\n");
#nullable restore
#line 54 "C:\Users\Louis\source\repos\EhpadVaccin\EhpadVaccin\EhpadVaccin.WEB\Views\Personnes\ListeInjections.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EhpadVaccin.ORM.Injection>> Html { get; private set; }
    }
}
#pragma warning restore 1591
