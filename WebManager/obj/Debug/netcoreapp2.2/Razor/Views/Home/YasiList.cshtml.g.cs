#pragma checksum "D:\younengkao\manage\WebManager\Views\Home\YasiList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a6951bad844508fa8047be5fd52570fe0227f68"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_YasiList), @"mvc.1.0.view", @"/Views/Home/YasiList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/YasiList.cshtml", typeof(AspNetCore.Views_Home_YasiList))]
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
#line 1 "D:\younengkao\manage\WebManager\Views\_ViewImports.cshtml"
using WebManager;

#line default
#line hidden
#line 2 "D:\younengkao\manage\WebManager\Views\_ViewImports.cshtml"
using WebManager.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a6951bad844508fa8047be5fd52570fe0227f68", @"/Views/Home/YasiList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a472608030038dae4e094cd50cb4aba226576597", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_YasiList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\younengkao\manage\WebManager\Views\Home\YasiList.cshtml"
  
    Layout = "/Views/Shared/_Templete.cshtml";

#line default
#line hidden
            BeginContext(55, 2589, true);
            WriteLiteral(@"<style>
    .front .section--content {
        background: transparent linear-gradient( 0deg,#f5f5f5,#f5f5f5);
        margin-top: initial;
    }
</style>
<div id=""section--content"" class=""section section--content wrapper-background wrapper-background--angle "">
    <div class=""section__inner-wrapper section__inner "">
        <div class=""section__content"">
            <div class=""region region__content brick--main"">
                <article class=""node node-landing-page article article--landing-page article--view-full article-type--landing_page prose clearfix"">
                    <div class=""article__paragraphs"">

                        <div class=""entity entity-paragraphs-item paragraphs-item-content-blocks entity-paragraphs-item--full"">
                            <div class=""content"">
                                <div class=""wrapper wrapper--padding"">
                                    <div class=""landing-grid landing-grid--05 grid grid--equal-height grid--max-h4 grid--padding-wide"" id");
            WriteLiteral(@"=""caseContent"">
                                        <div class=""brick brick--ug---applying-to-university grid__item brick--default"">

                                            <div class=""brick__wrapper clearfix contextual-links-region brick__wrapper--has-background"">
                                                <div class=""brick__image background-image--loaded"" style=""background-image: url(&quot;/assets/images/unibuddy_0.jpg?itok=-L7vOOEi&quot;);""></div>

                                                <h2 class=""brick__title""><a>Applying to university</a></h2>

                                                <div class=""brick__content"">
                                                    <div class=""bean__body prose"">
                                                        When and how to apply for an undergraduate course
                                                    </div>
                                                </div>

                                                <d");
            WriteLiteral(@"iv class=""brick__footer"">
                                                    <a>Explore <strong>more ›</strong></a>
                                                </div>
                                            </div>

                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </article>
            </div>
        </div>
    </div>
</div>
");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(2661, 1604, true);
                WriteLiteral(@"
    <script type=""text/html"" id=""caseTeplate"">
        {{each data item index}}
        <div class=""brick brick--ug---applying-to-university grid__item brick--default"">
            <div class=""brick__wrapper clearfix contextual-links-region brick__wrapper--has-background"">

                <div class=""brick__image background-image--loaded"" style=""background-image: url(&quot;{{item.ImgUrl}}?itok=-L7vOOEi&quot;);""></div>

                <h2 class=""brick__title""><a href=""/Home/Detail?id={{item.Id}}&type=yashi"">{{item.Title}}</a></h2>

                <div class=""brick__content"">
                    <div class=""bean__body prose"">
                        {{item.Subtitle}}
                    </div>
                </div>

                <div class=""brick__footer"">
                    <a>Explore <strong>more ›</strong></a>
                </div>
            </div>
        </div>
        {{/each}}
    </script>
    <script type=""text/javascript"">
        $(function () {
            $(""#mu");
                WriteLiteral(@"enUl"").find(""li"").find(""a"").removeClass(""activeA"");
            $(""#muenUl"").find(""li"").find(""a[data-class='yashi']"").addClass(""activeA"");
         })
        //绑定案例列表
        ajaxRequst(""post"", ""Home/BindYase"", { page:1,pagesize: 50 }, function (data) {
            if (data != null && data.code != undefined && data.code != null && data.data != null) {
                var html = """";
                html = template(""caseTeplate"", { data: data.data });
                document.getElementById(""caseContent"").innerHTML = html;
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
