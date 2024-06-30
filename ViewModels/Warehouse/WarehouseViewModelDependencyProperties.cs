using Inventory.Models;
using Inventory.ViewModels.Base;
using System.Collections.ObjectModel;
using System.Data;

namespace Inventory.ViewModels.Warehouse
{
    public partial class WarehouseViewModel : DialogViewModel
    {
        //Test

        #region ItemSourseTest: - IS Test

        /// <summary>IS Test</summary>
        private DataTable? _ItemSourseTest;

        /// <summary>IS Test</summary>

        public DataTable? ItemSourseTest { get => _ItemSourseTest; set => Set(ref _ItemSourseTest, value); }

        #endregion



        #region NameOfWarhouseWindow: - Name Of "Warehouse Window"

        /// <summary>Name Of "Warehouse Window"</summary>
        private string? _NameOfWarhouseWindow;

        /// <summary>Name Of "Warehouse Window"</summary>

        public string? NameOfWarhouseWindow { get => _NameOfWarhouseWindow; set => Set(ref _NameOfWarhouseWindow, value); }

        #endregion

        //Main Menu

        #region ConnectionItemMainMenuWarehouseWindow: - Item "Connection -> "Main Menu" -> "Warehouse Window""

        /// <summary>Item "Connection -> "Main Menu" -> "Warehouse Window""</summary>
        private string? _ConnectionItemMainMenuWarehouseWindow;

        /// <summary>Item "Connection -> "Main Menu" -> "Warehouse Window""</summary>

        public string? ConnectionItemMainMenuWarehouseWindow { get => _ConnectionItemMainMenuWarehouseWindow; set => Set(ref _ConnectionItemMainMenuWarehouseWindow, value); }

        #endregion


        #region RefreshItemConnectionMainMenuWarehouseWindow: - Item "Refresh" -> "Connection" -> "Main Menu" -> "Warehouse Window"

        /// <summary>Item "Refresh" -> "Connection" -> "Main Menu" -> "Warehouse Window"</summary>
        private string? _RefreshItemConnectionMainMenuWarehouseWindow;

        /// <summary>Item "Refresh" -> "Connection" -> "Main Menu" -> "Warehouse Window"</summary>

        public string? RefreshItemConnectionMainMenuWarehouseWindow { get => _RefreshItemConnectionMainMenuWarehouseWindow; set => Set(ref _RefreshItemConnectionMainMenuWarehouseWindow, value); }

        #endregion



    }
}
