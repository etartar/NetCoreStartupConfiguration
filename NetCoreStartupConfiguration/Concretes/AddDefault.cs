using Microsoft.Extensions.DependencyInjection;
using NetCoreStartupConfiguration.Abstracts;

namespace NetCoreStartupConfiguration.Concretes
{
    public class AddDefault : IConfigureServiceModule
    {
        public void Load(IServiceCollection services)
        {
            services.AddControllers();
        }
    }
}
