#pragma checksum "D:\git-re\-\ppl\src\ppl.Web.Mvc\Views\Shared\ErrorView\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b483bb62893a8033e0c635dbeb790873049f1193"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ErrorView_Error), @"mvc.1.0.view", @"/Views/Shared/ErrorView/Error.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/ErrorView/Error.cshtml", typeof(AspNetCore.Views_Shared_ErrorView_Error))]
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
#line 1 "D:\git-re\-\ppl\src\ppl.Web.Mvc\Views\Shared\ErrorView\Error.cshtml"
using Abp.Collections.Extensions;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b483bb62893a8033e0c635dbeb790873049f1193", @"/Views/Shared/ErrorView/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cc72928e58287740592435e67e86457ddcd9614", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ErrorView_Error : ppl.Web.Views.pplRazorPage<Abp.Web.Mvc.Models.ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(77, 176, true);
            WriteLiteral("<div class=\"row\">\r\n    <section class=\"col-lg-12\">\r\n        <div class=\"panel panel-warning\">\r\n            <div class=\"panel-heading\">\r\n                <h3 class=\"panel-title\">");
            EndContext();
            BeginContext(254, 23, false);
#line 7 "D:\git-re\-\ppl\src\ppl.Web.Mvc\Views\Shared\ErrorView\Error.cshtml"
                                   Write(Model.ErrorInfo.Message);

#line default
#line hidden
            EndContext();
            BeginContext(277, 106, true);
            WriteLiteral("</h3>\r\n            </div>\r\n            <div class=\"panel-body\">\r\n                <p>\r\n                    ");
            EndContext();
            BeginContext(385, 98, false);
#line 11 "D:\git-re\-\ppl\src\ppl.Web.Mvc\Views\Shared\ErrorView\Error.cshtml"
                Write(!string.IsNullOrEmpty(Model.ErrorInfo.Details) ? Model.ErrorInfo.Details : Model.ErrorInfo.Message);

#line default
#line hidden
            EndContext();
            BeginContext(484, 24, true);
            WriteLiteral("\r\n                </p>\r\n");
            EndContext();
#line 14 "D:\git-re\-\ppl\src\ppl.Web.Mvc\Views\Shared\ErrorView\Error.cshtml"
                 if (!Model.ErrorInfo.ValidationErrors.IsNullOrEmpty())
                {

#line default
#line hidden
            BeginContext(646, 26, true);
            WriteLiteral("                    <ul>\r\n");
            EndContext();
#line 17 "D:\git-re\-\ppl\src\ppl.Web.Mvc\Views\Shared\ErrorView\Error.cshtml"
                         foreach (var validationError in Model.ErrorInfo.ValidationErrors)
                        {

#line default
#line hidden
            BeginContext(791, 66, true);
            WriteLiteral("                            <li>\r\n                                ");
            EndContext();
            BeginContext(858, 23, false);
#line 20 "D:\git-re\-\ppl\src\ppl.Web.Mvc\Views\Shared\ErrorView\Error.cshtml"
                           Write(validationError.Message);

#line default
#line hidden
            EndContext();
            BeginContext(881, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 21 "D:\git-re\-\ppl\src\ppl.Web.Mvc\Views\Shared\ErrorView\Error.cshtml"
                                 if (validationError.Members != null && validationError.Members.Any())
                                {
                                    

#line default
#line hidden
            BeginContext(1064, 1, true);
            WriteLiteral("(");
            EndContext();
            BeginContext(1066, 42, false);
#line 23 "D:\git-re\-\ppl\src\ppl.Web.Mvc\Views\Shared\ErrorView\Error.cshtml"
                                      Write(string.Join(", ", validationError.Members));

#line default
#line hidden
            EndContext();
            BeginContext(1108, 1, true);
            WriteLiteral(")");
            EndContext();
#line 23 "D:\git-re\-\ppl\src\ppl.Web.Mvc\Views\Shared\ErrorView\Error.cshtml"
                                                                                              
                                }

#line default
#line hidden
            BeginContext(1153, 35, true);
            WriteLiteral("                            </li>\r\n");
            EndContext();
#line 26 "D:\git-re\-\ppl\src\ppl.Web.Mvc\Views\Shared\ErrorView\Error.cshtml"
                        }

#line default
#line hidden
            BeginContext(1215, 27, true);
            WriteLiteral("                    </ul>\r\n");
            EndContext();
#line 28 "D:\git-re\-\ppl\src\ppl.Web.Mvc\Views\Shared\ErrorView\Error.cshtml"
                }

#line default
#line hidden
            BeginContext(1261, 60, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </section>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Abp.Web.Mvc.Models.ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
