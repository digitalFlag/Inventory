using Inventory.Models;
using Inventory.Services;
using Inventory.ViewModels.Base;
using System.Data;

namespace Inventory.ViewModels.Warehouse
{
    public partial class WarehouseViewModel : DialogViewModel
    {
        private readonly IUserDialog? _UserDialog = null;
        private readonly IDataBase? _DataBase = null;

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

            //WareHouse Products
            SelectedWarehouseProduct = new WarehouseProduct();
            LabelSelectedProductTittleMyWarehouseControlTab = "Наименование:";
            BorderColorSelectedProductTittleMyWarehouseControlTab = "HotPink";
            LabelSelectedProductPropertyMyWarehouseControlTab = "Тип:";
            BorderColorSelectedProductPropertyMyWarehouseControlTab = "HotPink";
            LabelSelectedProductSizeMyWarehouseControlTab = "Размер:";
            BorderColorSelectedProductSizeMyWarehouseControlTab = "HotPink";
            LabelSelectedProductExpirationDateMyWarehouseControlTab = "Срок годности:";
            BorderColorSelectedProductExpirationDateMyWarehouseControlTab = "HotPink";
            LabelSelectedProductPurchaseCostMyWarehouseControlTab = "Стоимость покупки:";
            BorderColorSelectedProductPurchaseCostMyWarehouseControlTab = "HotPink";
            LabelSelectedProductLocationMyWarehouseControlTab = "Место хранения:";
            BorderColorSelectedProductLocationMyWarehouseControlTab = "HotPink";
            LabelSelectedProductReceiptDateMyWarehouseControlTab = "Дата поступления:";
            BorderColorSelectedProductReceiptDateMyWarehouseControlTab = "HotPink";
            LabelSelectedProductOrderNumberMyWarehouseControlTab = "Номер заказа:";
            BorderColorSelectedProductOrderNumberMyWarehouseControlTab = "HotPink";
            LabelSelectedProductNoteMyWarehouseControlTab = "Примечание:";
            BorderColorSelectedProductNoteMyWarehouseControlTab = "HotPink";
            LabelSelectedProductIdMyWarehouseControlTab = "Номер позиции:";
            ButtonCaptionReWriteWareHouseProduct = "Корректировать данные";
            TextLabelEventLogMyWarehouseTabControlWarehouseWindow = string.Empty;

            SelectedProductId = string.Empty;
            SelectedProductTittle = string.Empty;
            SelectedProductProperty = string.Empty;
        }

        public WarehouseViewModel(IUserDialog UserDialog, IDataBase DataBase) : this()
        {

            _UserDialog = UserDialog;
            _DataBase = DataBase;

        }


    }
}
