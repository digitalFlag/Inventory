using Inventory.Commands;
using Inventory.Models;
using Inventory.Resources.Constants;
using Inventory.ViewModels.Base;
using System.Data;
using System.Drawing;
using System.Windows.Input;

namespace Inventory.ViewModels.Warehouse
{
    public partial class WarehouseViewModel : DialogViewModel
    {
        #region Dependency Properties

        #region LoadedDataTableFromDataBaseMiniWarehouseWindow: - Loaded "DataTable" From SQL DB For "WareHouse Window" 

        /// <summary>Loaded "DataTable" From SQL DB For "WareHouse Window" </summary>
        private DataTable? _LoadedDataTableFromDataBaseMiniWarehouseWindow;

        /// <summary>Loaded "DataTable" From SQL DB For "WareHouse Window" </summary>

        public DataTable? LoadedDataTableFromDataBaseMiniWarehouseWindow { get => _LoadedDataTableFromDataBaseMiniWarehouseWindow; set => Set(ref _LoadedDataTableFromDataBaseMiniWarehouseWindow, value); }

        #endregion

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

        #region BorderColorSelectedProductSoldCostMyWarehouseControlTab: - "Border Color" Of Selected Product Sold Cost At "My Warehouse"

        /// <summary>"Border Color" Of Selected Product Sold Cost At "My Warehouse"</summary>
        private string? _BorderColorSelectedProductSoldCostMyWarehouseControlTab;

        /// <summary>"Border Color" Of Selected Product Sold Cost At "My Warehouse"</summary>

        public string? BorderColorSelectedProductSoldCostMyWarehouseControlTab { get => _BorderColorSelectedProductSoldCostMyWarehouseControlTab; set => Set(ref _BorderColorSelectedProductSoldCostMyWarehouseControlTab, value); }

        #endregion
        #region BorderColorSelectedProductSoldDateMyWarehouseControlTab: - "Border Color" Of Selected Product Sold Date At "My Warehouse"

        /// <summary>"Border Color" Of Selected Product Sold Date At "My Warehouse"</summary>
        private string? _BorderColorSelectedProductSoldDateMyWarehouseControlTab;

        /// <summary>"Border Color" Of Selected Product Sold Date At "My Warehouse"</summary>

        public string? BorderColorSelectedProductSoldDateMyWarehouseControlTab { get => _BorderColorSelectedProductSoldDateMyWarehouseControlTab; set => Set(ref _BorderColorSelectedProductSoldDateMyWarehouseControlTab, value); }

        #endregion
        #region BorderColorSelectedProductCustomerIdMyWarehouseControlTab: - "Border Color" Of Selected Product Customer Id At "My Warehouse"

        /// <summary>"Border Color" Of Selected Product Customer Id At "My Warehouse"</summary>
        private string? _BorderColorSelectedProductCustomerIdMyWarehouseControlTab;

        /// <summary>"Border Color" Of Selected Product Customer Id At "My Warehouse"</summary>

        public string? BorderColorSelectedProductCustomerIdMyWarehouseControlTab { get => _BorderColorSelectedProductCustomerIdMyWarehouseControlTab; set => Set(ref _BorderColorSelectedProductCustomerIdMyWarehouseControlTab, value); }

        #endregion


        #region IconSoldCostChangeValue: - Value Of Icom "Sold Cost" When Value Is Changing

        /// <summary>Value Of Icom "Sold Cost" When Value Is Changing</summary>
        private string? _IconSoldCostChangeValue;

        /// <summary>Value Of Icom "Sold Cost" When Value Is Changing</summary>

        public string? IconSoldCostChangeValue { get => _IconSoldCostChangeValue; set => Set(ref _IconSoldCostChangeValue, value); }

        #endregion
        #region IconSoldCostColorSendToSoldProducts: - Color Of Icon "Sold Cost" At My Warehouse Products Panel

        /// <summary>Color Of Icon "Sold Cost" At My Warehouse Products Panel</summary>
        private string? _IconSoldCostColorSendToSoldProducts;

        /// <summary>Color Of Icon "Sold Cost" At My Warehouse Products Panel</summary>

        public string? IconSoldCostColorSendToSoldProducts { get => _IconSoldCostColorSendToSoldProducts; set => Set(ref _IconSoldCostColorSendToSoldProducts, value); }

        #endregion
        #region IconSoldDateChangeValue: - Value Of Icon "Sold Date" When Value Is Changing

        /// <summary>Value Of Icon "Sold Date" When Value Is Changing</summary>
        private string? _IconSoldDateChangeValue;

        /// <summary>Value Of Icon "Sold Date" When Value Is Changing</summary>

        public string? IconSoldDateChangeValue { get => _IconSoldDateChangeValue; set => Set(ref _IconSoldDateChangeValue, value); }

        #endregion
        #region IconSoldDateColorSendToSoldProducts: - Color Of Icon "Sold Date" At My Warehouse Products Panel

        /// <summary>Color Of Icon "Sold Date" At My Warehouse Products Panel</summary>
        private string? _IconSoldDateColorSendToSoldProducts;

        /// <summary>Color Of Icon "Sold Date" At My Warehouse Products Panel</summary>

        public string? IconSoldDateColorSendToSoldProducts { get => _IconSoldDateColorSendToSoldProducts; set => Set(ref _IconSoldDateColorSendToSoldProducts, value); }

        #endregion
        #region IconCustomerIdChangeValue: - value Of Icon "Customer Id" When Value Is Changing

        /// <summary>value Of Icon "Customer Id" When Value Is Changing</summary>
        private string? _IconCustomerIdChangeValue;

        /// <summary>value Of Icon "Customer Id" When Value Is Changing</summary>

        public string? IconCustomerIdChangeValue { get => _IconCustomerIdChangeValue; set => Set(ref _IconCustomerIdChangeValue, value); }

        #endregion
        #region IconCustomerIdColorSendToSoldProducts: - Color Of Icon "Customer Id" At My Warehouse Products Panel

        /// <summary>Color Of Icon "Customer Id" At My Warehouse Products Panel</summary>
        private string? _IconCustomerIdColorSendToSoldProducts;

        /// <summary>Color Of Icon "Customer Id" At My Warehouse Products Panel</summary>

        public string? IconCustomerIdColorSendToSoldProducts { get => _IconCustomerIdColorSendToSoldProducts; set => Set(ref _IconCustomerIdColorSendToSoldProducts, value); }

        #endregion


        #region ButtonCaptionReWriteWareHouseProduct: - Button Caption "ReWrite Data" In My WareHouse Products

        /// <summary>Button Caption "ReWrite Data" In My WareHouse Products</summary>
        private string? _ButtonCaptionReWriteWareHouseProduct;

        /// <summary>Button Caption "ReWrite Data" In My WareHouse Products</summary>

        public string? ButtonCaptionReWriteWareHouseProduct { get => _ButtonCaptionReWriteWareHouseProduct; set => Set(ref _ButtonCaptionReWriteWareHouseProduct, value); }

        #endregion
        #region ButtonCaptionSoldOutWarehouseProduct: - Button Caption "Sold Out" In My WareHouse Products

        /// <summary>Button Caption "Sold Out" In My WareHouse Products</summary>
        private string? _ButtonCaptionSoldOutWarehouseProduct;

        /// <summary>Button Caption "Sold Out" In My WareHouse Products</summary>

        public string? ButtonCaptionSoldOutWarehouseProduct { get => _ButtonCaptionSoldOutWarehouseProduct; set => Set(ref _ButtonCaptionSoldOutWarehouseProduct, value); }

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
        #region SelectedProductSoldCost: - Selected Product Sold Cost "My Warehouse"

        /// <summary>Selected Product Sold Cost "My Warehouse"</summary>
        private string? _SelectedProductSoldCost;

        /// <summary>Selected Product Sold Cost "My Warehouse"</summary>

        public string? SelectedProductSoldCost { get => _SelectedProductSoldCost; set => Set(ref _SelectedProductSoldCost, value); }

        #endregion
        #region SelectedProductSoldDate: - Selected Product Sold Date "My Warehouse"

        /// <summary>Selected Product Sold Date "My Warehouse"</summary>
        private string? _SelectedProductSoldDate;

        /// <summary>Selected Product Sold Date "My Warehouse"</summary>

        public string? SelectedProductSoldDate { get => _SelectedProductSoldDate; set => Set(ref _SelectedProductSoldDate, value); }

        #endregion
        #region SelectedProductCustomerId: - Selected Product "Customer Id"

        /// <summary>Selected Product "Customer Id"</summary>
        private string? _SelectedProductCustomerId;

        /// <summary>Selected Product "Customer Id"</summary>

        public string? SelectedProductCustomerId { get => _SelectedProductCustomerId; set => Set(ref _SelectedProductCustomerId, value); }

        #endregion

        #region AllWarehouseProducts: - All "My Warehouse Products" Lodaded From DB

        /// <summary>All "My Warehouse Products" Lodaded From DB</summary>
        private IEnumerable<WarehouseProduct>? _AllWarehouseProducts;

        /// <summary>All "My Warehouse Products" Lodaded From DB</summary>

        public IEnumerable<WarehouseProduct>? AllWarehouseProducts { get => _AllWarehouseProducts; set => Set(ref _AllWarehouseProducts, value); }

        #endregion
        #region FilteredWarehouseProducts: - "My Warehouse Products" After Filtering

        /// <summary>"My Warehouse Products" After Filtering</summary>
        private List<WarehouseProduct>? _FilteredWarehouseProducts;

        /// <summary>"My Warehouse Products" After Filtering</summary>

        public List<WarehouseProduct>? FilteredWarehouseProducts { get => _FilteredWarehouseProducts; set => Set(ref _FilteredWarehouseProducts, value); }

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

        #region TabItemSelectedProductMyWarehouseItem: - Name Of TabItem "Selected Product" In Panel My Warehouse Products

        /// <summary>Name Of TabItem "Selected Product" In Panel My Warehouse Products</summary>
        private string? _TabItemSelectedProductMyWarehouseItem;

        /// <summary>Name Of TabItem "Selected Product" In Panel My Warehouse Products</summary>

        public string? TabItemSelectedProductMyWarehouseItem { get => _TabItemSelectedProductMyWarehouseItem; set => Set(ref _TabItemSelectedProductMyWarehouseItem, value); }

        #endregion
        #region TabItemFiltersMyWarehouseItem: - Name Of TabItem "Filters" In Panel My Warehouse Products

        /// <summary>Name Of TabItem "Filters" In Panel My Warehouse Products</summary>
        private string? _TabItemFiltersMyWarehouseItem;

        /// <summary>Name Of TabItem "Filters" In Panel My Warehouse Products</summary>

        public string? TabItemFiltersMyWarehouseItem { get => _TabItemFiltersMyWarehouseItem; set => Set(ref _TabItemFiltersMyWarehouseItem, value); }

        #endregion

        //Filter Tab Control
        #region IconFiltersTabControlInMyWarehouseItemValue: - Value Of Icon "Filters" Tab Control -> My WareHouse Item

        /// <summary>Value Of Icon "Filters" Tab Control -> My WareHouse Item</summary>
        private string? _IconFiltersTabControlInMyWarehouseItemValue;

        /// <summary>Value Of Icon "Filters" Tab Control -> My WareHouse Item</summary>

        public string? IconFiltersTabControlInMyWarehouseItemValue { get => _IconFiltersTabControlInMyWarehouseItemValue; set => Set(ref _IconFiltersTabControlInMyWarehouseItemValue, value); }

        #endregion
        #region FilterTittleForMyWarehouseProducts: - Filter "Tittle" For My Warehouse Products 

        /// <summary>Filter "Tittle" For My Warehouse Products </summary>
        private string? _FilterTittleForMyWarehouseProducts;

        /// <summary>Filter "Tittle" For My Warehouse Products </summary>

        public string? FilterTittleForMyWarehouseProducts { get => _FilterTittleForMyWarehouseProducts; set => Set(ref _FilterTittleForMyWarehouseProducts, value); }

        #endregion
        #region FilterPropertyForMyWarehouseProducts: - Folter "Property" For My Warehouse Products

        /// <summary>Folter "Property" For My Warehouse Products</summary>
        private string? _FilterPropertyForMyWarehouseProducts;

        /// <summary>Folter "Property" For My Warehouse Products</summary>

        public string? FilterPropertyForMyWarehouseProducts { get => _FilterPropertyForMyWarehouseProducts; set => Set(ref _FilterPropertyForMyWarehouseProducts, value); }

        #endregion
        #region FilterExpirationDateStartForMyWarehouseProducts: - Filter "Expitation Date Start" For My Warehouse Products

