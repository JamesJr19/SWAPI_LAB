#pragma checksum "C:\Users\ruwar\OneDrive\Desktop\Grand Circus Projects\Notes and Exercises\SWAPI_Lab\SWAPI_Lab\Views\Home\GetPeopleById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d326792a1ce0340f818dd4d5c7603f23da6d9c37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetPeopleById), @"mvc.1.0.view", @"/Views/Home/GetPeopleById.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d326792a1ce0340f818dd4d5c7603f23da6d9c37", @"/Views/Home/GetPeopleById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70ce515e3694edae97cf2e75168f6c3f08f1aead", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetPeopleById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Results>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ruwar\OneDrive\Desktop\Grand Circus Projects\Notes and Exercises\SWAPI_Lab\SWAPI_Lab\Views\Home\GetPeopleById.cshtml"
  
    ViewData["Title"] = "GetPeopleById";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h1>");
#nullable restore
#line 7 "C:\Users\ruwar\OneDrive\Desktop\Grand Circus Projects\Notes and Exercises\SWAPI_Lab\SWAPI_Lab\Views\Home\GetPeopleById.cshtml"
   Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n    <table class=\"table\">\r\n        <tr>\r\n            <th>Name</th>\r\n            <th>Gender</th>\r\n            <th>Height</th>\r\n            <th>Mass</th>\r\n            <th>Birth Year</th>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 18 "C:\Users\ruwar\OneDrive\Desktop\Grand Circus Projects\Notes and Exercises\SWAPI_Lab\SWAPI_Lab\Views\Home\GetPeopleById.cshtml"
           Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 19 "C:\Users\ruwar\OneDrive\Desktop\Grand Circus Projects\Notes and Exercises\SWAPI_Lab\SWAPI_Lab\Views\Home\GetPeopleById.cshtml"
           Write(Model.gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\ruwar\OneDrive\Desktop\Grand Circus Projects\Notes and Exercises\SWAPI_Lab\SWAPI_Lab\Views\Home\GetPeopleById.cshtml"
           Write(Model.height);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\ruwar\OneDrive\Desktop\Grand Circus Projects\Notes and Exercises\SWAPI_Lab\SWAPI_Lab\Views\Home\GetPeopleById.cshtml"
           Write(Model.mass);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\ruwar\OneDrive\Desktop\Grand Circus Projects\Notes and Exercises\SWAPI_Lab\SWAPI_Lab\Views\Home\GetPeopleById.cshtml"
           Write(Model.birth_year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Results> Html { get; private set; }
    }
}
#pragma warning restore 1591