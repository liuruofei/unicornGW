#pragma checksum "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\ReadMain\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c5cb2fac3c177ff5aea84e93f1b0d87eca1c22e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Manage_ReadMain_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Manage/ReadMain/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Manage/ReadMain/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Manage_ReadMain_Index))]
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
#line 1 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\_ViewImports.cshtml"
using WebManager;

#line default
#line hidden
#line 2 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\_ViewImports.cshtml"
using WebManager.Models;

#line default
#line hidden
#line 3 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\_ViewImports.cshtml"
using ADT.Html;

#line default
#line hidden
#line 4 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\_ViewImports.cshtml"
using ADT.Models;

#line default
#line hidden
#line 5 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\_ViewImports.cshtml"
using ADT.Common;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c5cb2fac3c177ff5aea84e93f1b0d87eca1c22e", @"/Areas/Admin/Views/Manage/ReadMain/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b8323b3d6a732432ae31640b181b722dbefcc02", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Manage_ReadMain_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "-1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(121, 509, true);
            WriteLiteral(@"
<!-- 正文开始 -->
<div class=""layui-fluid"">
    <div class=""layui-card"">
        <div class=""layui-card-body"">
            <div class=""layui-form toolbar"">
                <div class=""layui-form-item"">
                    <div class=""layui-inline"">
                        <label class=""layui-form-label w-auto"">类型：</label>
                        <div class=""layui-input-inline mr0"" style=""width:150px;"">
                            <select id=""sltype"" name=""sltype"">
                                ");
            EndContext();
            BeginContext(630, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c5cb2fac3c177ff5aea84e93f1b0d87eca1c22e5076", async() => {
                BeginContext(649, 2, true);
                WriteLiteral("全部");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(660, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(694, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c5cb2fac3c177ff5aea84e93f1b0d87eca1c22e6478", async() => {
                BeginContext(712, 5, true);
                WriteLiteral("留学直通车");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(726, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(760, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c5cb2fac3c177ff5aea84e93f1b0d87eca1c22e7883", async() => {
                BeginContext(778, 6, true);
                WriteLiteral("线下精准预测");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(793, 1389, true);
            WriteLiteral(@"
                            </select>
                        </div>
                    </div>
                    <div class=""layui-inline"">
                        <label class=""layui-form-label w-auto"">标题：</label>
                        <div class=""layui-input-inline mr0"">
                            <input id=""txttitle"" class=""layui-input"" type=""text"" placeholder=""输入关键字"" />
                        </div>
                    </div>
                    <div class=""layui-inline"">
                        <button id=""btnSearch"" class=""layui-btn icon-btn""><i class=""layui-icon"">&#xe615;</i>搜索</button>
                        <button id=""btnAdd"" class=""layui-btn icon-btn"" data-power=""Add""><i class=""layui-icon"">&#xe654;</i>添加</button>
                    </div>
                </div>
            </div>

            <table class=""layui-table"" id=""userTable"" lay-filter=""userTable""></table>
        </div>
    </div>
</div>

<!-- 表格操作列 -->
<script type=""text/html"" id=""tableBar"">

    <a cla");
            WriteLiteral(@"ss=""layui-btn layui-btn-primary layui-btn-xs"" data-power=""Edit"" lay-event=""edit"">编辑</a>
    <a class=""layui-btn layui-btn-xs"" data-power=""Edit"" lay-event=""list"">题干</a>
    <a class=""layui-btn layui-btn-xs"" data-power=""Edit"" lay-event=""listyw"">原文</a>
    <a class=""layui-btn layui-btn-danger layui-btn-xs"" data-power=""Delete"" lay-event=""del"">删除</a>
</script>

");
            EndContext();
            DefineSection("css", async() => {
                BeginContext(2195, 86, true);
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"/assets/module/formSelects/formSelects-v4.css\" />\r\n");
                EndContext();
            }
            );
            DefineSection("js", async() => {
                BeginContext(2296, 353, true);
                WriteLiteral(@"
    <!-- js部分 -->
    <script>
    layui.use(['form', 'util', 'admin', 'adminList'], function () {
    var $ = layui.jquery;
    var util = layui.util;
    var admin = layui.admin;
    var adminList = layui.adminList;
    var form = layui.form;

    // 渲染表格
    var insTb = adminList.tableLayUI({
        elem: '#userTable',
        url: '");
                EndContext();
                BeginContext(2650, 27, false);
#line 63 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\ReadMain\Index.cshtml"
         Write(Url.Action("GetDataSource"));

#line default
#line hidden
                EndContext();
                BeginContext(2677, 1730, true);
                WriteLiteral(@"',
        page: true,
        cellMinWidth: 100,
        cols: [[
            { type: 'numbers' },
            { field: 'name', title: '名称', sort: true },
            { field: 'over_name', title: '套题', sort: true },
            { field: 'type_name', title: '类型', sort: true },
            { field: 'number', title: '题目数量', sort: true },
            { field: 'created_time', title: '创建时间', sort: true, width: 160 },
            {align: 'center', toolbar: '#tableBar', title: '操作', width: 220}
        ]]
    });

    // 添加
    $('#btnAdd').click(function () {
        showEditModel();
    });

    // 搜索
    $('#btnSearch').click(function () {
        var txttitle = $('#txttitle').val();
        var slisenable = $('#slisenable').val();
        var sltype = $('#sltype').val();
        var digit = $('#digit').val();
        insTb.reload({
            where: { sltype: sltype, txttitle: txttitle }
            , page: {
                curr: 1 //重新从第 1 页开始
            } });
    });

    // ");
                WriteLiteral(@"工具条点击事件
    adminList.table.on('tool(userTable)', function (obj) {
        var data = obj.data;
        var layEvent = obj.event;
        if (layEvent === 'edit') { // 修改
            showEditModel(data);
        } else if (layEvent === 'del') { // 删除
            doDel(data.id);
        }
        else if (layEvent === 'list') { // 编辑
            showListModel(data);
        } else if (layEvent === 'listyw') {
            showListYWModel(data);
        }
    });
    function showEditModel(mUser) {
        adminList.form({
            title: (mUser ? '修改' : '添加') + '文章信息',
            type: 2,
            width: ""800px"",
            height: ""700px"",
            content: mUser ? '");
                EndContext();
                BeginContext(4408, 18, false);
#line 116 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\ReadMain\Index.cshtml"
                         Write(Url.Action("Edit"));

#line default
#line hidden
                EndContext();
                BeginContext(4426, 20, true);
                WriteLiteral("?ID=\' + mUser.id : \'");
                EndContext();
                BeginContext(4447, 17, false);
#line 116 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\ReadMain\Index.cshtml"
                                                                Write(Url.Action("Add"));

#line default
#line hidden
                EndContext();
                BeginContext(4464, 317, true);
                WriteLiteral(@"',
            end: function () {
                insTb.reload();
            }
        });
    }
    function showListModel(mUser) {
        adminList.form({
            title: '管理' + mUser.name + '题干',
            type: 2,
            width: ""1000px"",
            height: ""700px"",
            content: '");
                EndContext();
                BeginContext(4782, 23, false);
#line 128 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\ReadMain\Index.cshtml"
                 Write(Url.Action("IndexList"));

#line default
#line hidden
                EndContext();
                BeginContext(4805, 338, true);
                WriteLiteral(@"?mainId=' + mUser.id,
            end: function () {
                insTb.reload();
            }
        });
    }
    function showListYWModel(mUser) {
        adminList.form({
            title: '管理' + mUser.name + '原文',
            type: 2,
            width: ""1000px"",
            height: ""700px"",
            content: '");
                EndContext();
                BeginContext(5144, 27, false);
#line 140 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\ReadMain\Index.cshtml"
                 Write(Url.Action("IndexContents"));

#line default
#line hidden
                EndContext();
                BeginContext(5171, 230, true);
                WriteLiteral("?mainId=\' + mUser.id,\r\n            end: function () {\r\n                insTb.reload();\r\n            }\r\n        });\r\n    }\r\n    function doDel(Id) {\r\n        var ids = new Array();\r\n        ids.push(Id);\r\n        adminList.delete(\'");
                EndContext();
                BeginContext(5402, 20, false);
#line 149 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\ReadMain\Index.cshtml"
                     Write(Url.Action("Delete"));

#line default
#line hidden
                EndContext();
                BeginContext(5422, 118, true);
                WriteLiteral("\', { id: JSON.stringify(ids) }, function () {\r\n            insTb.reload();\r\n        });\r\n    }\r\n\r\n});\r\n    </script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
