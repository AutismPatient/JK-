#pragma checksum "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Shared\Components\AccountLanguages\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1cf9a7b968a03a6f520a41e8d82fffdb2d8fad7"
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
#line 1 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\_ViewImports.cshtml"
using Abp.Localization;

#line default
#line hidden
#line 1 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Shared\Components\AccountLanguages\Default.cshtml"
using System.Text.Encodings.Web;

#line default
#line hidden
#line 2 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Shared\Components\AccountLanguages\Default.cshtml"
using ppl.Web.Views.Shared.Components.AccountLanguages;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1cf9a7b968a03a6f520a41e8d82fffdb2d8fad7", @"/Views/Shared/Components/AccountLanguages/Default.cshtml")]
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
#line 4 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Shared\Components\AccountLanguages\Default.cshtml"
 if (Model.Languages.Count > 1)
{

#line default
#line hidden
            BeginContext(162, 40, true);
            WriteLiteral("    <div class=\"language-switch-area\">\r\n");
            EndContext();
#line 7 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Shared\Components\AccountLanguages\Default.cshtml"
         foreach (var languageInfo in Model.Languages)
        {

#line default
#line hidden
            BeginContext(269, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(281, 377, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "beb99eb3d764429fa41ccce7f7a4c626", async() => {
                BeginContext(447, 23, true);
                WriteLiteral("\r\n                <span");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 470, "\"", 563, 2);
                WriteAttributeValue("", 478, "language-icon", 478, 13, true);
#line 10 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Shared\Components\AccountLanguages\Default.cshtml"
WriteAttributeValue(" ", 491, languageInfo == Model.CurrentLanguage ? "language-icon-current" : "", 492, 71, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 564, "\"", 597, 1);
#line 10 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Shared\Components\AccountLanguages\Default.cshtml"
WriteAttributeValue("", 572, languageInfo.DisplayName, 572, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(598, 3, true);
                WriteLiteral("><i");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 601, "\"", 627, 1);
#line 10 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Shared\Components\AccountLanguages\Default.cshtml"
WriteAttributeValue("", 609, languageInfo.Icon, 609, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(628, 26, true);
                WriteLiteral("></i></span>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 290, "~/AbpLocalization/ChangeCulture?cultureName=", 290, 44, true);
#line 9 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Shared\Components\AccountLanguages\Default.cshtml"
AddHtmlAttributeValue("", 334, languageInfo.Name, 334, 20, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 354, "&returnUrl=", 354, 11, true);
#line 9 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Shared\Components\AccountLanguages\Default.cshtml"
AddHtmlAttributeValue("", 365, UrlEncoder.Default.Encode(Context.Request.Path + Context.Request.QueryString), 365, 80, false);

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
            BeginContext(658, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 12 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Shared\Components\AccountLanguages\Default.cshtml"
        }

#line default
#line hidden
            BeginContext(671, 12, true);
            WriteLiteral("    </div>\r\n");
            EndContext();
#line 14 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\Shared\Components\AccountLanguages\Default.cshtml"
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
