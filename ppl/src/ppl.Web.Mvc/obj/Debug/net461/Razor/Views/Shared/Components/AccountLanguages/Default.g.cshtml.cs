#pragma checksum "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Shared\Components\AccountLanguages\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddb15639b3514ca43976c3ea7f4914c32cddf7e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AccountLanguages_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AccountLanguages/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/AccountLanguages/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_AccountLanguages_Default))]
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
#line 1 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Shared\Components\AccountLanguages\Default.cshtml"
using System.Text.Encodings.Web;

#line default
#line hidden
#line 2 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Shared\Components\AccountLanguages\Default.cshtml"
using ppl.Web.Views.Shared.Components.AccountLanguages;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddb15639b3514ca43976c3ea7f4914c32cddf7e0", @"/Views/Shared/Components/AccountLanguages/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cc72928e58287740592435e67e86457ddcd9614", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_AccountLanguages_Default : ppl.Web.Views.pplRazorPage<LanguageSelectionViewModel>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(126, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Shared\Components\AccountLanguages\Default.cshtml"
 if (Model.Languages.Count > 1)
{

#line default
#line hidden
            BeginContext(164, 50, true);
            WriteLiteral("    <div class=\"language-switch-area\">\r\n        \r\n");
            EndContext();
#line 9 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Shared\Components\AccountLanguages\Default.cshtml"
         foreach (var languageInfo in Model.Languages)
        {

#line default
#line hidden
            BeginContext(281, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(293, 377, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "391ece0c647040fa9cd28c34f43ec80d", async() => {
                BeginContext(459, 23, true);
                WriteLiteral("\r\n                <span");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 482, "\"", 575, 2);
                WriteAttributeValue("", 490, "language-icon", 490, 13, true);
#line 12 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Shared\Components\AccountLanguages\Default.cshtml"
WriteAttributeValue(" ", 503, languageInfo == Model.CurrentLanguage ? "language-icon-current" : "", 504, 71, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 576, "\"", 609, 1);
#line 12 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Shared\Components\AccountLanguages\Default.cshtml"
WriteAttributeValue("", 584, languageInfo.DisplayName, 584, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(610, 3, true);
                WriteLiteral("><i");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 613, "\"", 639, 1);
#line 12 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Shared\Components\AccountLanguages\Default.cshtml"
WriteAttributeValue("", 621, languageInfo.Icon, 621, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(640, 26, true);
                WriteLiteral("></i></span>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 302, "~/AbpLocalization/ChangeCulture?cultureName=", 302, 44, true);
#line 11 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Shared\Components\AccountLanguages\Default.cshtml"
AddHtmlAttributeValue("", 346, languageInfo.Name, 346, 20, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 366, "&returnUrl=", 366, 11, true);
#line 11 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Shared\Components\AccountLanguages\Default.cshtml"
AddHtmlAttributeValue("", 377, UrlEncoder.Default.Encode(Context.Request.Path + Context.Request.QueryString), 377, 80, false);

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
            BeginContext(670, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 14 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Shared\Components\AccountLanguages\Default.cshtml"
        }

#line default
#line hidden
            BeginContext(683, 12, true);
            WriteLiteral("    </div>\r\n");
            EndContext();
#line 16 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\Shared\Components\AccountLanguages\Default.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LanguageSelectionViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
