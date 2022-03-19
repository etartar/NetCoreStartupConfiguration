using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Swagger;
using NetCoreStartupConfiguration.Abstracts;
using NetCoreStartupConfiguration.Constants;
using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;

namespace NetCoreStartupConfiguration.Concretes
{
    public class AddSwaggerConfig : IConfigureServiceModule
    {
        public void Load(IServiceCollection services)
        {
            services.AddSwaggerGen(x =>
            {
                x.SwaggerDoc(StartupSettings.Version, 
                    new OpenApiInfo
                    {
                        Title = StartupSettings.SwaggerTitle,
                        Version = StartupSettings.Version,
                        Description = StartupSettings.SwaggerDescription,
                        Contact = new OpenApiContact
                        {
                            Name = StartupSettings.SwaggerContactName,
                            Email = StartupSettings.SwaggerContactEmail,
                            Url = new System.Uri(StartupSettings.SwaggerContactUrl)
                        },
                        License = new OpenApiLicense
                        {
                            Name = StartupSettings.SwaggerLicenceName,
                            Url = new Uri(StartupSettings.SwaggerContactUrl)
                        },
                        TermsOfService = new Uri(StartupSettings.SwaggerTermsOfService)
                    });

                x.AddSecurityDefinition(StartupSettings.Bearer, new OpenApiSecurityScheme
                {
                    Description = StartupSettings.SwaggerSecurityDescription,
                    Name = StartupSettings.Authorization,
                    In = StartupSettings.Header,
                    Type = StartupSettings.ApiKey
                });
            });
        }
    }
}
