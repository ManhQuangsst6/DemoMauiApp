using Microsoft.Extensions.DependencyInjection;

namespace DemoMauiApp.DataAccess.Configurations
{
    public static class ConfigurationAutoMapper
    {
        public static IServiceCollection AddAutoMapperConfig(this IServiceCollection collection)
        {
            return collection.AddAutoMapper(typeof(ConfigurationAutoMapper).Assembly);
        }
    }
}
