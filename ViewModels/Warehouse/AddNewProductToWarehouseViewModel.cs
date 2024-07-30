using Inventory.Commands;
using Inventory.Models;
using Inventory.Resources.Constants;
using Inventory.ViewModels.Base;
using System.Windows.Input;

namespace Inventory.ViewModels.Warehouse
{
    public partial class WarehouseViewModel : DialogViewModel
    {
		#region Dependencies


		#region TittleProductAddNewToWarehouse: - "Tittle" Of Product That Is Adding To Warehouse

		/// <summary>"Tittle" Of Product That Is Adding To Warehouse</summary>
		private string? _TittleProductAddNewToWarehouse;

		/// <summary>"Tittle" Of Product That Is Adding To Warehouse</summary>

		public string? TittleProductAddNewToWarehouse { get => _TittleProductAddNewToWarehouse; set => Set(ref _TittleProductAddNewToWarehouse, value); }

		#endregion
		#region PropertyProductAddNewToWarehouse: - "Property" Of Product That Is Adding To Warehouse

		/// <summary>"Property" Of Product That Is Adding To Warehouse</summary>
		private string? _PropertyProductAddNewToWarehouse;

		/// <summary>"Property" Of Product That Is Adding To Warehouse</summary>

		public string? PropertyProductAddNewToWarehouse { get => _PropertyProductAddNewToWarehouse; set => Set(ref _PropertyProductAddNewToWarehouse, value); }

		#endregion
		#region SizeProductAddNewToWarehouse: - "Size" Of Product That Is Adding To The Warehouse

		/// <summary>"Size" Of Product That Is Adding To The Warehouse</summary>
		private string? _SizeProductAddNewToWarehouse;

		/// <summary>"Size" Of Product That Is Adding To The Warehouse</summary>

		public string? SizeProductAddNewToWarehouse { get => _SizeProductAddNewToWarehouse; set => Set(ref _SizeProductAddNewToWarehouse, value); }

		#endregion
		#region ExpirationDateProductAddNewToWarehouse: - "Expiration Date" Of Product That Is Adding To The Warehouse

		/// <summary>"Expiration Date" Of Product That Is Adding To The Warehouse</summary>
		private string? _ExpirationDateProductAddNewToWarehouse;

		/// <summary>"Expiration Date" Of Product That Is Adding To The Warehouse</summary>

		public string? ExpirationDateProductAddNewToWarehouse { get => _ExpirationDateProductAddNewToWarehouse; set => Set(ref _ExpirationDateProductAddNewToWarehouse, value); }

		#endregion
		#region PurchaseCostAddNewToWarehouse: - "Purchase Cost" Of Product That Is Adding To The Warehouse

		/// <summary>"Purchase Cost" Of Product That Is Adding To The Warehouse</summary>
		private string? _PurchaseCostAddNewToWarehouse;

		/// <summary>"Purchase Cost" Of Product That Is Adding To The Warehouse</summary>

		public string? PurchaseCostAddNewToWarehouse { get => _PurchaseCostAddNewToWarehouse; set => Set(ref _PurchaseCostAddNewToWarehouse, value); }

		#endregion
		#region LocationAddNewToWarehouse: - "Location" Of Product That Is Adding To The Warehouse

		/// <summary>"Location" Of Product That Is Adding To The Warehouse</summary>
		private string? _LocationAddNewToWarehouse;

		/// <summary>"Location" Of Product That Is Adding To The Warehouse</summary>

		public string? LocationAddNewToWarehouse { get => _LocationAddNewToWarehouse; set => Set(ref _LocationAddNewToWarehouse, value); }

		#endregion
		#region ReceiptDateAddNewToWarehouse: - "Receipt Date" Of Product That Is Adding To The Warehouse

		/// <summary>"Receipt Date" Of Product That Is Adding To The Warehouse</summary>
		private string? _ReceiptDateAddNewToWarehouse;

		/// <summary>"Receipt Date" Of Product That Is Adding To The Warehouse</summary>

		public string? ReceiptDateAddNewToWarehouse { get => _ReceiptDateAddNewToWarehouse; set => Set(ref _ReceiptDateAddNewToWarehouse, value); }

		#endregion
		#region OrderNumberAddNewToWarehouse: - "Order Number" Of Product That Is Adding To The Warehouse

		/// <summary>"Order Number" Of Product That Is Adding To The Warehouse</summary>
		private string? _OrderNumberAddNewToWarehouse;

		/// <summary>"Order Number" Of Product That Is Adding To The Warehouse</summary>

		public string? OrderNumberAddNewToWarehouse { get => _OrderNumberAddNewToWarehouse; set => Set(ref _OrderNumberAddNewToWarehouse, value); }

