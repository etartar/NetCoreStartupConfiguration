using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using NetCoreStartupConfiguration.Abstracts;
using System;
using System.Linq;

namespace NetCoreStartupConfiguration.Extensions
{
    public static class InstallerExtensions
    {
        public static void ServicesInstallerAssembly(this IServiceCollection services)
        {
            var installers = typeof(Startup).Assembly.ExportedTypes
                                            .Where(x => typeof(IConfigureServiceModule).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
                                            .Select(Activator.CreateInstance)
                                            .Cast<IConfigureServiceModule>()
                                            .ToList();

            installers.ForEach(installer => installer.Load(services));
        }

        public static void ConfigurationsInstallerAssembly(this IApplicationBuilder app)
        {
            var installers = typeof(Startup).Assembly.ExportedTypes
                                            .Where(x => typeof(IConfigureModule).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
                                            .Select(Activator.CreateInstance)
                                            .Cast<IConfigureModule>()
                                            .OrderBy(o => o.Priority)
                                            .ToList();

            installers.ForEach(installer => installer.Load(app));
        }
    }
}