        /// <summary>Filter "Expitation Date Start" For My Warehouse Products</summary>
        private string? _FilterExpirationDateStartForMyWarehouseProducts;

        /// <summary>Filter "Expitation Date Start" For My Warehouse Products</summary>

        public string? FilterExpirationDateStartForMyWarehouseProducts { get => _FilterExpirationDateStartForMyWarehouseProducts; set => Set(ref _FilterExpirationDateStartForMyWarehouseProducts, value); }

        #endregion
        #region SelectedDateExpirationDateStartFilterMyWarehouseProducts: - Selected Date For DataPicker "Expitation Date Start" Filter For My Warehouse Products

        /// <summary>Selected Date For DataPicker "Expitation Date Start" Filter For My Warehouse Products</summary>
        private DateTime? _SelectedDateExpirationDateStartFilterMyWarehouseProducts;

        /// <summary>Selected Date For DataPicker "Expitation Date Start" Filter For My Warehouse Products</summary>

        public DateTime? SelectedDateExpirationDateStartFilterMyWarehouseProducts { get => _SelectedDateExpirationDateStartFilterMyWarehouseProducts; set => Set(ref _SelectedDateExpirationDateStartFilterMyWarehouseProducts, value); }

        #endregion
        #region FilterExpirationDateStopForMyWarehouseProducts: - Filter "Expiration Date Stop" For My Warehouse Products

        /// <summary>Filter "Expiration Date Stop" For My Warehouse Products</summary>
        private string? _FilterExpirationDateStopForMyWarehouseProducts;

        /// <summary>Filter "Expiration Date Stop" For My Warehouse Products</summary>

        public string? FilterExpirationDateStopForMyWarehouseProducts { get => _FilterExpirationDateStopForMyWarehouseProducts; set => Set(ref _FilterExpirationDateStopForMyWarehouseProducts, value); }

        #endregion
        #region SelectedDateExpirationDateStopFilterMyWarehouseProducts: - Selected Date For DataPicker "Expiration Date Stop" Filter For My Warehouse Products

        /// <summary>Selected Date For DataPicker "Expiration Date Stop" Filter For My Warehouse Products</summary>
        private DateTime? _SelectedDateExpirationDateStopFilterMyWarehouseProducts;

        /// <summary>Selected Date For DataPicker "Expiration Date Stop" Filter For My Warehouse Products</summary>

        public DateTime? SelectedDateExpirationDateStopFilterMyWarehouseProducts { get => _SelectedDateExpirationDateStopFilterMyWarehouseProducts; set => Set(ref _SelectedDateExpirationDateStopFilterMyWarehouseProducts, value); }

        #endregion
        #region FilterPurchaseCostStartForMyWarehouseProducts: - Filter "Purchase Cost Start" For My Warehouse Products 

        /// <summary>Filter "Purchase Cost Start" For My Warehouse Products </summary>
        private string? _FilterPurchaseCostStartForMyWarehouseProducts;

        /// <summary>Filter "Purchase Cost Start" For My Warehouse Products </summary>

        public string? FilterPurchaseCostStartForMyWarehouseProducts { get => _FilterPurchaseCostStartForMyWarehouseProducts; set => Set(ref _FilterPurchaseCostStartForMyWarehouseProducts, value); }

        #endregion
        #region FilterPurchaseCostStopForMyWarehouseProducts: - Filter "Purchase Cost Stop" For My Warehouse Products

        /// <summary>Filter "Purchase Cost Stop" For My Warehouse Products</summary>
        private string? _FilterPurchaseCostStopForMyWarehouseProducts;

        /// <summary>Filter "Purchase Cost Stop" For My Warehouse Products</summary>

        public string? FilterPurchaseCostStopForMyWarehouseProducts { get => _FilterPurchaseCostStopForMyWarehouseProducts; set => Set(ref _FilterPurchaseCostStopForMyWarehouseProducts, value); }

        #endregion
        #region FilterLocationForMyWarehouseProducts: - Filter "Location" For My Warehouse Products

        /// <summary>Filter "Location" For My Warehouse Products</summary>
        private string? _FilterLocationForMyWarehouseProducts;

        /// <summary>Filter "Location" For My Warehouse Products</summary>

        public string? FilterLocationForMyWarehouseProducts { get => _FilterLocationForMyWarehouseProducts; set => Set(ref _FilterLocationForMyWarehouseProducts, value); }

        #endregion
        #region ListOfComboBoxLocationPossibleValues: - Possible Items Values Of Combo Box "Location" In Filter Panel My Warehouse Products 

        /// <summary>Possible Items Values Of Combo Box "Location" In Filter Panel My Warehouse Products </summary>
        private List<string>? _ListOfComboBoxLocationPossibleValues;

        /// <summary>Possible Items Values Of Combo Box "Location" In Filter Panel My Warehouse Products </summary>

        public List<string>? ListOfComboBoxLocationPossibleValues { get => _ListOfComboBoxLocationPossibleValues; set => Set(ref _ListOfComboBoxLocationPossibleValues, value); }

        #endregion
        #region SelectedItemOfComboBoxLocationInFilterPanelMyWarehouseProducts: - Selectrd Item Of ComboBox "Location" In Filter Panel In My Warehouse Products Item

        /// <summary>Selectrd Item Of ComboBox "Location" In Filter Panel In My Warehouse Products Item</summary>
        private string? _SelectedItemOfComboBoxLocationInFilterPanelMyWarehouseProducts;

        /// <summary>Selectrd Item Of ComboBox "Location" In Filter Panel In My Warehouse Products Item</summary>

        public string? SelectedItemOfComboBoxLocationInFilterPanelMyWarehouseProducts { get => _SelectedItemOfComboBoxLocationInFilterPanelMyWarehouseProducts; set => Set(ref _SelectedItemOfComboBoxLocationInFilterPanelMyWarehouseProducts, value); }

        #endregion
        #region SelectedDateReceiptDateStartFilterMyWarehouseProducts: - Selected Date For DataPicker "Receipt Date Start" Filter For My Warehouse Products

        /// <summary>Selected Date For DataPicker "Receipt Date Start" Filter For My Warehouse Products</summary>
        private DateTime? _SelectedDateReceiptDateStartFilterMyWarehouseProducts;

        /// <summary>Selected Date For DataPicker "Receipt Date Start" Filter For My Warehouse Products</summary>

        public DateTime? SelectedDateReceiptDateStartFilterMyWarehouseProducts { get => _SelectedDateReceiptDateStartFilterMyWarehouseProducts; set => Set(ref _SelectedDateReceiptDateStartFilterMyWarehouseProducts, value); }

        #endregion
        #region SelectedDateReceiptDateStopFilterMyWarehouseProducts: - Selected Date For DataPicker "Receipt Date Stop" Filter For My Warehouse Products

        /// <summary>Selected Date For DataPicker "Receipt Date Stop" Filter For My Warehouse Products</summary>
        private DateTime? _SelectedDateReceiptDateStopFilterMyWarehouseProducts;

        /// <summary>Selected Date For DataPicker "Receipt Date Stop" Filter For My Warehouse Products</summary>

        public DateTime? SelectedDateReceiptDateStopFilterMyWarehouseProducts { get => _SelectedDateReceiptDateStopFilterMyWarehouseProducts; set => Set(ref _SelectedDateReceiptDateStopFilterMyWarehouseProducts, value); }

        #endregion
        #region FilterReceiptDateStartForMyWarehouseProducts: - Filter "Receipt Date Start" For My Warehouse Products

        /// <summary>Filter "Receipt Date Start" For My Warehouse Products</summary>
        private string? _FilterReceiptDateStartForMyWarehouseProducts;

        /// <summary>Filter "Receipt Date Start" For My Warehouse Products</summary>

        public string? FilterReceiptDateStartForMyWarehouseProducts { get => _FilterReceiptDateStartForMyWarehouseProducts; set => Set(ref _FilterReceiptDateStartForMyWarehouseProducts, value); }

        #endregion
        #region FilterReceiptDateStopForMyWarehouseProducts: - Filter "Receipt Date Stop" For My Warehouse Products

        /// <summary>Filter "Receipt Date Stop" For My Warehouse Products</summary>
        private string? _FilterReceiptDateStopForMyWarehouseProducts;

        /// <summary>Filter "Receipt Date Stop" For My Warehouse Products</summary>

        public string? FilterReceiptDateStopForMyWarehouseProducts { get => _FilterReceiptDateStopForMyWarehouseProducts; set => Set(ref _FilterReceiptDateStopForMyWarehouseProducts, value); }

        #endregion
        #region ListOfComboBoxOrderNumberPossibleValues: - Possible Items Values Of Combo Box "Order Number" In Filter Panel My Warehouse Products 

        /// <summary>Possible Items Values Of Combo Box "Order Number" In Filter Panel My Warehouse Products </summary>
        private List<string>? _ListOfComboBoxOrderNumberPossibleValues;

        /// <summary>Possible Items Values Of Combo Box "Order Number" In Filter Panel My Warehouse Products </summary>

        public List<string>? ListOfComboBoxOrderNumberPossibleValues { get => _ListOfComboBoxOrderNumberPossibleValues; set => Set(ref _ListOfComboBoxOrderNumberPossibleValues, value); }

        #endregion
        #region FilterOrderNumberForMyWarehouseProducts: - Filter "Order Number" For My Warehouse Products

        /// <summary>Filter "Order Number" For My Warehouse Products</summary>
        private string? _FilterOrderNumberForMyWarehouseProducts;

        /// <summary>Filter "Order Number" For My Warehouse Products</summary>

        public string? FilterOrderNumberForMyWarehouseProducts { get => _FilterOrderNumberForMyWarehouseProducts; set => Set(ref _FilterOrderNumberForMyWarehouseProducts, value); }

        #endregion
        #region SelectedItemOfComboBoxOrderNumberInFilterPanelMyWarehouseProducts: - Selectrd Item Of ComboBox "Order Number" In Filter Panel In My Warehouse Products Item

        /// <summary>Selectrd Item Of ComboBox "Order Number" In Filter Panel In My Warehouse Products Item</summary>
        private string? _SelectedItemOfComboBoxOrderNumberInFilterPanelMyWarehouseProducts;

        /// <summary>Selectrd Item Of ComboBox "Order Number" In Filter Panel In My Warehouse Products Item</summary>

        public string? SelectedItemOfComboBoxOrderNumberInFilterPanelMyWarehouseProducts { get => _SelectedItemOfComboBoxOrderNumberInFilterPanelMyWarehouseProducts; set => Set(ref _SelectedItemOfComboBoxOrderNumberInFilterPanelMyWarehouseProducts, value); }

        #endregion
        #region FilterNoteForMyWarehouseProducts: - Folter "Note" For My Warehouse Products

        /// <summary>Folter "Note" For My Warehouse Products</summary>
        private string? _FilterNoteForMyWarehouseProducts;

        /// <summary>Folter "Note" For My Warehouse Products</summary>

        public string? FilterNoteForMyWarehouseProducts { get => _FilterNoteForMyWarehouseProducts; set => Set(ref _FilterNoteForMyWarehouseProducts, value); }

        #endregion
        //Statistic
        #region TabItemStatisticMyWarehouseItem: - Name Of TabItem "Statistic" In Panel My Warehouse Products

        /// <summary>Name Of TabItem "Statistic" In Panel My Warehouse Products</summary>
        private string? _TabItemStatisticMyWarehouseItem;

        /// <summary>Name Of TabItem "Statistic" In Panel My Warehouse Products</summary>

        public string? TabItemStatisticMyWarehouseItem { get => _TabItemStatisticMyWarehouseItem; set => Set(ref _TabItemStatisticMyWarehouseItem, value); }

        #endregion
        #region TextValueTotalNumberOfProducts: - Value Of Text "Total Number Of Products"

        /// <summary>Value Of Text "Total Number Of Products"</summary>
        private string? _TextValueTotalNumberOfProducts;

        /// <summary>Value Of Text "Total Number Of Products"</summary>

        public string? TextValueTotalNumberOfProducts { get => _TextValueTotalNumberOfProducts; set => Set(ref _TextValueTotalNumberOfProducts, value); }

        #endregion
        #region ValueOfTotalNumberOfProductsForMyWarehouseProducts: - Value Of "Total Number Of Products" In "Statistics" TabItem In My Warehouse Panel

        /// <summary>Value Of "Total Number Of Products" In "Statistics" TabItem In My Warehouse Panel</summary>
        private string? _ValueOfTotalNumberOfProductsForMyWarehouseProducts;

        /// <summary>Value Of "Total Number Of Products" In "Statistics" TabItem In My Warehouse Panel</summary>

