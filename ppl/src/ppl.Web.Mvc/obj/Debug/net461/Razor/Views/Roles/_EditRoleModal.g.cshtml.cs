#pragma checksum "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\_EditRoleModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed93f806366d4590787ac4e70a1cd8d037ee4f3e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Roles__EditRoleModal), @"mvc.1.0.view", @"/Views/Roles/_EditRoleModal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Roles/_EditRoleModal.cshtml", typeof(AspNetCore.Views_Roles__EditRoleModal))]
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
#line 1 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\_ViewImports.cshtml"
using Abp.Localization;

#line default
#line hidden
#line 1 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\_EditRoleModal.cshtml"
using ppl.Web.Models.Common.Modals;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed93f806366d4590787ac4e70a1cd8d037ee4f3e", @"/Views/Roles/_EditRoleModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cc72928e58287740592435e67e86457ddcd9614", @"/Views/_ViewImports.cshtml")]
    public class Views_Roles__EditRoleModal : ppl.Web.Views.pplRazorPage<ppl.Web.Models.Roles.EditRoleModalViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/view-resources/Views/Roles/_EditRoleModal.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("RoleEditForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\_EditRoleModal.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(116, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76b91636446a4b21a9936fe836260e2b", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 6 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\_EditRoleModal.cshtml"
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
            BeginContext(212, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(215, 98, false);
#line 7 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\_EditRoleModal.cshtml"
Write(Html.Partial("~/Views/Shared/Modals/_ModalHeader.cshtml", new ModalHeaderViewModel(L("EditRole"))));

#line default
#line hidden
            EndContext();
            BeginContext(313, 34, true);
            WriteLiteral("\r\n\r\n<div class=\"modal-body\">\r\n    ");
            EndContext();
            BeginContext(347, 2537, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce62078ab2114fb9ba9249593c66be09", async() => {
                BeginContext(420, 40, true);
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"Id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 460, "\"", 482, 1);
#line 11 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\_EditRoleModal.cshtml"
WriteAttributeValue("", 468, Model.Role.Id, 468, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(483, 49, true);
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"IsStatic\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 532, "\"", 573, 1);
#line 12 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\_EditRoleModal.cshtml"
WriteAttributeValue("", 540, Model.Role.IsStatic.ToString(), 540, 33, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(574, 221, true);
                WriteLiteral(" />\r\n        <div class=\"row clearfix\">\r\n            <div class=\"col-sm-12\">\r\n                <div class=\"form-group form-float\">\r\n                    <div class=\"form-line\">\r\n                        <input id=\"rolename\" ");
                EndContext();
                BeginContext(797, 37, false);
#line 17 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\_EditRoleModal.cshtml"
                                         Write(Model.Role.IsStatic ? "disabled" : "");

#line default
#line hidden
                EndContext();
                BeginContext(835, 32, true);
                WriteLiteral(" type=\"text\" name=\"Name\" value=\"");
                EndContext();
                BeginContext(868, 15, false);
#line 17 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\_EditRoleModal.cshtml"
                                                                                                                Write(Model.Role.Name);

#line default
#line hidden
                EndContext();
                BeginContext(883, 137, true);
                WriteLiteral("\" required maxlength=\"32\" minlength=\"2\" class=\"validate form-control\">\r\n                        <label for=\"rolename\" class=\"form-label\">");
                EndContext();
                BeginContext(1021, 13, false);
#line 18 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\_EditRoleModal.cshtml"
                                                            Write(L("RoleName"));

#line default
#line hidden
                EndContext();
                BeginContext(1034, 349, true);
                WriteLiteral(@"</label>
                    </div>
                </div>
            </div>
        </div>

        <div class=""row clearfix"">
            <div class=""col-sm-12"">
                <div class=""form-group form-float"">
                    <div class=""form-line"">
                        <input id=""displayname"" type=""text"" name=""DisplayName""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1383, "\"", 1414, 1);
#line 28 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\_EditRoleModal.cshtml"
WriteAttributeValue("", 1391, Model.Role.DisplayName, 1391, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1415, 139, true);
                WriteLiteral(" required maxlength=\"32\" minlength=\"2\" class=\"validate form-control\">\r\n                        <label for=\"displayname\" class=\"form-label\">");
                EndContext();
                BeginContext(1555, 16, false);
#line 29 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\_EditRoleModal.cshtml"
                                                               Write(L("DisplayName"));

#line default
#line hidden
                EndContext();
                BeginContext(1571, 367, true);
                WriteLiteral(@"</label>
                    </div>
                </div>
            </div>
        </div>

        <div class=""row"">
            <div class=""col-sm-12"">
                <div class=""form-group form-float"">
                    <div class=""form-line"">
                        <textarea id=""role-description"" name=""Description"" class=""validate form-control"">");
                EndContext();
                BeginContext(1939, 22, false);
#line 39 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\_EditRoleModal.cshtml"
                                                                                                    Write(Model.Role.Description);

#line default
#line hidden
                EndContext();
                BeginContext(1961, 86, true);
                WriteLiteral("</textarea>\r\n                        <label for=\"role-description\" class=\"form-label\">");
                EndContext();
                BeginContext(2048, 20, false);
#line 40 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\_EditRoleModal.cshtml"
                                                                    Write(L("RoleDescription"));

#line default
#line hidden
                EndContext();
                BeginContext(2068, 193, true);
                WriteLiteral("</label>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row clearfix\">\r\n            <div class=\"col-sm-12\">\r\n                <h4>");
                EndContext();
                BeginContext(2262, 16, false);
#line 48 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\_EditRoleModal.cshtml"
               Write(L("Permissions"));

#line default
#line hidden
                EndContext();
                BeginContext(2278, 9, true);
                WriteLiteral("</h4>\r\n\r\n");
                EndContext();
#line 50 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\_EditRoleModal.cshtml"
                 foreach (var permission in Model.Permissions)
                {

#line default
#line hidden
                BeginContext(2370, 108, true);
                WriteLiteral("                    <div class=\"col-sm-6\">\r\n                        <input type=\"checkbox\" name=\"permission\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2478, "\"", 2502, 1);
#line 53 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\_EditRoleModal.cshtml"
WriteAttributeValue("", 2486, permission.Name, 2486, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2503, 18, true);
                WriteLiteral(" class=\"filled-in\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 2521, "\"", 2573, 1);
#line 53 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\_EditRoleModal.cshtml"
WriteAttributeValue("", 2526, string.Format("permission{0}",permission.Name), 2526, 47, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2574, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(2577, 48, false);
#line 53 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\_EditRoleModal.cshtml"
                                                                                                                                                             Write(Model.HasPermission(permission) ? "checked" : "");

#line default
#line hidden
                EndContext();
                BeginContext(2626, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(2629, 37, false);
#line 53 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\_EditRoleModal.cshtml"
                                                                                                                                                                                                                 Write(Model.Role.IsStatic ? "disabled" : "");

#line default
#line hidden
                EndContext();
                BeginContext(2667, 35, true);
                WriteLiteral(" />\r\n                        <label");
                EndContext();
                BeginWriteAttribute("for", " for=\"", 2702, "\"", 2755, 1);
#line 54 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\_EditRoleModal.cshtml"
WriteAttributeValue("", 2708, string.Format("permission{0}",permission.Name), 2708, 47, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2756, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(2758, 22, false);
#line 54 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\_EditRoleModal.cshtml"
                                                                                Write(permission.DisplayName);

#line default
#line hidden
                EndContext();
                BeginContext(2780, 38, true);
                WriteLiteral("</label>\r\n                    </div>\r\n");
                EndContext();
#line 56 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\_EditRoleModal.cshtml"
                }

#line default
#line hidden
                BeginContext(2837, 40, true);
                WriteLiteral("            </div>\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2884, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(2891, 74, false);
#line 60 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\_EditRoleModal.cshtml"
Write(Html.Partial("~/Views/Shared/Modals/_ModalFooterWithSaveAndCancel.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(2965, 16, true);
            WriteLiteral("\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ppl.Web.Models.Roles.EditRoleModalViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
