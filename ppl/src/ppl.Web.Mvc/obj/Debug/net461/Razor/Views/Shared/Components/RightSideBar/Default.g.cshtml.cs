#pragma checksum "D:\git-re\-\ppl\src\ppl.Web.Mvc\Views\Shared\Components\RightSideBar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49033239f492bec5dd17ce15d31745fad89dc6dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_RightSideBar_Default), @"mvc.1.0.view", @"/Views/Shared/Components/RightSideBar/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/RightSideBar/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_RightSideBar_Default))]
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
#line 1 "D:\git-re\-\ppl\src\ppl.Web.Mvc\Views\_ViewImports.cshtml"
using Abp.Localization;

#line default
#line hidden
#line 1 "D:\git-re\-\ppl\src\ppl.Web.Mvc\Views\Shared\Components\RightSideBar\Default.cshtml"
using ppl.Configuration.Ui;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49033239f492bec5dd17ce15d31745fad89dc6dc", @"/Views/Shared/Components/RightSideBar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cc72928e58287740592435e67e86457ddcd9614", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_RightSideBar_Default : ppl.Web.Views.pplRazorPage<ppl.Web.Views.Shared.Components.RightSideBar.RightSideBarViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(104, 191, true);
            WriteLiteral("<aside id=\"rightsidebar\" class=\"right-sidebar\">\r\n    <ul class=\"nav nav-tabs tab-nav-right\" role=\"tablist\">\r\n        <li role=\"presentation\" class=\"active\"><a href=\"#skins\" data-toggle=\"tab\">");
            EndContext();
            BeginContext(296, 10, false);
#line 5 "D:\git-re\-\ppl\src\ppl.Web.Mvc\Views\Shared\Components\RightSideBar\Default.cshtml"
                                                                             Write(L("Skins"));

#line default
#line hidden
            EndContext();
            BeginContext(306, 81, true);
            WriteLiteral("</a></li>\r\n        <li role=\"presentation\"><a href=\"#settings\" data-toggle=\"tab\">");
            EndContext();
            BeginContext(388, 13, false);
#line 6 "D:\git-re\-\ppl\src\ppl.Web.Mvc\Views\Shared\Components\RightSideBar\Default.cshtml"
                                                                 Write(L("Settings"));

#line default
#line hidden
            EndContext();
            BeginContext(401, 180, true);
            WriteLiteral("</a></li>\r\n    </ul>\r\n    <div class=\"tab-content\">\r\n        <div role=\"tabpanel\" class=\"tab-pane fade in active in active\" id=\"skins\">\r\n            <ul class=\"demo-choose-skin\">\r\n");
            EndContext();
#line 11 "D:\git-re\-\ppl\src\ppl.Web.Mvc\Views\Shared\Components\RightSideBar\Default.cshtml"
                 foreach (var theme in UiThemes.All)
                {

#line default
#line hidden
            BeginContext(654, 36, true);
            WriteLiteral("                    <li data-theme=\"");
            EndContext();
            BeginContext(691, 14, false);
#line 13 "D:\git-re\-\ppl\src\ppl.Web.Mvc\Views\Shared\Components\RightSideBar\Default.cshtml"
                               Write(theme.CssClass);

#line default
#line hidden
            EndContext();
            BeginContext(705, 1, true);
            WriteLiteral("\"");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 706, "\"", 778, 1);
#line 13 "D:\git-re\-\ppl\src\ppl.Web.Mvc\Views\Shared\Components\RightSideBar\Default.cshtml"
WriteAttributeValue("", 714, theme.CssClass == Model.CurrentTheme.CssClass ? "active" : "", 714, 64, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(779, 31, true);
            WriteLiteral(">\r\n                        <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 810, "\"", 833, 1);
#line 14 "D:\git-re\-\ppl\src\ppl.Web.Mvc\Views\Shared\Components\RightSideBar\Default.cshtml"
WriteAttributeValue("", 818, theme.CssClass, 818, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(834, 39, true);
            WriteLiteral("></div>\r\n                        <span>");
            EndContext();
            BeginContext(874, 10, false);
#line 15 "D:\git-re\-\ppl\src\ppl.Web.Mvc\Views\Shared\Components\RightSideBar\Default.cshtml"
                         Write(theme.Name);

#line default
#line hidden
            EndContext();
            BeginContext(884, 36, true);
            WriteLiteral("</span>\r\n                    </li>\r\n");
            EndContext();
#line 17 "D:\git-re\-\ppl\src\ppl.Web.Mvc\Views\Shared\Components\RightSideBar\Default.cshtml"
                }

#line default
#line hidden
            BeginContext(939, 2330, true);
            WriteLiteral(@"            </ul>
        </div>
        <div role=""tabpanel"" class=""tab-pane fade"" id=""settings"">
            <div class=""demo-settings"">
                <p>GENERAL SETTINGS</p>
                <ul class=""setting-list"">
                    <li>
                        <span>Report Panel Usage</span>
                        <div class=""switch"">
                            <label><input type=""checkbox"" checked><span class=""lever""></span></label>
                        </div>
                    </li>
                    <li>
                        <span>Email Redirect</span>
                        <div class=""switch"">
                            <label><input type=""checkbox""><span class=""lever""></span></label>
                        </div>
                    </li>
                </ul>
                <p>SYSTEM SETTINGS</p>
                <ul class=""setting-list"">
                    <li>
                        <span>Notifications</span>
                        <div class=""switch""");
            WriteLiteral(@">
                            <label><input type=""checkbox"" checked><span class=""lever""></span></label>
                        </div>
                    </li>
                    <li>
                        <span>Auto Updates</span>
                        <div class=""switch"">
                            <label><input type=""checkbox"" checked><span class=""lever""></span></label>
                        </div>
                    </li>
                </ul>
                <p>ACCOUNT SETTINGS</p>
                <ul class=""setting-list"">
                    <li>
                        <span>Offline</span>
                        <div class=""switch"">
                            <label><input type=""checkbox""><span class=""lever""></span></label>
                        </div>
                    </li>
                    <li>
                        <span>Location Permission</span>
                        <div class=""switch"">
                            <label><input type=""checkbox"" checked");
            WriteLiteral(@"><span class=""lever""></span></label>
                        </div>
                    </li>
                </ul>
                
                <p style=""color: red;"">This settings are just for demonstration!</p>
            </div>
        </div>
    </div>
</aside>
");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ppl.Web.Views.Shared.Components.RightSideBar.RightSideBarViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