		#endregion
		#region NoteAddNewToWarehouse: - "Note" Of Product That Is Adding To The Warehouse

		/// <summary>"Note" Of Product That Is Adding To The Warehouse</summary>
		private string? _NoteAddNewToWarehouse;

		/// <summary>"Note" Of Product That Is Adding To The Warehouse</summary>

		public string? NoteAddNewToWarehouse { get => _NoteAddNewToWarehouse; set => Set(ref _NoteAddNewToWarehouse, value); }

		#endregion

		#region BorderColorTittleAddNewWarehouse: - Border Color Of Text Box "Tittle" Add New Product To Warehouse

		/// <summary>Border Color Of Text Box "Tittle" Add New Product To Warehouse</summary>
		private string? _BorderColorTittleAddNewWarehouse;

		/// <summary>Border Color Of Text Box "Tittle" Add New Product To Warehouse</summary>

		public string? BorderColorTittleAddNewWarehouse { get => _BorderColorTittleAddNewWarehouse; set => Set(ref _BorderColorTittleAddNewWarehouse, value); }

		#endregion
		#region BorderColorPropertyAddNewWarehouse: - Border Color Of Text Box "Property" Add New Product To Warehouse

		/// <summary>Border Color Of Text Box "Property" Add New Product To Warehouse</summary>
		private string? _BorderColorPropertyAddNewWarehouse;

		/// <summary>Border Color Of Text Box "Property" Add New Product To Warehouse</summary>

		public string? BorderColorPropertyAddNewWarehouse { get => _BorderColorPropertyAddNewWarehouse; set => Set(ref _BorderColorPropertyAddNewWarehouse, value); }

        #endregion
        #region BorderColorSizeAddNewWarehouse: - Border Color Of Text Box "Size" Add New Product To Warehouse

        /// <summary>Border Color Of Text Box "Size" Add New Product To Warehouse</summary>
        private string? _BorderColorSizeAddNewWarehouse;

        /// <summary>Border Color Of Text Box "Size" Add New Product To Warehouse</summary>

        public string? BorderColorSizeAddNewWarehouse { get => _BorderColorSizeAddNewWarehouse; set => Set(ref _BorderColorSizeAddNewWarehouse, value); }

		#endregion
		#region BorderColorExpirationDateAddNewWarehouse: - Border Color Of Text Box "Expiration Date" Add New Product To Warehouse

		/// <summary>Border Color Of Text Box "Expiration Date" Add New Product To Warehouse</summary>
		private string? _BorderColorExpirationDateAddNewWarehouse;

		/// <summary>Border Color Of Text Box "Expiration Date" Add New Product To Warehouse</summary>

		public string? BorderColorExpirationDateAddNewWarehouse { get => _BorderColorExpirationDateAddNewWarehouse; set => Set(ref _BorderColorExpirationDateAddNewWarehouse, value); }

		#endregion
		#region BorderColorPurchaseCostAddNewWarehouse: - Border COlor Of Text "Purchase Cost" Add New Product To Warehouse

		/// <summary>Border COlor Of Text "Purchase Cost" Add New Product To Warehouse</summary>
		private string? _BorderColorPurchaseCostAddNewWarehouse;

		/// <summary>Border COlor Of Text "Purchase Cost" Add New Product To Warehouse</summary>

		public string? BorderColorPurchaseCostAddNewWarehouse { get => _BorderColorPurchaseCostAddNewWarehouse; set => Set(ref _BorderColorPurchaseCostAddNewWarehouse, value); }

        #endregion
        #region BorderColorLocationAddNewWarehouse: - Border COlor Of Text "Location" Add New Product To Warehouse

        /// <summary>Border COlor Of Text "Location" Add New Product To Warehouse</summary>
        private string? _BorderColorLocationAddNewWarehouse;

        /// <summary>Border COlor Of Text "Location" Add New Product To Warehouse</summary>

        public string? BorderColorLocationAddNewWarehouse { get => _BorderColorLocationAddNewWarehouse; set => Set(ref _BorderColorLocationAddNewWarehouse, value); }

		#endregion
		#region BorderColorReceiptDateAddNewWarehouse: - Border Color Of Text "Receipt Date" Add New Product To Warehouse

		/// <summary>Border Color Of Text "Receipt Date" Add New Product To Warehouse</summary>
		private string? _BorderColorReceiptDateAddNewWarehouse;

		/// <summary>Border Color Of Text "Receipt Date" Add New Product To Warehouse</summary>

		public string? BorderColorReceiptDateAddNewWarehouse { get => _BorderColorReceiptDateAddNewWarehouse; set => Set(ref _BorderColorReceiptDateAddNewWarehouse, value); }

