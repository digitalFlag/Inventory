using Inventory.Commands;
using Inventory.ViewModels.Base;
using System.Windows.Input;

namespace Inventory.ViewModels.MainWindowViewModel
{
    public partial class MainWindowViewModel : DialogViewModel
    {

		#region Command OpenWarehouseWindowCommand: - Open Window "Warehouse"

		/// <summary>Open Window "Warehouse"</summary>
		private LambdaCommand? _OpenWarehouseWindowCommand;

		/// <summary>Open Window "Warehouse"</summary>
		public ICommand OpenWarehouseWindowCommand => _OpenWarehouseWindowCommand ??= new(OnOpenWarehouseWindowCommandExecuted);

		/// <summary>Логика выполнения - Open Window "Warehouse"</summary>

		private void OnOpenWarehouseWindowCommandExecuted(object? p)
		{
			if (_UserDialog is null)
			{
				return;
			}

			_UserDialog.OpenWarehouseWindow();

        }

		#endregion

	}

}
