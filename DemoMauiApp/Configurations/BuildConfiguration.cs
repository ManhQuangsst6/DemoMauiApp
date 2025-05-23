using Microsoft.Extensions.Configuration;

namespace DemoMauiApp.Configurations
{
    public static class BuildConfiguration
    {
        public static async void BuildConfig(this MauiAppBuilder builder)
        {
            var file = await FileSystem.Current.OpenAppPackageFileAsync("AppSettings.json");
            builder.Configuration
                .AddConfiguration(new ConfigurationBuilder().AddJsonStream(file).Build());
        }
    }
}
