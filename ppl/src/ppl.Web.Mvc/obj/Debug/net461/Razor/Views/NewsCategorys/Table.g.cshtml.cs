#pragma checksum "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Table.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "352931571a2471036646e1f016854d2337bcc319"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NewsCategorys_Table), @"mvc.1.0.view", @"/Views/NewsCategorys/Table.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/NewsCategorys/Table.cshtml", typeof(AspNetCore.Views_NewsCategorys_Table))]
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
#line 1 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\_ViewImports.cshtml"
using Abp.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"352931571a2471036646e1f016854d2337bcc319", @"/Views/NewsCategorys/Table.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c11c579c28f192704a8097ac1871355b4dfde99", @"/Views/_ViewImports.cshtml")]
    public class Views_NewsCategorys_Table : ppl.Web.Views.pplRazorPage<ppl.Web.Models.NewsManger.Category.CategoryViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Table.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(90, 143, true);
            WriteLiteral("<div class=\"col-lg-12 col-md-12 col-sm-12 col-xs-12\">\r\n    <div class=\"card\">\r\n        <div class=\"header\">\r\n            <h2>\r\n                ");
            EndContext();
            BeginContext(234, 17, false);
#line 10 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Table.cshtml"
           Write(L("NewsCategory"));

#line default
#line hidden
            EndContext();
            BeginContext(251, 11, true);
            WriteLiteral(" <small>共有 ");
            EndContext();
            BeginContext(263, 28, false);
#line 10 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Table.cshtml"
                                        Write(Model.NewsCategories.Count());

