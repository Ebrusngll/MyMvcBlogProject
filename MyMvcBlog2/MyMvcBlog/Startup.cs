using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyMvcBlog.Models;

namespace MyMvcBlog
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddDbContext<MvcContext>(options => options.UseSqlServer(Configuration.GetConnectionString("MvcConnection")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {

                //endpoints.MapControllerRoute(
                //    name: "areaDefault",
                //    pattern: "{area:exist}/{controller=Home}/{action=Index}/{id?}"     // arealrým için Default bir map oluþturudm.
                //    );

                // exist: Route 'un bir Area ile eþleþmesi için kýsýtlama uygular.

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=HomePageViewModel}/{action=Index}/{id?}");
            });
        }

       
    }
}
