using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CoreMvcNTier.Business.Abstract;
using CoreMvcNTier.Business.Concrete;
using CoreMvcNTier.DataAccess.Abstract;
using CoreMvcNTier.DataAccess.Concrete;
using CoreMvcNTier.DataAccess.Concrete.EntityFrameWork;
using CoreMvcNTier.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;

namespace CoreMvcNTier
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddDbContext<NTierContext>(
                options => options.UseSqlServer(Configuration["database:connection"])
                );


            services.AddSession(options =>
            {
                // Set a short timeout for easy testing.
                options.IdleTimeout = TimeSpan.FromSeconds(600);
                options.Cookie.HttpOnly = true;
            });
            services.AddScoped<IProductDal, EFProductDal>();
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<ICategoryDal, EFCategoryDal>();
            services.AddScoped<ISubCategoryDal, EFSubCategoryDal>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ISubCategoryService,SubCategoryManager>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
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
            }

            
            app.UseTheme(env.ContentRootPath);
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseSession();
            app.UseMvc(configureRoutes);
            
        }

        private void configureRoutes(IRouteBuilder routes)
        {
            routes.MapRoute(
              name: "altkategori",
              template: "{controller=Home}/{action=Index}/{kategori}/{id?}",
              defaults: "{controller=Home}/{action=Index}/{id?}");

            routes.MapRoute(
            name: "urunler",
            template: "{controller=Product}/{action=Detail}/{proname}/{id?}",
            defaults: "{controller=Product}/{action=Detail}/{id?}");

            routes.MapRoute(
                name: "default",
                template: "{controller=Home}/{action=Index}/{id?}");
        }
    }
}