        #endregion
        #region BorderColorOrderNumberAddNewWarehouse: - Border Color Of Text "Order Number" Add New Product To Warehouse

        /// <summary>Border Color Of Text "Order Number" Add New Product To Warehouse</summary>
        private string? _BorderColorOrderNumberAddNewWarehouse;

        /// <summary>Border Color Of Text "Order Number" Add New Product To Warehouse</summary>

        public string? BorderColorOrderNumberAddNewWarehouse { get => _BorderColorOrderNumberAddNewWarehouse; set => Set(ref _BorderColorOrderNumberAddNewWarehouse, value); }

        #endregion
        #region BorderColorNoteAddNewWarehouse: - Border Color Of Text "Location" Add New Product To Warehouse

        /// <summary>Border Color Of Text "Note" Add New Product To Warehouse</summary>
        private string? _BorderColorNoteAddNewWarehouse;

        /// <summary>Border Color Of Text "Note" Add New Product To Warehouse</summary>

        public string? BorderColorNoteAddNewWarehouse { get => _BorderColorNoteAddNewWarehouse; set => Set(ref _BorderColorNoteAddNewWarehouse, value); }

        #endregion
        #region BorderColorIdAddNewWarehouse: - Border Color Of Text "Id" Add New Product To Warehouse

        /// <summary>Border Color Of Text "Id" Add New Product To Warehouse</summary>
        private string? _BorderColorIdAddNewWarehouse;

        /// <summary>Border Color Of Text "Id" Add New Product To Warehouse</summary>

        public string? BorderColorIdAddNewWarehouse { get => _BorderColorIdAddNewWarehouse; set => Set(ref _BorderColorIdAddNewWarehouse, value); }

		#endregion

		#region ButtonTittleAddToWarewouseAddToWarehousePannel: - Button Content "Add To Warehouse" Add To Warehouse Panel

		/// <summary>Button Content "Add To Warehouse" Add To Warehouse Panel</summary>
		private string? _ButtonTittleAddToWarewouseAddToWarehousePannel;

		/// <summary>Button Content "Add To Warehouse" Add To Warehouse Panel</summary>

		public string? ButtonTittleAddToWarewouseAddToWarehousePannel { get => _ButtonTittleAddToWarewouseAddToWarehousePannel; set => Set(ref _ButtonTittleAddToWarewouseAddToWarehousePannel, value); }

		#endregion


		#endregion


		#region Commands


		#region Command PushButtonAddToWarehouseAtAddToWarehousePanelCommand: - Action When You Push The Button "Add To Warehouse" On Add To Warehoue Panel

		/// <summary>Action When You Push The Button "Add To Warehouse" On Add To Warehoue Panel</summary>
		private LambdaCommand? _PushButtonAddToWarehouseAtAddToWarehousePanelCommand;

		/// <summary>Action When You Push The Button "Add To Warehouse" On Add To Warehoue Panel</summary>
		public ICommand PushButtonAddToWarehouseAtAddToWarehousePanelCommand => _PushButtonAddToWarehouseAtAddToWarehousePanelCommand ??= new(OnPushButtonAddToWarehouseAtAddToWarehousePanelCommandExecuted);

		/// <summary>Логика выполнения - Action When You Push The Button "Add To Warehouse" On Add To Warehoue Panel</summary>

