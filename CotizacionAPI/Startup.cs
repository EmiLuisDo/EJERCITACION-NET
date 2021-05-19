using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

using CotizacionAPI.Services.Logging;
using CotizacionAPI.Services.Requests;
using CotizacionAPI.Services.ServiceImpl;

namespace CotizacionAPI
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
            services.AddTransient< ILogger, Logger>();
            services.AddTransient< ICotizacionesDisponiblesRequestService, FakeCotizacionesDisponiblesRequestService>();
            services.AddTransient< ICotizacionDisponibleToResponse, CotizacionDisponibleToResponse>();
            services.AddSingleton< ICotizacionRequestService, CotizacionRequestService>();
            services.AddTransient< IResponseToCotizacion, ResponseToCotizacion>();
            services.AddHttpClient();



            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CotizacionAPI", Version = "v1" });
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CotizacionAPI v1"));
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
