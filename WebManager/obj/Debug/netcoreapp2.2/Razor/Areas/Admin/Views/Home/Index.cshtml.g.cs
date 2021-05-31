#pragma checksum "D:\younengkaoGW\WebManager\Areas\Admin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "baa912df8e364456a23e6d7baccdcee21e6871cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Home/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"baa912df8e364456a23e6d7baccdcee21e6871cc", @"/Areas/Admin/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b8323b3d6a732432ae31640b181b722dbefcc02", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\younengkaoGW\WebManager\Areas\Admin\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 132, true);
            WriteLiteral("\r\n<div class=\"layui-layout layui-layout-admin\">\r\n    <!-- 头部 -->\r\n    <div class=\"layui-header\">\r\n        <div class=\"layui-logo\">\r\n");
            EndContext();
            BeginContext(221, 530, true);
            WriteLiteral(@"            <cite>&nbsp;优能考&emsp;</cite>
        </div>
        <ul class=""layui-nav layui-layout-left"">
            <li class=""layui-nav-item"" lay-unselect>
                <a ew-event=""flexible"" title=""侧边伸缩""><i class=""layui-icon layui-icon-shrink-right""></i></a>
            </li>
            <li class=""layui-nav-item"" lay-unselect>
                <a ew-event=""refresh"" title=""刷新""><i class=""layui-icon layui-icon-refresh-3""></i></a>
            </li>
        </ul>
        <ul class=""layui-nav layui-layout-right"">
");
            EndContext();
            BeginContext(922, 269, true);
            WriteLiteral(@"            <li class=""layui-nav-item layui-hide-xs"" lay-unselect>
                <a ew-event=""fullScreen"" title=""全屏""><i class=""layui-icon layui-icon-screen-full""></i></a>
            </li>
            <li class=""layui-nav-item"" lay-unselect>
                <a>
");
            EndContext();
            BeginContext(1263, 26, true);
            WriteLiteral("                    <cite>");
            EndContext();
            BeginContext(1290, 16, false);
#line 30 "D:\younengkaoGW\WebManager\Areas\Admin\Views\Home\Index.cshtml"
                     Write(ViewBag.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1306, 315, true);
            WriteLiteral(@"</cite>
                </a>
                <dl class=""layui-nav-child"">
                    <dd lay-unselect>
                        <a ew-event=""psw"">修改密码</a>
                    </dd>
                    <hr>
                    <dd lay-unselect>
                        <a ew-event=""logout"" data-url=""");
            EndContext();
            BeginContext(1622, 25, false);
#line 38 "D:\younengkaoGW\WebManager\Areas\Admin\Views\Home\Index.cshtml"
                                                  Write(Url.Action("out","Login"));

#line default
#line hidden
            EndContext();
            BeginContext(1647, 6634, true);
            WriteLiteral(@""">退出</a>
                    </dd>
                </dl>
            </li>
            <li class=""layui-nav-item"" lay-unselect>
                <a ew-event=""theme"" title=""主题""><i class=""layui-icon layui-icon-more-vertical""></i></a>
            </li>
        </ul>
    </div>

    <!-- 侧边栏 -->
    <div class=""layui-side"">
        <div class=""layui-side-scroll"">
            <ul class=""layui-nav layui-nav-tree"" lay-filter=""admin-side-nav"" lay-accordion=""true""
                style=""margin: 15px 0;"">
                <li class=""layui-nav-item"">
                    <a><i class=""layui-icon layui-icon-set""></i>&emsp;<cite>系统管理</cite></a>
                    <dl class=""layui-nav-child"">
                        <dd><a lay-href=""page/system/user.html"">用户管理</a></dd>
                        <dd><a lay-href=""page/system/role.html"">角色管理</a></dd>
                        <dd><a lay-href=""page/system/authorities.html"">菜单管理</a></dd>
                        <dd><a lay-href=""page/system/loginRecord.html"">登录日志</");
            WriteLiteral(@"a></dd>
                    </dl>
                </li>
                <li class=""layui-nav-item"">
                    <a><i class=""layui-icon layui-icon-template""></i>&emsp;<cite>模板页面</cite></a>
                    <dl class=""layui-nav-child"">
                        <dd>
                            <a>表单页</a>
                            <dl class=""layui-nav-child"">
                                <dd><a lay-href=""page/template/form/form-basic.html"">基础表单</a></dd>
                                <dd><a lay-href=""page/template/form/form-advance.html"">复杂表单</a></dd>
                                <dd><a lay-href=""page/template/form/form-step.html"">分步表单</a></dd>
                            </dl>
                        </dd>
                        <dd>
                            <a>表格页</a>
                            <dl class=""layui-nav-child"">
                                <dd><a lay-href=""page/template/table/table-basic.html"">数据表格</a></dd>
                                <dd><a lay-href");
            WriteLiteral(@"=""page/template/table/table-advance.html"">复杂查询</a></dd>
                                <dd><a lay-href=""page/template/table/table-ltrt.html"">左树右表</a></dd>
                                <dd><a lay-href=""page/template/table/table-img.html"">表格缩略图</a></dd>
                            </dl>
                        </dd>
                        <dd>
                            <a>错误页</a>
                            <dl class=""layui-nav-child"">
                                <dd><a lay-href=""page/template/error/error-500.html"">500</a></dd>
                                <dd><a lay-href=""page/template/error/error-404.html"">404</a></dd>
                                <dd><a lay-href=""page/template/error/error-403.html"">403</a></dd>
                            </dl>
                        </dd>
                        <dd><a lay-href=""page/template/user-info.html"">个人中心</a></dd>
                        <dd><a href=""page/template/login.html"" target=""_blank"">登录页面</a></dd>
                        <dd>");
            WriteLiteral(@"<a lay-href=""page/template/file/fileMain.html"">文件管理</a></dd>
                        <dd><a href=""page/template/side-more.html"" target=""_blank"">多系统</a></dd>
                    </dl>
                </li>
                <li class=""layui-nav-item"">
                    <a><i class=""layui-icon layui-icon-app""></i>&emsp;<cite>扩展组件</cite></a>
                    <dl class=""layui-nav-child"">
                        <dd><a lay-href=""page/plugin/dropdown.html"">下拉菜单</a></dd>
                        <dd><a lay-href=""page/plugin/notice.html"">消息通知</a></dd>
                        <dd><a lay-href=""page/plugin/dialog.html"">弹窗皮肤</a></dd>
                        <dd><a lay-href=""page/plugin/contextMenu.html"">鼠标右键</a></dd>
                        <dd><a lay-href=""page/plugin/printer.html"">打印插件</a></dd>
                        <dd><a lay-href=""page/plugin/other.html"">更多扩展</a></dd>
                    </dl>
                </li>
                <li class=""layui-nav-item"">
                    <a><i class=""layui-");
            WriteLiteral(@"icon layui-icon-release""></i>&emsp;<cite>LayUI组件</cite></a>
                    <dl class=""layui-nav-child"">
                        <dd><a lay-href=""https://www.layui.com/demo/button.html"">组件演示</a></dd>
                        <dd><a lay-href=""https://www.layui.com/doc/element/button.html#use"">layui文档</a></dd>
                        <dd><a lay-href=""https://layer.layui.com/"">layer弹窗组件</a></dd>
                        <dd><a lay-href=""https://www.layui.com/laydate/"">laydate日期组件</a></dd>
                    </dl>
                </li>
                <li class=""layui-nav-item"">
                    <a><i class=""layui-icon layui-icon-unlink""></i>&emsp;<cite>多级菜单</cite></a>
                    <dl class=""layui-nav-child"">
                        <dd><a>二级菜单</a></dd>
                        <dd>
                            <a>二级菜单</a>
                            <dl class=""layui-nav-child"">
                                <dd><a>三级菜单</a></dd>
                                <dd>
                 ");
            WriteLiteral(@"                   <a>三级菜单</a>
                                    <dl class=""layui-nav-child"">
                                        <dd><a>四级菜单</a></dd>
                                        <dd>
                                            <a>四级菜单</a>
                                            <dl class=""layui-nav-child"">
                                                <dd><a>五级菜单</a></dd>
                                                <dd>
                                                    <a lay-href=""https://baidu.com"">百度一下</a>
                                                </dd>
                                            </dl>
                                        </dd>
                                    </dl>
                                </dd>
                            </dl>
                        </dd>
                    </dl>
                </li>
                <li class=""layui-nav-item"">
                    <a lay-href=""//baidu.com""><i class=""layui-icon layui-");
            WriteLiteral(@"icon-unlink""></i>&emsp;<cite>一级菜单</cite></a>
                </li>
            </ul>
        </div>
    </div>

    <!-- 主体部分 -->
    <div class=""layui-body""></div>
    <!-- 底部 -->
    <div class=""layui-footer"">
        copyright © 2020 <span class=""pull-right"">Version 1.0.0</span>
    </div>
</div>

<!-- 加载动画，移除位置在common.js中 -->
<div class=""page-loading"">
    <div class=""ball-loader"">
        <span></span><span></span><span></span><span></span>
    </div>
</div>

");
            EndContext();
            DefineSection("js", async() => {
                BeginContext(8293, 2728, true);
                WriteLiteral(@"
    <script id=""menuNav"" type=""text/html"">
        {{#  layui.each(d, function(index, item){ }}
        <li class=""layui-nav-item"">
            <a {{# if(item.url){ }} lay-href=""{{item.url}}"" {{# }}}><i class=""layui-icon {{item.icon}}""></i>&emsp;<cite>{{ item.name}}</cite></a>
            {{# if(item.subMenus&&item.subMenus.length>0){ }}
            <dl class=""layui-nav-child"">
                {{# layui.each(item.subMenus, function(index, subItem){ }}
                <dd>
                    <a {{# if(subItem.url){ }} lay-href=""{{ subItem.url }}"" {{#}}}>{{ subItem.name }}</a>

                    {{# if(subItem.subMenus&&subItem.subMenus.length>0){ }}
                    <dl class=""layui-nav-child"">
                        {{# layui.each(subItem.subMenus, function(index, thrItem){ }}
                        <dd>
                            <a {{# if(thrItem.url){ }} lay-href=""{{ thrItem.url }}"" {{#}}}>{{ thrItem.name }}</a>

                            {{# if(thrItem.subMenus&&thrItem.subMen");
                WriteLiteral(@"us.length>0){ }}
                            <dl class=""layui-nav-child"">
                                {{# layui.each(thrItem.subMenus, function(index, fourItem){ }}
                                <dd>
                                    <a {{# if(fourItem.url){}} lay-href=""{{ fourItem.url }}"" {{# }}}>{{ fourItem.name }}</a>

                                    {{# if(fourItem.subMenus&&fourItem.subMenus.length>0){ }}
                                    <dl class=""layui-nav-child"">
                                        {{# layui.each(fourItem.subMenus, function(index, fiveItem){ }}
                                        <dd>
                                            <a {{# if(fiveItem.url){}} lay-href=""{{ fiveItem.url }}"" {{#}}}>{{ fiveItem.name }}</a>
                                        </dd>
                                        {{# }); }}
                                    </dl>
                                    {{# } }}

                                </dd>
            ");
                WriteLiteral(@"                    {{# }); }}
                            </dl>
                            {{# } }}

                        </dd>
                        {{# }); }}
                    </dl>
                    {{# } }}
                </dd>
                {{# }); }}
            </dl>
            {{# } }}
        </li>
        {{#  }); }}
    </script>
    <script>
    layui.use(['index', 'admin', 'laytpl','element'], function () {
        var $ = layui.jquery;
        var index = layui.index;
        var admin = layui.admin;
        var laytpl = layui.laytpl;
        var element = layui.element;
        $.ajax({
            async: false, url: '");
                EndContext();
                BeginContext(11022, 21, false);
#line 222 "D:\younengkaoGW\WebManager\Areas\Admin\Views\Home\Index.cshtml"
                           Write(Url.Action("GetMenu"));

#line default
#line hidden
                EndContext();
                BeginContext(11043, 361, true);
                WriteLiteral(@"', success: function (res) {
                laytpl(menuNav.innerHTML).render(res, function (html) {
                    $('.layui-layout-admin .layui-side .layui-nav').html(html);
                    element.render('nav');
                });
            }, dataType:'json'
        })
        // 默认加载主页
        index.loadHome({
            menuPath: '");
                EndContext();
                BeginContext(11405, 21, false);
#line 231 "D:\younengkaoGW\WebManager\Areas\Admin\Views\Home\Index.cshtml"
                  Write(Url.Action("Welcome"));

#line default
#line hidden
                EndContext();
                BeginContext(11426, 109, true);
                WriteLiteral("\',\r\n            menuName: \'<i class=\"layui-icon layui-icon-home\"></i>\'\r\n        });\r\n    });\r\n    </script>\r\n");
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
