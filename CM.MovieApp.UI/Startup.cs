using AutoMapper;
using CG.MovieApp.Business.Concrete;
using CG.MovieApp.Business.Interfaces;
using CG.MovieApp.DataAccess.Concrate.EntityFrameworkCore.Context;
using CG.MovieApp.DataAccess.Concrate.EntityFrameworkCore.Repository;
using CG.MovieApp.DataAccess.Interfaces.Dal;
using CM.MovieApp.UI.Mapping.AutoMapping;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CM.MovieApp.UI
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
            services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));
            services.AddScoped(typeof(IGenericDal<>), typeof(EfGenericRepository<>));

            services.AddScoped<IFilmService, FilmService>();
            services.AddScoped<IFilmDal, FilmRepository>();

            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICategoryDal, CategoryRepository>();

            services.AddScoped<IActorService, ActorService>();
            services.AddScoped<IActorDal, ActorRepository>();

            services.AddScoped<IDirectorService, DirectorService>();
            services.AddScoped<IDirectorDal, DirectorRepository>();

            services.AddAutoMapper(typeof(Startup));

            

            services.AddControllersWithViews();


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
                    endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
