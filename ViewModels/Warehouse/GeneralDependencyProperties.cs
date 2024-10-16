﻿using Inventory.ViewModels.Base;
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

		#region LabelSoldDateProduct: - Label Value "Sold Date:" Of Product

		/// <summary>Label Value "Sold Date:" Of Product</summary>
		private string? _LabelSoldDateProduct;

		/// <summary>Label Value "Sold Date:" Of Product</summary>

		public string? LabelSoldDateProduct { get => _LabelSoldDateProduct; set => Set(ref _LabelSoldDateProduct, value); }

		#endregion

		#region LadelCustomerId: - Label Value "Customer Id"

		/// <summary>Label Value "Customer Id"</summary>
		private string? _LadelCustomerId;

		/// <summary>Label Value "Customer Id"</summary>

		public string? LadelCustomerId { get => _LadelCustomerId; set => Set(ref _LadelCustomerId, value); }

        #endregion

        #region LabelSelectProduct: - Label Value "Select" Of Product

        /// <summary>Label Value "Select" Of Product</summary>
        private string? _LabelSelectProduct;

        /// <summary>Label Value "Select" Of Product</summary>

        public string? LabelSelectProduct { get => _LabelSelectProduct; set => Set(ref _LabelSelectProduct, value); }

        #endregion

        #region LabelCutProduct: - Label Value "Cut" Of Product

        /// <summary>Label Value "Cut" Of Product</summary>
        private string? _LabelCutProduct;

        /// <summary>Label Value "Cut" Of Product</summary>

        public string? LabelCutProduct { get => _LabelCutProduct; set => Set(ref _LabelCutProduct, value); }

        #endregion

        #region LabelCancel: - Label Value "Cancel"  

        /// <summary>Label Value "Cancel"  </summary>
        private string? _LabelCancel;

        /// <summary>Label Value "Cancel"  </summary>

        public string? LabelCancel { get => _LabelCancel; set => Set(ref _LabelCancel, value); }

        #endregion

        #region LabelStatistics: - Label Value "Statistics"  

        /// <summary>Label Value "Statistics"  </summary>
        private string? _LabelStatistics;

        /// <summary>Label Value "Statistics"  </summary>

        public string? LabelStatistics { get => _LabelStatistics; set => Set(ref _LabelStatistics, value); }

        #endregion

        #region TextValueTotalNumberOfProducts: - Value Of Text "Total Number Of Products"

        /// <summary>Value Of Text "Total Number Of Products"</summary>
        private string? _TextValueTotalNumberOfProducts;

        /// <summary>Value Of Text "Total Number Of Products"</summary>

        public string? TextValueTotalNumberOfProducts { get => _TextValueTotalNumberOfProducts; set => Set(ref _TextValueTotalNumberOfProducts, value); }

        #endregion

        #region TextValueTotalPriceOfProducts: - Value Of Text "Total Price Of Products"

        /// <summary>Value Of Text "Total Price Of Products"</summary>
        private string? _TextValueTotalPriceOfProducts;

        /// <summary>Value Of Text "Total Price Of Products"</summary>

        public string? TextValueTotalPriceOfProducts { get => _TextValueTotalPriceOfProducts; set => Set(ref _TextValueTotalPriceOfProducts, value); }

        #endregion

        #region TextValueFullPriceOfProducts: - Value Of Text "Full Price Of Products"

        /// <summary>Value Of Text "Full Price Of Products"</summary>
        private string? _TextValueFullPriceOfProducts;

        /// <summary>Value Of Text "Full Price Of Products"</summary>

        public string? TextValueFullPriceOfProducts { get => _TextValueFullPriceOfProducts; set => Set(ref _TextValueFullPriceOfProducts, value); }

        #endregion


        #region TextValueTotalCostOfProducts: - Value Of Text "Total Cost Of Products"

        /// <summary>Value Of Text "Total Cost Of Products"</summary>
        private string? _TextValueTotalCostOfProducts;

        /// <summary>Value Of Text "Total Cost Of Products"</summary>

        public string? TextValueTotalCostOfProducts { get => _TextValueTotalCostOfProducts; set => Set(ref _TextValueTotalCostOfProducts, value); }

        #endregion

    }
}
