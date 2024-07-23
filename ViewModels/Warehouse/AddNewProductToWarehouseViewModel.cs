using Inventory.ViewModels.Base;

namespace Inventory.ViewModels.Warehouse
{
    public partial class WarehouseViewModel : DialogViewModel
    {
		#region Dependencies


		#region LabalValueTittleOfProductAddNewToWarehouse: - Label Value "Tittle" At Panel Add Product To Warehouse

		/// <summary>Label Value "Tittle" At Panel Add Product To Warehouse</summary>
		private string? _LabalValueTittleOfProductAddNewToWarehouse;

		/// <summary>Label Value "Tittle" At Panel Add Product To Warehouse</summary>

		public string? LabalValueTittleOfProductAddNewToWarehouse { get => _LabalValueTittleOfProductAddNewToWarehouse; set => Set(ref _LabalValueTittleOfProductAddNewToWarehouse, value); }

        #endregion




		#region TittleProductAddNewToWarehouse: - "Tittle" Of Product That Is Adding To Warehouse

		/// <summary>"Tittle" Of Product That Is Adding To Warehouse</summary>
		private string? _TittleProductAddNewToWarehouse;

		/// <summary>"Tittle" Of Product That Is Adding To Warehouse</summary>

		public string? TittleProductAddNewToWarehouse { get => _TittleProductAddNewToWarehouse; set => Set(ref _TittleProductAddNewToWarehouse, value); }

		#endregion
		#region BorderColorTittleAddNewWarehouse: - Border Color Of Text Box "Tittle" Add New Product To Warehouse

		/// <summary>Border Color Of Text Box "Tittle" Add New Product To Warehouse</summary>
		private string? _BorderColorTittleAddNewWarehouse;

		/// <summary>Border Color Of Text Box "Tittle" Add New Product To Warehouse</summary>

		public string? BorderColorTittleAddNewWarehouse { get => _BorderColorTittleAddNewWarehouse; set => Set(ref _BorderColorTittleAddNewWarehouse, value); }

		#endregion



		#endregion


		#region Commands
		#endregion
	}
}