		private void OnPushButtonAddToWarehouseAtAddToWarehousePanelCommandExecuted(object? p)
		{
            var dbSettings = new DBSettings
            {
                Server = ConnectionOptions.dbServer,
                Port = ConnectionOptions.dbPort,
                Name = ConnectionOptions.dbName,
                UserId = ConnectionOptions.userId,
                Password = ConnectionOptions.password
            };

            string tableTittle = Resources.Constants.WarehouseProducts.tableTittleWarehouseProducts;

            WarehouseProduct warehouseProduct = new();
            warehouseProduct.Tittle = TittleProductAddNewToWarehouse;
            warehouseProduct.Property = PropertyProductAddNewToWarehouse;
            warehouseProduct.Property = SizeProductAddNewToWarehouse;
            warehouseProduct.ExpirationDate = new DateTime(2008, 6, 1, 7, 47, 0);
            warehouseProduct.PurchaseCost = Convert.ToInt16(PurchaseCostAddNewToWarehouse);
            warehouseProduct.Location = LocationAddNewToWarehouse;
            warehouseProduct.ReceiptDate = new DateTime(2028, 6, 1, 7, 47, 0); ;
            warehouseProduct.OrderNumber = OrderNumberAddNewToWarehouse;
            warehouseProduct.Note = NoteAddNewToWarehouse;

            //ToDo I am Here.











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
                string columnTittle = WarehouseTable.propertyTittle;

                if (SelectedProductTittle is null)
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

                if (SelectedProductProperty is null)
                {
                    return;
                }

                _DataBase.UpdateRecord(dbSettings, tableTittle, columnTittle, id, SelectedProductProperty);

                TextLabelEventLogMyWarehouseTabControlWarehouseWindow = "Значение свойства выбранного продукта изменено.";
                BorderColorSelectedProductPropertyMyWarehouseControlTab = "HotPink";
            }
            //Size
            if (BorderColorSelectedProductSizeMyWarehouseControlTab == "Green")
            {
                string columnTittle = WarehouseTable.propertySize;

                if (SelectedProductSize is null)
                {
                    return;
                }

                _DataBase.UpdateRecord(dbSettings, tableTittle, columnTittle, id, SelectedProductSize);

                TextLabelEventLogMyWarehouseTabControlWarehouseWindow = "Значение свойства выбранного продукта изменено.";
                BorderColorSelectedProductSizeMyWarehouseControlTab = "HotPink";





            }
            //Expiration Data
            if (BorderColorSelectedProductExpirationDateMyWarehouseControlTab == "Green")
            {
                string columnTittle = WarehouseTable.propertyExpirationDate;

                if (SelectedProductExpirationData is null)
                {
                    return;
                }

                string newValue = "01." + SelectedProductExpirationData.Substring(0, 2) + '.' + SelectedProductExpirationData.Substring(3, 4);


                _DataBase.UpdateRecord(dbSettings, tableTittle, columnTittle, id, newValue);

                TextLabelEventLogMyWarehouseTabControlWarehouseWindow = "Значение свойства выбранного продукта изменено.";
                BorderColorSelectedProductExpirationDateMyWarehouseControlTab = "HotPink";





            }
            //Purchase Cost
            if (BorderColorSelectedProductPurchaseCostMyWarehouseControlTab == "Green")
            {
                string columnTittle = WarehouseTable.propertyPurchaseCost;

                if (SelectedProductPurchaseCost is null)
                {
                    return;
                }

                _DataBase.UpdateRecord(dbSettings, tableTittle, columnTittle, id, SelectedProductPurchaseCost);

                TextLabelEventLogMyWarehouseTabControlWarehouseWindow = "Значение свойства выбранного продукта изменено.";
                BorderColorSelectedProductPurchaseCostMyWarehouseControlTab = "HotPink";





            }
            //Location
            if (BorderColorSelectedProductLocationMyWarehouseControlTab == "Green")
            {
                string columnTittle = WarehouseTable.propertyLocation;

                if (SelectedProductLocation is null)
                {
                    return;
                }

                _DataBase.UpdateRecord(dbSettings, tableTittle, columnTittle, id, SelectedProductLocation);

                TextLabelEventLogMyWarehouseTabControlWarehouseWindow = "Значение свойства выбранного продукта изменено.";
                BorderColorSelectedProductLocationMyWarehouseControlTab = "HotPink";
            }
            //Receipt Date
            if (BorderColorSelectedProductReceiptDateMyWarehouseControlTab == "Green")
            {
                string columnTittle = WarehouseTable.propertyReceiptDate;

                if (SelectedProductReceiptDate is null)
                {
                    return;
                }

                _DataBase.UpdateRecord(dbSettings, tableTittle, columnTittle, id, SelectedProductReceiptDate);

                TextLabelEventLogMyWarehouseTabControlWarehouseWindow = "Значение свойства выбранного продукта изменено.";
                BorderColorSelectedProductReceiptDateMyWarehouseControlTab = "HotPink";





            }
            //Order Number
            if (BorderColorSelectedProductOrderNumberMyWarehouseControlTab == "Green")
            {
                string columnTittle = WarehouseTable.propertyOrderNumber;

                if (SelectedProductOrderNumber is null)
                {
                    return;
                }

                _DataBase.UpdateRecord(dbSettings, tableTittle, columnTittle, id, SelectedProductOrderNumber);

                TextLabelEventLogMyWarehouseTabControlWarehouseWindow = "Значение свойства выбранного продукта изменено.";
                BorderColorSelectedProductOrderNumberMyWarehouseControlTab = "HotPink";
            }
            //Note
            if (BorderColorSelectedProductNoteMyWarehouseControlTab == "Green")
            {
                string columnTittle = WarehouseTable.propertyNote;

                if (SelectedProductNote is null)
                {
                    return;
                }

                _DataBase.UpdateRecord(dbSettings, tableTittle, columnTittle, id, SelectedProductNote);

                TextLabelEventLogMyWarehouseTabControlWarehouseWindow = "Значение свойства выбранного продукта изменено.";
                BorderColorSelectedProductNoteMyWarehouseControlTab = "HotPink";
            }




        }

		#endregion



		#endregion
	}
}
