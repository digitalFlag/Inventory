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

		//Main Menu
		#region RepositoryItemMainMenuOfMainWindow: - Item "Repositoriy" -> "Main Menu" -> "Main Window"

		/// <summary>Item "Repositoriy" -> "Main Menu" -> "Main Window"</summary>
		private string? _RepositoryItemMainMenuOfMainWindow;

		/// <summary>Item "Repositoriy" -> "Main Menu" -> "Main Window"</summary>

		public string? RepositoryItemMainMenuOfMainWindow { get => _RepositoryItemMainMenuOfMainWindow; set => Set(ref _RepositoryItemMainMenuOfMainWindow, value); }

        #endregion

		#region WarehousrRepositoryMainMenuMainWindow: - Item "Warehouse" -> "Repository" -> "MainMenu" -> "Main Window"

		/// <summary>Item "Warehouse" -> "Repository" -> "MainMenu" -> "Main Window"</summary>
		private string? _WarehousrRepositoryMainMenuMainWindow;

		/// <summary>Item "Warehouse" -> "Repository" -> "MainMenu" -> "Main Window"</summary>

		public string? WarehousrRepositoryMainMenuMainWindow { get => _WarehousrRepositoryMainMenuMainWindow; set => Set(ref _WarehousrRepositoryMainMenuMainWindow, value); }

		#endregion










	}

}
