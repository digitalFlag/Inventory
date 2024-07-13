using Inventory.Models;

namespace Inventory.Services
{
    public interface IDataBase
    {
        public void OpenConnection(DBSettings dbSettings);


        public void Update(string server, string port, string dataBase, string userId, string password, string table);

        
    }
}
