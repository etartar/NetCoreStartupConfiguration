using Microsoft.Extensions.DependencyInjection;

namespace NetCoreStartupConfiguration.Abstracts
{
    public interface IConfigureServiceModule
    {
        void Load(IServiceCollection services);
    }
}
