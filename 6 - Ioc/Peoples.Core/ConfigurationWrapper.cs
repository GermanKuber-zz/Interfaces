using Microsoft.Extensions.Configuration;

namespace Peoples.Core
{
    public static class ConfigurationWrapper
    {
        public static IConfigurationRoot Configuration { get; set; }
    }
}