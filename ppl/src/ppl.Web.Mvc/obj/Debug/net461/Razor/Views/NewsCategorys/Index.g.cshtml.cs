#pragma checksum "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e28a52ccf2e93a20c2d55eafa35ef2c0452bd889"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NewsCategorys_Index), @"mvc.1.0.view", @"/Views/NewsCategorys/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/NewsCategorys/Index.cshtml", typeof(AspNetCore.Views_NewsCategorys_Index))]
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
#line 1 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Index.cshtml"
using ppl.Web.Startup;

#line default
#line hidden
#line 2 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Index.cshtml"
using static ppl.JklConsts;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e28a52ccf2e93a20c2d55eafa35ef2c0452bd889", @"/Views/NewsCategorys/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cc72928e58287740592435e67e86457ddcd9614", @"/Views/_ViewImports.cshtml")]
    public class Views_NewsCategorys_Index : ppl.Web.Views.pplRazorPage<ppl.Web.Models.NewsManger.Category.CategoryViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/view-resources/Views/Category/Index.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("NewsCreateForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Index.cshtml"
  
    ViewBag.CurrentPageName = "NewsCategory"; // The menu item will be active for this page.

#line default
#line hidden
            DefineSection("scripts", async() => {
                BeginContext(238, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(244, 153, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5762c2c00a94693bcc8b3a33b104b24", async() => {
                    BeginContext(277, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(287, 90, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c0a655bb13b4e75872201dc7075086d", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 10 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Index.cshtml"
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
                    BeginContext(377, 6, true);
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
                BeginContext(397, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(402, 2162, true);
            WriteLiteral(@"<style>
    .pad {
        padding: 2px 7px;
    }

    .gurp {
        position: absolute;
        top: 0;
        right: 0;
        max-width: 50%;
    }

    .input-info {
        font-size: 13px;
        height: 28px;
        box-shadow: 0 2px 5px rgba(0, 0, 0, 0.16), 0 2px 10px rgba(0, 0, 0, 0.12);
        border-radius: 2px;
    }

    .input-group .form-control:focus {
        z-index: initial;
    }

    .btn-circle {
        width: 30px;
        height: 30px;
    }

        .btn-circle i {
            left: -4px;
        }

    #select {
        padding-bottom: 6px;
    }

    [type=""checkbox""] + label {
        line-height: 23px;
        margin-bottom: 0;
    }

    .file {
        position: relative;
        display: block;
        cursor: pointer;
    }

        .file input {
            opacity: 0;
            position: absolute;
            left: 0;
            top: 0;
        }

    form textarea {
        max-width: 100%;
        min-widt");
            WriteLiteral(@"h: 100%;
        min-height: 45px;
    }

    .tags {
        cursor: pointer;
        padding-bottom: 2.4px;
        position: relative;
    }

        .tags:hover i {
            opacity: 1;
        }

        .tags i {
            opacity: 0;
            font-size: inherit;
            position: absolute;
            right: -6px;
            top: -2px;
            background-color: #333;
        }

    .div-pad {
        padding: 10px;
        border: 1px dashed #808080;
        margin-bottom: 20px;
    }

    .seach {
        padding: 10px;
    }

        .seach input {
            border-radius: 0;
            width: 280px;
        }
    .table-responsive a[disabled] {
        opacity: 0.5;
        cursor: not-allowed;
        pointer-events: none;
    }
    .dropdown{
        margin-left:20px;
    }
    tbody > tr:hover{
        background-color:#f5f5f5;
    }
</style>
<div class=""row clearfix body-list"">
    <div class=""col-lg-12 col-md-12 col-sm-12 col");
            WriteLiteral("-xs-12\">\r\n        <div class=\"card\">\r\n            <div class=\"header\">\r\n                <h2>\r\n                    ");
            EndContext();
            BeginContext(2565, 17, false);
#line 123 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Index.cshtml"
               Write(L("NewsCategory"));

#line default
#line hidden
            EndContext();
            BeginContext(2582, 11, true);
            WriteLiteral(" <small>共有 ");
            EndContext();
            BeginContext(2594, 60, false);
#line 123 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Index.cshtml"
                                            Write(Model.NewsCategories.Where(x => x.IsDeleted != true).Count());

#line default
#line hidden
            EndContext();
            BeginContext(2654, 3274, true);
            WriteLiteral(@" 条可编辑数据</small>
                </h2>
                <ul class=""header-dropdown m-r--5"">
                    <li class=""dropdown"">
                        <a href=""javascript:void(0);"" class=""dropdown-toggle "" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">
                            <i class=""material-icons"">delete</i>
                        </a>
                        <ul class=""dropdown-menu pull-right"">
                            <li>
                                <a id=""DeleteList"" href=""javascript:void(0);"" class=""waves-effect waves-block""><i class=""material-icons"">priority_high</i>批量删除</a>
                            </li>
                        </ul>
                    </li>
                    <li class=""dropdown"">
                        <a href=""javascript:void(0);"" class=""dropdown-toggle "" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">
                            <i class=""material-icons"">reply</i>
        ");
            WriteLiteral(@"                </a>
                        <ul class=""dropdown-menu pull-right"">
                            <li>
                                <a id=""replyList"" href=""javascript:void(0);"" class=""waves-effect waves-block""><i class=""material-icons"">priority_high</i>批量恢复</a>
                            </li>
                        </ul>
                    </li>
                    <li class=""dropdown"">
                        <a href=""javascript:void(0);"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">
                            <i class=""material-icons"">search</i>
                        </a>
                        <ul class=""dropdown-menu pull-right"">
                            <li class=""seach"">
                                <input type=""text"" name=""seacrh"" placeholder=""搜索数据"" class=""form-control form-group-sm"" />
                            </li>
                        </ul>
                    </li>
                    <li");
            WriteLiteral(@" class=""dropdown"">
                        <a href=""javascript:void(0);"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">
                            <i class=""material-icons"">more_vert</i>
                        </a>
                        <ul class=""dropdown-menu pull-right"">

                            <li><a id=""RefreshButton"" href=""javascript:void(0);"" class=""waves-effect waves-block""><i class=""material-icons"">refresh</i>刷新数据</a></li>
                        </ul>
                    </li>
                </ul>
            </div>
            <div class=""body table-responsive"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th id=""select"" style=""max-width:40px;"">
                                <input id=""IsCheckAll"" type=""checkbox"" name=""IsCheckAll"" value=""false"" class=""filled-in""><label for=""IsCheckAll"" class="""">全选</label>
                            </");
            WriteLiteral("th>\r\n                            <th>#</th>\r\n                            <th>名称</th>\r\n                            <th>创建时间</th>\r\n                            <th>状态</th>\r\n                            <th>");
            EndContext();
            BeginContext(5929, 12, false);
#line 178 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Index.cshtml"
                           Write(L("Actions"));

#line default
#line hidden
            EndContext();
            BeginContext(5941, 97, true);
            WriteLiteral("</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
            EndContext();
#line 182 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Index.cshtml"
                          var num = 0; 

#line default
#line hidden
            BeginContext(6080, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 183 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Index.cshtml"
                         foreach (var news in Model.NewsCategories)
                        {
                            num++;

#line default
#line hidden
            BeginContext(6212, 100, true);
            WriteLiteral("                            <tr>\r\n                                <td style=\"max-width:40px;\"><input");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 6312, "\"", 6325, 1);
#line 187 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Index.cshtml"
WriteAttributeValue("", 6317, news.Id, 6317, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6326, 10, true);
            WriteLiteral(" data-id=\"");
            EndContext();
            BeginContext(6337, 7, false);
#line 187 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Index.cshtml"
                                                                                     Write(news.Id);

#line default
#line hidden
            EndContext();
            BeginContext(6344, 70, true);
            WriteLiteral("\" type=\"checkbox\" name=\"single\" value=\"false\" class=\"filled-in\"><label");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 6414, "\"", 6428, 1);
#line 187 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Index.cshtml"
WriteAttributeValue("", 6420, news.Id, 6420, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6429, 63, true);
            WriteLiteral(" class=\"\">  </label></td>\r\n                                <td>");
            EndContext();
            BeginContext(6493, 3, false);
#line 188 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Index.cshtml"
                               Write(num);

#line default
#line hidden
            EndContext();
            BeginContext(6496, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(6540, 17, false);
#line 189 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Index.cshtml"
                               Write(news.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(6557, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(6601, 41, false);
#line 190 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Index.cshtml"
                               Write(String.Format("{0:D}", news.CreationTime));

#line default
#line hidden
            EndContext();
            BeginContext(6642, 68, true);
            WriteLiteral("</td>\r\n                                <td><i class=\"material-icons\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 6710, "\"", 6758, 3);
            WriteAttributeValue("", 6718, "color:", 6718, 6, true);
#line 191 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Index.cshtml"
WriteAttributeValue("", 6724, news.IsDeleted ? "red":"green", 6724, 33, false);

#line default
#line hidden
            WriteAttributeValue("", 6757, ";", 6757, 1, true);
            EndWriteAttribute();
            BeginContext(6759, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(6762, 56, false);
#line 191 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Index.cshtml"
                                                                                                           Write(news.IsDeleted ? "indeterminate_check_box" : "check_box");

#line default
#line hidden
            EndContext();
            BeginContext(6819, 553, true);
            WriteLiteral(@"</i></td>
                                <td class=""dropdown"">
                                    <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">
                                        <i class=""material-icons"">menu</i>
                                    </a>
                                    <ul class=""dropdown-menu pull-right"">
                                        <li>
                                            <a href=""#"" class=""waves-effect waves-block edit"" ");
            EndContext();
            BeginContext(7374, 32, false);
#line 198 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Index.cshtml"
                                                                                          Write(news.IsDeleted ? "disabled" : "");

#line default
#line hidden
            EndContext();
            BeginContext(7407, 10, true);
            WriteLiteral(" data-id=\"");
            EndContext();
            BeginContext(7418, 7, false);
#line 198 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Index.cshtml"
                                                                                                                                      Write(news.Id);

#line default
#line hidden
            EndContext();
            BeginContext(7425, 13, true);
            WriteLiteral("\" data-name=\"");
            EndContext();
            BeginContext(7439, 17, false);
#line 198 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Index.cshtml"
                                                                                                                                                           Write(news.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(7456, 144, true);
            WriteLiteral("\" data-toggle=\"modal\" data-target=\"#CategoryEditModal\"><i class=\"material-icons\">edit</i>修改</a>\r\n                                        </li>\r\n");
            EndContext();
#line 200 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Index.cshtml"
                                         if (news.IsDeleted)
                                        {

#line default
#line hidden
            BeginContext(7705, 109, true);
            WriteLiteral("                                            <li><a href=\"#\" class=\"waves-effect waves-block delete\" data-id=\"");
            EndContext();
            BeginContext(7815, 7, false);
#line 202 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Index.cshtml"
                                                                                                        Write(news.Id);

#line default
#line hidden
            EndContext();
            BeginContext(7822, 13, true);
            WriteLiteral("\" data-name=\"");
            EndContext();
            BeginContext(7836, 17, false);
#line 202 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Index.cshtml"
                                                                                                                             Write(news.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(7853, 15, true);
            WriteLiteral("\" data-delete=\"");
            EndContext();
            BeginContext(7869, 14, false);
#line 202 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Index.cshtml"
                                                                                                                                                              Write(news.IsDeleted);

#line default
#line hidden
            EndContext();
            BeginContext(7883, 50, true);
            WriteLiteral("\"><i class=\"material-icons\">reply</i>恢复</a></li>\r\n");
            EndContext();
#line 203 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Index.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
            BeginContext(8065, 109, true);
            WriteLiteral("                                            <li><a href=\"#\" class=\"waves-effect waves-block delete\" data-id=\"");
            EndContext();
            BeginContext(8175, 7, false);
#line 206 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Index.cshtml"
                                                                                                        Write(news.Id);

#line default
#line hidden
            EndContext();
            BeginContext(8182, 13, true);
            WriteLiteral("\" data-name=\"");
            EndContext();
            BeginContext(8196, 17, false);
#line 206 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Index.cshtml"
                                                                                                                             Write(news.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(8213, 15, true);
            WriteLiteral("\" data-delete=\"");
            EndContext();
            BeginContext(8229, 14, false);
#line 206 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Index.cshtml"
                                                                                                                                                              Write(news.IsDeleted);

#line default
#line hidden
            EndContext();
            BeginContext(8243, 57, true);
            WriteLiteral("\"><i class=\"material-icons\">delete_sweep</i>删除</a></li>\r\n");
            EndContext();
#line 207 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Index.cshtml"
                                        }

#line default
#line hidden
            BeginContext(8343, 117, true);
            WriteLiteral("                                    </ul>\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 211 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(8487, 270, true);
            WriteLiteral(@"                    </tbody>
                </table>
                <div class=""row"" style=""margin-top:30px;"">
                    <div class=""col-md-3"">
                        <a href=""javascript:void();"" class=""btn btn-default btn-sm"">当前页码：<span id=""PageIndex"">");
            EndContext();
            BeginContext(8758, 15, false);
#line 216 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Index.cshtml"
                                                                                                         Write(Model.PageIndex);

#line default
#line hidden
            EndContext();
            BeginContext(8773, 31, true);
            WriteLiteral("</span> / <span id=\"PageCount\">");
            EndContext();
            BeginContext(8805, 20, false);
#line 216 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Index.cshtml"
                                                                                                                                                        Write(Model.TotalPageCount);

#line default
#line hidden
            EndContext();
            BeginContext(8825, 14, true);
            WriteLiteral("</span> </a>\r\n");
            EndContext();
#line 217 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Index.cshtml"
                           var top = Model.PageIndex-1;var next = Model.PageIndex+1;

#line default
#line hidden
            BeginContext(8926, 26, true);
            WriteLiteral("                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 8952, "\"", 8999, 2);
            WriteAttributeValue("", 8959, "../../NewsCategorys/Index?PageIndex=", 8959, 36, true);
#line 218 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Index.cshtml"
WriteAttributeValue("", 8995, top, 8995, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9000, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(9003, 34, false);
#line 218 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Index.cshtml"
                                                                       Write(Model.PageIndex<=1 ? "disabled":"");

#line default
#line hidden
            EndContext();
            BeginContext(9038, 126, true);
            WriteLiteral(" class=\"btn btn-default btn-sm pad\" id=\"Top\"><i class=\"material-icons\">keyboard_arrow_left</i></a>\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 9164, "\"", 9212, 2);
            WriteAttributeValue("", 9171, "../../NewsCategorys/Index?PageIndex=", 9171, 36, true);
#line 219 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Index.cshtml"
WriteAttributeValue("", 9207, next, 9207, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9213, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(9216, 53, false);
#line 219 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Index.cshtml"
                                                                        Write(Model.PageIndex>=Model.TotalPageCount ? "disabled":"");

#line default
#line hidden
            EndContext();
            BeginContext(9270, 339, true);
            WriteLiteral(@" class=""btn btn-default btn-sm pad"" id=""Next""><i class=""material-icons"">keyboard_arrow_right</i></a>
                    </div>
                    <div class=""col-md-3"">
                        <div class=""input-group"">
                            <input type=""number"" id=""TotalPageCount"" class=""form-control form-group-sm input-info""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 9609, "\"", 9638, 1);
#line 223 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Index.cshtml"
WriteAttributeValue("", 9617, Model.TotalPageCount, 9617, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9639, 101, true);
            WriteLiteral(" style=\"box-shadow: 0 2px 5px rgba(0, 0, 0, 0.16), 0 2px 10px rgba(0, 0, 0, 0.12);padding: 4px 10px;\"");
            EndContext();
            BeginWriteAttribute("max", " max=\"", 9740, "\"", 9767, 1);
#line 223 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Index.cshtml"
WriteAttributeValue("", 9746, Model.TotalPageCount, 9746, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9768, 105, true);
            WriteLiteral(" min=\"1\">\r\n                            <span class=\"input-group-btn\">\r\n                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 9873, "\"", 9937, 2);
            WriteAttributeValue("", 9880, "../../NewsCategorys/Index?PageIndex=", 9880, 36, true);
#line 225 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Index.cshtml"
WriteAttributeValue("", 9916, Model.TotalPageCount, 9916, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9938, 1118, true);
            WriteLiteral(@" class=""btn btn-sm btn-primary"" id=""jump"" type=""button"" style=""border-top-left-radius: 0;border-bottom-left-radius: 0;"">跳转</a>
                            </span>
                        </div>
                    </div>
                    <div class=""col-md-6 text-right"">
                        <button type=""button"" class=""btn btn-success btn-sm btn-circle waves-effect waves-circle waves-float pull-right"" data-toggle=""modal"" data-target=""#NewsCreateModal"">
                            <i class=""material-icons"">add</i>
                        </button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""modal fade"" id=""NewsCreateModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""RoleCreateModalLabel"" data-backdrop=""static"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">
                    <span>创建新闻类型</span>
   ");
            WriteLiteral("             </h4>\r\n            </div>\r\n            <div class=\"modal-body\">\r\n                ");
            EndContext();
            BeginContext(11056, 1328, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82e9a353e89e451e8e46f0f25cc9eec3", async() => {
                BeginContext(11131, 434, true);
                WriteLiteral(@"
                    <div id=""create-news-details"" class=""tab-pane animated fadeIn active"">
                        <div class=""row clearfix"">
                            <div class=""col-sm-12"">
                                <div class=""form-group form-float"">
                                    <div class=""form-line"">
                                        <input id=""CategoryName"" type=""text"" name=""CategoryName"" required");
                EndContext();
                BeginWriteAttribute("maxlength", " maxlength=", 11565, "", 11594, 1);
#line 254 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Index.cshtml"
WriteAttributeValue("", 11576, MaxCategoryLength, 11576, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(11594, 612, true);
                WriteLiteral(@" minlength=""2"" class=""validate form-control"">
                                        <label for=""CategoryName"" class=""form-label"">类型名称</label>
                                    </div>
                                    <p class=""text-right text-white-50"" style=""margin-top:10px""><label>*输入2到6位字符以保证页面的排版</label></p>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-default waves-effect"" data-dismiss=""modal"">");
                EndContext();
                BeginContext(12207, 11, false);
#line 263 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Index.cshtml"
                                                                                                   Write(L("Cancel"));

#line default
#line hidden
                EndContext();
                BeginContext(12218, 94, true);
                WriteLiteral("</button>\r\n                        <button type=\"submit\" class=\"btn btn-primary waves-effect\">");
                EndContext();
                BeginContext(12313, 9, false);
#line 264 "C:\Users\Admin\Documents\-\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Index.cshtml"
                                                                              Write(L("Save"));

#line default
#line hidden
                EndContext();
                BeginContext(12322, 55, true);
                WriteLiteral("</button>\r\n                    </div>\r\n                ");
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
            BeginContext(12384, 316, true);
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>
<div class=""modal fade"" id=""CategoryEditModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""EditModalLabel"" data-backdrop=""static"">
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ppl.Web.Models.NewsManger.Category.CategoryViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
