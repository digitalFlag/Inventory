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

            #endregion

            #region ADD NEW PRODUCT TO WAREHOUSE

            TittleProductAddNewToWarehouse = string.Empty;
            PropertyProductAddNewToWarehouse = string.Empty;
            SizeProductAddNewToWarehouse = string.Empty;
            ExpirationDateProductAddNewToWarehouse = string.Empty;
            PurchaseCostAddNewToWarehouse = string.Empty;
            LocationAddNewToWarehouse = string.Empty;
            ReceiptDateAddNewToWarehouse = string.Empty;
            OrderNumberAddNewToWarehouse = string.Empty;
            NoteAddNewToWarehouse = string.Empty;

            BorderColorTittleAddNewWarehouse = "HotPink";
            BorderColorPropertyAddNewWarehouse = "HotPink";
            BorderColorSizeAddNewWarehouse = "HotPink";
            BorderColorExpirationDateAddNewWarehouse = "HotPink";
            BorderColorPurchaseCostAddNewWarehouse = "HotPink";
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
            ValueOfSelectedItemComboBoxTittle = string.Empty;

            LoadedDataTableOfActualProducts = new DataTable();
            ListOfActualProductsTittles = [];
            ListOfActualProductProperties = [];


            #endregion

        }

        public WarehouseViewModel(IDataBase DataBase) : this()
        {
            _DataBase = DataBase;
        }


    }
}
