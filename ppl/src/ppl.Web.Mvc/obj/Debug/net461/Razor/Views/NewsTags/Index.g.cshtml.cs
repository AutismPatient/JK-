#pragma checksum "D:\myppl\ppl\src\ppl.Web.Mvc\Views\NewsTags\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f73f51d8eb0947b66b3fe7e894e56336f546b3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NewsTags_Index), @"mvc.1.0.view", @"/Views/NewsTags/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/NewsTags/Index.cshtml", typeof(AspNetCore.Views_NewsTags_Index))]
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
#line 1 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\NewsTags\Index.cshtml"
using ppl.Web.Startup;

#line default
#line hidden
#line 2 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\NewsTags\Index.cshtml"
using ppl.NewsTag.Dto;

#line default
#line hidden
#line 3 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\NewsTags\Index.cshtml"
using ppl.Web.Models.Common.PageInfoModel;

#line default
#line hidden
#line 4 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\NewsTags\Index.cshtml"
using ppl.Web.Models.Common.Modals;

#line default
#line hidden
#line 5 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\NewsTags\Index.cshtml"
using static ppl.JklConsts;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f73f51d8eb0947b66b3fe7e894e56336f546b3d", @"/Views/NewsTags/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cc72928e58287740592435e67e86457ddcd9614", @"/Views/_ViewImports.cshtml")]
    public class Views_NewsTags_Index : ppl.Web.Views.pplRazorPage<ppl.Web.Models.Common.ViewModelBase<TagDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/view-resources/Views/Tag/Index.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("TagCreateForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 7 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\NewsTags\Index.cshtml"
  
    ViewBag.CurrentPageName = "NewsTags"; // The menu item will be active for this page.

#line default
#line hidden
            DefineSection("scripts", async() => {
                BeginContext(330, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(336, 148, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38e3a4d4e7e8468797a6853f94f349ea", async() => {
                    BeginContext(369, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(379, 85, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e9022200bdc4b89b4f93b6ed537efc3", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 13 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\NewsTags\Index.cshtml"
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
                    BeginContext(464, 6, true);
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
                BeginContext(484, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(489, 2187, true);
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

    .dropdown {
        margin-left: 20px;
    }

    tbody > tr:hover {
        background-color: #f5f5f5;
    }
</style>
<div class=""row clearfix body-list"">
    <div class=""col-lg-12 col-md-12 col");
            WriteLiteral("-sm-12 col-xs-12\">\r\n        <div class=\"card\">\r\n            <div class=\"header\">\r\n                <h2>\r\n                    标签列表 <small>共有 ");
            EndContext();
            BeginContext(2677, 51, false);
#line 129 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\NewsTags\Index.cshtml"
                              Write(Model.Items.Where(x => x.IsDeleted != true).Count());

#line default
#line hidden
            EndContext();
            BeginContext(2728, 3267, true);
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
                    <");
            WriteLiteral(@"li class=""dropdown"">
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
                                <input id=""IsCheckAll"" type=""checkbox"" name=""IsCheckAll"" value=""false"" class=""filled-in""><label for=""IsCheckAll"">全选</label>
                            </th>
  ");
            WriteLiteral("                          <th>#</th>\r\n                            <th>名称</th>\r\n                            <th>创建时间</th>\r\n                            <th>状态</th>\r\n                            <th>");
            EndContext();
            BeginContext(5996, 12, false);
#line 185 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\NewsTags\Index.cshtml"
                           Write(L("Actions"));

#line default
#line hidden
            EndContext();
            BeginContext(6008, 97, true);
            WriteLiteral("</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
            EndContext();
#line 189 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\NewsTags\Index.cshtml"
                          var num = 0; 

#line default
#line hidden
            BeginContext(6147, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 190 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\NewsTags\Index.cshtml"
                         foreach (var news in Model.Items)
                        {
                            num++;

#line default
#line hidden
            BeginContext(6270, 100, true);
            WriteLiteral("                            <tr>\r\n                                <td style=\"max-width:40px;\"><input");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 6370, "\"", 6383, 1);
#line 194 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\NewsTags\Index.cshtml"
WriteAttributeValue("", 6375, news.Id, 6375, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6384, 10, true);
            WriteLiteral(" data-id=\"");
            EndContext();
            BeginContext(6395, 7, false);
#line 194 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\NewsTags\Index.cshtml"
                                                                                     Write(news.Id);

#line default
#line hidden
            EndContext();
            BeginContext(6402, 70, true);
            WriteLiteral("\" type=\"checkbox\" name=\"single\" value=\"false\" class=\"filled-in\"><label");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 6472, "\"", 6486, 1);
#line 194 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\NewsTags\Index.cshtml"
WriteAttributeValue("", 6478, news.Id, 6478, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6487, 63, true);
            WriteLiteral(" class=\"\">  </label></td>\r\n                                <td>");
            EndContext();
            BeginContext(6551, 3, false);
#line 195 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\NewsTags\Index.cshtml"
                               Write(num);

#line default
#line hidden
            EndContext();
            BeginContext(6554, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(6598, 12, false);
#line 196 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\NewsTags\Index.cshtml"
                               Write(news.TagName);

#line default
#line hidden
            EndContext();
            BeginContext(6610, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(6654, 41, false);
#line 197 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\NewsTags\Index.cshtml"
                               Write(String.Format("{0:D}", news.CreationTime));

#line default
#line hidden
            EndContext();
            BeginContext(6695, 68, true);
            WriteLiteral("</td>\r\n                                <td><i class=\"material-icons\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 6763, "\"", 6811, 3);
            WriteAttributeValue("", 6771, "color:", 6771, 6, true);
#line 198 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\NewsTags\Index.cshtml"
WriteAttributeValue("", 6777, news.IsDeleted ? "red":"green", 6777, 33, false);

#line default
#line hidden
            WriteAttributeValue("", 6810, ";", 6810, 1, true);
            EndWriteAttribute();
            BeginContext(6812, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(6815, 56, false);
#line 198 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\NewsTags\Index.cshtml"
                                                                                                           Write(news.IsDeleted ? "indeterminate_check_box" : "check_box");

#line default
#line hidden
            EndContext();
            BeginContext(6872, 553, true);
            WriteLiteral(@"</i></td>
                                <td class=""dropdown"">
                                    <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">
                                        <i class=""material-icons"">menu</i>
                                    </a>
                                    <ul class=""dropdown-menu pull-right"">
                                        <li>
                                            <a href=""#"" class=""waves-effect waves-block edit"" ");
            EndContext();
            BeginContext(7427, 32, false);
#line 205 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\NewsTags\Index.cshtml"
                                                                                          Write(news.IsDeleted ? "disabled" : "");

#line default
#line hidden
            EndContext();
            BeginContext(7460, 10, true);
            WriteLiteral(" data-id=\"");
            EndContext();
            BeginContext(7471, 7, false);
#line 205 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\NewsTags\Index.cshtml"
                                                                                                                                      Write(news.Id);

#line default
#line hidden
            EndContext();
            BeginContext(7478, 13, true);
            WriteLiteral("\" data-name=\"");
            EndContext();
            BeginContext(7492, 12, false);
#line 205 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\NewsTags\Index.cshtml"
                                                                                                                                                           Write(news.TagName);

#line default
#line hidden
            EndContext();
            BeginContext(7504, 139, true);
            WriteLiteral("\" data-toggle=\"modal\" data-target=\"#TagEditModal\"><i class=\"material-icons\">edit</i>修改</a>\r\n                                        </li>\r\n");
            EndContext();
#line 207 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\NewsTags\Index.cshtml"
                                         if (news.IsDeleted)
                                        {

#line default
#line hidden
            BeginContext(7748, 109, true);
            WriteLiteral("                                            <li><a href=\"#\" class=\"waves-effect waves-block delete\" data-id=\"");
            EndContext();
            BeginContext(7858, 7, false);
#line 209 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\NewsTags\Index.cshtml"
                                                                                                        Write(news.Id);

#line default
#line hidden
            EndContext();
            BeginContext(7865, 13, true);
            WriteLiteral("\" data-name=\"");
            EndContext();
            BeginContext(7879, 12, false);
#line 209 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\NewsTags\Index.cshtml"
                                                                                                                             Write(news.TagName);

#line default
#line hidden
            EndContext();
            BeginContext(7891, 15, true);
            WriteLiteral("\" data-delete=\"");
            EndContext();
            BeginContext(7907, 14, false);
#line 209 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\NewsTags\Index.cshtml"
                                                                                                                                                         Write(news.IsDeleted);

#line default
#line hidden
            EndContext();
            BeginContext(7921, 50, true);
            WriteLiteral("\"><i class=\"material-icons\">reply</i>恢复</a></li>\r\n");
            EndContext();
#line 210 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\NewsTags\Index.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
            BeginContext(8103, 109, true);
            WriteLiteral("                                            <li><a href=\"#\" class=\"waves-effect waves-block delete\" data-id=\"");
            EndContext();
            BeginContext(8213, 7, false);
#line 213 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\NewsTags\Index.cshtml"
                                                                                                        Write(news.Id);

#line default
#line hidden
            EndContext();
            BeginContext(8220, 13, true);
            WriteLiteral("\" data-name=\"");
            EndContext();
            BeginContext(8234, 12, false);
#line 213 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\NewsTags\Index.cshtml"
                                                                                                                             Write(news.TagName);

#line default
#line hidden
            EndContext();
            BeginContext(8246, 15, true);
            WriteLiteral("\" data-delete=\"");
            EndContext();
            BeginContext(8262, 14, false);
#line 213 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\NewsTags\Index.cshtml"
                                                                                                                                                         Write(news.IsDeleted);

#line default
#line hidden
            EndContext();
            BeginContext(8276, 57, true);
            WriteLiteral("\"><i class=\"material-icons\">delete_sweep</i>删除</a></li>\r\n");
            EndContext();
#line 214 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\NewsTags\Index.cshtml"
                                        }

#line default
#line hidden
            BeginContext(8376, 117, true);
            WriteLiteral("                                    </ul>\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 218 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\NewsTags\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(8520, 136, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n                <div class=\"row\" style=\"margin-top:30px;\">\r\n                    ");
            EndContext();
            BeginContext(8657, 208, false);
#line 222 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\NewsTags\Index.cshtml"
               Write(Html.Partial("~/Views/Shared/Modals/_PageInfo.cshtml", new PageViewModel("News", "NewIndex", Model.PageIndex, Model.PageSize, Model.TotalPageCount, Model.HasPreviousPage, Model.HasNextPage, Model.TotalCount)));

#line default
#line hidden
            EndContext();
            BeginContext(8865, 685, true);
            WriteLiteral(@"
                    <div class=""col-md-9 text-right"">
                        <button type=""button"" class=""btn btn-success btn-sm btn-circle waves-effect waves-circle waves-float pull-right"" data-toggle=""modal"" data-target=""#TagCreateModal"">
                            <i class=""material-icons"">add</i>
                        </button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""modal fade"" id=""TagCreateModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""RoleCreateModalLabel"" data-backdrop=""static"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            ");
            EndContext();
            BeginContext(9551, 94, false);
#line 236 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\NewsTags\Index.cshtml"
       Write(Html.Partial("~/Views/Shared/Modals/_ModalHeader.cshtml", new ModalHeaderViewModel("新建资料标签项")));

#line default
#line hidden
            EndContext();
            BeginContext(9645, 56, true);
            WriteLiteral("\r\n            <div class=\"modal-body\">\r\n                ");
            EndContext();
            BeginContext(9701, 1308, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9af99ea351f841efa61704da981673ee", async() => {
                BeginContext(9775, 424, true);
                WriteLiteral(@"
                    <div id=""create-news-details"" class=""tab-pane animated fadeIn active"">
                        <div class=""row clearfix"">
                            <div class=""col-sm-12"">
                                <div class=""form-group form-float"">
                                    <div class=""form-line"">
                                        <input id=""TagName"" type=""text"" name=""TagName"" required");
                EndContext();
                BeginWriteAttribute("maxlength", " maxlength=", 10199, "", 10224, 1);
#line 244 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\NewsTags\Index.cshtml"
WriteAttributeValue("", 10210, MaxTagsLength, 10210, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(10224, 607, true);
                WriteLiteral(@" minlength=""2"" class=""validate form-control"">
                                        <label for=""TagName"" class=""form-label"">标签名称</label>
                                    </div>
                                    <p class=""text-right text-white-50"" style=""margin-top:10px""><label>*输入2到6位字符以保证页面的排版</label></p>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-default waves-effect"" data-dismiss=""modal"">");
                EndContext();
                BeginContext(10832, 11, false);
#line 253 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\NewsTags\Index.cshtml"
                                                                                                   Write(L("Cancel"));

#line default
#line hidden
                EndContext();
                BeginContext(10843, 94, true);
                WriteLiteral("</button>\r\n                        <button type=\"submit\" class=\"btn btn-primary waves-effect\">");
                EndContext();
                BeginContext(10938, 9, false);
#line 254 "D:\myppl\ppl\src\ppl.Web.Mvc\Views\NewsTags\Index.cshtml"
                                                                              Write(L("Save"));

#line default
#line hidden
                EndContext();
                BeginContext(10947, 55, true);
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
            BeginContext(11009, 311, true);
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>
<div class=""modal fade"" id=""TagEditModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""EditModalLabel"" data-backdrop=""static"">
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ppl.Web.Models.Common.ViewModelBase<TagDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
