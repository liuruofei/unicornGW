#pragma checksum "D:\younengkaoGW\WebManager\Areas\Admin\Views\Sys\Function\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "972562e9d572ac04a4a6b9112140352476b08642"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Sys_Function_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Sys/Function/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Sys/Function/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Sys_Function_Index))]
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
#line 1 "D:\younengkaoGW\WebManager\Areas\Admin\Views\_ViewImports.cshtml"
using WebManager;

#line default
#line hidden
#line 2 "D:\younengkaoGW\WebManager\Areas\Admin\Views\_ViewImports.cshtml"
using WebManager.Models;

#line default
#line hidden
#line 3 "D:\younengkaoGW\WebManager\Areas\Admin\Views\_ViewImports.cshtml"
using ADT.Html;

#line default
#line hidden
#line 4 "D:\younengkaoGW\WebManager\Areas\Admin\Views\_ViewImports.cshtml"
using ADT.Models;

#line default
#line hidden
#line 5 "D:\younengkaoGW\WebManager\Areas\Admin\Views\_ViewImports.cshtml"
using ADT.Common;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"972562e9d572ac04a4a6b9112140352476b08642", @"/Areas/Admin/Views/Sys/Function/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b8323b3d6a732432ae31640b181b722dbefcc02", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Sys_Function_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(121, 864, true);
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

            <table class=""layui-table"" id=""functionTable"" lay-filter=""functionTable""></table>
        </div>
    </div>
</div>

<!-- 表格操作列 -->
<script type=""text/html"" id=""tableBar"">
    <a class=""layui-btn layui-btn-primary layui-btn-xs"" data-power=""Edit"" lay-event=""edit"">修改</a>
    <a class=""layui-btn layui-btn-danger layui-btn-xs"" data-power=""Delete"" lay-event=""del"">删除</a>
</script>

");
            EndContext();
            DefineSection("css", async() => {
                BeginContext(998, 86, true);
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"/assets/module/formSelects/formSelects-v4.css\" />\r\n");
                EndContext();
            }
            );
            DefineSection("js", async() => {
                BeginContext(1099, 440, true);
                WriteLiteral(@"
    <!-- js部分 -->
    <script>
layui.use([ 'form', 'util', 'admin','adminList', 'formSelects'], function () {
    var $ = layui.jquery;
    var layer = layui.layer;
    var form = layui.form;
    var util = layui.util;
    var admin = layui.admin;
    var formSelects = layui.formSelects;
    var adminList = layui.adminList;

    // 渲染表格
    var insTb = adminList.tableLayUI({
        elem: '#functionTable',
        url: '");
                EndContext();
                BeginContext(1540, 27, false);
#line 45 "D:\younengkaoGW\WebManager\Areas\Admin\Views\Sys\Function\Index.cshtml"
         Write(Url.Action("GetDataSource"));

#line default
#line hidden
                EndContext();
                BeginContext(1567, 1453, true);
                WriteLiteral(@"',
        page: true,
        cellMinWidth: 100,
        cols: [[
            { type: 'numbers' },
            { field: 'Function_Num', title: '编号', sort: true },
            { field: 'Function_Name', title: '功能名称', sort: true },
            { field: 'Function_ByName', title: '功能英文名', sort: true },
            { field: 'Function_CreateTime', title: '创建时间', sort: true },
            {align: 'center', toolbar: '#tableBar', title: '操作', width: 120}
        ]]
    });

    // 添加
    $('#btnAdd').click(function () {
        showEditModel();
    });

    // 搜索
    $('#btnSearch').click(function () {
        var key = $('#sltKey').val();
        var value = $('#edtSearch').val();
        if (value && !key) {
            admin.msg('请选择搜索条件', 2);
        }
        insTb.reload({where: {searchKey: key, searchValue: value}});
    });

    // 工具条点击事件
    adminList.table.on('tool(functionTable)', function (obj) {
        var data = obj.data;
        var layEvent = obj.event;
        if (la");
                WriteLiteral(@"yEvent === 'edit') { // 修改
            showEditModel(data);
        } else if (layEvent === 'del') { // 删除
            doDel(data.Function_ID, data.User_LoginName);
        }
    });

    //显示表单弹窗
    function showEditModel(mUser) {
        adminList.form({
            title: (mUser ? '修改' : '添加') + '功能',
            type: 2,
            width: ""500px"",
            height: ""600px"",
            content: mUser ? '");
                EndContext();
                BeginContext(3021, 18, false);
#line 91 "D:\younengkaoGW\WebManager\Areas\Admin\Views\Sys\Function\Index.cshtml"
                         Write(Url.Action("Edit"));

#line default
#line hidden
                EndContext();
                BeginContext(3039, 29, true);
                WriteLiteral("?ID=\' + mUser.Function_ID : \'");
                EndContext();
                BeginContext(3069, 17, false);
#line 91 "D:\younengkaoGW\WebManager\Areas\Admin\Views\Sys\Function\Index.cshtml"
                                                                         Write(Url.Action("Add"));

#line default
#line hidden
                EndContext();
                BeginContext(3086, 231, true);
                WriteLiteral("\',\r\n            end: function () {\r\n                insTb.reload();\r\n            }\r\n        });\r\n    }\r\n    //删除\r\n    function doDel(Id, nickName) {\r\n        var ids = new Array();\r\n        ids.push(Id);\r\n        adminList.delete(\'");
                EndContext();
                BeginContext(3318, 20, false);
#line 101 "D:\younengkaoGW\WebManager\Areas\Admin\Views\Sys\Function\Index.cshtml"
                     Write(Url.Action("Delete"));

#line default
#line hidden
                EndContext();
                BeginContext(3338, 118, true);
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
