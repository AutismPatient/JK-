#pragma checksum "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d95d2c7bf50c4a2a14007c42cf1697f15eb214ef"
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
#line 1 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\_ViewImports.cshtml"
using Abp.Localization;

#line default
#line hidden
#line 1 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
using ppl.Web.Startup;

#line default
#line hidden
#line 2 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
using ppl.Web.Models.Common.Modals;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d95d2c7bf50c4a2a14007c42cf1697f15eb214ef", @"/Views/Roles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c11c579c28f192704a8097ac1871355b4dfde99", @"/Views/_ViewImports.cshtml")]
    public class Views_Roles_Index : ppl.Web.Views.pplRazorPage<ppl.Web.Models.Roles.RoleListViewModel>
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
#line 4 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
  
    ViewBag.CurrentPageName = PageNames.Roles; // The menu item will be active for this page.

#line default
#line hidden
            DefineSection("scripts", async() => {
                BeginContext(222, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(227, 148, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44955f08630e421481e3a7a538f08e0b", async() => {
                    BeginContext(260, 9, true);
                    WriteLiteral("\n        ");
                    EndContext();
                    BeginContext(269, 87, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c95c43242f1f492889dbf7ec8ed57c22", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 10 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
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
                    BeginContext(356, 5, true);
                    WriteLiteral("\n    ");
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
                BeginContext(375, 6, true);
                WriteLiteral("\n\n    ");
                EndContext();
                BeginContext(381, 159, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4874632c51c545ce97dae11e383c8615", async() => {
                    BeginContext(421, 9, true);
                    WriteLiteral("\n        ");
                    EndContext();
                    BeginContext(430, 91, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81d9d8595a7f4c0390a842b0ec28f274", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 14 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
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
                    BeginContext(521, 5, true);
                    WriteLiteral("\n    ");
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
                BeginContext(540, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            BeginContext(543, 186, true);
            WriteLiteral("<div class=\"row clearfix\">\n    <div class=\"col-lg-12 col-md-12 col-sm-12 col-xs-12\">\n        <div class=\"card\">\n            <div class=\"header\">\n                <h2>\n                    ");
            EndContext();
            BeginContext(730, 10, false);
#line 22 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
               Write(L("Roles"));

#line default
#line hidden
            EndContext();
            BeginContext(740, 586, true);
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
            BeginContext(1327, 12, false);
#line 30 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                                                                                                                                                  Write(L("Refresh"));

#line default
#line hidden
            EndContext();
            BeginContext(1339, 274, true);
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
            BeginContext(1614, 13, false);
#line 39 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                       Write(L("RoleName"));

#line default
#line hidden
            EndContext();
            BeginContext(1627, 34, true);
            WriteLiteral("</th>\n                        <th>");
            EndContext();
            BeginContext(1662, 16, false);
#line 40 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                       Write(L("DisplayName"));

#line default
#line hidden
            EndContext();
            BeginContext(1678, 34, true);
            WriteLiteral("</th>\n                        <th>");
            EndContext();
            BeginContext(1713, 12, false);
#line 41 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                       Write(L("Actions"));

#line default
#line hidden
            EndContext();
            BeginContext(1725, 89, true);
            WriteLiteral("</th>\n                    </tr>\n                    </thead>\n                    <tbody>\n");
            EndContext();
#line 45 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                     foreach (var role in Model.Roles)
                    {

#line default
#line hidden
            BeginContext(1891, 61, true);
            WriteLiteral("                        <tr>\n                            <td>");
            EndContext();
            BeginContext(1953, 9, false);
#line 48 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                           Write(role.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1962, 38, true);
            WriteLiteral("</td>\n                            <td>");
            EndContext();
            BeginContext(2001, 16, false);
#line 49 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                           Write(role.DisplayName);

#line default
#line hidden
            EndContext();
            BeginContext(2017, 492, true);
            WriteLiteral(@"</td>
                            <td class=""dropdown"">
                                <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">
                                    <i class=""material-icons"">menu</i>
                                </a>
                                <ul class=""dropdown-menu pull-right"">
                                    <li><a href=""#"" class=""waves-effect waves-block edit-role"" data-role-id=""");
            EndContext();
            BeginContext(2510, 7, false);
#line 55 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                                                                                                        Write(role.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2517, 85, true);
            WriteLiteral("\" data-toggle=\"modal\" data-target=\"#RoleEditModal\"><i class=\"material-icons\">edit</i>");
            EndContext();
            BeginContext(2603, 9, false);
#line 55 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                                                                                                                                                                                                     Write(L("Edit"));

#line default
#line hidden
            EndContext();
            BeginContext(2612, 121, true);
            WriteLiteral("</a></li>\n                                    <li><a href=\"#\" class=\"waves-effect waves-block delete-role\" data-role-id=\"");
            EndContext();
            BeginContext(2734, 7, false);
#line 56 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                                                                                                          Write(role.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2741, 18, true);
            WriteLiteral("\" data-role-name=\"");
            EndContext();
            BeginContext(2760, 9, false);
#line 56 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                                                                                                                                    Write(role.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2769, 44, true);
            WriteLiteral("\"><i class=\"material-icons\">delete_sweep</i>");
            EndContext();
            BeginContext(2814, 11, false);
#line 56 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                                                                                                                                                                                          Write(L("Delete"));

#line default
#line hidden
            EndContext();
            BeginContext(2825, 112, true);
            WriteLiteral("</a></li>\n                                </ul>\n                            </td>\n                        </tr>\n");
            EndContext();
#line 60 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2959, 592, true);
            WriteLiteral(@"                    </tbody>
                </table>
                <button type=""button"" class=""btn btn-primary btn-circle waves-effect waves-circle waves-float pull-right"" data-toggle=""modal"" data-target=""#RoleCreateModal"">
                    <i class=""material-icons"">add</i>
                </button>
            </div>
        </div>
    </div>
</div>
<div class=""modal fade"" id=""RoleCreateModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""RoleCreateModalLabel"" data-backdrop=""static"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            ");
            EndContext();
            BeginContext(3552, 103, false);
#line 73 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
       Write(Html.Partial("~/Views/Shared/Modals/_ModalHeader.cshtml", new ModalHeaderViewModel(L("CreateNewRole"))));

#line default
#line hidden
            EndContext();
            BeginContext(3655, 56, true);
            WriteLiteral("\r\n            <div class=\"modal-body\">\r\n                ");
            EndContext();
            BeginContext(3711, 2961, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12c632f4d2bb4cf2a919a0888fce148a", async() => {
                BeginContext(3786, 449, true);
                WriteLiteral(@"
                    <div class=""row clearfix"">
                        <div class=""col-sm-12"">
                            <div class=""form-group form-float"">
                                <div class=""form-line"">
                                    <input id=""rolename"" type=""text"" name=""Name"" required maxlength=""32"" minlength=""2"" class=""validate form-control"">
                                    <label for=""rolename"" class=""form-label"">");
                EndContext();
                BeginContext(4236, 13, false);
#line 81 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                                                                        Write(L("RoleName"));

#line default
#line hidden
                EndContext();
                BeginContext(4249, 606, true);
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
                BeginContext(4856, 16, false);
#line 91 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                                                                           Write(L("DisplayName"));

#line default
#line hidden
                EndContext();
                BeginContext(4872, 571, true);
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
                BeginContext(5444, 20, false);
#line 101 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                                                                                Write(L("RoleDescription"));

#line default
#line hidden
                EndContext();
                BeginContext(5464, 275, true);
                WriteLiteral(@"</label>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""row clearfix"">
                        <div class=""col-sm-12"">
                            <h4>");
                EndContext();
                BeginContext(5740, 16, false);
#line 108 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                           Write(L("Permissions"));

#line default
#line hidden
                EndContext();
                BeginContext(5756, 7, true);
                WriteLiteral("</h4>\r\n");
                EndContext();
#line 109 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                             foreach (var permission in Model.Permissions)
                            {

#line default
#line hidden
                BeginContext(5870, 132, true);
                WriteLiteral("                                <div class=\"col-sm-6\">\r\n                                    <input type=\"checkbox\" name=\"permission\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 6002, "\"", 6026, 1);
#line 112 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
WriteAttributeValue("", 6010, permission.Name, 6010, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6027, 18, true);
                WriteLiteral(" class=\"filled-in\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 6045, "\"", 6077, 2);
                WriteAttributeValue("", 6050, "permission-", 6050, 11, true);
#line 112 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
WriteAttributeValue("", 6061, permission.Name, 6061, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6078, 65, true);
                WriteLiteral(" checked=\"checked\" />\r\n                                    <label");
                EndContext();
                BeginWriteAttribute("for", " for=\"", 6143, "\"", 6176, 2);
                WriteAttributeValue("", 6149, "permission-", 6149, 11, true);
#line 113 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
WriteAttributeValue("", 6160, permission.Name, 6160, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6177, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(6179, 22, false);
#line 113 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                                                                        Write(permission.DisplayName);

#line default
#line hidden
                EndContext();
                BeginContext(6201, 50, true);
                WriteLiteral("</label>\r\n                                </div>\r\n");
                EndContext();
#line 115 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                            }

#line default
#line hidden
                BeginContext(6282, 212, true);
                WriteLiteral("                        </div>\r\n                    </div>\r\n                    <div class=\"modal-footer\">\r\n                        <button type=\"button\" class=\"btn btn-default waves-effect\" data-dismiss=\"modal\">");
                EndContext();
                BeginContext(6495, 11, false);
#line 119 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                                                                                                   Write(L("Cancel"));

#line default
#line hidden
                EndContext();
                BeginContext(6506, 94, true);
                WriteLiteral("</button>\r\n                        <button type=\"submit\" class=\"btn btn-primary waves-effect\">");
                EndContext();
                BeginContext(6601, 9, false);
#line 120 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                                                                              Write(L("Save"));

#line default
#line hidden
                EndContext();
                BeginContext(6610, 55, true);
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
            BeginContext(6672, 305, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ppl.Web.Models.Roles.RoleListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
