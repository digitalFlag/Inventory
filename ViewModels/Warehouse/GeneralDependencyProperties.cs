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

		#region LabelPropertyProduct: - Label "Property:" Of Product

		/// <summary>Label "Property:" Of Product</summary>
		private string? _LabelPropertyProduct;

		/// <summary>Label "Property:" Of Product</summary>

		public string? LabelPropertyProduct { get => _LabelPropertyProduct; set => Set(ref _LabelPropertyProduct, value); }

		#endregion







	}
}
