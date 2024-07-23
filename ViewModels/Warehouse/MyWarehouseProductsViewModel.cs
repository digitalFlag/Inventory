using Inventory.ViewModels.Base;

namespace Inventory.ViewModels.Warehouse
{
    public partial class WarehouseViewModel : DialogViewModel
    {
        #region Dependency Properties

        #region BorderColorSelectedProductTittleMyWarehouseControlTab: - "Border Color" Of Selected Product At "My Warehouse"

        /// <summary>"Border Color" Of Selected Product At "My Warehouse"</summary>
        private string? _BorderColorSelectedProductTittleMyWarehouseControlTab;

        /// <summary>"Border Color" Of Selected Product At "My Warehouse"</summary>

        public string? BorderColorSelectedProductTittleMyWarehouseControlTab { get => _BorderColorSelectedProductTittleMyWarehouseControlTab; set => Set(ref _BorderColorSelectedProductTittleMyWarehouseControlTab, value); }

        #endregion
        #region BorderColorSelectedProductPropertyMyWarehouseControlTab: - "Border Color" Of Selected Product Property At "My Warehouse"

        /// <summary>"Border Color" Of Selected Product Property At "My Warehouse"</summary>
        private string? _BorderColorSelectedProductPropertyMyWarehouseControlTab;

        /// <summary>"Border Color" Of Selected Product Property At "My Warehouse"</summary>

        public string? BorderColorSelectedProductPropertyMyWarehouseControlTab { get => _BorderColorSelectedProductPropertyMyWarehouseControlTab; set => Set(ref _BorderColorSelectedProductPropertyMyWarehouseControlTab, value); }

        #endregion
        #region BorderColorSelectedProductSizeMyWarehouseControlTab: - "Border Color" Of Selected Product Size At "My Warehouse"

        /// <summary>"Border Color" Of Selected Product Size At "My Warehouse"</summary>
        private string? _BorderColorSelectedProductSizeMyWarehouseControlTab;

        /// <summary>"Border Color" Of Selected Product Size At "My Warehouse"</summary>

        public string? BorderColorSelectedProductSizeMyWarehouseControlTab { get => _BorderColorSelectedProductSizeMyWarehouseControlTab; set => Set(ref _BorderColorSelectedProductSizeMyWarehouseControlTab, value); }

        #endregion
        #region BorderColorSelectedProductExpirationDateMyWarehouseControlTab: - "Border Color" Of Selected Product Expiration Date At "My Warehouse"

        /// <summary>"Border Color" Of Selected Product Expiration Date At "My Warehouse"</summary>
        private string? _BorderColorSelectedProductExpirationDateMyWarehouseControlTab;

        /// <summary>"Border Color" Of Selected Product Expiration Date At "My Warehouse"</summary>

        public string? BorderColorSelectedProductExpirationDateMyWarehouseControlTab { get => _BorderColorSelectedProductExpirationDateMyWarehouseControlTab; set => Set(ref _BorderColorSelectedProductExpirationDateMyWarehouseControlTab, value); }

        #endregion
        #region BorderColorSelectedProductPurchaseCostMyWarehouseControlTab: - "Purchase Cost" Of Selected Product Expiration Date At "My Warehouse"

        /// <summary>"Purchase Cost" Of Selected Product Expiration Date At "My Warehouse"</summary>
        private string? _BorderColorSelectedProductPurchaseCostMyWarehouseControlTab;

        /// <summary>"Purchase Cost" Of Selected Product Expiration Date At "My Warehouse"</summary>

        public string? BorderColorSelectedProductPurchaseCostMyWarehouseControlTab { get => _BorderColorSelectedProductPurchaseCostMyWarehouseControlTab; set => Set(ref _BorderColorSelectedProductPurchaseCostMyWarehouseControlTab, value); }

        #endregion
        #region BorderColorSelectedProductLocationMyWarehouseControlTab: - "Border Color" Of Selected Product Location At "My Warehouse"

        /// <summary>"Border Color" Of Selected Product Location At "My Warehouse"</summary>
        private string? _BorderColorSelectedProductLocationMyWarehouseControlTab;

        /// <summary>"Border Color" Of Selected Product Location At "My Warehouse"</summary>

        public string? BorderColorSelectedProductLocationMyWarehouseControlTab { get => _BorderColorSelectedProductLocationMyWarehouseControlTab; set => Set(ref _BorderColorSelectedProductLocationMyWarehouseControlTab, value); }

        #endregion
        #region BorderColorSelectedProductReceiptDateMyWarehouseControlTab: - "Receipt Date" Of Selected Product Expiration Date At "My Warehouse"

        /// <summary>"Receipt Date" Of Selected Product Expiration Date At "My Warehouse"</summary>
        private string? _BorderColorSelectedProductReceiptDateMyWarehouseControlTab;

        /// <summary>"Receipt Date" Of Selected Product Expiration Date At "My Warehouse"</summary>

        public string? BorderColorSelectedProductReceiptDateMyWarehouseControlTab { get => _BorderColorSelectedProductReceiptDateMyWarehouseControlTab; set => Set(ref _BorderColorSelectedProductReceiptDateMyWarehouseControlTab, value); }

        #endregion
        #region BorderColorSelectedProductOrderNumberMyWarehouseControlTab: - "Border Color" Of Selected Product Order Number At "My Warehouse"

