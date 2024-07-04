using System.Data;

namespace Inventory.Services
{
    public interface IDataBaseConnection
    {
        DataTable LoadDataFromTable(string server, string port, string dataBase, string userId, string password, string table);
    }
}

