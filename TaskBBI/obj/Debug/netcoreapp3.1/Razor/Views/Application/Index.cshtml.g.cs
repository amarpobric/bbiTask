#pragma checksum "C:\Users\User\source\repos\TaskBBI\TaskBBI\Views\Application\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec335b1028035f7c8e69802b53076038a0b45f37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Application_Index), @"mvc.1.0.view", @"/Views/Application/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec335b1028035f7c8e69802b53076038a0b45f37", @"/Views/Application/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e32d7bf014d7601a08866f3a5d275cd387cf2f5", @"/Views/_ViewImports.cshtml")]
    public class Views_Application_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApplicationIndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div");
            BeginWriteAttribute("class", " class=\"", 49, "\"", 57, 0);
            EndWriteAttribute();
            WriteLiteral(@">
    <div class=""row"">
        <div class=""col-md-12 col-sm-12 col-xs-12"">
            <div class=""x_panel"">
                <div class=""x_title"">
                    <h2><i class=""fa fa-add""></i> Izaberite paket </h2>
                    <div class=""clearfix""></div>

                </div>
                <div class=""x_content"">
                    <br />
");
#nullable restore
#line 17 "C:\Users\User\source\repos\TaskBBI\TaskBBI\Views\Application\Index.cshtml"
                     using (Html.BeginForm("Create", "Application", FormMethod.Get, new { @class = "form-horizontal form-label-left", @autocomplete = "off" }))
                    {
                                              
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\User\source\repos\TaskBBI\TaskBBI\Views\Application\Index.cshtml"
                   Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-md-6 col-sm-6\">\r\n                            <div class=\"form-group\">\r\n                                ");
#nullable restore
#line 23 "C:\Users\User\source\repos\TaskBBI\TaskBBI\Views\Application\Index.cshtml"
                           Write(Html.LabelFor(model => model.ApplicationPackageId, new { @class = "control-label col-md-4 col-sm-3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                <div class=\"col-md-8 col-sm-9\">\r\n                                    ");
#nullable restore
#line 26 "C:\Users\User\source\repos\TaskBBI\TaskBBI\Views\Application\Index.cshtml"
                               Write(Html.DropDownListFor(model => model.ApplicationPackageId, Model.ApplicationPackages, "Odaberite vrstu paketa", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 27 "C:\Users\User\source\repos\TaskBBI\TaskBBI\Views\Application\Index.cshtml"
                               Write(Html.ValidationMessageFor(model => model.ApplicationPackageId, "", new { @style = "color:red" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>                          \r\n                        </div>\r\n");
            WriteLiteral(@"                        <div class=""col-md-12 col-sm-12 col-xs-12"">
                            <div class=""form-group"">
                                <div class=""col-md-12"">
                                    <div class=""btn-group  pull-right"">
                                        <button type=""submit"" class=""btn btn-success""><i class=""fa fa-save""></i> Dalje </button>                                  
                                        <a");
            BeginWriteAttribute("href", " href=\"", 1943, "\"", 1977, 1);
#nullable restore
#line 37 "C:\Users\User\source\repos\TaskBBI\TaskBBI\Views\Application\Index.cshtml"
WriteAttributeValue("", 1950, Url.Action("Index","Home"), 1950, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary pull-right"" style=""background-color:#C9302C;border-color:#C9302C""><i class=""fa fa-close"" style=""color:#fff;""></i> Odustani </a>
                                    </div>
                                </div>
                            </div>
                        </div>
");
#nullable restore
#line 42 "C:\Users\User\source\repos\TaskBBI\TaskBBI\Views\Application\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApplicationIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
