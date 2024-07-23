using Inventory.ViewModels.Base;

namespace Inventory.ViewModels.Warehouse
{
    public partial class WarehouseViewModel : DialogViewModel
    {

		#region LabelTittleProduct: - Label Value "Tittle" Of Product

		/// <summary>Label Value "Tittle" Of Product</summary>
		private string? _LabelTittleProduct;

		/// <summary>Label Value "Tittle" Of Product</summary>

		public string? LabelTittleProduct { get => _LabelTittleProduct; set => Set(ref _LabelTittleProduct, value); }

		#endregion

		#region name: - description

		/// <summary>description</summary>
		private string? _name;

		/// <summary>description</summary>

		public string? name { get => _name; set => Set(ref _name, value); }

		#endregion




	}
}
