#pragma checksum "C:\Users\User\source\repos\TaskBBI\TaskBBI\Views\Home\TestDB.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76027d3a302b582a1286888aa2885ff029777906"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TestDB), @"mvc.1.0.view", @"/Views/Home/TestDB.cshtml")]
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
#line 1 "C:\Users\User\source\repos\TaskBBI\TaskBBI\Views\_ViewImports.cshtml"
using TaskBBI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\TaskBBI\TaskBBI\Views\_ViewImports.cshtml"
using TaskBBI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\source\repos\TaskBBI\TaskBBI\Views\_ViewImports.cshtml"
using TaskBBI.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\User\source\repos\TaskBBI\TaskBBI\Views\Home\TestDB.cshtml"
using TaskBBI.EF;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76027d3a302b582a1286888aa2885ff029777906", @"/Views/Home/TestDB.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e32d7bf014d7601a08866f3a5d275cd387cf2f5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TestDB : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dbContext>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\User\source\repos\TaskBBI\TaskBBI\Views\Home\TestDB.cshtml"
  
    ViewBag.Title = "title";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Test DB - row count</h2>\r\n\r\nMjesta stanovanja: ");
#nullable restore
#line 11 "C:\Users\User\source\repos\TaskBBI\TaskBBI\Views\Home\TestDB.cshtml"
              Write(Model.PlaceOfResidence.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\nPaketi: ");
#nullable restore
#line 13 "C:\Users\User\source\repos\TaskBBI\TaskBBI\Views\Home\TestDB.cshtml"
   Write(Model.ApplicationPackage.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n\r\n\r\n");
#nullable restore
#line 17 "C:\Users\User\source\repos\TaskBBI\TaskBBI\Views\Home\TestDB.cshtml"
Write(Html.ActionLink("Apliciranje", "Index", "Application"));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dbContext> Html { get; private set; }
    }
}
#pragma warning restore 1591
