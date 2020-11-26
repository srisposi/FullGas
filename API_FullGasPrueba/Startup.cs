using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FullGas.Core.Interfaces;
using FullGas.Core.Interfaces.Services;
using FullGas.Core.Services;
using FullGas.Infraestructure.Data;
using FullGas.Infraestructure.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;


namespace API_FullGasPrueba
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
            //JavaScript
            services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin());
            });

            services.AddControllers();

            //Dependencies
            services.AddTransient<IEstacionRepository, EstacionRepository>();
            services.AddTransient<IOperacionesRepository, OperacionesRepository>();
            services.AddTransient<ITanqueRepository, TanqueRepository>();
            services.AddTransient<IEstacionServices, EstacionService>();
            //Context de DataBase
            services.AddDbContext<FullGasContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("FullGas")));
            //SwaggerGen
            services.AddSwaggerGen(doc =>
            {
                doc.SwaggerDoc("v1", new OpenApiInfo { Title = "FullGas", Version = "v1" });
            });


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //JavaScript
            app.UseCors(options => options.AllowAnyOrigin());
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

            //Swagger
            app.UseSwagger();

            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "Full GAS API");
                options.RoutePrefix = string.Empty;
            });



        }
    }
}
