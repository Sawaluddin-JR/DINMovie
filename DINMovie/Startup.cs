using DINMovie.Data;
using Microsoft.EntityFrameworkCore;

namespace DINMovie
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime.Use this method  to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //DbContext configuration
            services.AddDbContext<AppDbContext>(o =>
            {
                o.UseMySQL(Configuration.GetConnectionString("mysql"));
            });

            services.AddAuthentication("CookieAuth")
                .AddCookie("CookieAuth", options =>
                {
                    options.LoginPath = "/Akun/SignIn";
                    options.AccessDeniedPath = "/Akun/SignIn";
                });

            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");

                app.UseHsts();
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            /*  app.UseEndpoints(endpoints =>
              {
                  endpoints.MapAreaControllerRoute(
                      name: "AreaAdmin",
                      areaName: "Admin",
                      pattern: "Admin/{controller=Home}/{action=Index}/{id?}"
                      );
                  endpoints.MapAreaControllerRoute(
                      name: "AreaUser",
                      areaName: "User",
                      pattern: "User/{controller=Home}/{action=Index}/{id?}"
                      );
                  endpoints.MapControllerRoute(
                      name: "default",
                      pattern: "{controller=Home}/{action=Index}/{id?}");
              });*/
        }
    }
}
