#pragma checksum "D:\younengkao\manage\WebManager\Areas\Admin\Views\Manage\Materia\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6839c939b5b0fa29d1c09cd9d269199602952b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Manage_Materia_Add), @"mvc.1.0.view", @"/Areas/Admin/Views/Manage/Materia/Add.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Manage/Materia/Add.cshtml", typeof(AspNetCore.Areas_Admin_Views_Manage_Materia_Add))]
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
#line 1 "D:\younengkao\manage\WebManager\Areas\Admin\Views\_ViewImports.cshtml"
using WebManager;

#line default
#line hidden
#line 2 "D:\younengkao\manage\WebManager\Areas\Admin\Views\_ViewImports.cshtml"
using WebManager.Models;

#line default
#line hidden
#line 3 "D:\younengkao\manage\WebManager\Areas\Admin\Views\_ViewImports.cshtml"
using ADT.Html;

#line default
#line hidden
#line 4 "D:\younengkao\manage\WebManager\Areas\Admin\Views\_ViewImports.cshtml"
using ADT.Models;

#line default
#line hidden
#line 5 "D:\younengkao\manage\WebManager\Areas\Admin\Views\_ViewImports.cshtml"
using ADT.Common;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6839c939b5b0fa29d1c09cd9d269199602952b1", @"/Areas/Admin/Views/Manage/Materia/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b8323b3d6a732432ae31640b181b722dbefcc02", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Manage_Materia_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\younengkao\manage\WebManager\Areas\Admin\Views\Manage\Materia\Add.cshtml"
  
    var KeyId = ViewBag.ID;

#line default
#line hidden
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(38, 1004, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6839c939b5b0fa29d1c09cd9d269199602952b15039", async() => {
                BeginContext(120, 44, true);
                WriteLiteral("\r\n    <input name=\"MaterialId\" type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 164, "\"", 183, 1);
#line 6 "D:\younengkao\manage\WebManager\Areas\Admin\Views\Manage\Materia\Add.cshtml"
WriteAttributeValue("", 172, ViewBag.ID, 172, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(184, 851, true);
                WriteLiteral(@" />
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">资料名称</label>
        <div class=""layui-input-block"">
            <input  name=""MateriaName"" placeholder=""请输入课程名称"" class=""layui-input"" lay-verify=""required"" required/>
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">是否开启</label>
        <div class=""layui-input-block"">
            <input type=""checkbox"" name=""IsEnble""   value=""1""  class=""layui-form-checkbox""/>
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
            BeginContext(1042, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("css", async() => {
                BeginContext(1059, 184, true);
                WriteLiteral("\r\n<style>\r\n    .ke-container {\r\n        margin-left: 33px !important;\r\n    }\r\n\r\n    .ke-edit, .ke-edit-iframe, .ke-edit-textarea {\r\n        height: 266px !important;\r\n    }\r\n</style>\r\n");
                EndContext();
            }
            );
            BeginContext(1246, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("js", async() => {
                BeginContext(1260, 118, true);
                WriteLiteral("\r\n    <!-- js部分 -->\r\n    <script>\r\n    layui.use([ \'form\', \'admin\', \'adminForm\'], function () {\r\n        var KeyId = \'");
                EndContext();
                BeginContext(1379, 5, false);
#line 42 "D:\younengkao\manage\WebManager\Areas\Admin\Views\Manage\Materia\Add.cshtml"
                Write(KeyId);

#line default
#line hidden
                EndContext();
                BeginContext(1384, 309, true);
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
                BeginContext(1694, 5, false);
#line 52 "D:\younengkao\manage\WebManager\Areas\Admin\Views\Manage\Materia\Add.cshtml"
                       Write(KeyId);

#line default
#line hidden
                EndContext();
                BeginContext(1699, 30, true);
                WriteLiteral("\',\r\n                    url: \"");
                EndContext();
                BeginContext(1730, 18, false);
#line 53 "D:\younengkao\manage\WebManager\Areas\Admin\Views\Manage\Materia\Add.cshtml"
                     Write(Url.Action("Find"));

#line default
#line hidden
                EndContext();
                BeginContext(1748, 634, true);
                WriteLiteral(@""",
                    dataType: 'json',
                    callBack: function (r) {
                        if (r.IsEnble == 1) {
                            $(""input[name='IsEnble']"").prop(""checked"", true);
                        }
                    }
                });
            },
            Save: function (data) {
                if ($(""input[name='IsEnble']"").prop(""checked"") == true) {
                    data.field.IsEnble = 1;
                }
                else {
                    data.field.IsEnble = 0;
                }
                adminForm.Save({
                    url: KeyId ? '");
                EndContext();
                BeginContext(2383, 22, false);
#line 70 "D:\younengkao\manage\WebManager\Areas\Admin\Views\Manage\Materia\Add.cshtml"
                             Write(Url.Action("SaveInfo"));

#line default
#line hidden
                EndContext();
                BeginContext(2405, 5, true);
                WriteLiteral("\' : \'");
                EndContext();
                BeginContext(2411, 22, false);
#line 70 "D:\younengkao\manage\WebManager\Areas\Admin\Views\Manage\Materia\Add.cshtml"
                                                         Write(Url.Action("SaveInfo"));

#line default
#line hidden
                EndContext();
                BeginContext(2433, 402, true);
                WriteLiteral(@"',
                    data: data.field,
                    callBack: function () {
                        admin.closeThisDialog();
                    }
                })
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
