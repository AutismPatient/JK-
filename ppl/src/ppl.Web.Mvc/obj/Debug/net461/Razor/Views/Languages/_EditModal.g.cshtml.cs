#pragma checksum "D:\git-re\-\ppl\src\ppl.Web.Mvc\Views\Languages\_EditModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2af2090c1e0afe6608be8aeef4d081419d6aac4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Languages__EditModal), @"mvc.1.0.view", @"/Views/Languages/_EditModal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Languages/_EditModal.cshtml", typeof(AspNetCore.Views_Languages__EditModal))]
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
#line 1 "D:\git-re\-\ppl\src\ppl.Web.Mvc\Views\Languages\_EditModal.cshtml"
using ppl;

#line default
#line hidden
#line 2 "D:\git-re\-\ppl\src\ppl.Web.Mvc\Views\Languages\_EditModal.cshtml"
using ppl.Web.Models.Languages;

#line default
#line hidden
#line 3 "D:\git-re\-\ppl\src\ppl.Web.Mvc\Views\Languages\_EditModal.cshtml"
using ppl.Web.Startup;

#line default
#line hidden
#line 4 "D:\git-re\-\ppl\src\ppl.Web.Mvc\Views\Languages\_EditModal.cshtml"
using static ppl.JklConsts;

#line default
#line hidden
#line 5 "D:\git-re\-\ppl\src\ppl.Web.Mvc\Views\Languages\_EditModal.cshtml"
using ppl.Web.Models.Common.Modals;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2af2090c1e0afe6608be8aeef4d081419d6aac4", @"/Views/Languages/_EditModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cc72928e58287740592435e67e86457ddcd9614", @"/Views/_ViewImports.cshtml")]
    public class Views_Languages__EditModal : ppl.Web.Views.pplRazorPage<ppl.Web.Models.Languages.GetLanguagesEdit>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("languagesEditForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/view-resources/Views/Languages/_Edit.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(185, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "D:\git-re\-\ppl\src\ppl.Web.Mvc\Views\Languages\_EditModal.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(302, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(305, 93, false);
#line 13 "D:\git-re\-\ppl\src\ppl.Web.Mvc\Views\Languages\_EditModal.cshtml"
Write(Html.Partial("~/Views/Shared/Modals/_ModalHeader.cshtml", new ModalHeaderViewModel("编辑语言内容")));

#line default
#line hidden
            EndContext();
            BeginContext(398, 32, true);
            WriteLiteral("\r\n<div class=\"modal-body\">\r\n    ");
            EndContext();
            BeginContext(430, 2233, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "003680809f424c8db14a2f1eb25f6c47", async() => {
                BeginContext(508, 40, true);
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"Id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 548, "\"", 574, 1);
#line 16 "D:\git-re\-\ppl\src\ppl.Web.Mvc\Views\Languages\_EditModal.cshtml"
WriteAttributeValue("", 556, Model.Language.Id, 556, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(575, 321, true);
                WriteLiteral(@" />
        <div role=""tabpanel"" class=""tab-pane animated fadeIn "">
            <div class=""row clearfix"" style=""margin-top:10px;"">
                <div class=""col-sm-12"">
                    <div class=""form-group form-float"">
                        <label for=""createLanguage"">语言</label>
                        ");
                EndContext();
                BeginContext(897, 339, false);
#line 22 "D:\git-re\-\ppl\src\ppl.Web.Mvc\Views\Languages\_EditModal.cshtml"
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
                BeginContext(1236, 427, true);
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
#line 37 "D:\git-re\-\ppl\src\ppl.Web.Mvc\Views\Languages\_EditModal.cshtml"
                             foreach (var flag in Model.Flags)
                            {

#line default
#line hidden
                BeginContext(1758, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(1790, 144, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8630de66e254f91bb710ad11ea2f35b", async() => {
                    BeginContext(1870, 30, true);
                    WriteLiteral("<i class=\"famfamfam-flags zm\">");
                    EndContext();
                    BeginContext(1901, 16, false);
#line 39 "D:\git-re\-\ppl\src\ppl.Web.Mvc\Views\Languages\_EditModal.cshtml"
                                                                                                                                         Write(flag.DisplayText);

#line default
#line hidden
                    EndContext();
                    BeginContext(1917, 8, true);
                    WriteLiteral("</i>    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 39 "D:\git-re\-\ppl\src\ppl.Web.Mvc\Views\Languages\_EditModal.cshtml"
                                              Write(flag.Value);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("data-icon", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 39 "D:\git-re\-\ppl\src\ppl.Web.Mvc\Views\Languages\_EditModal.cshtml"
                                                           WriteLiteral(flag.Value);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "selected", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 39 "D:\git-re\-\ppl\src\ppl.Web.Mvc\Views\Languages\_EditModal.cshtml"
AddHtmlAttributeValue("", 1852, flag.IsSelected, 1852, 16, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1934, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 40 "D:\git-re\-\ppl\src\ppl.Web.Mvc\Views\Languages\_EditModal.cshtml"
                            }

#line default
#line hidden
                BeginContext(1967, 404, true);
                WriteLiteral(@"                        </select>
                        <input type=""hidden"" name=""Icon"" value="""" />
                    </div>
                </div>
            </div>
            <div class=""row clearfix"" style=""margin-top:10px;"">
                <div class=""col-sm-12"">
                    <div class=""form-group form-float"">
                        <input type=""checkbox"" name=""IsDisabled""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2371, "\"", 2416, 1);
#line 49 "D:\git-re\-\ppl\src\ppl.Web.Mvc\Views\Languages\_EditModal.cshtml"
WriteAttributeValue("", 2379, Model.Language.IsDisabled.ToString(), 2379, 37, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2417, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(2420, 42, false);
#line 49 "D:\git-re\-\ppl\src\ppl.Web.Mvc\Views\Languages\_EditModal.cshtml"
                                                                                                           Write(Model.Language.IsDisabled ? "" : "checked");

#line default
#line hidden
                EndContext();
                BeginContext(2463, 193, true);
                WriteLiteral(" class=\"filled-in\" id=\"IsDisabled1\">\r\n                        <label for=\"IsDisabled1\">是否启用</label>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    ");
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
            BeginContext(2663, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(2670, 74, false);
#line 56 "D:\git-re\-\ppl\src\ppl.Web.Mvc\Views\Languages\_EditModal.cshtml"
Write(Html.Partial("~/Views/Shared/Modals/_ModalFooterWithSaveAndCancel.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(2744, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(2756, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50a802d0c7c140db92159af31a696119", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2821, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ppl.Web.Models.Languages.GetLanguagesEdit> Html { get; private set; }
    }
}
#pragma warning restore 1591
