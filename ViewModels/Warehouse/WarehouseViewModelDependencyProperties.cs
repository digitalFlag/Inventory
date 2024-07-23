using Inventory.Models;
using Inventory.ViewModels.Base;
using System.Data;

namespace Inventory.ViewModels.Warehouse
{
    public partial class WarehouseViewModel : DialogViewModel
    {

        #region NameOfWarhouseWindow: - Name Of "Warehouse Window"

        /// <summary>Name Of "Warehouse Window"</summary>
        private string? _NameOfWarhouseWindow;

        /// <summary>Name Of "Warehouse Window"</summary>

        public string? NameOfWarhouseWindow { get => _NameOfWarhouseWindow; set => Set(ref _NameOfWarhouseWindow, value); }

        #endregion

        #region ConnectionItemMainMenuWarehouseWindow: - Item "Connection -> "Main Menu" -> "Warehouse Window""

        /// <summary>Item "Connection -> "Main Menu" -> "Warehouse Window""</summary>
        private string? _ConnectionItemMainMenuWarehouseWindow;

        /// <summary>Item "Connection -> "Main Menu" -> "Warehouse Window""</summary>

        public string? ConnectionItemMainMenuWarehouseWindow { get => _ConnectionItemMainMenuWarehouseWindow; set => Set(ref _ConnectionItemMainMenuWarehouseWindow, value); }

        #endregion
        #region RefreshItemConnectionMainMenuWarehouseWindow: - Item "Refresh" -> "Connection" -> "Main Menu" -> "Warehouse Window"

        /// <summary>Item "Refresh" -> "Connection" -> "Main Menu" -> "Warehouse Window"</summary>
        private string? _RefreshItemConnectionMainMenuWarehouseWindow;

        /// <summary>Item "Refresh" -> "Connection" -> "Main Menu" -> "Warehouse Window"</summary>

        public string? RefreshItemConnectionMainMenuWarehouseWindow { get => _RefreshItemConnectionMainMenuWarehouseWindow; set => Set(ref _RefreshItemConnectionMainMenuWarehouseWindow, value); }

        #endregion

        #region MyMiniWarehouse: - TabControl Header "Мой Мини-Склад" -> "Warehouse Window"

        /// <summary>TabControl Header "Мой Мини-Склад" -> "Warehouse Window"</summary>
        private string? _MyMiniWarehouse;

        /// <summary>TabControl Header "Мой Мини-Склад" -> "Warehouse Window"</summary>

        public string? MyMiniWarehouse { get => _MyMiniWarehouse; set => Set(ref _MyMiniWarehouse, value); }

        #endregion
        #region AddToMyMiniWarehouse: - TabControl Item "Добавить На Мини-Склад" -> "Warehouse Window"

        /// <summary>TabControl Item "Добавить На Мини-Склад" -> "Warehouse Window"</summary>
        private string? _AddToMyMiniWarehouse;

        /// <summary>TabControl Item "Добавить На Мини-Склад" -> "Warehouse Window"</summary>

        public string? AddToMyMiniWarehouse { get => _AddToMyMiniWarehouse; set => Set(ref _AddToMyMiniWarehouse, value); }

        #endregion
        #region OptionsMyWarehouseTabWarhouseWindow: - Label "Options" -> "My Warehouse" Case -> "Warehouse Window" 

        /// <summary>Label "Options" -> "My Warehouse" Case -> "Warehouse Window" </summary>
        private string? _OptionsMyWarehouseTabWarhouseWindow;

        /// <summary>Label "Options" -> "My Warehouse" Case -> "Warehouse Window" </summary>

        public string? OptionsMyWarehouseTabWarhouseWindow { get => _OptionsMyWarehouseTabWarhouseWindow; set => Set(ref _OptionsMyWarehouseTabWarhouseWindow, value); }

        #endregion

        #region DownloadDataMyProductsWarehouseWindow: - "Download Data" -> "My Mini-Warehouse" Case -> "Warehouse Window"

        /// <summary>"Download Data" -> "My Mini-Warehouse" Case -> "Warehouse Window"</summary>
        private string? _DownloadDataMyProductsWarehouseWindow;

        /// <summary>"Download Data" -> "My Mini-Warehouse" Case -> "Warehouse Window"</summary>

        public string? DownloadDataMyProductsWarehouseWindow { get => _DownloadDataMyProductsWarehouseWindow; set => Set(ref _DownloadDataMyProductsWarehouseWindow, value); }

        #endregion

        #region LoadedDataTableFromDataBaseMiniWarehouseWindow: - Loaded "DataTable" From SQL DB For "WareHouse Window" 

        /// <summary>Loaded "DataTable" From SQL DB For "WareHouse Window" </summary>
        private DataTable? _LoadedDataTableFromDataBaseMiniWarehouseWindow;

        /// <summary>Loaded "DataTable" From SQL DB For "WareHouse Window" </summary>

        public DataTable? LoadedDataTableFromDataBaseMiniWarehouseWindow { get => _LoadedDataTableFromDataBaseMiniWarehouseWindow; set => Set(ref _LoadedDataTableFromDataBaseMiniWarehouseWindow, value); }

        #endregion
        #region WarehouseProducts: - Products On Warehouse List

        /// <summary>Products On Warehouse List</summary>
        private IEnumerable<WarehouseProduct>? _WarehouseProducts;

        /// <summary>Products On Warehouse List</summary>

        public IEnumerable<WarehouseProduct>? WarehouseProducts { get => _WarehouseProducts; set => Set(ref _WarehouseProducts, value); }

        #endregion
        #region SelectedWarehouseProduct: - Selected Warehouse Product

        /// <summary>Selected Warehouse Product</summary>
        private WarehouseProduct? _SelectedWarehouseProduct;

        /// <summary>Selected Warehouse Product</summary>

        public WarehouseProduct? SelectedWarehouseProduct
        {
            get => _SelectedWarehouseProduct;
            set => Set(ref _SelectedWarehouseProduct, value);
        }

        #endregion

       










    }
}
