#pragma checksum "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\HearingMain\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "520823d0dba1ea8e93e7e3a069a12b2ddc853b1f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Manage_HearingMain_Add), @"mvc.1.0.view", @"/Areas/Admin/Views/Manage/HearingMain/Add.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Manage/HearingMain/Add.cshtml", typeof(AspNetCore.Areas_Admin_Views_Manage_HearingMain_Add))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"520823d0dba1ea8e93e7e3a069a12b2ddc853b1f", @"/Areas/Admin/Views/Manage/HearingMain/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b8323b3d6a732432ae31640b181b722dbefcc02", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Manage_HearingMain_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("modelUserForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("lay-filter", new global::Microsoft.AspNetCore.Html.HtmlString("modelUserForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layui-form model-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\HearingMain\Add.cshtml"
  
    var KeyId = ViewBag.ID;

#line default
#line hidden
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(38, 2066, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "520823d0dba1ea8e93e7e3a069a12b2ddc853b1f5472", async() => {
                BeginContext(120, 659, true);
                WriteLiteral(@"
    <input name=""id"" type=""hidden"" />
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">名称</label>
        <div class=""layui-input-block"">
            <input name=""name"" placeholder=""请输入标题"" type=""text"" class=""layui-input"" maxlength=""50"" lay-verType=""tips"" lay-verify=""required"" required />
        </div>
    </div>
    <div class=""layui-form-item"">
        <div class=""layui-inline"">
            <label class=""layui-form-label"">套题</label>
            <div class=""layui-input-inline"">
                <select name=""type"" lay-verType=""tips"" lay-filter=""type"" lay-verify=""required"" placeholder=""请选择类别"">
                    ");
                EndContext();
                BeginContext(779, 33, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "520823d0dba1ea8e93e7e3a069a12b2ddc853b1f6553", async() => {
                    BeginContext(796, 7, true);
                    WriteLiteral("==请选择==");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(812, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 19 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\HearingMain\Add.cshtml"
                     foreach (var item in (List<web_hearing_over>)ViewBag.OverList)
                    {

#line default
#line hidden
                BeginContext(922, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(946, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "520823d0dba1ea8e93e7e3a069a12b2ddc853b1f8379", async() => {
                    BeginContext(972, 9, false);
#line 21 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\HearingMain\Add.cshtml"
                                            Write(item.name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 21 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\HearingMain\Add.cshtml"
                           WriteLiteral(item.id);

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
                BeginContext(990, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 22 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\HearingMain\Add.cshtml"
                    }

#line default
#line hidden
                BeginContext(1015, 1082, true);
                WriteLiteral(@"                </select>
            </div>
        </div>
        <div class=""layui-inline"">
            <label class=""layui-form-label"">类型</label>
            <div class=""layui-input-inline"">
                <select name=""hearing_type_id"" lay-verType=""tips"" lay-filter=""type1"" lay-verify=""required"" placeholder=""请选择类别"">
                </select>
            </div>
        </div>
        <div class=""layui-form-item img_url"">
            <label class=""layui-form-label"">语音:</label>
            <div class=""layui-input-block"">
                <button type=""button"" class=""layui-btn"" id=""audio_url"">上传语音</button>
                <div class=""layui-upload-list file-list"">
                </div>
            </div>
        </div>
    </div>

    <div class=""layui-form-item positionbottomtop""></div>
    <div class=""layui-form-item text-right positionbottom"">
        <button class=""layui-btn layui-btn-primary"" type=""button"" ew-event=""closeDialog"">取消</button>
        <button class=""layui-btn"" lay-fil");
                WriteLiteral("ter=\"modelUserSubmit\" lay-submit>保存</button>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
            BeginContext(2104, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("css", async() => {
                BeginContext(2121, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(2126, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("js", async() => {
                BeginContext(2140, 132, true);
                WriteLiteral("\r\n    <!-- js部分 -->\r\n    <script>\r\n        layui.use([\'form\', \'admin\', \'adminForm\', \'laydate\'], function () {\r\n        var KeyId = \'");
                EndContext();
                BeginContext(2273, 5, false);
#line 57 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\HearingMain\Add.cshtml"
                Write(KeyId);

#line default
#line hidden
                EndContext();
                BeginContext(2278, 846, true);
                WriteLiteral(@"';
        var $ = layui.jquery;
        var form = layui.form;
        var admin = layui.admin;
        var adminForm = layui.adminForm;
        var laydate = layui.laydate;

        admin.uploadFile({
            elem: '#audio_url',
            accept: 'audio',
            data: { exits: '.mp3|.wav|.m4a|.aac' },
            exts: 'mp3|wav|m4a|aac',
            acceptMime: 'audio/mp3,audio/wav,audio/m4a,audio/aac',
            done: function (res, index, upload) {
                admin.initBindFile({
                    key: 'audio_url',
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
                BeginContext(3125, 5, false);
#line 84 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\HearingMain\Add.cshtml"
                       Write(KeyId);

#line default
#line hidden
                EndContext();
                BeginContext(3130, 30, true);
                WriteLiteral("\',\r\n                    url: \"");
                EndContext();
                BeginContext(3161, 18, false);
#line 85 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\HearingMain\Add.cshtml"
                     Write(Url.Action("Find"));

#line default
#line hidden
                EndContext();
                BeginContext(3179, 616, true);
                WriteLiteral(@""",
                    dataType: 'json',
                    callBack: function (r) {
                        typeShow(r.type, r.hearing_type_id);
                        if (r.audio_url) {
                            admin.initBindFile({
                                key: 'audio_url',
                                data: r.audio_url,
                                number: 1
                            });
                        }
                    }
                });
            },
            Save: function (data) {
                adminForm.Save({
                    url: KeyId ? '");
                EndContext();
                BeginContext(3796, 22, false);
#line 101 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\HearingMain\Add.cshtml"
                             Write(Url.Action("EditSave"));

#line default
#line hidden
                EndContext();
                BeginContext(3818, 5, true);
                WriteLiteral("\' : \'");
                EndContext();
                BeginContext(3824, 21, false);
#line 101 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\HearingMain\Add.cshtml"
                                                         Write(Url.Action("AddSave"));

#line default
#line hidden
                EndContext();
                BeginContext(3845, 696, true);
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
        function typeShow(type,value) {
            admin.req('");
                EndContext();
                BeginContext(4542, 25, false);
#line 122 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\HearingMain\Add.cshtml"
                  Write(Url.Action("GetTypeList"));

#line default
#line hidden
                EndContext();
                BeginContext(4567, 565, true);
                WriteLiteral(@"?overId=' + type, '', function (res) {
                console.log(res);
                var _html = '<option value="""">==请选择==</option>';
                for (var i = 0; i < res.length; i++) {
                    _html += '<option value=""'+res[i].id+'"">'+res[i].name+'</option>';
                }
                $('select[name=""hearing_type_id""]').html(_html);
                if (value)
                    $('select[name=""hearing_type_id""]').val(value);
                form.render('select');
            },""Post"")
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
