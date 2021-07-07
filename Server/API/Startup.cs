
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
using DocFx.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Text.Json.Serialization;

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
            services.AddControllers().AddJsonOptions( configure => configure.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull);

            services.AddBLL();

            //Unique dans toute mon application (même instance dans toute l'aplication)

            ////A chaque fois qu'on demande un Ilibrairi service => nouvelle instance
            //services.AddTransient<ILibrairiService, LibrairiService>();

            //// La même instance tout au long de la requête
            //services.AddScoped<ILibrairiService, LibrairiService>();


            //Versioning
            services.AddApiVersioning(config =>
            {
                config.ReportApiVersions = true;
               
            });

            //Changer le mode d'exploration d'api avec la version dans l'url!
            services.AddVersionedApiExplorer(option =>
            {
               
                option.SubstituteApiVersionInUrl= true;
               

            });
            //Documentation Client API
            services.AddOpenApiDocument(config =>
            {
                config.DocumentName = "v1.0";
                config.PostProcess = document =>
                {
                    document.Info.Version = "v1";
                    document.Info.Title = "FoodBook Abdel";
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
                        Name = "Api FoodBook",
                        Url = ""
                    };
                };
                config.ApiGroupNames = new[] { "1.0" };

            });
            services
                 .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                 .AddJwtBearer(options =>
                 {
                     options.TokenValidationParameters = new TokenValidationParameters()
                     {
                         ValidateIssuer = false,
                         ValidateAudience = false,
                         ValidAudience = Configuration["JwtIssuer"],
                         ValidIssuer = Configuration["JwtIssuer"],
                         ValidateIssuerSigningKey = true,
                         IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JwtKey"])),
                         //Retourne la difference de tps max autorisée entre le client et les parametres de l'horloge du serveur
                         ClockSkew = TimeSpan.Zero // remove delay of token whe expire
                     };
                 
                 });
         


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
 
            //Add Authentification => code Erreur 401
            app.UseAuthentication()
;

            //Add Authorization => code Erreur 403
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });


            app.UseDocFx(config =>
            {
                config.roothPath = "/doc";
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
