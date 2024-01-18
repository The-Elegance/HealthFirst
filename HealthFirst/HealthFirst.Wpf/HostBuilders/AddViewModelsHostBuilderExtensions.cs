using HealthFirst.WPF.Mvvm.ViewModels;
using HealthFirst.WPF.Mvvm.ViewModels.Layouts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace HealthFirst.WPF.HostBuilders
{
    public static class AddViewModelsHostBuilderExtensions
    {
        public static IHostBuilder AddViewModels(this IHostBuilder host) 
        {
            host.ConfigureServices(services => 
            {
                services.AddSingleton<MainViewModel>();

                services.AddSingleton<MainMenuLayoutViewModel>();
            });

            return host;        
        }
    }
}
