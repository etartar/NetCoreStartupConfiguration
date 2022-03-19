using Microsoft.OpenApi.Models;

namespace NetCoreStartupConfiguration.Constants
{
    public static class StartupSettings
    {
        public const string Version = "v1";
        public const string Bearer = "Bearer";
        public const ParameterLocation Header = ParameterLocation.Header;
        public const SecuritySchemeType ApiKey = SecuritySchemeType.ApiKey;
        public const string Authorization = "Authorization";
        public const string SwaggerDescription = "This project belongs to © ";
        public const string SwaggerSecurityDescription = "Jwt Authorization header using the bearer scheme!";
        public const string SwaggerTitle = "NetCoreStartupConfiguration API";
        public const string SwaggerContactName = "NetCoreStartupConfiguration";
        public const string SwaggerLicenceName = "All rights reserved. © NetCoreStartupConfiguration";
        public const string SwaggerContactEmail = "emirtartar35@gmail.com";
        public const string SwaggerContactUrl = "https://localhost:5000";
        public const string SwaggerTermsOfService = "http://swagger.io/terms/";
    }
}
