#pragma checksum "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bbe00c2d0095e9a114f13e1ba579bade57e7e64"
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
#line 1 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\_ViewImports.cshtml"
using Abp.Localization;

#line default
#line hidden
#line 1 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
using ppl.Web.Startup;

#line default
#line hidden
#line 2 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
using ppl.Web.Models.Common.Modals;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bbe00c2d0095e9a114f13e1ba579bade57e7e64", @"/Views/Roles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cc72928e58287740592435e67e86457ddcd9614", @"/Views/_ViewImports.cshtml")]
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
#line 4 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
  
    ViewBag.CurrentPageName = PageNames.Roles; // The menu item will be active for this page.

#line default
#line hidden
            DefineSection("scripts", async() => {
                BeginContext(229, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(235, 150, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f7c836d73c9401799a43a67a28df647", async() => {
                    BeginContext(268, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(278, 87, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a29e471e4b24416baacffd80e387df50", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 10 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
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
                    BeginContext(365, 6, true);
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
                BeginContext(385, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(393, 161, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "806e27b2dec54c6eb504dded810514b8", async() => {
                    BeginContext(433, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(443, 91, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e850a28ec0de41bb88a3d323f9f8a554", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 14 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
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
                    BeginContext(534, 6, true);
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
                BeginContext(554, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(559, 191, true);
            WriteLiteral("<div class=\"row clearfix\">\r\n    <div class=\"col-lg-12 col-md-12 col-sm-12 col-xs-12\">\r\n        <div class=\"card\">\r\n            <div class=\"header\">\r\n                <h2>\r\n                    ");
            EndContext();
            BeginContext(751, 10, false);
#line 22 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
               Write(L("Roles"));

#line default
#line hidden
            EndContext();
            BeginContext(761, 594, true);
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
            BeginContext(1356, 12, false);
#line 30 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                                                                                                                                                  Write(L("Refresh"));

#line default
#line hidden
            EndContext();
            BeginContext(1368, 283, true);
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
            BeginContext(1652, 13, false);
#line 39 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                       Write(L("RoleName"));

#line default
#line hidden
            EndContext();
            BeginContext(1665, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(1701, 16, false);
#line 40 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                       Write(L("DisplayName"));

#line default
#line hidden
            EndContext();
            BeginContext(1717, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(1753, 12, false);
#line 41 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                       Write(L("Actions"));

#line default
#line hidden
            EndContext();
            BeginContext(1765, 93, true);
            WriteLiteral("</th>\r\n                    </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
            EndContext();
#line 45 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                     foreach (var role in Model.Roles)
                    {

#line default
#line hidden
            BeginContext(1937, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(2000, 9, false);
#line 48 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                           Write(role.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2009, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2049, 16, false);
#line 49 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                           Write(role.DisplayName);

#line default
#line hidden
            EndContext();
            BeginContext(2065, 498, true);
            WriteLiteral(@"</td>
                            <td class=""dropdown"">
                                <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">
                                    <i class=""material-icons"">menu</i>
                                </a>
                                <ul class=""dropdown-menu pull-right"">
                                    <li><a href=""#"" class=""waves-effect waves-block edit-role"" data-role-id=""");
            EndContext();
            BeginContext(2564, 7, false);
#line 55 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                                                                                                        Write(role.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2571, 85, true);
            WriteLiteral("\" data-toggle=\"modal\" data-target=\"#RoleEditModal\"><i class=\"material-icons\">edit</i>");
            EndContext();
            BeginContext(2657, 9, false);
#line 55 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                                                                                                                                                                                                     Write(L("Edit"));

#line default
#line hidden
            EndContext();
            BeginContext(2666, 122, true);
            WriteLiteral("</a></li>\r\n                                    <li><a href=\"#\" class=\"waves-effect waves-block delete-role\" data-role-id=\"");
            EndContext();
            BeginContext(2789, 7, false);
#line 56 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                                                                                                          Write(role.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2796, 18, true);
            WriteLiteral("\" data-role-name=\"");
            EndContext();
            BeginContext(2815, 9, false);
#line 56 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                                                                                                                                    Write(role.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2824, 44, true);
            WriteLiteral("\"><i class=\"material-icons\">delete_sweep</i>");
            EndContext();
            BeginContext(2869, 11, false);
#line 56 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                                                                                                                                                                                          Write(L("Delete"));

#line default
#line hidden
            EndContext();
            BeginContext(2880, 116, true);
            WriteLiteral("</a></li>\r\n                                </ul>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 60 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(3019, 603, true);
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
            BeginContext(3623, 103, false);
#line 73 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
       Write(Html.Partial("~/Views/Shared/Modals/_ModalHeader.cshtml", new ModalHeaderViewModel(L("CreateNewRole"))));

#line default
#line hidden
            EndContext();
            BeginContext(3726, 56, true);
            WriteLiteral("\r\n            <div class=\"modal-body\">\r\n                ");
            EndContext();
            BeginContext(3782, 2961, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8493d33700c4f949ae25b3f6a8ac78a", async() => {
                BeginContext(3857, 449, true);
                WriteLiteral(@"
                    <div class=""row clearfix"">
                        <div class=""col-sm-12"">
                            <div class=""form-group form-float"">
                                <div class=""form-line"">
                                    <input id=""rolename"" type=""text"" name=""Name"" required maxlength=""32"" minlength=""2"" class=""validate form-control"">
                                    <label for=""rolename"" class=""form-label"">");
                EndContext();
                BeginContext(4307, 13, false);
#line 81 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                                                                        Write(L("RoleName"));

#line default
#line hidden
                EndContext();
                BeginContext(4320, 606, true);
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
                BeginContext(4927, 16, false);
#line 91 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                                                                           Write(L("DisplayName"));

#line default
#line hidden
                EndContext();
                BeginContext(4943, 571, true);
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
                BeginContext(5515, 20, false);
#line 101 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                                                                                Write(L("RoleDescription"));

#line default
#line hidden
                EndContext();
                BeginContext(5535, 275, true);
                WriteLiteral(@"</label>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""row clearfix"">
                        <div class=""col-sm-12"">
                            <h4>");
                EndContext();
                BeginContext(5811, 16, false);
#line 108 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                           Write(L("Permissions"));

#line default
#line hidden
                EndContext();
                BeginContext(5827, 7, true);
                WriteLiteral("</h4>\r\n");
                EndContext();
#line 109 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                             foreach (var permission in Model.Permissions)
                            {

#line default
#line hidden
                BeginContext(5941, 132, true);
                WriteLiteral("                                <div class=\"col-sm-6\">\r\n                                    <input type=\"checkbox\" name=\"permission\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 6073, "\"", 6097, 1);
#line 112 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
WriteAttributeValue("", 6081, permission.Name, 6081, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6098, 18, true);
                WriteLiteral(" class=\"filled-in\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 6116, "\"", 6148, 2);
                WriteAttributeValue("", 6121, "permission-", 6121, 11, true);
#line 112 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
WriteAttributeValue("", 6132, permission.Name, 6132, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6149, 65, true);
                WriteLiteral(" checked=\"checked\" />\r\n                                    <label");
                EndContext();
                BeginWriteAttribute("for", " for=\"", 6214, "\"", 6247, 2);
                WriteAttributeValue("", 6220, "permission-", 6220, 11, true);
#line 113 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
WriteAttributeValue("", 6231, permission.Name, 6231, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6248, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(6250, 22, false);
#line 113 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                                                                        Write(permission.DisplayName);

#line default
#line hidden
                EndContext();
                BeginContext(6272, 50, true);
                WriteLiteral("</label>\r\n                                </div>\r\n");
                EndContext();
#line 115 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                            }

#line default
#line hidden
                BeginContext(6353, 212, true);
                WriteLiteral("                        </div>\r\n                    </div>\r\n                    <div class=\"modal-footer\">\r\n                        <button type=\"button\" class=\"btn btn-default waves-effect\" data-dismiss=\"modal\">");
                EndContext();
                BeginContext(6566, 11, false);
#line 119 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                                                                                                   Write(L("Cancel"));

#line default
#line hidden
                EndContext();
                BeginContext(6577, 94, true);
                WriteLiteral("</button>\r\n                        <button type=\"submit\" class=\"btn btn-primary waves-effect\">");
                EndContext();
                BeginContext(6672, 9, false);
#line 120 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Roles\Index.cshtml"
                                                                              Write(L("Save"));

#line default
#line hidden
                EndContext();
                BeginContext(6681, 55, true);
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
            BeginContext(6743, 316, true);
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
