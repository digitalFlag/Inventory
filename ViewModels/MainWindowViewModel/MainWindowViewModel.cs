using Inventory.Services;
using Inventory.ViewModels.Base;

namespace Inventory.ViewModels.MainWindowViewModel
{
    public partial class MainWindowViewModel : DialogViewModel
    {
        private readonly IUserDialog? _UserDialog = null;


        public MainWindowViewModel()
        {
            //Start values
            NameOfInventoryWindow = "Ассистент";

            RepositoryItemMainMenuOfMainWindow = "Разделы";
            WarehousrRepositoryMainMenuMainWindow = "Мини-Склад";

        }

        public MainWindowViewModel(IUserDialog UserDialog) : this()
        {

            _UserDialog = UserDialog;

        }

    }

}