        /// <summary>"Border Color" Of Selected Product Order Number At "My Warehouse"</summary>
        private string? _BorderColorSelectedProductOrderNumberMyWarehouseControlTab;

        /// <summary>"Border Color" Of Selected Product Order Number At "My Warehouse"</summary>

        public string? BorderColorSelectedProductOrderNumberMyWarehouseControlTab { get => _BorderColorSelectedProductOrderNumberMyWarehouseControlTab; set => Set(ref _BorderColorSelectedProductOrderNumberMyWarehouseControlTab, value); }

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

        #region SelectedProductId: - Selected Product ID "My Warehouse"

        /// <summary>Selected Product ID "My Warehouse"</summary>
        private string? _SelectedProductId;

        /// <summary>Selected Product ID "My Warehouse"</summary>

        public string? SelectedProductId { get => _SelectedProductId; set => Set(ref _SelectedProductId, value); }

        #endregion
        #region SelectedProductTittle: - Selected Product Tittle "My Warehouse"

        /// <summary>Selected Product Tittle "My Warehouse"</summary>
        private string? _SelectedProductTittle;

        /// <summary>Selected Product Tittle "My Warehouse"</summary>

        public string? SelectedProductTittle { get => _SelectedProductTittle; set => Set(ref _SelectedProductTittle, value); }

        #endregion
        #region SelectedProductProperty: - Selected Product Property "My Warehouse"

        /// <summary>Selected Product Property "My Warehouse"</summary>
        private string? _SelectedProductProperty;

        /// <summary>Selected Product Property "My Warehouse"</summary>

        public string? SelectedProductProperty { get => _SelectedProductProperty; set => Set(ref _SelectedProductProperty, value); }

        #endregion
        #region SelectedProductSize: - Selected Product Size "My Warehouse"

        /// <summary>Selected Product Size "My Warehouse"</summary>
        private string? _SelectedProductSize;

        /// <summary>Selected Product Size "My Warehouse"</summary>

        public string? SelectedProductSize { get => _SelectedProductSize; set => Set(ref _SelectedProductSize, value); }

        #endregion
        #region SelectedProductExpirationData: - Selected Product Expiration Data "My Warehouse"

        /// <summary>Selected Product Expiration Data "My Warehouse"</summary>
        private string? _SelectedProductExpirationData;

        /// <summary>Selected Product Expiration Data "My Warehouse"</summary>

        public string? SelectedProductExpirationData { get => _SelectedProductExpirationData; set => Set(ref _SelectedProductExpirationData, value); }

        #endregion
        #region SelectedProductPurchaseCost: - Selected Product Purchase Cost "My Warehouse"

        /// <summary>Selected Product Purchase Cost "My Warehouse"</summary>
        private string? _SelectedProductPurchaseCost;

        /// <summary>Selected Product Purchase Cost "My Warehouse"</summary>

        public string? SelectedProductPurchaseCost { get => _SelectedProductPurchaseCost; set => Set(ref _SelectedProductPurchaseCost, value); }

        #endregion
        #region SelectedProductLocation: - Selected Product Location "My Warehouse"

        /// <summary>Selected Product Location "My Warehouse"</summary>
        private string? _SelectedProductLocation;

        /// <summary>Selected Product Location "My Warehouse"</summary>

        public string? SelectedProductLocation { get => _SelectedProductLocation; set => Set(ref _SelectedProductLocation, value); }

        #endregion
        #region SelectedProductReceiptDate: - Selected Product Receipt Date "My Warehouse"

        /// <summary>Selected Product Receipt Date "My Warehouse"</summary>
        private string? _SelectedProductReceiptDate;

        /// <summary>Selected Product Receipt Date "My Warehouse"</summary>

        public string? SelectedProductReceiptDate { get => _SelectedProductReceiptDate; set => Set(ref _SelectedProductReceiptDate, value); }

        #endregion
        #region SelectedProductOrderNumber: - Selected Product Order Number "My Warehouse"

        /// <summary>Selected Product Order Number "My Warehouse"</summary>
        private string? _SelectedProductOrderNumber;

        /// <summary>Selected Product Order Number "My Warehouse"</summary>

        public string? SelectedProductOrderNumber { get => _SelectedProductOrderNumber; set => Set(ref _SelectedProductOrderNumber, value); }

        #endregion
        #region SelectedProductNote: - Selected Product Note "My Warehouse"

        /// <summary>Selected Product Note "My Warehouse"</summary>
        private string? _SelectedProductNote;

        /// <summary>Selected Product Note "My Warehouse"</summary>

        public string? SelectedProductNote { get => _SelectedProductNote; set => Set(ref _SelectedProductNote, value); }

        #endregion

        #region TextLabelEventLogMyWarehouseTabControlWarehouseWindow: - Text Of Event Log In MyWarehouse TabControl In Warehouse Window

        /// <summary>Text Of Event Log In MyWarehouse TabControl In Warehouse Window</summary>
        private string? _TextLabelEventLogMyWarehouseTabControlWarehouseWindow;

        /// <summary>Text Of Event Log In MyWarehouse TabControl In Warehouse Window</summary>

        public string? TextLabelEventLogMyWarehouseTabControlWarehouseWindow { get => _TextLabelEventLogMyWarehouseTabControlWarehouseWindow; set => Set(ref _TextLabelEventLogMyWarehouseTabControlWarehouseWindow, value); }

        #endregion


        #endregion


        #region Commands





        #endregion

    }
}
