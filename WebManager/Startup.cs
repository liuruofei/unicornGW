using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Threading.Tasks;
using ADT.Models;
using AutofacModule;
using log4net;
using log4net.Config;
using log4net.Repository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Senparc.CO2NET;
using Senparc.CO2NET.Cache;
using Senparc.CO2NET.RegisterServices;
using Senparc.Weixin;
using Senparc.Weixin.Entities;
using Senparc.Weixin.RegisterServices;
using Senparc.Weixin.WxOpen;
using UEditor.Core;

namespace WebManager
{
    public class Startup
    {
        private ILog log = null;
        public static ILoggerRepository repository { get; set; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            //log4net仓储名
            repository = LogManager.CreateRepository("NETCoreRepository");
            // 指定配置文件
            XmlConfigurator.Configure(repository, new FileInfo("log4net.config"));
            log = LogManager.GetLogger(Startup.repository.Name, typeof(Startup));
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => false;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            //启用MemoryCache缓存
            services.AddMemoryCache();
            //自定义 视图 
            services.Configure<Microsoft.AspNetCore.Mvc.Razor.RazorViewEngineOptions>(item =>
            {
                item.AreaViewLocationFormats.Add("/Areas/{2}/Views/{1}/{0}.cshtml");
                item.AreaViewLocationFormats.Add("/Areas/{2}/Views/Shared/{0}.cshtml");
                item.AreaViewLocationFormats.Add("/Areas/{2}/Views/Sys/{1}/{0}.cshtml");//系统管理
                item.AreaViewLocationFormats.Add("/Areas/{2}/Views/Manage/{1}/{0}.cshtml");//系统管理
                item.ViewLocationFormats.Add("/Views/Sys/{1}/{0}.cshtml");//系统管理
            });

            //将appsettings.json中的JwtSettings部分文件读取到JwtSettings中，这是给其他地方用的
            services.Configure<JwtSettings>(Configuration.GetSection("JwtSettings"));
            //由于初始化的时候我们就需要用，所以使用Bind的方式读取配置
            //将配置绑定到JwtSettings实例中
            var jwtSettings = new JwtSettings();
            Configuration.Bind("JwtSettings", jwtSettings);
            //
            //Areas.Admin.Filter.RegisterRoleMenu.AddRoleMenu();
            services.AddAuthentication(options =>
            {
                //认证middleware配置
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(o =>
            {
                //主要是jwt  token参数设置
                o.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
                {
                    //Token颁发机构
                    ValidIssuer = jwtSettings.Issuer,
                    //颁发给谁
                    ValidAudience = jwtSettings.Audience,
                    //这里的key要进行加密，需要引用Microsoft.IdentityModel.Tokens
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.SecretKey)),
                    ValidateAudience = true,
                    ValidateIssuerSigningKey = true,
                    //是否验证Token有效期，使用当前时间与Token的Claims中的NotBefore和Expires对比
                    ValidateLifetime = true,
                    //允许的服务器时间偏移量
                    ClockSkew = TimeSpan.Zero

                };
                o.Events = new JwtBearerEvents()
                {
                    OnMessageReceived = context =>
                    {
                        var token = Convert.ToString(context.Request.Headers["token"]);
                        var cookieToken = Convert.ToString(context.Request.Cookies["authtoken"]);
                        if (!string.IsNullOrEmpty(cookieToken))
                            token = cookieToken;
                        context.Token = token;
                        //token.FirstOrDefault();
                        return Task.CompletedTask;
                    }
                };
            });

            //设置跨域
            services.AddCors(options =>
            {
                options.AddPolicy("any", builder =>
                {
                    builder.AllowAnyOrigin() //允许任何来源的主机访问
                    //builder.WithOrigins("http://localhost:8080") ////允许http://localhost:8080的主机访问
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials();//指定处理cookie
                });
            });

            //解决中文被编码
            services.AddSingleton(HtmlEncoder.Create(UnicodeRanges.All));

            services.AddMvc()
                .AddJsonOptions(options =>
                {
                    //忽略循环引用
                    options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                    //不使用驼峰样式的key
                    options.SerializerSettings.ContractResolver = new DefaultContractResolver();
                    //设置时间格式
                    options.SerializerSettings.DateFormatString = "yyyy-MM-dd HH:mm:ss";
                }).SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            string uploadPath = Directory.GetCurrentDirectory() + "\\" + ADT.Common.ConfigHelper.GetConfig("FilePath");
            if (!Directory.Exists(uploadPath))
                Directory.CreateDirectory(uploadPath);
            //解决Multipart body length limit 134217728 exceeded
            services.Configure<FormOptions>(x =>
            {
                x.ValueLengthLimit = int.MaxValue;
                x.MultipartBodyLengthLimit = int.MaxValue; // In case of multipart
            });
            ;
            //使用AutoFac注入
            return new RegisterFac().RegisterAutofac(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env,
                IOptions<SenparcSetting> senparcSetting, IOptions<SenparcWeixinSetting> senparcWeixinSetting)
        {
            if (env.IsDevelopment())
            {
                app.UseExceptionHandler("/Admin/Error/Ajax");
                //app.UseDeveloperExceptionPage();
                app.UseHsts();
            }
            else
            {
                app.UseExceptionHandler("/Admin/Error/Ajax");
                app.UseHsts();
                //app.UseExceptionHandler("/Home/Error");
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            string uploadPath = Directory.GetCurrentDirectory() + "\\" + ADT.Common.ConfigHelper.GetConfig("FilePath");
            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(uploadPath),
                RequestPath = new PathString("/upload")
            });
            app.UseAuthentication();
            app.UseCookiePolicy();
            app.UseCors("any");
            //使用跨域再控制器头部添加EnableCors("any")

            //判断返回值状态一次的情况下处理业务。
            app.UseStatusCodePages(async context =>
            {
                var request = context.HttpContext.Request;
                var response = context.HttpContext.Response;

                if (response.StatusCode == (int)HttpStatusCode.Unauthorized && !request.Path.Value.Contains("/api/"))
                {
                    response.ContentType = "text/html; charset=utf-8";
                    await response.WriteAsync("<script>alert('登陆超时，请重新登陆');window.top.location.href='/admin/Login';</script>");
                    //response.Redirect("/admin/login");
                }
            });

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "areas",
                    template: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

        }


    }
}
