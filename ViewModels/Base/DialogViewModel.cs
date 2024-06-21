namespace Inventory.ViewModels.Base
{
    public class DialogViewModel : ViewModel
    {
        public event EventHandler? DialogComplete;

        protected virtual void OnDialogComplete(EventArgs e) => DialogComplete?.Invoke(this, e);

    }
}
