using LoanNet.IServices;
using LoanNet.Models;
using LoanNet.Services;
using LoanNet.Services.UsuarioService;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanNet
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
            services.AddControllers();
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<IEmpresaService, EmpresaService>();
            services.AddScoped<IEmpleadoService, EmpleadoService>();
            services.AddScoped<IDocumentoService, DocumentoService>();
            services.AddScoped<IListaNegraService, ListaNegraService>();
            services.AddScoped<ITipoPrestamoService, TipoPrestamoService>();
            services.AddScoped<IRecomendadoService, RecomendadoService>();
            services.AddScoped<IPrestamoService, PrestamoService>();
            services.AddScoped<IPagoService, PagoService>();
            var connection = Configuration.GetConnectionString("OracleConnection");
            services.AddDbContextPool<MyDbContext>(options => options.UseOracle(connection));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
