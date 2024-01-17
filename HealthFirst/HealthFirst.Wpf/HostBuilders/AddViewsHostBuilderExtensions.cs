using HealthFirst.WPF.Mvvm.ViewModels;
using HealthFirst.WPF.Views.Windows;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace HealthFirst.WPF.HostBuilders
{
    public static class AddViewsHostBuilderExtensions
    {
        public static IHostBuilder AddViews(this IHostBuilder host) 
        {
            host.ConfigureServices(services => 
            {
                // Main Window
                services.AddSingleton(w => new MainWindow(w.GetRequiredService<MainViewModel>()));
            });

            return host;
        }
    }
}
