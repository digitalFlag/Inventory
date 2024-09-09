using Inventory.ViewModels.Base;
using System.Reflection.Emit;

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

		#region LabelSizeProduct: - Label "Size:" Of Product

		/// <summary>Label "Size:" Of Product</summary>
		private string? _LabelSizeProduct;

		/// <summary>Label "Size:" Of Product</summary>

		public string? LabelSizeProduct { get => _LabelSizeProduct; set => Set(ref _LabelSizeProduct, value); }

		#endregion

		#region LabelExpirationDateProduct: - Label Value "Expiration Date" Of Product

		/// <summary>Label Value "Expiration Date" Of Product</summary>
		private string? _LabelExpirationDateProduct;

		/// <summary>Label Value "Expiration Date" Of Product</summary>

		public string? LabelExpirationDateProduct { get => _LabelExpirationDateProduct; set => Set(ref _LabelExpirationDateProduct, value); }

		#endregion

		#region LabelPurchaseCostProduct: - Label Value "Purcase Cost" Of Product

		/// <summary>Label Value "Purcase Cost" Of Product</summary>
		private string? _LabelPurchaseCostProduct;

		/// <summary>Label Value "Purcase Cost" Of Product</summary>

		public string? LabelPurchaseCostProduct { get => _LabelPurchaseCostProduct; set => Set(ref _LabelPurchaseCostProduct, value); }

		#endregion

		#region LabelLocationProduct: - Label Value "Location:" Of Product

		/// <summary>Label Value "Location:" Of Product</summary>
		private string? _LabelLocationProduct;

		/// <summary>Label Value "Location:" Of Product</summary>

		public string? LabelLocationProduct { get => _LabelLocationProduct; set => Set(ref _LabelLocationProduct, value); }

		#endregion

		#region LabelReceiptDateProduct: - Label Value "Receipt Date:" Of Product

		/// <summary>Label Value "Receipt Date:" Of Product</summary>
		private string? _LabelReceiptDateProduct;

		/// <summary>Label Value "Receipt Date:" Of Product</summary>

		public string? LabelReceiptDateProduct { get => _LabelReceiptDateProduct; set => Set(ref _LabelReceiptDateProduct, value); }

		#endregion

		#region LabelOrderNumberProduct: - Label Value "Order Number:" Of Product

		/// <summary>Label Value "Order Number:" Of Product</summary>
		private string? _LabelOrderNumberProduct;

		/// <summary>Label Value "Order Number:" Of Product</summary>

		public string? LabelOrderNumberProduct { get => _LabelOrderNumberProduct; set => Set(ref _LabelOrderNumberProduct, value); }

		#endregion

		#region LabelNoteProduct: - Label Value "Note:" Of Product

		/// <summary>Label Value "Note:" Of Product</summary>
		private string? _LabelNoteProduct;

		/// <summary>Label Value "Note:" Of Product</summary>

		public string? LabelNoteProduct { get => _LabelNoteProduct; set => Set(ref _LabelNoteProduct, value); }

		#endregion

		#region LabelIdProduct: - Label Value "Id:" Of Product

		/// <summary>Label Value "Id:" Of Product</summary>
		private string? _LabelIdProduct;

		/// <summary>Label Value "Id:" Of Product</summary>

		public string? LabelIdProduct { get => _LabelIdProduct; set => Set(ref _LabelIdProduct, value); }

		#endregion

		#region LabelSoldCostProduct: - Label Value "Sold Cost:" Of Product

		/// <summary>Label Value "Sold Cost:" Of Product</summary>
		private string? _LabelSoldCostProduct;

		/// <summary>Label Value "Sold Cost:" Of Product</summary>

		public string? LabelSoldCostProduct { get => _LabelSoldCostProduct; set => Set(ref _LabelSoldCostProduct, value); }

		#endregion


	}
}
