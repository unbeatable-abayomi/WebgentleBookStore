using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using WebgentleBookStore.Data;
using WebgentleBookStore.Repository;

namespace WebgentleBookStore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<BookStoreContext>(options => options.UseSqlServer("Server=.;Database=BookStore;Integrated Security=True;"));
            services.AddControllersWithViews();

            services.AddScoped<BookRepository, BookRepository>();
            services.AddScoped<CarRespositroy, CarRespositroy>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.Use(async( context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello from my first middleware");
            //    await next();
            //    await context.Response.WriteAsync("Hello from my first middleware: response again");
            //});

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello from my second middleware");
            //    await next();
            //    await context.Response.WriteAsync("Hello from my second middleware: response again");
            //});
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello from my third middleware");
            //    await next();

            //});
            app.UseStaticFiles();
            //app.UseStaticFiles(new StaticFileOptions()
            //{
            //    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(),"MyStaticFiles")),
            //    RequestPath = "/MyStaticFiles"
            //});
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
                //endpoints.MapControllerRoute(
                //    name: "default",
                //    pattern: "bookapp/{controller=Home}/{action=Index}/{id?}");
                //("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World!");
                //});
            });
           // app.UseRouting();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.Map("/yomi", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World! yomi deve");
            //    });
            //});
        }
    }
}
