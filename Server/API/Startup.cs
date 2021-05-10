
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;

namespace API
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

           
            //Unique dans toute mon application (m�me instance dans toute l'aplication)

            ////A chaque fois qu'on demande un Ilibrairi service => nouvelle instance
            //services.AddTransient<ILibrairiService, LibrairiService>();

            //// La m�me instance tout au long de la requ�te
            //services.AddScoped<ILibrairiService, LibrairiService>();


            //Changer le mode d'exploration d api avec la version dans l'url
            services.AddApiVersioning(config =>
            {
                config.ReportApiVersions = true;
                config.DefaultApiVersion = new ApiVersion(1, 0);
                //config.AssumeDefaultVersionWhenUnspecified = true;
            });

            //Documentation Client API
            services.AddVersionedApiExplorer(option =>
            {
                option.SubstituteApiVersionInUrl= true;

            });
            // Register the Swagger services
            services.AddOpenApiDocument(config =>
            {
                config.DocumentName = "v1.0";
                config.PostProcess = document =>
                {
                    document.Info.Version = "v1";
                    document.Info.Title = "Public API connector";
                    document.Info.Description = "A simple ASP.NET Core web API";
                    document.Info.TermsOfService = "None";
                    document.Info.Contact = new NSwag.OpenApiContact
                    {
                        Name = "Abdellatif EL JID",
                        Email = string.Empty,
                        Url = ""
                    };
                    document.Info.License = new NSwag.OpenApiLicense
                    {
                        Name = "Use under LICX",
                        Url = ""
                    };
                };
                config.ApiGroupNames = new[] { "1.0" };

            });

            services.AddBLL();


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


            // MiddleWare de generation du OpenApi.Json
            app.UseOpenApi(config =>
            {
                config.Path = "/api/doc/{documentName}/api.json";
            });

            //Inteface utilisateur en fonction du OpenApi.json
            app.UseSwaggerUi3(config =>
            {
                config.DocumentPath = "/api/doc/{documentName}/api.json";
                config.Path = "/api/doc";
            });

        }
    }
}
