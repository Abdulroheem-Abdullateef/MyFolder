#pragma checksum "C:\Users\BDUL LATEEF\Desktop\My Project\LearningManagementSystem\LearningManagementSystem\Views\Course\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e73343b076b93f59576de9e07002a8ac25320e38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_Details), @"mvc.1.0.view", @"/Views/Course/Details.cshtml")]
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
#line 1 "C:\Users\BDUL LATEEF\Desktop\My Project\LearningManagementSystem\LearningManagementSystem\Views\_ViewImports.cshtml"
using LearningManagementSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\BDUL LATEEF\Desktop\My Project\LearningManagementSystem\LearningManagementSystem\Views\_ViewImports.cshtml"
using LearningManagementSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e73343b076b93f59576de9e07002a8ac25320e38", @"/Views/Course/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"253b9025da8ac75b4a4663180061fa51f4c7fe24", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Course_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LearningManagementSystem.DTOs.CourseDto>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\BDUL LATEEF\Desktop\My Project\LearningManagementSystem\LearningManagementSystem\Views\Course\Details.cshtml"
  
    Layout = "_InstructorLayout";
    ViewData["Title"] = "Instructor";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<dl class=\"row\">\r\n    <dt class=\"col-sm-2\">\r\n        Name:\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 14 "C:\Users\BDUL LATEEF\Desktop\My Project\LearningManagementSystem\LearningManagementSystem\Views\Course\Details.cshtml"
   Write(Model.CourseName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n\r\n    <dt class=\"col-sm-2\">\r\n        CourseCode:\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 21 "C:\Users\BDUL LATEEF\Desktop\My Project\LearningManagementSystem\LearningManagementSystem\Views\Course\Details.cshtml"
   Write(Model.CourseCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n    <dt class=\"col-sm-2\">\r\n        InstructorName:\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 27 "C:\Users\BDUL LATEEF\Desktop\My Project\LearningManagementSystem\LearningManagementSystem\Views\Course\Details.cshtml"
   Write(Model.InstructorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n    <dt class=\"col-sm-2\">\r\n        StudentName:\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 33 "C:\Users\BDUL LATEEF\Desktop\My Project\LearningManagementSystem\LearningManagementSystem\Views\Course\Details.cshtml"
   Write(Model.Students);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n\r\n\r\n\r\n</dl>\r\n\r\n<button style=\"background-color:darkblue;\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e73343b076b93f59576de9e07002a8ac25320e385539", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</button>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LearningManagementSystem.DTOs.CourseDto> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
