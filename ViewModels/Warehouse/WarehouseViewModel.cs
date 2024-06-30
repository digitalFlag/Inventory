using Inventory.Services;
using Inventory.ViewModels.Base;

namespace Inventory.ViewModels.Warehouse
{
    public partial class WarehouseViewModel : DialogViewModel
    {
        private readonly IUserDialog? _UserDialog = null;
        private readonly IDataBaseConnection? _DataBaseConnection;

        public WarehouseViewModel() 
        {
            //Test
            ItemSourseTest = new();



            NameOfWarhouseWindow = "Мини склад";
            ConnectionItemMainMenuWarehouseWindow = "Соединение";
            RefreshItemConnectionMainMenuWarehouseWindow = "Обновить";
        }

        public WarehouseViewModel(IUserDialog UserDialog, IDataBaseConnection DataBaseConnection) : this()
        {

            _UserDialog = UserDialog;
            _DataBaseConnection = DataBaseConnection;

        }


    }
}
