#pragma checksum "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\HearingMain\AddContents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e99b6b2808e0b0ab0d7720073863e2e743d47c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Manage_HearingMain_AddContents), @"mvc.1.0.view", @"/Areas/Admin/Views/Manage/HearingMain/AddContents.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Manage/HearingMain/AddContents.cshtml", typeof(AspNetCore.Areas_Admin_Views_Manage_HearingMain_AddContents))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e99b6b2808e0b0ab0d7720073863e2e743d47c6", @"/Areas/Admin/Views/Manage/HearingMain/AddContents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b8323b3d6a732432ae31640b181b722dbefcc02", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Manage_HearingMain_AddContents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\HearingMain\AddContents.cshtml"
  
    var KeyId = ViewBag.ID;

#line default
#line hidden
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(38, 1177, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e99b6b2808e0b0ab0d7720073863e2e743d47c65114", async() => {
                BeginContext(120, 88, true);
                WriteLiteral("\r\n    <input name=\"id\" type=\"hidden\" />\r\n    <input name=\"hearing_main_id\" type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 208, "\"", 231, 1);
#line 7 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\HearingMain\AddContents.cshtml"
WriteAttributeValue("", 216, ViewBag.MainId, 216, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(232, 976, true);
                WriteLiteral(@" />
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">原文</label>
        <div class=""layui-input-block"">
            <textarea name=""contents"" placeholder=""请输入标题内容"" maxlength=""500"" class=""layui-textarea"" lay-verType=""tips"" lay-verify=""required"" required></textarea>
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">原文翻译</label>
        <div class=""layui-input-block"">
            <textarea name=""contents_translate"" placeholder=""请输入标题内容"" maxlength=""500"" class=""layui-textarea"" lay-verType=""tips"" lay-verify=""required"" required></textarea>
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
            BeginContext(1215, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("css", async() => {
                BeginContext(1232, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(1237, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("js", async() => {
                BeginContext(1251, 132, true);
                WriteLiteral("\r\n    <!-- js部分 -->\r\n    <script>\r\n        layui.use([\'form\', \'admin\', \'adminForm\', \'laydate\'], function () {\r\n        var KeyId = \'");
                EndContext();
                BeginContext(1384, 5, false);
#line 35 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\HearingMain\AddContents.cshtml"
                Write(KeyId);

#line default
#line hidden
                EndContext();
                BeginContext(1389, 655, true);
                WriteLiteral(@"';
        var $ = layui.jquery;
        var form = layui.form;
        var admin = layui.admin;
        var adminForm = layui.adminForm;
        var laydate = layui.laydate;

        admin.initUploadImg({
            elem: '#img_url',
            done: function (res, index, upload) {
                admin.initBindImg({
                    key: 'img_url',
                    data: res.data,
                    number: 1
                });
            }
        });


        var App = {
            Load: function () {
                adminForm.load({
                    formName: 'modelUserForm',
                    KeyId: '");
                EndContext();
                BeginContext(2045, 5, false);
#line 58 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\HearingMain\AddContents.cshtml"
                       Write(KeyId);

#line default
#line hidden
                EndContext();
                BeginContext(2050, 30, true);
                WriteLiteral("\',\r\n                    url: \"");
                EndContext();
                BeginContext(2081, 26, false);
#line 59 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\HearingMain\AddContents.cshtml"
                     Write(Url.Action("FindContents"));

#line default
#line hidden
                EndContext();
                BeginContext(2107, 520, true);
                WriteLiteral(@""",
                    dataType: 'json',
                    callBack: function (r) {
                        typeShow(r.type, r.hearing_type_id);
                        admin.initBindImg({
                            key: 'img_url',
                            data: r.img_url,
                            number: 1
                        });
                    }
                });
            },
            Save: function (data) {
                adminForm.Save({
                    url: KeyId ? '");
                EndContext();
                BeginContext(2628, 30, false);
#line 73 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\HearingMain\AddContents.cshtml"
                             Write(Url.Action("EditSaveContents"));

#line default
#line hidden
                EndContext();
                BeginContext(2658, 5, true);
                WriteLiteral("\' : \'");
                EndContext();
                BeginContext(2664, 29, false);
#line 73 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\HearingMain\AddContents.cshtml"
                                                                 Write(Url.Action("AddSaveContents"));

#line default
#line hidden
                EndContext();
                BeginContext(2693, 847, true);
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
        form.on('select(type)', function (data) {
            console.log(data.elem); //得到select原始DOM对象
            console.log(data.value); //得到被选中的值
            console.log(data.othis); //得到美化后的DOM对象
            typeShow(data.value);
        });
        function typeShow(type) {
            if (type == 2) {
                $('.img_url').show();
            } else {
                $('.img_url').hide();
            }
        }
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
