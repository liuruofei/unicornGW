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
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace AppApi
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
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            //jwt配置读取
            services.Configure<JwtSettings>(Configuration.GetSection("JwtSettings"));
            var jwtSettings = new JwtSettings();
            Configuration.Bind("JwtSettings", jwtSettings);


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
                    .AllowAnyMethod()
                    .AllowAnyHeader();
                });
            });

            //解决中文被编码
            services.AddSingleton(HtmlEncoder.Create(UnicodeRanges.All));

            //上传图片
            string uploadPath = Directory.GetCurrentDirectory() + "\\" + ADT.Common.ConfigHelper.GetConfig("FilePath");
            if (!Directory.Exists(uploadPath))
                Directory.CreateDirectory(uploadPath);
            //限制文件上传字节大小
            services.Configure<FormOptions>(x =>
            {
                x.ValueLengthLimit = int.MaxValue;
                x.MultipartBodyLengthLimit = int.MaxValue; // In case of multipart
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);



            //使用AutoFac注入
            return new RegisterFac().RegisterAutofac(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();


            string uploadPath = Directory.GetCurrentDirectory() + "\\" + ADT.Common.ConfigHelper.GetConfig("FilePath");
            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(uploadPath),
                RequestPath = new PathString("/upload")
            });
            app.UseAuthentication();
            app.UseCookiePolicy();
            app.UseCors("any");

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
