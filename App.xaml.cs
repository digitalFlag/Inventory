using Inventory.Services;
using Inventory.Services.Implementations;
using Inventory.ViewModels.MainWindowViewModel;
using Inventory.ViewModels.Warehouse;
using Inventory.Views.Windows.Warehouse;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace Inventory
{
    public partial class App : Application
    {

        private static IServiceProvider? _Services;

        public static IServiceProvider Services => _Services ??= InitializeServices().BuildServiceProvider();

        private static ServiceCollection InitializeServices()
        {
            var services = new ServiceCollection();

            services.AddSingleton<MainWindowViewModel>();
            services.AddScoped<WarehouseViewModel>();

            services.AddSingleton<IUserDialog, UserDialogServices>();
            services.AddSingleton<IDataBase, DataBaseServices>();


            services.AddTransient(
                s =>
                {
                    var model = s.GetRequiredService<MainWindowViewModel>();
                    var window = new MainWindow { DataContext = model };
                    model.DialogComplete += (_, _) => window.Close();

                    return window;
                });

            services.AddTransient(
                s =>
                {
                    var scope = s.CreateScope();
                    var model = scope.ServiceProvider.GetRequiredService<WarehouseViewModel>();
                    var window = new WarehouseWindow { DataContext = model };
                    model.DialogComplete += (_, _) => window.Close();
                    window.Closed += (_, _) => scope.Dispose();

                    return window;

                });

            return services;
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            Services.GetRequiredService<IUserDialog>().OpenMainWindow();
        }

    }

}
