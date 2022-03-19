using Microsoft.AspNetCore.Builder;
using NetCoreStartupConfiguration.Abstracts;

namespace NetCoreStartupConfiguration.Concretes
{
    public class UseSwaggerConfig : IConfigureModule
    {
        public int Priority { get; set; } = 1;

        public void Load(IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "NetCoreStartupConfiguration v1"));
        }
    }
}
