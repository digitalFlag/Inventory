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
        #region Dependencies

        #region LoadedDataTableFromDataBaseSoldProducts: - Loaded "DataTable" From SQL DB For "Sold Products Window"

        /// <summary>Loaded "DataTable" From SQL DB For "Sold Products Window"</summary>
        private DataTable? _LoadedDataTableFromDataBaseSoldProducts;

        /// <summary>Loaded "DataTable" From SQL DB For "Sold Products Window"</summary>

        public DataTable? LoadedDataTableFromDataBaseSoldProducts { get => _LoadedDataTableFromDataBaseSoldProducts; set => Set(ref _LoadedDataTableFromDataBaseSoldProducts, value); }

        #endregion

        #region SoldProducts: - Products On Sold List

        /// <summary>Products On Sold List</summary>
        private IEnumerable<SoldProduct>? _SoldProducts;

        /// <summary>Products On Sold List</summary>

        public IEnumerable<SoldProduct>? SoldProducts { get => _SoldProducts; set => Set(ref _SoldProducts, value); }

        #endregion

        #region SelectedSoldProduct: - Selected Sold Product

        /// <summary>Selected Sold Product</summary>
        private SoldProduct? _SelectedSoldProduct;

        /// <summary>Selected Sold Product</summary>

        public SoldProduct? SelectedSoldProduct { get => _SelectedSoldProduct; set => Set(ref _SelectedSoldProduct, value); }

        #endregion

        #region EventTextValueLogSoldProductsTabControl: - Text Of Event Log In Sold Products TabControl In Warehouse Window

        /// <summary>Text Of Event Log In Sold Products TabControl In Warehouse Window</summary>
        private string? _EventTextValueLogSoldProductsTabControl;

        /// <summary>Text Of Event Log In Sold Products TabControl In Warehouse Window</summary>

        public string? EventTextValueLogSoldProductsTabControl { get => _EventTextValueLogSoldProductsTabControl; set => Set(ref _EventTextValueLogSoldProductsTabControl, value); }

        #endregion

        //Filters
        #region LabelFilterModeInFiltersTabItemInSoldProductsItem: - Label Value "Filter Mode" In Filters tabItem In Sold Products Item

        /// <summary>Label Value "Filter Mode" In Filters tabItem In Sold Products Item</summary>
        private string? _LabelFilterModeInFiltersTabItemInSoldProductsItem;

        /// <summary>Label Value "Filter Mode" In Filters tabItem In Sold Products Item</summary>

        public string? LabelFilterModeInFiltersTabItemInSoldProductsItem { get => _LabelFilterModeInFiltersTabItemInSoldProductsItem; set => Set(ref _LabelFilterModeInFiltersTabItemInSoldProductsItem, value); }

        #endregion

        #region FiltersModeSelectForSoldFroducts: - Is Mode "Select" For Filters In Sold Products Item 

        /// <summary>Is Mode "Select" For Filters In Sold Products Item </summary>
        private bool? _FiltersModeSelectForSoldFroducts;

        /// <summary>Is Mode "Select" For Filters In Sold Products Item </summary>

        public bool? FiltersModeSelectForSoldFroducts { get => _FiltersModeSelectForSoldFroducts; set => Set(ref _FiltersModeSelectForSoldFroducts, value); }

        #endregion
        #region ColorOfFillRectungleSelectFilterSoldProductsItem: - Color Of "Rectangle" Select Filter In Sold Products Item
        /// <summary>Color Of "Rectangle" Select Filter In Sold Products Item</summary>
        private string? _ColorOfFillRectungleSelectFilterSoldProductsItem;

        /// <summary>Color Of "Rectangle" Select Filter In Sold Products Item</summary>

        public string? ColorOfFillRectungleSelectFilterSoldProductsItem { get => _ColorOfFillRectungleSelectFilterSoldProductsItem; set => Set(ref _ColorOfFillRectungleSelectFilterSoldProductsItem, value); }

        #endregion
        #region FiltersModeCutForSoldFroducts: - Is Mode "Cut" For Filters In Sold Products Item 

        /// <summary>Is Mode "Cut" For Filters In Sold Products Item </summary>
        private bool? _FiltersModeCutForSoldFroducts;

        /// <summary>Is Mode "Cut" For Filters In Sold Products Item </summary>

        public bool? FiltersModeCutForSoldFroducts { get => _FiltersModeCutForSoldFroducts; set => Set(ref _FiltersModeCutForSoldFroducts, value); }

        #endregion
        #region ColorOfFillRectungleCutFilterSoldProductsItem: - Color Of "Rectangle" Cut Filter In Sold Products Item
        /// <summary>Color Of "Rectangle" Cut Filter In Sold Products Item</summary>
        private string? _ColorOfFillRectungleCutFilterSoldProductsItem;

        /// <summary>Color Of "Rectangle" Cut Filter In Sold Products Item</summary>

        public string? ColorOfFillRectungleCutFilterSoldProductsItem { get => _ColorOfFillRectungleCutFilterSoldProductsItem; set => Set(ref _ColorOfFillRectungleCutFilterSoldProductsItem, value); }

        #endregion



        #endregion

        #region Commands

        #region Command RefreshConnectionToDataBaseSoldProductsCommand: - Refresh Connection To DB With Sold Products

        /// <summary>Refresh Connection To DB With Sold Products</summary>
        private LambdaCommand? _RefreshConnectionToDataBaseSoldProductsCommand;

        /// <summary>Refresh Connection To DB With Sold Products</summary>
        public ICommand RefreshConnectionToDataBaseSoldProductsCommand => _RefreshConnectionToDataBaseSoldProductsCommand ??= new(OnRefreshConnectionToDataBaseSoldProductsCommandExecuted);

        /// <summary>Логика выполнения - Refresh Connection To DB With Sold Products</summary>

        private void OnRefreshConnectionToDataBaseSoldProductsCommandExecuted(object? p)
        {
            var dbSettings = new DBSettings
            {
                Server = ConnectionOptions.dbServer,
                Port = ConnectionOptions.dbPort,
                Name = ConnectionOptions.dbName,
                UserId = ConnectionOptions.userId,
                Password = ConnectionOptions.password
            };

            string table = DbTables.SoldProducts;

            if (_DataBase is null)
            {
                return;
            }

            LoadedDataTableFromDataBaseSoldProducts = _DataBase.GetData(dbSettings, table);

            SoldProducts = LoadedDataTableFromDataBaseSoldProducts.AsEnumerable().Select(row => new Models.SoldProduct
            {
                Id = Convert.ToInt32(row[DbTableSoldProducts.propertyId]),
                Tittle = Convert.ToString(row[DbTableSoldProducts.propertyTittle]),
                Property = Convert.ToString(row[DbTableSoldProducts.propertyProperty]),
                Size = Convert.ToString(row[DbTableSoldProducts.propertySize]),
                ExpirationDate = Convert.ToDateTime(row[DbTableSoldProducts.propertyExpirationDate]),
                PurchaseCost = Convert.ToInt32(row[DbTableSoldProducts.propertyPurchaseCost]),
                SoldCost = Convert.ToInt32(row[DbTableSoldProducts.propertySoldCost]),
                OrderNumber = Convert.ToString(row[DbTableSoldProducts.propertyOrderNumber]),
                ReceiptDate = Convert.ToDateTime(row[DbTableSoldProducts.propertyReceiptDate]),
                SoldDate = Convert.ToDateTime(row[DbTableSoldProducts.propertySoldDate]),
                Note = Convert.ToString(row[DbTableSoldProducts.propertyNote]),
                CustomerId = Convert.ToInt32(row[DbTableSoldProducts.propertyCustomerId]),
            });

            EventTextValueLogSoldProductsTabControl = $"Информация о проданной продукции из базы \"{ConnectionOptions.dbName}\" загружена.";

            //ToDo It's need to set variables values.

        }

        #endregion


        #region Command PushButtonSelectFilterInFilterTabItemInSoldProductsItemCommand: - Push Button "Select" In Filters TabItem In Sold Products Item

        /// <summary>Push Button "Select" In Filters TabItem In Sold Products Item</summary>
        private LambdaCommand? _PushButtonSelectFilterInFilterTabItemInSoldProductsItemCommand;

        /// <summary>Push Button "Select" In Filters TabItem In Sold Products Item</summary>
        public ICommand PushButtonSelectFilterInFilterTabItemInSoldProductsItemCommand => _PushButtonSelectFilterInFilterTabItemInSoldProductsItemCommand ??= new(OnPushButtonSelectFilterInFilterTabItemInSoldProductsItemCommandExecuted);

        /// <summary>Логика выполнения - Push Button "Select" In Filters TabItem In Sold Products Item</summary>

        private void OnPushButtonSelectFilterInFilterTabItemInSoldProductsItemCommandExecuted(object? p)
        {
            FiltersModeSelectForSoldFroducts = true;
            ColorOfFillRectungleSelectFilterSoldProductsItem = Color.HotPink.Name;
            ColorOfFillRectungleCutFilterSoldProductsItem = Color.Pink.Name;

        }

        #endregion
        #region Command PushButtonCutFilterInFilterTabItemInSoldProductsItemCommand: - Push Button "Cut" In Filters TabItem In Sold Products Item

        /// <summary>Push Button "Cut" In Filters TabItem In Sold Products Item</summary>
        private LambdaCommand? _PushButtonCutFilterInFilterTabItemInSoldProductsItemCommand;

        /// <summary>Push Button "Cut" In Filters TabItem In Sold Products Item</summary>
        public ICommand PushButtonCutFilterInFilterTabItemInSoldProductsItemCommand => _PushButtonCutFilterInFilterTabItemInSoldProductsItemCommand ??= new(OnPushButtonCutFilterInFilterTabItemInSoldProductsItemCommandExecuted);

        /// <summary>Логика выполнения - Push Button "Cut" In Filters TabItem In Sold Products Item</summary>

        private void OnPushButtonCutFilterInFilterTabItemInSoldProductsItemCommandExecuted(object? p)
        {
            FiltersModeSelectForSoldFroducts = false;
            ColorOfFillRectungleCutFilterSoldProductsItem = Color.HotPink.Name;
            ColorOfFillRectungleSelectFilterSoldProductsItem = Color.Pink.Name;

        }

        #endregion
        #region Command PushButtonCancelFilterInFilterTabItemInSoldProductsItemCommand: - Push Button "Cancel" In Filters TabItem In Sold Products Item

        /// <summary>Push Button "Cancel" In Filters TabItem In Sold Products Item</summary>
        private LambdaCommand? _PushButtonCancelFilterInFilterTabItemInSoldProductsItemCommand;

        /// <summary>Push Button "Cancel" In Filters TabItem In Sold Products Item</summary>
        public ICommand PushButtonCancelFilterInFilterTabItemInSoldProductsItemCommand => _PushButtonCancelFilterInFilterTabItemInSoldProductsItemCommand ??= new(OnPushButtonCancelFilterInFilterTabItemInSoldProductsItemCommandExeCanceled);

        /// <summary>Логика выполнения - Push Button "Cancel" In Filters TabItem In Sold Products Item</summary>

        private void OnPushButtonCancelFilterInFilterTabItemInSoldProductsItemCommandExeCanceled(object? p)
        {
            //ToDo Its Need To Implement.
        }

        #endregion



        #endregion
    }
}
