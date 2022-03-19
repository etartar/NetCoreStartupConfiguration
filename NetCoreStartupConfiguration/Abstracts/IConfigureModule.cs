using Microsoft.AspNetCore.Builder;

namespace NetCoreStartupConfiguration.Abstracts
{
    public interface IConfigureModule
    {
        int Priority { get; set; }
        void Load(IApplicationBuilder app);
    }
}