        public string? ValueOfTotalNumberOfProductsForMyWarehouseProducts { get => _ValueOfTotalNumberOfProductsForMyWarehouseProducts; set => Set(ref _ValueOfTotalNumberOfProductsForMyWarehouseProducts, value); }

        #endregion



        #endregion


        #region Commands


        #region Command LoadMyWarehouseProductsFromDbCommand: - Load "My Warehouse Products" Data From DB 

        /// <summary>Load "My Warehouse Products" Data From DB </summary>
        private LambdaCommand? _LoadMyWarehouseProductsFromDbCommand;

        /// <summary>Load "My Warehouse Products" Data From DB </summary>
        public ICommand LoadMyWarehouseProductsFromDbCommand => _LoadMyWarehouseProductsFromDbCommand ??= new(OnLoadMyWarehouseProductsFromDbCommandExecuted);

        /// <summary>Логика выполнения - Load "My Warehouse Products" Data From DB </summary>

        private void OnLoadMyWarehouseProductsFromDbCommandExecuted(object? p)
        {
            var dbSettings = new DBSettings
            {
                Server = ConnectionOptions.dbServer,
                Port = ConnectionOptions.dbPort,
                Name = ConnectionOptions.dbName,
                UserId = ConnectionOptions.userId,
                Password = ConnectionOptions.password
            };

            if (_DataBase is null)
            {
                return;
            }

            string table = DbTables.WarehouseProducts;

            LoadedDataTableFromDataBaseMiniWarehouseWindow = _DataBase.GetData(dbSettings, table);

            AllWarehouseProducts = LoadedDataTableFromDataBaseMiniWarehouseWindow.AsEnumerable().Select(row => new Models.WarehouseProduct
            {
                Id = Convert.ToInt32(row[DbTableWarehouseProducts.propertyId]),
                Tittle = Convert.ToString(row[DbTableWarehouseProducts.propertyTittle]),
                Property = Convert.ToString(row[DbTableWarehouseProducts.propertyProperty]),
                Size = Convert.ToString(row[DbTableWarehouseProducts.propertySize]),
                ExpirationDate = Convert.ToDateTime(row[DbTableWarehouseProducts.propertyExpirationDate]),
                Location = Convert.ToString(row[DbTableWarehouseProducts.propertyLocation]),
                PurchaseCost = Convert.ToInt16(row[DbTableWarehouseProducts.propertyPurchaseCost]),
                OrderNumber = Convert.ToString(row[DbTableWarehouseProducts.propertyOrderNumber]),
                ReceiptDate = Convert.ToDateTime(row[DbTableWarehouseProducts.propertyReceiptDate]),
                Note = Convert.ToString(row[DbTableWarehouseProducts.propertyNote]),
            });





        }

        #endregion

        #region Command RefreshConnectionToDataBaseWarhouseWindowCommand: - Refresh Connection To BD With Products

        /// <summary>Refresh Connection To BD With Products</summary>
        private LambdaCommand? _RefreshConnectionToDataBaseWarhouseWindowCommand;

        /// <summary>Refresh Connection To BD With Products</summary>
        public ICommand RefreshConnectionToDataBaseWarhouseWindowCommand => _RefreshConnectionToDataBaseWarhouseWindowCommand ??= new(OnRefreshConnectionToDataBaseWarhouseWindowCommandExecuted);

        /// <summary>Логика выполнения - Refresh Connection To BD With Products</summary>

        private void OnRefreshConnectionToDataBaseWarhouseWindowCommandExecuted(object? p)
        {
            OnLoadMyWarehouseProductsFromDbCommandExecuted(true);
            OnFilterMyWarehouseProductsCommandExecuted(true);

            WarehouseEventTextValue = $"Информация о продукции на Мини-Складе из базы \"{ConnectionOptions.dbName}\" загружена.";
            WarehouseEventIconValue = Icons.Name.Regular_CircleCheck.ToString();
            WarehouseEventIconColor = Color.LimeGreen.Name;


            SelectedProductId = string.Empty;
            SelectedProductTittle = string.Empty;
            SelectedProductProperty = string.Empty;
            SelectedProductSize = string.Empty;
            SelectedProductExpirationData = string.Empty;
            SelectedProductPurchaseCost = string.Empty;
            SelectedProductLocation = string.Empty;
            SelectedProductReceiptDate = string.Empty;
            SelectedProductOrderNumber = string.Empty;
            SelectedProductNote = string.Empty;

            WarehouseEventTextValue = "Данные о продукции обновлены.";
            WarehouseEventIconValue = Icons.Name.Regular_CircleCheck.ToString();
            WarehouseEventIconColor = Color.LimeGreen.Name;


            OnPropertyChanged();
        }

        #endregion

        #region Command FilterMyWarehouseProductsCommand: - Filter "My Warehouse Products" By Seted Parametrs

        /// <summary>Filter "My Warehouse Products" By Seted Parametrs</summary>
        private LambdaCommand? _FilterMyWarehouseProductsCommand;

        /// <summary>Filter "My Warehouse Products" By Seted Parametrs</summary>
        public ICommand FilterMyWarehouseProductsCommand => _FilterMyWarehouseProductsCommand ??= new(OnFilterMyWarehouseProductsCommandExecuted);

        /// <summary>Логика выполнения - Filter "My Warehouse Products" By Seted Parametrs</summary>

