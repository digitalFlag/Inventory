using Inventory.Models;

namespace Inventory.Services
{
    public interface IDataBase
    {
        void Connect( DBSettings dbSettings);


        void Update(string server, string port, string dataBase, string userId, string password, string table);

        
    }
}
