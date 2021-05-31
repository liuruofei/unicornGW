#pragma checksum "D:\younengkaoGW\WebManager\Areas\Admin\Views\Manage\Account\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c4c6b42668025a58f6aa60e3da9a421e6c1c305"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Manage_Account_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Manage/Account/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Manage/Account/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Manage_Account_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c4c6b42668025a58f6aa60e3da9a421e6c1c305", @"/Areas/Admin/Views/Manage/Account/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b8323b3d6a732432ae31640b181b722dbefcc02", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Manage_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(121, 1762, true);
            WriteLiteral(@"
<!-- 正文开始 -->
<div class=""layui-fluid"">
    <div class=""layui-card"">
        <div class=""layui-card-body"">
            <div class=""layui-form toolbar"">
                <div class=""layui-form-item"">
                    <div class=""layui-inline"">
                        <label class=""layui-form-label w-auto"">手机号码：</label>
                        <div class=""layui-input-inline mr0"">
                            <input id=""txtphone"" class=""layui-input"" type=""text"" placeholder=""输入手机号码"" />
                        </div>
                    </div>
                    <div class=""layui-inline"">
                        <label class=""layui-form-label w-auto"">账号名称：</label>
                        <div class=""layui-input-inline mr0"">
                            <input id=""txtnickname"" class=""layui-input"" type=""text"" placeholder=""账号名称"" />
                        </div>
                    </div>
                    <div class=""layui-inline"">
                        <button id=""btnSearch"" class=""layui-b");
            WriteLiteral(@"tn icon-btn""><i class=""layui-icon"">&#xe615;</i>搜索</button>
                    </div>
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
    <a class=""layui-btn layui-btn-primary layui-btn-xs"" data-power=""Edit"" lay-event=""edit"">修改</a>
    <a class=""layui-btn layui-btn-danger layui-btn-xs"" data-power=""Delete"" lay-event=""del"">删除</a>
</script>

");
            EndContext();
            DefineSection("css", async() => {
                BeginContext(1896, 86, true);
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"/assets/module/formSelects/formSelects-v4.css\" />\r\n");
                EndContext();
            }
            );
            DefineSection("js", async() => {
                BeginContext(1997, 321, true);
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
                BeginContext(2319, 27, false);
#line 57 "D:\younengkaoGW\WebManager\Areas\Admin\Views\Manage\Account\Index.cshtml"
         Write(Url.Action("GetDataSource"));

#line default
#line hidden
                EndContext();
                BeginContext(2346, 1725, true);
                WriteLiteral(@"',
        page: true,
        cellMinWidth: 100,
        cols: [[
            { type: 'numbers' },
            { field: 'Account_Name', title: '账号', sort: true },
            { field: 'Pwd_Display', title: '密码', sort: true },
            {
                field: 'IsUseed', title: '是否被绑定', sort: true, templet: function (d) {
                    return d.IsUseed == 1 ? '是' : '<span style=""padding: 2px 5px 2px 5px;background: #009688;color:white;"">否</span>';
                } },
            { field: 'Mobile', title: '绑定手机号码', sort: true, width: 150},
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
        var txtphone = $('#txtphone').val();
        var txtnickname = $('#txtnickname').val();
        insTb.reload({
            where: { txtphone: ");
                WriteLiteral(@"txtphone, txtnickname: txtnickname }
            , page: {
                curr: 1 //重新从第 1 页开始
            }
        });
    });

    // 工具条点击事件
    adminList.table.on('tool(userTable)', function (obj) {
        var data = obj.data;
        var layEvent = obj.event;
        if (layEvent === 'edit') { // 修改
            showEditModel(data);
        } else if (layEvent === 'del') { // 删除
            doDel(data.Account_Uid);
        }
    });

    //显示表单弹窗
    function showEditModel(mUser) {
        adminList.form({
            title: (mUser ? '修改' : '添加') + '用户',
            type: 2,
            width: ""500px"",
            height: ""600px"",
            content: mUser ? '");
                EndContext();
                BeginContext(4072, 18, false);
#line 109 "D:\younengkaoGW\WebManager\Areas\Admin\Views\Manage\Account\Index.cshtml"
                         Write(Url.Action("Edit"));

#line default
#line hidden
                EndContext();
                BeginContext(4090, 29, true);
                WriteLiteral("?ID=\' + mUser.Account_Uid : \'");
                EndContext();
                BeginContext(4120, 17, false);
#line 109 "D:\younengkaoGW\WebManager\Areas\Admin\Views\Manage\Account\Index.cshtml"
                                                                         Write(Url.Action("Add"));

#line default
#line hidden
                EndContext();
                BeginContext(4137, 178, true);
                WriteLiteral("?ID=0\',\r\n            end: function () {\r\n                insTb.reload();\r\n            }\r\n        });\r\n    }\r\n    //删除\r\n    function doDel(accountId) {\r\n        adminList.delete(\'");
                EndContext();
                BeginContext(4316, 20, false);
#line 117 "D:\younengkaoGW\WebManager\Areas\Admin\Views\Manage\Account\Index.cshtml"
                     Write(Url.Action("Delete"));

#line default
#line hidden
                EndContext();
                BeginContext(4336, 114, true);
                WriteLiteral("\', { accountId: accountId}, function () {\r\n            insTb.reload();\r\n        });\r\n    }\r\n\r\n});\r\n    </script>\r\n");
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
