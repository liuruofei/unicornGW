#pragma checksum "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Sys\User\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "525d6299cfe37a8bd2e6d690823a98e5d827c89f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Sys_User_Add), @"mvc.1.0.view", @"/Areas/Admin/Views/Sys/User/Add.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Sys/User/Add.cshtml", typeof(AspNetCore.Areas_Admin_Views_Sys_User_Add))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"525d6299cfe37a8bd2e6d690823a98e5d827c89f", @"/Areas/Admin/Views/Sys/User/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b8323b3d6a732432ae31640b181b722dbefcc02", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Sys_User_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("modelUserForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("lay-filter", new global::Microsoft.AspNetCore.Html.HtmlString("modelUserForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layui-form model-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Sys\User\Add.cshtml"
  
    var KeyId = ViewBag.ID;

#line default
#line hidden
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(38, 2171, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "525d6299cfe37a8bd2e6d690823a98e5d827c89f5102", async() => {
                BeginContext(120, 1490, true);
                WriteLiteral(@"
    <input name=""User_ID"" type=""hidden"" />
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">账号</label>
        <div class=""layui-input-block"">
            <input name=""User_LoginName"" placeholder=""请输入账号"" type=""text"" class=""layui-input"" maxlength=""20"" lay-verType=""tips"" lay-verify=""required"" required />
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">用户名</label>
        <div class=""layui-input-block"">
            <input name=""User_Name"" placeholder=""请输入用户名"" type=""text"" class=""layui-input"" maxlength=""20"" lay-verType=""tips"" lay-verify=""required"" required />
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">密码</label>
        <div class=""layui-input-block"">
            <input name=""User_Pwd"" placeholder=""请输入密码"" type=""password"" class=""layui-input"" maxlength=""20"" lay-verType=""tips"" />
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""lay");
                WriteLiteral(@"ui-form-label"">状态</label>
        <div class=""layui-input-block"">
            <input type=""radio"" name=""User_IsDelete"" value=""2"" title=""正常"" checked />
            <input type=""radio"" name=""User_IsDelete"" value=""1"" title=""锁定"" />
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">角色</label>
        <div class=""layui-input-block"">
            <select name=""Role_ID"" lay-verType=""tips"" lay-verify=""required"">
");
                EndContext();
#line 36 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Sys\User\Add.cshtml"
                   foreach (var item in (List<sys_role>)ViewBag.RoleList)
                    {

#line default
#line hidden
                BeginContext(1708, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(1732, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "525d6299cfe37a8bd2e6d690823a98e5d827c89f7451", async() => {
                    BeginContext(1763, 14, false);
#line 38 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Sys\User\Add.cshtml"
                                                 Write(item.Role_Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 38 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Sys\User\Add.cshtml"
                           WriteLiteral(item.Role_ID);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1786, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 39 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Sys\User\Add.cshtml"
                    }
                

#line default
#line hidden
                BeginContext(1830, 372, true);
                WriteLiteral(@"            </select>
        </div>
    </div>
    <div class=""layui-form-item positionbottomtop""></div>
    <div class=""layui-form-item text-right positionbottom"">
        <button class=""layui-btn layui-btn-primary"" type=""button"" ew-event=""closeDialog"">取消</button>
        <button class=""layui-btn"" lay-filter=""modelUserSubmit"" lay-submit>保存</button>
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2209, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("css", async() => {
                BeginContext(2226, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(2231, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("js", async() => {
                BeginContext(2245, 118, true);
                WriteLiteral("\r\n    <!-- js部分 -->\r\n    <script>\r\n    layui.use([ \'form\', \'admin\', \'adminForm\'], function () {\r\n        var KeyId = \'");
                EndContext();
                BeginContext(2364, 5, false);
#line 58 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Sys\User\Add.cshtml"
                Write(KeyId);

#line default
#line hidden
                EndContext();
                BeginContext(2369, 309, true);
                WriteLiteral(@"';
        var $ = layui.jquery;
        var form = layui.form;
        var admin = layui.admin;
        var adminForm = layui.adminForm;

        var App = {
            Load: function () {
                adminForm.load({
                    formName: 'modelUserForm',
                    KeyId: '");
                EndContext();
                BeginContext(2679, 5, false);
#line 68 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Sys\User\Add.cshtml"
                       Write(KeyId);

#line default
#line hidden
                EndContext();
                BeginContext(2684, 30, true);
                WriteLiteral("\',\r\n                    url: \"");
                EndContext();
                BeginContext(2715, 18, false);
#line 69 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Sys\User\Add.cshtml"
                     Write(Url.Action("Find"));

#line default
#line hidden
                EndContext();
                BeginContext(2733, 658, true);
                WriteLiteral(@""",
                    dataType: 'json',
                    callBack: function (r) {
                        $('input[name=""User_IsDelete""][value=""' + r.User_IsDelete + '""]').prop(""checked"", true);
                    }
                });
            },
            Save: function (data) {
                var user_Pwd = $('input[name=""User_Pwd""]').val();
                if (user_Pwd == '' || user_Pwd==null)
                    admin.msg(""请输入密码"", 0);
                else {
                    if (user_Pwd)
                        data.field.User_Pwd = user_Pwd;
                    adminForm.Save({
                        url: KeyId ? '");
                EndContext();
                BeginContext(3392, 22, false);
#line 84 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Sys\User\Add.cshtml"
                                 Write(Url.Action("EditSave"));

#line default
#line hidden
                EndContext();
                BeginContext(3414, 5, true);
                WriteLiteral("\' : \'");
                EndContext();
                BeginContext(3420, 21, false);
#line 84 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Sys\User\Add.cshtml"
                                                             Write(Url.Action("AddSave"));

#line default
#line hidden
                EndContext();
                BeginContext(3441, 441, true);
                WriteLiteral(@"',
                        data: data.field,
                        callBack: function () {
                            admin.closeThisDialog();
                        }
                    })
                }
            }
        }
        App.Load();
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
