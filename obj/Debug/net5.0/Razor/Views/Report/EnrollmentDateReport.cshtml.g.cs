#pragma checksum "C:\Users\user\source\repos\GAMF\GAMF\Views\Report\EnrollmentDateReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f3073a17c87b4906802a66acaf2a629606f5f05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Report_EnrollmentDateReport), @"mvc.1.0.view", @"/Views/Report/EnrollmentDateReport.cshtml")]
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
#line 1 "C:\Users\user\source\repos\GAMF\GAMF\Views\_ViewImports.cshtml"
using GAMF;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\source\repos\GAMF\GAMF\Views\_ViewImports.cshtml"
using GAMF.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\user\source\repos\GAMF\GAMF\Views\Report\EnrollmentDateReport.cshtml"
using GAMF.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f3073a17c87b4906802a66acaf2a629606f5f05", @"/Views/Report/EnrollmentDateReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b34d1c292a4f9844470bf02570c6649f77128030", @"/Views/_ViewImports.cshtml")]
    public class Views_Report_EnrollmentDateReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EnrollmentDateVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n \r\n\r\n");
#nullable restore
#line 7 "C:\Users\user\source\repos\GAMF\GAMF\Views\Report\EnrollmentDateReport.cshtml"
   

    ViewData["Title"] = "EnrollmentDateReport"; 


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
 

<h2>Első jelentkezések riport</h2> 

 

<table class=""table""> 

    <thead> 

        <tr> 

            <th> 

                Első jelentkezés 

            </th> 

            <th> 

                Hallgatók száma 

            </th> 

        </tr> 

    </thead> 

    <tbody> 

");
#nullable restore
#line 43 "C:\Users\user\source\repos\GAMF\GAMF\Views\Report\EnrollmentDateReport.cshtml"
         foreach (var item in Model) 

        { 


#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr> \r\n\r\n                <td> \r\n\r\n                    ");
#nullable restore
#line 51 "C:\Users\user\source\repos\GAMF\GAMF\Views\Report\EnrollmentDateReport.cshtml"
               Write(item.EnrollmentDate.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n\r\n                </td> \r\n\r\n                <td> \r\n\r\n                    ");
#nullable restore
#line 57 "C:\Users\user\source\repos\GAMF\GAMF\Views\Report\EnrollmentDateReport.cshtml"
               Write(item.StudentCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n\r\n                </td> \r\n\r\n            </tr> \r\n");
#nullable restore
#line 62 "C:\Users\user\source\repos\GAMF\GAMF\Views\Report\EnrollmentDateReport.cshtml"

        } 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody> \r\n\r\n</table> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EnrollmentDateVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591