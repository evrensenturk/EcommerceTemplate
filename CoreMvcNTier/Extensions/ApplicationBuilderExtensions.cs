using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMvcNTier.Extensions
{
    public  static class ApplicationBuilderExtensions
    {
            public static IApplicationBuilder  UseTheme (this IApplicationBuilder app,string  root)
            {

            var path = Path.Combine(root, "wwwroot/themes");
            var provider = new PhysicalFileProvider(path);

            var options = new StaticFileOptions();
            options.FileProvider = provider;
            options.RequestPath = "/themes";
            app.UseStaticFiles(options);
            return app;
            }
    }
}
