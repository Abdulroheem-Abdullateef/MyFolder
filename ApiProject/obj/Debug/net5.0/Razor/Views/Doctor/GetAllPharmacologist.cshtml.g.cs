#pragma checksum "C:\Users\ABDUL LATEEF RAHEEM\OneDrive\Desktop\ApiProject\Views\Doctor\GetAllPharmacologist.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25161923beba93562ea29c3f0435f0b1ae880995"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctor_GetAllPharmacologist), @"mvc.1.0.view", @"/Views/Doctor/GetAllPharmacologist.cshtml")]
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
#line 1 "C:\Users\ABDUL LATEEF RAHEEM\OneDrive\Desktop\ApiProject\Views\_ViewImports.cshtml"
using ApiProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ABDUL LATEEF RAHEEM\OneDrive\Desktop\ApiProject\Views\_ViewImports.cshtml"
using ApiProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25161923beba93562ea29c3f0435f0b1ae880995", @"/Views/Doctor/GetAllPharmacologist.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f67953344dedd38d689da9f12296d917b1e2e167", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Doctor_GetAllPharmacologist : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ApiProject.Dtos.DoctorDTO>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ABDUL LATEEF RAHEEM\OneDrive\Desktop\ApiProject\Views\Doctor\GetAllPharmacologist.cshtml"
  
   Layout = "AdminLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"card-header\" style=\"background-color:midnightblue;\">\r\n    <div class=\"card-title\">\r\n        <h1 class=\"text-center\">Pharmacologists</h1>\r\n    </div>\r\n</div>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n");
            WriteLiteral("                S/N\r\n            </th>\r\n\r\n            <th>\r\n");
            WriteLiteral("                FirstName\r\n            </th>\r\n\r\n            <th>\r\n");
            WriteLiteral("                LastName\r\n            </th>\r\n            <th>\r\n");
            WriteLiteral("                Email\r\n            </th>\r\n            <th>\r\n");
            WriteLiteral("                Specialized Area\r\n            </th>\r\n             <th>\r\n");
            WriteLiteral("                Staff Number\r\n            </th>\r\n");
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 61 "C:\Users\ABDUL LATEEF RAHEEM\OneDrive\Desktop\ApiProject\Views\Doctor\GetAllPharmacologist.cshtml"
         foreach (var patients in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 65 "C:\Users\ABDUL LATEEF RAHEEM\OneDrive\Desktop\ApiProject\Views\Doctor\GetAllPharmacologist.cshtml"
           Write(Html.DisplayFor(modelItem => patients.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 68 "C:\Users\ABDUL LATEEF RAHEEM\OneDrive\Desktop\ApiProject\Views\Doctor\GetAllPharmacologist.cshtml"
           Write(Html.DisplayFor(modelItem => patients.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 71 "C:\Users\ABDUL LATEEF RAHEEM\OneDrive\Desktop\ApiProject\Views\Doctor\GetAllPharmacologist.cshtml"
           Write(Html.DisplayFor(modelItem => patients.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 74 "C:\Users\ABDUL LATEEF RAHEEM\OneDrive\Desktop\ApiProject\Views\Doctor\GetAllPharmacologist.cshtml"
           Write(Html.DisplayFor(modelItem => patients.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>           \r\n            <td>\r\n                ");
#nullable restore
#line 77 "C:\Users\ABDUL LATEEF RAHEEM\OneDrive\Desktop\ApiProject\Views\Doctor\GetAllPharmacologist.cshtml"
           Write(Html.DisplayFor(modelItem => patients.AreaOfSpec));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n              <td>\r\n                ");
#nullable restore
#line 80 "C:\Users\ABDUL LATEEF RAHEEM\OneDrive\Desktop\ApiProject\Views\Doctor\GetAllPharmacologist.cshtml"
           Write(Html.DisplayFor(modelItem => patients.StaffNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 95 "C:\Users\ABDUL LATEEF RAHEEM\OneDrive\Desktop\ApiProject\Views\Doctor\GetAllPharmacologist.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ApiProject.Dtos.DoctorDTO>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
