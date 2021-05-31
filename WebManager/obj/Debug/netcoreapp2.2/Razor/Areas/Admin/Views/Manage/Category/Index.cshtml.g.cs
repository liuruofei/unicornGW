#pragma checksum "D:\younengkaoGW\WebManager\Areas\Admin\Views\Manage\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3bda63f4d7bbae43fc8bd22e8b5ed7065e045e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Manage_Category_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Manage/Category/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Manage/Category/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Manage_Category_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3bda63f4d7bbae43fc8bd22e8b5ed7065e045e8", @"/Areas/Admin/Views/Manage/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b8323b3d6a732432ae31640b181b722dbefcc02", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Manage_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(121, 1405, true);
            WriteLiteral(@"
<!-- 正文开始 -->
<div class=""layui-fluid"">
    <div class=""layui-card"">
        <div class=""layui-card-body"">
            <div class=""layui-form toolbar"">
                <div class=""layui-form-item"">
                    <div class=""layui-inline"">
                        <label class=""layui-form-label w-auto"">栏目名称：</label>
                        <div class=""layui-input-inline mr0"">
                            <input id=""txtTitle"" class=""layui-input"" type=""text"" placeholder=""输入标题"" />
                        </div>
                    </div>
                    <div class=""layui-inline"">
                        <button id=""btnSearch"" class=""layui-btn icon-btn""><i class=""layui-icon"">&#xe615;</i>搜索</button>
                    </div>
                    <div class=""layui-inline"">
                        <button id=""btnAdd"" class=""layui-btn icon-btn"" data-power=""Add""><i class=""layui-icon"">&#xe654;</i>添加</button>
                    </div>
                </div>
            </div>

            ");
            WriteLiteral(@"<table class=""layui-table"" id=""userTable"" lay-filter=""userTable""></table>
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
                BeginContext(1539, 273, true);
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""/assets/module/formSelects/formSelects-v4.css"" />
   <style>
       .layui-table-cell {
           height: auto;
           line-height: 28px;
       }
       .layui-table img {
           max-width: 600px;
       }
   </style>
");
                EndContext();
            }
            );
            DefineSection("js", async() => {
                BeginContext(1827, 321, true);
                WriteLiteral(@"
    <!-- js部分 -->
    <script>
layui.use(['form', 'util', 'admin', 'adminList'], function () {
    var $ = layui.jquery;
    var util = layui.util;
    var admin = layui.admin;
    var adminList = layui.adminList;

    // 渲染表格
    var insTb = adminList.tableLayUI({
        elem: '#userTable',
        url: '");
                EndContext();
                BeginContext(2149, 27, false);
#line 60 "D:\younengkaoGW\WebManager\Areas\Admin\Views\Manage\Category\Index.cshtml"
         Write(Url.Action("GetDataSource"));

#line default
#line hidden
                EndContext();
                BeginContext(2176, 1586, true);
                WriteLiteral(@"',
        page: true,
        cellMinWidth: 100,
        cols: [[
            { type: 'numbers' },
            { field: 'CategoryName', title: '栏目名称', sort: true },
            { field: 'Subtitle', title: '标题', sort: true },
            {
                field: 'Sort', title: '排序', sort: true, width: 120, templet: function (d) {
                    return ""<input type='number' value='"" + d.Sort + ""' data-id='"" + d.Id + ""' style='width:80px' onchange='orderBy(this)'/>"";
                }
            },
            { field: 'CreateTime', title: '创建时间', sort: true },
            {align: 'center', toolbar: '#tableBar', title: '操作', width: 200}
        ]]
    });

    // 添加
    $('#btnAdd').click(function () {
        showEditModel();
    });

    // 搜索
    $('#btnSearch').click(function () {
        var title = $('#txtTitle').val();
        insTb.reload({
            where: { title: title }
            , page: {
                curr: 1 //重新从第 1 页开始
            }
        });
    });");
                WriteLiteral(@"

    // 工具条点击事件
    adminList.table.on('tool(userTable)', function (obj) {
        var data = obj.data;
        var layEvent = obj.event;
        if (layEvent === 'edit') { // 修改
            showEditModel(data);
        } else if (layEvent === 'del') { // 删除
            doDel(data.Id);
        }
    });

    //显示表单弹窗
    function showEditModel(vmodel) {
        adminList.form({
            title: (vmodel ? '修改' : '添加') + '新闻',
            type: 2,
            width: ""1360px"",
            height: ""700px"",
            content: vmodel ? '");
                EndContext();
                BeginContext(3763, 18, false);
#line 111 "D:\younengkaoGW\WebManager\Areas\Admin\Views\Manage\Category\Index.cshtml"
                          Write(Url.Action("Edit"));

#line default
#line hidden
                EndContext();
                BeginContext(3781, 21, true);
                WriteLiteral("?ID=\' + vmodel.Id : \'");
                EndContext();
                BeginContext(3803, 17, false);
#line 111 "D:\younengkaoGW\WebManager\Areas\Admin\Views\Manage\Category\Index.cshtml"
                                                                  Write(Url.Action("Add"));

#line default
#line hidden
                EndContext();
                BeginContext(3820, 171, true);
                WriteLiteral("?ID=0\',\r\n            end: function () {\r\n                insTb.reload();\r\n            }\r\n        });\r\n    }\r\n    //删除\r\n    function doDel(Id) {\r\n        adminList.delete(\'");
                EndContext();
                BeginContext(3992, 20, false);
#line 119 "D:\younengkaoGW\WebManager\Areas\Admin\Views\Manage\Category\Index.cshtml"
                     Write(Url.Action("Delete"));

#line default
#line hidden
                EndContext();
                BeginContext(4012, 576, true);
                WriteLiteral(@"', { Id: Id}, function () {
            insTb.reload();
        });
    };

});
        function orderBy(obj) {
            console.log($(obj).attr(""data-id""));
            $.ajax({
                type: ""post"",
                url: ""SetSort"",
                data: { Id: $(obj).attr(""data-id""), sort:$(obj).val()},
                dataType: 'json',
                contentType: 'application/x-www-form-urlencoded',
                success: function (data) {
                    console.log(data);
                }
            });
        }
    </script>
");
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
