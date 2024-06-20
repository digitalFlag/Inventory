using Inventory.ViewModels.MainWindowViewModel;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace Inventory
{
    public partial class App : Application
    {

        private static IServiceProvider? _Services;

        public static IServiceProvider Services => _Services ??= InitializeServices().BuildServiceProvider();

        private static IServiceCollection InitializeServices()
        {
            var services = new ServiceCollection();

            services.AddSingleton<MainWindowViewModel>();

            return services;
        }


    }

}
