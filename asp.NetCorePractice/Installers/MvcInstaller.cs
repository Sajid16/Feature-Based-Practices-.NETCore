using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Services.Abstractions;
using WebApi.Services.Implementations;

namespace WebApi.Installers
{
    public class MvcInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            // MVC and swagger related staffs transfered to here from startup.cs to make it minimal
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebApi", Version = "v1" });
            });

            //registering services with associated interface
            //services.AddSingleton<IPostServices, PostServices>();
            services.AddScoped<IPostServices, PostServices>();
        }
    }
}
