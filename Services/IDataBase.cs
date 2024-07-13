using Inventory.Models;
using System.Data;

namespace Inventory.Services
{
    public interface IDataBase
    {

        public DataTable GetData(DBSettings dbSettings, string tableTittle);

        public Task UpdateRecord(DBSettings dbSettings, string tableTittle, string id, string oldValue, string newValue);

        
    }
}
