#pragma checksum "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Users\_EditUserModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d59a3219e86b472914661d7526d672cded2b9262"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users__EditUserModal), @"mvc.1.0.view", @"/Views/Users/_EditUserModal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/_EditUserModal.cshtml", typeof(AspNetCore.Views_Users__EditUserModal))]
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
#line 1 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Users\_EditUserModal.cshtml"
using ppl.Web.Models.Common.Modals;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d59a3219e86b472914661d7526d672cded2b9262", @"/Views/Users/_EditUserModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cc72928e58287740592435e67e86457ddcd9614", @"/Views/_ViewImports.cshtml")]
    public class Views_Users__EditUserModal : ppl.Web.Views.pplRazorPage<ppl.Web.Models.Users.EditUserModalViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("UserEditForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/view-resources/Views/Users/_EditUserModal.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Users\_EditUserModal.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(117, 98, false);
#line 6 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Users\_EditUserModal.cshtml"
Write(Html.Partial("~/Views/Shared/Modals/_ModalHeader.cshtml", new ModalHeaderViewModel(L("EditUser"))));

#line default
#line hidden
            EndContext();
            BeginContext(215, 34, true);
            WriteLiteral("\r\n\r\n<div class=\"modal-body\">\r\n    ");
            EndContext();
            BeginContext(249, 4303, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c49b1ee769134e92aa4759e068258298", async() => {
                BeginContext(322, 40, true);
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"Id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 362, "\"", 384, 1);
#line 10 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Users\_EditUserModal.cshtml"
WriteAttributeValue("", 370, Model.User.Id, 370, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(385, 167, true);
                WriteLiteral(" />\r\n        <ul class=\"nav nav-tabs tab-nav-right\" role=\"tablist\">\r\n            <li role=\"presentation\" class=\"active\"><a href=\"#edit-user-details\" data-toggle=\"tab\">");
                EndContext();
                BeginContext(553, 16, false);
#line 12 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Users\_EditUserModal.cshtml"
                                                                                             Write(L("UserDetails"));

#line default
#line hidden
                EndContext();
                BeginContext(569, 92, true);
                WriteLiteral("</a></li>\r\n            <li role=\"presentation\"><a href=\"#edit-user-roles\" data-toggle=\"tab\">");
                EndContext();
                BeginContext(662, 14, false);
#line 13 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Users\_EditUserModal.cshtml"
                                                                            Write(L("UserRoles"));

#line default
#line hidden
                EndContext();
                BeginContext(676, 469, true);
                WriteLiteral(@"</a></li>
        </ul>
        <div class=""tab-content"">
            <div role=""tabpanel"" class=""tab-pane animated fadeIn active"" id=""edit-user-details"">

                <div class=""row clearfix"" style=""margin-top:10px;"">
                    <div class=""col-sm-12"">
                        <div class=""form-group form-float"">
                            <div class=""form-line"">
                                <input id=""username"" type=""text"" name=""UserName""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1145, "\"", 1173, 1);
#line 22 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Users\_EditUserModal.cshtml"
WriteAttributeValue("", 1153, Model.User.UserName, 1153, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1174, 144, true);
                WriteLiteral(" required maxlength=\"32\" minlength=\"2\" class=\"validate form-control\">\r\n                                <label for=\"username\" class=\"form-label\">");
                EndContext();
                BeginContext(1319, 13, false);
#line 23 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Users\_EditUserModal.cshtml"
                                                                    Write(L("UserName"));

#line default
#line hidden
                EndContext();
                BeginContext(1332, 406, true);
                WriteLiteral(@"</label>
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""row clearfix"">
                    <div class=""col-sm-6"">
                        <div class=""form-group form-float"">
                            <div class=""form-line"">
                                <input id=""name"" type=""text"" name=""Name""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1738, "\"", 1762, 1);
#line 33 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Users\_EditUserModal.cshtml"
WriteAttributeValue("", 1746, Model.User.Name, 1746, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1763, 126, true);
                WriteLiteral(" required maxlength=\"32\" class=\"validate form-control\">\r\n                                <label for=\"name\" class=\"form-label\">");
                EndContext();
                BeginContext(1890, 9, false);
#line 34 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Users\_EditUserModal.cshtml"
                                                                Write(L("Name"));

#line default
#line hidden
                EndContext();
                BeginContext(1899, 342, true);
                WriteLiteral(@"</label>
                            </div>
                        </div>
                    </div>
                    <div class=""col-sm-6"">
                        <div class=""form-group form-float"">
                            <div class=""form-line"">
                                <input id=""surname"" type=""text"" name=""Surname""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2241, "\"", 2268, 1);
#line 41 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Users\_EditUserModal.cshtml"
WriteAttributeValue("", 2249, Model.User.Surname, 2249, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2269, 129, true);
                WriteLiteral(" required maxlength=\"32\" class=\"validate form-control\">\r\n                                <label for=\"surname\" class=\"form-label\">");
                EndContext();
                BeginContext(2399, 12, false);
#line 42 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Users\_EditUserModal.cshtml"
                                                                   Write(L("Surname"));

#line default
#line hidden
                EndContext();
                BeginContext(2411, 417, true);
                WriteLiteral(@"</label>
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""row clearfix"">
                    <div class=""col-sm-12"">
                        <div class=""form-group form-float"">
                            <div class=""form-line"">
                                <input id=""email"" type=""email"" name=""EmailAddress""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2828, "\"", 2860, 1);
#line 52 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Users\_EditUserModal.cshtml"
WriteAttributeValue("", 2836, Model.User.EmailAddress, 2836, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2861, 119, true);
                WriteLiteral(" maxlength=\"256\" class=\"validate form-control\">\r\n                                <label for=\"email\" class=\"form-label\">");
                EndContext();
                BeginContext(2981, 17, false);
#line 53 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Users\_EditUserModal.cshtml"
                                                                 Write(L("EmailAddress"));

#line default
#line hidden
                EndContext();
                BeginContext(2998, 424, true);
                WriteLiteral(@"</label>
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""row clearfix"">
                    <div class=""col-sm-12"">
                        <div class=""form-group form-float"">
                            <div class="""">
                                <input id=""IsActive"" type=""checkbox"" name=""IsActive"" value=""true"" ");
                EndContext();
                BeginContext(3424, 36, false);
#line 63 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Users\_EditUserModal.cshtml"
                                                                                              Write(Model.User.IsActive ? "checked" : "");

#line default
#line hidden
                EndContext();
                BeginContext(3461, 99, true);
                WriteLiteral(" class=\"form-control\" />\r\n                                <label for=\"IsActive\" class=\"form-label\">");
                EndContext();
                BeginContext(3561, 13, false);
#line 64 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Users\_EditUserModal.cshtml"
                                                                    Write(L("IsActive"));

#line default
#line hidden
                EndContext();
                BeginContext(3574, 322, true);
                WriteLiteral(@"</label>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <div role=""tabpanel"" class=""tab-pane animated fadeIn"" id=""edit-user-roles"">
                <div class=""row"">
                    <div class=""col-sm-12 "">
");
                EndContext();
#line 74 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Users\_EditUserModal.cshtml"
                         foreach (var role in Model.Roles)
                        {

#line default
#line hidden
                BeginContext(3983, 118, true);
                WriteLiteral("                            <div class=\"col-sm-6\">\r\n                                <input type=\"checkbox\" name=\"role\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4101, "\"", 4129, 1);
#line 77 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Users\_EditUserModal.cshtml"
WriteAttributeValue("", 4109, role.NormalizedName, 4109, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 4130, "\"", 4155, 1);
#line 77 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Users\_EditUserModal.cshtml"
WriteAttributeValue("", 4138, role.Description, 4138, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4156, 18, true);
                WriteLiteral(" class=\"filled-in\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 4174, "\"", 4212, 1);
#line 77 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Users\_EditUserModal.cshtml"
WriteAttributeValue("", 4179, string.Format("role{0}",role.Id), 4179, 33, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4213, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(4216, 41, false);
#line 77 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Users\_EditUserModal.cshtml"
                                                                                                                                                                               Write(Model.UserIsInRole(role) ? "checked" : "");

#line default
#line hidden
                EndContext();
                BeginContext(4258, 43, true);
                WriteLiteral(" />\r\n                                <label");
                EndContext();
                BeginWriteAttribute("for", " for=\"", 4301, "\"", 4340, 1);
#line 78 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Users\_EditUserModal.cshtml"
WriteAttributeValue("", 4307, string.Format("role{0}",role.Id), 4307, 33, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 4341, "\"", 4366, 1);
#line 78 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Users\_EditUserModal.cshtml"
WriteAttributeValue("", 4349, role.DisplayName, 4349, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4367, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(4369, 9, false);
#line 78 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Users\_EditUserModal.cshtml"
                                                                                                    Write(role.Name);

#line default
#line hidden
                EndContext();
                BeginContext(4378, 46, true);
                WriteLiteral("</label>\r\n                            </div>\r\n");
                EndContext();
#line 80 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Users\_EditUserModal.cshtml"
                        }

#line default
#line hidden
                BeginContext(4451, 94, true);
                WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    ");
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
            BeginContext(4552, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(4559, 74, false);
#line 87 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Users\_EditUserModal.cshtml"
Write(Html.Partial("~/Views/Shared/Modals/_ModalFooterWithSaveAndCancel.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(4633, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
            BeginContext(4643, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e25e35ee547f41d0863a67dbd5688e42", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 89 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Users\_EditUserModal.cshtml"
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
            BeginContext(4739, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ppl.Web.Models.Users.EditUserModalViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
