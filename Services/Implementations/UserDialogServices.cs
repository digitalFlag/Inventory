using Inventory.Views.Windows.Warehouse;
using Microsoft.Extensions.DependencyInjection;

namespace Inventory.Services.Implementations
{
    public class UserDialogServices : IUserDialog
    {
        private readonly IServiceProvider _Services;

        public UserDialogServices(IServiceProvider Services) => _Services = Services;

        private MainWindow? _MainWindow;
        public void OpenMainWindow()
        {
            if (_MainWindow is { } window)
            {
                window.Show();
                return;
            }

            window = _Services.GetRequiredService<MainWindow>();
            window.Closed += (_, _) => _MainWindow = null;

            _MainWindow = window;
            window.Show();
        }


        private WarehouseWindow? _WarehouseWindow;
        public void OpenWarehouseWindow()
        {
            if (_WarehouseWindow is { } window)
            {
                window.Show();
                return;
            }

            window = _Services.GetRequiredService<WarehouseWindow>();
            window.Closed += (_, _) => _WarehouseWindow = null;

            _WarehouseWindow = window;
            window.Show();

        }

    }
}
