#pragma checksum "C:\Users\ABDIRAHMAN\source\repos\e-healthAppointment\e-healthAppointment\Views\Appointment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ae6af5ef73a82b52b158db2ef73378140daf946"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Appointment_Index), @"mvc.1.0.view", @"/Views/Appointment/Index.cshtml")]
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
#line 1 "C:\Users\ABDIRAHMAN\source\repos\e-healthAppointment\e-healthAppointment\Views\_ViewImports.cshtml"
using e_healthAppointment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ABDIRAHMAN\source\repos\e-healthAppointment\e-healthAppointment\Views\_ViewImports.cshtml"
using e_healthAppointment.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ae6af5ef73a82b52b158db2ef73378140daf946", @"/Views/Appointment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6f2da9ca7edcaf4837622fd97a66e68590ff178", @"/Views/_ViewImports.cshtml")]
    public class Views_Appointment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"container\">\r\n");
#nullable restore
#line 4 "C:\Users\ABDIRAHMAN\source\repos\e-healthAppointment\e-healthAppointment\Views\Appointment\Index.cshtml"
         if (User.IsInRole(e_healthAppointment.Utility.Helper.Admin))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\">\r\n                <div class=\"form-group  col-4\" id=\"divDoctorList\">\r\n                    <label> Select Doctor</label>\r\n                    ");
#nullable restore
#line 9 "C:\Users\ABDIRAHMAN\source\repos\e-healthAppointment\e-healthAppointment\Views\Appointment\Index.cshtml"
               Write(Html.DropDownList("doctorId", new SelectList(ViewBag.DoctorList, "Id", "Name"), new
               {
                   @class = "form-control select2"

               }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n\r\n\r\n            </div>\r\n");
#nullable restore
#line 19 "C:\Users\ABDIRAHMAN\source\repos\e-healthAppointment\e-healthAppointment\Views\Appointment\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div id=\"Calendar\"></div>\r\n\r\n\r\n\r\n\r\n    </div>\r\n            </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
