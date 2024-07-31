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

		#region ValueOfEventLogAddProductToWarehouseTabControl: - Value Of "Event Log" On TabCOntrol Add Product To Warehouse

		/// <summary>Value Of "Event Log" On TabCOntrol Add Product To Warehouse</summary>
		private string? _ValueOfEventLogAddProductToWarehouseTabControl;

		/// <summary>Value Of "Event Log" On TabCOntrol Add Product To Warehouse</summary>

		public string? ValueOfEventLogAddProductToWarehouseTabControl { get => _ValueOfEventLogAddProductToWarehouseTabControl; set => Set(ref _ValueOfEventLogAddProductToWarehouseTabControl, value); }

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
            if (_DataBase is null)
            {
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

            string tableTittle = Resources.Constants.WarehouseProducts.tableTittleWarehouseProducts;

            DateTime exDate;
			if (!DateTime.TryParse(ExpirationDateProductAddNewToWarehouse, out exDate))
			{
                ValueOfEventLogAddProductToWarehouseTabControl = "Не удалось преобразовать значение \"Срок годности\"";

                return;
			}

            DateTime resDate;
            if (!DateTime.TryParse(ReceiptDateAddNewToWarehouse, out resDate))
			{
                ValueOfEventLogAddProductToWarehouseTabControl = "Не удалось преобразовать значение \"Дата поступления\"";

                return;
            }

            WarehouseProduct warehouseProduct = new()
            {
                Id = 0,
                Tittle = TittleProductAddNewToWarehouse,
                Property = PropertyProductAddNewToWarehouse,
                Size = SizeProductAddNewToWarehouse,
                ExpirationDate = exDate,
                PurchaseCost = Convert.ToInt16(PurchaseCostAddNewToWarehouse),
                Location = LocationAddNewToWarehouse,
                ReceiptDate = resDate,
                OrderNumber = OrderNumberAddNewToWarehouse,
                Note = NoteAddNewToWarehouse,
            };


            _DataBase.AddRecord(dbSettings, tableTittle, warehouseProduct);

			ValueOfEventLogAddProductToWarehouseTabControl = "Данные внесены в Базу Данных";

			//ToDo I am Here.
        }

		#endregion



		#endregion
	}
}
