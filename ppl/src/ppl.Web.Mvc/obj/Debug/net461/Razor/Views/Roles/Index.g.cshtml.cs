#pragma checksum "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7595fe8dc0f2e7445159a65a8bef57b867b99c7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Roles_Index), @"mvc.1.0.view", @"/Views/Roles/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Roles/Index.cshtml", typeof(AspNetCore.Views_Roles_Index))]
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
#line 1 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
using ppl.Web.Startup;

#line default
#line hidden
#line 2 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
using ppl.Web.Models.Common.Modals;

#line default
#line hidden
#line 3 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
using ppl.Roles.Dto;

#line default
#line hidden
#line 4 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
using ppl.Authorization.Accounts.Dto;

#line default
#line hidden
#line 5 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
using ppl.Web.Models.Common.PageInfoModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7595fe8dc0f2e7445159a65a8bef57b867b99c7c", @"/Views/Roles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cc72928e58287740592435e67e86457ddcd9614", @"/Views/_ViewImports.cshtml")]
    public class Views_Roles_Index : ppl.Web.Views.pplRazorPage<ppl.Web.Models.Roles.RoleListViewModel<RoleDto,PermissionDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/view-resources/Views/Roles/Index.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/view-resources/Views/Roles/Index.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "Staging,Production", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("roleCreateForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 7 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
  
    ViewBag.CurrentPageName = PageNames.Roles; // The menu item will be active for this page.

#line default
#line hidden
            DefineSection("scripts", async() => {
                BeginContext(357, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(363, 150, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18366a11900e4f1fac1d11b26a3b7b90", async() => {
                    BeginContext(396, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(406, 87, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9d926a421d34df8ab855b45ff31e6b9", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 13 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
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
                    BeginContext(493, 6, true);
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
                BeginContext(513, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(521, 161, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d3e101b78724c7592c75f9e6f2fbe8a", async() => {
                    BeginContext(561, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(571, 91, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "faff1d613e904b4ab25030e198658080", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 17 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
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
                    BeginContext(662, 6, true);
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
                BeginContext(682, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(687, 191, true);
            WriteLiteral("<div class=\"row clearfix\">\r\n    <div class=\"col-lg-12 col-md-12 col-sm-12 col-xs-12\">\r\n        <div class=\"card\">\r\n            <div class=\"header\">\r\n                <h2>\r\n                    ");
            EndContext();
            BeginContext(879, 10, false);
#line 25 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
               Write(L("Roles"));

#line default
#line hidden
            EndContext();
            BeginContext(889, 594, true);
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
            BeginContext(1484, 12, false);
#line 33 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                                                                                                                                                  Write(L("Refresh"));

#line default
#line hidden
            EndContext();
            BeginContext(1496, 283, true);
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
            BeginContext(1780, 13, false);
#line 42 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                       Write(L("RoleName"));

#line default
#line hidden
            EndContext();
            BeginContext(1793, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(1829, 16, false);
#line 43 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                       Write(L("DisplayName"));

#line default
#line hidden
            EndContext();
            BeginContext(1845, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(1881, 12, false);
#line 44 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                       Write(L("Actions"));

#line default
#line hidden
            EndContext();
            BeginContext(1893, 93, true);
            WriteLiteral("</th>\r\n                    </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
            EndContext();
#line 48 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                     foreach (var role in Model.Roles)
                    {

#line default
#line hidden
            BeginContext(2065, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(2128, 9, false);
#line 51 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                           Write(role.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2137, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2177, 16, false);
#line 52 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                           Write(role.DisplayName);

#line default
#line hidden
            EndContext();
            BeginContext(2193, 498, true);
            WriteLiteral(@"</td>
                            <td class=""dropdown"">
                                <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">
                                    <i class=""material-icons"">menu</i>
                                </a>
                                <ul class=""dropdown-menu pull-right"">
                                    <li><a href=""#"" class=""waves-effect waves-block edit-role"" data-role-id=""");
            EndContext();
            BeginContext(2692, 7, false);
#line 58 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                                                                                                        Write(role.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2699, 85, true);
            WriteLiteral("\" data-toggle=\"modal\" data-target=\"#RoleEditModal\"><i class=\"material-icons\">edit</i>");
            EndContext();
            BeginContext(2785, 9, false);
#line 58 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                                                                                                                                                                                                     Write(L("Edit"));

#line default
#line hidden
            EndContext();
            BeginContext(2794, 122, true);
            WriteLiteral("</a></li>\r\n                                    <li><a href=\"#\" class=\"waves-effect waves-block delete-role\" data-role-id=\"");
            EndContext();
            BeginContext(2917, 7, false);
#line 59 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                                                                                                          Write(role.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2924, 18, true);
            WriteLiteral("\" data-role-name=\"");
            EndContext();
            BeginContext(2943, 9, false);
#line 59 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                                                                                                                                    Write(role.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2952, 44, true);
            WriteLiteral("\"><i class=\"material-icons\">delete_sweep</i>");
            EndContext();
            BeginContext(2997, 11, false);
#line 59 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                                                                                                                                                                                          Write(L("Delete"));

#line default
#line hidden
            EndContext();
            BeginContext(3008, 116, true);
            WriteLiteral("</a></li>\r\n                                </ul>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 63 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(3147, 111, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n                <div class=\"row\">\r\n                    ");
            EndContext();
            BeginContext(3259, 206, false);
#line 67 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
               Write(Html.Partial("~/Views/Shared/Modals/_PageInfo.cshtml", new PageViewModel("Roles", "Index", Model.PageIndex, Model.PageSize, Model.TotalPageCount, Model.HasPreviousPage, Model.HasNextPage, Model.TotalCount)));

#line default
#line hidden
            EndContext();
            BeginContext(3465, 680, true);
            WriteLiteral(@"
                    <div class=""col-md-9 text-right"">
                        <button type=""button"" class=""btn btn-primary btn-circle waves-effect waves-circle waves-float pull-right"" data-toggle=""modal"" data-target=""#RoleCreateModal"">
                            <i class=""material-icons"">add</i>
                        </button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""modal fade"" id=""RoleCreateModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""RoleCreateModalLabel"" data-backdrop=""static"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            ");
            EndContext();
            BeginContext(4146, 103, false);
#line 81 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
       Write(Html.Partial("~/Views/Shared/Modals/_ModalHeader.cshtml", new ModalHeaderViewModel(L("CreateNewRole"))));

#line default
#line hidden
            EndContext();
            BeginContext(4249, 56, true);
            WriteLiteral("\r\n            <div class=\"modal-body\">\r\n                ");
            EndContext();
            BeginContext(4305, 2961, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5366e56d5f1c4a07970ad8f02d9bf8bd", async() => {
                BeginContext(4380, 449, true);
                WriteLiteral(@"
                    <div class=""row clearfix"">
                        <div class=""col-sm-12"">
                            <div class=""form-group form-float"">
                                <div class=""form-line"">
                                    <input id=""rolename"" type=""text"" name=""Name"" required maxlength=""32"" minlength=""2"" class=""validate form-control"">
                                    <label for=""rolename"" class=""form-label"">");
                EndContext();
                BeginContext(4830, 13, false);
#line 89 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                                                                        Write(L("RoleName"));

#line default
#line hidden
                EndContext();
                BeginContext(4843, 606, true);
                WriteLiteral(@"</label>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""row clearfix"">
                        <div class=""col-sm-12"">
                            <div class=""form-group form-float"">
                                <div class=""form-line"">
                                    <input id=""displayname"" type=""text"" name=""DisplayName"" required maxlength=""32"" minlength=""2"" class=""validate form-control"">
                                    <label for=""displayname"" class=""form-label"">");
                EndContext();
                BeginContext(5450, 16, false);
#line 99 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                                                                           Write(L("DisplayName"));

#line default
#line hidden
                EndContext();
                BeginContext(5466, 571, true);
                WriteLiteral(@"</label>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-sm-12"">
                            <div class=""form-group form-float"">
                                <div class=""form-line"">
                                    <textarea id=""role-description"" name=""Description"" class=""validate form-control""></textarea>
                                    <label for=""role-description"" class=""form-label"">");
                EndContext();
                BeginContext(6038, 20, false);
#line 109 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                                                                                Write(L("RoleDescription"));

#line default
#line hidden
                EndContext();
                BeginContext(6058, 275, true);
                WriteLiteral(@"</label>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""row clearfix"">
                        <div class=""col-sm-12"">
                            <h4>");
                EndContext();
                BeginContext(6334, 16, false);
#line 116 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                           Write(L("Permissions"));

#line default
#line hidden
                EndContext();
                BeginContext(6350, 7, true);
                WriteLiteral("</h4>\r\n");
                EndContext();
#line 117 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                             foreach (var permission in Model.Permissions)
                            {

#line default
#line hidden
                BeginContext(6464, 132, true);
                WriteLiteral("                                <div class=\"col-sm-6\">\r\n                                    <input type=\"checkbox\" name=\"permission\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 6596, "\"", 6620, 1);
#line 120 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
WriteAttributeValue("", 6604, permission.Name, 6604, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6621, 18, true);
                WriteLiteral(" class=\"filled-in\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 6639, "\"", 6671, 2);
                WriteAttributeValue("", 6644, "permission-", 6644, 11, true);
#line 120 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
WriteAttributeValue("", 6655, permission.Name, 6655, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6672, 65, true);
                WriteLiteral(" checked=\"checked\" />\r\n                                    <label");
                EndContext();
                BeginWriteAttribute("for", " for=\"", 6737, "\"", 6770, 2);
                WriteAttributeValue("", 6743, "permission-", 6743, 11, true);
#line 121 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
WriteAttributeValue("", 6754, permission.Name, 6754, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6771, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(6773, 22, false);
#line 121 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                                                                        Write(permission.DisplayName);

#line default
#line hidden
                EndContext();
                BeginContext(6795, 50, true);
                WriteLiteral("</label>\r\n                                </div>\r\n");
                EndContext();
#line 123 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                            }

#line default
#line hidden
                BeginContext(6876, 212, true);
                WriteLiteral("                        </div>\r\n                    </div>\r\n                    <div class=\"modal-footer\">\r\n                        <button type=\"button\" class=\"btn btn-default waves-effect\" data-dismiss=\"modal\">");
                EndContext();
                BeginContext(7089, 11, false);
#line 127 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                                                                                                   Write(L("Cancel"));

#line default
#line hidden
                EndContext();
                BeginContext(7100, 94, true);
                WriteLiteral("</button>\r\n                        <button type=\"submit\" class=\"btn btn-primary waves-effect\">");
                EndContext();
                BeginContext(7195, 9, false);
#line 128 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                                                                              Write(L("Save"));

#line default
#line hidden
                EndContext();
                BeginContext(7204, 55, true);
                WriteLiteral("</button>\r\n                    </div>\r\n                ");
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
            BeginContext(7266, 316, true);
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""RoleEditModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""RoleEditModalLabel"" data-backdrop=""static"">
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ppl.Web.Models.Roles.RoleListViewModel<RoleDto,PermissionDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