        private void OnFilterMyWarehouseProductsCommandExecuted(object? p)
        {
            if (AllWarehouseProducts is null)
            {
                WarehouseEventTextValue = "Список \"Загруженных продуктов\" равен NULL!";
                WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                WarehouseEventIconColor = Color.Red.Name;

                return;
            }

            if (!AllWarehouseProducts.Any())
            {
                WarehouseEventTextValue = "Список \"Загруженных продуктов\" не содержит элементы.";
                WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                WarehouseEventIconColor = Color.Red.Name;

                return;
            }

            IconFiltersTabControlInMyWarehouseItemValue = Icons.Name.Solid_FilterCircleXmark.ToString();

            List <WarehouseProduct> resultList = [];

            foreach (WarehouseProduct product in AllWarehouseProducts)
            {
                resultList.Add(product);
            }
            FilteredWarehouseProducts = AllWarehouseProducts.ToList();

            //Filtering By Products Tittle
            if (!string.IsNullOrEmpty(FilterTittleForMyWarehouseProducts))
            {
                IconFiltersTabControlInMyWarehouseItemValue = Icons.Name.Solid_Filter.ToString();

                FilteredWarehouseProducts = [];
                foreach (WarehouseProduct product in resultList)
                {
                    if (product.Tittle.Contains(FilterTittleForMyWarehouseProducts))
                    {
                        FilteredWarehouseProducts.Add(product);
                    }
                }

                if (FilteredWarehouseProducts.Count == 0)
                {
                    WarehouseEventTextValue = $"Список не содержит продуктов с указанным \"Наименованием\".";
                    WarehouseEventIconValue = Icons.Name.Solid_CircleExclamation.ToString();
                    WarehouseEventIconColor = Color.Goldenrod.Name;
                    OnCalculateStatisticsMyWarehouseProductsCommandExecuted(true);

                    return;
                }

                resultList.Clear();
                foreach (WarehouseProduct product in FilteredWarehouseProducts)
                {
                    resultList.Add(product);
                }
            }

            //Filtering By Products Property
            if (!string.IsNullOrEmpty(FilterPropertyForMyWarehouseProducts))
            {
                IconFiltersTabControlInMyWarehouseItemValue = Icons.Name.Solid_Filter.ToString();

                FilteredWarehouseProducts = [];
                foreach (WarehouseProduct product in resultList)
                {
                    if (product.Property.Contains(FilterPropertyForMyWarehouseProducts))
                    {
                        FilteredWarehouseProducts.Add(product);
                    }
                }

                if (FilteredWarehouseProducts.Count == 0)
                {
                    WarehouseEventTextValue = $"Список не содержит продуктов с указанным \"Типом\".";
                    WarehouseEventIconValue = Icons.Name.Solid_CircleExclamation.ToString();
                    WarehouseEventIconColor = Color.Goldenrod.Name;
                    OnCalculateStatisticsMyWarehouseProductsCommandExecuted(true);

                    return;
                }

                resultList.Clear();
                foreach (WarehouseProduct product in FilteredWarehouseProducts)
                {
                    resultList.Add(product);
                }
            }

            //Filtering By Expiration Date Start
            if (!string.IsNullOrEmpty(FilterExpirationDateStartForMyWarehouseProducts))
            {
                IconFiltersTabControlInMyWarehouseItemValue = Icons.Name.Solid_Filter.ToString();

                FilteredWarehouseProducts = [];

                if (FilterExpirationDateStartForMyWarehouseProducts.Length != 7)
                {
                    WarehouseEventTextValue = $"Значение фмльтра \"Срок годности От:\" задано некорректно (мм.ГГГГ).";
                    WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                    WarehouseEventIconColor = Color.Red.Name;

                    return;
                }

                DateTime dt;
                if (!DateTime.TryParse("01." + FilterExpirationDateStartForMyWarehouseProducts, out dt))
                {
                    WarehouseEventTextValue = $"Значение фмльтра \"Срок годности От:\" задано некорректно (мм.ГГГГ).";
                    WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                    WarehouseEventIconColor = Color.Red.Name;

                    return;
                }
                else
                {
                    foreach (WarehouseProduct product in resultList)
                    {
                        if (product.ExpirationDate >= dt)
                        {
                            FilteredWarehouseProducts.Add(product);
                        }
                    }

                    if (FilteredWarehouseProducts.Count == 0)
                    {
                        WarehouseEventTextValue = $"Список не содержит продуктов с указанным параметрами фильтра \"Срок годности От:\".";
                        WarehouseEventIconValue = Icons.Name.Solid_CircleExclamation.ToString();
                        WarehouseEventIconColor = Color.Goldenrod.Name;
                        OnCalculateStatisticsMyWarehouseProductsCommandExecuted(true);

                        return;
                    }

                    resultList.Clear();
                    foreach (WarehouseProduct product in FilteredWarehouseProducts)
                    {
                        resultList.Add(product);
                    }

                }
            }
            //Filtering By Expiration Date Stop
            if (!string.IsNullOrEmpty(FilterExpirationDateStopForMyWarehouseProducts))
            {
                IconFiltersTabControlInMyWarehouseItemValue = Icons.Name.Solid_Filter.ToString();

                FilteredWarehouseProducts = [];

                if (FilterExpirationDateStopForMyWarehouseProducts.Length != 7)
                {
                    WarehouseEventTextValue = $"Значение фмльтра \"Срок годности До:\" задано некорректно (мм.ГГГГ).";
                    WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                    WarehouseEventIconColor = Color.Red.Name;

                    return;
                }

                DateTime dt;
                if (!DateTime.TryParse("01." + FilterExpirationDateStopForMyWarehouseProducts, out dt))
                {
                    WarehouseEventTextValue = $"Значение фмльтра \"Срок годности До:\" задано некорректно (мм.ГГГГ).";
                    WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                    WarehouseEventIconColor = Color.Red.Name;

                    return;
                }
                else
                {
                    foreach (WarehouseProduct product in resultList)
                    {
                        if (product.ExpirationDate <= dt)
                        {
                            FilteredWarehouseProducts.Add(product);
                        }
                    }

                    if (FilteredWarehouseProducts.Count == 0)
                    {
                        WarehouseEventTextValue = $"Список не содержит продуктов с указанным параметрами фильтра \"Срок годности До:\".";
                        WarehouseEventIconValue = Icons.Name.Solid_CircleExclamation.ToString();
                        WarehouseEventIconColor = Color.Goldenrod.Name;
                        OnCalculateStatisticsMyWarehouseProductsCommandExecuted(true);

                        return;
                    }

                    resultList.Clear();
                    foreach (WarehouseProduct product in FilteredWarehouseProducts)
                    {
                        resultList.Add(product);
                    }

                }
            }

            //Filtering By Purchase Cost Start
            if (!string.IsNullOrEmpty(FilterPurchaseCostStartForMyWarehouseProducts))
            {
                IconFiltersTabControlInMyWarehouseItemValue = Icons.Name.Solid_Filter.ToString();

                FilteredWarehouseProducts = [];

                foreach (char c in FilterPurchaseCostStartForMyWarehouseProducts)
                {
                    if (!char.IsDigit(c))
                    {
                        WarehouseEventTextValue = $"Значение фмльтра \"Стоимость покупки От:\" задано некорректно.";
                        WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                        WarehouseEventIconColor = Color.Red.Name;

                        return;
                    }
                }

                if (FilterPurchaseCostStartForMyWarehouseProducts[0] == 0)
                {
                    WarehouseEventTextValue = $"Значение фмльтра \"Стоимость покупки От:\" задано некорректно.";
                    WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                    WarehouseEventIconColor = Color.Red.Name;

                    return;
                }

                int price = Convert.ToInt32(FilterPurchaseCostStartForMyWarehouseProducts);

                foreach (WarehouseProduct product in resultList)
                {
                    if (product.PurchaseCost >= price)
                    {
                        FilteredWarehouseProducts.Add(product);
                    }
                }

                if (FilteredWarehouseProducts.Count == 0)
                {
                    WarehouseEventTextValue = $"Список не содержит продуктов с указанным параметрами фильтра \"Стоимость покупки От:\".";
                    WarehouseEventIconValue = Icons.Name.Solid_CircleExclamation.ToString();
                    WarehouseEventIconColor = Color.Goldenrod.Name;
                    OnCalculateStatisticsMyWarehouseProductsCommandExecuted(true);

                    return;
                }

                resultList.Clear();
                foreach (WarehouseProduct product in FilteredWarehouseProducts)
                {
                    resultList.Add(product);
                }

            }

            //Filtering By Purchase Cost Stop
            if (!string.IsNullOrEmpty(FilterPurchaseCostStopForMyWarehouseProducts))
            {
                IconFiltersTabControlInMyWarehouseItemValue = Icons.Name.Solid_Filter.ToString();

                FilteredWarehouseProducts = [];

                foreach (char c in FilterPurchaseCostStopForMyWarehouseProducts)
                {
                    if (!char.IsDigit(c))
                    {
                        WarehouseEventTextValue = $"Значение фмльтра \"Стоимость покупки До:\" задано некорректно.";
                        WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                        WarehouseEventIconColor = Color.Red.Name;

                        return;
                    }
                }

                if (FilterPurchaseCostStopForMyWarehouseProducts[0] == 0)
                {
                    WarehouseEventTextValue = $"Значение фмльтра \"Стоимость покупки До:\" задано некорректно.";
                    WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                    WarehouseEventIconColor = Color.Red.Name;

                    return;
                }

                int price = Convert.ToInt32(FilterPurchaseCostStopForMyWarehouseProducts);

                foreach (WarehouseProduct product in resultList)
                {
                    if (product.PurchaseCost <= price)
                    {
                        FilteredWarehouseProducts.Add(product);
                    }
                }

                if (FilteredWarehouseProducts.Count == 0)
                {
                    WarehouseEventTextValue = $"Список не содержит продуктов с указанным параметрами фильтра \"Стоимость покупки От:\".";
                    WarehouseEventIconValue = Icons.Name.Solid_CircleExclamation.ToString();
                    WarehouseEventIconColor = Color.Goldenrod.Name;
                    OnCalculateStatisticsMyWarehouseProductsCommandExecuted(true);

                    return;
                }

                resultList.Clear();
                foreach (WarehouseProduct product in FilteredWarehouseProducts)
                {
                    resultList.Add(product);
                }

            }

            //Filtering By Location
            List<string> productsLocation = [];
            foreach (WarehouseProduct wp in FilteredWarehouseProducts)
            {
                if (wp.Location is null)
                {
                    WarehouseEventTextValue = $"Значение \"Местоположения:\" продукта их отфильтрованного списка задано некорректно.";
                    WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                    WarehouseEventIconColor = Color.Red.Name;

                    break;
                }

                productsLocation.Add(wp.Location);
                productsLocation.Sort();
                ListOfComboBoxLocationPossibleValues = productsLocation.Distinct().ToList();
            }
            if (!string.IsNullOrEmpty(FilterLocationForMyWarehouseProducts))
            {
                IconFiltersTabControlInMyWarehouseItemValue = Icons.Name.Solid_Filter.ToString();

                FilteredWarehouseProducts = [];

                if (FilterLocationForMyWarehouseProducts is null)
                {
                    WarehouseEventTextValue = $"Значение фильтра \"Местоположение:\" равно NULL.";
                    WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                    WarehouseEventIconColor = Color.Red.Name;

                    return;
                }
                FilteredWarehouseProducts.AddRange(from WarehouseProduct product in resultList
                                                   where product.Location.Contains(FilterLocationForMyWarehouseProducts)
                                                   select product);

                if (FilteredWarehouseProducts.Count == 0)
                {
                    WarehouseEventTextValue = $"Список не содержит продуктов с указанным \"Местоположением\".";
                    WarehouseEventIconValue = Icons.Name.Solid_CircleExclamation.ToString();
                    WarehouseEventIconColor = Color.Goldenrod.Name;
                    OnCalculateStatisticsMyWarehouseProductsCommandExecuted(true);

                    return;
                }

                resultList.Clear();
                foreach (WarehouseProduct product in FilteredWarehouseProducts)
                {
                    resultList.Add(product);
                }
            }

            //Filtering By Receipt Date Start
            if (!string.IsNullOrEmpty(FilterReceiptDateStartForMyWarehouseProducts))
            {
                IconFiltersTabControlInMyWarehouseItemValue = Icons.Name.Solid_Filter.ToString();

                FilteredWarehouseProducts = [];

                if (FilterReceiptDateStartForMyWarehouseProducts.Length != 10)
                {
                    WarehouseEventTextValue = $"Значение фмльтра \"Дата поступления От:\" задано некорректно (дд.мм.гггг).";
                    WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                    WarehouseEventIconColor = Color.Red.Name;

                    return;
                }

                DateTime dt;
                if (!DateTime.TryParse(FilterReceiptDateStartForMyWarehouseProducts, out dt))
                {
                    WarehouseEventTextValue = $"Значение фмльтра \"Дата поступления От:\" задано некорректно (дд.мм.гггг).";
                    WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                    WarehouseEventIconColor = Color.Red.Name;

                    return;
                }
                else
                {
                    foreach (WarehouseProduct product in resultList)
                    {
                        if (product.ReceiptDate >= dt)
                        {
                            FilteredWarehouseProducts.Add(product);
                        }
                    }

                    if (FilteredWarehouseProducts.Count == 0)
                    {
                        WarehouseEventTextValue = $"Список не содержит продуктов с указанным параметрами фильтра \"Дата поступления От:\".";
                        WarehouseEventIconValue = Icons.Name.Solid_CircleExclamation.ToString();
                        WarehouseEventIconColor = Color.Goldenrod.Name;
                        OnCalculateStatisticsMyWarehouseProductsCommandExecuted(true);

                        return;
                    }

                    resultList.Clear();
                    foreach (WarehouseProduct product in FilteredWarehouseProducts)
                    {
                        resultList.Add(product);
                    }

                }
            }
            //Filtering By Receipt Date Stop
            if (!string.IsNullOrEmpty(FilterReceiptDateStopForMyWarehouseProducts))
            {
                IconFiltersTabControlInMyWarehouseItemValue = Icons.Name.Solid_Filter.ToString();

                FilteredWarehouseProducts = [];

                if (FilterReceiptDateStopForMyWarehouseProducts.Length != 10)
                {
                    WarehouseEventTextValue = $"Значение фмльтра \"Дата поступления До:\" задано некорректно (дд.мм.гггг).";
                    WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                    WarehouseEventIconColor = Color.Red.Name;

                    return;
                }

                DateTime dt;
                if (!DateTime.TryParse(FilterReceiptDateStopForMyWarehouseProducts, out dt))
                {
                    WarehouseEventTextValue = $"Значение фмльтра \"Дата поступления До:\" задано некорректно (дд.мм.гггг).";
                    WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                    WarehouseEventIconColor = Color.Red.Name;

                    return;
                }
                else
                {
                    foreach (WarehouseProduct product in resultList)
                    {
                        if (product.ReceiptDate <= dt)
                        {
                            FilteredWarehouseProducts.Add(product);
                        }
                    }

                    if (FilteredWarehouseProducts.Count == 0)
                    {
                        WarehouseEventTextValue = $"Список не содержит продуктов с указанным параметрами фильтра \"Дата поступления До:\".";
                        WarehouseEventIconValue = Icons.Name.Solid_CircleExclamation.ToString();
                        WarehouseEventIconColor = Color.Goldenrod.Name;
                        OnCalculateStatisticsMyWarehouseProductsCommandExecuted(true);

                        return;
                    }

                    resultList.Clear();
                    foreach (WarehouseProduct product in FilteredWarehouseProducts)
                    {
                        resultList.Add(product);
                    }

                }
            }

            //Filtering By OrderNumber
            List<string> productsOrdersNumbers = [];
            foreach (WarehouseProduct wp in FilteredWarehouseProducts)
            {
                if (wp.OrderNumber is null)
                {
                    WarehouseEventTextValue = $"Значение \"Номер заказа:\" продукта их отфильтрованного списка задано некорректно.";
                    WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                    WarehouseEventIconColor = Color.Red.Name;

                    break;
                }

                productsOrdersNumbers.Add(wp.OrderNumber);
                productsOrdersNumbers.Sort();
                ListOfComboBoxOrderNumberPossibleValues = productsOrdersNumbers.Distinct().ToList();
            }
            if (!string.IsNullOrEmpty(FilterOrderNumberForMyWarehouseProducts))
            {
                IconFiltersTabControlInMyWarehouseItemValue = Icons.Name.Solid_Filter.ToString();

                FilteredWarehouseProducts = [];

                if (FilterOrderNumberForMyWarehouseProducts is null)
                {
                    WarehouseEventTextValue = $"Значение фильтра \"Номер заказа:\" равно NULL.";
                    WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                    WarehouseEventIconColor = Color.Red.Name;

                    return;
                }

                FilteredWarehouseProducts.AddRange(from WarehouseProduct product in resultList
                                                   where product.OrderNumber.Contains(FilterOrderNumberForMyWarehouseProducts)
                                                   select product);

                if (FilteredWarehouseProducts.Count == 0)
                {
                    WarehouseEventTextValue = $"Список не содержит продуктов с указанным \"Номером заказа\".";
                    WarehouseEventIconValue = Icons.Name.Solid_CircleExclamation.ToString();
                    WarehouseEventIconColor = Color.Goldenrod.Name;
                    OnCalculateStatisticsMyWarehouseProductsCommandExecuted(true);

                    return;
                }

                resultList.Clear();
                foreach (WarehouseProduct product in FilteredWarehouseProducts)
                {
                    resultList.Add(product);
                }
            }

            //Filtering By Products Note
            if (!string.IsNullOrEmpty(FilterNoteForMyWarehouseProducts))
            {
                IconFiltersTabControlInMyWarehouseItemValue = Icons.Name.Solid_Filter.ToString();

                FilteredWarehouseProducts = [];
                foreach (WarehouseProduct product in resultList)
                {
                    if (product.Note.Contains(FilterNoteForMyWarehouseProducts))
                    {
                        FilteredWarehouseProducts.Add(product);
                    }
                }

                if (FilteredWarehouseProducts.Count == 0)
                {
                    WarehouseEventTextValue = $"Список не содержит продуктов с указанным \"Примечанием\".";
                    WarehouseEventIconValue = Icons.Name.Solid_CircleExclamation.ToString();
                    WarehouseEventIconColor = Color.Goldenrod.Name;
                    OnCalculateStatisticsMyWarehouseProductsCommandExecuted(true);

                    return;
                }
            }

            OnCalculateStatisticsMyWarehouseProductsCommandExecuted(true);
            WarehouseEventTextValue = $"Отфильтрованный список содержит {FilteredWarehouseProducts.Count.ToString()} продуктов.";
            WarehouseEventIconValue = Icons.Name.Regular_CircleCheck.ToString();
            WarehouseEventIconColor = Color.LimeGreen.Name;
        }

        #endregion


        #region Command CalculateStatisticsMyWarehouseProductsCommand: - Calculate Statistics About The List Of Warehouse Products After Filtering

        /// <summary>Calculate Statistics About The List Of Warehouse Products After Filtering</summary>
        private LambdaCommand? _CalculateStatisticsMyWarehouseProductsCommand;

        /// <summary>Calculate Statistics About The List Of Warehouse Products After Filtering</summary>
        public ICommand CalculateStatisticsMyWarehouseProductsCommand => _CalculateStatisticsMyWarehouseProductsCommand ??= new(OnCalculateStatisticsMyWarehouseProductsCommandExecuted);

        /// <summary>Логика выполнения - Calculate Statistics About The List Of Warehouse Products After Filtering</summary>

