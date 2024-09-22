using Inventory.ViewModels.Base;

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
        #region SoldProductsFromMyWarehouse: - TabControl Item "Peализованная продукция" -> "Warehouse Window"

        /// <summary>TabControl Item "Peализованная продукция" -> "Warehouse Window"</summary>
        private string? _SoldProductsFromMyWarehouse;

        /// <summary>TabControl Item "Peализованная продукция" -> "Warehouse Window"</summary>

        public string? SoldProductsFromMyWarehouse { get => _SoldProductsFromMyWarehouse; set => Set(ref _SoldProductsFromMyWarehouse, value); }

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

        #region WarehouseEventIconValue: - Value Of Icon "Event" In Warehouse Window

        /// <summary>Value Of Icon "Event" In Warehouse Window</summary>
        private string? _WarehouseEventIconValue;

        /// <summary>Value Of Icon "Event" In Warehouse Window</summary>

        public string? WarehouseEventIconValue { get => _WarehouseEventIconValue; set => Set(ref _WarehouseEventIconValue, value); }

        #endregion
        #region WarehouseEventIconColor: - Value Of Icon Color "Event" In Warehouse Window

        /// <summary>Value Of Icon Color "Event" In Warehouse Window</summary>
        private string? _WarehouseEventIconColor;

        /// <summary>Value Of Icon Color "Event" In Warehouse Window</summary>

        public string? WarehouseEventIconColor { get => _WarehouseEventIconColor; set => Set(ref _WarehouseEventIconColor, value); }

        #endregion
        #region WarehouseEventTextValue: - Value Of Texst "Event" In Warehouse Window

        /// <summary>Value Of Texst "Event" In Warehouse Window</summary>
        private string? _WarehouseEventTextValue;

        /// <summary>Value Of Texst "Event" In Warehouse Window</summary>

        public string? WarehouseEventTextValue { get => _WarehouseEventTextValue; set => Set(ref _WarehouseEventTextValue, value); }

        #endregion



    }
}
