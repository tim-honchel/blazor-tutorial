using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyBlog.Data;
using MyBlog.Data.Interfaces;
using MyBlog.Data.Models;
//<authusing>
using MyBlogServerSide.Authentication;
//</authusing>
//<IdentityServerUsing>
using Microsoft.Extensions.Options;
//</IdentityServerUsing>
using MyBlog.Shared.Interfaces;
using MyBlogServerSide.Services;

namespace MyBlogServerSide
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        //</Startup>

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            //<AddMyBlogDataServices>
            services.AddDbContextFactory<MyBlogDbContext>(opt => opt.UseSqlite(Configuration.GetConnectionString("MyBlogDB")));
            services.AddScoped<IMyBlogApi, MyBlogApiServerSide>();
            //</AddMyBlogDataServices>
            services.AddDbContext<MyBlogDbContext>(opt => opt.UseSqlite(Configuration.GetConnectionString("MyBlogDB")));
            services.AddDefaultIdentity<AppUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<MyBlogDbContext>();
            services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<AppUser>>();
            services.AddScoped < IBrowserStorage,MyBlogProtectedBrowserStorage > ();
            services.AddSingleton<IBlogNotificationService,BlazorServerBlogNotificationService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.

        //<ConfigureMigrate>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IDbContextFactory<MyBlogDbContext> factory)
        {
            factory.CreateDbContext().Database.Migrate();
            //</ConfigureMigrate>
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
