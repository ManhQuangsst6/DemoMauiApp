﻿using CommunityToolkit.Maui;
using DemoMauiApp.Configurations;
using DemoMauiApp.CoreMVVM.MVVM;
using DemoMauiApp.CoreMVVM.Navigation;
using DemoMauiApp.DataAccess;
using DemoMauiApp.DataAccess.Configurations;
using DemoMauiApp.DataAccess.Interfaces;
using DemoMauiApp.DataAccess.Models;
using DemoMauiApp.Pages.ViewModels;
using DemoMauiApp.Pages.Views;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Hosting;
using Serilog;
using Serilog.Events;
using Syncfusion.Maui.Toolkit.Hosting;
//using Telerik.Maui.Controls.Compatibility;
namespace DemoMauiApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
            .UseMauiApp<App>()
            .ConfigureSyncfusionToolkit()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

            builder.BuildConfig();
            builder.RegisterServices();
            builder.RegisterPages();
            builder.RegisterViewModel();
            builder.RegisterLog();

#if DEBUG
          //  builder.Logging.AddDebug();
            //builder.EnableHotReload();
#endif
            return builder.Build();
        }
        private static MauiAppBuilder RegisterServices(this MauiAppBuilder builder)
        {
            builder.Services.AddAutoMapperConfig();
            builder.Services.AddTransient<IMainService, MainService>();
            builder.Services.AddTransient<IAppNavigator, AppNavigator>();

            return builder;
        }

        private static MauiAppBuilder RegisterPages(this MauiAppBuilder builder)
        {
            builder.Services.AddPage<MainPage, MainViewModel>();
            return builder;
        }

        private static MauiAppBuilder RegisterViewModel(this MauiAppBuilder builder)
        {
            return builder;
        }

        private static IServiceCollection AddPage<TPage, TViewModel>(this IServiceCollection services)
    where TPage : BasePage where TViewModel : BaseViewModel
        {
            services.AddTransient<TPage>();
            services.AddTransient<TViewModel>();
            return services;
        }

        private static MauiAppBuilder RegisterLog(this MauiAppBuilder builder)
        {
            // Build a temporary service provider to resolve configuration
            var serviceProvider = builder.Services.BuildServiceProvider();
            var configuration = serviceProvider.GetService<IConfiguration>();
            LogSettingModel logSetting;
            try
            {
                logSetting = configuration?.GetSection("LogSettings").Get<LogSettingModel>();
            }
            catch (InvalidOperationException ex)
            {
                return builder;
            }

            if (logSetting == null)
            {
                return builder;
            }
            // Configure Serilog
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .MinimumLevel.Override("Default", LogEventLevel.Fatal)
                .MinimumLevel.Override("Microsoft", LogEventLevel.Fatal)
                .MinimumLevel.Override("System", LogEventLevel.Fatal)
                .WriteTo.File(
                    logSetting.LogPath,
                    rollingInterval: RollingInterval.Day,
                    retainedFileCountLimit: logSetting.LogKeepDays
                )
                .CreateLogger();
            // Add Serilog to the logging providers
            builder.Logging.ClearProviders();
            //builder.Logging.AddSerilog();
            return builder;
        }

#if WINDOWS


#endif
    }
}