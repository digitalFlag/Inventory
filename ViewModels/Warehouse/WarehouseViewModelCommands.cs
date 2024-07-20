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
            if (SelectedWarehouseProduct is null)
            {
                return;
            }

            if (string.IsNullOrEmpty(SelectedProductId))
            {
                TextLabelEventLogMyWarehouseTabControlWarehouseWindow = $"Не выбран \"Продукт\" из списка.";
                return;
            }

            var dbSettings = new DBSettings
            {
                Server = ConnectionOptions.dbServer,
                Port = ConnectionOptions.dbPort,
                Name = ConnectionOptions.dbName,
                UserId = ConnectionOptions.userId,
                Password = ConnectionOptions.password
            };

            string tableTittle = WarehouseTable.tableTittleWarehouseProducts;


            //Tittle
            if (BorderColorSelectedProductTittleMyWarehouseControlTab == "Green")
            {
                string columnTittle = WarehouseTable.propertyTittle;

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
                string columnTittle = WarehouseTable.propertyProperty;

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
            //I am Here.

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
            SelectedProductExpirationData = SelectedWarehouseProduct.ExpirationDate.ToString().Substring(3, 7).Replace('.', '/');
            SelectedProductPurchaseCost = SelectedWarehouseProduct.PurchaseCost.ToString();
            SelectedProductLocation = SelectedWarehouseProduct.Location;
            SelectedProductReceiptDate = SelectedWarehouseProduct.ReceiptDate.ToString().Substring(0, 10);
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
            if (SelectedWarehouseProduct is null)
            {
                return;
            }

            if (SelectedProductId != SelectedWarehouseProduct.Id.ToString())
            {
                return;
            }

            if (SelectedProductSize != SelectedWarehouseProduct.Size)
            {
                if (string.IsNullOrEmpty(SelectedProductSize))
                {
                    BorderColorSelectedProductSizeMyWarehouseControlTab = "DarkViolet";
                    TextLabelEventLogMyWarehouseTabControlWarehouseWindow = $"Не задано значение \"Размер\" продукта.";

                    return;
                }

                BorderColorSelectedProductSizeMyWarehouseControlTab = "Green";
                TextLabelEventLogMyWarehouseTabControlWarehouseWindow = $"Значение \"Размер\" продукта изменено.";

            }
            else
            {
                BorderColorSelectedProductSizeMyWarehouseControlTab = "HotPink";
            }
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
            if (SelectedWarehouseProduct is null)
            {
                return;
            }

            if (SelectedProductId != SelectedWarehouseProduct.Id.ToString())
            {
                return;
            }

            if (SelectedProductLocation != SelectedWarehouseProduct.Location)
            {
                if (string.IsNullOrEmpty(SelectedProductLocation))
                {
                    BorderColorSelectedProductLocationMyWarehouseControlTab = "DarkViolet";
                    TextLabelEventLogMyWarehouseTabControlWarehouseWindow = $"Не задано значение \"Место хранения\" продукта.";

                    return;
                }

                BorderColorSelectedProductLocationMyWarehouseControlTab = "Green";
                TextLabelEventLogMyWarehouseTabControlWarehouseWindow = $"Значение \"Место хранения\" продукта изменено.";

            }
            else
            {
                BorderColorSelectedProductLocationMyWarehouseControlTab = "HotPink";
            }
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
            if (SelectedWarehouseProduct is null)
            {
                return;
            }

            if (SelectedProductId != SelectedWarehouseProduct.Id.ToString())
            {
                return;
            }

            if (SelectedProductOrderNumber != SelectedWarehouseProduct.OrderNumber)
            {
                if (string.IsNullOrEmpty(SelectedProductOrderNumber))
                {
                    BorderColorSelectedProductOrderNumberMyWarehouseControlTab = "DarkViolet";
                    TextLabelEventLogMyWarehouseTabControlWarehouseWindow = $"Не задано значение \"Номер заказа\" продукта.";

                    return;
                }

                BorderColorSelectedProductOrderNumberMyWarehouseControlTab = "Green";
                TextLabelEventLogMyWarehouseTabControlWarehouseWindow = $"Значение \"Номер заказа\" продукта изменено.";

            }
            else
            {
                BorderColorSelectedProductOrderNumberMyWarehouseControlTab = "HotPink";
            }
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
            if (SelectedWarehouseProduct is null)
            {
                return;
            }

            if (SelectedProductId != SelectedWarehouseProduct.Id.ToString())
            {
                return;
            }

            if (SelectedProductNote != SelectedWarehouseProduct.Note)
            {
                if (SelectedProductNote is null)
                {
                    BorderColorSelectedProductNoteMyWarehouseControlTab = "DarkViolet";
                    TextLabelEventLogMyWarehouseTabControlWarehouseWindow = $"Значение \"Примечание\" продукта NULL.";

                    return;
                }

                BorderColorSelectedProductNoteMyWarehouseControlTab = "Green";
                TextLabelEventLogMyWarehouseTabControlWarehouseWindow = $"Значение \"Примечание\" продукта изменено.";

            }
            else
            {
                BorderColorSelectedProductNoteMyWarehouseControlTab = "HotPink";
            }
        }

        #endregion
        #region Command nameCommand: - Change Value Of "Expiration Date" Of Selected Warhouse Product

        /// <summary>Change Value Of "Expiration Date" Of Selected Warhouse Product</summary>
        private LambdaCommand? _nameCommand;

        /// <summary>Change Value Of "Expiration Date" Of Selected Warhouse Product</summary>
        public ICommand ChangeExpirationDateValueOfWarehouseProductCommand => _nameCommand ??= new(OnnameCommandExecuted);

        /// <summary>Логика выполнения - Change Value Of "Expiration Date" Of Selected Warhouse Product</summary>

        private void OnnameCommandExecuted(object? p)
        {
            if (SelectedWarehouseProduct is null)
            {
                return;
            }

            if (SelectedProductId != SelectedWarehouseProduct.Id.ToString())
            {
                return;
            }

            if (SelectedProductExpirationData != SelectedWarehouseProduct.ExpirationDate.ToString().Substring(3, 7).Replace('.', '/'))
            {
                if (string.IsNullOrEmpty(SelectedProductExpirationData))
                {
                    BorderColorSelectedProductExpirationDateMyWarehouseControlTab = "DarkViolet";
                    TextLabelEventLogMyWarehouseTabControlWarehouseWindow = $"Не задано значение \"Срок годности\" продукта.";

                    return;
                }

                if (SelectedProductExpirationData.Length != 7)
                {
                    BorderColorSelectedProductExpirationDateMyWarehouseControlTab = "DarkViolet";
                    TextLabelEventLogMyWarehouseTabControlWarehouseWindow = $"Формат значения \"Срок годности\" некоректный (мм/гггг).";

                    return;
                }

                string mm = SelectedProductExpirationData.Substring(0, 2);
                if (mm != "01" && mm != "02" && mm != "03" && mm != "04" && mm != "05" && mm != "06" && mm != "07" && mm != "08" && mm != "09" && mm != "10" && mm != "11" && mm != "12")
                {
                    BorderColorSelectedProductExpirationDateMyWarehouseControlTab = "DarkViolet";
                    TextLabelEventLogMyWarehouseTabControlWarehouseWindow = $"Формат месяца значения \"Срок годности\" некоректный.";

                    return;
                }

                string yyyy = SelectedProductExpirationData.Substring(3, 4);
                bool isLetter = false;
                foreach (char c in yyyy)
                {
                    if (!char.IsDigit(c))
                    {
                        isLetter = true;
                        break;
                    }
                }
                if (isLetter)
                {
                    BorderColorSelectedProductExpirationDateMyWarehouseControlTab = "DarkViolet";
                    TextLabelEventLogMyWarehouseTabControlWarehouseWindow = $"Формат года значения \"Срок годности\" некоректный.";

                    return;
                }

                uint yearvalue = Convert.ToUInt16(yyyy);
                if (yearvalue < 2000)
                {
                    BorderColorSelectedProductExpirationDateMyWarehouseControlTab = "DarkViolet";
                    TextLabelEventLogMyWarehouseTabControlWarehouseWindow = $"Значение года \"Срок годности\" слишком мало.";

                    return;
                }

                if (yearvalue > 2050)
                {
                    BorderColorSelectedProductExpirationDateMyWarehouseControlTab = "DarkViolet";
                    TextLabelEventLogMyWarehouseTabControlWarehouseWindow = $"Значение года \"Срок годности\" слишком велико.";

                    return;
                }


                BorderColorSelectedProductExpirationDateMyWarehouseControlTab = "Green";
                TextLabelEventLogMyWarehouseTabControlWarehouseWindow = $"Значение \"Срок годности\" продукта изменено.";

            }
            else
            {
                BorderColorSelectedProductExpirationDateMyWarehouseControlTab = "HotPink";
            }
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
            if (SelectedWarehouseProduct is null)
            {
                return;
            }

            if (SelectedProductId != SelectedWarehouseProduct.Id.ToString())
            {
                return;
            }

            if (SelectedProductPurchaseCost != SelectedWarehouseProduct.PurchaseCost.ToString())
            {
                if (string.IsNullOrEmpty(SelectedProductPurchaseCost))
                {
                    BorderColorSelectedProductPurchaseCostMyWarehouseControlTab = "DarkViolet";
                    TextLabelEventLogMyWarehouseTabControlWarehouseWindow = $"Не задано значение \"Цена\" продукта.";

                    return;
                }

                bool isLetter = false;
                foreach (char c in SelectedProductPurchaseCost)
                {
                    if (!char.IsDigit(c))
                    {
                        isLetter = true;
                        break;
                    }
                }

                if (isLetter)
                {
                    BorderColorSelectedProductPurchaseCostMyWarehouseControlTab = "DarkViolet";
                    TextLabelEventLogMyWarehouseTabControlWarehouseWindow = $"Значение \"Цена\" указано некорректно.";

                    return;
                }

                int coastValue = Convert.ToInt16(SelectedProductPurchaseCost);

                if (coastValue < 0)
                {
                    BorderColorSelectedProductPurchaseCostMyWarehouseControlTab = "DarkViolet";
                    TextLabelEventLogMyWarehouseTabControlWarehouseWindow = $"Значение \"Цена\" отрицательное.";

                    return;
                }

                BorderColorSelectedProductPurchaseCostMyWarehouseControlTab = "Green";
                TextLabelEventLogMyWarehouseTabControlWarehouseWindow = $"Значение \"Цена\" продукта изменено.";

            }
            else
            {
                BorderColorSelectedProductPurchaseCostMyWarehouseControlTab = "HotPink";
            }


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

            if (SelectedWarehouseProduct is null)
            {
                return;
            }

            if (SelectedProductId != SelectedWarehouseProduct.Id.ToString())
            {
                return;
            }

            if (SelectedProductReceiptDate != SelectedWarehouseProduct.ReceiptDate.ToString().Substring(0, 10))
            {
                if (string.IsNullOrEmpty(SelectedProductReceiptDate))
                {
                    BorderColorSelectedProductReceiptDateMyWarehouseControlTab = "DarkViolet";
                    TextLabelEventLogMyWarehouseTabControlWarehouseWindow = $"Не задано значение \"Дата поступления\" продукта.";

                    return;
                }

                if (SelectedProductReceiptDate.Length != 10)
                {
                    BorderColorSelectedProductReceiptDateMyWarehouseControlTab = "DarkViolet";
                    TextLabelEventLogMyWarehouseTabControlWarehouseWindow = $"Формат значения \"Дата поступления\" некоректный (дд.мм.гггг).";

                    return;
                }

                DateTime dt;
                if (!DateTime.TryParse(SelectedProductReceiptDate, out dt)) 
                {
                    BorderColorSelectedProductReceiptDateMyWarehouseControlTab = "DarkViolet";
                    TextLabelEventLogMyWarehouseTabControlWarehouseWindow = $"Значение \"Дата поступления\" некоректно.";

                    return;
                }

                BorderColorSelectedProductReceiptDateMyWarehouseControlTab = "Green";
                TextLabelEventLogMyWarehouseTabControlWarehouseWindow = $"Значение \"Дата поступления\" продукта изменено.";

            }
            else
            {
                BorderColorSelectedProductExpirationDateMyWarehouseControlTab = "HotPink";
            }


        }

        #endregion

    }
}
