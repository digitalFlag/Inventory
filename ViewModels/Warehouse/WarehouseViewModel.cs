using Inventory.Services;
using Inventory.ViewModels.Base;

namespace Inventory.ViewModels.Warehouse
{
    public partial class WarehouseViewModel : DialogViewModel
    {

        private readonly IUserDialog? _UserDialog = null;

        public WarehouseViewModel() 
        {
            NameOfWarhouseWindow = "Мини склад";

            ConnectionItemMainMenuWarehouseWindow = "Соединение";
            RefreshItemConnectionMainMenuWarehouseWindow = "Обновить";
        }

        public WarehouseViewModel(IUserDialog UserDialog) : this()
        {

            _UserDialog = UserDialog;

        }


    }
}
