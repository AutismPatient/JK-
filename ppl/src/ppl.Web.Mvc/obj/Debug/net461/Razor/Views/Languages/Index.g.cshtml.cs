#pragma checksum "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Languages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73b41859b38fdb1dd195bc44db02f1b4d7ffc70e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Languages_Index), @"mvc.1.0.view", @"/Views/Languages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Languages/Index.cshtml", typeof(AspNetCore.Views_Languages_Index))]
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
#line 1 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Languages\Index.cshtml"
using ppl;

#line default
#line hidden
#line 2 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Languages\Index.cshtml"
using ppl.Web.Models.Languages;

#line default
#line hidden
#line 3 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Languages\Index.cshtml"
using ppl.Web.Startup;

#line default
#line hidden
#line 4 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Languages\Index.cshtml"
using ppl.Web.Models.Common.Modals;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73b41859b38fdb1dd195bc44db02f1b4d7ffc70e", @"/Views/Languages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cc72928e58287740592435e67e86457ddcd9614", @"/Views/_ViewImports.cshtml")]
    public class Views_Languages_Index : ppl.Web.Views.pplRazorPage<GetLanguageViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/view-resources/Views/Languages/Index.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("languagesCreateForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 6 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Languages\Index.cshtml"
  
    ViewBag.CurrentPageName = PageNames.Language; // The menu item will be active for this page.

#line default
#line hidden
            DefineSection("scripts", async() => {
                BeginContext(263, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(269, 154, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15fa56f6f9cc4dabba995f8dc9d0696e", async() => {
                    BeginContext(302, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(312, 91, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c8d43bf4faf446abedc307cfc525838", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 12 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Languages\Index.cshtml"
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
                    BeginContext(403, 6, true);
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
                BeginContext(423, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(428, 1353, true);
            WriteLiteral(@"<div class=""row clearfix"">
    <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
        <div class=""card"">
            <div class=""header"">
                <h2>
                    系统语言管理
                </h2>
                <ul class=""header-dropdown m-r--5"">
                    <li class=""dropdown"">
                        <a href=""javascript:void(0);"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">
                            <i class=""material-icons"">more_vert</i>
                        </a>
                        <ul class=""dropdown-menu pull-right"">
                            <li><a id=""RefreshButton"" href=""javascript:void(0);"" class=""waves-effect waves-block""><i class=""material-icons"">refresh</i>刷新</a></li>
                        </ul>
                    </li>
                </ul>
            </div>
            <div class=""body table-responsive"">
                <table class=""table"">
                    <thead>
  ");
            WriteLiteral(@"                      <tr>
                            <th>名称</th>
                            <th>标记代码</th>
                            <th>创建时间</th>
                            <th>启用状态</th>
                            <th>操作</th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 45 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Languages\Index.cshtml"
                         foreach (var languages in Model.Items)
                        {

#line default
#line hidden
            BeginContext(1873, 72, true);
            WriteLiteral("                            <tr>\r\n                                <td><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1945, "\"", 1968, 1);
#line 48 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Languages\Index.cshtml"
WriteAttributeValue("", 1953, languages.Icon, 1953, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1969, 8, true);
            WriteLiteral("></i>   ");
            EndContext();
            BeginContext(1978, 21, false);
#line 48 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Languages\Index.cshtml"
                                                                 Write(languages.DisplayName);

#line default
#line hidden
            EndContext();
            BeginContext(1999, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2043, 14, false);
#line 49 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Languages\Index.cshtml"
                               Write(languages.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2057, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2101, 22, false);
#line 50 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Languages\Index.cshtml"
                               Write(languages.CreationTime);

#line default
#line hidden
            EndContext();
            BeginContext(2123, 68, true);
            WriteLiteral("</td>\r\n                                <td><i class=\"material-icons\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 2191, "\"", 2246, 3);
            WriteAttributeValue("", 2199, "color:", 2199, 6, true);
#line 51 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Languages\Index.cshtml"
WriteAttributeValue("", 2205, !languages.IsDisabled ? "green":"red", 2205, 40, false);

#line default
#line hidden
            WriteAttributeValue("", 2245, ";", 2245, 1, true);
            EndWriteAttribute();
            BeginContext(2247, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2250, 63, false);
#line 51 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Languages\Index.cshtml"
                                                                                                                  Write(!languages.IsDisabled ? "check_box" : "indeterminate_check_box");

#line default
#line hidden
            EndContext();
            BeginContext(2314, 516, true);
            WriteLiteral(@"</i></td>
                                <td class=""dropdown"">
                                    <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">
                                        <i class=""material-icons"">menu</i>
                                    </a>
                                    <ul class=""dropdown-menu pull-right"">
                                        <li><a href=""#"" class=""waves-effect waves-block edit"" data-id=""");
            EndContext();
            BeginContext(2831, 12, false);
#line 57 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Languages\Index.cshtml"
                                                                                                  Write(languages.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2843, 208, true);
            WriteLiteral("\" data-toggle=\"modal\" data-target=\"#LanguagesEditModal\"><i class=\"material-icons\">edit</i>修正</a></li>\r\n                                        <li><a href=\"#\" class=\"waves-effect waves-block delete\" data-id=\"");
            EndContext();
            BeginContext(3052, 12, false);
#line 58 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Languages\Index.cshtml"
                                                                                                    Write(languages.Id);

#line default
#line hidden
            EndContext();
            BeginContext(3064, 13, true);
            WriteLiteral("\" data-name=\"");
            EndContext();
            BeginContext(3078, 21, false);
#line 58 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Languages\Index.cshtml"
                                                                                                                              Write(languages.DisplayName);

#line default
#line hidden
            EndContext();
            BeginContext(3099, 174, true);
            WriteLiteral("\"><i class=\"material-icons\">delete_sweep</i>删除</a></li>\r\n                                    </ul>\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 62 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Languages\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(3300, 615, true);
            WriteLiteral(@"                    </tbody>
                </table>
                <button type=""button"" class=""btn btn-primary btn-circle waves-effect waves-circle waves-float pull-right"" data-toggle=""modal"" data-target=""#LanguagesCreateModal"">
                    <i class=""material-icons"">add</i>
                </button>
            </div>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""LanguagesCreateModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""UserCreateModalLabel"" data-backdrop=""static"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            ");
            EndContext();
            BeginContext(3916, 96, false);
#line 76 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Languages\Index.cshtml"
       Write(Html.Partial("~/Views/Shared/Modals/_ModalHeader.cshtml", new ModalHeaderViewModel("为系统创建新的语言")));

#line default
#line hidden
            EndContext();
            BeginContext(4012, 56, true);
            WriteLiteral("\r\n            <div class=\"modal-body\">\r\n                ");
            EndContext();
            BeginContext(4068, 2506, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffa7077fac274dad931183b75f30a4ca", async() => {
                BeginContext(4148, 390, true);
                WriteLiteral(@"
                    <div role=""tabpanel"" class=""tab-pane animated fadeIn "">
                        <div class=""row clearfix"" style=""margin-top:10px;"">
                            <div class=""col-sm-12"">
                                <div class=""form-group form-float"">
                                    <label for=""createLanguage"">语言</label>
                                    ");
                EndContext();
                BeginContext(4539, 411, false);
#line 84 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Languages\Index.cshtml"
                               Write(Html.DropDownList("Name",Model.LanguageNames.Select(i=>i.ToSelectItem()),new{
                                   @class= "form-control bs-select",
                                   data_live_search="true",
                                   @required= "required",
                                   name = "Name",
                                   id = "createLanguage"
                               }));

#line default
#line hidden
                EndContext();
                BeginContext(4950, 523, true);
                WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                        <div class=""row clearfix"" style=""margin-top:10px;"">
                            <div class=""col-sm-12"">
                                <div class=""form-group form-float"">
                                    <label for=""Icon"">语言标记</label>
                                    <select id=""DisplayName"" name=""DisplayName"" class=""form-control bs-select"" data-live-search=""true"" required>
");
                EndContext();
#line 99 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Languages\Index.cshtml"
                                         foreach (var flag in Model.Flags)
                                        {

#line default
#line hidden
                BeginContext(5592, 44, true);
                WriteLiteral("                                            ");
                EndContext();
                BeginContext(5636, 105, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f468ea2fe174ba495ad074938596423", async() => {
                    BeginContext(5688, 2, true);
                    WriteLiteral("<i");
                    EndContext();
                    BeginWriteAttribute("class", " class=\"", 5690, "\"", 5709, 1);
#line 101 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Languages\Index.cshtml"
WriteAttributeValue("", 5698, flag.Value, 5698, 11, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(5710, 5, true);
                    WriteLiteral("></i>");
                    EndContext();
                    BeginContext(5716, 16, false);
#line 101 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Languages\Index.cshtml"
                                                                                                                      Write(flag.DisplayText);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 101 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Languages\Index.cshtml"
                                                          Write(flag.Value);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("data-icon", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 101 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Languages\Index.cshtml"
                                                                       WriteLiteral(flag.Value);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5741, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 102 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Languages\Index.cshtml"
                                        }

#line default
#line hidden
                BeginContext(5786, 781, true);
                WriteLiteral(@"                                    </select>
                                    <input type=""hidden"" name=""Icon"" value="""" />
                                </div>
                            </div>
                        </div>
                        <div class=""row clearfix"" style=""margin-top:10px;"">
                            <div class=""col-sm-12"">
                                <div class=""form-group form-float"">
                                    <input type=""checkbox"" name=""IsEnabled"" class=""filled-in"" id=""IsEnabled"">
                                    <label for=""IsEnabled"" class="""">是否启用</label>
                                </div>
                            </div>
                        </div>
                    </div>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6574, 158, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"modal-footer\">\r\n                <button type=\"button\" class=\"btn btn-default waves-effect\" data-dismiss=\"modal\">");
            EndContext();
            BeginContext(6733, 11, false);
#line 120 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Languages\Index.cshtml"
                                                                                           Write(L("Cancel"));

#line default
#line hidden
            EndContext();
            BeginContext(6744, 98, true);
            WriteLiteral("</button>\r\n                <button type=\"submit\" class=\"btn btn-primary waves-effect\" id=\"submit\">");
            EndContext();
            BeginContext(6843, 9, false);
#line 121 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Languages\Index.cshtml"
                                                                                  Write(L("Save"));

#line default
#line hidden
            EndContext();
            BeginContext(6852, 291, true);
            WriteLiteral(@"</button>
            </div>
        </div>
    </div>
</div>
<div class=""modal fade"" id=""LanguagesEditModal"" tabindex=""-1"" role=""dialog"" data-backdrop=""static"">
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GetLanguageViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
