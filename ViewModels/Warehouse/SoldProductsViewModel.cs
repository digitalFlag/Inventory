using Inventory.Commands;
using Inventory.Models;
using Inventory.Resources.Constants;
using Inventory.ViewModels.Base;
using System.Data;
using System.Drawing;
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

        #region All SoldProducts: - All Products On Sold List

        /// <summary>Products On Sold List</summary>
        private IEnumerable<SoldProduct>? _AllSoldProducts;

        /// <summary>Products On Sold List</summary>

        public IEnumerable<SoldProduct>? AllSoldProducts { get => _AllSoldProducts; set => Set(ref _AllSoldProducts, value); }

        #endregion
        #region FilteredSoldProducts: - "Sold Products" After Filtering

        /// <summary>"Sold Products" After Filtering</summary>
        private List<SoldProduct>? _FilteredSoldProducts;

        /// <summary>"Sold Products" After Filtering</summary>

        public List<SoldProduct>? FilteredSoldProducts { get => _FilteredSoldProducts; set => Set(ref _FilteredSoldProducts, value); }

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
        #region IconFiltersTabControlInSoldProductsItemValue: - Value Of Icon "Filters" Tab Control -> Sold Item

        /// <summary>Value Of Icon "Filters" Tab Control -> Sold Item</summary>
        private string? _IconFiltersTabControlInSoldProductsItemValue;

        /// <summary>Value Of Icon "Filters" Tab Control -> Sold Item</summary>

        public string? IconFiltersTabControlInSoldProductsItemValue { get => _IconFiltersTabControlInSoldProductsItemValue; set => Set(ref _IconFiltersTabControlInSoldProductsItemValue, value); }

        #endregion

        #region LabelFilterModeInFiltersTabItemInSoldProductsItem: - Label Value "Filter Mode" In Filters tabItem In Sold Products Item

        /// <summary>Label Value "Filter Mode" In Filters tabItem In Sold Products Item</summary>
        private string? _LabelFilterModeInFiltersTabItemInSoldProductsItem;

        /// <summary>Label Value "Filter Mode" In Filters tabItem In Sold Products Item</summary>

        public string? LabelFilterModeInFiltersTabItemInSoldProductsItem { get => _LabelFilterModeInFiltersTabItemInSoldProductsItem; set => Set(ref _LabelFilterModeInFiltersTabItemInSoldProductsItem, value); }

        #endregion

        #region FiltersModeSelectForSoldFroducts: - Is Mode "Select" For Filters In Sold Products Item 

        /// <summary>Is Mode "Select" For Filters In Sold Products Item </summary>
        private bool _FiltersModeSelectForSoldFroducts;

        /// <summary>Is Mode "Select" For Filters In Sold Products Item </summary>

        public bool FiltersModeSelectForSoldFroducts { get => _FiltersModeSelectForSoldFroducts; set => Set(ref _FiltersModeSelectForSoldFroducts, value); }

        #endregion
        #region ColorOfFillRectungleSelectFilterSoldProductsItem: - Color Of "Rectangle" Select Filter In Sold Products Item
        /// <summary>Color Of "Rectangle" Select Filter In Sold Products Item</summary>
        private string? _ColorOfFillRectungleSelectFilterSoldProductsItem;

        /// <summary>Color Of "Rectangle" Select Filter In Sold Products Item</summary>

        public string? ColorOfFillRectungleSelectFilterSoldProductsItem { get => _ColorOfFillRectungleSelectFilterSoldProductsItem; set => Set(ref _ColorOfFillRectungleSelectFilterSoldProductsItem, value); }

        #endregion
        #region ColorOfFillRectungleCutFilterSoldProductsItem: - Color Of "Rectangle" Cut Filter In Sold Products Item
        /// <summary>Color Of "Rectangle" Cut Filter In Sold Products Item</summary>
        private string? _ColorOfFillRectungleCutFilterSoldProductsItem;

        /// <summary>Color Of "Rectangle" Cut Filter In Sold Products Item</summary>

        public string? ColorOfFillRectungleCutFilterSoldProductsItem { get => _ColorOfFillRectungleCutFilterSoldProductsItem; set => Set(ref _ColorOfFillRectungleCutFilterSoldProductsItem, value); }

        #endregion

        #region FilterTittleForSoldProducts: - Filter "Tittle" For Sold Products 

        /// <summary>Filter "Tittle" For Sold Products </summary>
        private string? _FilterTittleForSoldProducts;

        /// <summary>Filter "Tittle" For Sold Products </summary>

        public string? FilterTittleForSoldProducts { get => _FilterTittleForSoldProducts; set => Set(ref _FilterTittleForSoldProducts, value); }

        #endregion
        #region FilterPropertyForSoldProducts: - Filter "Property" For Sold Products 

        /// <summary>Filter "Property" For Sold Products </summary>
        private string? _FilterPropertyForSoldProducts;

        /// <summary>Filter "Property" For Sold Products </summary>

        public string? FilterPropertyForSoldProducts { get => _FilterPropertyForSoldProducts; set => Set(ref _FilterPropertyForSoldProducts, value); }

        #endregion



        #endregion

        #region Commands

        #region Command LoadSoldProductsFromDbCommand: - Load "Sold Products" Data From DB 

        /// <summary>Load "Sold Products" Data From DB </summary>
        private LambdaCommand? _LoadSoldProductsFromDbCommand;

        /// <summary>Load "Sold Products" Data From DB </summary>
        public ICommand LoadSoldProductsFromDbCommand => _LoadSoldProductsFromDbCommand ??= new(OnLoadSoldProductsFromDbCommandExecuted);

        /// <summary>Логика выполнения - Load "Sold Products" Data From DB </summary>

        private void OnLoadSoldProductsFromDbCommandExecuted(object? p)
        {
            var dbSettings = new DBSettings
            {
                Server = ConnectionOptions.dbServer,
                Port = ConnectionOptions.dbPort,
                Name = ConnectionOptions.dbName,
                UserId = ConnectionOptions.userId,
                Password = ConnectionOptions.password
            };

            if (_DataBase is null)
            {
                return;
            }

            string table = DbTables.SoldProducts;

            LoadedDataTableFromDataBaseSoldProducts = _DataBase.GetData(dbSettings, table);

            AllSoldProducts = LoadedDataTableFromDataBaseSoldProducts.AsEnumerable().Select(row => new Models.SoldProduct
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

        }

        #endregion

        #region Command RefreshConnectionToDataBaseSoldProductsCommand: - Refresh Connection To DB With Sold Products

        /// <summary>Refresh Connection To DB With Sold Products</summary>
        private LambdaCommand? _RefreshConnectionToDataBaseSoldProductsCommand;

        /// <summary>Refresh Connection To DB With Sold Products</summary>
        public ICommand RefreshConnectionToDataBaseSoldProductsCommand => _RefreshConnectionToDataBaseSoldProductsCommand ??= new(OnRefreshConnectionToDataBaseSoldProductsCommandExecuted);

        /// <summary>Логика выполнения - Refresh Connection To DB With Sold Products</summary>

        private void OnRefreshConnectionToDataBaseSoldProductsCommandExecuted(object? p)
        {
            OnLoadSoldProductsFromDbCommandExecuted(true);
            OnFilterSoldProductsCommandExecuted(true);

            WarehouseEventTextValue = $"Информация о проданной продукции из базы \"{ConnectionOptions.dbName}\" обновлена.";
            WarehouseEventIconValue = Icons.Name.Regular_CircleCheck.ToString();
            WarehouseEventIconColor = Color.LimeGreen.Name;

            //ToDo It's need to set variables values.

        }

        #endregion

        #region Command FilterSoldProductsCommand: - Filter "Sold Products" By Seted Parametrs

        /// <summary>Filter "Sold Products" By Seted Parametrs</summary>
        private LambdaCommand? _FilterSoldProductsCommand;

        /// <summary>Filter "Sold Products" By Seted Parametrs</summary>
        public ICommand FilterSoldProductsCommand => _FilterSoldProductsCommand ??= new(OnFilterSoldProductsCommandExecuted);

        /// <summary>Логика выполнения - Filter "Sold Products" By Seted Parametrs</summary>

        private void OnFilterSoldProductsCommandExecuted(object? p)
        {
            //ToDo It`s need To Debugged Icon View!

            if (AllSoldProducts is null)
            {
                WarehouseEventTextValue = "Список \"Загруженных продуктов\" равен NULL!";
                WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                WarehouseEventIconColor = Color.Red.Name;

                return;
            }

            if (!AllSoldProducts.Any())
            {
                WarehouseEventTextValue = "Список \"Загруженных продуктов\" не содержит элементы.";
                WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                WarehouseEventIconColor = Color.Red.Name;

                return;
            }

            IconFiltersTabControlInSoldProductsItemValue = Icons.Name.Solid_FilterCircleXmark.ToString();

            List<SoldProduct> resultList = [];

            foreach (SoldProduct product in AllSoldProducts)
            {
                resultList.Add(product);
            }
            FilteredSoldProducts = AllSoldProducts.ToList();

            //Filtering By Products Tittle
            if (!string.IsNullOrEmpty(FilterTittleForSoldProducts))
            {
                IconFiltersTabControlInSoldProductsItemValue = Icons.Name.Solid_Filter.ToString();

                FilteredSoldProducts = [];

                if (FiltersModeSelectForSoldFroducts)
                {
                    foreach (SoldProduct product in resultList)
                    {
                        if (product.Tittle.Contains(FilterTittleForSoldProducts))
                        {
                            FilteredSoldProducts.Add(product);
                        }
                    }
                }
                else
                {
                    foreach (SoldProduct product in resultList)
                    {
                        if (!product.Tittle.Contains(FilterTittleForSoldProducts))
                        {
                            FilteredSoldProducts.Add(product);
                        }
                    }
                }

                if (FilteredSoldProducts.Count == 0)
                {
                    WarehouseEventTextValue = $"Список не содержит продуктов с указанным \"Наименованием\".";
                    WarehouseEventIconValue = Icons.Name.Solid_CircleExclamation.ToString();
                    WarehouseEventIconColor = Color.Goldenrod.Name;
                    OnCalculateStatisticsSoldProductsCommandExecuted(true);

                    return;
                }

                resultList.Clear();

                foreach (SoldProduct product in FilteredSoldProducts)
                {
                    resultList.Add(product);
                }
            }

            //Filtering By Products Property
            if (!string.IsNullOrEmpty(FilterPropertyForSoldProducts))
            {
                IconFiltersTabControlInSoldProductsItemValue = Icons.Name.Solid_Filter.ToString();

                FilteredSoldProducts = [];

                if (FiltersModeSelectForSoldFroducts)
                {
                    foreach (SoldProduct product in resultList)
                    {
                        if (product.Property.Contains(FilterPropertyForSoldProducts))
                        {
                            FilteredSoldProducts.Add(product);
                        }
                    }
                }
                else
                {
                    foreach (SoldProduct product in resultList)
                    {
                        if (!product.Property.Contains(FilterPropertyForSoldProducts))
                        {
                            FilteredSoldProducts.Add(product);
                        }
                    }
                }

                if (FilteredSoldProducts.Count == 0)
                {
                    WarehouseEventTextValue = $"Список не содержит продуктов с указанным \"Типом\".";
                    WarehouseEventIconValue = Icons.Name.Solid_CircleExclamation.ToString();
                    WarehouseEventIconColor = Color.Goldenrod.Name;
                    OnCalculateStatisticsSoldProductsCommandExecuted(true);

                    return;
                }

                resultList.Clear();

                foreach (SoldProduct product in FilteredSoldProducts)
                {
                    resultList.Add(product);
                }
            }

            //Filtering By Sold Date Start













            //if (!string.IsNullOrEmpty(FilterReceiptDateStartForSoldProducts))
            //{
            //    IconFiltersTabControlInSoldItemValue = Icons.Name.Solid_Filter.ToString();

            //    FilteredWarehouseProducts = [];

            //    if (FilterReceiptDateStartForSoldProducts.Length != 10)
            //    {
            //        WarehouseEventTextValue = $"Значение фмльтра \"Дата поступления От:\" задано некорректно (дд.мм.гггг).";
            //        WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
            //        WarehouseEventIconColor = Color.Red.Name;

            //        return;
            //    }

            //    DateTime dt;
            //    if (!DateTime.TryParse(FilterReceiptDateStartForSoldProducts, out dt))
            //    {
            //        WarehouseEventTextValue = $"Значение фмльтра \"Дата поступления От:\" задано некорректно (дд.мм.гггг).";
            //        WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
            //        WarehouseEventIconColor = Color.Red.Name;

            //        return;
            //    }
            //    else
            //    {
            //        foreach (WarehouseProduct product in resultList)
            //        {
            //            if (product.ReceiptDate >= dt)
            //            {
            //                FilteredWarehouseProducts.Add(product);
            //            }
            //        }

            //        if (FilteredWarehouseProducts.Count == 0)
            //        {
            //            WarehouseEventTextValue = $"Список не содержит продуктов с указанным параметрами фильтра \"Дата поступления От:\".";
            //            WarehouseEventIconValue = Icons.Name.Solid_CircleExclamation.ToString();
            //            WarehouseEventIconColor = Color.Goldenrod.Name;
            //            OnCalculateStatisticsSoldProductsCommandExecuted(true);

            //            return;
            //        }

            //        resultList.Clear();
            //        foreach (WarehouseProduct product in FilteredWarehouseProducts)
            //        {
            //            resultList.Add(product);
            //        }

            //    }
            //}
            ////Filtering By Receipt Date Stop
            //if (!string.IsNullOrEmpty(FilterReceiptDateStopForSoldProducts))
            //{
            //    IconFiltersTabControlInSoldItemValue = Icons.Name.Solid_Filter.ToString();

            //    FilteredWarehouseProducts = [];

            //    if (FilterReceiptDateStopForSoldProducts.Length != 10)
            //    {
            //        WarehouseEventTextValue = $"Значение фмльтра \"Дата поступления До:\" задано некорректно (дд.мм.гггг).";
            //        WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
            //        WarehouseEventIconColor = Color.Red.Name;

            //        return;
            //    }

            //    DateTime dt;
            //    if (!DateTime.TryParse(FilterReceiptDateStopForSoldProducts, out dt))
            //    {
            //        WarehouseEventTextValue = $"Значение фмльтра \"Дата поступления До:\" задано некорректно (дд.мм.гггг).";
            //        WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
            //        WarehouseEventIconColor = Color.Red.Name;

            //        return;
            //    }
            //    else
            //    {
            //        foreach (WarehouseProduct product in resultList)
            //        {
            //            if (product.ReceiptDate <= dt)
            //            {
            //                FilteredWarehouseProducts.Add(product);
            //            }
            //        }

            //        if (FilteredWarehouseProducts.Count == 0)
            //        {
            //            WarehouseEventTextValue = $"Список не содержит продуктов с указанным параметрами фильтра \"Дата поступления До:\".";
            //            WarehouseEventIconValue = Icons.Name.Solid_CircleExclamation.ToString();
            //            WarehouseEventIconColor = Color.Goldenrod.Name;
            //            OnCalculateStatisticsSoldProductsCommandExecuted(true);

            //            return;
            //        }

            //        resultList.Clear();
            //        foreach (WarehouseProduct product in FilteredWarehouseProducts)
            //        {
            //            resultList.Add(product);
            //        }

            //    }
            //}

            ////Filtering By OrderNumber
            //List<string> productsOrdersNumbers = [];
            //foreach (WarehouseProduct wp in FilteredWarehouseProducts)
            //{
            //    if (wp.OrderNumber is null)
            //    {
            //        WarehouseEventTextValue = $"Значение \"Номер заказа:\" продукта их отфильтрованного списка задано некорректно.";
            //        WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
            //        WarehouseEventIconColor = Color.Red.Name;

            //        break;
            //    }

            //    productsOrdersNumbers.Add(wp.OrderNumber);
            //    productsOrdersNumbers.Sort();
            //    ListOfComboBoxOrderNumberPossibleValues = productsOrdersNumbers.Distinct().ToList();
            //}
            //if (!string.IsNullOrEmpty(FilterOrderNumberForSoldProducts))
            //{
            //    IconFiltersTabControlInSoldItemValue = Icons.Name.Solid_Filter.ToString();

            //    FilteredWarehouseProducts = [];

            //    if (FilterOrderNumberForSoldProducts is null)
            //    {
            //        WarehouseEventTextValue = $"Значение фильтра \"Номер заказа:\" равно NULL.";
            //        WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
            //        WarehouseEventIconColor = Color.Red.Name;

            //        return;
            //    }

            //    FilteredWarehouseProducts.AddRange(from WarehouseProduct product in resultList
            //                                       where product.OrderNumber.Contains(FilterOrderNumberForSoldProducts)
            //                                       select product);

            //    if (FilteredWarehouseProducts.Count == 0)
            //    {
            //        WarehouseEventTextValue = $"Список не содержит продуктов с указанным \"Номером заказа\".";
            //        WarehouseEventIconValue = Icons.Name.Solid_CircleExclamation.ToString();
            //        WarehouseEventIconColor = Color.Goldenrod.Name;
            //        OnCalculateStatisticsSoldProductsCommandExecuted(true);

            //        return;
            //    }

            //    resultList.Clear();
            //    foreach (WarehouseProduct product in FilteredWarehouseProducts)
            //    {
            //        resultList.Add(product);
            //    }
            //}

            ////Filtering By Products Note
            //if (!string.IsNullOrEmpty(FilterNoteForSoldProducts))
            //{
            //    IconFiltersTabControlInSoldItemValue = Icons.Name.Solid_Filter.ToString();

            //    FilteredWarehouseProducts = [];
            //    foreach (WarehouseProduct product in resultList)
            //    {
            //        if (product.Note.Contains(FilterNoteForSoldProducts))
            //        {
            //            FilteredWarehouseProducts.Add(product);
            //        }
            //    }

            //    if (FilteredWarehouseProducts.Count == 0)
            //    {
            //        WarehouseEventTextValue = $"Список не содержит продуктов с указанным \"Примечанием\".";
            //        WarehouseEventIconValue = Icons.Name.Solid_CircleExclamation.ToString();
            //        WarehouseEventIconColor = Color.Goldenrod.Name;
            //        OnCalculateStatisticsSoldProductsCommandExecuted(true);

            //        return;
            //    }
            //}

            WarehouseEventTextValue = $"Отфильтрованный список содержит {FilteredWarehouseProducts.Count.ToString()} продуктов.";
            WarehouseEventIconValue = Icons.Name.Regular_CircleCheck.ToString();
            WarehouseEventIconColor = Color.LimeGreen.Name;
        }

        #endregion

        #region Command CalculateStatisticsSoldProductsCommand: - Calculate Statistics About The List Of Sold Products After Filtering

        /// <summary>Calculate Statistics About The List Of Sold Products After Filtering</summary>
        private LambdaCommand? _CalculateStatisticsSoldProductsCommand;

        /// <summary>Calculate Statistics About The List Of Sold Products After Filtering</summary>
        public ICommand CalculateStatisticsSoldProductsCommand => _CalculateStatisticsSoldProductsCommand ??= new(OnCalculateStatisticsSoldProductsCommandExecuted);

        /// <summary>Логика выполнения - Calculate Statistics About The List Of Sold Products After Filtering</summary>

        private void OnCalculateStatisticsSoldProductsCommandExecuted(object? p)
        {
            // Null Check

            if (FilteredSoldProducts is null)
            {
                WarehouseEventTextValue = $"Cписок для рассчета \"Статистики\" равен NULL!";
                WarehouseEventIconValue = Icons.Name.Regular_CircleXmark.ToString();
                WarehouseEventIconColor = Color.Red.Name;

                //ValueOfTotalNumberOfProductsForSoldProducts = string.Empty;
                //ValueOfTotalPriceOfProductsForSoldProducts = string.Empty;


                return;
            }

            // Zero Check

            if (FilteredSoldProducts.Count == 0)
            {
                WarehouseEventTextValue = $"Cписок для рассчета \"Статистики\" не содержит значений.";
                WarehouseEventIconValue = Icons.Name.Solid_CircleExclamation.ToString();
                WarehouseEventIconColor = Color.Goldenrod.Name;

                //ValueOfTotalNumberOfProductsForSoldProducts = string.Empty;
                //ValueOfTotalPriceOfProductsForSoldProducts = string.Empty;
                return;
            }


            //ToDo It`s need To Implement.
        }

        #endregion


        #region Command PushButtonSelectFilterInFilterTabItemInSoldProductsItemCommand: - Push Button "Select" In Filters TabItem In Sold Products Item

        /// <summary>Push Button "Select" In Filters TabItem In Sold Products Item</summary>
        private LambdaCommand? _PushButtonSelectFilterInFilterTabItemInSoldProductsItemCommand;

        /// <summary>Push Button "Select" In Filters TabItem In Sold Products Item</summary>
        public ICommand PushButtonSelectFilterInFilterTabItemInSoldProductsItemCommand => _PushButtonSelectFilterInFilterTabItemInSoldProductsItemCommand ??= new(OnPushButtonSelectFilterInFilterTabItemInSoldProductsItemCommandExecuted);

        /// <summary>Логика выполнения - Push Button "Select" In Filters TabItem In Sold Products Item</summary>

        private void OnPushButtonSelectFilterInFilterTabItemInSoldProductsItemCommandExecuted(object? p)
        {
            FiltersModeSelectForSoldFroducts = true;
            ColorOfFillRectungleSelectFilterSoldProductsItem = Color.HotPink.Name;
            ColorOfFillRectungleCutFilterSoldProductsItem = Color.Pink.Name;
            OnFilterSoldProductsCommandExecuted(true);

        }

        #endregion
        #region Command PushButtonCutFilterInFilterTabItemInSoldProductsItemCommand: - Push Button "Cut" In Filters TabItem In Sold Products Item

        /// <summary>Push Button "Cut" In Filters TabItem In Sold Products Item</summary>
        private LambdaCommand? _PushButtonCutFilterInFilterTabItemInSoldProductsItemCommand;

        /// <summary>Push Button "Cut" In Filters TabItem In Sold Products Item</summary>
        public ICommand PushButtonCutFilterInFilterTabItemInSoldProductsItemCommand => _PushButtonCutFilterInFilterTabItemInSoldProductsItemCommand ??= new(OnPushButtonCutFilterInFilterTabItemInSoldProductsItemCommandExecuted);

        /// <summary>Логика выполнения - Push Button "Cut" In Filters TabItem In Sold Products Item</summary>

        private void OnPushButtonCutFilterInFilterTabItemInSoldProductsItemCommandExecuted(object? p)
        {
            FiltersModeSelectForSoldFroducts = false;
            ColorOfFillRectungleCutFilterSoldProductsItem = Color.HotPink.Name;
            ColorOfFillRectungleSelectFilterSoldProductsItem = Color.Pink.Name;
            OnFilterSoldProductsCommandExecuted(true);

        }

        #endregion
        #region Command PushButtonCancelFilterInFilterTabItemInSoldProductsItemCommand: - Push Button "Cancel" In Filters TabItem In Sold Products Item

        /// <summary>Push Button "Cancel" In Filters TabItem In Sold Products Item</summary>
        private LambdaCommand? _PushButtonCancelFilterInFilterTabItemInSoldProductsItemCommand;

        /// <summary>Push Button "Cancel" In Filters TabItem In Sold Products Item</summary>
        public ICommand PushButtonCancelFilterInFilterTabItemInSoldProductsItemCommand => _PushButtonCancelFilterInFilterTabItemInSoldProductsItemCommand ??= new(OnPushButtonCancelFilterInFilterTabItemInSoldProductsItemCommandExeCanceled);

        /// <summary>Логика выполнения - Push Button "Cancel" In Filters TabItem In Sold Products Item</summary>

        private void OnPushButtonCancelFilterInFilterTabItemInSoldProductsItemCommandExeCanceled(object? p)
        {
            FilterTittleForSoldProducts = string.Empty;
            FilterPropertyForSoldProducts = string.Empty;

            OnFilterSoldProductsCommandExecuted(true);

        }

        #endregion
        #region Command PushButtonCancelTittleFilterInFilterTabItemInSoldProductsItemCommand: - Push Button "Cancel Tittle Value" In Filters TabItem In Sold Products Item

        /// <summary>Push Button "Cancel Tittle Value" In Filters TabItem In Sold Products Item</summary>
        private LambdaCommand? _PushButtonCancelTittleFilterInFilterTabItemInSoldProductsItemCommand;

        /// <summary>Push Button "Cancel Tittle Value" In Filters TabItem In Sold Products Item</summary>
        public ICommand PushButtonCancelTittleFilterInFilterTabItemInSoldProductsItemCommand => _PushButtonCancelTittleFilterInFilterTabItemInSoldProductsItemCommand ??= new(OnPushButtonCancelTittleFilterInFilterTabItemInSoldProductsItemCommandExeCanceled);

        /// <summary>Логика выполнения - Push Button "Cancel Tittle Value" In Filters TabItem In Sold Products Item</summary>

        private void OnPushButtonCancelTittleFilterInFilterTabItemInSoldProductsItemCommandExeCanceled(object? p)
        {
            FilterTittleForSoldProducts = string.Empty;
            OnFilterSoldProductsCommandExecuted(true);

        }

        #endregion
        #region Command PushButtonCancelPropertyFilterInFilterTabItemInSoldProductsItemCommand: - Push Button "Cancel Property Value" In Filters TabItem In Sold Products Item

        /// <summary>Push Button "Cancel Property Value" In Filters TabItem In Sold Products Item</summary>
        private LambdaCommand? _PushButtonCancelPropertyFilterInFilterTabItemInSoldProductsItemCommand;

        /// <summary>Push Button "Cancel Property Value" In Filters TabItem In Sold Products Item</summary>
        public ICommand PushButtonCancelPropertyFilterInFilterTabItemInSoldProductsItemCommand => _PushButtonCancelPropertyFilterInFilterTabItemInSoldProductsItemCommand ??= new(OnPushButtonCancelPropertyFilterInFilterTabItemInSoldProductsItemCommandExeCanceled);

        /// <summary>Логика выполнения - Push Button "Cancel Property Value" In Filters TabItem In Sold Products Item</summary>

        private void OnPushButtonCancelPropertyFilterInFilterTabItemInSoldProductsItemCommandExeCanceled(object? p)
        {
            FilterPropertyForSoldProducts = string.Empty;
            OnFilterSoldProductsCommandExecuted(true);

        }

        #endregion



        #endregion
    }
}
