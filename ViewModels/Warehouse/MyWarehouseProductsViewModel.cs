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
        #region Dependency Properties

        #region LoadedDataTableFromDataBaseMiniWarehouseWindow: - Loaded "DataTable" From SQL DB For "WareHouse Window" 

        /// <summary>Loaded "DataTable" From SQL DB For "WareHouse Window" </summary>
        private DataTable? _LoadedDataTableFromDataBaseMiniWarehouseWindow;

        /// <summary>Loaded "DataTable" From SQL DB For "WareHouse Window" </summary>

        public DataTable? LoadedDataTableFromDataBaseMiniWarehouseWindow { get => _LoadedDataTableFromDataBaseMiniWarehouseWindow; set => Set(ref _LoadedDataTableFromDataBaseMiniWarehouseWindow, value); }

        #endregion

        #region BorderColorSelectedProductTittleMyWarehouseControlTab: - "Border Color" Of Selected Product At "My Warehouse"

        /// <summary>"Border Color" Of Selected Product At "My Warehouse"</summary>
        private string? _BorderColorSelectedProductTittleMyWarehouseControlTab;

        /// <summary>"Border Color" Of Selected Product At "My Warehouse"</summary>

        public string? BorderColorSelectedProductTittleMyWarehouseControlTab { get => _BorderColorSelectedProductTittleMyWarehouseControlTab; set => Set(ref _BorderColorSelectedProductTittleMyWarehouseControlTab, value); }

        #endregion
        #region BorderColorSelectedProductPropertyMyWarehouseControlTab: - "Border Color" Of Selected Product Property At "My Warehouse"

        /// <summary>"Border Color" Of Selected Product Property At "My Warehouse"</summary>
        private string? _BorderColorSelectedProductPropertyMyWarehouseControlTab;

        /// <summary>"Border Color" Of Selected Product Property At "My Warehouse"</summary>

        public string? BorderColorSelectedProductPropertyMyWarehouseControlTab { get => _BorderColorSelectedProductPropertyMyWarehouseControlTab; set => Set(ref _BorderColorSelectedProductPropertyMyWarehouseControlTab, value); }

        #endregion
        #region BorderColorSelectedProductSizeMyWarehouseControlTab: - "Border Color" Of Selected Product Size At "My Warehouse"

        /// <summary>"Border Color" Of Selected Product Size At "My Warehouse"</summary>
        private string? _BorderColorSelectedProductSizeMyWarehouseControlTab;

        /// <summary>"Border Color" Of Selected Product Size At "My Warehouse"</summary>

        public string? BorderColorSelectedProductSizeMyWarehouseControlTab { get => _BorderColorSelectedProductSizeMyWarehouseControlTab; set => Set(ref _BorderColorSelectedProductSizeMyWarehouseControlTab, value); }

        #endregion
        #region BorderColorSelectedProductExpirationDateMyWarehouseControlTab: - "Border Color" Of Selected Product Expiration Date At "My Warehouse"

        /// <summary>"Border Color" Of Selected Product Expiration Date At "My Warehouse"</summary>
        private string? _BorderColorSelectedProductExpirationDateMyWarehouseControlTab;

        /// <summary>"Border Color" Of Selected Product Expiration Date At "My Warehouse"</summary>

        public string? BorderColorSelectedProductExpirationDateMyWarehouseControlTab { get => _BorderColorSelectedProductExpirationDateMyWarehouseControlTab; set => Set(ref _BorderColorSelectedProductExpirationDateMyWarehouseControlTab, value); }

        #endregion
        #region BorderColorSelectedProductPurchaseCostMyWarehouseControlTab: - "Purchase Cost" Of Selected Product Expiration Date At "My Warehouse"

        /// <summary>"Purchase Cost" Of Selected Product Expiration Date At "My Warehouse"</summary>
        private string? _BorderColorSelectedProductPurchaseCostMyWarehouseControlTab;

        /// <summary>"Purchase Cost" Of Selected Product Expiration Date At "My Warehouse"</summary>

        public string? BorderColorSelectedProductPurchaseCostMyWarehouseControlTab { get => _BorderColorSelectedProductPurchaseCostMyWarehouseControlTab; set => Set(ref _BorderColorSelectedProductPurchaseCostMyWarehouseControlTab, value); }

        #endregion
        #region BorderColorSelectedProductLocationMyWarehouseControlTab: - "Border Color" Of Selected Product Location At "My Warehouse"

        /// <summary>"Border Color" Of Selected Product Location At "My Warehouse"</summary>
        private string? _BorderColorSelectedProductLocationMyWarehouseControlTab;

        /// <summary>"Border Color" Of Selected Product Location At "My Warehouse"</summary>

        public string? BorderColorSelectedProductLocationMyWarehouseControlTab { get => _BorderColorSelectedProductLocationMyWarehouseControlTab; set => Set(ref _BorderColorSelectedProductLocationMyWarehouseControlTab, value); }

        #endregion
        #region BorderColorSelectedProductReceiptDateMyWarehouseControlTab: - "Receipt Date" Of Selected Product Expiration Date At "My Warehouse"

        /// <summary>"Receipt Date" Of Selected Product Expiration Date At "My Warehouse"</summary>
        private string? _BorderColorSelectedProductReceiptDateMyWarehouseControlTab;

        /// <summary>"Receipt Date" Of Selected Product Expiration Date At "My Warehouse"</summary>

        public string? BorderColorSelectedProductReceiptDateMyWarehouseControlTab { get => _BorderColorSelectedProductReceiptDateMyWarehouseControlTab; set => Set(ref _BorderColorSelectedProductReceiptDateMyWarehouseControlTab, value); }

        #endregion
        #region BorderColorSelectedProductOrderNumberMyWarehouseControlTab: - "Border Color" Of Selected Product Order Number At "My Warehouse"

        /// <summary>"Border Color" Of Selected Product Order Number At "My Warehouse"</summary>
        private string? _BorderColorSelectedProductOrderNumberMyWarehouseControlTab;

        /// <summary>"Border Color" Of Selected Product Order Number At "My Warehouse"</summary>

        public string? BorderColorSelectedProductOrderNumberMyWarehouseControlTab { get => _BorderColorSelectedProductOrderNumberMyWarehouseControlTab; set => Set(ref _BorderColorSelectedProductOrderNumberMyWarehouseControlTab, value); }

        #endregion
        #region BorderColorSelectedProductNoteMyWarehouseControlTab: - "Border Color" Of Selected Product Note At "My Warehouse"

        /// <summary>"Border Color" Of Selected Product Note At "My Warehouse"</summary>
        private string? _BorderColorSelectedProductNoteMyWarehouseControlTab;

        /// <summary>"Border Color" Of Selected Product Note At "My Warehouse"</summary>

        public string? BorderColorSelectedProductNoteMyWarehouseControlTab { get => _BorderColorSelectedProductNoteMyWarehouseControlTab; set => Set(ref _BorderColorSelectedProductNoteMyWarehouseControlTab, value); }

        #endregion

        #region ButtonCaptionReWriteWareHouseProduct: - Button Caption "ReWrite Data" In My WareHouse Products

        /// <summary>Button Caption "ReWrite Data" In My WareHouse Products</summary>
        private string? _ButtonCaptionReWriteWareHouseProduct;

        /// <summary>Button Caption "ReWrite Data" In My WareHouse Products</summary>

        public string? ButtonCaptionReWriteWareHouseProduct { get => _ButtonCaptionReWriteWareHouseProduct; set => Set(ref _ButtonCaptionReWriteWareHouseProduct, value); }

        #endregion

        #region SelectedProductId: - Selected Product ID "My Warehouse"

        /// <summary>Selected Product ID "My Warehouse"</summary>
        private string? _SelectedProductId;

        /// <summary>Selected Product ID "My Warehouse"</summary>

        public string? SelectedProductId { get => _SelectedProductId; set => Set(ref _SelectedProductId, value); }

        #endregion
        #region SelectedProductTittle: - Selected Product Tittle "My Warehouse"

        /// <summary>Selected Product Tittle "My Warehouse"</summary>
        private string? _SelectedProductTittle;

        /// <summary>Selected Product Tittle "My Warehouse"</summary>

        public string? SelectedProductTittle { get => _SelectedProductTittle; set => Set(ref _SelectedProductTittle, value); }

        #endregion
        #region SelectedProductProperty: - Selected Product Property "My Warehouse"

        /// <summary>Selected Product Property "My Warehouse"</summary>
        private string? _SelectedProductProperty;

        /// <summary>Selected Product Property "My Warehouse"</summary>

        public string? SelectedProductProperty { get => _SelectedProductProperty; set => Set(ref _SelectedProductProperty, value); }

        #endregion
        #region SelectedProductSize: - Selected Product Size "My Warehouse"

        /// <summary>Selected Product Size "My Warehouse"</summary>
        private string? _SelectedProductSize;

        /// <summary>Selected Product Size "My Warehouse"</summary>

        public string? SelectedProductSize { get => _SelectedProductSize; set => Set(ref _SelectedProductSize, value); }

        #endregion
        #region SelectedProductExpirationData: - Selected Product Expiration Data "My Warehouse"

        /// <summary>Selected Product Expiration Data "My Warehouse"</summary>
        private string? _SelectedProductExpirationData;

        /// <summary>Selected Product Expiration Data "My Warehouse"</summary>

        public string? SelectedProductExpirationData { get => _SelectedProductExpirationData; set => Set(ref _SelectedProductExpirationData, value); }

        #endregion
        #region SelectedProductPurchaseCost: - Selected Product Purchase Cost "My Warehouse"

        /// <summary>Selected Product Purchase Cost "My Warehouse"</summary>
        private string? _SelectedProductPurchaseCost;

        /// <summary>Selected Product Purchase Cost "My Warehouse"</summary>

        public string? SelectedProductPurchaseCost { get => _SelectedProductPurchaseCost; set => Set(ref _SelectedProductPurchaseCost, value); }

        #endregion
        #region SelectedProductLocation: - Selected Product Location "My Warehouse"

        /// <summary>Selected Product Location "My Warehouse"</summary>
        private string? _SelectedProductLocation;

        /// <summary>Selected Product Location "My Warehouse"</summary>

        public string? SelectedProductLocation { get => _SelectedProductLocation; set => Set(ref _SelectedProductLocation, value); }

        #endregion
        #region SelectedProductReceiptDate: - Selected Product Receipt Date "My Warehouse"

        /// <summary>Selected Product Receipt Date "My Warehouse"</summary>
        private string? _SelectedProductReceiptDate;

        /// <summary>Selected Product Receipt Date "My Warehouse"</summary>

        public string? SelectedProductReceiptDate { get => _SelectedProductReceiptDate; set => Set(ref _SelectedProductReceiptDate, value); }

        #endregion
        #region SelectedProductOrderNumber: - Selected Product Order Number "My Warehouse"

        /// <summary>Selected Product Order Number "My Warehouse"</summary>
        private string? _SelectedProductOrderNumber;

        /// <summary>Selected Product Order Number "My Warehouse"</summary>

        public string? SelectedProductOrderNumber { get => _SelectedProductOrderNumber; set => Set(ref _SelectedProductOrderNumber, value); }

        #endregion
        #region SelectedProductNote: - Selected Product Note "My Warehouse"

        /// <summary>Selected Product Note "My Warehouse"</summary>
        private string? _SelectedProductNote;

        /// <summary>Selected Product Note "My Warehouse"</summary>

        public string? SelectedProductNote { get => _SelectedProductNote; set => Set(ref _SelectedProductNote, value); }

        #endregion

        #region TextLabelEventLogMyWarehouseTabControlWarehouseWindow: - Text Of Event Log In MyWarehouse TabControl In Warehouse Window

        /// <summary>Text Of Event Log In MyWarehouse TabControl In Warehouse Window</summary>
        private string? _TextLabelEventLogMyWarehouseTabControlWarehouseWindow;

        /// <summary>Text Of Event Log In MyWarehouse TabControl In Warehouse Window</summary>

        public string? TextLabelEventLogMyWarehouseTabControlWarehouseWindow { get => _TextLabelEventLogMyWarehouseTabControlWarehouseWindow; set => Set(ref _TextLabelEventLogMyWarehouseTabControlWarehouseWindow, value); }

        #endregion


        #endregion


        #region Commands

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

            string table = DbTables.WarehouseProducts;

            if (_DataBase is null)
            {
                return;
            }

            LoadedDataTableFromDataBaseMiniWarehouseWindow = _DataBase.GetData(dbSettings, table);


            WarehouseProducts = LoadedDataTableFromDataBaseMiniWarehouseWindow.AsEnumerable().Select(row => new Models.WarehouseProduct
            {
                Id = Convert.ToInt32(row[DbTableWarehouseProducts.propertyId]),
                Tittle = Convert.ToString(row[DbTableWarehouseProducts.propertyTittle]),
                Property = Convert.ToString(row[DbTableWarehouseProducts.propertyProperty]),
                Size = Convert.ToString(row[DbTableWarehouseProducts.propertySize]),
                ExpirationDate = Convert.ToDateTime(row[DbTableWarehouseProducts.propertyExpirationDate]),
                Location = Convert.ToString(row[DbTableWarehouseProducts.propertyLocation]),
                PurchaseCost = Convert.ToInt16(row[DbTableWarehouseProducts.propertyPurchaseCost]),
                OrderNumber = Convert.ToString(row[DbTableWarehouseProducts.propertyOrderNumber]),
                ReceiptDate = Convert.ToDateTime(row[DbTableWarehouseProducts.propertyReceiptDate]),
                Note = Convert.ToString(row[DbTableWarehouseProducts.propertyNote]),
            });

            TextLabelEventLogMyWarehouseTabControlWarehouseWindow = $"Информация о продукции на Мини-Складе из базы \"{ConnectionOptions.dbName}\" загружена.";

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

            OnPropertyChanged();
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
            SelectedProductReceiptDate = SelectedWarehouseProduct.ReceiptDate.ToString()[..10];
            SelectedProductOrderNumber = SelectedWarehouseProduct.OrderNumber;
            SelectedProductNote = SelectedWarehouseProduct.Note;

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

            string tableTittle = DbTables.WarehouseProducts;
            string columnId = DbTableWarehouseProducts.propertyId;

            if (SelectedWarehouseProduct.Id is null)
            {
                return;
            }

            if (_DataBase is null)
            {
                return;
            }

            string id = SelectedWarehouseProduct.Id.ToString();

            if (id is null)
            {
                return;
            }

            //Tittle
            if (BorderColorSelectedProductTittleMyWarehouseControlTab == "Green")
            {
                string columnTittle = DbTableWarehouseProducts.propertyTittle;

                if (SelectedProductTittle is null)
                {
                    return;
                }

                _DataBase.UpdateRecord(dbSettings, tableTittle, columnTittle, columnId, SelectedProductId, SelectedProductTittle);

                TextLabelEventLogMyWarehouseTabControlWarehouseWindow = "Значение названия выбранного продукта изменено.";
                BorderColorSelectedProductTittleMyWarehouseControlTab = "HotPink";
            }
            //Property
            if (BorderColorSelectedProductPropertyMyWarehouseControlTab == "Green")
            {
                string columnTittle = DbTableWarehouseProducts.propertyProperty;

                if (SelectedProductProperty is null)
                {
                    return;
                }

                _DataBase.UpdateRecord(dbSettings, tableTittle, columnTittle, columnId, SelectedProductId, SelectedProductProperty);

                TextLabelEventLogMyWarehouseTabControlWarehouseWindow = "Значение свойства выбранного продукта изменено.";
                BorderColorSelectedProductPropertyMyWarehouseControlTab = "HotPink";
            }
            //Size
            if (BorderColorSelectedProductSizeMyWarehouseControlTab == "Green")
            {
                string columnTittle = DbTableWarehouseProducts.propertySize;

                if (SelectedProductSize is null)
                {
                    return;
                }

                _DataBase.UpdateRecord(dbSettings, tableTittle, columnTittle, columnId, SelectedProductId, SelectedProductSize);

                TextLabelEventLogMyWarehouseTabControlWarehouseWindow = "Значение свойства выбранного продукта изменено.";
                BorderColorSelectedProductSizeMyWarehouseControlTab = "HotPink";





            }
            //Expiration Data
            if (BorderColorSelectedProductExpirationDateMyWarehouseControlTab == "Green")
            {
                string columnTittle = DbTableWarehouseProducts.propertyExpirationDate;

                if (SelectedProductExpirationData is null)
                {
                    return;
                }

                string newValue = string.Concat("01.", SelectedProductExpirationData.AsSpan(0, 2), ".", SelectedProductExpirationData.AsSpan(3, 4));


                _DataBase.UpdateRecord(dbSettings, tableTittle, columnTittle, columnId, SelectedProductId, newValue);

                TextLabelEventLogMyWarehouseTabControlWarehouseWindow = "Значение свойства выбранного продукта изменено.";
                BorderColorSelectedProductExpirationDateMyWarehouseControlTab = "HotPink";
            }
            //Purchase Cost
            if (BorderColorSelectedProductPurchaseCostMyWarehouseControlTab == "Green")
            {
                string columnTittle = DbTableWarehouseProducts.propertyPurchaseCost;

                if (SelectedProductPurchaseCost is null)
                {
                    return;
                }

                _DataBase.UpdateRecord(dbSettings, tableTittle, columnTittle, columnId, SelectedProductId, SelectedProductPurchaseCost);

                TextLabelEventLogMyWarehouseTabControlWarehouseWindow = "Значение свойства выбранного продукта изменено.";
                BorderColorSelectedProductPurchaseCostMyWarehouseControlTab = "HotPink";





            }
            //Location
            if (BorderColorSelectedProductLocationMyWarehouseControlTab == "Green")
            {
                string columnTittle = DbTableWarehouseProducts.propertyLocation;

                if (SelectedProductLocation is null)
                {
                    return;
                }

                _DataBase.UpdateRecord(dbSettings, tableTittle, columnTittle, columnId, SelectedProductId, SelectedProductLocation);

                TextLabelEventLogMyWarehouseTabControlWarehouseWindow = "Значение свойства выбранного продукта изменено.";
                BorderColorSelectedProductLocationMyWarehouseControlTab = "HotPink";
            }
            //Receipt Date
            if (BorderColorSelectedProductReceiptDateMyWarehouseControlTab == "Green")
            {
                string columnTittle = DbTableWarehouseProducts.propertyReceiptDate;

                if (SelectedProductReceiptDate is null)
                {
                    return;
                }

                _DataBase.UpdateRecord(dbSettings, tableTittle, columnTittle, columnId, SelectedProductId, SelectedProductReceiptDate);

                TextLabelEventLogMyWarehouseTabControlWarehouseWindow = "Значение свойства выбранного продукта изменено.";
                BorderColorSelectedProductReceiptDateMyWarehouseControlTab = "HotPink";





            }
            //Order Number
            if (BorderColorSelectedProductOrderNumberMyWarehouseControlTab == "Green")
            {
                string columnTittle = DbTableWarehouseProducts.propertyOrderNumber;

                if (SelectedProductOrderNumber is null)
                {
                    return;
                }

                _DataBase.UpdateRecord(dbSettings, tableTittle, columnTittle, columnId, SelectedProductId, SelectedProductOrderNumber);

                TextLabelEventLogMyWarehouseTabControlWarehouseWindow = "Значение свойства выбранного продукта изменено.";
                BorderColorSelectedProductOrderNumberMyWarehouseControlTab = "HotPink";
            }
            //Note
            if (BorderColorSelectedProductNoteMyWarehouseControlTab == "Green")
            {
                string columnTittle = DbTableWarehouseProducts.propertyNote;

                if (SelectedProductNote is null)
                {
                    return;
                }

                _DataBase.UpdateRecord(dbSettings, tableTittle, columnTittle, columnId, SelectedProductId, SelectedProductNote);

                TextLabelEventLogMyWarehouseTabControlWarehouseWindow = "Значение свойства выбранного продукта изменено.";
                BorderColorSelectedProductNoteMyWarehouseControlTab = "HotPink";
            }

            OnRefreshConnectionToDataBaseWarhouseWindowCommandExecuted(true);

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
        #region Command ChangeExpirationDateValueOfWarehouseProductCommand: - Change Value Of "Expiration Date" Of Selected Warhouse Product

        /// <summary>Change Value Of "Expiration Date" Of Selected Warhouse Product</summary>
        private LambdaCommand? _ChangeExpirationDateValueOfWarehouseProductCommand;

        /// <summary>Change Value Of "Expiration Date" Of Selected Warhouse Product</summary>
        public ICommand ChangeExpirationDateValueOfWarehouseProductCommand => _ChangeExpirationDateValueOfWarehouseProductCommand ??= new(OnChangeExpirationDateValueOfWarehouseProductCommandExecuted);

        /// <summary>Логика выполнения - Change Value Of "Expiration Date" Of Selected Warhouse Product</summary>

        private void OnChangeExpirationDateValueOfWarehouseProductCommandExecuted(object? p)
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

                string mm = SelectedProductExpirationData[..2];
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

            if (SelectedProductReceiptDate != SelectedWarehouseProduct.ReceiptDate.ToString()[..10])
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


        #endregion

    }
}
