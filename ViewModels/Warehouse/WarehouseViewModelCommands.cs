using Inventory.Commands;
using Inventory.ViewModels.Base;
using System.Windows.Input;

namespace Inventory.ViewModels.Warehouse
{
    public partial class WarehouseViewModel : DialogViewModel
    {


		#region Command RefreshConnectionToDataBaseWarhouseWindowCommand: - Refresh Connection To BD With Products

		/// <summary>Refresh Connection To BD With Products</summary>
		private LambdaCommand? _RefreshConnectionToDataBaseWarhouseWindowCommand;

		/// <summary>Refresh Connection To BD With Products</summary>
		public ICommand RefreshConnectionToDataBaseWarhouseWindowCommand => _RefreshConnectionToDataBaseWarhouseWindowCommand ??= new(OnRefreshConnectionToDataBaseWarhouseWindowCommandExecuted);

		/// <summary>Логика выполнения - Refresh Connection To BD With Products</summary>

		private void OnRefreshConnectionToDataBaseWarhouseWindowCommandExecuted(object? p)
		{
			if (_DataBaseConnection is null)
			{
				return;
			}

            ItemSourseTest = _DataBaseConnection.LoadData();
			OnPropertyChanged();
        }



        #endregion

       

    }
}
