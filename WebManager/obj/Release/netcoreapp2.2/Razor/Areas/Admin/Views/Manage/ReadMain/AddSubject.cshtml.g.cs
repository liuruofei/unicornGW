#pragma checksum "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\ReadMain\AddSubject.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aba48b065c35aca36303a4d25737ef68fa345cb4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Manage_ReadMain_AddSubject), @"mvc.1.0.view", @"/Areas/Admin/Views/Manage/ReadMain/AddSubject.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Manage/ReadMain/AddSubject.cshtml", typeof(AspNetCore.Areas_Admin_Views_Manage_ReadMain_AddSubject))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aba48b065c35aca36303a4d25737ef68fa345cb4", @"/Areas/Admin/Views/Manage/ReadMain/AddSubject.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b8323b3d6a732432ae31640b181b722dbefcc02", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Manage_ReadMain_AddSubject : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("modelUserForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("lay-filter", new global::Microsoft.AspNetCore.Html.HtmlString("modelUserForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layui-form model-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\ReadMain\AddSubject.cshtml"
  
    var KeyId = ViewBag.ID;
    //类型（0-单选、1-多选、2-看图填空题）
    var ReadType = ViewBag.ReadType;

#line default
#line hidden
            BeginContext(103, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(105, 4524, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aba48b065c35aca36303a4d25737ef68fa345cb45865", async() => {
                BeginContext(187, 80, true);
                WriteLiteral("\r\n    <input name=\"id\" type=\"hidden\" />\r\n    <input name=\"read_id\" type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 267, "\"", 290, 1);
#line 9 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\ReadMain\AddSubject.cshtml"
WriteAttributeValue("", 275, ViewBag.ReadId, 275, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(291, 389, true);
                WriteLiteral(@" />
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">题目</label>
        <div class=""layui-input-block"">
            <input name=""title"" placeholder=""请输入题目"" type=""text"" class=""layui-input"" maxlength=""50"" lay-verType=""tips"" lay-verify=""required"" required />
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">");
                EndContext();
                BeginContext(681, 41, false);
#line 17 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\ReadMain\AddSubject.cshtml"
                                   Write(Html.Raw(ReadType != 2 ? "正确选项" : "正确答案"));

#line default
#line hidden
                EndContext();
                BeginContext(722, 279, true);
                WriteLiteral(@"</label>
        <div class=""layui-input-block"">
            <input name=""right_choice"" placeholder=""请输入正确选项（多个用英文逗号隔开）"" title=""请输入正确选项（多个用英文逗号隔开）"" type=""text"" class=""layui-input"" maxlength=""50"" lay-verType=""tips"" lay-verify=""required"" required />
        </div>
    </div>
");
                EndContext();
#line 22 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\ReadMain\AddSubject.cshtml"
     if (ReadType == 0)
    {

#line default
#line hidden
                BeginContext(1033, 283, true);
                WriteLiteral(@"        <div class=""layui-inline"">
            <label class=""layui-form-label"">是否下拉</label>
            <div class=""layui-input-inline"">
                <select name=""is_selected"" lay-verType=""tips"" lay-filter=""type1"" lay-verify=""required"" placeholder=""请选择"">
                    ");
                EndContext();
                BeginContext(1316, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aba48b065c35aca36303a4d25737ef68fa345cb48435", async() => {
                    BeginContext(1334, 1, true);
                    WriteLiteral("否");
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
                BeginContext(1344, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(1366, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aba48b065c35aca36303a4d25737ef68fa345cb49915", async() => {
                    BeginContext(1384, 1, true);
                    WriteLiteral("是");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1394, 65, true);
                WriteLiteral("\r\n                </select>\r\n            </div>\r\n        </div>\r\n");
                EndContext();
#line 33 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\ReadMain\AddSubject.cshtml"
    }

#line default
#line hidden
                BeginContext(1466, 4, true);
                WriteLiteral("    ");
                EndContext();
#line 34 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\ReadMain\AddSubject.cshtml"
     if (ReadType != 2)
    {

#line default
#line hidden
                BeginContext(1498, 141, true);
                WriteLiteral("        <div class=\"layui-card\">\r\n            <div class=\"layui-card-header\">答案信息</div>\r\n            <div class=\"layui-form\" id=\"daanlist\">\r\n");
                EndContext();
#line 39 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\ReadMain\AddSubject.cshtml"
                  
                    var num = 0;
                    foreach (var item in (List<Dictionary<string, object>>)ViewBag.AnswerList)
                    {

#line default
#line hidden
                BeginContext(1812, 330, true);
                WriteLiteral(@"                        <div class=""layui-form-item"">
                            <div class=""layui-inline"" style=""width:150px;"">
                                <label class=""layui-form-label"">选项</label>
                                <div class=""layui-input-block"">
                                    <input name=""option1""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2142, "\"", 2165, 1);
#line 47 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\ReadMain\AddSubject.cshtml"
WriteAttributeValue("", 2150, item["option"], 2150, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2166, 512, true);
                WriteLiteral(@" placeholder="""" type=""text"" class=""layui-input"" maxlength=""1"" lay-verType=""tips"" lay-verify=""required"" required />
                                </div>
                            </div>
                            <div class=""layui-inline"" style=""width:480px;"">
                                <label class=""layui-form-label"" style=""width:30px"">答案</label>
                                <div class=""layui-input-block"" style=""margin-left:60px;"">
                                    <input name=""answer1""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2678, "\"", 2701, 1);
#line 53 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\ReadMain\AddSubject.cshtml"
WriteAttributeValue("", 2686, item["answer"], 2686, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2702, 199, true);
                WriteLiteral(" placeholder=\"请输入答案\" type=\"text\" class=\"layui-input\" maxlength=\"100\" lay-verType=\"tips\" lay-verify=\"required\" required />\r\n                                </div>\r\n                            </div>\r\n");
                EndContext();
#line 56 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\ReadMain\AddSubject.cshtml"
                             if (num == 0)
                            {

#line default
#line hidden
                BeginContext(2976, 216, true);
                WriteLiteral("                                <div class=\"layui-inline\">\r\n                                    <button type=\"button\" class=\"layui-btn\" onclick=\"addRead(\'\',\'\')\">添加答案</button>\r\n                                </div>\r\n");
                EndContext();
#line 61 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\ReadMain\AddSubject.cshtml"
                            }
                            else
                            {

#line default
#line hidden
                BeginContext(3288, 235, true);
                WriteLiteral("                                <div class=\"layui-inline\">\r\n                                    <button type=\"button\" class=\"layui-btn layui-btn-danger\" onclick=\"removeRead(this)\">删除答案</button>\r\n                                </div>\r\n");
                EndContext();
#line 67 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\ReadMain\AddSubject.cshtml"
                            }

#line default
#line hidden
                BeginContext(3554, 32, true);
                WriteLiteral("                        </div>\r\n");
                EndContext();
#line 69 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\ReadMain\AddSubject.cshtml"
                        num++;
                    }
                

#line default
#line hidden
                BeginContext(3660, 36, true);
                WriteLiteral("            </div>\r\n        </div>\r\n");
                EndContext();
#line 74 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\ReadMain\AddSubject.cshtml"
    }

#line default
#line hidden
                BeginContext(3703, 919, true);
                WriteLiteral(@"    <div class=""layui-form-item part1_contents"">
        <label class=""layui-form-label"">答题解析</label>
        <div class=""layui-input-block"">
            <textarea name=""analysis"" placeholder=""请输入答题解析"" class=""layui-textarea"" lay-verType=""tips"" lay-verify=""required"" required></textarea>
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">排序</label>
        <div class=""layui-input-block"">
            <input name=""sort_id"" placeholder=""请输入排序"" type=""number"" class=""layui-input"" value=""1"" lay-verType=""tips"" />
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4629, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("css", async() => {
                BeginContext(4646, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(4651, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("js", async() => {
                BeginContext(4665, 132, true);
                WriteLiteral("\r\n    <!-- js部分 -->\r\n    <script>\r\n        layui.use([\'form\', \'admin\', \'adminForm\', \'laydate\'], function () {\r\n        var KeyId = \'");
                EndContext();
                BeginContext(4798, 5, false);
#line 102 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\ReadMain\AddSubject.cshtml"
                Write(KeyId);

#line default
#line hidden
                EndContext();
                BeginContext(4803, 655, true);
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
                BeginContext(5459, 5, false);
#line 125 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\ReadMain\AddSubject.cshtml"
                       Write(KeyId);

#line default
#line hidden
                EndContext();
                BeginContext(5464, 30, true);
                WriteLiteral("\',\r\n                    url: \"");
                EndContext();
                BeginContext(5495, 25, false);
#line 126 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\ReadMain\AddSubject.cshtml"
                     Write(Url.Action("FindSubject"));

#line default
#line hidden
                EndContext();
                BeginContext(5520, 946, true);
                WriteLiteral(@""",
                    dataType: 'json',
                    callBack: function (r) {
                    }
                });
            },
            Save: function (data) {
                var daanlist = $('#daanlist .layui-form-item');
                var answer = '';
                if (daanlist && daanlist.length > 0) {
                    var answerObj = new Array();
                    daanlist.each(function (index, ele) {
                        var option = $(ele).find('input[name=""option1""]').val();
                        var answer = $(ele).find('input[name=""answer1""]').val();
                        answerObj.push({ option: option, answer: answer});
                    });
                    answer = JSON.stringify(answerObj);
                    console.log(answer);
                }
                data.field.answer = answer;
                adminForm.Save({
                    url: KeyId ? '");
                EndContext();
                BeginContext(6467, 29, false);
#line 147 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\ReadMain\AddSubject.cshtml"
                             Write(Url.Action("EditSaveSubject"));

#line default
#line hidden
                EndContext();
                BeginContext(6496, 5, true);
                WriteLiteral("\' : \'");
                EndContext();
                BeginContext(6502, 28, false);
#line 147 "D:\work\YNK_YS\YS\WebManager\Areas\Admin\Views\Manage\ReadMain\AddSubject.cshtml"
                                                                Write(Url.Action("AddSaveSubject"));

#line default
#line hidden
                EndContext();
                BeginContext(6530, 1752, true);
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
    });
        function addRead(option, answer) {
            var _html = '<div class=""layui-form-item""><div class=""layui-inline"" style=""width:150px;""><label class=""layui-form-label"">选项</label><div class=""layui-input-block""><input name=""option1"" value=""' + option + '"" placeholder="""" type=""text"" class=""layui-input"" maxlength=""1"" lay-verType=""tips"" lay-verify=""required"" required /></div><");
                WriteLiteral(@"/div><div class=""layui-inline"" style=""width:487px;""><label class=""layui-form-label"" style=""width:30px"">答案</label><div class=""layui-input-block"" style=""margin-left:60px;""><input name=""answer1"" value=""' + answer + '"" placeholder=""请输入答案"" type=""text"" class=""layui-input"" maxlength=""100"" lay-verType=""tips"" lay-verify=""required"" required /></div></div><div class=""layui-inline""><button type=""button"" class=""layui-btn layui-btn-danger"" onclick=""removeRead(this)"">删除答案</button></div></div>';
            $('#daanlist').append(_html);
        }
        function removeRead(_this) {
            console.log($(_this).parents('.layui-form-item'));
            $(_this).parents('.layui-form-item').remove();
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
