using Inventory.Models;
using Inventory.ViewModels.Base;
using System.Data;

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

        #region SoldProducts: - Products On Sold List

        /// <summary>Products On Sold List</summary>
        private IEnumerable<SoldProduct>? _SoldProducts;

        /// <summary>Products On Sold List</summary>

        public IEnumerable<SoldProduct>? SoldProducts { get => _SoldProducts; set => Set(ref _SoldProducts, value); }

        #endregion

        #region SelectedSoldProduct: - Selected Sold Product

        /// <summary>Selected Sold Product</summary>
        private SoldProduct? _SelectedSoldProduct;

        /// <summary>Selected Sold Product</summary>

        public SoldProduct? SelectedSoldProduct { get => _SelectedSoldProduct; set => Set(ref _SelectedSoldProduct, value); }

        #endregion

        //I am Here.





        #endregion

        #region Commands

        #endregion
    }
}
