using System.Data;

namespace Inventory.Services
{
    public interface IDataBaseConnection
    {
        DataTable LoadData();
    }
}
