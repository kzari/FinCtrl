using Kzari.Finctrl.Domain.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Kzari.Finctrl.Domain.Services;
using Kzari.Finctrl.Domain.Services.Interfaces;
using Kzari.FinCtrl.Domain.Interfaces;
using Kzari.FinCtrl.Infra.Data.Repository;
using Kzari.FinCtrl.Infra.Data;

namespace Kzari.FinCtrl.Web
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
            services.AddMvc();

            //Serviços
            services.AddTransient<ICategoriaService, CategoriaService>();
            services.AddTransient<IRegistroService, RegistroService>();

            //Repositórios
            services.AddTransient<ICategoriaRepository, CategoriaRepository>();
            services.AddTransient<IRegistroRepository, RegistroRepository>();

            services.AddScoped<FinCtrlContext>();
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

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            app.UseRequestLocalization("pt-br");
        }
    }
}
