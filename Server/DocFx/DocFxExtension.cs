using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DocFx.AspNetCore
{
    public static class DocFxExtension
    {/// <summary>
    /// Ajouter l'intergiciel (midelware) server static files
    /// </summary>
    /// <param name="app"></param>
    /// <param name="configure"></param>
    /// <returns></returns>
        public static IApplicationBuilder UseDocFx(
            this IApplicationBuilder app,
            Action<DocFxSettings> configure = null
            )
        {
            //options de configuration
            DocFxSettings settings = new DocFxSettings();
            if (configure == null)
            {
                settings.roothPath = "/docfx";
            }
            else
            {
                configure.Invoke(settings);
            }
            // Fin de récupération de la configuration

            //Servir les fichiers statique sur l'Url roothPath
            app.UseFileServer(new FileServerOptions
            {
                RequestPath = new PathString(settings.roothPath),
                FileProvider = new EmbeddedFileProvider(typeof(DocFxExtension).GetTypeInfo().Assembly, "DocFx._site")
            });

            return app;
        }
    }
}
