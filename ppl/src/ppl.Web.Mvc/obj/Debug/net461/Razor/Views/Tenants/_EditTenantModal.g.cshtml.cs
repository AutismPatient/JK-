#pragma checksum "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Tenants\_EditTenantModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ce2765934ad02a1f5eb7c3bba37038fc014bcd7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tenants__EditTenantModal), @"mvc.1.0.view", @"/Views/Tenants/_EditTenantModal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tenants/_EditTenantModal.cshtml", typeof(AspNetCore.Views_Tenants__EditTenantModal))]
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
#line 1 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Tenants\_EditTenantModal.cshtml"
using Abp.MultiTenancy;

#line default
#line hidden
#line 2 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Tenants\_EditTenantModal.cshtml"
using ppl.MultiTenancy.Dto;

#line default
#line hidden
#line 3 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Tenants\_EditTenantModal.cshtml"
using ppl.Web.Models.Common.Modals;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ce2765934ad02a1f5eb7c3bba37038fc014bcd7", @"/Views/Tenants/_EditTenantModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cc72928e58287740592435e67e86457ddcd9614", @"/Views/_ViewImports.cshtml")]
    public class Views_Tenants__EditTenantModal : ppl.Web.Views.pplRazorPage<TenantDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("TenantEditForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/view-resources/Views/Tenants/_EditTenantModal.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 5 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Tenants\_EditTenantModal.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(137, 100, false);
#line 8 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Tenants\_EditTenantModal.cshtml"
Write(Html.Partial("~/Views/Shared/Modals/_ModalHeader.cshtml", new ModalHeaderViewModel(L("EditTenant"))));

#line default
#line hidden
            EndContext();
            BeginContext(237, 34, true);
            WriteLiteral("\r\n\r\n<div class=\"modal-body\">\r\n    ");
            EndContext();
            BeginContext(271, 1103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac79760d883b4a5789813c94686a4328", async() => {
                BeginContext(346, 40, true);
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"Id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 386, "\"", 403, 1);
#line 12 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Tenants\_EditTenantModal.cshtml"
WriteAttributeValue("", 394, Model.Id, 394, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(404, 160, true);
                WriteLiteral("/>\r\n        <div class=\"form-group form-float\">\r\n            <div class=\"form-line\">\r\n                <input class=\"form-control\" type=\"text\" name=\"TenancyName\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 564, "\"", 590, 1);
#line 15 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Tenants\_EditTenantModal.cshtml"
WriteAttributeValue("", 572, Model.TenancyName, 572, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(591, 83, true);
                WriteLiteral(" required maxlength=\"64\" minlength=\"2\">\r\n                <label class=\"form-label\">");
                EndContext();
                BeginContext(675, 16, false);
#line 16 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Tenants\_EditTenantModal.cshtml"
                                     Write(L("TenancyName"));

#line default
#line hidden
                EndContext();
                BeginContext(691, 195, true);
                WriteLiteral("</label>\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group form-float\">\r\n            <div class=\"form-line\">\r\n                <input type=\"text\" name=\"Name\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 886, "\"", 905, 1);
#line 21 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Tenants\_EditTenantModal.cshtml"
WriteAttributeValue("", 894, Model.Name, 894, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(906, 70, true);
                WriteLiteral(" required maxlength=\"128\">\r\n                <label class=\"form-label\">");
                EndContext();
                BeginContext(977, 9, false);
#line 22 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Tenants\_EditTenantModal.cshtml"
                                     Write(L("Name"));

#line default
#line hidden
                EndContext();
                BeginContext(986, 201, true);
                WriteLiteral("</label>\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group form-float\">\r\n            <div class=\"\">\r\n                <input id=\"isactive\" type=\"checkbox\" name=\"IsActive\" value=\"true\" ");
                EndContext();
                BeginContext(1189, 31, false);
#line 27 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Tenants\_EditTenantModal.cshtml"
                                                                              Write(Model.IsActive ? "checked" : "");

#line default
#line hidden
                EndContext();
                BeginContext(1221, 82, true);
                WriteLiteral(" class=\"form-control\"/>\r\n                <label for=\"isactive\" class=\"form-label\">");
                EndContext();
                BeginContext(1304, 13, false);
#line 28 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Tenants\_EditTenantModal.cshtml"
                                                    Write(L("IsActive"));

#line default
#line hidden
                EndContext();
                BeginContext(1317, 50, true);
                WriteLiteral("</label>\r\n            </div>\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1374, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(1387, 74, false);
#line 34 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Tenants\_EditTenantModal.cshtml"
Write(Html.Partial("~/Views/Shared/Modals/_ModalFooterWithSaveAndCancel.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(1461, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(1465, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70cdfc9eb022484aa6e872eb9b4eca18", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 36 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Tenants\_EditTenantModal.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1565, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TenantDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
