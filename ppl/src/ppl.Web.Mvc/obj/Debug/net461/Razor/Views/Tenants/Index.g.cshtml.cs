#pragma checksum "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Tenants\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7936c5e53b03ebd9768670956d97c0714fbcf82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tenants_Index), @"mvc.1.0.view", @"/Views/Tenants/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tenants/Index.cshtml", typeof(AspNetCore.Views_Tenants_Index))]
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
#line 1 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Tenants\Index.cshtml"
using Abp.Authorization.Users;

#line default
#line hidden
#line 2 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Tenants\Index.cshtml"
using Abp.MultiTenancy;

#line default
#line hidden
#line 3 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Tenants\Index.cshtml"
using ppl.MultiTenancy;

#line default
#line hidden
#line 4 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Tenants\Index.cshtml"
using ppl.Web.Startup;

#line default
#line hidden
#line 5 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Tenants\Index.cshtml"
using ppl.Web.Models.Common.Modals;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7936c5e53b03ebd9768670956d97c0714fbcf82", @"/Views/Tenants/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cc72928e58287740592435e67e86457ddcd9614", @"/Views/_ViewImports.cshtml")]
    public class Views_Tenants_Index : ppl.Web.Views.pplRazorPage<Abp.Application.Services.Dto.PagedResultDto<ppl.MultiTenancy.Dto.TenantDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/view-resources/Views/Tenants/Index.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/view-resources/Views/Tenants/Index.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "Staging,Production", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("tenantCreateForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 7 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Tenants\Index.cshtml"
  
    ViewBag.CurrentPageName = PageNames.Tenants; // The menu item will be active for this page.

#line default
#line hidden
            DefineSection("scripts", async() => {
                BeginContext(350, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(356, 152, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7161e9d13bdc4919b255e012782d598e", async() => {
                    BeginContext(389, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(399, 89, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0a6a9de18b04b60a1af721c168b08b0", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 13 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Tenants\Index.cshtml"
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
                    BeginContext(488, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(508, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(516, 163, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec994571753e489580aa27608a42b0c4", async() => {
                    BeginContext(556, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(566, 93, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73fa0a552d204cf8bc42e4de3b14f508", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 17 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Tenants\Index.cshtml"
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
                    BeginContext(659, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(679, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(684, 191, true);
            WriteLiteral("<div class=\"row clearfix\">\r\n    <div class=\"col-lg-12 col-md-12 col-sm-12 col-xs-12\">\r\n        <div class=\"card\">\r\n            <div class=\"header\">\r\n                <h2>\r\n                    ");
            EndContext();
            BeginContext(876, 12, false);
#line 25 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Tenants\Index.cshtml"
               Write(L("Tenants"));

#line default
#line hidden
            EndContext();
            BeginContext(888, 594, true);
            WriteLiteral(@"
                </h2>
                <ul class=""header-dropdown m-r--5"">
                    <li class=""dropdown"">
                        <a href=""javascript:void(0);"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">
                            <i class=""material-icons"">more_vert</i>
                        </a>
                        <ul class=""dropdown-menu pull-right"">
                            <li><a id=""RefreshButton"" href=""javascript:void(0);"" class=""waves-effect waves-block""><i class=""material-icons"">refresh</i>");
            EndContext();
            BeginContext(1483, 12, false);
#line 33 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Tenants\Index.cshtml"
                                                                                                                                                  Write(L("Refresh"));

#line default
#line hidden
            EndContext();
            BeginContext(1495, 291, true);
            WriteLiteral(@"</a></li>
                        </ul>
                    </li>
                </ul>
            </div>
            <div class=""body table-responsive"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>");
            EndContext();
            BeginContext(1787, 16, false);
#line 42 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Tenants\Index.cshtml"
                           Write(L("TenancyName"));

#line default
#line hidden
            EndContext();
            BeginContext(1803, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(1843, 9, false);
#line 43 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Tenants\Index.cshtml"
                           Write(L("Name"));

#line default
#line hidden
            EndContext();
            BeginContext(1852, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(1892, 13, false);
#line 44 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Tenants\Index.cshtml"
                           Write(L("IsActive"));

#line default
#line hidden
            EndContext();
            BeginContext(1905, 97, true);
            WriteLiteral("</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
            EndContext();
#line 48 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Tenants\Index.cshtml"
                         foreach (var tenant in Model.Items)
                        {

#line default
#line hidden
            BeginContext(2091, 70, true);
            WriteLiteral("                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(2162, 18, false);
#line 51 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Tenants\Index.cshtml"
                               Write(tenant.TenancyName);

#line default
#line hidden
            EndContext();
            BeginContext(2180, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2224, 11, false);
#line 52 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Tenants\Index.cshtml"
                               Write(tenant.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2235, 68, true);
            WriteLiteral("</td>\r\n                                <td><i class=\"material-icons\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 2303, "\"", 2352, 3);
            WriteAttributeValue("", 2311, "color:", 2311, 6, true);
#line 53 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Tenants\Index.cshtml"
WriteAttributeValue("", 2317, tenant.IsActive ? "green":"red", 2317, 34, false);

#line default
#line hidden
            WriteAttributeValue("", 2351, ";", 2351, 1, true);
            EndWriteAttribute();
            BeginContext(2353, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2356, 57, false);
#line 53 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Tenants\Index.cshtml"
                                                                                                            Write(tenant.IsActive ? "check_box" : "indeterminate_check_box");

#line default
#line hidden
            EndContext();
            BeginContext(2414, 530, true);
            WriteLiteral(@"</i></td>
                                <td class=""dropdown"">
                                    <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">
                                        <i class=""material-icons"">menu</i>
                                    </a>
                                    <ul class=""dropdown-menu pull-right"">
                                        <li><a href=""#"" class=""waves-effect waves-block edit-tenant"" data-tenant-id=""");
            EndContext();
            BeginContext(2945, 9, false);
#line 59 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Tenants\Index.cshtml"
                                                                                                                Write(tenant.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2954, 87, true);
            WriteLiteral("\" data-toggle=\"modal\" data-target=\"#TenantEditModal\"><i class=\"material-icons\">edit</i>");
            EndContext();
            BeginContext(3042, 9, false);
#line 59 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Tenants\Index.cshtml"
                                                                                                                                                                                                                 Write(L("Edit"));

#line default
#line hidden
            EndContext();
            BeginContext(3051, 130, true);
            WriteLiteral("</a></li>\r\n                                        <li><a href=\"#\" class=\"waves-effect waves-block delete-tenant\" data-tenant-id=\"");
            EndContext();
            BeginContext(3182, 9, false);
#line 60 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Tenants\Index.cshtml"
                                                                                                                  Write(tenant.Id);

#line default
#line hidden
            EndContext();
            BeginContext(3191, 21, true);
            WriteLiteral("\" data-tenancy-name=\"");
            EndContext();
            BeginContext(3213, 18, false);
#line 60 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Tenants\Index.cshtml"
                                                                                                                                                 Write(tenant.TenancyName);

#line default
#line hidden
            EndContext();
            BeginContext(3231, 44, true);
            WriteLiteral("\"><i class=\"material-icons\">delete_sweep</i>");
            EndContext();
            BeginContext(3276, 11, false);
#line 60 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Tenants\Index.cshtml"
                                                                                                                                                                                                                Write(L("Delete"));

#line default
#line hidden
            EndContext();
            BeginContext(3287, 128, true);
            WriteLiteral("</a></li>\r\n                                    </ul>\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 64 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Tenants\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(3442, 611, true);
            WriteLiteral(@"                    </tbody>
                </table>
                <button type=""button"" class=""btn btn-primary btn-circle waves-effect waves-circle waves-float pull-right"" data-toggle=""modal"" data-target=""#TenantCreateModal"">
                    <i class=""material-icons"">add</i>
                </button>
            </div>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""TenantCreateModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""TenantCreateModalLabel"" data-backdrop=""static"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            ");
            EndContext();
            BeginContext(4053, 2564, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5ad31cca9c548cca4b412a5a2ef208e", async() => {
                BeginContext(4130, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(4149, 105, false);
#line 79 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Tenants\Index.cshtml"
           Write(Html.Partial("~/Views/Shared/Modals/_ModalHeader.cshtml", new ModalHeaderViewModel(L("CreateNewTenant"))));

#line default
#line hidden
                EndContext();
                BeginContext(4254, 245, true);
                WriteLiteral("\r\n                <div class=\"modal-body\">\r\n                    <div class=\"form-group form-float\">\r\n                        <div class=\"form-line\">\r\n                            <input class=\"form-control\" type=\"text\" name=\"TenancyName\" required");
                EndContext();
                BeginWriteAttribute("maxlength", " maxlength=\"", 4499, "\"", 4546, 1);
#line 83 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Tenants\Index.cshtml"
WriteAttributeValue("", 4511, AbpTenantBase.MaxTenancyNameLength, 4511, 35, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4547, 71, true);
                WriteLiteral(" minlength=\"2\">\r\n                            <label class=\"form-label\">");
                EndContext();
                BeginContext(4619, 16, false);
#line 84 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Tenants\Index.cshtml"
                                                 Write(L("TenancyName"));

#line default
#line hidden
                EndContext();
                BeginContext(4635, 264, true);
                WriteLiteral(@"</label>
                        </div>
                    </div>
                    <div class=""form-group form-float"">
                        <div class=""form-line"">
                            <input type=""text"" name=""Name"" class=""form-control"" required");
                EndContext();
                BeginWriteAttribute("maxlength", " maxlength=\"", 4899, "\"", 4932, 1);
#line 89 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Tenants\Index.cshtml"
WriteAttributeValue("", 4911, Tenant.MaxNameLength, 4911, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4933, 57, true);
                WriteLiteral(">\r\n                            <label class=\"form-label\">");
                EndContext();
                BeginContext(4991, 9, false);
#line 90 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Tenants\Index.cshtml"
                                                 Write(L("Name"));

#line default
#line hidden
                EndContext();
                BeginContext(5000, 267, true);
                WriteLiteral(@"</label>
                        </div>
                    </div>
                    <div class=""form-group form-float"">
                        <div class=""form-line"">
                            <input type=""text"" name=""ConnectionString"" class=""form-control""");
                EndContext();
                BeginWriteAttribute("maxlength", " maxlength=\"", 5267, "\"", 5319, 1);
#line 95 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Tenants\Index.cshtml"
WriteAttributeValue("", 5279, AbpTenantBase.MaxConnectionStringLength, 5279, 40, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5320, 57, true);
                WriteLiteral(">\r\n                            <label class=\"form-label\">");
                EndContext();
                BeginContext(5378, 29, false);
#line 96 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Tenants\Index.cshtml"
                                                 Write(L("DatabaseConnectionString"));

#line default
#line hidden
                EndContext();
                BeginContext(5407, 2, true);
                WriteLiteral(" (");
                EndContext();
                BeginContext(5410, 13, false);
#line 96 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Tenants\Index.cshtml"
                                                                                 Write(L("Optional"));

#line default
#line hidden
                EndContext();
                BeginContext(5423, 279, true);
                WriteLiteral(@")</label>
                        </div>
                    </div>
                    <div class=""form-group form-float"">
                        <div class=""form-line"">
                            <input type=""email"" name=""AdminEmailAddress"" class=""form-control"" required");
                EndContext();
                BeginWriteAttribute("maxlength", " maxlength=\"", 5702, "\"", 5748, 1);
#line 101 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Tenants\Index.cshtml"
WriteAttributeValue("", 5714, AbpUserBase.MaxEmailAddressLength, 5714, 34, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5749, 57, true);
                WriteLiteral(">\r\n                            <label class=\"form-label\">");
                EndContext();
                BeginContext(5807, 22, false);
#line 102 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Tenants\Index.cshtml"
                                                 Write(L("AdminEmailAddress"));

#line default
#line hidden
                EndContext();
                BeginContext(5829, 304, true);
                WriteLiteral(@"</label>
                        </div>
                    </div>
                    <div class=""checkbox"">
                        <input type=""checkbox"" name=""IsActive"" value=""true"" id=""CreateTenantIsActive"" class=""filled-in"" checked />
                        <label for=""CreateTenantIsActive"">");
                EndContext();
                BeginContext(6134, 13, false);
#line 107 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Tenants\Index.cshtml"
                                                     Write(L("IsActive"));

#line default
#line hidden
                EndContext();
                BeginContext(6147, 61, true);
                WriteLiteral("</label>\r\n                    </div>\r\n                    <p>");
                EndContext();
                BeginContext(6209, 68, false);
#line 109 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Tenants\Index.cshtml"
                  Write(L("DefaultPasswordIs", ppl.Authorization.Users.User.DefaultPassword));

#line default
#line hidden
                EndContext();
                BeginContext(6277, 174, true);
                WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"modal-footer\">\r\n                    <button type=\"button\" class=\"btn btn-default waves-effect\" data-dismiss=\"modal\">");
                EndContext();
                BeginContext(6452, 11, false);
#line 112 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Tenants\Index.cshtml"
                                                                                               Write(L("Cancel"));

#line default
#line hidden
                EndContext();
                BeginContext(6463, 90, true);
                WriteLiteral("</button>\r\n                    <button type=\"submit\" class=\"btn btn-primary waves-effect\">");
                EndContext();
                BeginContext(6554, 9, false);
#line 113 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Tenants\Index.cshtml"
                                                                          Write(L("Save"));

#line default
#line hidden
                EndContext();
                BeginContext(6563, 47, true);
                WriteLiteral("</button>\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6617, 300, true);
            WriteLiteral(@"
        </div>
    </div>
</div>

<div class=""modal fade"" id=""TenantEditModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""TenantEditModalLabel"" data-backdrop=""static"">
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
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Abp.Application.Services.Dto.PagedResultDto<ppl.MultiTenancy.Dto.TenantDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
