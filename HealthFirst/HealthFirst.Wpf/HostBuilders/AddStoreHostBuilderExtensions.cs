using HealthFirst.WPF.Mvvm.Core.Stores;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace HealthFirst.WPF.HostBuilders
{
    public static class AddStoreHostBuilderExtensions
    {
        public static IHostBuilder AddStore(this IHostBuilder host)
        {
            host.ConfigureServices(services =>
            {
                services.AddSingleton<INavigationStore, NavigationStore>();
            });

            return host;
        }
    }
}
