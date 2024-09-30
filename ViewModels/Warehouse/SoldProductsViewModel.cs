using Inventory.Commands;
using Inventory.Models;
using Inventory.Resources.Constants;
using Inventory.ViewModels.Base;
using System.Data;
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



        #endregion
    }
}