        private void OnCalculateStatisticsMyWarehouseProductsCommandExecuted(object? p)
        {
            // Null Check

            if (FilteredWarehouseProducts is null)
            {
                WarehouseEventTextValue = $"Cписок для рассчета \"Статистики\" равен NULL!";
                WarehouseEventIconValue = Icons.Name.Regular_CircleCheck.ToString();
                WarehouseEventIconColor = Color.LimeGreen.Name;

                ValueOfTotalNumberOfProductsForMyWarehouseProducts = string.Empty;

                return;
            }

            // Zero Check

            if (FilteredWarehouseProducts.Count == 0)
            {
                WarehouseEventTextValue = $"Cписок для рассчета \"Статистики\" равен NULL!";
                WarehouseEventIconValue = Icons.Name.Solid_CircleExclamation.ToString();
                WarehouseEventIconColor = Color.Goldenrod.Name;

                ValueOfTotalNumberOfProductsForMyWarehouseProducts = string.Empty;

                return;
            }



            ValueOfTotalNumberOfProductsForMyWarehouseProducts = FilteredWarehouseProducts.Count.ToString();
        }

        #endregion


        #region Command SelectedExpirationDateStartChangedMyWarehouseProductsCommand: - "Selected Expiration Date" Changed In My Warehouse Windows

        /// <summary>"Selected Expiration Date" Changed In My Warehouse Windows</summary>
        private LambdaCommand? _SelectedExpirationDateStartChangedMyWarehouseProductsCommand;

        /// <summary>"Selected Expiration Date" Changed In My Warehouse Windows</summary>
        public ICommand SelectedExpirationDateStartChangedMyWarehouseProductsCommand => _SelectedExpirationDateStartChangedMyWarehouseProductsCommand ??= new(OnSelectedExpirationDateStartChangedMyWarehouseProductsCommandExecuted);

        /// <summary>Логика выполнения - "Selected Expiration Date" Changed In My Warehouse Windows</summary>

        private void OnSelectedExpirationDateStartChangedMyWarehouseProductsCommandExecuted(object? p)
        {

            FilterExpirationDateStartForMyWarehouseProducts = SelectedDateExpirationDateStartFilterMyWarehouseProducts.ToString()[3..10];
        }

        #endregion
        #region Command SelectedExpirationDateStopChangedMyWarehouseProductsCommand: - "Selected Expiration Date" Stop Changed In My Warehouse Window

        /// <summary>"Selected Expiration Date" Stop Changed In My Warehouse Window</summary>
        private LambdaCommand? _SelectedExpirationDateStopChangedMyWarehouseProductsCommand;

        /// <summary>"Selected Expiration Date" Stop Changed In My Warehouse Window</summary>
        public ICommand SelectedExpirationDateStopChangedMyWarehouseProductsCommand => _SelectedExpirationDateStopChangedMyWarehouseProductsCommand ??= new(OnSelectedExpirationDateStopChangedMyWarehouseProductsCommandExecuted);

        /// <summary>Логика выполнения - "Selected Expiration Date" Stop Changed In My Warehouse Window</summary>

        private void OnSelectedExpirationDateStopChangedMyWarehouseProductsCommandExecuted(object? p)
        {
            FilterExpirationDateStopForMyWarehouseProducts = SelectedDateExpirationDateStopFilterMyWarehouseProducts.ToString()[3..10];

        }

        #endregion
        #region Command ChangeSelectedItemOfCombmBoxLocationFilterCommand: - Change Value Of Selected Item "Location" Filtef In My Warehouse Panel

        /// <summary>Change Value Of Selected Item "Location" Filtef In My Warehouse Panel</summary>
        private LambdaCommand? _ChangeSelectedItemOfCombmBoxLocationFilterCommand;

        /// <summary>Change Value Of Selected Item "Location" Filtef In My Warehouse Panel</summary>
        public ICommand ChangeSelectedItemOfCombmBoxLocationFilterCommand => _ChangeSelectedItemOfCombmBoxLocationFilterCommand ??= new(OnChangeSelectedItemOfCombmBoxLocationFilterCommandExecuted);

        /// <summary>Логика выполнения - Change Value Of Selected Item "Location" Filtef In My Warehouse Panel</summary>

        private void OnChangeSelectedItemOfCombmBoxLocationFilterCommandExecuted(object? p)
        {
            if (SelectedItemOfComboBoxLocationInFilterPanelMyWarehouseProducts is null)
            {
                SelectedItemOfComboBoxLocationInFilterPanelMyWarehouseProducts = FilterLocationForMyWarehouseProducts;

                return;
            }

            FilterLocationForMyWarehouseProducts = SelectedItemOfComboBoxLocationInFilterPanelMyWarehouseProducts;
        }

        #endregion
        #region Command SelectedReceiptDateStartChangedMyWarehouseProductsCommand: - "Selected Receipt Date Start" Changed In My Warehouse Windows

        /// <summary>"Selected Receipt Date Start" Changed In My Warehouse Windows</summary>
        private LambdaCommand? _SelectedReceiptDateStartChangedMyWarehouseProductsCommand;

        /// <summary>"Selected Receipt Date Start" Changed In My Warehouse Windows</summary>
        public ICommand SelectedReceiptDateStartChangedMyWarehouseProductsCommand => _SelectedReceiptDateStartChangedMyWarehouseProductsCommand ??= new(OnSelectedReceiptDateStartChangedMyWarehouseProductsCommandExecuted);

        /// <summary>Логика выполнения - "Selected Receipt Date Start" Changed In My Warehouse Windows</summary>

        private void OnSelectedReceiptDateStartChangedMyWarehouseProductsCommandExecuted(object? p)
        {

            FilterReceiptDateStartForMyWarehouseProducts = SelectedDateReceiptDateStartFilterMyWarehouseProducts.ToString()[..10];
        }

        #endregion
        #region Command SelectedReceiptDateStopChangedMyWarehouseProductsCommand: - "Selected Receipt Date" Stop Changed In My Warehouse Window

        /// <summary>"Selected Receipt Date" Stop Changed In My Warehouse Window</summary>
        private LambdaCommand? _SelectedReceiptDateStopChangedMyWarehouseProductsCommand;

        /// <summary>"Selected Receipt Date" Stop Changed In My Warehouse Window</summary>
        public ICommand SelectedReceiptDateStopChangedMyWarehouseProductsCommand => _SelectedReceiptDateStopChangedMyWarehouseProductsCommand ??= new(OnSelectedReceiptDateStopChangedMyWarehouseProductsCommandExecuted);

        /// <summary>Логика выполнения - "Selected Receipt Date" Stop Changed In My Warehouse Window</summary>

        private void OnSelectedReceiptDateStopChangedMyWarehouseProductsCommandExecuted(object? p)
        {
            FilterReceiptDateStopForMyWarehouseProducts = SelectedDateReceiptDateStopFilterMyWarehouseProducts.ToString()[..10];

        }

        #endregion
        #region Command ChangeSelectedItemOfCombmBoxOrderNumberFilterCommand: - Change Value Of Selected Item "Order Number" Filtef In My Warehouse Panel

        /// <summary>Change Value Of Selected Item "Order Number" Filtef In My Warehouse Panel</summary>
        private LambdaCommand? _ChangeSelectedItemOfCombmBoxOrderNumberFilterCommand;

        /// <summary>Change Value Of Selected Item "Order Number" Filtef In My Warehouse Panel</summary>
        public ICommand ChangeSelectedItemOfCombmBoxOrderNumberFilterCommand => _ChangeSelectedItemOfCombmBoxOrderNumberFilterCommand ??= new(OnChangeSelectedItemOfCombmBoxOrderNumberFilterCommandExecuted);

        /// <summary>Логика выполнения - Change Value Of Selected Item "Order Number" Filtef In My Warehouse Panel</summary>

        private void OnChangeSelectedItemOfCombmBoxOrderNumberFilterCommandExecuted(object? p)
        {
            if (SelectedItemOfComboBoxOrderNumberInFilterPanelMyWarehouseProducts is null)
            {
                SelectedItemOfComboBoxOrderNumberInFilterPanelMyWarehouseProducts = FilterOrderNumberForMyWarehouseProducts;

                return;
            }

            FilterOrderNumberForMyWarehouseProducts = SelectedItemOfComboBoxOrderNumberInFilterPanelMyWarehouseProducts;
        }

        #endregion


        #region Command SelectNewWarehouseProductCommand: - Select New Product In My Warehouse

        /// <summary>Select New Product In My Warehouse</summary>
        private LambdaCommand? _SelectNewWarehouseProductCommand;

        /// <summary>Select New Product In My Warehouse</summary>
        public ICommand SelectNewWarehouseProductCommand => _SelectNewWarehouseProductCommand ??= new(OnSelectNewWarehouseProductCommandExecuted);

        /// <summary>Логика выполнения - Select New Product In My Warehouse</summary>

        private void OnSelectNewWarehouseProductCommandExecuted(object? p)
        {
            if (SelectedWarehouseProduct is null)
            {
                return;
            }

            SelectedProductId = SelectedWarehouseProduct.Id.ToString();
            SelectedProductTittle = SelectedWarehouseProduct.Tittle;
            SelectedProductProperty = SelectedWarehouseProduct.Property;
            SelectedProductSize = SelectedWarehouseProduct.Size;
            SelectedProductExpirationData = SelectedWarehouseProduct.ExpirationDate.ToString().Substring(3, 7).Replace('.', '/');
            SelectedProductPurchaseCost = SelectedWarehouseProduct.PurchaseCost.ToString();
            SelectedProductLocation = SelectedWarehouseProduct.Location;
            SelectedProductReceiptDate = SelectedWarehouseProduct.ReceiptDate.ToString()[..10];
            SelectedProductOrderNumber = SelectedWarehouseProduct.OrderNumber;
            SelectedProductNote = SelectedWarehouseProduct.Note;

        }

        #endregion

        #region Command PushButtonCorrectWareHouseProductDataCommand: - Push Button "Correct Data" Of The Warehouse Product

        /// <summary>Push Button "Correct Data" Of The Warehouse Product</summary>
        private LambdaCommand? _PushButtonCorrectWareHouseProductDataCommand;

        /// <summary>Push Button "Correct Data" Of The Warehouse Product</summary>
        public ICommand PushButtonCorrectWareHouseProductDataCommand => _PushButtonCorrectWareHouseProductDataCommand ??= new(OnPushButtonCorrectWareHouseProductDataCommandExecuted);

        /// <summary>Логика выполнения - Push Button "Correct Data" Of The Warehouse Product</summary>

