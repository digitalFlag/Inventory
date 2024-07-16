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

		#region Command RefreshConnectionToDataBaseWarhouseWindowCommand: - Refresh Connection To BD With Products

		/// <summary>Refresh Connection To BD With Products</summary>
		private LambdaCommand? _RefreshConnectionToDataBaseWarhouseWindowCommand;

		/// <summary>Refresh Connection To BD With Products</summary>
		public ICommand RefreshConnectionToDataBaseWarhouseWindowCommand => _RefreshConnectionToDataBaseWarhouseWindowCommand ??= new(OnRefreshConnectionToDataBaseWarhouseWindowCommandExecuted);

		/// <summary>Логика выполнения - Refresh Connection To BD With Products</summary>

		private void OnRefreshConnectionToDataBaseWarhouseWindowCommandExecuted(object? p)
		{
            var dbSettings = new DBSettings();
            dbSettings.Server = ConnectionOptions.dbServer;
            dbSettings.Port = ConnectionOptions.dbPort;
            dbSettings.Name = ConnectionOptions.dbName;
            dbSettings.UserId = ConnectionOptions.userId;
            dbSettings.Password = ConnectionOptions.password;

            string table = ConnectionOptions.tableWarehouseProducts;

            if (_DataBase is null)
            {
                return;
            }

            LoadedDataTableFromDataBaseMiniWarehouseWindow = _DataBase.GetData(dbSettings, table);


            WarehouseProducts = LoadedDataTableFromDataBaseMiniWarehouseWindow.AsEnumerable().Select(row => new Models.WarehouseProduct
            {
                Id = Convert.ToInt32(row["Id"]),
                Tittle = Convert.ToString(row["Tittle_Product"]),
                Property = Convert.ToString(row["Property_Product"]),
                Size = Convert.ToString(row["Size_Product"]),
                ExpirationDate = Convert.ToDateTime(row["ExpirationDate_Product"]),
                Location = Convert.ToString(row["Location_Product"]),
                PurchaseCost = Convert.ToInt16(row["PurchaseCost_Product"]),
                OrderNumber = Convert.ToString(row["OrderNumber_Product"]),
                ReceiptDate = Convert.ToDateTime(row["ReceiptDate_Product"]),
                Note = Convert.ToString(row["Note_Product"]),
            });

            TextLabelEventLogMyWarehouseTabControlWarehouseWindow = $"Информация о продукции на Мини-Складе из базы \"{ConnectionOptions.dbName}\" загружена.";

            SelectedProductTittle = string.Empty;



            OnPropertyChanged();
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
            if (string.IsNullOrEmpty(SelectedProductId))
            {
                TextLabelEventLogMyWarehouseTabControlWarehouseWindow = $"Не выбран \"Продукт\" из списка.";
            }

            if (SelectedWarehouseProduct is null)
            {
                return;
            }

            if (BorderColorSelectedProductTittleMyWarehouseControlTab == "Green")
            {
                var dbSettings = new DBSettings
                {
                    Server = ConnectionOptions.dbServer,
                    Port = ConnectionOptions.dbPort,
                    Name = ConnectionOptions.dbName,
                    UserId = ConnectionOptions.userId,
                    Password = ConnectionOptions.password
                };

                string tableTittle = ConnectionOptions.tableWarehouseProducts;
                string columnTittle = "Tittle_Product";

                if (SelectedWarehouseProduct.Id is null)
                {
                    return;
                }
                if (_DataBase is null)
                {
                    return;
                }
                if (SelectedProductTittle is null)
                {
                    return;
                }

                string id = SelectedWarehouseProduct.Id.ToString();

                _DataBase.UpdateRecord(dbSettings, tableTittle, columnTittle, id, SelectedProductTittle);

                TextLabelEventLogMyWarehouseTabControlWarehouseWindow = "Значение названия выбранного продукта изменено.";
                BorderColorSelectedProductTittleMyWarehouseControlTab = "HotPink";
            }

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
                    TextLabelEventLogMyWarehouseTabControlWarehouseWindow = $"Не задано значение \"Название\" продукта.";

                    return;
                }

                BorderColorSelectedProductTittleMyWarehouseControlTab = "Green";
                TextLabelEventLogMyWarehouseTabControlWarehouseWindow = $"Значение \"Название\" продукта изменено.";

            }
            else 
            {
                BorderColorSelectedProductTittleMyWarehouseControlTab = "HotPink";
            }
        }

        #endregion


    }
}
