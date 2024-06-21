using Inventory.ViewModels.Base;

namespace Inventory.ViewModels.MainWindowViewModel
{

    public partial class MainWindowViewModel : DialogViewModel
    {

		#region NameOfInventoryWindow: - Name Of "Inventory Window"

		/// <summary>Name Of "Inventory Window"</summary>
		private string? _NameOfInventoryWindow;

		/// <summary>Name Of "Inventory Window"</summary>

		public string? NameOfInventoryWindow { get => _NameOfInventoryWindow; set => Set(ref _NameOfInventoryWindow, value); }

		#endregion







	}

}
