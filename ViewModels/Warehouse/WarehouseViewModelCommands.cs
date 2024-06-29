using Inventory.Commands;
using Inventory.ViewModels.Base;
using System.Runtime.CompilerServices;
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
			string sqlConnection = "Server=localhost; Port=5432; DataBase=Test_N; User Id=dinaster; Password=diM@$terPw_87;";

			
		}

		private void SqlConnectionReader()
		{
			
		}

		#endregion



	}
}
