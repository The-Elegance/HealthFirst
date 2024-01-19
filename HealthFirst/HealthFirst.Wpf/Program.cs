using HealthFirst.WPF.HostBuilders;
using HealthFirst.WPF.Views.Windows;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;

namespace HealthFirst.WPF
{
    internal class Program
    {
        private static IHost _host;
        private static App _app;

        [STAThread] 
        public static void Main() 
        {
            _host = CreateHostBuilder().Build();

            _app = _host.Services.GetService<App>();

            _app.Startup += OnStartup;
            _app.Exit += OnExit;

            _app.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args = null)
        {
            return Host.CreateDefaultBuilder(args)
                .AddServices()
                .AddStore()
                .AddViewModels()
                .AddViews();
        }

        private static void OnStartup(object sender, StartupEventArgs e)
        {
            _host.Start();

            _app.Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri("pack://application:,,,/Assets/LanguageRegistry.xaml")
            });

            _app.Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri("pack://application:,,,/Controls/ControlsRegistry.xaml")
            });

            // DataTemplates (VM <-> View)
            _app.Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri("pack://application:,,,/DataTemplates.xaml")
            });

            _app.Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri("pack://application:,,,/Resources/Themes/DarkTheme.xaml")
            });

            _app.MainWindow = _host.Services.GetRequiredService<MainWindow>();
            _app.MainWindow.Show();
        }

        private static async void OnExit(object sender, ExitEventArgs e)
        {
            await _host.StopAsync();
            _host.Dispose();
        }
    }
}
