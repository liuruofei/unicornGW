#pragma checksum "D:\younengkao\manage\WebManager\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "015398690f96242d4ba5ac4bb954f6d88140c8d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"015398690f96242d4ba5ac4bb954f6d88140c8d8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a472608030038dae4e094cd50cb4aba226576597", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("video/mp4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/homepage-leader.mp4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/gongzhonghao.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("position: relative; top: 4px;width: 166px;height: 143px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/lianxiwomen.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\younengkao\manage\WebManager\Views\Home\Index.cshtml"
  
    Layout = "/Views/Shared/_Templete.cshtml";

#line default
#line hidden
            BeginContext(57, 2038, true);
            WriteLiteral(@"<style>

    .regionUl {
    }

        .regionUl li {
            margin-top: 9px;
        }

            .regionUl li input {
                width: 100%;
                margin-bottom: .15rem;
                height: 39px !important;
                line-height: .5rem;
                border-radius: 3px;
                border: 0px;
            }

    .button-btn {
        border: none;
        font-family: inherit;
        font-size: inherit;
        color: inherit;
        background: none;
        cursor: pointer;
        padding: 8px 0;
        display: inline-block;
        text-transform: uppercase;
        letter-spacing: 1px;
        font-weight: 700;
        outline: none;
        position: relative;
        -webkit-transition: all 0.3s;
        -moz-transition: all 0.3s;
        transition: all 0.3s;
        width: 100%;
        border-radius: 5px;
    }

        .button-btn:after {
            content: '';
            position: absolute;
            z-in");
            WriteLiteral(@"dex: -1;
            -webkit-transition: all 0.3s;
            -moz-transition: all 0.3s;
            transition: all 0.3s;
        }

    .btn-2 {
        background-image: -webkit-linear-gradient(top, rgb(0, 166, 162), rgb(1, 91, 89));
        color: #fff;
        box-shadow: 0 5px #013938;
        -webkit-transition: none;
        -moz-transition: none;
        transition: none;
    }
</style>
<section class=""section section--lower-header section--lower-header-has-background section--lower-header-large section--lower-header-has-search"" id=""section-lower-header"">
    <div class=""wrapper-background wrapper-background--header-with-background wrapper-background--no-contain background-image--loaded""
         style=""margin-top: -130px; padding-top: 130px; background-position-y: 0px;"">
        <div class=""section__video-background"">
            <video autoplay="""" muted="""" loop="""" playsinline="""" id=""landing-video"" data-lazy-video=""~/assets/images/homepage-leader.mp4"">
                ");
            EndContext();
            BeginContext(2095, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("source", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "015398690f96242d4ba5ac4bb954f6d88140c8d87327", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2162, 3648, true);
            WriteLiteral(@"
            </video>
        </div>

        <header class=""header header--with-background header--reduced"">
            <div class=""header__inner-wrapper wrapper wrapper--padding"">
                <h1 class=""header__heading"">Choose your future</h1>
                <div class=""section-lower-header__search"">
                    <h1 class=""header__heading"" style=""color:#fff"">Unicorn</h1> 
                </div>
            </div>
        </header>
    </div>
</section>

<div id=""section--content"" class=""section section--content wrapper-background wrapper-background--angle "">
    <div class=""section__inner-wrapper section__inner "">
        <div class=""section__content"">
            <div class=""region region__content brick--main"">
                <article class=""node node-landing-page article article--landing-page article--view-full article-type--landing_page prose clearfix"">
                    <div class=""wrapper wrapper--padding"" style=""flex-wrap:wrap;"">
                        <div class");
            WriteLiteral(@"=""landing-grid--single landing-grid landing-grid--01"" style=""display:flex"">
                            <div class=""brick brick--home---get-updates-from-ucas grid__item brick--default"" id=""bannerContent"">

                                <div class=""brick__wrapper clearfix contextual-links-region brick__wrapper--has-background"" style=""min-height: 182px;"">
                                    <div class=""brick__image background-image--loaded"" style=""background-image: url('');""></div>

                                    <h2 class=""brick__title""><a>Sign up for the UCAS newsletter</a></h2>

                                    <div class=""brick__content"">
                                        <div class=""bean__body prose"">
                                            <p>Get the latest updates,&nbsp;tips, and guidance to support you with your next steps, straight to your inbox.</p>
                                        </div>
                                    </div>

                             ");
            WriteLiteral(@"       <div class=""brick__footer"">
                                        <a>Explore <strong>more ›</strong></a>
                                    </div>
                                </div>

                            </div>
                            <div class=""brick brick--ad brick--heavy prose brick--fourth-width brick--advertisement"">
                                <div class=""brick__wrapper clearfix"">
                                    <div style=""width: 300px; height: 250px;background-color:rgba(255,255,255,.5);opacity:0.8;border-radius:5px;text-align:center;padding:8px 16px 0 16px;"" class=""region1"">
                                        <h3>领取资料</h3>
                                        <ul class=""regionUl"">
                                            <li><input name=""UserName"" placeholder=""您的姓名"" style="" text-indent:0.7em;"" /></li>
                                            <li><input name=""Mobile"" placeholder=""手机号码"" type=""number"" maxlength=""11"" /></li>
                   ");
            WriteLiteral(@"                         <li><select id=""selectMateria"" name=""Materia""></select></li>
                                            <li><button class=""button-btn btn-2"" onclick=""regionMateria(this)"">马上领取</button> </li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                            <div class=""brick brick--ad brick--heavy prose brick--fourth-width brick--advertisement"">
                                <div class=""brick__wrapper clearfix"">
");
            EndContext();
            BeginContext(6384, 317, true);
            WriteLiteral(@"                                    <div style=""width: 300px; height: 250px;background-color:rgba(255,255,255,.5);opacity:0.8;border-radius:5px;padding:41px 9px 0 9px;display:flex"" class=""region1"">
                                        <div style=""text-align:center;"">
                                            ");
            EndContext();
            BeginContext(6701, 111, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "015398690f96242d4ba5ac4bb954f6d88140c8d812843", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
            BeginContext(6812, 254, true);
            WriteLiteral("\r\n                                            <div style=\"font-weight:600\">微信公众号</div>\r\n                                        </div>\r\n                                        <div style=\"text-align:center;\">\r\n                                            ");
            EndContext();
            BeginContext(7066, 110, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "015398690f96242d4ba5ac4bb954f6d88140c8d814362", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7176, 6022, true);
            WriteLiteral(@"
                                            <div style=""font-weight:600"">联系微信</div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class=""article__paragraphs"">
                        <div class=""entity entity-paragraphs-item paragraphs-item-content-blocks entity-paragraphs-item--full"">
                            <div class=""content"">

                                <div class=""wrapper wrapper--padding"">
                                    <div class=""landing-grid landing-grid--03 grid grid--equal-height grid--max-h3 grid--padding-extra-wide"" id=""courseContent"">
                                        <div class=""brick brick--home---explore-your-options grid__item brick--default"">

                                            <div class=""brick__wrapper clearfix contextual-links-region brick__w");
            WriteLiteral(@"rapper--has-background"">

                                                <div class=""brick__image background-image--loaded"" style=""background-image: url('');""></div>

                                                <h2 class=""brick__title""><a>Explore your options</a></h2>

                                                <div class=""brick__content"">
                                                    <div class=""bean__body prose"">
                                                        <span>The personalised space to help you make the next step</span>
                                                    </div>
                                                </div>

                                                <div class=""brick__footer"">
                                                    <a>Explore <strong>more ›</strong></a>
                                                </div>
                                            </div>

                                        </div>
            ");
            WriteLiteral(@"                        </div>
                                </div>
                            </div>
                        </div>



                        <div class=""entity entity-paragraphs-item paragraphs-item-content-blocks entity-paragraphs-item--full"">
                            <div class=""content"">

                                <div class=""wrapper wrapper--padding"">
                                    <div class=""landing-grid landing-grid--05 grid grid--equal-height grid--max-h4 grid--padding-wide"" id=""caseContent"">
                                        <div class=""brick brick--ug---applying-to-university grid__item brick--default"">

                                            <div class=""brick__wrapper clearfix contextual-links-region brick__wrapper--has-background"">

                                                <div class=""brick__image background-image--loaded"" style=""background-image: url('');""></div>

                                                <h2 class=""bri");
            WriteLiteral(@"ck__title""><a>Applying to university</a></h2>

                                                <div class=""brick__content"">
                                                    <div class=""bean__body prose"">
                                                        When and how to apply for an undergraduate course
                                                    </div>
                                                </div>

                                                <div class=""brick__footer"">
                                                    <a>Explore <strong>more ›</strong></a>
                                                </div>
                                            </div>

                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>



                        <div class=""entity entity-paragraphs-item paragraphs-item-content-blocks entity");
            WriteLiteral(@"-paragraphs-item--full"">
                            <div class=""content"">
                                <div class=""wrapper wrapper--padding""><h2 class=""heading--emphasis""><a class=""paragraphs-item__label-anchor""></a><span>热门</span>动态</h2></div>
                                <div class=""wrapper wrapper--padding"">
                                    <div class=""landing-grid landing-grid--05 grid grid--equal-height grid--max-h4 grid--padding-extra-wide"" id=""newsContent"">
                                        <div class=""brick brick--book-your-ucas-discovery-day grid__item brick--teaser"">

                                            <div class=""brick__wrapper clearfix contextual-links-region brick__wrapper--has-background"">

                                                <div class=""brick__image background-image--loaded"" style=""background-image: url('');""></div>
                                                <h2 class=""brick__title"">Book your UCAS/Discovery Day</h2>
                          ");
            WriteLiteral(@"                      <div class=""brick__content"">
                                                    <div class=""bean__body prose"">
                                                        <p>Get ready to explore a world of possibilities and see where your journey could head next…</p>
                                                    </div>
                                                    <a class=""brick__secondary-link"">Read more</a>
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
<div class=""boxMsg""></div>
");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(13215, 7315, true);
                WriteLiteral(@"
    <script type=""text/html"" id=""bannerTemplete"">
        {{each data item index}}
        <div class=""brick__wrapper clearfix contextual-links-region brick__wrapper--has-background"" style=""min-height: 182px;"">
            <div class=""brick__image background-image--loaded"" style=""background-image: url(&quot;{{item.BannerImage}}?itok=poB52cGn&quot;);""></div>
            <h2 class=""brick__title""><a href=""/Home/Detail?id={{item.Id}}&type=first"">{{item.Title}}</a></h2>
            <div class=""brick__content"">
                <div class=""bean__body prose"">
                    <a href=""/Home/Detail?id={{item.Id}}&type=first""><p style=""color:white;"">{{item.Subtitle}}</p></a>
                </div>
            </div>
            <div class=""brick__footer"">
                <a>Explore <strong>more ›</strong></a>
            </div>
        </div>
        {{/each}}
    </script>
    <script type=""text/html"" id=""courseTeplate"">
        {{each data item index}}
        <div class=""brick brick--home---ex");
                WriteLiteral(@"plore-your-options grid__item brick--default"">

            <div class=""brick__wrapper clearfix contextual-links-region brick__wrapper--has-background"">

                <div class=""brick__image background-image--loaded"" style=""background-image: url(&quot;{{item.ImgUrl}}?itok=nVeGbiDX&quot;);""></div>

                <h2 class=""brick__title""><a href=""/Home/Detail?id={{item.Id}}&type=course"">{{item.CourseName}}</a></h2>

                <div class=""brick__content"">
                    <div class=""bean__body prose"">
                        <span>{{item.CourseTitle}}</span>
                    </div>
                </div>

                <div class=""brick__footer"">
                    <a>Explore <strong>more ›</strong></a>
                </div>
            </div>

        </div>
        {{/each}}
    </script>
    <script type=""text/html"" id=""caseTeplate"">
        {{each data item index}}
        <div class=""brick brick--ug---applying-to-university grid__item brick--default"">
        ");
                WriteLiteral(@"    <div class=""brick__wrapper clearfix contextual-links-region brick__wrapper--has-background"">

                <div class=""brick__image background-image--loaded"" style=""background-image: url(&quot;{{item.ImgUrl}}?itok=-L7vOOEi&quot;);""></div>

                <h2 class=""brick__title""><a href=""/Home/Detail?id={{item.Id}}&type=case"">{{item.Title}}</a></h2>

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
    <script type=""text/html"" id=""newsTeplate"">
        {{each data item index}}
        <div class=""brick brick--book-your-ucas-discovery-day grid__item brick--teaser"">
            <div class=""brick__wrapper clearfix contextual-links-region brick__wrapper--has");
                WriteLiteral(@"-background"">
                <div class=""brick__image background-image--loaded"" style=""background-image: url(&quot;{{item.ImgUrl}}?itok=FsDLF6IW&quot;);""></div>
                <a href=""/Home/Detail?id={{item.Id}}&type=news""><h2 class=""brick__title""  style=""color:#1077d0 !important"">{{item.Title}}</h2></a>
                <div class=""brick__content"">
                    <div class=""bean__body prose"">
                        <a href=""/Home/Detail?id={{item.Id}}&type=news""><p style=""color:#1077d0 !important"">{{item.Subtitle}}</p></a>
                    </div>
                    <a class=""brick__secondary-link"">Read more</a>
                </div>
            </div>
        </div>
        {{/each}}
    </script>
    <script type=""text/javascript"">
        $(""#muenUl"").find(""li"").find(""a"").removeClass(""activeA"");
        $(""#muenUl"").find(""li"").find(""a[data-class='frist']"").addClass(""activeA"");
        //绑定资料
        ajaxRequst(""post"", ""Home/BindMateria"", {}, function (data) {
            if ");
                WriteLiteral(@"(data != null && data.code != undefined && data.code != null && data.data != null) {
                $.each(data.data, function (i, item) {
                    $(""#selectMateria"").append(""<option value='"" + item.MaterialId + ""'>"" + item.MateriaName + ""</option>"");
                })
            }
        });
        //绑定banner图
        ajaxRequst(""post"", ""Home/BindBanner"", {}, function (data) {
            if (data != null && data.code != undefined && data.code != null && data.data != null) {
                var html = """";
                html = template(""bannerTemplete"", { data: data.data });
                document.getElementById(""bannerContent"").innerHTML = html;
            }
        });
        //绑定课程列表
        ajaxRequst(""post"", ""Home/BindCourse"", {page:1,pagesize:4}, function (data) {
            if (data != null && data.code != undefined && data.code != null && data.data != null) {
                var html = """";
                html = template(""courseTeplate"", { data: data.data });");
                WriteLiteral(@"
                document.getElementById(""courseContent"").innerHTML = html;
            }
        });
        //绑定案例列表
        ajaxRequst(""post"",""Home/BindCase"", { page:1, pagesize: 4 }, function (data) {
            if (data != null && data.code != undefined && data.code != null && data.data != null) {
                var html = """";
                html = template(""caseTeplate"", { data: data.data });
                document.getElementById(""caseContent"").innerHTML = html;
            }
        });
        //绑定新闻列表
        ajaxRequst(""post"", ""Home/BindNews"", {page:1,pagesize:4 }, function (data) {
            if (data != null && data.code != undefined && data.code != null && data.data != null) {
                console.log(data);
                var html = """";
                html = template(""newsTeplate"", { data: data.data });
                document.getElementById(""newsContent"").innerHTML = html;
            }
        });
       //领取资料
        function regionMateria() {
            va");
                WriteLiteral(@"r mobile = $(""input[name='Mobile']"").val();
            var reg = /^(13|14|15|16|17|18|19)[0-9]{9}$/;
            var valite = reg.test(mobile);
            if (mobile=="""") {
                boxMsg(""请填写手机号码！"", 2);
                return false;
            }
            if (!valite) {
                boxMsg(""手机格式错误！"", 2);
                return false;
            }
            var prm = { UserName: $(""input[name='UserName']"").val(), Mobile:mobile, MaterialId: $(""#selectMateria"").val() };
            ajaxRequst(""post"", ""Home/Region"", prm, function (data) {
                if (data != null && data.code != undefined && data.code != null) {
                    boxMsg(data.msg,1);
                }
            });
        }
        function boxMsg(msg, status) {
            if (status == 1) {
                $("".boxMsg"").css(""color"", ""green"");
            }
            else {
                $("".boxMsg"").css(""color"", ""black"");
            }
            $("".boxMsg"").show();
            $("".");
                WriteLiteral("boxMsg\").text(msg);\r\n            setTimeout(function () {\r\n                $(\".boxMsg\").hide();\r\n            }, 1000)\r\n        }\r\n\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(20533, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
