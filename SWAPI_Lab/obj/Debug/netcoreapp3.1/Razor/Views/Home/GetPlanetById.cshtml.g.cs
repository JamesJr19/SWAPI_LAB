#pragma checksum "C:\Users\ruwar\OneDrive\Desktop\Grand Circus Projects\Notes and Exercises\SWAPI_Lab\SWAPI_Lab\Views\Home\GetPlanetById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "245a728a4f9811df7e86670d1377ee96792138ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetPlanetById), @"mvc.1.0.view", @"/Views/Home/GetPlanetById.cshtml")]
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
#line 1 "C:\Users\ruwar\OneDrive\Desktop\Grand Circus Projects\Notes and Exercises\SWAPI_Lab\SWAPI_Lab\Views\_ViewImports.cshtml"
using SWAPI_Lab;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ruwar\OneDrive\Desktop\Grand Circus Projects\Notes and Exercises\SWAPI_Lab\SWAPI_Lab\Views\_ViewImports.cshtml"
using SWAPI_Lab.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"245a728a4f9811df7e86670d1377ee96792138ab", @"/Views/Home/GetPlanetById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70ce515e3694edae97cf2e75168f6c3f08f1aead", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetPlanetById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Result>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ruwar\OneDrive\Desktop\Grand Circus Projects\Notes and Exercises\SWAPI_Lab\SWAPI_Lab\Views\Home\GetPlanetById.cshtml"
  
    ViewData["Title"] = "GetPlanetById";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Planet: ");
#nullable restore
#line 6 "C:\Users\ruwar\OneDrive\Desktop\Grand Circus Projects\Notes and Exercises\SWAPI_Lab\SWAPI_Lab\Views\Home\GetPlanetById.cshtml"
           Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n    <table class=\"table\">\r\n        <tr>\r\n            <th>Population</th>\r\n            <th>Orbit</th>\r\n            <th>Diameter</th>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 15 "C:\Users\ruwar\OneDrive\Desktop\Grand Circus Projects\Notes and Exercises\SWAPI_Lab\SWAPI_Lab\Views\Home\GetPlanetById.cshtml"
           Write(Model.population);

#line default
#line hidden
#nullable disable
            WriteLiteral(" People</td>\r\n            <td>");
#nullable restore
#line 16 "C:\Users\ruwar\OneDrive\Desktop\Grand Circus Projects\Notes and Exercises\SWAPI_Lab\SWAPI_Lab\Views\Home\GetPlanetById.cshtml"
           Write(Model.orbital_period);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Miles</td>\r\n            <td>");
#nullable restore
#line 17 "C:\Users\ruwar\OneDrive\Desktop\Grand Circus Projects\Notes and Exercises\SWAPI_Lab\SWAPI_Lab\Views\Home\GetPlanetById.cshtml"
           Write(Model.diameter);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Miles</td>\r\n            \r\n        </tr>\r\n\r\n    </table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Result> Html { get; private set; }
    }
}
#pragma warning restore 1591
