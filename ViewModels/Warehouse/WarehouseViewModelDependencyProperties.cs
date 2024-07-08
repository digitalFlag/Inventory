using Inventory.Models;
using Inventory.ViewModels.Base;
using System.Collections.ObjectModel;
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

        #region LabelSelectedProductTittleMyWarehouseControlTab: - "Tittle" Of Selected Product At "My Warehouse"

        /// <summary>"Tittle" Of Selected Product At "My Warehouse"</summary>
        private string? _LabelSelectedProductTittleMyWarehouseControlTab;

        /// <summary>"Tittle" Of Selected Product At "My Warehouse"</summary>

        public string? LabelSelectedProductTittleMyWarehouseControlTab { get => _LabelSelectedProductTittleMyWarehouseControlTab; set => Set(ref _LabelSelectedProductTittleMyWarehouseControlTab, value); }

        #endregion
        #region BorderColorSelectedProductTittleMyWarehouseControlTab: - "Border Color" Of Selected Product At "My Warehouse"

        /// <summary>"Border Color" Of Selected Product At "My Warehouse"</summary>
        private string? _BorderColorSelectedProductTittleMyWarehouseControlTab;

        /// <summary>"Border Color" Of Selected Product At "My Warehouse"</summary>

        public string? BorderColorSelectedProductTittleMyWarehouseControlTab { get => _BorderColorSelectedProductTittleMyWarehouseControlTab; set => Set(ref _BorderColorSelectedProductTittleMyWarehouseControlTab, value); }

        #endregion
        #region LabelSelectedProductPropertyMyWarehouseControlTab: - "Property" Of Selected Product At "My Warehouse"

        /// <summary>"Property" Of Selected Product At "My Warehouse"</summary>
        private string? _LabelSelectedProductPropertyMyWarehouseControlTab;

        /// <summary>"Property" Of Selected Product At "My Warehouse"</summary>

        public string? LabelSelectedProductPropertyMyWarehouseControlTab { get => _LabelSelectedProductPropertyMyWarehouseControlTab; set => Set(ref _LabelSelectedProductPropertyMyWarehouseControlTab, value); }

        #endregion
        #region BorderColorSelectedProductPropertyMyWarehouseControlTab: - "Border Color" Of Selected Product Property At "My Warehouse"

        /// <summary>"Border Color" Of Selected Product Property At "My Warehouse"</summary>
        private string? _BorderColorSelectedProductPropertyMyWarehouseControlTab;

        /// <summary>"Border Color" Of Selected Product Property At "My Warehouse"</summary>

        public string? BorderColorSelectedProductPropertyMyWarehouseControlTab { get => _BorderColorSelectedProductPropertyMyWarehouseControlTab; set => Set(ref _BorderColorSelectedProductPropertyMyWarehouseControlTab, value); }

        #endregion
        #region LabelSelectedProductSizeMyWarehouseControlTab: - "Size" Of Selected Product At "My Warehouse"

        /// <summary>"Size" Of Selected Product At "My Warehouse"</summary>
        private string? _LabelSelectedProductSizeMyWarehouseControlTab;

        /// <summary>"Size" Of Selected Product At "My Warehouse"</summary>

        public string? LabelSelectedProductSizeMyWarehouseControlTab { get => _LabelSelectedProductSizeMyWarehouseControlTab; set => Set(ref _LabelSelectedProductSizeMyWarehouseControlTab, value); }

        #endregion
        #region BorderColorSelectedProductSizeMyWarehouseControlTab: - "Border Color" Of Selected Product Size At "My Warehouse"

        /// <summary>"Border Color" Of Selected Product Size At "My Warehouse"</summary>
        private string? _BorderColorSelectedProductSizeMyWarehouseControlTab;

        /// <summary>"Border Color" Of Selected Product Size At "My Warehouse"</summary>

        public string? BorderColorSelectedProductSizeMyWarehouseControlTab { get => _BorderColorSelectedProductSizeMyWarehouseControlTab; set => Set(ref _BorderColorSelectedProductSizeMyWarehouseControlTab, value); }

        #endregion
        #region LabelSelectedProductExpirationDateMyWarehouseControlTab: - "ExpirationDate" Of Selected Product At "My Warehouse"

        /// <summary>"ExpirationDate" Of Selected Product At "My Warehouse"</summary>
        private string? _LabelSelectedProductExpirationDateMyWarehouseControlTab;

        /// <summary>"ExpirationDate" Of Selected Product At "My Warehouse"</summary>

        public string? LabelSelectedProductExpirationDateMyWarehouseControlTab { get => _LabelSelectedProductExpirationDateMyWarehouseControlTab; set => Set(ref _LabelSelectedProductExpirationDateMyWarehouseControlTab, value); }

        #endregion
        #region BorderColorSelectedProductExpirationDateMyWarehouseControlTab: - "Border Color" Of Selected Product Expiration Date At "My Warehouse"

        /// <summary>"Border Color" Of Selected Product Expiration Date At "My Warehouse"</summary>
        private string? _BorderColorSelectedProductExpirationDateMyWarehouseControlTab;

        /// <summary>"Border Color" Of Selected Product Expiration Date At "My Warehouse"</summary>

        public string? BorderColorSelectedProductExpirationDateMyWarehouseControlTab { get => _BorderColorSelectedProductExpirationDateMyWarehouseControlTab; set => Set(ref _BorderColorSelectedProductExpirationDateMyWarehouseControlTab, value); }

        #endregion
        #region LabelSelectedProductPurchaseCostMyWarehouseControlTab: - "Purchase Cost" Of Selected Product At "My Warehouse"

        /// <summary>"Purchase Cost" Of Selected Product At "My Warehouse"</summary>
        private string? _LabelSelectedProductPurchaseCostMyWarehouseControlTab;

        /// <summary>"Purchase Cost" Of Selected Product At "My Warehouse"</summary>

        public string? LabelSelectedProductPurchaseCostMyWarehouseControlTab { get => _LabelSelectedProductPurchaseCostMyWarehouseControlTab; set => Set(ref _LabelSelectedProductPurchaseCostMyWarehouseControlTab, value); }

        #endregion
        #region BorderColorSelectedProductPurchaseCostMyWarehouseControlTab: - "Purchase Cost" Of Selected Product Expiration Date At "My Warehouse"

        /// <summary>"Purchase Cost" Of Selected Product Expiration Date At "My Warehouse"</summary>
        private string? _BorderColorSelectedProductPurchaseCostMyWarehouseControlTab;

        /// <summary>"Purchase Cost" Of Selected Product Expiration Date At "My Warehouse"</summary>

        public string? BorderColorSelectedProductPurchaseCostMyWarehouseControlTab { get => _BorderColorSelectedProductPurchaseCostMyWarehouseControlTab; set => Set(ref _BorderColorSelectedProductPurchaseCostMyWarehouseControlTab, value); }

        #endregion
        #region LabelSelectedProductLocationMyWarehouseControlTab: - "Location" Of Selected Product At "My Warehouse"

        /// <summary>"Location" Of Selected Product At "My Warehouse"</summary>
        private string? _LabelSelectedProductLocationMyWarehouseControlTab;

        /// <summary>"Location" Of Selected Product At "My Warehouse"</summary>

        public string? LabelSelectedProductLocationMyWarehouseControlTab { get => _LabelSelectedProductLocationMyWarehouseControlTab; set => Set(ref _LabelSelectedProductLocationMyWarehouseControlTab, value); }

        #endregion
        #region BorderColorSelectedProductLocationMyWarehouseControlTab: - "Border Color" Of Selected Product Location At "My Warehouse"

        /// <summary>"Border Color" Of Selected Product Location At "My Warehouse"</summary>
        private string? _BorderColorSelectedProductLocationMyWarehouseControlTab;

        /// <summary>"Border Color" Of Selected Product Location At "My Warehouse"</summary>

        public string? BorderColorSelectedProductLocationMyWarehouseControlTab { get => _BorderColorSelectedProductLocationMyWarehouseControlTab; set => Set(ref _BorderColorSelectedProductLocationMyWarehouseControlTab, value); }

        #endregion
        #region LabelSelectedProductReceiptDateMyWarehouseControlTab: - "Receipt Date" Of Selected Product At "My Warehouse"

        /// <summary>"Receipt Date" Of Selected Product At "My Warehouse"</summary>
        private string? _LabelSelectedProductReceiptDateMyWarehouseControlTab;

        /// <summary>"Receipt Date" Of Selected Product At "My Warehouse"</summary>

        public string? LabelSelectedProductReceiptDateMyWarehouseControlTab { get => _LabelSelectedProductReceiptDateMyWarehouseControlTab; set => Set(ref _LabelSelectedProductReceiptDateMyWarehouseControlTab, value); }

        #endregion
        #region BorderColorSelectedProductReceiptDateMyWarehouseControlTab: - "Receipt Date" Of Selected Product Expiration Date At "My Warehouse"

        /// <summary>"Receipt Date" Of Selected Product Expiration Date At "My Warehouse"</summary>
        private string? _BorderColorSelectedProductReceiptDateMyWarehouseControlTab;

        /// <summary>"Receipt Date" Of Selected Product Expiration Date At "My Warehouse"</summary>

        public string? BorderColorSelectedProductReceiptDateMyWarehouseControlTab { get => _BorderColorSelectedProductReceiptDateMyWarehouseControlTab; set => Set(ref _BorderColorSelectedProductReceiptDateMyWarehouseControlTab, value); }

        #endregion
        #region LabelSelectedProductOrderNumberMyWarehouseControlTab: - "Order Number" Of Selected Product At "My Warehouse"

        /// <summary>"Order Number" Of Selected Product At "My Warehouse"</summary>
        private string? _LabelSelectedProductOrderNumberMyWarehouseControlTab;

        /// <summary>"Order Number" Of Selected Product At "My Warehouse"</summary>

        public string? LabelSelectedProductOrderNumberMyWarehouseControlTab { get => _LabelSelectedProductOrderNumberMyWarehouseControlTab; set => Set(ref _LabelSelectedProductOrderNumberMyWarehouseControlTab, value); }

        #endregion
        #region BorderColorSelectedProductOrderNumberMyWarehouseControlTab: - "Border Color" Of Selected Product Order Number At "My Warehouse"

        /// <summary>"Border Color" Of Selected Product Order Number At "My Warehouse"</summary>
        private string? _BorderColorSelectedProductOrderNumberMyWarehouseControlTab;

        /// <summary>"Border Color" Of Selected Product Order Number At "My Warehouse"</summary>

        public string? BorderColorSelectedProductOrderNumberMyWarehouseControlTab { get => _BorderColorSelectedProductOrderNumberMyWarehouseControlTab; set => Set(ref _BorderColorSelectedProductOrderNumberMyWarehouseControlTab, value); }

        #endregion
        #region LabelSelectedProductIdMyWarehouseControlTab: - "Id" Of Selected Product At "My Warehouse"

        /// <summary>"Id" Of Selected Product At "My Warehouse"</summary>
        private string? _LabelSelectedProductIdMyWarehouseControlTab;

        /// <summary>"Id" Of Selected Product At "My Warehouse"</summary>

        public string? LabelSelectedProductIdMyWarehouseControlTab { get => _LabelSelectedProductIdMyWarehouseControlTab; set => Set(ref _LabelSelectedProductIdMyWarehouseControlTab, value); }

        #endregion
        #region LabelSelectedProductNoteMyWarehouseControlTab: - "Note" Of Selected Product At "My Warehouse"

        /// <summary>"Note" Of Selected Product At "My Warehouse"</summary>
        private string? _LabelSelectedProductNoteMyWarehouseControlTab;

        /// <summary>"Note" Of Selected Product At "My Warehouse"</summary>

        public string? LabelSelectedProductNoteMyWarehouseControlTab { get => _LabelSelectedProductNoteMyWarehouseControlTab; set => Set(ref _LabelSelectedProductNoteMyWarehouseControlTab, value); }

        #endregion
        #region BorderColorSelectedProductNoteMyWarehouseControlTab: - "Border Color" Of Selected Product Note At "My Warehouse"

        /// <summary>"Border Color" Of Selected Product Note At "My Warehouse"</summary>
        private string? _BorderColorSelectedProductNoteMyWarehouseControlTab;

        /// <summary>"Border Color" Of Selected Product Note At "My Warehouse"</summary>

        public string? BorderColorSelectedProductNoteMyWarehouseControlTab { get => _BorderColorSelectedProductNoteMyWarehouseControlTab; set => Set(ref _BorderColorSelectedProductNoteMyWarehouseControlTab, value); }

        #endregion
        #region ButtonCaptionReWriteWareHouseProduct: - Button Caption "ReWrite Data" In My WareHouse Products

        /// <summary>Button Caption "ReWrite Data" In My WareHouse Products</summary>
        private string? _ButtonCaptionReWriteWareHouseProduct;

        /// <summary>Button Caption "ReWrite Data" In My WareHouse Products</summary>

        public string? ButtonCaptionReWriteWareHouseProduct { get => _ButtonCaptionReWriteWareHouseProduct; set => Set(ref _ButtonCaptionReWriteWareHouseProduct, value); }

        #endregion

        #region TextLabelEventLogMyWarehouseTabControlWarehouseWindow: - Text Of Event Log In MyWarehouse TabControl In Warehouse Window

        /// <summary>Text Of Event Log In MyWarehouse TabControl In Warehouse Window</summary>
        private string? _TextLabelEventLogMyWarehouseTabControlWarehouseWindow;

        /// <summary>Text Of Event Log In MyWarehouse TabControl In Warehouse Window</summary>

        public string? TextLabelEventLogMyWarehouseTabControlWarehouseWindow { get => _TextLabelEventLogMyWarehouseTabControlWarehouseWindow; set => Set(ref _TextLabelEventLogMyWarehouseTabControlWarehouseWindow, value); }

        #endregion










    }
}
