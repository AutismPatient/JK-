#pragma checksum "D:\git-re\-\ppl\src\ppl.Web.Mvc\Views\Shared\Components\SideBarUserArea\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c505a34b68a669ddc8274c3a3ab375ac2891f72"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SideBarUserArea_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SideBarUserArea/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/SideBarUserArea/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_SideBarUserArea_Default))]
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
#line 1 "D:\git-re\-\ppl\src\ppl.Web.Mvc\Views\Shared\Components\SideBarUserArea\Default.cshtml"
using ppl.Web.Views.Shared.Components.SideBarUserArea;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c505a34b68a669ddc8274c3a3ab375ac2891f72", @"/Views/Shared/Components/SideBarUserArea/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cc72928e58287740592435e67e86457ddcd9614", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_SideBarUserArea_Default : ppl.Web.Views.pplRazorPage<SideBarUserAreaViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(89, 268, true);
            WriteLiteral(@"<div class=""user-info"">
    <div class=""header"">
        <h4 style=""margin-bottom:0;color:white;font-weight:500"">欢 迎 您</h4>
    </div>
    <div class=""info-container"">
        <div class=""name"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false""><b>");
            EndContext();
            BeginContext(358, 35, false);
#line 8 "D:\git-re\-\ppl\src\ppl.Web.Mvc\Views\Shared\Components\SideBarUserArea\Default.cshtml"
                                                                                          Write(Html.Raw(Model.GetShownLoginName()));

#line default
#line hidden
            EndContext();
            BeginContext(393, 44, true);
            WriteLiteral("</b> </div>\r\n        <div class=\"email\">邮箱： ");
            EndContext();
            BeginContext(438, 41, false);
#line 9 "D:\git-re\-\ppl\src\ppl.Web.Mvc\Views\Shared\Components\SideBarUserArea\Default.cshtml"
                          Write(Model.LoginInformations.User.EmailAddress);

#line default
#line hidden
            EndContext();
            BeginContext(479, 596, true);
            WriteLiteral(@"</div>
        <div class=""btn-group user-helper-dropdown"">
            <i class=""material-icons"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""true"">keyboard_arrow_down</i>
            <ul class=""dropdown-menu pull-right"">
                <li><a href=""javascript:void(0);"" class="" waves-effect waves-block""><i class=""material-icons"">person</i>个人资料</a></li>
                <li><a href=""javascript:void(0);"" class="" waves-effect waves-block""><i class=""material-icons"">lock_open</i>修改密码</a></li>
                <li role=""separator"" class=""divider""></li>
                <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1075, "\"", 1142, 1);
#line 16 "D:\git-re\-\ppl\src\ppl.Web.Mvc\Views\Shared\Components\SideBarUserArea\Default.cshtml"
WriteAttributeValue("", 1082, Url.Action("Logout", "Account", new { area= string.Empty }), 1082, 60, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1143, 105, true);
            WriteLiteral("><i class=\"material-icons\">input</i>注 销</a></li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SideBarUserAreaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
