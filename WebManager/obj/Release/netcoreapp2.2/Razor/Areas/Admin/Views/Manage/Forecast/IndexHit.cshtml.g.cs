#pragma checksum "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\Forecast\IndexHit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39c4bd43ec6b361a64c3f96eb80e79d7d8471969"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Manage_Forecast_IndexHit), @"mvc.1.0.view", @"/Areas/Admin/Views/Manage/Forecast/IndexHit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Manage/Forecast/IndexHit.cshtml", typeof(AspNetCore.Areas_Admin_Views_Manage_Forecast_IndexHit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39c4bd43ec6b361a64c3f96eb80e79d7d8471969", @"/Areas/Admin/Views/Manage/Forecast/IndexHit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b8323b3d6a732432ae31640b181b722dbefcc02", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Manage_Forecast_IndexHit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(121, 858, true);
            WriteLiteral(@"
<!-- 正文开始 -->
<div class=""layui-fluid"">
    <div class=""layui-card"">
        <div class=""layui-card-body"">
            <div class=""layui-form toolbar"">
                <div class=""layui-form-item"">
                    <div class=""layui-inline"">
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

    <a class=""layui-btn layui-btn-primary layui-btn-xs"" data-power=""Edit"" lay-event=""edit"">编辑</a>
    <a class=""layui-btn layui-btn-danger layui-btn-xs"" data-power=""Delete"" lay-event=""del"">删除</a>
</script>

");
            EndContext();
            DefineSection("css", async() => {
                BeginContext(992, 86, true);
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"/assets/module/formSelects/formSelects-v4.css\" />\r\n");
                EndContext();
            }
            );
            DefineSection("js", async() => {
                BeginContext(1093, 353, true);
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
                BeginContext(1447, 30, false);
#line 44 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\Forecast\IndexHit.cshtml"
         Write(Url.Action("GetDataSourceHit"));

#line default
#line hidden
                EndContext();
                BeginContext(1477, 1767, true);
                WriteLiteral(@"',
        page: true,
        cellMinWidth: 100,
        cols: [[
            { type: 'numbers' },
            { field: 'times', title: '日期', sort: true },
            { field: 'listening', title: '听力百分比', sort: true },
            { field: 'reading', title: '阅读百分比', sort: true },
            { field: 'speaking', title: '口语百分比', sort: true },
            { field: 'writing', title: '写作百分比', sort: true },
            { field: 'created_time', title: '创建时间', sort: true, width: 160 },
            {align: 'center', toolbar: '#tableBar', title: '操作', width: 180}
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
    ");
                WriteLiteral(@"            curr: 1 //重新从第 1 页开始
            } });
    });

    // 工具条点击事件
    adminList.table.on('tool(userTable)', function (obj) {
        var data = obj.data;
        var layEvent = obj.event;
        if (layEvent === 'edit') { // 修改
            showEditModel(data);
        } else if (layEvent === 'del') { // 删除
            doDel(data.id);
        }
        else if (layEvent === 'upd') { // 编辑
            doUpd(data);
        } else if (layEvent === 'applicationEdit') {

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
                BeginContext(3245, 21, false);
#line 98 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\Forecast\IndexHit.cshtml"
                         Write(Url.Action("EditHit"));

#line default
#line hidden
                EndContext();
                BeginContext(3266, 20, true);
                WriteLiteral("?ID=\' + mUser.id : \'");
                EndContext();
                BeginContext(3287, 20, false);
#line 98 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\Forecast\IndexHit.cshtml"
                                                                   Write(Url.Action("AddHit"));

#line default
#line hidden
                EndContext();
                BeginContext(3307, 211, true);
                WriteLiteral("\',\r\n            end: function () {\r\n                insTb.reload();\r\n            }\r\n        });\r\n    }\r\n    function doDel(Id) {\r\n        var ids = new Array();\r\n        ids.push(Id);\r\n        adminList.delete(\'");
                EndContext();
                BeginContext(3519, 23, false);
#line 107 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\Forecast\IndexHit.cshtml"
                     Write(Url.Action("DeleteHit"));

#line default
#line hidden
                EndContext();
                BeginContext(3542, 118, true);
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
