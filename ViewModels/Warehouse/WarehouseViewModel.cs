using Inventory.Models;
using Inventory.Services;
using Inventory.ViewModels.Base;
using System.Data;

namespace Inventory.ViewModels.Warehouse
{
    public partial class WarehouseViewModel : DialogViewModel
    {
        private readonly IUserDialog? _UserDialog = null;
        private readonly IDataBaseConnection? _DataBaseConnection;

        public WarehouseViewModel() 
        {
            //Test

            NameOfWarhouseWindow = "Мини-Cклад";
            ConnectionItemMainMenuWarehouseWindow = "Соединение";
            RefreshItemConnectionMainMenuWarehouseWindow = "Обновить";

            MyMiniWarehouse = "Мой Мини-Склад";
            AddToMyMiniWarehouse = "Добавить Продукцию на Мини-Склад";
            OptionsMyWarehouseTabWarhouseWindow = "Действия:";
            DownloadDataMyProductsWarehouseWindow = "Обновить данные";
            LoadedDataTableFromDataBaseMiniWarehouseWindow = new DataTable();

            //Dell??
            SelectedWarehouseProduct = null;
        }

        public WarehouseViewModel(IUserDialog UserDialog, IDataBaseConnection DataBaseConnection) : this()
        {

            _UserDialog = UserDialog;
            _DataBaseConnection = DataBaseConnection;

        }


    }
}
