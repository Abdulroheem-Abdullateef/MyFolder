#pragma checksum "C:\Users\ABDUL LATEEF RAHEEM\OneDrive\Desktop\ApiProject\Views\MedicalRecord\MedicalCases.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e6b37fb715791d780a8a9d641d816d9cc6b448c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MedicalRecord_MedicalCases), @"mvc.1.0.view", @"/Views/MedicalRecord/MedicalCases.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e6b37fb715791d780a8a9d641d816d9cc6b448c", @"/Views/MedicalRecord/MedicalCases.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f67953344dedd38d689da9f12296d917b1e2e167", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_MedicalRecord_MedicalCases : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ApiProject.Dtos.MedicalRecordDTO>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ABDUL LATEEF RAHEEM\OneDrive\Desktop\ApiProject\Views\MedicalRecord\MedicalCases.cshtml"
  
    Layout = "AdminLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n<div class=\"card-header\" style=\"background-color:Yellow;\">\r\n    <div class=\"card-title\">\r\n        <h1 class=\"text-center\" style=\"Green\">Treated Cases</h1>\r\n    </div>\r\n</div>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n");
            WriteLiteral("                S/N\r\n            </th>\r\n\r\n            <th>\r\n");
            WriteLiteral("               Doctor\'s Name\r\n            </th>\r\n\r\n            <th>\r\n");
            WriteLiteral("                Diagnosis\r\n            </th>\r\n            <th>\r\n");
            WriteLiteral("                Prescription\r\n            </th>\r\n            <th>\r\n");
            WriteLiteral("                Complain\r\n            </th>\r\n             <th>\r\n");
            WriteLiteral("                Doctor\'s Report\r\n            </th>\r\n              <th>\r\n");
            WriteLiteral("                Refferral\r\n            </th> \r\n              <th>\r\n");
            WriteLiteral("                Patient\'s Name\r\n            </th> \r\n              <th>\r\n");
            WriteLiteral("                Hospital Name\r\n            </th>             \r\n\r\n");
            WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 66 "C:\Users\ABDUL LATEEF RAHEEM\OneDrive\Desktop\ApiProject\Views\MedicalRecord\MedicalCases.cshtml"
         foreach (var patients in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 70 "C:\Users\ABDUL LATEEF RAHEEM\OneDrive\Desktop\ApiProject\Views\MedicalRecord\MedicalCases.cshtml"
           Write(Html.DisplayFor(modelItem => patients.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 73 "C:\Users\ABDUL LATEEF RAHEEM\OneDrive\Desktop\ApiProject\Views\MedicalRecord\MedicalCases.cshtml"
           Write(Html.DisplayFor(modelItem => patients.DoctorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 76 "C:\Users\ABDUL LATEEF RAHEEM\OneDrive\Desktop\ApiProject\Views\MedicalRecord\MedicalCases.cshtml"
           Write(Html.DisplayFor(modelItem => patients.Diagnosis));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 79 "C:\Users\ABDUL LATEEF RAHEEM\OneDrive\Desktop\ApiProject\Views\MedicalRecord\MedicalCases.cshtml"
           Write(Html.DisplayFor(modelItem => patients.Prescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>           \r\n            <td>\r\n                ");
#nullable restore
#line 82 "C:\Users\ABDUL LATEEF RAHEEM\OneDrive\Desktop\ApiProject\Views\MedicalRecord\MedicalCases.cshtml"
           Write(Html.DisplayFor(modelItem => patients.PatientComplain));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n              <td>\r\n                ");
#nullable restore
#line 85 "C:\Users\ABDUL LATEEF RAHEEM\OneDrive\Desktop\ApiProject\Views\MedicalRecord\MedicalCases.cshtml"
           Write(Html.DisplayFor(modelItem => patients.DoctorReport));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n             <td>\r\n                ");
#nullable restore
#line 88 "C:\Users\ABDUL LATEEF RAHEEM\OneDrive\Desktop\ApiProject\Views\MedicalRecord\MedicalCases.cshtml"
           Write(Html.DisplayFor(modelItem => patients.Refferral));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td> \r\n             <td>\r\n                ");
#nullable restore
#line 91 "C:\Users\ABDUL LATEEF RAHEEM\OneDrive\Desktop\ApiProject\Views\MedicalRecord\MedicalCases.cshtml"
           Write(Html.DisplayFor(modelItem => patients.PatientName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td> \r\n             <td>\r\n                ");
#nullable restore
#line 94 "C:\Users\ABDUL LATEEF RAHEEM\OneDrive\Desktop\ApiProject\Views\MedicalRecord\MedicalCases.cshtml"
           Write(Html.DisplayFor(modelItem => patients.HospitalName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td> \r\n");
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 106 "C:\Users\ABDUL LATEEF RAHEEM\OneDrive\Desktop\ApiProject\Views\MedicalRecord\MedicalCases.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ApiProject.Dtos.MedicalRecordDTO>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
