﻿using Inventory.Commands;
using Inventory.Models;
using Inventory.Resources.Constants;
using Inventory.ViewModels.Base;
using System.Data;
using System.Windows.Input;
using System.Globalization;
using System.Drawing;

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
		#region IconCostChangeValue: - Value Of Icon "Purchase Cost" When Value Is Changing

		/// <summary>Value Of Icon "Purchase Cost" When Value Is Changing</summary>
		private string? _IconCostChangeValue;

		/// <summary>Value Of Icon "Purchase Cost" When Value Is Changing</summary>

		public string? IconCostChangeValue { get => _IconCostChangeValue; set => Set(ref _IconCostChangeValue, value); }

		#endregion
		#region IconCostColorAddNewProduct: - Color Of Icon "Purchase Cost" At Add New Product Panel

		/// <summary>Color Of Icon "Purchase Cost" At Add New Product Panel</summary>
		private string? _IconCostColorAddNewProduct;

		/// <summary>Color Of Icon "Purchase Cost" At Add New Product Panel</summary>

		public string? IconCostColorAddNewProduct { get => _IconCostColorAddNewProduct; set => Set(ref _IconCostColorAddNewProduct, value); }

		#endregion
		#region IconLocationChangeValue: - Value Of Icon "Location" When Value Is Changing

		/// <summary>Value Of Icon "Location" When Value Is Changing</summary>
		private string? _IconLocationChangeValue;

		/// <summary>Value Of Icon "Location" When Value Is Changing</summary>

		public string? IconLocationChangeValue { get => _IconLocationChangeValue; set => Set(ref _IconLocationChangeValue, value); }

		#endregion
		#region IconLocationColorAddNewProduct: - Color Of Icon "Location" At Add New Product Panel

		/// <summary>Color Of Icon "Location" At Add New Product Panel</summary>
		private string? _IconLocationColorAddNewProduct;

		/// <summary>Color Of Icon "Location" At Add New Product Panel</summary>

		public string? IconLocationColorAddNewProduct { get => _IconLocationColorAddNewProduct; set => Set(ref _IconLocationColorAddNewProduct, value); }

		#endregion
		#region IconReceiptDateValue: - Value Of Icon "Receipt Date" When Value Is Changing

		/// <summary>Value Of Icon "Receipt Date" When Value Is Changing</summary>
		private string? _IconReceiptDateValue;

		/// <summary>Value Of Icon "Receipt Date" When Value Is Changing</summary>

		public string? IconReceiptDateValue { get => _IconReceiptDateValue; set => Set(ref _IconReceiptDateValue, value); }

		#endregion
		#region IconReceiptDateColorAddNewProduct: - Color Of Icon "Receipt Date" At Add New Product Panel

		/// <summary>Color Of Icon "Receipt Date" At Add New Product Panel</summary>
		private string? _IconReceiptDateColorAddNewProduct;

		/// <summary>Color Of Icon "Receipt Date" At Add New Product Panel</summary>

		public string? IconReceiptDateColorAddNewProduct { get => _IconReceiptDateColorAddNewProduct; set => Set(ref _IconReceiptDateColorAddNewProduct, value); }

		#endregion
		#region IconOrderNumberValue: - Value Of Icon "Order Number" When Value Is Changing

		/// <summary>Value Of Icon "Order Number" When Value Is Changing</summary>
		private string? _IconOrderNumberValue;

		/// <summary>Value Of Icon "Order Number" When Value Is Changing</summary>

		public string? IconOrderNumberValue { get => _IconOrderNumberValue; set => Set(ref _IconOrderNumberValue, value); }

		#endregion
		#region IconOrderNumberColorAddNewProduct: - Color Of Icon "Order Number" At Add New Product Panel

		/// <summary>Color Of Icon "Order Number" At Add New Product Panel</summary>
		private string? _IconOrderNumberColorAddNewProduct;

		/// <summary>Color Of Icon "Order Number" At Add New Product Panel</summary>

		public string? IconOrderNumberColorAddNewProduct { get => _IconOrderNumberColorAddNewProduct; set => Set(ref _IconOrderNumberColorAddNewProduct, value); }

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

		#region ListOfPossibleProductLocations: - List Wich Contains Possible Locations Of Product

		/// <summary>List Wich Contains Possible Locations Of Product</summary>
		private List<string>? _ListOfPossibleProductLocations;

		/// <summary>List Wich Contains Possible Locations Of Product</summary>

		public List<string>? ListOfPossibleProductLocations { get => _ListOfPossibleProductLocations; set => Set(ref _ListOfPossibleProductLocations, value); }

		#endregion

		#region ValueOfSelectedItemComboBoxLocation: - Value Of SelectedItem Of Combo Box "Location" At Add New Product Panel

		/// <summary>Value Of SelectedItem Of Combo Box "Location" At Add New Product Panel</summary>
		private string? _ValueOfSelectedItemComboBoxLocation;

		/// <summary>Value Of SelectedItem Of Combo Box "Location" At Add New Product Panel</summary>

		public string? ValueOfSelectedItemComboBoxLocation { get => _ValueOfSelectedItemComboBoxLocation; set => Set(ref _ValueOfSelectedItemComboBoxLocation, value); }

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

            if (IconTittleChangeValue == Icons.Name.Regular_CircleXmark.ToString() || IconPropertyChangeValue == Icons.Name.Regular_CircleXmark.ToString() ||
                IconSizeChangeValue == Icons.Name.Regular_CircleXmark.ToString() || IconNoteChangeValue == Icons.Name.Regular_CircleXmark.ToString() ||
                IconExpirationDateChangeValue == Icons.Name.Regular_CircleXmark.ToString() || IconCostChangeValue == Icons.Name.Regular_CircleXmark.ToString() ||
                IconLocationChangeValue == Icons.Name.Regular_CircleXmark.ToString() || IconReceiptDateValue == Icons.Name.Regular_CircleXmark.ToString() ||
                IconOrderNumberValue == Icons.Name.Regular_CircleXmark.ToString())
			{
                WarehouseEventTextValue = "Продукт не добавлен на склад. Некорректно указаны данные.";
				WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
				WarehouseEventIconColor = Color.Red.Name;
                return;
			}

			if (ReceiptDateAddNewToWarehouse is null)
			{
                WarehouseEventTextValue = "Продукт не добавлен на склад. Значение \"даты получения\" продукта равно NULL!.";
                WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                WarehouseEventIconColor = Color.Red.Name;
                return;
			}

			//CultureInfo fp = new("en-US");

			var exDate = DateTime.Parse("01." + ExpirationDateProductAddNewToWarehouse);
            var resDate = DateTime.Parse(ReceiptDateAddNewToWarehouse);

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


            _DataBase.AddWarehouseProduct(dbSettings, tableTittle, warehouseProduct);

            WarehouseEventTextValue = "Продукт добавлен на склад.";
            WarehouseEventIconValue = Icons.Name.Regular_CircleCheck.ToString();
            WarehouseEventIconColor = Color.LimeGreen.Name;
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
            ListOfActualProductsTittles.Sort();
            ReceiptDateAddNewToWarehouse = DateTime.Now.ToString("dd.MM.yyyy");

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

            PropertyProductAddNewToWarehouse = ListOfActualProductProperties[0];

			SelectedIndexOfComboBoxProductProperty = 0;

			SizeProductAddNewToWarehouse = ProductsProperties.ActualSizes.Set(ValueOfSelectedItemComboBoxTittle);
            NoteAddNewToWarehouse = ProductsProperties.ActualNotes.Set(ValueOfSelectedItemComboBoxTittle);

        }

        #endregion
        #region Command ComboBoxValueLocationIsChangedCommand: - Change value Of Selected Item In Combo Box "Lication"

        /// <summary>Change value Of Selected Item In Combo Box "Lication"</summary>
        private LambdaCommand? _ComboBoxValueLocationIsChangedCommand;

        /// <summary>Change value Of Selected Item In Combo Box "Lication"</summary>
        public ICommand ComboBoxValueLocationIsChangedCommand => _ComboBoxValueLocationIsChangedCommand ??= new(OnComboBoxValueLocationIsChangedCommandExecuted);

        /// <summary>Логика выполнения - Change value Of Selected Item In Combo Box "Lication"</summary>

        private void OnComboBoxValueLocationIsChangedCommandExecuted(object? p)
        {
            LocationAddNewToWarehouse = ValueOfSelectedItemComboBoxLocation;
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
                BorderColorTittleAddNewWarehouse = Color.DarkViolet.Name;
				IconTittleChangeValue = Icons.Name.Regular_CircleXmark.ToString();
				IcomTittleColorAddNewProduct = Color.Red.Name;

                WarehouseEventTextValue = "Значение \"Название\" продукта не задано!";
                WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                WarehouseEventIconColor = Color.Red.Name;
                return;

            }

            if (string.IsNullOrWhiteSpace(TittleProductAddNewToWarehouse))
            {
                BorderColorTittleAddNewWarehouse = Color.DarkViolet.Name;
                IconTittleChangeValue = Icons.Name.Regular_CircleXmark.ToString();
                IcomTittleColorAddNewProduct = Color.Red.Name;

                WarehouseEventTextValue = "Значение \"Название\" продукта задано как ПРОБЕЛ!";
                WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                WarehouseEventIconColor = Color.Red.Name;
                return;

            }

			if (ListOfActualProductsTittles is null)
			{
                WarehouseEventTextValue = "Список эталонов\"Названий\" продуктов пустой!";
                WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                WarehouseEventIconColor = Color.Red.Name;
                return;
			}

			if (ListOfActualProductsTittles.Contains(TittleProductAddNewToWarehouse))
			{
                BorderColorTittleAddNewWarehouse = Color.HotPink.Name;
                IconTittleChangeValue = Icons.Name.Regular_CircleCheck.ToString();
                IcomTittleColorAddNewProduct = Color.LimeGreen.Name;

                WarehouseEventTextValue = "Значение \"Название\" продукта изменено.";
                WarehouseEventIconValue = Icons.Name.Regular_CircleCheck.ToString();
                WarehouseEventIconColor = Color.LimeGreen.Name;
                return;
            }

            BorderColorTittleAddNewWarehouse = Color.HotPink.Name;
            IconTittleChangeValue = Icons.Name.Regular_CircleQuestion.ToString();
            IcomTittleColorAddNewProduct = Color.Green.Name;

            WarehouseEventTextValue = "Задано \"Название\" продукта не внесенное в эталоны!";
            WarehouseEventIconValue = Icons.Name.Regular_CircleCheck.ToString();
            WarehouseEventIconColor = Color.Green.Name;

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
                BorderColorPropertyAddNewWarehouse = Color.DarkViolet.Name;
                IconPropertyChangeValue = Icons.Name.Regular_CircleXmark.ToString();
                IconPropertyColorAddNewProduct = Color.Red.Name;

                WarehouseEventTextValue = "Значение \"Тип\" продукта не задано.";
                WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                WarehouseEventIconColor = Color.Red.Name;

                return;
            }

			if (ListOfActualProductProperties is null)
			{
                IcomTittleColorAddNewProduct = "Список \"Тип\" продукта NULL!!!";
                return;
			}

            if (ListOfActualProductProperties.Contains(PropertyProductAddNewToWarehouse))
            {
                BorderColorPropertyAddNewWarehouse = Color.HotPink.Name;
                IconPropertyChangeValue = Icons.Name.Regular_CircleCheck.ToString();
                IconPropertyColorAddNewProduct = Color.LimeGreen.Name;

                WarehouseEventTextValue = "Значение \"Тип\" продукта изменено.";
                WarehouseEventIconValue = Icons.Name.Regular_CircleCheck.ToString();
                WarehouseEventIconColor = Color.LimeGreen.Name;

                return;
            }

            BorderColorPropertyAddNewWarehouse = Color.HotPink.Name;
            IconPropertyChangeValue = Icons.Name.Regular_CircleQuestion.ToString();
            IconPropertyColorAddNewProduct = Color.Green.Name;

            WarehouseEventTextValue = "Задан \"Тип\" продукта не внесенный в эталон!";
            WarehouseEventIconValue = Icons.Name.Regular_CircleQuestion.ToString();
            WarehouseEventIconColor = Color.Green.Name;
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
                BorderColorSizeAddNewWarehouse = Color.DarkViolet.Name;
                IconSizeChangeValue = Icons.Name.Regular_CircleXmark.ToString();
                IconSizeColorAddNewProduct = Color.Red.Name;

                WarehouseEventTextValue = "Значение \"Размер\" продукта не задано.";
                WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                WarehouseEventIconColor = Color.Red.Name;

                return;
            }

            BorderColorSizeAddNewWarehouse = Color.HotPink.Name;
            IconSizeChangeValue = Icons.Name.Regular_CircleCheck.ToString();
            IconSizeColorAddNewProduct = Color.LimeGreen.Name;

            WarehouseEventTextValue = "Значение \"Размер\" продукта изменено.";
            WarehouseEventIconValue = Icons.Name.Regular_CircleCheck.ToString();
            WarehouseEventIconColor = Color.LimeGreen.Name;

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
                BorderColorExpirationDateAddNewWarehouse = Color.DarkViolet.Name;
                IconExpirationDateChangeValue = Icons.Name.Regular_CircleXmark.ToString();
                IconExpirationDateColorAddNewProduct = Color.Red.Name;

                WarehouseEventTextValue = "Значение \"Срок годности\" продукта не задано.";
                WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                WarehouseEventIconColor = Color.Red.Name;

                return;
            }

			if (ExpirationDateProductAddNewToWarehouse.Length != 7)
			{
                BorderColorExpirationDateAddNewWarehouse = Color.DarkViolet.Name;
                IconExpirationDateChangeValue = Icons.Name.Regular_CircleXmark.ToString();
                IconExpirationDateColorAddNewProduct = Color.Red.Name;

                WarehouseEventTextValue = "Значение \"Срок годности\" продукта задано некорректно (mm.yyyy).";
                WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                WarehouseEventIconColor = Color.Red.Name;

                return;
            }

			if (!char.IsDigit(ExpirationDateProductAddNewToWarehouse[0]))
			{
                BorderColorExpirationDateAddNewWarehouse = Color.DarkViolet.Name;
                IconExpirationDateChangeValue = Icons.Name.Regular_CircleXmark.ToString();
                IconExpirationDateColorAddNewProduct = Color.Red.Name;

                WarehouseEventTextValue = "Значение \"Срок годности\" продукта задано некорректно (*m.yyyy).";
                WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                WarehouseEventIconColor = Color.Red.Name;

                return;
            }

            if (!char.IsDigit(ExpirationDateProductAddNewToWarehouse[1]))
            {
                BorderColorExpirationDateAddNewWarehouse = Color.DarkViolet.Name;
                IconExpirationDateChangeValue = Icons.Name.Regular_CircleXmark.ToString();
                IconExpirationDateColorAddNewProduct = Color.Red.Name;

                WarehouseEventTextValue = "Значение \"Срок годности\" продукта задано некорректно (m*.yyyy).";
                WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                WarehouseEventIconColor = Color.Red.Name;

                return;
            }
            if (!char.IsDigit(ExpirationDateProductAddNewToWarehouse[3]))
            {
                BorderColorExpirationDateAddNewWarehouse = Color.DarkViolet.Name;
                IconExpirationDateChangeValue = Icons.Name.Regular_CircleXmark.ToString();
                IconExpirationDateColorAddNewProduct = Color.Red.Name;

                WarehouseEventTextValue = "Значение \"Срок годности\" продукта задано некорректно (mm.*yyy).";
                WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                WarehouseEventIconColor = Color.Red.Name;

                return;
            }
            if (!char.IsDigit(ExpirationDateProductAddNewToWarehouse[4]))
            {
                BorderColorExpirationDateAddNewWarehouse = Color.DarkViolet.Name;
                IconExpirationDateChangeValue = Icons.Name.Regular_CircleXmark.ToString();
                IconExpirationDateColorAddNewProduct = Color.Red.Name;

                WarehouseEventTextValue = "Значение \"Срок годности\" продукта задано некорректно (mm.y*yy).";
                WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                WarehouseEventIconColor = Color.Red.Name;

                return;
            }
            if (!char.IsDigit(ExpirationDateProductAddNewToWarehouse[5]))
            {
                BorderColorExpirationDateAddNewWarehouse = Color.DarkViolet.Name;
                IconExpirationDateChangeValue = Icons.Name.Regular_CircleXmark.ToString();
                IconExpirationDateColorAddNewProduct = Color.Red.Name;

                WarehouseEventTextValue = "Значение \"Срок годности\" продукта задано некорректно (mm.yy*y).";
                WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                WarehouseEventIconColor = Color.Red.Name;

                return;
            }
            if (!char.IsDigit(ExpirationDateProductAddNewToWarehouse[6]))
            {
                BorderColorExpirationDateAddNewWarehouse = Color.DarkViolet.Name;
                IconExpirationDateChangeValue = Icons.Name.Regular_CircleXmark.ToString();
                IconExpirationDateColorAddNewProduct = Color.Red.Name;

                WarehouseEventTextValue = "Значение \"Срок годности\" продукта задано некорректно (mm.yyy*).";
                WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                WarehouseEventIconColor = Color.Red.Name;

                return;
            }

			uint month = Convert.ToUInt32(ExpirationDateProductAddNewToWarehouse[..2]);

			if (month < 1 || month > 12)
			{
                BorderColorExpirationDateAddNewWarehouse = Color.DarkViolet.Name;
                IconExpirationDateChangeValue = Icons.Name.Regular_CircleXmark.ToString();
                IconExpirationDateColorAddNewProduct = Color.Red.Name;

                WarehouseEventTextValue = "Значение \"Срок годности\" (месяц) продукта задано некорректно (**.yyyy).";
                WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                WarehouseEventIconColor = Color.Red.Name;

                return;
            }

			if (ExpirationDateProductAddNewToWarehouse[2] != '.' && ExpirationDateProductAddNewToWarehouse[2] != '/')
			{
                BorderColorExpirationDateAddNewWarehouse = Color.DarkViolet.Name;
                IconExpirationDateChangeValue = Icons.Name.Regular_CircleXmark.ToString();
                IconExpirationDateColorAddNewProduct = Color.Red.Name;

                WarehouseEventTextValue = "Значение \"Срок годности\" (разделитель) продукта задано некорректно (mm*yyyy) ( * = . or /).";
                WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                WarehouseEventIconColor = Color.Red.Name;

                return;
            }

            BorderColorExpirationDateAddNewWarehouse = Color.HotPink.Name;
            IconExpirationDateChangeValue = Icons.Name.Regular_CircleCheck.ToString();
            IconExpirationDateColorAddNewProduct = Color.LimeGreen.Name;

            WarehouseEventTextValue = "Значение \"Срок годности\" продукта изменено.";
            WarehouseEventIconValue = Icons.Name.Regular_CircleCheck.ToString();
            WarehouseEventIconColor = Color.LimeGreen.Name;
        }

		#endregion

		#region Command ChangeValueOfProductCostCommand: - Change Value Of The AddedProduct Cost

		/// <summary>Change Value Of The AddedProduct Cost</summary>
		private LambdaCommand? _ChangeValueOfProductCostCommand;

		/// <summary>Change Value Of The AddedProduct Cost</summary>
		public ICommand ChangeValueOfProductCostCommand => _ChangeValueOfProductCostCommand ??= new(OnChangeValueOfProductCostCommandExecuted);

		/// <summary>Логика выполнения - Change Value Of The AddedProduct Cost</summary>

		private void OnChangeValueOfProductCostCommandExecuted(object? p)
		{
            if (string.IsNullOrEmpty(PurchaseCostAddNewToWarehouse))
            {
                BorderColorPurchaseCostAddNewWarehouse = Color.DarkViolet.Name;
                IconCostChangeValue = Icons.Name.Regular_CircleXmark.ToString();
                IconCostColorAddNewProduct = Color.Red.Name;

                WarehouseEventTextValue = "Значение \"Стоимость покупки\" продукта не задано.";
                WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                WarehouseEventIconColor = Color.Red.Name;

                return;
            }

            if (string.IsNullOrWhiteSpace(PurchaseCostAddNewToWarehouse))
            {
                BorderColorPurchaseCostAddNewWarehouse = Color.DarkViolet.Name;
                IconCostChangeValue = Icons.Name.Regular_CircleXmark.ToString();
                IconCostColorAddNewProduct = Color.Red.Name;

                WarehouseEventTextValue = "Значение \"Стоимость покупки\" продукта задано как ПРОБЕЛ!";
                WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                WarehouseEventIconColor = Color.Red.Name;

                return;
            }

			foreach (char c in PurchaseCostAddNewToWarehouse)
			{
				if (!char.IsDigit(c))
				{
                    BorderColorPurchaseCostAddNewWarehouse = Color.DarkViolet.Name;
                    IconCostChangeValue = Icons.Name.Regular_CircleXmark.ToString();
                    IconCostColorAddNewProduct = Color.Red.Name;

                    WarehouseEventTextValue = "Значение \"Стоимость покупки\" продукта задано некорректно.";
                    WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                    WarehouseEventIconColor = Color.Red.Name;

                    return;
                }
			}

			if (PurchaseCostAddNewToWarehouse.Length > 1 && PurchaseCostAddNewToWarehouse[0] == '0')
			{
                BorderColorPurchaseCostAddNewWarehouse = Color.DarkViolet.Name;
                IconCostChangeValue = Icons.Name.Regular_CircleXmark.ToString();
                IconCostColorAddNewProduct = Color.Red.Name;

                WarehouseEventTextValue = "Значение \"Стоимость покупки\" продукта задано некорректно (первая цифра 0).";
                WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                WarehouseEventIconColor = Color.Red.Name;

                return;

            }

            BorderColorPurchaseCostAddNewWarehouse = Color.HotPink.Name;
            IconCostChangeValue = Icons.Name.Regular_CircleCheck.ToString();
            IconCostColorAddNewProduct = Color.LimeGreen.Name;

            WarehouseEventTextValue = "Значение \"Стоимость покупки\" продукта изменено.";
            WarehouseEventIconValue = Icons.Name.Regular_CircleCheck.ToString();
            WarehouseEventIconColor = Color.LimeGreen.Name;

        }

		#endregion

		#region Command ChangeValueOfLocationCommand: - Change Value Of The Added Product Location

		/// <summary>Change Value Of The Added Product Location</summary>
		private LambdaCommand? _ChangeValueOfLocationCommand;

		/// <summary>Change Value Of The Added Product Location</summary>
		public ICommand ChangeValueOfLocationCommand => _ChangeValueOfLocationCommand ??= new(OnChangeValueOfLocationCommandExecuted);

		/// <summary>Логика выполнения - Change Value Of The Added Product Location</summary>

		private void OnChangeValueOfLocationCommandExecuted(object? p)
		{
            if (string.IsNullOrEmpty(LocationAddNewToWarehouse) || string.IsNullOrWhiteSpace(LocationAddNewToWarehouse))
            {
                BorderColorLocationAddNewWarehouse = Color.DarkViolet.Name;
                IconLocationChangeValue = Icons.Name.Regular_CircleXmark.ToString();
                IconLocationColorAddNewProduct = Color.Red.Name;

                WarehouseEventTextValue = "Значение \"Место хранения\" продукта не задано!";
                WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                WarehouseEventIconColor = Color.Red.Name;

                return;

            }

            if (ListOfPossibleProductLocations is null)
            {
                WarehouseEventTextValue = "Список эталонов\"Место хранения\" продуктов пустой!";
                WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                WarehouseEventIconColor = Color.Red.Name;

                return;
            }

            if (ListOfPossibleProductLocations.Contains(LocationAddNewToWarehouse))
            {
                BorderColorLocationAddNewWarehouse = Color.HotPink.Name;
                IconLocationChangeValue = Icons.Name.Regular_CircleCheck.ToString();
                IconLocationColorAddNewProduct = Color.LimeGreen.Name;

                WarehouseEventTextValue = "Значение \"Место хранения\" продукта изменено.";
                WarehouseEventIconValue = Icons.Name.Regular_CircleCheck.ToString();
                WarehouseEventIconColor = Color.LimeGreen.Name;

                return;
            }

            BorderColorLocationAddNewWarehouse = Color.HotPink.Name;
            IconLocationChangeValue = Icons.Name.Regular_CircleQuestion.ToString();
            IconLocationColorAddNewProduct = Color.Green.Name;

            WarehouseEventTextValue = "Задано значение \"Место хранения\" продукта не внесенное в эталоны.";
            WarehouseEventIconValue = Icons.Name.Regular_CircleQuestion.ToString();
            WarehouseEventIconColor = Color.Green.Name;
        }

		#endregion

		#region Command ChangeValueOfReceiptDateCommand: - Change Value Of The Added Product Receipt Date

		/// <summary>Change Value Of The Added Product Receipt Date</summary>
		private LambdaCommand? _ChangeValueOfReceiptDateCommand;

		/// <summary>Change Value Of The Added Product Receipt Date</summary>
		public ICommand ChangeValueOfReceiptDateCommand => _ChangeValueOfReceiptDateCommand ??= new(OnChangeValueOfReceiptDateCommandExecuted);

		/// <summary>Логика выполнения - Change Value Of The Added Product Receipt Date</summary>

		private void OnChangeValueOfReceiptDateCommandExecuted(object? p)
		{
            if (string.IsNullOrEmpty(ReceiptDateAddNewToWarehouse))
            {
                BorderColorReceiptDateAddNewWarehouse = Color.DarkViolet.Name;
                IconReceiptDateValue = Icons.Name.Regular_CircleXmark.ToString();
                IconReceiptDateColorAddNewProduct = Color.Red.Name;

                WarehouseEventTextValue = "Значение \"Дата поставки\" продукта не задано.";
                WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                WarehouseEventIconColor = Color.Red.Name;

                return;
            }

            if (ReceiptDateAddNewToWarehouse.Length != 10)
            {
                BorderColorReceiptDateAddNewWarehouse = Color.DarkViolet.Name;
                IconReceiptDateValue = Icons.Name.Regular_CircleXmark.ToString();
                IconReceiptDateColorAddNewProduct = Color.Red.Name;

                WarehouseEventTextValue = "Значение \"Дата поставки\" продукта не задано (dd.MM.yyyy).";
                WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                WarehouseEventIconColor = Color.Red.Name;

                return;
            }

			//CultureInfo fp = new("ru-RU");

            DateTime dt;
            if (!DateTime.TryParse(ReceiptDateAddNewToWarehouse, out dt))
            {
                BorderColorReceiptDateAddNewWarehouse = Color.DarkViolet.Name;
                IconReceiptDateValue = Icons.Name.Regular_CircleXmark.ToString();
                IconReceiptDateColorAddNewProduct = Color.Red.Name;

                WarehouseEventTextValue = "Значение \"Дата поставки\" продукта не задано (dd.MM.yyyy).";
                WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                WarehouseEventIconColor = Color.Red.Name;

                return;
            }

            BorderColorReceiptDateAddNewWarehouse = Color.HotPink.Name;
            IconReceiptDateValue = Icons.Name.Regular_CircleCheck.ToString();
            IconReceiptDateColorAddNewProduct = Color.LimeGreen.Name;

            WarehouseEventTextValue = "Значение \"Дата поставки\" продукта изменено.";
            WarehouseEventIconValue = Icons.Name.Regular_CircleCheck.ToString();
            WarehouseEventIconColor = Color.LimeGreen.Name;
        }

		#endregion

		#region Command ChangeValueOfOrderNumberCommand: - Change Value Of The Added Product Order Number

		/// <summary>Change Value Of The Added Product Order Number</summary>
		private LambdaCommand? _ChangeValueOfOrderNumberCommand;

		/// <summary>Change Value Of The Added Product Order Number</summary>
		public ICommand ChangeValueOfOrderNumberCommand => _ChangeValueOfOrderNumberCommand ??= new(OnChangeValueOfOrderNumberCommandExecuted);

		/// <summary>Логика выполнения - Change Value Of The Added Product Order Number</summary>

		private void OnChangeValueOfOrderNumberCommandExecuted(object? p)
		{
            if (string.IsNullOrEmpty(OrderNumberAddNewToWarehouse))
            {
                BorderColorOrderNumberAddNewWarehouse = Color.DarkViolet.Name;
                IconOrderNumberValue = Icons.Name.Regular_CircleXmark.ToString();
                IconOrderNumberColorAddNewProduct = Color.Red.Name;

                WarehouseEventTextValue = "Значение \"Номер заказа\" продукта не задано.";
                WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                WarehouseEventIconColor = Color.Red.Name;

                return;
            }

            BorderColorOrderNumberAddNewWarehouse = Color.HotPink.Name;
            IconOrderNumberValue = Icons.Name.Regular_CircleCheck.ToString();
            IconOrderNumberColorAddNewProduct = Color.LimeGreen.Name;

            WarehouseEventTextValue = "Значение \"Номер заказа\" продукта изменено.";
            WarehouseEventIconValue = Icons.Name.Regular_CircleCheck.ToString();
            WarehouseEventIconColor = Color.LimeGreen.Name;
        }

        #endregion

    }
}
#endregion

