#pragma checksum "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\Forecast\Count.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fad5013d2c1d0bfd0a684cfbf2358af4a5065d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Manage_Forecast_Count), @"mvc.1.0.view", @"/Areas/Admin/Views/Manage/Forecast/Count.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Manage/Forecast/Count.cshtml", typeof(AspNetCore.Areas_Admin_Views_Manage_Forecast_Count))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fad5013d2c1d0bfd0a684cfbf2358af4a5065d4", @"/Areas/Admin/Views/Manage/Forecast/Count.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b8323b3d6a732432ae31640b181b722dbefcc02", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Manage_Forecast_Count : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2, 1013, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8fad5013d2c1d0bfd0a684cfbf2358af4a5065d44889", async() => {
                BeginContext(84, 924, true);
                WriteLiteral(@"
    <input name=""id"" type=""hidden"" />
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">考题预测总数</label>
        <div class=""layui-input-block"">
            <input name=""forecast"" placeholder=""请输入考题预测总数"" type=""number"" value=""0"" class=""layui-input"" maxlength=""11"" lay-verType=""tips"" lay-verify=""required"" required />
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">考题回忆总数</label>
        <div class=""layui-input-block"">
            <input name=""recall"" placeholder=""请输入考题回忆总数"" type=""number"" value=""0"" class=""layui-input"" maxlength=""11"" lay-verType=""tips"" lay-verify=""required"" required />
        </div>
    </div>

    <div class=""layui-form-item positionbottomtop""></div>
    <div class=""layui-form-item text-right positionbottom"">
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
            BeginContext(1015, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("css", async() => {
                BeginContext(1032, 118, true);
                WriteLiteral("\r\n<style type=\"text/css\">\r\n    .layui-form-label{width:120px;}\r\n    .layui-input-block{margin-left:150px;}\r\n</style>\r\n");
                EndContext();
            }
            );
            BeginContext(1153, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("js", async() => {
                BeginContext(1167, 403, true);
                WriteLiteral(@"
    <!-- js部分 -->
    <script>
        layui.use(['form', 'admin', 'adminForm'], function () {
        var $ = layui.jquery;
        var form = layui.form;
        var admin = layui.admin;
        var adminForm = layui.adminForm;

        var App = {
            Load: function () {
                adminForm.load({
                    formName: 'modelUserForm',
                    url: """);
                EndContext();
                BeginContext(1571, 23, false);
#line 43 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\Forecast\Count.cshtml"
                     Write(Url.Action("FindCount"));

#line default
#line hidden
                EndContext();
                BeginContext(1594, 248, true);
                WriteLiteral("\",\r\n                    dataType: \'json\',\r\n                    callBack: function (r) {\r\n\r\n                    }\r\n                });\r\n            },\r\n            Save: function (data) {\r\n                adminForm.Save({\r\n                    url: \'");
                EndContext();
                BeginContext(1843, 27, false);
#line 52 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\Forecast\Count.cshtml"
                     Write(Url.Action("EditCountSave"));

#line default
#line hidden
                EndContext();
                BeginContext(1870, 129, true);
                WriteLiteral("\',\r\n                    data: data.field,\r\n                    callBack: function () {\r\n                        location.href = \'");
                EndContext();
                BeginContext(2000, 19, false);
#line 55 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\Forecast\Count.cshtml"
                                    Write(Url.Action("Count"));

#line default
#line hidden
                EndContext();
                BeginContext(2019, 268, true);
                WriteLiteral(@"';
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
