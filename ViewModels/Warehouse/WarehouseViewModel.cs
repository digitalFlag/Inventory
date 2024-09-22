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

            WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
            WarehouseEventIconColor = Color.DeepPink.ToString();
            WarehouseEventTextValue = string.Empty;

            #endregion

            #region WAREHOUSE PRODUCTS

            LoadedDataTableFromDataBaseMiniWarehouseWindow = new DataTable();
            SelectedWarehouseProduct = new WarehouseProduct();

            BorderColorSelectedProductTittleMyWarehouseControlTab = Color.HotPink.ToString();
            BorderColorSelectedProductPropertyMyWarehouseControlTab = Color.HotPink.ToString();
            BorderColorSelectedProductSizeMyWarehouseControlTab = Color.HotPink.ToString();
            BorderColorSelectedProductExpirationDateMyWarehouseControlTab = Color.HotPink.ToString();
            BorderColorSelectedProductPurchaseCostMyWarehouseControlTab = Color.HotPink.ToString();
            BorderColorSelectedProductLocationMyWarehouseControlTab = Color.HotPink.ToString();
            BorderColorSelectedProductReceiptDateMyWarehouseControlTab = Color.HotPink.ToString();
            BorderColorSelectedProductOrderNumberMyWarehouseControlTab = Color.HotPink.ToString();
            BorderColorSelectedProductNoteMyWarehouseControlTab = Color.HotPink.ToString();
            BorderColorSelectedProductSoldCostMyWarehouseControlTab = Color.HotPink.ToString();
            BorderColorSelectedProductSoldDateMyWarehouseControlTab = Color.HotPink.ToString();
            BorderColorSelectedProductCustomerIdMyWarehouseControlTab = Color.HotPink.ToString();

            ButtonCaptionReWriteWareHouseProduct = "Корректировать данные";
            ButtonCaptionSoldOutWarehouseProduct = "Продано";

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

            IconSoldCostChangeValue = Icons.Name.Regular_CircleXmark.ToString();
            IconSoldCostColorSendToSoldProducts = Color.Red.ToString();
            IconSoldDateChangeValue = Icons.Name.Regular_CircleCheck.ToString();
            IconSoldDateColorSendToSoldProducts = Color.LimeGreen.ToString();
            IconCustomerIdChangeValue  = Icons.Name.Regular_CircleQuestion.ToString();
            IconCustomerIdColorSendToSoldProducts = Color.Gray.ToString();

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

            BorderColorTittleAddNewWarehouse = Color.HotPink.ToString();
            BorderColorPropertyAddNewWarehouse = Color.HotPink.ToString();
            BorderColorSizeAddNewWarehouse = Color.HotPink.ToString();
            BorderColorExpirationDateAddNewWarehouse = Color.DarkViolet.ToString();
            BorderColorPurchaseCostAddNewWarehouse = Color.DarkViolet.ToString();
            BorderColorLocationAddNewWarehouse = Color.HotPink.ToString();
            BorderColorReceiptDateAddNewWarehouse = Color.HotPink.ToString();
            BorderColorOrderNumberAddNewWarehouse = Color.HotPink.ToString();
            BorderColorNoteAddNewWarehouse = Color.HotPink.ToString();
            BorderColorIdAddNewWarehouse = Color.HotPink.ToString();

            ButtonTittleAddToWarewouseAddToWarehousePannel = "Добавить на Мини-Склад";

            WarehouseEventTextValue = string.Empty;

            IconTittleChangeValue = Icons.Name.Regular_CircleCheck.ToString();
            IcomTittleColorAddNewProduct = Color.Gray.ToString();
            IconPropertyChangeValue = Icons.Name.Regular_CircleCheck.ToString();
            IconPropertyColorAddNewProduct = Color.Gray.ToString();
            IconSizeChangeValue = Icons.Name.Regular_CircleCheck.ToString();
            IconSizeColorAddNewProduct = Color.Gray.ToString();
            IconNoteChangeValue = Icons.Name.Regular_CircleCheck.ToString();
            IconNoteColorAddNewProduct = Color.LimeGreen.ToString();
            IconExpirationDateChangeValue = Icons.Name.Regular_CircleXmark.ToString();
            IconExpirationDateColorAddNewProduct = Color.Red.ToString();
            IconCostChangeValue = Icons.Name.Regular_CircleXmark.ToString();
            IconCostColorAddNewProduct = Color.Red.ToString();
            IconLocationChangeValue = Icons.Name.Regular_CircleCheck.ToString();
            IconLocationColorAddNewProduct = Color.LimeGreen.ToString();
            IconReceiptDateValue = Icons.Name.Regular_CircleXmark.ToString();
            IconReceiptDateColorAddNewProduct = Color.Red.ToString();
            IconOrderNumberValue = Icons.Name.Regular_CircleXmark.ToString();
            IconOrderNumberColorAddNewProduct = Color.Red.ToString();

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
