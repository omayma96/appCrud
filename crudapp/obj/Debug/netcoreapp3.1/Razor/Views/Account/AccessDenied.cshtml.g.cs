#pragma checksum "C:\Users\Youcode\source\repos\crudApp\Views\Account\AccessDenied.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5be81356e101170b777400c0f497df8748f3b981"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_AccessDenied), @"mvc.1.0.razor-page", @"/Views/Account/AccessDenied.cshtml")]
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
#line 1 "C:\Users\Youcode\source\repos\crudApp\Views\_ViewImports.cshtml"
using crudApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Youcode\source\repos\crudApp\Views\_ViewImports.cshtml"
using crudApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5be81356e101170b777400c0f497df8748f3b981", @"/Views/Account/AccessDenied.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ce67f7046df3085c641ea25568ac15ed1e1381a", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_AccessDenied : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Youcode\source\repos\crudApp\Views\Account\AccessDenied.cshtml"
  
    ViewData["Title"] = "Access denied";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Youcode\source\repos\crudApp\Views\Account\AccessDenied.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<header>\r\n    <h1 class=\"text-danger\">");
#nullable restore
#line 11 "C:\Users\Youcode\source\repos\crudApp\Views\Account\AccessDenied.cshtml"
                       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <p class=\"text-danger\">You do not have access to this resource.</p>\r\n</header>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<crudApp.ViewModel.AccessDeniedModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<crudApp.ViewModel.AccessDeniedModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<crudApp.ViewModel.AccessDeniedModel>)PageContext?.ViewData;
        public crudApp.ViewModel.AccessDeniedModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591