        private void OnPushButtonCorrectWareHouseProductDataCommandExecuted(object? p)
        {
            if (SelectedWarehouseProduct is null)
            {
                return;
            }

            if (string.IsNullOrEmpty(SelectedProductId))
            {
                WarehouseEventTextValue = $"Не выбран \"Продукт\" из списка.";
                WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                WarehouseEventIconColor = Color.Red.Name;

                return;
            }

            var dbSettings = new DBSettings
            {
                Server = ConnectionOptions.dbServer,
                Port = ConnectionOptions.dbPort,
                Name = ConnectionOptions.dbName,
                UserId = ConnectionOptions.userId,
                Password = ConnectionOptions.password
            };

            string tableTittle = DbTables.WarehouseProducts;
            string columnId = DbTableWarehouseProducts.propertyId;

            if (SelectedWarehouseProduct.Id is null)
            {
                return;
            }

            if (_DataBase is null)
            {
                return;
            }

            string id = SelectedWarehouseProduct.Id.ToString();

            if (id is null)
            {
                return;
            }

            //Tittle
            if (BorderColorSelectedProductTittleMyWarehouseControlTab == "Green")
            {
                string columnTittle = DbTableWarehouseProducts.propertyTittle;

                if (SelectedProductTittle is null)
                {
                    return;
                }

                _DataBase.UpdateRecord(dbSettings, tableTittle, columnTittle, columnId, SelectedProductId, SelectedProductTittle);

                WarehouseEventTextValue = "Значение названия выбранного продукта изменено.";
                WarehouseEventIconValue = Icons.Name.Regular_CircleCheck.ToString();
                WarehouseEventIconColor = Color.LimeGreen.Name;

                BorderColorSelectedProductTittleMyWarehouseControlTab = "HotPink";
            }
            //Property
            if (BorderColorSelectedProductPropertyMyWarehouseControlTab == "Green")
            {
                string columnTittle = DbTableWarehouseProducts.propertyProperty;

                if (SelectedProductProperty is null)
                {
                    return;
                }

                _DataBase.UpdateRecord(dbSettings, tableTittle, columnTittle, columnId, SelectedProductId, SelectedProductProperty);

                WarehouseEventTextValue = "Значение свойства выбранного продукта изменено.";
                WarehouseEventIconValue = Icons.Name.Regular_CircleCheck.ToString();
                WarehouseEventIconColor = Color.LimeGreen.Name;

                BorderColorSelectedProductPropertyMyWarehouseControlTab = "HotPink";
            }
            //Size
            if (BorderColorSelectedProductSizeMyWarehouseControlTab == "Green")
            {
                string columnTittle = DbTableWarehouseProducts.propertySize;

                if (SelectedProductSize is null)
                {
                    return;
                }

                _DataBase.UpdateRecord(dbSettings, tableTittle, columnTittle, columnId, SelectedProductId, SelectedProductSize);

                WarehouseEventTextValue = "Значение свойства выбранного продукта изменено.";
                WarehouseEventIconValue = Icons.Name.Regular_CircleCheck.ToString();
                WarehouseEventIconColor = Color.LimeGreen.Name;

                BorderColorSelectedProductSizeMyWarehouseControlTab = "HotPink";

            }
            //Expiration Data
            if (BorderColorSelectedProductExpirationDateMyWarehouseControlTab == "Green")
            {
                string columnTittle = DbTableWarehouseProducts.propertyExpirationDate;

                if (SelectedProductExpirationData is null)
                {
                    return;
                }

                string newValue = string.Concat("01.", SelectedProductExpirationData.AsSpan(0, 2), ".", SelectedProductExpirationData.AsSpan(3, 4));


                _DataBase.UpdateRecord(dbSettings, tableTittle, columnTittle, columnId, SelectedProductId, newValue);

                WarehouseEventTextValue = "Значение свойства выбранного продукта изменено.";
                WarehouseEventIconValue = Icons.Name.Regular_CircleCheck.ToString();
                WarehouseEventIconColor = Color.LimeGreen.Name;

                BorderColorSelectedProductExpirationDateMyWarehouseControlTab = "HotPink";
            }
            //Purchase Cost
            if (BorderColorSelectedProductPurchaseCostMyWarehouseControlTab == "Green")
            {
                string columnTittle = DbTableWarehouseProducts.propertyPurchaseCost;

                if (SelectedProductPurchaseCost is null)
                {
                    return;
                }

                _DataBase.UpdateRecord(dbSettings, tableTittle, columnTittle, columnId, SelectedProductId, SelectedProductPurchaseCost);

                WarehouseEventTextValue = "Значение свойства выбранного продукта изменено.";
                WarehouseEventIconValue = Icons.Name.Regular_CircleCheck.ToString();
                WarehouseEventIconColor = Color.LimeGreen.Name;

                BorderColorSelectedProductPurchaseCostMyWarehouseControlTab = "HotPink";


            }
            //Location
            if (BorderColorSelectedProductLocationMyWarehouseControlTab == "Green")
            {
                string columnTittle = DbTableWarehouseProducts.propertyLocation;

                if (SelectedProductLocation is null)
                {
                    return;
                }

                _DataBase.UpdateRecord(dbSettings, tableTittle, columnTittle, columnId, SelectedProductId, SelectedProductLocation);

                WarehouseEventTextValue = "Значение свойства выбранного продукта изменено.";
                WarehouseEventIconValue = Icons.Name.Regular_CircleCheck.ToString();
                WarehouseEventIconColor = Color.LimeGreen.Name;

                BorderColorSelectedProductLocationMyWarehouseControlTab = "HotPink";
            }
            //Receipt Date
            if (BorderColorSelectedProductReceiptDateMyWarehouseControlTab == "Green")
            {
                string columnTittle = DbTableWarehouseProducts.propertyReceiptDate;

                if (SelectedProductReceiptDate is null)
                {
                    return;
                }

                _DataBase.UpdateRecord(dbSettings, tableTittle, columnTittle, columnId, SelectedProductId, SelectedProductReceiptDate);

                WarehouseEventTextValue = "Значение свойства выбранного продукта изменено.";
                WarehouseEventIconValue = Icons.Name.Regular_CircleCheck.ToString();
                WarehouseEventIconColor = Color.LimeGreen.Name;

                BorderColorSelectedProductReceiptDateMyWarehouseControlTab = "HotPink";

            }
            //Order Number
            if (BorderColorSelectedProductOrderNumberMyWarehouseControlTab == "Green")
            {
                string columnTittle = DbTableWarehouseProducts.propertyOrderNumber;

                if (SelectedProductOrderNumber is null)
                {
                    return;
                }

                _DataBase.UpdateRecord(dbSettings, tableTittle, columnTittle, columnId, SelectedProductId, SelectedProductOrderNumber);

                WarehouseEventTextValue = "Значение свойства выбранного продукта изменено.";
                WarehouseEventIconValue = Icons.Name.Regular_CircleCheck.ToString();
                WarehouseEventIconColor = Color.LimeGreen.Name;


                BorderColorSelectedProductOrderNumberMyWarehouseControlTab = "HotPink";
            }
            //Note
            if (BorderColorSelectedProductNoteMyWarehouseControlTab == "Green")
            {
                string columnTittle = DbTableWarehouseProducts.propertyNote;

                if (SelectedProductNote is null)
                {
                    return;
                }

                _DataBase.UpdateRecord(dbSettings, tableTittle, columnTittle, columnId, SelectedProductId, SelectedProductNote);

                WarehouseEventTextValue = "Значение свойства выбранного продукта изменено.";
                WarehouseEventIconValue = Icons.Name.Regular_CircleCheck.ToString();
                WarehouseEventIconColor = Color.LimeGreen.Name;

                BorderColorSelectedProductNoteMyWarehouseControlTab = "HotPink";
            }

            OnRefreshConnectionToDataBaseWarhouseWindowCommandExecuted(true);

        }

        #endregion

        #region Command PushButtonSoldOutWareHouseCommand: - Push Button "Sold Out" The Product From Warehouse

        /// <summary>Push Button "Sold Out" The Product From Warehouse</summary>
        private LambdaCommand? _PushButtonSoldOutWareHouseCommand;

        /// <summary>Push Button "Sold Out" The Product From Warehouse</summary>
        public ICommand PushButtonSoldOutWareHouseCommand => _PushButtonSoldOutWareHouseCommand ??= new(OnPushButtonSoldOutWareHouseCommandExecuted);

        /// <summary>Логика выполнения - Push Button "Sold Out" The Product From Warehouse</summary>

        private void OnPushButtonSoldOutWareHouseCommandExecuted(object? p)
        {
            if (_DataBase is null)
            {
                return;
            }

            if (SelectedWarehouseProduct is null)
            {
                WarehouseEventTextValue = $"Не выбран продукт для переноса в базу \"{DbTables.SoldProducts}\".";
                WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                WarehouseEventIconColor = Color.Red.Name;

                return;
            }

            var dbSettings = new DBSettings
            {
                Server = ConnectionOptions.dbServer,
                Port = ConnectionOptions.dbPort,
                Name = ConnectionOptions.dbName,
                UserId = ConnectionOptions.userId,
                Password = ConnectionOptions.password
            };

            string tableTittle = DbTables.SoldProducts;

            if (IconSoldCostChangeValue == "Regular_CircleXmark" || IconSoldDateChangeValue == "Regular_CircleXmark" ||
                IconCustomerIdChangeValue == "Regular_CircleXmark")
            {
                WarehouseEventTextValue = $"Продукт не может быть добавлен в \"Проданное\". Некорректно указаны данные.";
                WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                WarehouseEventIconColor = Color.Red.Name;

                return;
            }

            var soldDate = DateTime.Parse(SelectedProductSoldDate);

            SoldProduct soldProduct = new()
            {
                Id = 0,
                Tittle = SelectedWarehouseProduct.Tittle,
                Property = SelectedWarehouseProduct.Property,
                Size = SelectedWarehouseProduct.Size,
                ExpirationDate = SelectedWarehouseProduct.ExpirationDate,
                PurchaseCost = Convert.ToInt32(SelectedWarehouseProduct.PurchaseCost),
                SoldCost = Convert.ToInt32(SelectedProductSoldCost),
                OrderNumber = SelectedWarehouseProduct.OrderNumber,
                ReceiptDate = SelectedWarehouseProduct.ReceiptDate,
                SoldDate = soldDate,
                Note = SelectedWarehouseProduct.Note,
                CustomerId = Convert.ToInt32(SelectedProductCustomerId),
            };

            _DataBase.AddSoldProduct(dbSettings, tableTittle, soldProduct);

            tableTittle = DbTables.WarehouseProducts;

            _DataBase.DeleteRecord(dbSettings, tableTittle, DbTableWarehouseProducts.propertyId, SelectedWarehouseProduct.Id.ToString());

            WarehouseEventTextValue = $"Сведения о продукте записаны в базу \"{ConnectionOptions.dbName}\".";
            WarehouseEventIconValue = Icons.Name.Regular_CircleCheck.ToString();
            WarehouseEventIconColor = Color.LimeGreen.Name;

        }

        #endregion


        #region Command ChangeTittleValueOfWarehouseProductCommand: - Change Value Of "Tittle" Of Selected Warhouse Product

        /// <summary>Change Value Of "Tittle" Of Selected Warhouse Product</summary>
        private LambdaCommand? _ChangeTittleValueOfWarehouseProductCommand;

        /// <summary>Change Value Of "Tittle" Of Selected Warhouse Product</summary>
        public ICommand ChangeTittleValueOfWarehouseProductCommand => _ChangeTittleValueOfWarehouseProductCommand ??= new(OnChangeTittleValueOfWarehouseProductCommandExecuted);

        /// <summary>Логика выполнения - Change Value Of "Tittle" Of Selected Warhouse Product</summary>

        private void OnChangeTittleValueOfWarehouseProductCommandExecuted(object? p)
        {
            if (SelectedWarehouseProduct is null)
            {
                return;
            }

            if (SelectedProductId != SelectedWarehouseProduct.Id.ToString())
            {
                return;
            }

            if (SelectedProductTittle != SelectedWarehouseProduct.Tittle)
            {
                if (string.IsNullOrEmpty(SelectedProductTittle))
                {
                    BorderColorSelectedProductTittleMyWarehouseControlTab = "DarkViolet";

                    WarehouseEventTextValue = $"Не задано значение \"Название\" продукта.";
                    WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                    WarehouseEventIconColor = Color.Red.Name;

                    return;
                }

                BorderColorSelectedProductTittleMyWarehouseControlTab = "Green";

                WarehouseEventTextValue = $"Значение \"Название\" продукта изменено.";
                WarehouseEventIconValue = Icons.Name.Regular_CircleCheck.ToString();
                WarehouseEventIconColor = Color.LimeGreen.Name;
            }
            else
            {
                BorderColorSelectedProductTittleMyWarehouseControlTab = "HotPink";
            }
        }

        #endregion
        #region Command ChangePropertyValueOfWarehouseProductCommand: - Change Value Of "Proprety" Of Selected Warhouse Product

        /// <summary>Change Value Of "Proprety" Of Selected Warhouse Product</summary>
        private LambdaCommand? _ChangePropertyValueOfWarehouseProductCommand;

        /// <summary>Change Value Of "Proprety" Of Selected Warhouse Product</summary>
        public ICommand ChangePropertyValueOfWarehouseProductCommand => _ChangePropertyValueOfWarehouseProductCommand ??= new(OnChangePropertyValueOfWarehouseProductCommandExecuted);

        /// <summary>Логика выполнения - Change Value Of "Proprety" Of Selected Warhouse Product</summary>

        private void OnChangePropertyValueOfWarehouseProductCommandExecuted(object? p)
        {
            if (SelectedWarehouseProduct is null)
            {
                return;
            }

            if (SelectedProductId != SelectedWarehouseProduct.Id.ToString())
            {
                return;
            }

            if (SelectedProductProperty != SelectedWarehouseProduct.Property)
            {
                if (string.IsNullOrEmpty(SelectedProductProperty))
                {
                    BorderColorSelectedProductPropertyMyWarehouseControlTab = "DarkViolet";

                    WarehouseEventTextValue = $"Не задано значение \"Свойство\" продукта.";
                    WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                    WarehouseEventIconColor = Color.Red.Name;

                    return;
                }

                BorderColorSelectedProductPropertyMyWarehouseControlTab = "Green";

                WarehouseEventTextValue = $"Значение \"Свойство\" продукта изменено.";
                WarehouseEventIconValue = Icons.Name.Regular_CircleCheck.ToString();
                WarehouseEventIconColor = Color.LimeGreen.Name;

            }
            else
            {
                BorderColorSelectedProductPropertyMyWarehouseControlTab = "HotPink";
            }
        }

        #endregion
        #region Command ChangeSizeValueOfWarehouseProductCommand: - Change Value Of "Size" Of Selected Warhouse Product

        /// <summary>Change Value Of "Size" Of Selected Warhouse Product</summary>
        private LambdaCommand? _ChangeSizeValueOfWarehouseProductCommand;

