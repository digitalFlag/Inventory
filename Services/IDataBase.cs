namespace Inventory.Services
{
    public interface IDataBase
    {
        void Update(string server, string port, string dataBase, string userId, string password, string table);
    }
}
