#pragma checksum "D:\Projects\CivicPlusCalendar\CivicPlusCalendar\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "706442b94bc9cb908fd81edc33f7b9e97451e5f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\Projects\CivicPlusCalendar\CivicPlusCalendar\Views\_ViewImports.cshtml"
using CivicPlusCalendar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\CivicPlusCalendar\CivicPlusCalendar\Views\_ViewImports.cshtml"
using CivicPlusCalendar.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"706442b94bc9cb908fd81edc33f7b9e97451e5f5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b29c216b343eb3faef58c0e9c2173c20439c4e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Projects\CivicPlusCalendar\CivicPlusCalendar\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Your Events</h1>\r\n    <ul style=\"text-align: left; list-style-type: none; display:flex; flex-wrap: wrap\">\r\n");
#nullable restore
#line 8 "D:\Projects\CivicPlusCalendar\CivicPlusCalendar\Views\Home\Index.cshtml"
          
            foreach (var eventModel in Model)
            {
                var startDate = DateTime.Parse(eventModel.StartDate);
                var endDate = DateTime.Parse(eventModel.EndDate);


#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>\r\n                    <div style=\"background-color:gainsboro; border: 1px solid black; border-radius: 5px; padding: 15px; margin: 0 10px 10px 0; min-width: max-content\" ;>\r\n                        <p><b>Title:</b> ");
#nullable restore
#line 16 "D:\Projects\CivicPlusCalendar\CivicPlusCalendar\Views\Home\Index.cshtml"
                                    Write(eventModel.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p><b>Description:</b>  ");
#nullable restore
#line 17 "D:\Projects\CivicPlusCalendar\CivicPlusCalendar\Views\Home\Index.cshtml"
                                           Write(eventModel.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p><b>Start Date:</b> ");
#nullable restore
#line 18 "D:\Projects\CivicPlusCalendar\CivicPlusCalendar\Views\Home\Index.cshtml"
                                         Write(startDate.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 18 "D:\Projects\CivicPlusCalendar\CivicPlusCalendar\Views\Home\Index.cshtml"
                                                          Write(startDate.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 18 "D:\Projects\CivicPlusCalendar\CivicPlusCalendar\Views\Home\Index.cshtml"
                                                                         Write(startDate.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                        <p><b>End Date:</b> ");
#nullable restore
#line 19 "D:\Projects\CivicPlusCalendar\CivicPlusCalendar\Views\Home\Index.cshtml"
                                       Write(endDate.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 19 "D:\Projects\CivicPlusCalendar\CivicPlusCalendar\Views\Home\Index.cshtml"
                                                      Write(endDate.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 19 "D:\Projects\CivicPlusCalendar\CivicPlusCalendar\Views\Home\Index.cshtml"
                                                                   Write(endDate.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </li>\r\n");
#nullable restore
#line 22 "D:\Projects\CivicPlusCalendar\CivicPlusCalendar\Views\Home\Index.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n\r\n</div>\r\n");
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