#pragma checksum "D:\younengkaoGW\WebManager\Areas\Admin\Views\Sys\Role\ShowRoleList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8fc1dfe6a5bbf801f4014b6a01fe669a8e912d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Sys_Role_ShowRoleList), @"mvc.1.0.view", @"/Areas/Admin/Views/Sys/Role/ShowRoleList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Sys/Role/ShowRoleList.cshtml", typeof(AspNetCore.Areas_Admin_Views_Sys_Role_ShowRoleList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8fc1dfe6a5bbf801f4014b6a01fe669a8e912d1", @"/Areas/Admin/Views/Sys/Role/ShowRoleList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b8323b3d6a732432ae31640b181b722dbefcc02", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Sys_Role_ShowRoleList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("modelUserForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("lay-filter", new global::Microsoft.AspNetCore.Html.HtmlString("modelUserForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layui-form model-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding:0px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(121, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(125, 854, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8fc1dfe6a5bbf801f4014b6a01fe669a8e912d15236", async() => {
                BeginContext(228, 40, true);
                WriteLiteral("\r\n    <input name=\"roleid\" type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 268, "\"", 287, 1);
#line 6 "D:\younengkaoGW\WebManager\Areas\Admin\Views\Sys\Role\ShowRoleList.cshtml"
WriteAttributeValue("", 276, ViewBag.ID, 276, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(288, 684, true);
                WriteLiteral(@" />
    <!-- 正文开始 -->
    <div class=""layui-fluid"" style=""padding:0px;"">
        <!-- 左树 -->
        <div class=""layui-col-sm12 layui-col-md4 layui-col-lg2"">
            <div class=""layui-card"">
                <div class=""layui-card-body mini-bar"" id=""ltTree"">

                </div>
            </div>
        </div>
        <div class=""layui-form-item positionbottomtop""></div>
        <div class=""layui-form-item text-right positionbottom"">
            <button class=""layui-btn layui-btn-primary"" type=""button"" ew-event=""closeDialog"">取消</button>
            <button class=""layui-btn"" lay-filter=""modelUserSubmit"" lay-submit>保存</button>
        </div>
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(979, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("css", async() => {
                BeginContext(996, 165, true);
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"../../../assets/module/dtree/dtree.css\" />\r\n    <link rel=\"stylesheet\" href=\"../../../assets/module/dtree/font/dtreefont.css\" />\r\n");
                EndContext();
            }
            );
            DefineSection("js", async() => {
                BeginContext(1176, 655, true);
                WriteLiteral(@"
    <!-- js部分 -->
    <script>
layui.use(['form', 'util', 'admin', 'adminForm', 'dtree'], function () {
    var $ = layui.jquery;
    var layer = layui.layer;
    var form = layui.form;
    var util = layui.util;
    var admin = layui.admin;
    var adminForm = layui.adminForm;
    var dtree = layui.dtree

    $('html').attr('style', 'background-color:#fff');
    var App = {
        //显示表单弹窗
        showEditModel(mUser) {
            adminList.form({
                title: (mUser ? '修改' : '添加') + '菜单',
                type: 2,
                width: ""1000px"",
                height: ""600px"",
                content: mUser ? '");
                EndContext();
                BeginContext(1832, 18, false);
#line 50 "D:\younengkaoGW\WebManager\Areas\Admin\Views\Sys\Role\ShowRoleList.cshtml"
                             Write(Url.Action("Edit"));

#line default
#line hidden
                EndContext();
                BeginContext(1850, 45, true);
                WriteLiteral("?ID=\' + mUser.Menu_ID + \'&pId=\' + App.pId : \'");
                EndContext();
                BeginContext(1896, 17, false);
#line 50 "D:\younengkaoGW\WebManager\Areas\Admin\Views\Sys\Role\ShowRoleList.cshtml"
                                                                                             Write(Url.Action("Add"));

#line default
#line hidden
                EndContext();
                BeginContext(1913, 618, true);
                WriteLiteral(@"?pId=' + App.pId,
                end: function () {
                    insTb.reload();
                }
            });
        },
        Save: function (data) {
            var params = dtree.getCheckbarNodesParam(""ltTree"");
            var ids = new Array();
            for (var i = 0; i < params.length; i++) {
                var datas = JSON.parse(params[i].basicData);
                ids.push({ MenuFunction_FunctionID: datas.functionId, MenuFunction_MenuID: datas.menuId});
            }
            data.field.rows = JSON.stringify(ids);
            adminForm.Save({
                url: '");
                EndContext();
                BeginContext(2532, 26, false);
#line 65 "D:\younengkaoGW\WebManager\Areas\Admin\Views\Sys\Role\ShowRoleList.cshtml"
                 Write(Url.Action("SaveFunction"));

#line default
#line hidden
                EndContext();
                BeginContext(2558, 254, true);
                WriteLiteral("\',\r\n                data: data.field,\r\n                callBack: function () {\r\n                    admin.closeThisDialog();\r\n                }\r\n            })\r\n        }\r\n    }\r\n\r\n    // 树形渲染\r\n    dtree.render({\r\n        elem: \'#ltTree\',\r\n        url: \'");
                EndContext();
                BeginContext(2813, 37, false);
#line 77 "D:\younengkaoGW\WebManager\Areas\Admin\Views\Sys\Role\ShowRoleList.cshtml"
         Write(Url.Action("GetRoleMenuFunctionTree"));

#line default
#line hidden
                EndContext();
                BeginContext(2850, 8, true);
                WriteLiteral("?roleid=");
                EndContext();
                BeginContext(2859, 10, false);
#line 77 "D:\younengkaoGW\WebManager\Areas\Admin\Views\Sys\Role\ShowRoleList.cshtml"
                                                       Write(ViewBag.ID);

#line default
#line hidden
                EndContext();
                BeginContext(2869, 312, true);
                WriteLiteral(@"',
        type: 'all',
        initLevel: '3',
        checkbar: true,
        checkbarType: true,
        dot: false,
        method: 'GET'
    });

    // 表单提交事件
    form.on('submit(modelUserSubmit)', function (data) {
        App.Save(data);
        return false;
    });

});
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
