#pragma checksum "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\WebSetting\EditForWeb.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "014aa29478c75623e1a0c8a68d89443bcb7e148f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WebSetting_EditForWeb), @"mvc.1.0.view", @"/Views/WebSetting/EditForWeb.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/WebSetting/EditForWeb.cshtml", typeof(AspNetCore.Views_WebSetting_EditForWeb))]
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
#line 1 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\WebSetting\EditForWeb.cshtml"
using ppl.Web.Startup;

#line default
#line hidden
#line 2 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\WebSetting\EditForWeb.cshtml"
using static ppl.JklConsts;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"014aa29478c75623e1a0c8a68d89443bcb7e148f", @"/Views/WebSetting/EditForWeb.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cc72928e58287740592435e67e86457ddcd9614", @"/Views/_ViewImports.cshtml")]
    public class Views_WebSetting_EditForWeb : ppl.Web.Views.pplRazorPage<ppl.Web.Models.WebSettings.CreateOrUpdateViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/view-resources/Views/WebSetting/Index.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("SettingForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\WebSetting\EditForWeb.cshtml"
  
    ViewBag.CurrentPageName = "WebParameter";

#line default
#line hidden
            DefineSection("scripts", async() => {
                BeginContext(189, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(195, 155, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38aa037a94954f528ceee77f7032143c", async() => {
                    BeginContext(228, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(238, 92, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b52f1db9158449ea6e5223c5e051b4f", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 10 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\WebSetting\EditForWeb.cshtml"
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
                    BeginContext(330, 6, true);
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
                BeginContext(350, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(355, 568, true);
            WriteLiteral(@"<style>
    .seach {
        padding: 0px;
        margin-left: 0;
        margin-right: 0;
    }

    .error {
        color: red;
        font-size: .8rem;
    }

    .seach input {
        border-radius: 0;
    }
</style>
<div class=""row clearfix body-list"">
    <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
        <div class=""card"">
            <div class=""header"">
                <h2><b>站点基础参数设置：</b> </h2>
            </div>
            <div class=""body table-responsive"">
                <div class=""row"">
                    ");
            EndContext();
            BeginContext(923, 2198, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e98f93ef8d5a4dc6b3fa0a2ad7a6a68b", async() => {
                BeginContext(995, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 38 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\WebSetting\EditForWeb.cshtml"
                         if (Model.Id != Guid.Empty)
                        {

#line default
#line hidden
                BeginContext(1078, 44, true);
                WriteLiteral("                            <input name=\"Id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1122, "\"", 1139, 1);
#line 40 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\WebSetting\EditForWeb.cshtml"
WriteAttributeValue("", 1130, Model.Id, 1130, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1140, 19, true);
                WriteLiteral(" type=\"hidden\" />\r\n");
                EndContext();
#line 41 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\WebSetting\EditForWeb.cshtml"
                        }

#line default
#line hidden
                BeginContext(1186, 199, true);
                WriteLiteral("                        <div class=\"seach row\">\r\n                            <div class=\"col-md-3\">\r\n                                <input type=\"text\" name=\"HomeUrlTitle\" placeholder=\"首页标题栏(16个字以内)\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1385, "\"", 1412, 1);
#line 44 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\WebSetting\EditForWeb.cshtml"
WriteAttributeValue("", 1393, Model.HomeUrlTitle, 1393, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1413, 286, true);
                WriteLiteral(@" class=""form-control form-group-sm"" required data-toggle=""tooltip"" data-placement=""right"" title=""首页标题栏"" />
                            </div>
                            <div class=""col-md-9"">
                                <input type=""text"" name=""KeyWord"" placeholder=""关键词(以，号隔开)""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1699, "\"", 1721, 1);
#line 47 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\WebSetting\EditForWeb.cshtml"
WriteAttributeValue("", 1707, Model.KeyWord, 1707, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1722, 363, true);
                WriteLiteral(@" class=""form-control form-group-sm"" required data-toggle=""tooltip"" data-placement=""bottom"" title=""SEO检索词""/>
                            </div>
                        </div>
                        <div class=""seach row"">
                            <div class=""col-md-9"">
                                <input type=""text"" name=""Describe"" placeholder=""站点描述""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2085, "\"", 2108, 1);
#line 52 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\WebSetting\EditForWeb.cshtml"
WriteAttributeValue("", 2093, Model.Describe, 2093, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2109, 278, true);
                WriteLiteral(@" class=""form-control form-group-sm"" required data-toggle=""tooltip"" data-placement=""top"" title=""网站基本描述""/>
                            </div>
                            <div class=""col-md-3"">
                                <input type=""text"" name=""IconUrl"" placeholder=""图标名称""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2387, "\"", 2409, 1);
#line 55 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\WebSetting\EditForWeb.cshtml"
WriteAttributeValue("", 2395, Model.IconUrl, 2395, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2410, 469, true);
                WriteLiteral(@" class=""form-control form-group-sm"" required data-toggle=""tooltip"" data-placement=""top"" title=""网站图标文件名""/>
                            </div>
                        </div>
                        <div class=""seach row"">
                            <div class=""col-md-12"">
                                <div class=""switch"">
                                    <span>是否启用：</span>
                                    <label><input type=""checkbox"" name=""IsEnabled""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2879, "\"", 2914, 1);
#line 62 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\WebSetting\EditForWeb.cshtml"
WriteAttributeValue("", 2887, Model.IsEnabled.ToString(), 2887, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2915, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(2918, 29, false);
#line 62 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\WebSetting\EditForWeb.cshtml"
                                                                                                                   Write(Model.IsEnabled? "checked":"");

#line default
#line hidden
                EndContext();
                BeginContext(2948, 166, true);
                WriteLiteral("><span class=\"lever\"></span></label>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    ");
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
            BeginContext(3121, 278, true);
            WriteLiteral(@"
                </div>
                <div class=""row"" style=""margin-top:10px;border-top:1px dashed #ddd"">
                    <div class=""col-md-12"" style=""padding-top:10px;"">
                        <button type=""button"" class=""btn btn-primary save-button waves-effect"">");
            EndContext();
            BeginContext(3400, 9, false);
#line 70 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\WebSetting\EditForWeb.cshtml"
                                                                                          Write(L("Save"));

#line default
#line hidden
            EndContext();
            BeginContext(3409, 231, true);
            WriteLiteral("</button>\r\n                        <i style=\"color:#808080;font-size:.9rem;margin-left:12px;\">*所有站点设置回关联到SEO优化，请慎重设置！</i>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ppl.Web.Models.WebSettings.CreateOrUpdateViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