        /// <summary>Change Value Of "Size" Of Selected Warhouse Product</summary>
        public ICommand ChangeSizeValueOfWarehouseProductCommand => _ChangeSizeValueOfWarehouseProductCommand ??= new(OnChangeSizeValueOfWarehouseProductCommandExecuted);

        /// <summary>Логика выполнения - Change Value Of "Size" Of Selected Warhouse Product</summary>

        private void OnChangeSizeValueOfWarehouseProductCommandExecuted(object? p)
        {
            if (SelectedWarehouseProduct is null)
            {
                return;
            }

            if (SelectedProductId != SelectedWarehouseProduct.Id.ToString())
            {
                return;
            }

            if (SelectedProductSize != SelectedWarehouseProduct.Size)
            {
                if (string.IsNullOrEmpty(SelectedProductSize))
                {
                    BorderColorSelectedProductSizeMyWarehouseControlTab = "DarkViolet";

                    WarehouseEventTextValue = $"Не задано значение \"Размер\" продукта.";
                    WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                    WarehouseEventIconColor = Color.Red.Name;

                    return;
                }

                BorderColorSelectedProductSizeMyWarehouseControlTab = "Green";

                WarehouseEventTextValue = $"Значение \"Размер\" продукта изменено.";
                WarehouseEventIconValue = Icons.Name.Regular_CircleCheck.ToString();
                WarehouseEventIconColor = Color.LimeGreen.Name;

            }
            else
            {
                BorderColorSelectedProductSizeMyWarehouseControlTab = "HotPink";
            }
        }

        #endregion
        #region Command ChangeLocationValueOfWarehouseProductCommand: - Change Value Of "Location" Of Selected Warhouse Product

        /// <summary>Change Value Of "Location" Of Selected Warhouse Product</summary>
        private LambdaCommand? _ChangeLocationValueOfWarehouseProductCommand;

        /// <summary>Change Value Of "Location" Of Selected Warhouse Product</summary>
        public ICommand ChangeLocationValueOfWarehouseProductCommand => _ChangeLocationValueOfWarehouseProductCommand ??= new(OnChangeLocationValueOfWarehouseProductCommandExecuted);

        /// <summary>Логика выполнения - Change Value Of "Location" Of Selected Warhouse Product</summary>

        private void OnChangeLocationValueOfWarehouseProductCommandExecuted(object? p)
        {
            if (SelectedWarehouseProduct is null)
            {
                return;
            }

            if (SelectedProductId != SelectedWarehouseProduct.Id.ToString())
            {
                return;
            }

            if (SelectedProductLocation != SelectedWarehouseProduct.Location)
            {
                if (string.IsNullOrEmpty(SelectedProductLocation))
                {
                    BorderColorSelectedProductLocationMyWarehouseControlTab = "DarkViolet";

                    WarehouseEventTextValue = $"Не задано значение \"Место хранения\" продукта.";
                    WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                    WarehouseEventIconColor = Color.Red.Name;

                    return;
                }

                BorderColorSelectedProductLocationMyWarehouseControlTab = "Green";

                WarehouseEventTextValue = $"Значение \"Место хранения\" продукта изменено.";
                WarehouseEventIconValue = Icons.Name.Regular_CircleCheck.ToString();
                WarehouseEventIconColor = Color.LimeGreen.Name;

            }
            else
            {
                BorderColorSelectedProductLocationMyWarehouseControlTab = "HotPink";
            }
        }

        #endregion
        #region Command ChangeOrderNumberValueOfWarehouseProductCommand: - Change Value Of "Order Number" Of Selected Warhouse Product

        /// <summary>Change Value Of "Order Number" Of Selected Warhouse Product</summary>
        private LambdaCommand? _ChangeOrderNumberValueOfWarehouseProductCommand;

        /// <summary>Change Value Of "Order Number" Of Selected Warhouse Product</summary>
        public ICommand ChangeOrderNumberValueOfWarehouseProductCommand => _ChangeOrderNumberValueOfWarehouseProductCommand ??= new(OnChangeOrderNumberValueOfWarehouseProductCommandExecuted);

        /// <summary>Логика выполнения - Change Value Of "Order Number" Of Selected Warhouse Product</summary>

        private void OnChangeOrderNumberValueOfWarehouseProductCommandExecuted(object? p)
        {
            if (SelectedWarehouseProduct is null)
            {
                return;
            }

            if (SelectedProductId != SelectedWarehouseProduct.Id.ToString())
            {
                return;
            }

            if (SelectedProductOrderNumber != SelectedWarehouseProduct.OrderNumber)
            {
                if (string.IsNullOrEmpty(SelectedProductOrderNumber))
                {
                    BorderColorSelectedProductOrderNumberMyWarehouseControlTab = "DarkViolet";

                    WarehouseEventTextValue = $"Не задано значение \"Номер заказа\" продукта.";
                    WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                    WarehouseEventIconColor = Color.Red.Name;

                    return;
                }

                BorderColorSelectedProductOrderNumberMyWarehouseControlTab = "Green";

                WarehouseEventTextValue = $"Значение \"Номер заказа\" продукта изменено.";
                WarehouseEventIconValue = Icons.Name.Regular_CircleCheck.ToString();
                WarehouseEventIconColor = Color.LimeGreen.Name;

            }
            else
            {
                BorderColorSelectedProductOrderNumberMyWarehouseControlTab = "HotPink";
            }
        }

        #endregion
        #region Command ChangeNoteValueOfWarehouseProductCommand: - Change Value Of "Note" Of Selected Warhouse Product

        /// <summary>Change Value Of "Note" Of Selected Warhouse Product</summary>
        private LambdaCommand? _ChangeNoteValueOfWarehouseProductCommand;

        /// <summary>Change Value Of "Note" Of Selected Warhouse Product</summary>
        public ICommand ChangeNoteValueOfWarehouseProductCommand => _ChangeNoteValueOfWarehouseProductCommand ??= new(OnChangeNoteValueOfWarehouseProductCommandExecuted);

        /// <summary>Логика выполнения - Change Value Of "Note" Of Selected Warhouse Product</summary>

        private void OnChangeNoteValueOfWarehouseProductCommandExecuted(object? p)
        {
            if (SelectedWarehouseProduct is null)
            {
                return;
            }

            if (SelectedProductId != SelectedWarehouseProduct.Id.ToString())
            {
                return;
            }

            if (SelectedProductNote != SelectedWarehouseProduct.Note)
            {
                if (SelectedProductNote is null)
                {
                    BorderColorSelectedProductNoteMyWarehouseControlTab = "DarkViolet";

                    WarehouseEventTextValue = $"Значение \"Примечание\" продукта NULL.";
                    WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                    WarehouseEventIconColor = Color.Red.Name;

                    return;
                }

                BorderColorSelectedProductNoteMyWarehouseControlTab = "Green";

                WarehouseEventTextValue = $"Значение \"Примечание\" продукта изменено.";
                WarehouseEventIconValue = Icons.Name.Regular_CircleCheck.ToString();
                WarehouseEventIconColor = Color.LimeGreen.Name;

            }
            else
            {
                BorderColorSelectedProductNoteMyWarehouseControlTab = "HotPink";
            }
        }

        #endregion
        #region Command ChangeExpirationDateValueOfWarehouseProductCommand: - Change Value Of "Expiration Date" Of Selected Warhouse Product

        /// <summary>Change Value Of "Expiration Date" Of Selected Warhouse Product</summary>
        private LambdaCommand? _ChangeExpirationDateValueOfWarehouseProductCommand;

        /// <summary>Change Value Of "Expiration Date" Of Selected Warhouse Product</summary>
        public ICommand ChangeExpirationDateValueOfWarehouseProductCommand => _ChangeExpirationDateValueOfWarehouseProductCommand ??= new(OnChangeExpirationDateValueOfWarehouseProductCommandExecuted);

        /// <summary>Логика выполнения - Change Value Of "Expiration Date" Of Selected Warhouse Product</summary>

        private void OnChangeExpirationDateValueOfWarehouseProductCommandExecuted(object? p)
        {
            if (SelectedWarehouseProduct is null)
            {
                return;
            }

            if (SelectedProductId != SelectedWarehouseProduct.Id.ToString())
            {
                return;
            }

            if (SelectedProductExpirationData != SelectedWarehouseProduct.ExpirationDate.ToString().Substring(3, 7).Replace('.', '/'))
            {
                if (string.IsNullOrEmpty(SelectedProductExpirationData))
                {
                    BorderColorSelectedProductExpirationDateMyWarehouseControlTab = "DarkViolet";

                    WarehouseEventTextValue = $"Не задано значение \"Срок годности\" продукта.";
                    WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                    WarehouseEventIconColor = Color.Red.Name;

                    return;
                }

                if (SelectedProductExpirationData.Length != 7)
                {
                    BorderColorSelectedProductExpirationDateMyWarehouseControlTab = "DarkViolet";

                    WarehouseEventTextValue = $"Формат значения \"Срок годности\" некоректный (мм/гггг).";
                    WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                    WarehouseEventIconColor = Color.Red.Name;

                    return;
                }

                string mm = SelectedProductExpirationData[..2];
                if (mm != "01" && mm != "02" && mm != "03" && mm != "04" && mm != "05" && mm != "06" && mm != "07" && mm != "08" && mm != "09" && mm != "10" && mm != "11" && mm != "12")
                {
                    BorderColorSelectedProductExpirationDateMyWarehouseControlTab = "DarkViolet";

                    WarehouseEventTextValue = $"Формат месяца значения \"Срок годности\" некоректный.";
                    WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                    WarehouseEventIconColor = Color.Red.Name;

                    return;
                }

                string yyyy = SelectedProductExpirationData.Substring(3, 4);
                bool isLetter = false;
                foreach (char c in yyyy)
                {
                    if (!char.IsDigit(c))
                    {
                        isLetter = true;
                        break;
                    }
                }
                if (isLetter)
                {
                    BorderColorSelectedProductExpirationDateMyWarehouseControlTab = "DarkViolet";

                    WarehouseEventTextValue = $"Формат года значения \"Срок годности\" некоректный.";
                    WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                    WarehouseEventIconColor = Color.Red.Name;

                    return;
                }

                uint yearvalue = Convert.ToUInt16(yyyy);
                if (yearvalue < 2000)
                {
                    BorderColorSelectedProductExpirationDateMyWarehouseControlTab = "DarkViolet";

                    WarehouseEventTextValue = $"Значение года \"Срок годности\" слишком мало.";
                    WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                    WarehouseEventIconColor = Color.Red.Name;

                    return;
                }

                if (yearvalue > 2050)
                {
                    BorderColorSelectedProductExpirationDateMyWarehouseControlTab = "DarkViolet";

                    WarehouseEventTextValue = $"Значение года \"Срок годности\" слишком велико.";
                    WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                    WarehouseEventIconColor = Color.Red.Name;

                    return;
                }


                BorderColorSelectedProductExpirationDateMyWarehouseControlTab = "Green";

                WarehouseEventTextValue = $"Значение \"Срок годности\" продукта изменено.";
                WarehouseEventIconValue = Icons.Name.Regular_CircleCheck.ToString();
                WarehouseEventIconColor = Color.LimeGreen.Name;

            }
            else
            {
                BorderColorSelectedProductExpirationDateMyWarehouseControlTab = "HotPink";
            }
        }

        #endregion
        #region Command ChangePurchaseCostValueOfWarehouseProductCommand: - Change Value Of "Purchase Cost" Of Selected Warhouse Product

        /// <summary>Change Value Of "Purchase Cost" Of Selected Warhouse Product</summary>
        private LambdaCommand? _ChangePurchaseCostValueOfWarehouseProductCommand;

        /// <summary>Change Value Of "Purchase Cost" Of Selected Warhouse Product</summary>
        public ICommand ChangePurchaseCostValueOfWarehouseProductCommand => _ChangePurchaseCostValueOfWarehouseProductCommand ??= new(OnChangePurchaseCostValueOfWarehouseProductCommandExecuted);

        /// <summary>Логика выполнения - Change Value Of "Purchase Cost" Of Selected Warhouse Product</summary>

