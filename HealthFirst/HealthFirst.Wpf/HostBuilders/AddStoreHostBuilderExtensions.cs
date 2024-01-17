using HealthFirst.WPF.Mvvm.Core.Stores;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
