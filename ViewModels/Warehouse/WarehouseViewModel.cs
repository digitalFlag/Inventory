using Inventory.Models;
using Inventory.Services;
using Inventory.ViewModels.Base;
using System.Data;

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

            #endregion

            #region WAREHOUSE PRODUCTS

            LoadedDataTableFromDataBaseMiniWarehouseWindow = new DataTable();
            SelectedWarehouseProduct = new WarehouseProduct();

            BorderColorSelectedProductTittleMyWarehouseControlTab = "HotPink";
            BorderColorSelectedProductPropertyMyWarehouseControlTab = "HotPink";
            BorderColorSelectedProductSizeMyWarehouseControlTab = "HotPink";
            BorderColorSelectedProductExpirationDateMyWarehouseControlTab = "HotPink";
            BorderColorSelectedProductPurchaseCostMyWarehouseControlTab = "HotPink";
            BorderColorSelectedProductLocationMyWarehouseControlTab = "HotPink";
            BorderColorSelectedProductReceiptDateMyWarehouseControlTab = "HotPink";
            BorderColorSelectedProductOrderNumberMyWarehouseControlTab = "HotPink";
            BorderColorSelectedProductNoteMyWarehouseControlTab = "HotPink";
            BorderColorSelectedProductSoldCostMyWarehouseControlTab = "DarkViolet";
            BorderColorSelectedProductSoldDateMyWarehouseControlTab = "HotPink";
            BorderColorSelectedProductCustomerIdMyWarehouseControlTab = "HotPink";

            ButtonCaptionReWriteWareHouseProduct = "Корректировать данные";

            TextLabelEventLogMyWarehouseTabControlWarehouseWindow = string.Empty;

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
            #endregion

            #region SOLD PRODUCTS

            SelectedSoldProduct = new SoldProduct();

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

            BorderColorTittleAddNewWarehouse = "HotPink";
            BorderColorPropertyAddNewWarehouse = "HotPink";
            BorderColorSizeAddNewWarehouse = "HotPink";
            BorderColorExpirationDateAddNewWarehouse = "DarkViolet";
            BorderColorPurchaseCostAddNewWarehouse = "DarkViolet";
            BorderColorLocationAddNewWarehouse = "HotPink";
            BorderColorReceiptDateAddNewWarehouse = "HotPink";
            BorderColorOrderNumberAddNewWarehouse = "HotPink";
            BorderColorNoteAddNewWarehouse = "HotPink";
            BorderColorIdAddNewWarehouse = "HotPink";

            ButtonTittleAddToWarewouseAddToWarehousePannel = "Добавить на Мини-Склад";

            ValueOfEventLogAddProductToWarehouseTabControl = string.Empty;

            IconTittleChangeValue = "Regular_CircleCheck";
            IcomTittleColorAddNewProduct = "Gray";
            IconPropertyChangeValue = "Regular_CircleCheck";
            IconPropertyColorAddNewProduct = "Gray";
            IconSizeChangeValue = "Regular_CircleCheck";
            IconSizeColorAddNewProduct = "Gray";
            IconNoteChangeValue = "Regular_CircleCheck";
            IconNoteColorAddNewProduct = "LimeGreen";
            IconExpirationDateChangeValue = "Regular_CircleXmark";
            IconExpirationDateColorAddNewProduct = "Red";
            IconCostChangeValue = "Regular_CircleXmark";
            IconCostColorAddNewProduct = "Red";
            IconLocationChangeValue = "Regular_CircleCheck";
            IconLocationColorAddNewProduct = "LimeGreen";
            IconReceiptDateValue = "Regular_CircleXmark";
            IconReceiptDateColorAddNewProduct = "Red";
            IconOrderNumberValue = "Regular_CircleXmark";
            IconOrderNumberColorAddNewProduct = "Red";

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
