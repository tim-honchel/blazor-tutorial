using Microsoft.EntityFrameworkCore;
using MyBlog.Data;
using MyBlog.Data.Interfaces;
using MyBlog.Data.Models;
using Microsoft.AspNetCore.Authentication;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Identity;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.ResponseCompression;
using MyBlogWebAssembly.Server.Hubs;

namespace MyBlogWebAssembly.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddSignalR().AddJsonProtocol(options => {options.PayloadSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve; options.PayloadSerializerOptions.PropertyNamingPolicy =null;});
            services.AddDbContextFactory<MyBlogDbContext>(opt => opt.UseSqlite(Configuration.GetConnectionString("MyBlogDB")));
            services.AddScoped<IMyBlogApi, MyBlogApiServerSide>();

            services.AddControllersWithViews().AddJsonOptions(options => 
            {
                options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve;
                options.JsonSerializerOptions.PropertyNamingPolicy = null; 
            });
            services.AddRazorPages();
            services.AddDbContext<MyBlogDbContext>(opt => opt.UseSqlite(Configuration.GetConnectionString("MyBlogDB")));
            services.AddDefaultIdentity<AppUser>(options => options.SignIn.RequireConfirmedAccount = false).AddRoles<IdentityRole>().AddEntityFrameworkStores<MyBlogDbContext>();
            services.AddIdentityServer().AddApiAuthorization<AppUser, MyBlogDbContext>(options =>
            {
                options.IdentityResources["openid"].UserClaims.Add("name");
                options.ApiResources.Single().UserClaims.Add("name");
                options.IdentityResources["openid"].UserClaims.Add("role"); options.ApiResources.Single().UserClaims.Add("role");
            });
            JwtSecurityTokenHandler.DefaultInboundClaimFilter.Remove("role");
            services.AddAuthentication().AddIdentityServerJwt();
            services.AddResponseCompression(opts => {opts.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(new[] { "application/octet-stream" });});
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseIdentityServer();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapHub<BlogNotificationHub>("/BlogNotificationHub");
                endpoints.MapFallbackToFile("index.html");
            });
        }
    }
}