#line default
#line hidden
            EndContext();
            BeginContext(291, 1109, true);
            WriteLiteral(@" 条可编辑数据</small>
            </h2>
            <ul class=""header-dropdown m-r--5"">
                <li class=""dropdown"">
                    <a href=""javascript:void(0);"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">
                        <i class=""material-icons"">search</i>
                    </a>
                    <ul class=""dropdown-menu pull-right"">
                        <li class=""seach""><input type=""text"" name=""seacrh"" placeholder=""搜索数据"" class=""form-control form-group-sm"" /></li>
                    </ul>
                </li>
                <li class=""dropdown"">
                    <a href=""javascript:void(0);"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">
                        <i class=""material-icons"">more_vert</i>
                    </a>
                    <ul class=""dropdown-menu pull-right"">

                        <li><a id=""RefreshButton"" href=""javasc");
            WriteLiteral("ript:void(0);\" class=\"waves-effect waves-block\"><i class=\"material-icons\">refresh</i>");
            EndContext();
            BeginContext(1401, 12, false);
#line 27 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Table.cshtml"
                                                                                                                                              Write(L("Refresh"));

#line default
#line hidden
            EndContext();
            BeginContext(1413, 616, true);
            WriteLiteral(@"</a></li>
                    </ul>
                </li>
            </ul>
        </div>
        <div class=""body table-responsive"">
            <table class=""table"">
                <thead>
                    <tr>
                        <th id=""select"">
                            <input id=""IsCheckAll"" type=""checkbox"" name=""IsCheckAll"" value=""false"" class=""form-control""><label for=""IsCheckAll"" class=""form-label"">全选</label>
                        </th>
                        <th>名称</th>
                        <th>创建时间</th>
                        <th>状态</th>
                        <th>");
            EndContext();
            BeginContext(2030, 12, false);
#line 42 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Table.cshtml"
                       Write(L("Actions"));

#line default
#line hidden
            EndContext();
            BeginContext(2042, 85, true);
            WriteLiteral("</th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 46 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Table.cshtml"
                     foreach (var news in Model.NewsCategories)
                    {

#line default
#line hidden
            BeginContext(2215, 68, true);
            WriteLiteral("                        <tr>\r\n                            <td><input");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2283, "\"", 2296, 1);
#line 49 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Table.cshtml"
WriteAttributeValue("", 2288, news.Id, 2288, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2297, 72, true);
            WriteLiteral(" type=\"checkbox\" name=\"single\" value=\"false\" class=\"form-control\"><label");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 2369, "\"", 2383, 1);
#line 49 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Table.cshtml"
WriteAttributeValue("", 2375, news.Id, 2375, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2384, 69, true);
            WriteLiteral(" class=\"form-label\">  </label></td>\r\n                            <td>");
            EndContext();
            BeginContext(2454, 17, false);
#line 50 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Table.cshtml"
                           Write(news.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(2471, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2511, 17, false);
#line 51 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Table.cshtml"
                           Write(news.CreationTime);

#line default
#line hidden
            EndContext();
            BeginContext(2528, 64, true);
            WriteLiteral("</td>\r\n                            <td><i class=\"material-icons\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 2592, "\"", 2640, 3);
            WriteAttributeValue("", 2600, "color:", 2600, 6, true);
#line 52 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Table.cshtml"
WriteAttributeValue("", 2606, news.IsDeleted ? "red":"green", 2606, 33, false);

#line default
#line hidden
            WriteAttributeValue("", 2639, ";", 2639, 1, true);
            EndWriteAttribute();
            BeginContext(2641, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2644, 56, false);
#line 52 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Table.cshtml"
                                                                                                       Write(news.IsDeleted ? "indeterminate_check_box" : "check_box");

#line default
#line hidden
            EndContext();
            BeginContext(2701, 492, true);
            WriteLiteral(@"</i></td>
                            <td class=""dropdown"">
                                <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">
                                    <i class=""material-icons"">menu</i>
                                </a>
                                <ul class=""dropdown-menu pull-right"">
                                    <li><a href=""#"" class=""waves-effect waves-block edit"" data-id=""");
            EndContext();
            BeginContext(3194, 7, false);
#line 58 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Table.cshtml"
                                                                                              Write(news.Id);

#line default
#line hidden
            EndContext();
            BeginContext(3201, 13, true);
            WriteLiteral("\" data-name=\"");
            EndContext();
            BeginContext(3215, 17, false);
#line 58 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Table.cshtml"
                                                                                                                   Write(news.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(3232, 102, true);
            WriteLiteral("\" data-toggle=\"modal\" data-target=\"#CategoryEditModal\"><i class=\"material-icons\">edit</i>修改</a></li>\r\n");
            EndContext();
#line 59 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Table.cshtml"
                                     if (news.IsDeleted)
                                    {

#line default
#line hidden
            BeginContext(3431, 105, true);
            WriteLiteral("                                        <li><a href=\"#\" class=\"waves-effect waves-block delete\" data-id=\"");
            EndContext();
            BeginContext(3537, 7, false);
#line 61 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Table.cshtml"
                                                                                                    Write(news.Id);

#line default
#line hidden
            EndContext();
            BeginContext(3544, 13, true);
            WriteLiteral("\" data-name=\"");
            EndContext();
            BeginContext(3558, 17, false);
#line 61 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Table.cshtml"
                                                                                                                         Write(news.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(3575, 15, true);
            WriteLiteral("\" data-delete=\"");
            EndContext();
            BeginContext(3591, 14, false);
#line 61 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Table.cshtml"
                                                                                                                                                          Write(news.IsDeleted);

#line default
#line hidden
            EndContext();
            BeginContext(3605, 50, true);
            WriteLiteral("\"><i class=\"material-icons\">reply</i>恢复</a></li>\r\n");
            EndContext();
#line 62 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Table.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(3775, 105, true);
            WriteLiteral("                                        <li><a href=\"#\" class=\"waves-effect waves-block delete\" data-id=\"");
            EndContext();
            BeginContext(3881, 7, false);
#line 65 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Table.cshtml"
                                                                                                    Write(news.Id);

#line default
#line hidden
            EndContext();
            BeginContext(3888, 13, true);
            WriteLiteral("\" data-name=\"");
            EndContext();
            BeginContext(3902, 17, false);
#line 65 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Table.cshtml"
                                                                                                                         Write(news.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(3919, 15, true);
            WriteLiteral("\" data-delete=\"");
            EndContext();
            BeginContext(3935, 14, false);
#line 65 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Table.cshtml"
                                                                                                                                                          Write(news.IsDeleted);

#line default
#line hidden
            EndContext();
            BeginContext(3949, 57, true);
            WriteLiteral("\"><i class=\"material-icons\">delete_sweep</i>删除</a></li>\r\n");
            EndContext();
#line 66 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Table.cshtml"
                                    }

#line default
#line hidden
            BeginContext(4045, 105, true);
            WriteLiteral("                                </ul>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 70 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Table.cshtml"
                    }

#line default
#line hidden
            BeginContext(4173, 250, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n            <div class=\"row\" style=\"margin-top:30px;\">\r\n                <div class=\"col-md-3\">\r\n                    <a href=\"javascript:void();\" class=\"btn btn-default btn-sm\">当前页码：<span id=\"PageIndex\">");
            EndContext();
            BeginContext(4424, 15, false);
#line 75 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Table.cshtml"
                                                                                                     Write(Model.PageIndex);

#line default
#line hidden
            EndContext();
            BeginContext(4439, 31, true);
            WriteLiteral("</span> / <span id=\"PageCount\">");
            EndContext();
            BeginContext(4471, 20, false);
#line 75 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Table.cshtml"
                                                                                                                                                    Write(Model.TotalPageCount);

#line default
#line hidden
            EndContext();
            BeginContext(4491, 533, true);
            WriteLiteral(@"</span> </a>
                    <a href=""javascript:void();"" class=""btn btn-default btn-sm pad"" id=""Top""><i class=""material-icons"">keyboard_arrow_left</i></a>
                    <a href=""javascript:void();"" class=""btn btn-default btn-sm pad"" id=""Next""><i class=""material-icons"">keyboard_arrow_right</i></a>
                </div>
                <div class=""col-md-3"">
                    <div class=""input-group"">
                        <input type=""number"" id=""TotalPageCount"" class=""form-control form-group-sm input-info""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 5024, "\"", 5053, 1);
#line 81 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Table.cshtml"
WriteAttributeValue("", 5032, Model.TotalPageCount, 5032, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5054, 101, true);
            WriteLiteral(" style=\"box-shadow: 0 2px 5px rgba(0, 0, 0, 0.16), 0 2px 10px rgba(0, 0, 0, 0.12);padding: 4px 10px;\"");
            EndContext();
            BeginWriteAttribute("max", " max=\"", 5155, "\"", 5182, 1);
#line 81 "C:\Users\mengz\Source\Workspaces\MyFirstProject\资料库\ppl\src\ppl.Web.Mvc\Views\NewsCategorys\Table.cshtml"
WriteAttributeValue("", 5161, Model.TotalPageCount, 5161, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5183, 717, true);
            WriteLiteral(@" min=""1"">
                        <span class=""input-group-btn"">
                            <button class=""btn btn-sm btn-primary"" type=""button"" style=""border-top-left-radius: 0;border-bottom-left-radius: 0;"">跳转</button>
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