        private void OnChangePurchaseCostValueOfWarehouseProductCommandExecuted(object? p)
        {
            if (SelectedWarehouseProduct is null)
            {
                return;
            }

            if (SelectedProductId != SelectedWarehouseProduct.Id.ToString())
            {
                return;
            }

            if (SelectedProductPurchaseCost != SelectedWarehouseProduct.PurchaseCost.ToString())
            {
                if (string.IsNullOrEmpty(SelectedProductPurchaseCost))
                {
                    BorderColorSelectedProductPurchaseCostMyWarehouseControlTab = "DarkViolet";

                    WarehouseEventTextValue = $"Не задано значение \"Цена\" продукта.";
                    WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                    WarehouseEventIconColor = Color.Red.Name;

                    return;
                }

                bool isLetter = false;
                foreach (char c in SelectedProductPurchaseCost)
                {
                    if (!char.IsDigit(c))
                    {
                        isLetter = true;
                        break;
                    }
                }

                if (isLetter)
                {
                    BorderColorSelectedProductPurchaseCostMyWarehouseControlTab = "DarkViolet";

                    WarehouseEventTextValue = $"Значение \"Цена\" указано некорректно.";
                    WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                    WarehouseEventIconColor = Color.Red.Name;

                    return;
                }

                int coastValue = Convert.ToInt16(SelectedProductPurchaseCost);

                if (coastValue < 0)
                {
                    BorderColorSelectedProductPurchaseCostMyWarehouseControlTab = "DarkViolet";

                    WarehouseEventTextValue = $"Значение \"Цена\" отрицательное.";
                    WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                    WarehouseEventIconColor = Color.Red.Name;

                    return;
                }

                BorderColorSelectedProductPurchaseCostMyWarehouseControlTab = "Green";

                WarehouseEventTextValue = $"Значение \"Цена\" продукта изменено.";
                WarehouseEventIconValue = Icons.Name.Regular_CircleCheck.ToString();
                WarehouseEventIconColor = Color.LimeGreen.Name;

            }
            else
            {
                BorderColorSelectedProductPurchaseCostMyWarehouseControlTab = "HotPink";
            }


        }

        #endregion
        #region Command ChangeReceiptDateValueOfWarehouseProductCommand: - Change Value Of "Receipt Date" Of Selected Warhouse Product

        /// <summary>Change Value Of "Receipt Date" Of Selected Warhouse Product</summary>
        private LambdaCommand? _ChangeReceiptDateValueOfWarehouseProductCommand;

        /// <summary>Change Value Of "Receipt Date" Of Selected Warhouse Product</summary>
        public ICommand ChangeReceiptDateValueOfWarehouseProductCommand => _ChangeReceiptDateValueOfWarehouseProductCommand ??= new(OnChangeReceiptDateValueOfWarehouseProductCommandExecuted);

        /// <summary>Логика выполнения - Change Value Of "Receipt Date" Of Selected Warhouse Product</summary>

        private void OnChangeReceiptDateValueOfWarehouseProductCommandExecuted(object? p)
        {

            if (SelectedWarehouseProduct is null)
            {
                return;
            }

            if (SelectedProductId != SelectedWarehouseProduct.Id.ToString())
            {
                return;
            }

            if (SelectedProductReceiptDate != SelectedWarehouseProduct.ReceiptDate.ToString()[..10])
            {
                if (string.IsNullOrEmpty(SelectedProductReceiptDate))
                {
                    BorderColorSelectedProductReceiptDateMyWarehouseControlTab = "DarkViolet";

                    WarehouseEventTextValue = $"Не задано значение \"Дата поступления\" продукта.";
                    WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                    WarehouseEventIconColor = Color.Red.Name;

                    return;
                }

                if (SelectedProductReceiptDate.Length != 10)
                {
                    BorderColorSelectedProductReceiptDateMyWarehouseControlTab = "DarkViolet";

                    WarehouseEventTextValue = $"Формат значения \"Дата поступления\" некоректный (дд.мм.гггг).";
                    WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                    WarehouseEventIconColor = Color.Red.Name;

                    return;
                }

                DateTime dt;
                if (!DateTime.TryParse(SelectedProductReceiptDate, out dt))
                {
                    BorderColorSelectedProductReceiptDateMyWarehouseControlTab = "DarkViolet";

                    WarehouseEventTextValue = $"Значение \"Дата поступления\" некоректно.";
                    WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                    WarehouseEventIconColor = Color.Red.Name;

                    return;
                }

                BorderColorSelectedProductReceiptDateMyWarehouseControlTab = "Green";

                WarehouseEventTextValue = $"Значение \"Дата поступления\" продукта изменено.";
                WarehouseEventIconValue = Icons.Name.Regular_CircleCheck.ToString();
                WarehouseEventIconColor = Color.LimeGreen.Name;

            }
            else
            {
                BorderColorSelectedProductExpirationDateMyWarehouseControlTab = "HotPink";
            }


        }

        #endregion
        
        #region Command ChangeSoldCostValueOfWarehouseProductCommand: - Change Value Of Of "Sold Coast" Of Selected Warehouse Product

        /// <summary>Change Value Of Of "Sold Coast" Of Selected Warehouse Product</summary>
        private LambdaCommand? _ChangeSoldCostValueOfWarehouseProductCommand;

        /// <summary>Change Value Of Of "Sold Coast" Of Selected Warehouse Product</summary>
        public ICommand ChangeSoldCostValueOfWarehouseProductCommand => _ChangeSoldCostValueOfWarehouseProductCommand ??= new(OnChangeSoldCostValueOfWarehouseProductCommandExecuted);

        /// <summary>Логика выполнения - Change Value Of Of "Sold Coast" Of Selected Warehouse Product</summary>

        private void OnChangeSoldCostValueOfWarehouseProductCommandExecuted(object? p)
        {
            if (string.IsNullOrEmpty(SelectedProductSoldCost))
            {
                BorderColorSelectedProductSoldCostMyWarehouseControlTab = "DarkViolet";
                IconSoldCostChangeValue = "Regular_CircleXmark";
                IconSoldCostColorSendToSoldProducts = "Red";

                WarehouseEventTextValue = "Значение \"Стоимость продажи\" продукта не задано.";
                WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                WarehouseEventIconColor = Color.Red.Name;

                return;
            }

            if (string.IsNullOrWhiteSpace(SelectedProductSoldCost))
            {
                BorderColorSelectedProductSoldCostMyWarehouseControlTab = "DarkViolet";
                IconSoldCostChangeValue = "Regular_CircleXmark";
                IconSoldCostColorSendToSoldProducts = "Red";

                WarehouseEventTextValue = "Значение \"Стоимость продажи\" продукта задано как ПРОБЕЛ!";
                WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                WarehouseEventIconColor = Color.Red.Name;

                return;
            }

            foreach (char c in SelectedProductSoldCost)
            {
                if (!char.IsDigit(c))
                {
                    BorderColorSelectedProductSoldCostMyWarehouseControlTab = "DarkViolet";
                    IconSoldCostChangeValue = "Regular_CircleXmark";
                    IconSoldCostColorSendToSoldProducts = "Red";

                    WarehouseEventTextValue = "Значение \"Стоимость продажи\" продукта задано некорректно.";
                    WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                    WarehouseEventIconColor = Color.Red.Name;

                    return;
                }
            }

            if (SelectedProductSoldCost.Length > 1 && SelectedProductSoldCost[0] == '0')
            {
                BorderColorSelectedProductSoldCostMyWarehouseControlTab = "DarkViolet";
                IconSoldCostChangeValue = "Regular_CircleXmark";
                IconSoldCostColorSendToSoldProducts = "Red";

                WarehouseEventTextValue = "Значение \"Стоимость продажи\" продукта задано некорректно (первая цифра 0).";
                WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                WarehouseEventIconColor = Color.Red.Name;


                return;

            }

            BorderColorSelectedProductSoldCostMyWarehouseControlTab = "HotPink";
            IconSoldCostChangeValue = "Regular_CircleCheck";
            IconSoldCostColorSendToSoldProducts = "LimeGreen";

            WarehouseEventTextValue = "Значение \"Стоимость продажи\" продукта изменено.";
            WarehouseEventIconValue = Icons.Name.Regular_CircleCheck.ToString();
            WarehouseEventIconColor = Color.LimeGreen.Name;
        }

        #endregion
        #region Command ChangeSoldDateValueOfWarhouseProductCommand: - Change Value Of "Sold Date" Of Selected Warehouse Product

        /// <summary>Change Value Of "Sold Date" Of Selected Warehouse Product</summary>
        private LambdaCommand? _ChangeSoldDateValueOfWarhouseProductCommand;

        /// <summary>Change Value Of "Sold Date" Of Selected Warehouse Product</summary>
        public ICommand ChangeSoldDateValueOfWarhouseProductCommand => _ChangeSoldDateValueOfWarhouseProductCommand ??= new(OnChangeSoldDateValueOfWarhouseProductCommandExecuted);

        /// <summary>Логика выполнения - Change Value Of "Sold Date" Of Selected Warehouse Product</summary>

        private void OnChangeSoldDateValueOfWarhouseProductCommandExecuted(object? p)
        {
            if (string.IsNullOrEmpty(SelectedProductSoldDate))
            {
                BorderColorSelectedProductSoldDateMyWarehouseControlTab = "DarkViolet";
                IconSoldDateChangeValue = "Regular_CircleXmark";
                IconSoldDateColorSendToSoldProducts = "Red";

                WarehouseEventTextValue = "Значение \"Дата продажи\" продукта не задано.";
                WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                WarehouseEventIconColor = Color.Red.Name;

                return;
            }

            if (SelectedProductSoldDate.Length != 10)
            {
                BorderColorSelectedProductSoldDateMyWarehouseControlTab = "DarkViolet";
                IconSoldDateChangeValue = "Regular_CircleXmark";
                IconSoldDateColorSendToSoldProducts = "Red";

                WarehouseEventTextValue = "Значение \"Дата продажи\" продукта не задано (dd.MM.yyyy).";
                WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                WarehouseEventIconColor = Color.Red.Name;

                return;
            }

            DateTime dt;
            if (!DateTime.TryParse(SelectedProductSoldDate, out dt))
            {
                BorderColorSelectedProductSoldDateMyWarehouseControlTab = "DarkViolet";
                IconSoldDateChangeValue = "Regular_CircleXmark";
                IconSoldDateColorSendToSoldProducts = "Red";

                WarehouseEventTextValue = "Значение \"Дата продажи\" продукта не задано (dd.MM.yyyy).";
                WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                WarehouseEventIconColor = Color.Red.Name;

                return;
            }

            BorderColorSelectedProductSoldDateMyWarehouseControlTab = "HotPink";
            IconSoldDateChangeValue = "Regular_CircleCheck";
            IconSoldDateColorSendToSoldProducts = "LimeGreen";

            WarehouseEventTextValue = "Значение \"Дата продажи\" продукта изменено.";
            WarehouseEventIconValue = Icons.Name.Regular_CircleCheck.ToString();
            WarehouseEventIconColor = Color.LimeGreen.Name;

        }

        #endregion
        #region Command ChangeCustomerIdValueWarehouseProductCommand: - Change Value Of "Customer Id" Of Selected Warehouse Product

        /// <summary>Change Value Of "Customer Id" Of Selected Warehouse Product</summary>
        private LambdaCommand? _ChangeCustomerIdValueWarehouseProductCommand;

        /// <summary>Change Value Of "Customer Id" Of Selected Warehouse Product</summary>
        public ICommand ChangeCustomerIdValueWarehouseProductCommand => _ChangeCustomerIdValueWarehouseProductCommand ??= new(OnChangeCustomerIdValueWarehouseProductCommandExecuted);

        /// <summary>Логика выполнения - Change Value Of "Customer Id" Of Selected Warehouse Product</summary>

        private void OnChangeCustomerIdValueWarehouseProductCommandExecuted(object? p)
        {
            if (string.IsNullOrEmpty(SelectedProductCustomerId))
            {
                WarehouseEventTextValue = "Значение \"Выбранный продукт\" равно NULL!";
                WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                WarehouseEventIconColor = Color.Red.Name;

                return;
            }

            if (char.IsWhiteSpace(SelectedProductCustomerId[0]))
            {
                BorderColorSelectedProductCustomerIdMyWarehouseControlTab = "DarkViolet";
                IconCustomerIdChangeValue = "Regular_CircleXmark";
                IconCustomerIdColorSendToSoldProducts = "Red";

                WarehouseEventTextValue = "Значение \"Id Клиента\" начинается с пробела.";
                WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                WarehouseEventIconColor = Color.Red.Name;

                return;
            }

            BorderColorSelectedProductCustomerIdMyWarehouseControlTab = "HotPink";
            IconCustomerIdChangeValue = "Regular_CircleCheck";
            IconCustomerIdColorSendToSoldProducts = "LimeGreen";

            WarehouseEventTextValue = "Значение \"Id Киента\" изменено.";
            WarehouseEventIconValue = Icons.Name.Regular_CircleCheck.ToString();
            WarehouseEventIconColor = Color.LimeGreen.Name;
        }

        #endregion


        #endregion

    }
}
