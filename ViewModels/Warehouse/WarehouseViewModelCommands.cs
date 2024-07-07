using Inventory.Commands;
using Inventory.Resources.Constants;
using Inventory.ViewModels.Base;
using Microsoft.VisualBasic;
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
			if (_DataBaseConnection is null)
			{
				return;
            }

			LoadedDataTableFromDataBaseMiniWarehouseWindow = _DataBaseConnection.LoadDataFromTable(ConnectionOptions.dbServer, 
																								   ConnectionOptions.dbPort,
																								   ConnectionOptions.dbName,
																								   ConnectionOptions.userId,
																								   ConnectionOptions.password,
                                                                                                   "Products_MyWareHouse");

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

        }

        #endregion



    }
}
