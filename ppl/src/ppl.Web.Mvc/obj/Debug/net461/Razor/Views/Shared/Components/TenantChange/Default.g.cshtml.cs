#pragma checksum "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Shared\Components\TenantChange\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "749f494f5bc5dd8d14726a79ca50dae09adc5b80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_TenantChange_Default), @"mvc.1.0.view", @"/Views/Shared/Components/TenantChange/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/TenantChange/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_TenantChange_Default))]
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
#line 1 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\_ViewImports.cshtml"
using Abp.Localization;

#line default
#line hidden
#line 1 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Shared\Components\TenantChange\Default.cshtml"
using ppl.Web.Resources;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"749f494f5bc5dd8d14726a79ca50dae09adc5b80", @"/Views/Shared/Components/TenantChange/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cc72928e58287740592435e67e86457ddcd9614", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_TenantChange_Default : ppl.Web.Views.pplRazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Shared\Components\TenantChange\Default.cshtml"
  
    WebResourceManager.AddScript(ApplicationPath + "view-resources/Views/Shared/Components/TenantChange/Default.js");

#line default
#line hidden
            BeginContext(200, 143, true);
            WriteLiteral("<div class=\"card tenant-change-component\" style=\"margin-bottom: 3px;\">\r\n    <div class=\"body text-center\">\r\n        <span>\r\n            租户:\r\n\r\n");
            EndContext();
#line 11 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Shared\Components\TenantChange\Default.cshtml"
             if (Model.Tenant != null)
            {

#line default
#line hidden
            BeginContext(398, 21, true);
            WriteLiteral("                <span");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 419, "\"", 445, 1);
#line 13 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Shared\Components\TenantChange\Default.cshtml"
WriteAttributeValue("", 427, Model.Tenant.Name, 427, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(446, 9, true);
            WriteLiteral("><strong>");
            EndContext();
            BeginContext(456, 24, false);
#line 13 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Shared\Components\TenantChange\Default.cshtml"
                                                    Write(Model.Tenant.TenancyName);

#line default
#line hidden
            EndContext();
            BeginContext(480, 18, true);
            WriteLiteral("</strong></span>\r\n");
            EndContext();
#line 14 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Shared\Components\TenantChange\Default.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(546, 34, true);
            WriteLiteral("                <span>未选择</span>\r\n");
            EndContext();
#line 18 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Shared\Components\TenantChange\Default.cshtml"
            }

#line default
#line hidden
            BeginContext(595, 388, true);
            WriteLiteral(@"
            (<a href=""#"" data-toggle=""modal"" data-target=""#TenantChangeModal"">选择</a>)
        </span>
    </div>
</div>
<div class=""modal fade"" id=""TenantChangeModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""UserCreateModalLabel"" data-backdrop=""static"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">

        </div>
    </div>
</div>
");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IWebResourceManager WebResourceManager { get; private set; }
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
