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


		#region IconTittleChangeValue: - Value Of Icon "Tittle" When Value Is Changing

		/// <summary>Value Of Icon "Tittle" When Value Is Changing</summary>
		private string? _IconTittleChangeValue;

		/// <summary>Value Of Icon "Tittle" When Value Is Changing</summary>

		public string? IconTittleChangeValue { get => _IconTittleChangeValue; set => Set(ref _IconTittleChangeValue, value); }

		#endregion
		#region IcomTittleColorAddNewProduct: - Color Of Icon "Tittle" At Add New Product Panel

		/// <summary>Color Of Icon "Tittle" At Add New Product Panel</summary>
		private string? _IcomTittleColorAddNewProduct;

		/// <summary>Color Of Icon "Tittle" At Add New Product Panel</summary>

		public string? IcomTittleColorAddNewProduct { get => _IcomTittleColorAddNewProduct; set => Set(ref _IcomTittleColorAddNewProduct, value); }

		#endregion
		#region IconPropertyChangeValue: - Value Of Icon "Property" When Value Is Changing

		/// <summary>Value Of Icon "Property" When Value Is Changing</summary>
		private string? _IconPropertyChangeValue;

		/// <summary>Value Of Icon "Property" When Value Is Changing</summary>

		public string? IconPropertyChangeValue { get => _IconPropertyChangeValue; set => Set(ref _IconPropertyChangeValue, value); }

		#endregion
		#region IconPropertyColorAddNewProduct: - Color Of Icon "Property" At Add New Product Panel

		/// <summary>Color Of Icon "Property" At Add New Product Panel</summary>
		private string? _IconPropertyColorAddNewProduct;

		/// <summary>Color Of Icon "Property" At Add New Product Panel</summary>

		public string? IconPropertyColorAddNewProduct { get => _IconPropertyColorAddNewProduct; set => Set(ref _IconPropertyColorAddNewProduct, value); }

		#endregion
		#region IconSizeChangeValue: - Value Of Icon "Size" When VAlue Is Changing

		/// <summary>Value Of Icon "Size" When VAlue Is Changing</summary>
		private string? _IconSizeChangeValue;

		/// <summary>Value Of Icon "Size" When VAlue Is Changing</summary>

		public string? IconSizeChangeValue { get => _IconSizeChangeValue; set => Set(ref _IconSizeChangeValue, value); }

		#endregion
		#region IconSizeColorAddNewProduct: - Color Of Icon "Size" At Add New Product

		/// <summary>Color Of Icon "Size" At Add New Product</summary>
		private string? _IconSizeColorAddNewProduct;

		/// <summary>Color Of Icon "Size" At Add New Product</summary>

		public string? IconSizeColorAddNewProduct { get => _IconSizeColorAddNewProduct; set => Set(ref _IconSizeColorAddNewProduct, value); }

		#endregion
		#region IconNoteChangeValue: - Value Of Icon "Note" When Value Is Changing

		/// <summary>Value Of Icon "Note" When Value Is Changing</summary>
		private string? _IconNoteChangeValue;

		/// <summary>Value Of Icon "Note" When Value Is Changing</summary>

		public string? IconNoteChangeValue { get => _IconNoteChangeValue; set => Set(ref _IconNoteChangeValue, value); }

		#endregion
		#region IconNoteColorAddNewProduct: - Color Of Icon "Note" At Add New Product

		/// <summary>Color Of Icon "Note" At Add New Product</summary>
		private string? _IconNoteColorAddNewProduct;

		/// <summary>Color Of Icon "Note" At Add New Product</summary>

		public string? IconNoteColorAddNewProduct { get => _IconNoteColorAddNewProduct; set => Set(ref _IconNoteColorAddNewProduct, value); }

		#endregion
		#region IconExpirationDateChangeValue: - Value Of Icon "Expiration Date" When Value Is Changing

		/// <summary>Value Of Icon "Expiration Date" When Value Is Changing</summary>
		private string? _IconExpirationDateChangeValue;

		/// <summary>Value Of Icon "Expiration Date" When Value Is Changing</summary>

		public string? IconExpirationDateChangeValue { get => _IconExpirationDateChangeValue; set => Set(ref _IconExpirationDateChangeValue, value); }

		#endregion
		#region IconExpirationDateColorAddNewProduct: - Color Of Icon "Expiration Date" At Add New Product Panel

		/// <summary>Color Of Icon "Expiration Date" At Add New Product Panel</summary>
		private string? _IconExpirationDateColorAddNewProduct;

		/// <summary>Color Of Icon "Expiration Date" At Add New Product Panel</summary>

		public string? IconExpirationDateColorAddNewProduct { get => _IconExpirationDateColorAddNewProduct; set => Set(ref _IconExpirationDateColorAddNewProduct, value); }

		#endregion






		#region LoadedDataTableOfActualProducts: - Loaded "Data Table" From SQL DB For TabItem "Add New Warehouse Product"

		/// <summary>Loaded "Data Table" From SQL DB For TabItem "Add New Warehouse Product"</summary>
		private DataTable? _LoadedDataTableOfActualProducts;

		/// <summary>Loaded "Data Table" From SQL DB For TabItem "Add New Warehouse Product"</summary>

		public DataTable? LoadedDataTableOfActualProducts { get => _LoadedDataTableOfActualProducts; set => Set(ref _LoadedDataTableOfActualProducts, value); }

		#endregion

		#region ListOfActualProductsTittles: - List Wich Contains Actuall Tittes Of Products Names

		/// <summary>List Wich Contains Actuall Tittes Of Products Names</summary>
		private List<string>? _ListOfActualProductsTittles;

		/// <summary>List Wich Contains Actuall Tittes Of Products Names</summary>

		public List<string>? ListOfActualProductsTittles { get => _ListOfActualProductsTittles; set => Set(ref _ListOfActualProductsTittles, value); }

		#endregion
		#region ValueOfSelectedItemComboBoxTittle: - Value Of Selected Item Of Combo Box "Tittle" At Add New Product Panel

		/// <summary>Value Of Selected Item Of Combo Box "Tittle" At Add New Product Panel</summary>
		private string? _ValueOfSelectedItemComboBoxTittle;

		/// <summary>Value Of Selected Item Of Combo Box "Tittle" At Add New Product Panel</summary>

		public string? ValueOfSelectedItemComboBoxTittle { get => _ValueOfSelectedItemComboBoxTittle; set => Set(ref _ValueOfSelectedItemComboBoxTittle, value); }

		#endregion

		#region ListOfActualProductProperties: - List Wich Contains Actuall Properties Of Product

		/// <summary>List Wich Contains Actuall Properties Of Product</summary>
		private List<string>? _ListOfActualProductProperties;

		/// <summary>List Wich Contains Actuall Properties Of Product</summary>

		public List<string>? ListOfActualProductProperties { get => _ListOfActualProductProperties; set => Set(ref _ListOfActualProductProperties, value); }

		#endregion

		#region SelectedIndexOfComboBoxProductProperty: - The Value Of Selected Index Of Combo Box "Property"

		/// <summary>The Value Of Selected Index Of Combo Box "Property"</summary>
		private uint? _SelectedIndexOfComboBoxProductProperty;

		/// <summary>The Value Of Selected Index Of Combo Box "Property"</summary>

		public uint? SelectedIndexOfComboBoxProductProperty { get => _SelectedIndexOfComboBoxProductProperty; set => Set(ref _SelectedIndexOfComboBoxProductProperty, value); }

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

            string tableTittle = DbTables.WarehouseProducts;

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

        }

		#endregion

		#region Command LoadActualProductslistCommand: - Load The List Witch Contains Actual Products 

		/// <summary>Load The List Witch Contains Actual Products </summary>
		private LambdaCommand? _LoadActualProductslistCommand;

		/// <summary>Load The List Witch Contains Actual Products </summary>
		public ICommand LoadActualProductslistCommand => _LoadActualProductslistCommand ??= new(OnLoadActualProductslistCommandExecuted);

		/// <summary>Логика выполнения - Load The List Witch Contains Actual Products </summary>

		private void OnLoadActualProductslistCommandExecuted(object? p)
		{
            var dbSettings = new DBSettings
            {
                Server = ConnectionOptions.dbServer,
                Port = ConnectionOptions.dbPort,
                Name = ConnectionOptions.dbName,
                UserId = ConnectionOptions.userId,
                Password = ConnectionOptions.password
            };

            string table = DbTables.ActualProducts;

            if (_DataBase is null)
            {
                return;
            }

            LoadedDataTableOfActualProducts = _DataBase.GetData(dbSettings, table);
            ListOfActualProductsTittles = [.. LoadedDataTableOfActualProducts.AsEnumerable().Select(x => x[1].ToString())];

        }

		#endregion


		#region Command SelectTabItemAddNewProductCommand: - Action When You Chouse TabItem "Add New Warehouse Product"

		/// <summary>Action When You Chouse TabItem "Add New Warehouse Product"</summary>
		private LambdaCommand? _SelectTabItemAddNewProductCommand;

		/// <summary>Action When You Chouse TabItem "Add New Warehouse Product"</summary>
		public ICommand SelectTabItemAddNewProductCommand => _SelectTabItemAddNewProductCommand ??= new(OnSelectTabItemAddNewProductCommandExecuted);

		/// <summary>Логика выполнения - Action When You Chouse TabItem "Add New Warehouse Product"</summary>

		private void OnSelectTabItemAddNewProductCommandExecuted(object? p)
		{
			//ToDo I am Here. 
		}

		#endregion




		#region Command ComboBoxValueTittleIsChangedCommand: - Change Value Of Selected Item In Combo Box "Tittle";

		/// <summary>Change Value Of Selected Item In Combo Box "Tittle";</summary>
		private LambdaCommand? _ComboBoxValueTittleIsChangedCommand;

		/// <summary>Change Value Of Selected Item In Combo Box "Tittle";</summary>
		public ICommand ComboBoxValueTittleIsChangedCommand => _ComboBoxValueTittleIsChangedCommand ??= new(OnComboBoxValueTittleIsChangedCommandExecuted);

		/// <summary>Логика выполнения - Change Value Of Selected Item In Combo Box "Tittle";</summary>

		private void OnComboBoxValueTittleIsChangedCommandExecuted(object? p)
		{
			TittleProductAddNewToWarehouse = ValueOfSelectedItemComboBoxTittle;


            if (ValueOfSelectedItemComboBoxTittle is null)
			{
				return;
			}

			ListOfActualProductProperties = ProductsProperties.ActualProperties.Set(ValueOfSelectedItemComboBoxTittle);

            if (ListOfActualProductProperties.Count > 0)
            {
                ListOfActualProductProperties.Sort();
                SelectedIndexOfComboBoxProductProperty = 0;

                PropertyProductAddNewToWarehouse = ListOfActualProductProperties[0];
            }

            SizeProductAddNewToWarehouse = ProductsProperties.ActualSizes.Set(ValueOfSelectedItemComboBoxTittle);
            NoteAddNewToWarehouse = ProductsProperties.ActualNotes.Set(ValueOfSelectedItemComboBoxTittle);

        }

		#endregion


		#region Command ChangeValueOfProductTittleCommand: - Change Value Of The Added Product Tittle

		/// <summary>Change Value Of The Added Product Tittle</summary>
		private LambdaCommand? _ChangeValueOfProductTittleCommand;

		/// <summary>Change Value Of The Added Product Tittle</summary>
		public ICommand ChangeValueOfProductTittleCommand => _ChangeValueOfProductTittleCommand ??= new(OnChangeValueOfProductTittleCommandExecuted);

		/// <summary>Логика выполнения - Change Value Of The Added Product Tittle</summary>

		private void OnChangeValueOfProductTittleCommandExecuted(object? p)
		{
			if (string.IsNullOrEmpty(TittleProductAddNewToWarehouse))
			{
                BorderColorTittleAddNewWarehouse = "DarkViolet";
				IconTittleChangeValue = "Regular_CircleXmark";
				IcomTittleColorAddNewProduct = "Red";
				ValueOfEventLogAddProductToWarehouseTabControl = "Значение \"Название\" продукта не задано!";

                return;

            }

            if (string.IsNullOrWhiteSpace(TittleProductAddNewToWarehouse))
            {
                BorderColorTittleAddNewWarehouse = "DarkViolet";
                IconTittleChangeValue = "Regular_CircleXmark";
                IcomTittleColorAddNewProduct = "Red";
                ValueOfEventLogAddProductToWarehouseTabControl = "Значение \"Название\" продукта задано как ПРОБЕЛ!";

                return;

            }

			if (ListOfActualProductsTittles is null)
			{
                ValueOfEventLogAddProductToWarehouseTabControl = "Список эталонов\"Названий\" продуктов пустой!";

                return;
			}

			if (ListOfActualProductsTittles.Contains(TittleProductAddNewToWarehouse))
			{
                BorderColorTittleAddNewWarehouse = "HotPink";
                IconTittleChangeValue = "Regular_CircleCheck";
                IcomTittleColorAddNewProduct = "LimeGreen";
				ValueOfEventLogAddProductToWarehouseTabControl = "Значение \"Название\" продукта изменено.";

				return;
            }

            BorderColorTittleAddNewWarehouse = "HotPink";
            IconTittleChangeValue = "Regular_CircleQuestion";
            IcomTittleColorAddNewProduct = "LimeGreen";
			ValueOfEventLogAddProductToWarehouseTabControl = "Задано \"Название\" продукта не внесенное в эталоны!";

			ListOfActualProductProperties = [];
            PropertyProductAddNewToWarehouse = string.Empty;
            SizeProductAddNewToWarehouse = string.Empty;

        }

		#endregion

		#region Command ChangeValueOfProductPropertyCommand: - Change Value Of The Added Product Property

		/// <summary>Change Value Of The Added Product Property</summary>
		private LambdaCommand? _ChangeValueOfProductPropertyCommand;

		/// <summary>Change Value Of The Added Product Property</summary>
		public ICommand ChangeValueOfProductPropertyCommand => _ChangeValueOfProductPropertyCommand ??= new(OnChangeValueOfProductPropertyCommandExecuted);

		/// <summary>Логика выполнения - Change Value Of The Added Product Property</summary>

		private void OnChangeValueOfProductPropertyCommandExecuted(object? p)
		{
            if (string.IsNullOrEmpty(PropertyProductAddNewToWarehouse))
            {
                BorderColorPropertyAddNewWarehouse = "DarkViolet";
                IconPropertyChangeValue = "Regular_CircleXmark";
                IconPropertyColorAddNewProduct = "Red";
                ValueOfEventLogAddProductToWarehouseTabControl = "Значение \"Тип\" продукта не задано.";

                return;
            }

			if (ListOfActualProductProperties is null)
			{
                IcomTittleColorAddNewProduct = "Список \"Тип\" продукта NULL!!!";
                return;
			}

            if (ListOfActualProductProperties.Contains(PropertyProductAddNewToWarehouse))
            {
                BorderColorPropertyAddNewWarehouse = "HotPink";
                IconPropertyChangeValue = "Regular_CircleCheck";
                IconPropertyColorAddNewProduct = "LimeGreen";
                ValueOfEventLogAddProductToWarehouseTabControl = "Значение \"Тип\" продукта изменено.";

                return;
            }

            BorderColorPropertyAddNewWarehouse = "HotPink";
            IconPropertyChangeValue = "Regular_CircleQuestion";
            IconPropertyColorAddNewProduct = "LimeGreen";
            ValueOfEventLogAddProductToWarehouseTabControl = "Задан \"Тип\" продукта не внесенный в эталон!";

        }

		#endregion

		#region Command ChangeValueOfProductSizeCommand: - Change Value Of The Added Product Size

		/// <summary>Change Value Of The Added Product Size</summary>
		private LambdaCommand? _ChangeValueOfProductSizeCommand;

		/// <summary>Change Value Of The Added Product Size</summary>
		public ICommand ChangeValueOfProductSizeCommand => _ChangeValueOfProductSizeCommand ??= new(OnChangeValueOfProductSizeCommandExecuted);

		/// <summary>Логика выполнения - Change Value Of The Added Product Size</summary>

		private void OnChangeValueOfProductSizeCommandExecuted(object? p)
		{
            if (string.IsNullOrEmpty(SizeProductAddNewToWarehouse))
            {
                BorderColorSizeAddNewWarehouse = "DarkViolet";
                IconSizeChangeValue = "Regular_CircleXmark";
                IconSizeColorAddNewProduct = "Red";
                ValueOfEventLogAddProductToWarehouseTabControl = "Значение \"Размер\" продукта не задано.";

                return;
            }

            BorderColorSizeAddNewWarehouse = "HotPink";
            IconSizeChangeValue = "Regular_CircleCheck";
            IconSizeColorAddNewProduct = "LimeGreen";
            ValueOfEventLogAddProductToWarehouseTabControl = "Значение \"Размер\" продукта изменено.";

        }

		#endregion


		#region Command ChangeValueOfProductExpirationDateCommand: - Change Value Of The Added Product Expiration Date

		/// <summary>Change Value Of The Added Product Expiration Date</summary>
		private LambdaCommand? _ChangeValueOfProductExpirationDateCommand;

		/// <summary>Change Value Of The Added Product Expiration Date</summary>
		public ICommand ChangeValueOfProductExpirationDateCommand => _ChangeValueOfProductExpirationDateCommand ??= new(OnChangeValueOfProductExpirationDateCommandExecuted);

		/// <summary>Логика выполнения - Change Value Of The Added Product Expiration Date</summary>

		private void OnChangeValueOfProductExpirationDateCommandExecuted(object? p)
		{
            if (string.IsNullOrEmpty(ExpirationDateProductAddNewToWarehouse))
            {
                BorderColorExpirationDateAddNewWarehouse = "DarkViolet";
                IconExpirationDateChangeValue = "Regular_CircleXmark";
                IconExpirationDateColorAddNewProduct = "Red";
                ValueOfEventLogAddProductToWarehouseTabControl = "Значение \"Срок годности\" продукта не задано.";

                return;
            }
        }

		#endregion





	}
}
#endregion

