﻿using Inventory.Services;
using Inventory.Services.Implementations;
using Inventory.ViewModels.MainWindowViewModel;
using Inventory.ViewModels.Warehouse;
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
            services.AddScoped<WarehouseViewModel>();

            services.AddSingleton<IUserDialog, UserDialogServices>();


            services.AddTransient(
                s =>
                {
                    var model = s.GetRequiredService<MainWindowViewModel>();
                    var window = new MainWindow { DataContext = model };
                    model.DialogComplete += (_, _) => window.Close();

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
