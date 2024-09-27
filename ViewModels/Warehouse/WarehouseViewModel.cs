using Inventory.Models;
using Inventory.Resources.Constants;
using Inventory.Services;
using Inventory.ViewModels.Base;
using System.Data;
using System.Drawing;

namespace Inventory.ViewModels.Warehouse
{
    public partial class WarehouseViewModel : DialogViewModel
    {
        private readonly IDataBase? _DataBase = null;

        public WarehouseViewModel() 
        {

            NameOfWarhouseWindow = "Мини-Cклад";
            ConnectionItemMainMenuWarehouseWindow = "Соединение";
            RefreshItemConnectionMainMenuWarehouseWindow = "Обновить";

            MyMiniWarehouse = "Мой Мини-Склад";
            AddToMyMiniWarehouse = "Добавить Продукцию на Мини-Склад";
            SoldProductsFromMyWarehouse = "Реализованная продукция";
            OptionsMyWarehouseTabWarhouseWindow = "Действия:";
            DownloadDataMyProductsWarehouseWindow = "Обновить данные";

            #region GENERAL PROPERTIES

            LabelTittleProduct = "Наименование:";
            LabelPropertyProduct = "Тип:";
            LabelSizeProduct = "Размер:";
            LabelExpirationDateProduct = "Срок годности:";
            LabelPurchaseCostProduct = "Стоимость покупки:";
            LabelLocationProduct = "Место хранения:";
            LabelReceiptDateProduct = "Дата поступления:";
            LabelOrderNumberProduct = "Номер заказа:";
            LabelNoteProduct = "Примечание:";
            LabelIdProduct = "Номер позиции:";
            LabelSoldCostProduct = "Стоимость продажи:";
            LabelSoldDateProduct = "Дата продажи:";
            LadelCustomerId = "Id Клиента:";

            WarehouseEventIconValue = Icons.Name.Regular_CircleCheck.ToString();
            WarehouseEventIconColor = Color.Green.Name;
            WarehouseEventTextValue = string.Empty;

            #endregion

            #region WAREHOUSE PRODUCTS

            LoadedDataTableFromDataBaseMiniWarehouseWindow = new DataTable();
            SelectedWarehouseProduct = new WarehouseProduct();

            BorderColorSelectedProductTittleMyWarehouseControlTab = Color.HotPink.Name;
            BorderColorSelectedProductPropertyMyWarehouseControlTab = Color.HotPink.Name;
            BorderColorSelectedProductSizeMyWarehouseControlTab = Color.HotPink.Name;
            BorderColorSelectedProductExpirationDateMyWarehouseControlTab = Color.HotPink.Name;
            BorderColorSelectedProductPurchaseCostMyWarehouseControlTab = Color.HotPink.Name;
            BorderColorSelectedProductLocationMyWarehouseControlTab = Color.HotPink.Name;
            BorderColorSelectedProductReceiptDateMyWarehouseControlTab = Color.HotPink.Name;
            BorderColorSelectedProductOrderNumberMyWarehouseControlTab = Color.HotPink.Name;
            BorderColorSelectedProductNoteMyWarehouseControlTab = Color.HotPink.Name;
            BorderColorSelectedProductSoldCostMyWarehouseControlTab = Color.HotPink.Name;
            BorderColorSelectedProductSoldDateMyWarehouseControlTab = Color.HotPink.Name;
            BorderColorSelectedProductCustomerIdMyWarehouseControlTab = Color.HotPink.Name;

            ButtonCaptionReWriteWareHouseProduct = "Корректировать данные";
            ButtonCaptionSoldOutWarehouseProduct = "Продано";

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
            SelectedProductSoldCost = string.Empty;
            SelectedProductSoldDate = DateTime.Now.ToString("dd.MM.yyyy");
            SelectedProductCustomerId = string.Empty;

            IconSoldCostChangeValue = Icons.Name.Regular_CircleXmark.ToString();
            IconSoldCostColorSendToSoldProducts = Color.Red.Name;
            IconSoldDateChangeValue = Icons.Name.Regular_CircleCheck.ToString();
            IconSoldDateColorSendToSoldProducts = Color.LimeGreen.Name;
            IconCustomerIdChangeValue  = Icons.Name.Regular_CircleQuestion.ToString();
            IconCustomerIdColorSendToSoldProducts = Color.Gray.Name;

            TabItemFiltersMyWarehouseItem = "Фильтры";
            TabItemSelectedProductMyWarehouseItem = "Выбранный продукт";
            IconFiltersTabControlInMyWarehouseItemValue = Icons.Name.Solid_FilterCircleXmark.ToString();


            FilterTittleForMyWarehouseProducts = string.Empty;
            FilterPropertyForMyWarehouseProducts = string.Empty;
            FilterExpirationDateStartForMyWarehouseProducts = string.Empty;
            SelectedDateExpirationDateStartFilterMyWarehouseProducts = DateTime.Now;
            FilterExpirationDateStopForMyWarehouseProducts = string.Empty;
            SelectedDateExpirationDateStopFilterMyWarehouseProducts = DateTime.Now;
            FilterPurchaseCostStartForMyWarehouseProducts = string.Empty;
            FilterPurchaseCostStopForMyWarehouseProducts = string.Empty;
            FilterLocationForMyWarehouseProducts = string.Empty;
            ListOfComboBoxLocationPossibleValues = [];
            SelectedItemOfComboBoxLocationInFilterPanelMyWarehouseProducts = string.Empty;
            SelectedDateReceiptDateStartFilterMyWarehouseProducts = DateTime.Now;
            SelectedDateReceiptDateStopFilterMyWarehouseProducts = DateTime.Now;
            FilterReceiptDateStartForMyWarehouseProducts = string.Empty;
            FilterReceiptDateStopForMyWarehouseProducts = string.Empty;

            #endregion

            #region SOLD PRODUCTS

            SelectedSoldProduct = new SoldProduct();
            EventTextValueLogSoldProductsTabControl = string.Empty;

            #endregion

            #region ADD NEW PRODUCT TO WAREHOUSE

            TittleProductAddNewToWarehouse = string.Empty;
            PropertyProductAddNewToWarehouse = string.Empty;
            SizeProductAddNewToWarehouse = string.Empty;
            ExpirationDateProductAddNewToWarehouse = "**.202*";
            PurchaseCostAddNewToWarehouse = string.Empty;
            ReceiptDateAddNewToWarehouse = string.Empty;
            OrderNumberAddNewToWarehouse = string.Empty;
            NoteAddNewToWarehouse = string.Empty;

            BorderColorTittleAddNewWarehouse = Color.HotPink.Name;
            BorderColorPropertyAddNewWarehouse = Color.HotPink.Name;
            BorderColorSizeAddNewWarehouse = Color.HotPink.Name;
            BorderColorExpirationDateAddNewWarehouse = Color.DarkViolet.Name;
            BorderColorPurchaseCostAddNewWarehouse = Color.DarkViolet.Name;
            BorderColorLocationAddNewWarehouse = Color.HotPink.Name;
            BorderColorReceiptDateAddNewWarehouse = Color.HotPink.Name;
            BorderColorOrderNumberAddNewWarehouse = Color.HotPink.Name;
            BorderColorNoteAddNewWarehouse = Color.HotPink.Name;
            BorderColorIdAddNewWarehouse = Color.HotPink.Name;

            ButtonTittleAddToWarewouseAddToWarehousePannel = "Добавить на Мини-Склад";

            WarehouseEventTextValue = string.Empty;

            IconTittleChangeValue = Icons.Name.Regular_CircleCheck.ToString();
            IcomTittleColorAddNewProduct = Color.Gray.Name;
            IconPropertyChangeValue = Icons.Name.Regular_CircleCheck.ToString();
            IconPropertyColorAddNewProduct = Color.Gray.Name;
            IconSizeChangeValue = Icons.Name.Regular_CircleCheck.ToString();
            IconSizeColorAddNewProduct = Color.Gray.Name;
            IconNoteChangeValue = Icons.Name.Regular_CircleCheck.ToString();
            IconNoteColorAddNewProduct = Color.LimeGreen.Name;
            IconExpirationDateChangeValue = Icons.Name.Regular_CircleXmark.ToString();
            IconExpirationDateColorAddNewProduct = Color.Red.Name;
            IconCostChangeValue = Icons.Name.Regular_CircleXmark.ToString();
            IconCostColorAddNewProduct = Color.Red.Name;
            IconLocationChangeValue = Icons.Name.Regular_CircleCheck.ToString();
            IconLocationColorAddNewProduct = Color.LimeGreen.Name;
            IconReceiptDateValue = Icons.Name.Regular_CircleXmark.ToString();
            IconReceiptDateColorAddNewProduct = Color.Red.Name;
            IconOrderNumberValue = Icons.Name.Regular_CircleXmark.ToString();
            IconOrderNumberColorAddNewProduct = Color.Red.Name;

            LoadedDataTableOfActualProducts = new DataTable();
            ListOfActualProductsTittles = [];
            ListOfActualProductProperties = [];
            ListOfPossibleProductLocations = [];
            ListOfPossibleProductLocations.Add("Дом");
            ListOfPossibleProductLocations.Add("Офис");
            SelectedIndexOfComboBoxProductProperty = 0;

            ValueOfSelectedItemComboBoxTittle = string.Empty;
            ValueOfSelectedItemComboBoxLocation = ListOfPossibleProductLocations[0];
            LocationAddNewToWarehouse = ValueOfSelectedItemComboBoxLocation;


            #endregion

        }

        public WarehouseViewModel(IDataBase DataBase) : this()
        {
            _DataBase = DataBase;
        }


    }
}
