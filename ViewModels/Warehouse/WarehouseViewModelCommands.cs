﻿using Inventory.Commands;
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
            var dbSettings = new DBSettings
            {
                Server = ConnectionOptions.dbServer,
                Port = ConnectionOptions.dbPort,
                Name = ConnectionOptions.dbName,
                UserId = ConnectionOptions.userId,
                Password = ConnectionOptions.password
            };

            string table = WarehouseTable.tableTittleWarehouseProducts;

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
            SelectedProductProperty = string.Empty;


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
            //Tittle
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

                string tableTittle = WarehouseTable.tableTittleWarehouseProducts;
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

                if (id is null)
                {
                    return;
                }

                _DataBase.UpdateRecord(dbSettings, tableTittle, columnTittle, id, SelectedProductTittle);

                TextLabelEventLogMyWarehouseTabControlWarehouseWindow = "Значение названия выбранного продукта изменено.";
                BorderColorSelectedProductTittleMyWarehouseControlTab = "HotPink";
            }
            //Property
            if (BorderColorSelectedProductPropertyMyWarehouseControlTab == "Green")
            {
                var dbSettings = new DBSettings
                {
                    Server = ConnectionOptions.dbServer,
                    Port = ConnectionOptions.dbPort,
                    Name = ConnectionOptions.dbName,
                    UserId = ConnectionOptions.userId,
                    Password = ConnectionOptions.password
                };

                string tableTittle = WarehouseTable.tableTittleWarehouseProducts;
                string columnTittle = "Property_Product";

                if (SelectedWarehouseProduct.Id is null)
                {
                    return;
                }
                if (_DataBase is null)
                {
                    return;
                }
                if (SelectedProductProperty is null)
                {
                    return;
                }

                string id = SelectedWarehouseProduct.Id.ToString();

                if (id is null)
                {
                    return;
                }

                _DataBase.UpdateRecord(dbSettings, tableTittle, columnTittle, id, SelectedProductProperty);

                TextLabelEventLogMyWarehouseTabControlWarehouseWindow = "Значение свойства выбранного продукта изменено.";
                BorderColorSelectedProductPropertyMyWarehouseControlTab = "HotPink";
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
            SelectedProductProperty = SelectedWarehouseProduct.Property;
            SelectedProductSize = SelectedWarehouseProduct.Size;
            SelectedProductExpirationData = SelectedWarehouseProduct.ExpirationDate.ToString();
            SelectedProductPurchaseCost = SelectedWarehouseProduct.PurchaseCost.ToString();
            SelectedProductLocation = SelectedWarehouseProduct.Location;
            SelectedProductReceiptDate = SelectedWarehouseProduct.ReceiptDate.ToString();
            SelectedProductOrderNumber = SelectedWarehouseProduct.OrderNumber;
            SelectedProductNote = SelectedWarehouseProduct.Note;

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
                    TextLabelEventLogMyWarehouseTabControlWarehouseWindow = $"Не задано значение \"Свойство\" продукта.";

                    return;
                }

                BorderColorSelectedProductPropertyMyWarehouseControlTab = "Green";
                TextLabelEventLogMyWarehouseTabControlWarehouseWindow = $"Значение \"Свойство\" продукта изменено.";

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
            //ToDo The Method Is Not Implemented
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
            //ToDo The Method Is Not Implemented
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
            //ToDo The Method Is Not Implemented
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
            //ToDo The Method Is Not Implemented
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
            //ToDo The Method Is Not Implemented
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
            //ToDo The Method Is Not Implemented
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
            //ToDo The Method Is Not Implemented
        }

        #endregion

    }
}
